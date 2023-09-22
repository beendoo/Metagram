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
    public partial class Login1 : Form
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

        public Login1()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            bThreadExit = false;
            int Port = Int32.Parse(port_box.Text);
            clientSocket = new TcpClient();
            stream = default(NetworkStream);
            
            try
            {
                clientSocket.Connect(ip_box.Text, Port); // 접속 IP 및 포트
                stream = clientSocket.GetStream();
            }
            catch (Exception e2)
            {
                MessageBox.Show("서버가 실행중이 아닙니다.", "연결 실패!");
                return;
            }

            string original = "Login$" + id_box.Text + ":" + pw_box.Text + CR + LF;
            string str_encrypted = EncryptAES(original);
            byte[] buffer = Encoding.Unicode.GetBytes(str_encrypted);
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();

            Thread t_handler = new Thread(GetMessage);
            t_handler.IsBackground = true;
            t_handler.Start();
        }

        private void sign_button_Click(object sender, EventArgs e)
        {
            bThreadExit = false;
            int Port = Int32.Parse(port_box.Text);
            clientSocket = new TcpClient();
            stream = default(NetworkStream);
            try
            {
                clientSocket.Connect(ip_box.Text, Port); // 접속 IP 및 포트
                stream = clientSocket.GetStream();
            }
            catch (Exception e2)
            {
                MessageBox.Show("서버가 실행중이 아닙니다.", "연결 실패!");
                return;
            }

            Form Sign1 = new Sign1(ip_box.Text, port_box.Text);
            Sign1.Show();
        }

        private void GetMessage()   // 로그인버튼 --> 채팅창
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
                    ip_box.Enabled = false;
                    port_box.Enabled = false;
                    id_box.Enabled = false;
                    pw_box.Enabled = false;
                    login_button.Enabled = false;
                    sign_button.Enabled = false;
                    this.Opacity = 0;
                    Form Main = new Main(ip_box.Text, port_box.Text, id_box.Text);
                    Main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("로그인에 실패하였습니다. 다시 로그인 해주세요");

                    //Application.Restart(); // 프로그램 재실행 때

                    //Form form2 = new Form2();  // 특정 폼 재실행 때
                    //form2.Show();

                    return;
                }
            }

        }

        private void GetMessage2()  // 회원가입버튼 --> 회원가입창
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
                
                Form Sign1 = new Sign1();
                Sign1.ShowDialog();

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
