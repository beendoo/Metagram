using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MergeClient
{
    public partial class Lock1 : Form
    {
        Main main = null;

        static string aes_key = "AXe8YwuIn1zxt3FPWTZFlAa14EHdPAdN9FaZ9RQWihc="; //44자
        static string aes_iv = "bsxnWolsAyO7kCfWuyrnqg=="; //24자

        TcpClient clientSocket; // 소켓
        NetworkStream stream = default(NetworkStream);
        bool bThreadExit = false;

        private static char CR = (char)0x0D;
        private static char LF = (char)0x0A;

        public Lock1(Main main, string ip, string port, string id)
        {
            this.main = main;
            InitializeComponent();

            chatip_box.Text = ip;
            chatport_box.Text = port;
            chatid_box.Text = id;

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

            Thread a_handler = new Thread(alarmMessage);
            a_handler.IsBackground = true;
            a_handler.Start();
        }

        private void alarmMessage()
        {
            while (!bThreadExit)
            {
                stream = clientSocket.GetStream();
                int BUFFERSIZE = clientSocket.ReceiveBufferSize;
                byte[] buffer = new byte[BUFFERSIZE];
                int bytes = stream.Read(buffer, 0, buffer.Length);
                string message = Encoding.Unicode.GetString(buffer, 0, bytes);
                string str_roundtrip = DecryptAES(message);
                Console.WriteLine("get message" + str_roundtrip);

                int index = str_roundtrip.IndexOf(" ");
                if (index > 0)
                {
                    Form alarm = new alarm();

                    alarm.StartPosition = FormStartPosition.Manual;
                    alarm.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - alarm.Width - 10, Screen.PrimaryScreen.WorkingArea.Height - alarm.Height - 10);

                    alarm.ShowDialog();

                }
            }
        }

        private void unlock_button_Click(object sender, EventArgs e)
        {
            string original = "Lock$" + chatid_box.Text + ":" + pw_box.Text + CR + LF;
            string str_encrypted = EncryptAES(original);
            byte[] buffer = Encoding.Unicode.GetBytes(str_encrypted);
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();

            Thread t_handler = new Thread(unlock);
            t_handler.IsBackground = true;
            t_handler.Start();
        }
        private void unlock()   // 잠금해제
        {
            while (!bThreadExit)
            {
                stream = clientSocket.GetStream();
                int BUFFERSIZE = clientSocket.ReceiveBufferSize;
                byte[] buffer = new byte[BUFFERSIZE];
                int bytes = stream.Read(buffer, 0, buffer.Length);
                string message = Encoding.Unicode.GetString(buffer, 0, bytes);
                string str_roundtrip = DecryptAES(message);
                Console.WriteLine("get message" + str_roundtrip);

                int index = str_roundtrip.IndexOf("입장");
                if (index > 0)
                {
                    chatip_box.Enabled = false;
                    chatport_box.Enabled = false;
                    chatid_box.Enabled = false;
                    pw_box.Enabled = false;
                    unlock_button.Enabled = false;

                    main.Opacity = 1;
                    this.Dispose(); //잠금 form 닫기
                }
                else
                {
                    MessageBox.Show("잠금 해제에 실패하였습니다. 다시 입력 해주세요");

                    return;
                }
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

        private void pw_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                unlock_button_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }
    }
}
