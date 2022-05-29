using FontAwesome.Sharp;
using Newtonsoft.Json;
using NLog;
using PasswordGenerator.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class MainForm : Form
    {
        private static Logger logger; //Обект логгера NLog
        public PasswordGenerator Generator { get; set; } //Объект генератора паролей
        private IconButton currentButton; //Текущая выбранная кнопка
        private Form currentForm; //Текущая открытая форма
        private bool checkBtnState; //Флаг, отвечающий за проверку текущей кнопки при нажатии
        private PrivateFontCollection fontCollection; //Коллекция шрифтов (На самом деле только 1) для лого
        private Form lastForm; //Форма для возрата назад при использовании SetNextForm
        private IconButton lastButton; //Кнопка для возрата назад при использовании SetNextForm
        public List<ImagePassword> imagePasswords { get; private set; }//Загруженные из базы картинки-пароли

        public int GetNextImagePasswordId()
        {
            if (imagePasswords.Count == 0)
            {
                return 0;
            }
            return imagePasswords.Max(x => x.Id) + 1;
        }

        public MainForm()
        {
            logger = LogManager.GetCurrentClassLogger();
            logger.Info("ПРОГРАММА ЗАПУЩЕНА");
            checkBtnState = true;
            if (File.Exists("generatorInfo.json"))
            {
                try
                {
                    Generator = JsonConvert.DeserializeObject<PasswordGenerator>(File.ReadAllText("generatorInfo.json"));
                    logger.Trace("Генератор загружен из JSON");
                }
                catch (Exception exceptionFirst)
                {
                    logger.Error($"Ошибка чтения из файла конфигурации генератора: {exceptionFirst}");
                    Generator = new PasswordGenerator();
                    Generator.UseUpperCase = true;
                    Generator.PasswordLength = 10;
                    try
                    {
                        File.WriteAllText("generatorInfo.json", JsonConvert.SerializeObject(Generator));
                        logger.Trace("Файл конфигурации успешно создан!");
                    }
                    catch (Exception exceptionSecond)
                    {
                        logger.Error($"Ошибка создания нового файла конфигурации: {exceptionSecond}");
                        MessageBox.Show("Отсутствует файл найтроек генератора. Ошибка при создании нового.", "Ошибка");
                    }
                }
            }
            else
            {
                logger.Warn("Файл конфигурации генератора не был найден. Создание нового...");
                Generator = new PasswordGenerator();
                Generator.UseUpperCase = true;
                Generator.PasswordLength = 10;
                try
                {
                    File.WriteAllText("generatorInfo.json", JsonConvert.SerializeObject(Generator));
                    logger.Trace("Файл конфигурации успешно создан");
                }
                catch (Exception exception)
                {
                    logger.Error($"Ошибка создания нового файла конфигурации: {exception}");
                    MessageBox.Show("Отсутствует файл найтроек генератора. Ошибка при создании нового.", "Ошибка");
                }
            }
            imagePasswords = new List<ImagePassword>();
            logger.Trace("Начата загрузка картинок-паролей...");
            SqlConnector.LoadImageFromSql(imagePasswords);
            logger.Trace($"Загрузка картинок-паролей завершена. Всего загружено: {imagePasswords.Count}");
            logger.Trace("Начата загрузка логин-паролей...");
            SqlConnector.LoadPassFromSql();
            logger.Trace($"Загрузка логин-паролей завершена. Всего загружено: {PasswordGenerator.LoadedPasswords.Count}");
            InitializeComponent();
            ApplyFontToLogoLabel();
        }

        private void ApplyFontToLogoLabel()
        {
            logger.Trace("Начата загрузка шривта лого...");
            if (File.Exists("Break.ttf"))
            {
                fontCollection = new PrivateFontCollection();
                try
                {
                    fontCollection.AddFontFile($"{Environment.CurrentDirectory}\\Break.ttf");
                    logoLabel.Font = new Font(fontCollection.Families[0], 18);
                    logger.Trace("Шрифт успешно найден и установлен!");
                }
                catch (Exception exception)
                {
                    logger.Error($"Ошибка чтения шрифта: {exception}");
                    MessageBox.Show("Не удалось загрузить шрифт!", "Ошибка");
                }
            }
            else
            {
                logger.Error("Файл шрифта не найден. Создайте Break.ttf!");
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
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                mainToolTip.SetToolTip(maximizeBtn, "На весь экран");
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                mainToolTip.SetToolTip(maximizeBtn, "К нормальному виду");
            }
        }

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
        public void SetNextForm(IconButton nextButton, Form nextForm)
        {
            if (checkBtnState && currentButton == nextButton)
            {
                return;
            }
            closeCurrentBtn.Visible = reloadCurrentBtn.Visible = backBtn.Visible = true;
            string hexColorString = nextForm.Tag as string;
            lastButton = currentButton;
            lastForm = currentForm;
            if (hexColorString != null)
            {
                Color fromHexColor = ColorTranslator.FromHtml(hexColorString);
                nextButton.BackColor = topLabelPanel.BackColor = fromHexColor;
                logoPanel.BackColor = Algorythms.ChangeColorBrightness(nextButton.BackColor, -0.3);
            }
            currentButton = nextButton;
            currentForm = nextForm;
            nextForm.Dock = DockStyle.Fill;
            nextForm.TopLevel = false;
            workPanel.Controls.Add(nextForm);
            topLabel.Text = nextForm.Text;
            nextForm.BringToFront();
            nextForm.Show();
            logger.Trace($"Переход на кнопку \"{nextButton.Text}\" и Форму \"{nextForm.Text}\" с запомянанием предыдущей ({lastForm.Text})");
        }

        public void SetCurrentForm(IconButton nextButton, Form nextForm)
        {
            if (checkBtnState && currentButton == nextButton)
            {
                return;
            }
            backBtn.Visible = false;
            closeCurrentBtn.Visible = reloadCurrentBtn.Visible = true;
            if (lastButton != null && lastButton != nextButton && buttonPanel.Controls.Contains(lastButton))
            {
                lastButton.BackColor = buttonPanel.BackColor;
            }
            if (currentButton != null && buttonPanel.Controls.Contains(currentButton))
            {
                currentButton.BackColor = buttonPanel.BackColor;
            }
            string hexColorString = nextForm.Tag as string;
            if (lastForm != null && lastForm != nextForm)
            {
                lastForm.Close();
                lastForm.Dispose();
            }
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
                logoPanel.BackColor = Algorythms.ChangeColorBrightness(nextButton.BackColor, -0.3);
            }
            currentButton = nextButton;
            currentForm = nextForm;
            nextForm.Dock = DockStyle.Fill;
            nextForm.TopLevel = false;
            workPanel.Controls.Add(nextForm);
            topLabel.Text = nextForm.Text;
            nextForm.BringToFront();
            nextForm.Show();
            logger.Trace($"Переход на кнопку \"{nextButton.Text}\" и Форму \"{nextForm.Text}\"");
        }

        private void OnGenerateBtnClick(object sender, EventArgs e)
            => SetCurrentForm(generateBtn, new PasswordGenerateForm(this, Generator));

        public void OnPicPasswordsClick(object sender, EventArgs e)
            => SetCurrentForm(picPasswordsBtn, new PictureGenForm(this, imagePasswords));

        private void OnSavedClick(object sender, EventArgs e)
            => SetCurrentForm(savedButton, new SavedPasswordsForm(this));
        #endregion

        private void OnCloseCurrentclick(object sender, EventArgs e)
        {
            closeCurrentBtn.Visible = reloadCurrentBtn.Visible = backBtn.Visible = false;
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
            if (lastForm != null)
            {
                lastForm.Close();
                lastForm.Dispose();
                lastForm = null;
            }
            topLabelPanel.BackColor = buttonPanel.BackColor;
            logoPanel.BackColor = Algorythms.ChangeColorBrightness(buttonPanel.BackColor, -0.3);
            currentButton.BackColor = buttonPanel.BackColor;
            if (lastButton != null)
            {
                lastButton.BackColor = buttonPanel.BackColor;
            }
            currentButton = lastButton = null;
            topLabel.Text = "Генератор безопасных паролей";
            logger.Trace("Вкладка закрыта");
        }

        private void OnReloadCurrentClick(object sender, EventArgs e)
        {
            checkBtnState = false;
            currentButton.PerformClick();
            checkBtnState = true;
            logger.Trace("Вкладка перезагружена");
        }

        private void OnBackClick(object sender, EventArgs e)
        {
            backBtn.Visible = false;
            SetCurrentForm(lastButton, lastForm);
            logger.Trace("Вернулся на вкладку раньше");
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
            => logger.Info("ПРОГРАММА ЗАКРЫТА");
    }
}
