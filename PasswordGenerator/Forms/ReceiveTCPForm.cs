using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace PasswordGenerator.Forms
{
    public partial class ReceiveTCPForm : Form
    {
        private int port;
        private bool methodLinked;
        private TcpListener server;
        private ImagePassword receivedImage;
        private LoginPassword receivedLogin;
        private PictureGenForm imageParent;
        private SavedPasswordsForm loginParent;
        private BackgroundWorker worker;
        public ReceiveTCPForm(PictureGenForm parent)
        {
            methodLinked = false;
            imageParent = parent;
            worker = new BackgroundWorker();
            InitializeComponent();
        }

        public ReceiveTCPForm(SavedPasswordsForm parent)
        {
            methodLinked = false;
            loginParent = parent;
            worker = new BackgroundWorker();
            InitializeComponent();
            ReceiveBtn.BackColor = Color.FromArgb(50, 183, 108);
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
            if (worker.IsBusy)
            {
                MessageBox.Show("Немного подождите. Завершаем предыдущую операцию.", "Ошибка");
                return;
            }

            if (!portTextBox.MaskCompleted)
            {
                MessageBox.Show("Неверно введён порт", "Ошибка");
                return;
            }

            if (!int.TryParse(portTextBox.Text, out port))
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

            if (!methodLinked)
            {
                worker.DoWork += (object doWorkObject, DoWorkEventArgs arg) =>
                {
                    server = new TcpListener(IPAddress.Any, port);
                    server.Start();
                    TcpClient client = null;
                    try
                    {
                        client = server.AcceptTcpClient();
                    }
                    catch
                    {
                        Action act = () =>
                        {
                            SwapPanels(waitPanel, askPortPanel);
                        };
                        Invoke(act);
                        return;
                    }
                    NetworkStream ns = client.GetStream();
                    if (client.Connected)
                    {
                        byte[] msg = new byte[10485760];     // готовим место для принятия сообщения (10МБ)
                        string message = Encoding.UTF8.GetString(msg, 0, ns.Read(msg, 0, msg.Length));
                        try
                        {
                            int id = 0;
                            if (imageParent == null)
                            {
                                id = loginParent.Parent.GetNextImagePasswordId();
                            }
                            else
                            {
                                id = imageParent.GetNextId();
                            }
                            receivedImage = ImagePassword.FromSendInfo(JsonConvert.DeserializeObject<SendPasswordImageInfo>(message), id);
                        }
                        catch
                        {
                            try
                            {
                                receivedLogin = LoginPassword.FromSendInfo(JsonConvert.DeserializeObject<SendPasswordLoginInfo>(message), PasswordGenerator.GetNextPasswordId());
                            }
                            catch
                            {
                                MessageBox.Show("Не удалось распознать полученный пакет!", "Ошибка");
                            }
                        }
                        client.Close();
                        server.Stop();

                        Action act = () =>
                        {
                            if (receivedImage == null && receivedLogin == null)
                            {
                                SwapPanels(waitPanel, askPortPanel);
                            }
                            else if (receivedLogin != null)
                            {
                                SwapPanels(waitPanel, passwordReceivedPanel);
                                loginPassLabel.Text = $"Получен пароль с логином '{receivedLogin.Login}'!";
                            }
                            else
                            {
                                SwapPanels(waitPanel, foundPanel);
                                foundBox.Image = receivedImage.Image;
                            }
                        };
                        Invoke(act);
                    }
                    server = null;
                    client = null;
                };
                methodLinked = true;
            }
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

        private void cancelWaitBtn_Click(object sender, EventArgs e)
        {
            if (server != null)
            {
                server?.Stop();
                server = null;
            }
            else
            {
                SwapPanels(waitPanel, askPortPanel);
            }
        }

        private void cancelSaveBtn_Click(object sender, EventArgs e)
        {
            receivedImage = null;
            foundBox.Image = null;
            SwapPanels(foundPanel, askPortPanel);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (loginParent == null)
            {
                loginParent.Parent.imagePasswords.Add(receivedImage);
                loginParent.Parent.backBtn.PerformClick();
            }
            else
            {
                imageParent.AddPassword(receivedImage);
                imageParent.Parent.backBtn.PerformClick();
            }
        }

        private void cancelLoginPassBtn_Click(object sender, EventArgs e)
        {
            receivedLogin = null;
            SwapPanels(passwordReceivedPanel, askPortPanel);
        }

        private void saveLoginPassBtn_Click(object sender, EventArgs e)
        {
            if (PasswordGenerator.LoadedPasswords.Where(x => x.Login.Equals(receivedLogin.Login)).Any(x => x.Decrypt().Equals(receivedLogin.Decrypt())))
            {
                MessageBox.Show("Такой пароль уже сохранён при этом логине!", "Ошибка");
                return;
            }
            PasswordGenerator.LoadedPasswords.Add(receivedLogin);
            if (loginParent == null)
            {
                loginParent.OnSearchClick(null, null);
                loginParent.Parent.backBtn.PerformClick();
            }
            else
            {
                loginParent.Parent.backBtn.PerformClick();
            }
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            server?.Stop();
        }
    }
}
