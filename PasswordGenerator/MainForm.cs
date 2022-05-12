using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class MainForm : Form
    {
        private PasswordGenerator genarator;
        public MainForm()
        {
            isDraggingHorisontal = isDraggingVertical = false;
            genarator = new PasswordGenerator(); //Пока так, потому что не загружаем с базы
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
        private void closeBtn_Click(object sender, EventArgs e)
            => Close();

        private void maximizeBtn_Click(object sender, EventArgs e)
            => WindowState = (WindowState == FormWindowState.Maximized) ? FormWindowState.Normal : FormWindowState.Maximized;

        private void minimizeBtn_Click(object sender, EventArgs e)
            => WindowState = FormWindowState.Minimized;
        #endregion
    }
}
