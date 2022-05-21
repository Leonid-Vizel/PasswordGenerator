using System.Text;

namespace PasswordGenerator
{
    public class LoginPassword
    {
        public int Id { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }

        public LoginPassword(int id, string login, string password)
        {
            Id = id;
            Login = login;
            Password = password;
            decrypt = null;
        }

        public override string ToString()
        {
            string decrypted = Decrypt();
            StringBuilder passBuilder = new StringBuilder();
            for (int i = 0; i < decrypted.Length; i++)
            {
                passBuilder.Append('*');
            }
            return passBuilder.ToString();
        }

        private string decrypt;

        public string Decrypt()
        {
            if (decrypt == null)
            {
                decrypt = Algorythms.DecryptString(Password, Login);
            }
            return decrypt;
        }
    }
}
