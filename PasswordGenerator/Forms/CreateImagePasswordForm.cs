using System;
using System.Drawing;
using System.Windows.Forms;

namespace PasswordGenerator.Forms
{
    public partial class CreateImagePasswordForm : Form
    {
        private PictureGenForm parent;
        public CreateImagePasswordForm(PictureGenForm parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void OnImageUploadClick(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap fromFile = null;
                    try
                    {
                        fromFile = Image.FromFile(dialog.FileName) as Bitmap;
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка загрузки", "Ошибка");
                        return;
                    }
                    Image imageToDispose = imageBox.Image;
                    imageBox.Image = fromFile;
                    imageToDispose?.Dispose(); //Это можно не делать, так как оставленное в памяти изображение скорее всего будет очищено сборщиком мусора
                }
            }
        }

        private void OnEyeClick(object sender, EventArgs e)
        {
            if (openPasswordBtn.IconChar == FontAwesome.Sharp.IconChar.EyeSlash)
            {
                openPasswordBtn.IconChar = FontAwesome.Sharp.IconChar.Eye;
                passwordBox.UseSystemPasswordChar = true;
            }
            else
            {
                openPasswordBtn.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                passwordBox.UseSystemPasswordChar = false;
            }
        }

        private void OnSaveClick(object sender, EventArgs e)
        {
            if (passwordBox.Text.Length == 0)
            {
                MessageBox.Show("Укажите пароль!", "Ошибка");
                return;
            }
            if (imageBox.Image == null)
            {
                MessageBox.Show("Загрузите картинку!", "Ошибка");
                return;
            }
            ImagePassword imagePassword = new ImagePassword(parent.GetNextId(), passwordBox.Text, imageBox.Image as Bitmap);
            //!BASE! Здесь добавить отправку в БД объекта imagePassword
            parent.AddPassword(imagePassword);
            parent.Parent.backBtn.PerformClick();
        }
    }
}
