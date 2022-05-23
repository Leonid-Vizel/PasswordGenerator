
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PasswordGenerator
{
    internal class SqlConnection
    {
       
        public void LoadToSqlpasswd(LoginPassword logpass)
        {
             
             using (SQLiteConnection connection = new SQLiteConnection("Data Source = password.db;Version=3;"))
             {
                connection.Open();
                SqliteCommand com = new SqliteCommand($"Insert into Passwd_generation(ID,login,password) values(@id,@login,@password)");
                com.Parameters.Add("@id", (SqliteType)DbType.Int32).Value = logpass.Id;
                com.Parameters.Add("@login", (SqliteType)DbType.String).Value = logpass.Login;
                com.Parameters.Add("@password", (SqliteType)DbType.String).Value = logpass.Password;
                com.ExecuteNonQuery();
                connection.Close();
             }
        }
        public void LoadImageToSql(ImagePassword imgpas)
        {    
            MemoryStream ms = new MemoryStream(); 
            SqliteConnection con = new SqliteConnection("Data Source=password.db;Version=3;");
            con.Open();
            SqliteCommand com = new SqliteCommand("insert into Image_password(id,image,password) values(@id,@photo,@password)", con);
            com.Parameters.Add("@photo", (SqliteType)DbType.Binary, 10000).Value =imgpas.Image ;
            com.Parameters.Add("@id", (SqliteType)DbType.Int32).Value =imgpas.Id;
            com.Parameters.Add("@password", (SqliteType)DbType.String).Value =imgpas.Password;
            com.ExecuteNonQuery();
            con.Close();

        }
    }
}
