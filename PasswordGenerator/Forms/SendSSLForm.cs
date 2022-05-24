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
    public partial class SendSSLForm : Form
    {
        private ImagePassword sendInstance;
        public SendSSLForm(ImagePassword sendInstance)
        {
            this.sendInstance = sendInstance;
            InitializeComponent();
        }
    }
}
