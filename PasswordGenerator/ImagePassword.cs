using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public class ImagePassword
    {
        public long Id { get; set; }
        public Image Image { get; private set; }
        public string Password { get; private set; }

        public ImagePassword(long id, string password, Image image, bool encrypt = true)
        {
            Id = id;
            Image = image;
            if (encrypt)
            {
                Password = Algorythms.EncryptString(password, (Id + Image.Width + Image.Height).ToString());
            }
            else
            {
                Password = password;
            }
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
                decrypt = Algorythms.DecryptString(Password, (Image.Width + Image.Height).ToString());
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

        public static ImagePassword FromSendInfo(SendPasswordImageInfo info)
        {
            Bitmap initial = null;
            using (MemoryStream stream = new MemoryStream(info.ImageBytes))
            {
                initial = new Bitmap(stream);
            }
            return new ImagePassword(info.Id, info.Password, initial, false);
        }
    }
}
