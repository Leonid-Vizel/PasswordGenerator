using FontAwesome.Sharp;
using PasswordGenerator.Forms;
using System;
using System.IO;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class MainForm : Form
    {
        public PasswordGenerator Generator { get; set; } //Объект генератора паролей
        private IconButton currentButton; //Текущая выбранная кнопка
        private Form currentForm; //Текущая открытая форма
        private bool checkBtnState; //Флаг, отвечающий за проверку текущей кнопки при нажатии
        private PrivateFontCollection fontCollection; //Коллекция шрифтов (На самом деле только 1) для лого
        public MainForm()
        {
            Generator = new PasswordGenerator(); //Пока так, потому что не загружаем с базы
            Generator.UseUpperCase = true;
            Generator.PasswordLength = 10;
            checkBtnState = true;
            SetProcessDpiAwarenessContext(-1);
            InitializeComponent();
            ApplyFontToLogoLabel();
        }

        private void ApplyFontToLogoLabel()
        {
            if (File.Exists("Break.ttf"))
            {
                fontCollection = new PrivateFontCollection();
                try
                {
                    fontCollection.AddFontFile($"{Environment.CurrentDirectory}\\Break.ttf");
                    logoLabel.Font = new Font(fontCollection.Families[0], 18);
                }
                catch
                {
                    MessageBox.Show("Не удалось загрузить шрифт!", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Не найден файл шрифта!", "Ошибка");
            }
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

        #region Resizing
        protected override void WndProc(ref Message m)
        {
            const int wmNcHitTest = 0x84;
            const int htBottomLeft = 16;
            const int htBottomRight = 17;
            if (m.Msg == wmNcHitTest)
            {
                int x = (int)(m.LParam.ToInt64() & 0xFFFF);
                int y = (int)((m.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point pt = PointToClient(new Point(x, y));
                Size clientSize = ClientSize;
                if (pt.X >= clientSize.Width - 16 && pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htBottomLeft : htBottomRight);
                    return;
                }
            }
            base.WndProc(ref m);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x00040000;
                return cp;
            }
        }
        #endregion

        #region Buttons
        public void SetCurrentForm(IconButton nextButton, Form nextForm)
        {
            if (checkBtnState && currentButton == nextButton)
            {
                return;
            }
            closeCurrentBtn.Visible = reloadCurrentBtn.Visible = true;
            if (currentButton != null)
            {
                currentButton.BackColor = buttonPanel.BackColor;
            }
            string hexColorString = nextForm.Tag as string;
            if (currentForm != null)
            {
                currentForm.Close();
                workPanel.Controls.Clear();
                currentForm.Dispose();
            }
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
            => SetCurrentForm(generateBtn, new PasswordGenerateForm(this, Generator));

        public void OnPicPasswordsClick(object sender, EventArgs e)
            => SetCurrentForm(picPasswordsBtn, new SavedSettingForm(this, Generator));
        #endregion

        [DllImport("user32.dll")]
        private static extern bool SetProcessDpiAwarenessContext(int value);

        private void closeCurrentBtn_Click(object sender, EventArgs e)
        {
            closeCurrentBtn.Visible = reloadCurrentBtn.Visible = false;
            if (currentButton == null)
            {
                return;
            }
            if (currentForm != null)
            {
                currentForm.Close();
                workPanel.Controls.Clear();
                currentForm.Dispose();
                currentForm = null;
            }
            topLabelPanel.BackColor = buttonPanel.BackColor;
            logoPanel.BackColor = ChangeColorBrightness(buttonPanel.BackColor, -0.3);
            currentButton.BackColor = buttonPanel.BackColor;
            currentButton = null;
        }

        private void reloadCurrentBtn_Click(object sender, EventArgs e)
        {
            checkBtnState = false;
            currentButton.PerformClick();
            checkBtnState = true;
        }
    }
}
