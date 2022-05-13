using FontAwesome.Sharp;
using PasswordGenerator.Forms;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class MainForm : Form
    {
        public PasswordGenerator Generator { get; set; }
        private IconButton currentButton;
        private Form currentForm;
        public MainForm()
        {
            isDraggingHorisontal = isDraggingVertical = false;
            Generator = new PasswordGenerator(); //Пока так, потому что не загружаем с базы
            Generator.UseUpperCase = true;
            Generator.PasswordLength = 10;
            InitializeComponent();
        }

        #region Moving
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void OnMoveMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region Resizing
        private bool isDraggingHorisontal;
        private bool isDraggingVertical;

        private void OnPanelMouseMove(object sender, MouseEventArgs e)
        {
            Panel senderPanel = sender as Panel;
            if (senderPanel == null)
            {
                return;
            }
            bool sizeXready = e.X >= senderPanel.Width - 4;
            bool sizeYready = e.Y >= senderPanel.Height - 4;
            if (sizeYready)
            {
                Cursor = Cursors.SizeNS;
            }
            else if (sizeXready)
            {
                Cursor = Cursors.SizeWE;
            }
            else
            {
                Cursor = Cursors.Default;
            }

            if (isDraggingHorisontal)
            {
                Size = new Size(senderPanel.Location.X + senderPanel.Size.Width + (e.X - senderPanel.Size.Width), Height);
            }
            else if (isDraggingVertical)
            {
                Size = new Size(Width, senderPanel.Location.Y + senderPanel.Size.Height + (e.Y - senderPanel.Size.Height));
            }
        }

        private void OnPanelMouseUp(object sender, MouseEventArgs e)
        {
            isDraggingHorisontal = isDraggingVertical = false;
        }

        private void OnPanelMouseDown(object sender, MouseEventArgs e)
        {
            Panel senderPanel = sender as Panel;
            if (senderPanel == null)
            {
                return;
            }
            if (e.X >= senderPanel.Width - 4)
            {
                isDraggingHorisontal = true;
            }
            else if (e.Y >= senderPanel.Height - 4)
            {
                isDraggingVertical = true;
            }
        }

        private void OnPanelMouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            isDraggingHorisontal = isDraggingVertical = false;
        }
        #endregion

        #region Min-Max-Close Buttons
        private void OnCloseClick(object sender, EventArgs e)
            => Close();

        private void OnMaxClick(object sender, EventArgs e)
            => WindowState = (WindowState == FormWindowState.Maximized) ? FormWindowState.Normal : FormWindowState.Maximized;

        private void OnMinClick(object sender, EventArgs e)
            => WindowState = FormWindowState.Minimized;

        private void OnCloseMouseEnter(object sender, EventArgs e)
            => closeBtn.BackColor = Color.Red;

        private void OnCloseMouseLeave(object sender, EventArgs e)
            => closeBtn.BackColor = Color.Transparent;

        private void OnMaxMouseEnter(object sender, EventArgs e)
            => maximizeBtn.BackColor = Color.Yellow;

        private void OnMaxMouseLeave(object sender, EventArgs e)
            => maximizeBtn.BackColor = Color.Transparent;

        private void OnMixMouseEnter(object sender, EventArgs e)
            => minimizeBtn.BackColor = Color.Green;

        private void OnMinMouseLeave(object sender, EventArgs e)
            => minimizeBtn.BackColor = Color.Transparent;
        #endregion

        #region Buttons
        public void SetCurrentForm(IconButton nextButton, Form nextForm)
        {
            if (currentButton == nextButton)
            {
                return;
            }
            if (currentButton != null)
            {
                currentButton.BackColor = buttonPanel.BackColor;
            }
            string hexColorString = nextForm.Tag as string;
            currentForm?.Close();
            workPanel.Controls.Clear();
            currentForm?.Dispose();
            if (hexColorString != null)
            {
                Color fromHexColor = ColorTranslator.FromHtml(hexColorString);
                nextButton.BackColor = topLabelPanel.BackColor = fromHexColor;
                logoPanel.BackColor = ChangeColorBrightness(nextButton.BackColor, -0.3);
            }
            currentButton = nextButton;
            currentForm = nextForm;
            nextForm.Dock = DockStyle.Fill;
            nextForm.TopLevel = false;
            workPanel.Controls.Add(nextForm);
            topLabel.Text = nextForm.Text;
            nextForm.BringToFront();
            nextForm.Show();
        }

        public Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            //If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }

        private void OnGenerateBtnClick(object sender, EventArgs e)
        {
            SetCurrentForm(generateBtn, new PasswordGenerateForm(this, Generator));
        }

        public void OnPicPasswordsClick(object sender, EventArgs e)
        {
            SetCurrentForm(picPasswordsBtn, new SavedSettingForm(this, Generator));
        }
        #endregion
    }
}
