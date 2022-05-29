using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;

namespace PasswordGenerator
{
    internal class SqlConnector
    {
        private static string connectionString = "Data Source = password.db;Version=3;";

        public static void LoadToSqlpasswd(LoginPassword logpass)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand("Insert into Passwd_generation(ID,login,password) values(@id,@login,@password)", connection))
                {
                    command.Parameters.Add("@id", DbType.Int32).Value = logpass.Id;
                    command.Parameters.Add("@login", DbType.String).Value = logpass.Login;
                    command.Parameters.Add("@password", DbType.String).Value = logpass.Password;
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void LoadImageToSql(ImagePassword imgpas)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                byte[] imageBytes = null;
                using (MemoryStream ms = new MemoryStream())
                {
                    imgpas.Image.Save(ms, imgpas.Image.RawFormat);
                    imageBytes = ms.ToArray();
                }
                using (SQLiteCommand command = new SQLiteCommand("INSERT INTO Image_password(id,image,password) VALUES(@id,@photo,@password);", connection))
                {
                    command.Parameters.Add("@photo", DbType.Binary, 10000).Value = imageBytes;
                    command.Parameters.Add("@id", DbType.Int32).Value = imgpas.Id;
                    command.Parameters.Add("@password", DbType.String).Value = imgpas.Password;
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void DeleteImageFromSql(ImagePassword imgpas)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand("DELETE FROM Image_password WHERE Id=@id;", connection))
                {
                    command.Parameters.Add("@id", DbType.Int32).Value = imgpas.Id;
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void DeletePassFromSql(LoginPassword logpass)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand("DELETE FROM Passwd_generation WHERE Id=@id;", connection))
                {
                    command.Parameters.Add("@id", DbType.Int32).Value = logpass.Id;
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void LoadImageFromSql(List<ImagePassword> imagePasswords)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM Image_password;", connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    using (MemoryStream memoryStream = new MemoryStream((byte[])reader["image"]))
                                    {
                                        imagePasswords.Add(new ImagePassword(
                                                (int)reader.GetInt64(0),
                                                reader.GetValue(2).ToString(),
                                                new Bitmap(memoryStream),
                                                false));
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        public static void LoadPassFromSql()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM Passwd_generation;", connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                PasswordGenerator.LoadedPasswords.Add(new LoginPassword(
                                        (int)reader.GetInt64(0),
                                        reader.GetValue(1).ToString(),
                                        reader.GetValue(2).ToString()));
                            }
                        }
                    }
                }
            }
        }
    }
}
