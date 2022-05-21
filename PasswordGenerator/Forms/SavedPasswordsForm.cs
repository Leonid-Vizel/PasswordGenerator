using FontAwesome.Sharp;
using NLog;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PasswordGenerator.Forms
{
    public partial class SavedPasswordsForm : Form
    {
        private Logger logger;
        public string Result { get; set; }
        public Color formColor;
        public SavedPasswordsForm()
        {
            logger = LogManager.GetCurrentClassLogger();
            InitializeComponent();
            formColor = ColorTranslator.FromHtml((string)Tag);
        }
        private void OnBorderDraw(object sender, PaintEventArgs e)
        {
            Control senderControl = sender as Control;
            if (senderControl == null)
            {
                return;
            }
            ControlPaint.DrawBorder(e.Graphics, senderControl.ClientRectangle, formColor, ButtonBorderStyle.Solid);
        }

        private void OnSearchClick(object sender, EventArgs e)
        {
            if (searchBox.Text.Length == 0)
            {
                logger.Warn("Поиск отклонён. Не указан логин для поиска.");
                MessageBox.Show("Укажите логин по которому искать!","Ошибка");
                return;
            }
            workPanel.Controls.Clear();
            logger.Trace($"Происходит поиск паролей для логина {searchBox.Text}");
            IEnumerable<LoginPassword> searchResults = PasswordGenerator.LoadedPasswords.Where(x => x.Login.ToLower().Equals(searchBox.Text.ToLower()));
            logger.Trace($"Количество результатов: {searchResults.Count()}");
            foreach (LoginPassword password in searchResults)
            {
                Panel panel = new Panel();
                panel.BackColor = Algorythms.ChangeColorBrightness(formColor, -0.3F);
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
                #region Delete
                IconButton deleteButton = new IconButton();
                deleteButton.IconChar = IconChar.Plus;
                deleteButton.BackColor = Color.Crimson;
                deleteButton.Rotation = 45;
                deleteButton.IconSize = 34;
                deleteButton.Click += (object senderObj, EventArgs arg) =>
                {
                    if (MessageBox.Show("Вы действительно хотите удалить этот пароль?","Удаление", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        logger.Trace($"Удаление пароля (ID:{password.Id}) отклонено");
                        return;
                    }
                    workPanel.Controls.Remove(panel);
                    PasswordGenerator.LoadedPasswords.Remove(password);
                    //!BASE!Удаление объекта password из базы
                    panel.Dispose();
                    logger.Trace($"Пароль (ID:{password.Id}) удалён!");
                };
                deleteButton.Size = new Size(34, 34);
                deleteButton.FlatStyle = FlatStyle.Flat;
                deleteButton.FlatAppearance.BorderSize = 0;
                deleteButton.Dock = DockStyle.Right;
                panel.Controls.Add(deleteButton);
                #endregion
                workPanel.Controls.Add(panel);
            }
            logger.Trace("Отображение результатов окончено");
        }
    }
}
