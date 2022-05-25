using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;

namespace PasswordGenerator
{
    internal class SqlConnection
    {
        public void LoadToSqlpasswd(LoginPassword logpass)
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source = password.db;Version=3;"))
            {
                connection.Open();
                SQLiteCommand com = connection.CreateCommand();
                com.CommandText = $"Insert into Passwd_generation(ID,login,password) values(@id,@login,@password)";
                com.Parameters.Add("@id", DbType.Int32).Value = logpass.Id;
                com.Parameters.Add("@login", DbType.String).Value = logpass.Login;
                com.Parameters.Add("@password", DbType.String).Value = logpass.Password;
                com.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void LoadImageToSql(ImagePassword imgpas)
        {
            MemoryStream ms = new MemoryStream();
            imgpas.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            SQLiteConnection con = new SQLiteConnection("Data Source=password.db;Version=3;");
            con.Open();
            SQLiteCommand com = new SQLiteCommand("insert into Image_password(id,image,password) values(@id,@photo,@password)", con);
            com.Parameters.Add("@photo", DbType.Binary, 10000).Value = ms.ToArray();
            com.Parameters.Add("@id", DbType.Int32).Value = imgpas.Id;
            com.Parameters.Add("@password", DbType.String).Value = imgpas.Password;
            com.ExecuteNonQuery();
            con.Close();
        }
        public void DeleteImageFromSql(ImagePassword imgpas)
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source = password.db;Version=3;"))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "Delete from Image_password where Id=@id";
                command.Parameters.Add("@id", System.Data.DbType.Int32).Value = imgpas.Id;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void DeletePassFromSql(LoginPassword logpass)
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source = password.db;Version=3;"))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "Delete from Passwd_generation where Id=@id";
                command.Parameters.Add("@id", System.Data.DbType.Int32).Value = logpass.Id;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void LoadImageFromSql(List<ImagePassword> imagePasswords)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=password.db;Version=3;");
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Image_password", con);
            con.Open();
            SQLiteDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (!dr.IsDBNull(0))
                {
                    byte[] im = (byte[])dr["image"];
                    MemoryStream ms = new MemoryStream(im);
                    Bitmap bitmap = new Bitmap(ms);
                    imagePasswords.Add(new ImagePassword((int)dr.GetInt64(0), dr.GetValue(2).ToString(), bitmap, false));
                }
            }
            con.Close();
        }
        public void LoadPassFromSql()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=password.db;Version=3;");
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Passwd_generation", con);
            con.Open();
            SQLiteDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (!dr.IsDBNull(0))
                {
                    PasswordGenerator.LoadedPasswords.Add(new LoginPassword((int)dr.GetInt64(0), dr.GetValue(1).ToString(), dr.GetValue(2).ToString()));
                }
            }
            con.Close();
        }
    }
}
