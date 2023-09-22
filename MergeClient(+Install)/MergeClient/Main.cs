using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MergeClient
{
    public partial class Main : Form
    {
        static string aes_key = "AXe8YwuIn1zxt3FPWTZFlAa14EHdPAdN9FaZ9RQWihc="; //44자
        static string aes_iv = "bsxnWolsAyO7kCfWuyrnqg=="; //24자

        TcpClient clientSocket; // 소켓
        NetworkStream stream = default(NetworkStream);
        string stSendMessage = "";
        // 메시지는 개행으로 구분한다.
        private static char CR = (char)0x0D;
        private static char LF = (char)0x0A;
        bool bThreadExit = false;

        public Main()
        {
            InitializeComponent();
        }

        public Main(string ip, string port, string id)
        {
            InitializeComponent();

            chatip_box.Text = ip;
            chatport_box.Text = port;
            chatid_box.Text = id;

            bThreadExit = false;
            int Port = Int32.Parse(chatport_box.Text);
            clientSocket = new TcpClient();
            stream = default(NetworkStream);
            try
            {
                clientSocket.Connect(chatip_box.Text, Port); // 접속 IP 및 포트
                stream = clientSocket.GetStream();
            }
            catch (Exception e2)
            {
                MessageBox.Show("서버가 실행중이 아닙니다.", "연결 실패!");
                return;
            }

            Thread t_handler = new Thread(GetMessage);
            t_handler.IsBackground = true;
            t_handler.Start();
        }

        private void GetMessage()
        {
            while (!bThreadExit)
            {
                stream = clientSocket.GetStream();
                int BUFFERSIZE = clientSocket.ReceiveBufferSize;
                byte[] buffer = new byte[BUFFERSIZE];
                int bytes = stream.Read(buffer, 0, buffer.Length);
                string message = Encoding.Unicode.GetString(buffer, 0, bytes);
                string str_roundtrip = DecryptAES(message);
                DisplayText(str_roundtrip);
            }
        }

        private void DisplayText(string message)
        {
            if (Chat_box.InvokeRequired) //다른 쓰레드에서 실행되어 Invoke가 필요한 상태라면 
            {
                Chat_box.BeginInvoke(new MethodInvoker(delegate   ///델리게이트로 넘겨서 실행
                {
                    Chat_box.AppendText(message + Environment.NewLine);
                }));
            }
            else
                Chat_box.AppendText(message + Environment.NewLine);
        }

        private void Send_button_Click(object sender, EventArgs e)
        {
            if (message_box.Text != "")
            {
                string original = chatid_box.Text + "$" + message_box.Text + CR + LF;
                string str_encrypted = EncryptAES(original);
                byte[] buffer = Encoding.Unicode.GetBytes(str_encrypted);
                stream.Write(buffer, 0, buffer.Length);
                stream.Flush();
                message_box.Text = "";
            }
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            string original = "exit" + CR + LF;
            string str_encrypted = EncryptAES(original);
            byte[] buffer = Encoding.Unicode.GetBytes(str_encrypted);
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();
            bThreadExit = true;
            Thread.Sleep(1000);

            //로그아웃버튼 누르면 로그인창으로 넘어가게 시도 (원래는 아래 종료코드)
            this.Opacity = 0;
            //this.Close();
            //Form Login1 = new Login1();
            //Login1.ShowDialog();
            Application.Restart();

            //Application.Exit();
        }

        private void lock_button_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
            Form Lock1 = new Lock1(this, chatip_box.Text, chatport_box.Text, chatid_box.Text);
            Lock1.Show();
        }

        private void txt_message_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Send_button_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }
        public static string EncryptAES(string plainText)
        {
            byte[] encrypted;

            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                aes.KeySize = 256;
                aes.BlockSize = 128;
                aes.Key = Convert.FromBase64String(aes_key);
                aes.IV = Convert.FromBase64String(aes_iv);
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                ICryptoTransform enc = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, enc, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(plainText);
                        }

                        encrypted = ms.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(encrypted);
        }

        public static string DecryptAES(string encryptedText)
        {
            string decrypted = null;
            byte[] cipher = Convert.FromBase64String(encryptedText);

            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                aes.KeySize = 256; //AES256
                aes.BlockSize = 128;
                aes.Key = Convert.FromBase64String(aes_key);
                aes.IV = Convert.FromBase64String(aes_iv);
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                ICryptoTransform dec = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream(cipher))
                {
                    using (CryptoStream cs = new CryptoStream(ms, dec, CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(cs))
                        {
                            decrypted = sr.ReadToEnd();
                        }
                    }
                }
            }

            return decrypted;
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private bool onClick;
        private Point startPoint = new Point(0, 0);
        private void moveWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (onClick)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }
        private void moveWindow_MouseDown(object sender, MouseEventArgs e)
        {
            onClick = true;
            startPoint = new Point(e.X, e.Y);
        }
        private void moveWindow_MouseUp(object sender, MouseEventArgs e)
        {
            onClick = false;
        }
    }
}
