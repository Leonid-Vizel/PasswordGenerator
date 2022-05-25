using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace PasswordGenerator.Forms
{
    public partial class SendTCPForm : Form
    {
        private int port;
        private bool methodLinked;
        private bool closedFlag;
        private TcpClient tcpClient;
        private MainForm grandParent;
        private BackgroundWorker worker;
        private ImagePassword sendImageInstance;
        private LoginPassword sendLoginInstance;
        public SendTCPForm(ImagePassword sendInstance, MainForm grandParent)
        {
            this.grandParent = grandParent;
            sendImageInstance = sendInstance;
            worker = new BackgroundWorker();
            InitializeComponent();
        }

        public SendTCPForm(LoginPassword sendInstance, MainForm grandParent)
        {
            this.grandParent = grandParent;
            sendLoginInstance = sendInstance;
            worker = new BackgroundWorker();
            InitializeComponent();
            sendBtn.BackColor = Color.FromArgb(50, 183, 108);
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (ipTextBox.Text.Length == 0)
            {
                MessageBox.Show("IP указан неправильно!", "Ошибка");
                return;
            }

            if (!portTextBox.MaskCompleted)
            {
                MessageBox.Show("Порт указан неправильно!", "Ошибка");
                return;
            }

            if (!int.TryParse(portTextBox.Text, out port))
            {
                MessageBox.Show("Порт указан неверно", "Ошибка");
                return;
            }

            waitLabel.Visible = true;
            ipLabel.Visible = ipTextBox.Visible = portLabel.Visible = portTextBox.Visible = sendBtn.Visible = false;
            if (!methodLinked)
            {
                worker.DoWork += (object doWorkObject, DoWorkEventArgs arg) =>
                {
                    tcpClient = new TcpClient();
                    try
                    {
                        tcpClient.Connect(ipTextBox.Text, port);
                    }
                    catch (Exception ex)
                    {
                        if (!closedFlag)
                        {
                            MessageBox.Show($"Ошибка подключения: {ex}", "Ошибка");
                        }
                        return;
                    }
                    using (NetworkStream stream = tcpClient.GetStream())
                    {
                        byte[] data = null;
                        if (sendImageInstance == null)
                        {
                            data = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(sendLoginInstance.ToSendInfo()));
                        }
                        else
                        {
                            data = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(sendImageInstance.ToSendInfo()));
                        }
                        stream.Write(data, 0, data.Length);
                        stream.Close();
                    }
                    tcpClient.Close();
                    MessageBox.Show("Успешно отправлено");

                    Action act = () =>
                    {
                        grandParent.backBtn.PerformClick();
                    };
                    Invoke(act);
                };
                methodLinked = true;
            }

            worker.RunWorkerCompleted += (object completedObject, RunWorkerCompletedEventArgs arg) =>
            {
                waitLabel.Visible = false;
                ipLabel.Visible = ipTextBox.Visible = portLabel.Visible = portTextBox.Visible = sendBtn.Visible = true;
            };

            worker.RunWorkerAsync();
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            closedFlag = true;
            tcpClient?.Close();
        }
    }
}
