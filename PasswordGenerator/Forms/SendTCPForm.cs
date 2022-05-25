using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace PasswordGenerator.Forms
{
    public partial class SendTCPForm : Form
    {
        private MainForm grandParent;
        private BackgroundWorker worker;
        private ImagePassword sendInstance;
        public SendTCPForm(ImagePassword sendInstance, MainForm grandParent)
        {
            this.grandParent = grandParent;
            this.sendInstance = sendInstance;
            worker = new BackgroundWorker();
            InitializeComponent();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (ipTextBox.Text.Length == 0)
            {
                MessageBox.Show("IP указан неправильно!","Ошибка");
                return;
            }

            if (!portTextBox.MaskCompleted)
            {
                MessageBox.Show("Порт указан неправильно!", "Ошибка");
                return;
            }

            if (!int.TryParse(portTextBox.Text, out int port))
            {
                MessageBox.Show("Порт указан неверно", "Ошибка");
                return;
            }
            waitLabel.Visible = true;
            ipLabel.Visible = ipTextBox.Visible = portLabel.Visible = portTextBox.Visible = sendBtn.Visible = false;
            worker.DoWork += (object doWorkObject, DoWorkEventArgs arg) =>
            {
                TcpClient tcpClient = new TcpClient();
                try
                {
                    tcpClient.Connect(ipTextBox.Text, port);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка подключения: {ex}", "Ошибка");
                    return;
                }
                using (NetworkStream stream = tcpClient.GetStream())
                {
                    byte[] data = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(sendInstance.ToSendInfo()));
                    stream.Write(data, 0, data.Length);
                    stream.Close();
                }
                MessageBox.Show("Успешно отправлено");

                Action act = () =>
                {
                    grandParent.backBtn.PerformClick();
                };
                Invoke(act);
            };

            worker.RunWorkerCompleted += (object completedObject, RunWorkerCompletedEventArgs arg) =>
            {
                waitLabel.Visible = false;
                ipLabel.Visible = ipTextBox.Visible = portLabel.Visible = portTextBox.Visible = sendBtn.Visible = true;
            };

            worker.RunWorkerAsync();
        }
    }
}
