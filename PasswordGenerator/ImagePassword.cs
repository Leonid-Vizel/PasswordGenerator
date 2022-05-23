using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public class ImagePassword
    {
        public Bitmap Image { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }

        public ImagePassword(int id, string password, Bitmap image)
        {
            Id = id;
            Image = image;
            Password = Algorythms.EncryptString(password, (Id + Image.Width + Image.Height).ToString());
        }

        public override string ToString()
        {
            StringBuilder passBuilder = new StringBuilder();
            string decrypted = Decrypt();
            for (int i = 0; i < decrypted.Length; i++)
            {
                passBuilder.Append('*');
            }
            return passBuilder.ToString();
        }

        public Panel Panel { get; set; }

        private string decrypt;

        public string Decrypt()
        {
            if (decrypt == null)
            {
                decrypt = Algorythms.DecryptString(Password, (Id + Image.Width + Image.Height).ToString());
            }
            return decrypt;
        }
    }
}
