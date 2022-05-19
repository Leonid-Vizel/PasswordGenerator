using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PasswordGenerator.Forms
{
    public partial class SavedPasswordsForm : Form
    {
        public string Result { get; set; }
        public SavedPasswordsForm()
        {
            InitializeComponent();
        }

        private void OnSearchClick(object sender, EventArgs e)
        {
            if (searchBox.Text.Length == 0)
            {
                MessageBox.Show("Укажите логин по которому искать!","Ошибка");
                return;
            }
            workPanel.Controls.Clear();
            foreach (LoginPassword password in PasswordGenerator.LoadedPasswords.Where(x=>x.Login.ToLower().Equals(searchBox.Text.ToLower())))
            {
                Panel panel = new Panel();
                panel.BackColor = ColorTranslator.FromHtml((string)Tag);
                panel.Dock = DockStyle.Top;
                panel.Size = new Size(0, 34);
                #region Label
                Label passLabel = new Label();
                passLabel.Dock = DockStyle.Fill;
                passLabel.TextAlign = ContentAlignment.MiddleLeft;
                passLabel.Text = $"Логин: {password.Login} Пароль: {password}";
                passLabel.Size = new Size(100,0);
                panel.Controls.Add(passLabel);
                #endregion
                #region Eye
                IconButton eyeButton = new IconButton();
                eyeButton.IconChar = IconChar.Eye;
                eyeButton.IconSize = 34;
                eyeButton.Click += (object senderObj, EventArgs arg) =>
                {
                    if (eyeButton.IconChar == IconChar.Eye)
                    {
                        passLabel.Text = $"Логин: {password.Login} Пароль: {password.Decrypt()}";
                        eyeButton.IconChar = IconChar.EyeSlash;
                    }
                    else
                    {
                        passLabel.Text = $"Логин: {password.Login} Пароль: {password}";
                        eyeButton.IconChar = IconChar.Eye;
                    }
                };
                eyeButton.Size = new Size(34, 34);
                eyeButton.FlatStyle = FlatStyle.Flat;
                eyeButton.FlatAppearance.BorderSize = 0;
                eyeButton.Dock = DockStyle.Right;
                panel.Controls.Add(eyeButton);
                #endregion
                #region Copy
                IconButton copyButton = new IconButton();
                copyButton.IconChar = IconChar.Copy;
                copyButton.IconSize = 34;
                copyButton.Click += (object senderObj, EventArgs arg) =>
                {
                    string descrypted = password.Decrypt();
                    if (descrypted.Length > 0)
                    {
                        Clipboard.SetText(descrypted);
                    }
                };
                copyButton.Size = new Size(34, 34);
                copyButton.FlatStyle = FlatStyle.Flat;
                copyButton.FlatAppearance.BorderSize = 0;
                copyButton.Dock = DockStyle.Right;
                panel.Controls.Add(copyButton);
                #endregion
                workPanel.Controls.Add(panel);
            }
        }
    }
}
