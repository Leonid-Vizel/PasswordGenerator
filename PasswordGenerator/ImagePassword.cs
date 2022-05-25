using System.Drawing;
using System.IO;
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

        public SendPasswordImageInfo ToSendInfo()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return new SendPasswordImageInfo()
                {
                    Id = Id,
                    Password = Password,
                    ImageBytes = stream.ToArray()
                };
            }
        }

        public static ImagePassword FromSendInfo(SendPasswordImageInfo info, int newId)
        {
            Bitmap initial = null;
            using (MemoryStream stream = new MemoryStream(info.ImageBytes))
            {
                initial = new Bitmap(stream);
            }
            if (initial == null)
            {
                return null;
            }
            string decrypted = Algorythms.DecryptString(info.Password, (initial.Width + initial.Height + info.Id).ToString());
            return new ImagePassword(newId, decrypted, initial);
        }
    }
}
