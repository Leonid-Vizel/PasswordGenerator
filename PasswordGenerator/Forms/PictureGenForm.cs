using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator.Forms
{
    public partial class PictureGenForm : Form
    {
        private MainForm parent;
        private List<string> passwords;
        private Color formColor;
        public PictureGenForm(MainForm parent, List<string> passwords)
        {
            this.passwords = passwords;
            this.parent = parent;
            InitializeComponent();
            formColor = ColorTranslator.FromHtml((string)Tag);
        }

        private void PictureGenForm_Load(object sender, EventArgs e)
        {
            foreach (string password in passwords)
            {
                #region Создание плитки
                Panel passPicPanel = new Panel();
                passPicPanel.BackColor = SystemColors.Control;
                passPicPanel.BorderStyle = BorderStyle.FixedSingle;
                passPicPanel.Tag = password;
                #region Надпись
                Label passLabel = new Label()
                {
                    Dock = DockStyle.Top,
                    Location = new Point(0, 176),
                    Margin = new Padding(4, 0, 4, 0),
                    Size = new Size(198, 47),
                    BackColor = formColor,
                    Text = password,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                #endregion
                #region Кнопки
                Panel btnPanel = new Panel();
                btnPanel.BackColor = Algorythms.ChangeColorBrightness(formColor, -0.3F);
                #region Показать/Скрыть
                Button openBtn = new Button()
                {
                    Dock = DockStyle.Fill,
                    FlatStyle = FlatStyle.Flat,
                    Location = new Point(0, 0),
                    Size = new Size(90, 33),
                    TabIndex = 0,
                    Tag = true,
                    Text = "Показать",
                    UseVisualStyleBackColor = true
                };
                openBtn.Click += (object senderObject, EventArgs arg) =>
                {
                    bool flag = (bool)openBtn.Tag;
                    string pass = (string)passPicPanel.Tag;
                    if (flag)
                    {
                        passLabel.Text = pass;
                        openBtn.Text = "Скрыть";
                        openBtn.Tag = false;
                    }
                    else
                    {
                        StringBuilder passBuilder = new StringBuilder();
                        for (int i = 0; i < pass.Length; i++)
                        {
                            passBuilder.Append('*');
                        }
                        openBtn.Text = "Показать";
                        passLabel.Text = passBuilder.ToString();
                        openBtn.Tag = true;
                    }
                };
                openBtn.FlatAppearance.BorderSize = 0;
                btnPanel.Controls.Add(openBtn);
                #endregion
                #region Копировать
                Button copyBtn = new Button()
                {
                    Dock = DockStyle.Right,
                    FlatStyle = FlatStyle.Flat,
                    Location = new Point(0, 0),
                    Size = new Size(110, 33),
                    TabIndex = 0,
                    Text = "Копировать",
                    Tag = password,
                    UseVisualStyleBackColor = true
                };
                copyBtn.FlatAppearance.BorderSize = 0;
                copyBtn.Click += (object senderObject, EventArgs arg) =>
                {
                    string pass = (string)passPicPanel.Tag;
                    if (pass.Length > 0)
                    {
                        Clipboard.SetText(pass);
                    }
                };
                #endregion
                btnPanel.Controls.Add(copyBtn);
                btnPanel.Dock = DockStyle.Fill;
                btnPanel.Location = new Point(0, 223);
                btnPanel.Size = new Size(200, 33);
                #endregion
                #region Добавление
                passPicPanel.Controls.Add(btnPanel);
                passPicPanel.Controls.Add(passLabel);
                passPicPanel.Controls.Add(new PictureBox()
                {
                    Dock = DockStyle.Top,
                    Location = new Point(0, 0),
                    Margin = new Padding(4, 5, 4, 5),
                    Size = new Size(198, 176),
                    TabStop = false
                });
                #endregion
                passPicPanel.Location = new Point(4, 5);
                passPicPanel.Margin = new Padding(4, 5, 4, 5);
                passPicPanel.Size = new Size(200, 258);
                workPanel.Controls.Add(passPicPanel);
                #endregion
            }
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

        private void addButton_Click(object sender, EventArgs e)
        {

        }
    }
}
