using PasswordGenerator.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class PasswordGenerateForm : Form
    {
        private PasswordGenerator generator;
        private MainForm parent;
        public PasswordGenerateForm(MainForm parent, PasswordGenerator generator)
        {
            InitializeComponent();
            this.parent = parent;
            this.generator = generator;
        }

        private void openPasswordBtn_Click(object sender, EventArgs e)
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

        private void copyBtn_Click(object sender, EventArgs e)
        {
            copyBtn.IconChar = FontAwesome.Sharp.IconChar.Check;
            copyBtn.IconColor = Color.Green;
            Clipboard.SetText(passwordBox.Text);
            label1.Visible = true;
            copyLabelShowTimer.Start();
        }

        private void OnCopyTimerElapsed(object sender, EventArgs e)
        {
            copyBtn.IconChar = FontAwesome.Sharp.IconChar.Copy;
            copyBtn.IconColor = Color.Black;
            label1.Visible = false;
            copyLabelShowTimer.Stop();
        }

        private void upperCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!(upperCheckBox.Checked || lowerCheckBox.Checked || alphanumCheckBox.Checked || numberCheckBox.Checked))
            {
                upperCheckBox.Checked = !upperCheckBox.Checked;
                MessageBox.Show("Выберите хотя бы одну опцию для генерации", "Ошибка");
                return;
            }
            generator.UseUpperCase = upperCheckBox.Checked;
        }

        private void lowerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!(upperCheckBox.Checked || lowerCheckBox.Checked || alphanumCheckBox.Checked || numberCheckBox.Checked))
            {
                lowerCheckBox.Checked = !lowerCheckBox.Checked;
                MessageBox.Show("Выберите хотя бы одну опцию для генерации", "Ошибка");
                return;
            }
            generator.UseLowerCase = lowerCheckBox.Checked;
        }

        private void alphanumCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!(upperCheckBox.Checked || lowerCheckBox.Checked || alphanumCheckBox.Checked || numberCheckBox.Checked))
            {
                alphanumCheckBox.Checked = !alphanumCheckBox.Checked;
                MessageBox.Show("Выберите хотя бы одну опцию для генерации", "Ошибка");
                return;
            }
            generator.UseNonAlphanumeric = alphanumCheckBox.Checked;
        }

        private void numberCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!(upperCheckBox.Checked || lowerCheckBox.Checked || alphanumCheckBox.Checked || numberCheckBox.Checked))
            {
                numberCheckBox.Checked = !numberCheckBox.Checked;
                MessageBox.Show("Выберите хотя бы одну опцию для генерации", "Ошибка");
                return;
            }
            generator.UseNumbers = numberCheckBox.Checked;
        }

        private void similarCheckBox_CheckedChanged(object sender, EventArgs e)
            => generator.ExcludeSimilar = similarCheckBox.Checked;

        private void ambiguousCheckBox_CheckedChanged(object sender, EventArgs e)
            => generator.ExcludeAmbiguous = ambiguousCheckBox.Checked;

        private void OnGenerateClick(object sender, EventArgs e)
            => passwordBox.Text = generator.Generate();

        private void lengthUpDown_ValueChanged(object sender, EventArgs e)
            => generator.PasswordLength = (int)lengthUpDown.Value;

        private void OnFormLoad(object sender, EventArgs e)
        {
            lengthUpDown.Value = generator.PasswordLength;
            upperCheckBox.Checked = generator.UseUpperCase;
            lowerCheckBox.Checked = generator.UseLowerCase;
            numberCheckBox.Checked = generator.UseNumbers;
            alphanumCheckBox.Checked = generator.UseNonAlphanumeric;
            similarCheckBox.Checked = generator.ExcludeSimilar;
            ambiguousCheckBox.Checked = generator.ExcludeAmbiguous;
        }

        private void OnOpenSavedClick(object sender, EventArgs e)
            => parent.OnPicPasswordsClick(null,null);
    }
}
