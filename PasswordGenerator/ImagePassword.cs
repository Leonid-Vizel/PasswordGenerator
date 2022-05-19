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
            Password = password;
            Image = image;
        }

        public override string ToString()
        {
            StringBuilder passBuilder = new StringBuilder();
            for (int i = 0; i < Password.Length; i++)
            {
                passBuilder.Append('*');
            }
            return passBuilder.ToString();
        }

        public Panel Panel { get; set; }
    }
}
