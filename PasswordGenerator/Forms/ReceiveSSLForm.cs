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
    public partial class ReceiveSSLForm : Form
    {
        private int port;
        private List<ImagePassword> passwords;
        public ReceiveSSLForm(List<ImagePassword> passwords)
        {
            this.passwords = passwords;
            InitializeComponent();
        }

        private void SwapPanels(Panel panel1, Panel panel2)
        {
            panel1.Visible = false;
            Point location = panel1.Location;
            panel1.Location = panel2.Location;
            panel2.Location = location;
            panel2.Visible = true;
        }

        private void ReceiveBtn_Click(object sender, EventArgs e)
        {
            if (!portTextBox.MaskCompleted)
            {
                MessageBox.Show("Неверно введён порт","Ошибка");
                return;
            }
            SwapPanels(askPortPanel, waitPanel);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            SwapPanels(waitPanel, askPortPanel);
        }
    }
}
