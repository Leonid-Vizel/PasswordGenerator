using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Media.Imaging;

namespace PasswordGenerator
{
    internal class SqlConnector
    {
        private static string connectionString = "Data Source = password.db;Version=3;";

        public static long AddToBase(LoginPassword logpass)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand("Insert into Passwd_generation(login,password) values(@login,@password)", connection))
                {
                    command.Parameters.Add("@login", DbType.String).Value = logpass.Login;
                    command.Parameters.Add("@password", DbType.String).Value = logpass.Password;
                    command.ExecuteNonQuery();
                    return connection.LastInsertRowId;
                }
            }
        }

        public static long AddToBase(ImagePassword imgpas)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                byte[] imageBytes = null;
                GifBitmapEncoder encoder = new GifBitmapEncoder();
                using (MemoryStream ms = new MemoryStream())
                {
                    imgpas.Image.Save(ms, ImageFormat.Png);
                    imageBytes = ms.ToArray();
                }
                using (SQLiteCommand command = new SQLiteCommand("INSERT INTO Image_password(image,password) VALUES(@photo,@password);", connection))
                    {
                        command.Parameters.Add("@photo", DbType.Binary, 10000).Value = imageBytes;
                        command.Parameters.Add("@password", DbType.String).Value = imgpas.Password;
                        command.ExecuteNonQuery();
                        return connection.LastInsertRowId;
                    }
            }
        }

        public static void DeleteFromBase(ImagePassword imgpas)
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

        public static void DeleteFromBase(LoginPassword logpass)
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

        public static List<LoginPassword> FindPasswordWithLogin(string login)
        {
            List<LoginPassword> passwords = new List<LoginPassword>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM Passwd_generation WHERE login = @login;", connection))
                {
                    command.Parameters.Add("@login", DbType.String).Value = login;
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                passwords.Add(new LoginPassword(
                                        (int)reader.GetInt64(0),
                                        reader.GetValue(1).ToString(),
                                        reader.GetValue(2).ToString()));
                            }
                        }
                    }
                }
            }
            return passwords;
        }

        public static List<ImagePassword> LoadImagesFromBase()
        {
            List<ImagePassword> imagePasswords = new List<ImagePassword>();
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
                                    var a = (byte[])reader["image"];
                                    using (MemoryStream memoryStream = new MemoryStream((byte[])reader["image"]))
                                    {
                                        imagePasswords.Add(new ImagePassword(
                                                (int)reader.GetInt64(0),
                                                reader.GetValue(2).ToString(),
                                                Image.FromStream(memoryStream),
                                                false));
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return imagePasswords;
        }

        public static List<LoginPassword> LoadPasswordsFromBase()
        {
            List<LoginPassword> passwords = new List<LoginPassword>();
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
                                passwords.Add(new LoginPassword(
                                        (int)reader.GetInt64(0),
                                        reader.GetValue(1).ToString(),
                                        reader.GetValue(2).ToString()));
                            }
                        }
                    }
                }
            }
            return passwords;
        }
    }
}
