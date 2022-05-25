using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace PasswordGenerator.Forms
{
    public partial class ReceiveTCPForm : Form
    {
        private bool endWaiting;
        private ImagePassword received;
        private PictureGenForm parent;
        private BackgroundWorker worker;
        public ReceiveTCPForm(PictureGenForm parent)
        {
            this.parent = parent;
            worker = new BackgroundWorker();
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

            if (!int.TryParse(portTextBox.Text, out int port))
            {
                MessageBox.Show("Неверно введён порт", "Ошибка");
                return;
            }

            string ipLocal = GetLocalIPAddress();
            if (ipLocal.Equals("ERROR"))
            {
                MessageBox.Show("Нет сетевых адаптеров с адресом IPv4 в системе", "Ошибка");
                return;
            }
            ipLabel.Text = $"IP: {ipLocal}\nПорт: {port}";

            endWaiting = false;

            worker.DoWork += (object doWorkObject, DoWorkEventArgs arg) =>
            {
                TcpListener server = new TcpListener(IPAddress.Any, port);
                server.Start();  // запускаем сервер
                while (!endWaiting)   // бесконечный цикл обслуживания клиентов
                {
                    TcpClient client = server.AcceptTcpClient();  // ожидаем подключение клиента
                    NetworkStream ns = client.GetStream(); // для получения и отправки сообщений
                    if (client.Connected)
                    {
                        byte[] msg = new byte[10485760];     // готовим место для принятия сообщения
                        received = ImagePassword.FromSendInfo(JsonConvert.DeserializeObject<SendPasswordImageInfo>(Encoding.UTF8.GetString(msg, 0, ns.Read(msg, 0, msg.Length))), parent.GetNextId());
                        server.Stop();

                        Action act = () =>
                        {
                            endWaiting = true;
                            SwapPanels(waitPanel, foundPanel);
                            foundBox.Image = received.Image;
                        };
                        Invoke(act);
                    }
                }
            };
            worker.RunWorkerAsync();
            SwapPanels(askPortPanel, waitPanel);
        }

        private string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "ERROR";
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            endWaiting = true;
            SwapPanels(waitPanel, askPortPanel);
        }

        private void cancelSaveBtn_Click(object sender, EventArgs e)
        {
            received = null;
            foundBox.Image = null;
            SwapPanels(foundPanel, askPortPanel);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            parent.AddPassword(received);
            parent.Parent.backBtn.PerformClick();
        }
    }
}
