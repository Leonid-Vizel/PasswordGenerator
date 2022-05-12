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
    public partial class SavedSettingForm : Form
    {
        private PasswordGenerator generator;
        private MainForm parent;
        public SavedSettingForm(MainForm parent, PasswordGenerator generator)
        {
            InitializeComponent();
            this.parent = parent;
            this.generator = generator;
        }
    }
}
