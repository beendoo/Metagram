using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiChatServer;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MergeServer
{
    public partial class Open : Form
    {
        public Dictionary<Socket, string> clientSocketList = new Dictionary<Socket, string>();//클라이언트 소켓을 관리하는 리스트, 소켓과 접속 아이디를 관리하자.
        public Socket socket;

        List<string> connect_list = new List<string>();//접속자 리스트


        ServerProgram multiServer;
        int serverPort;
        
        public Open()
        {
            InitializeComponent();
        }

        private void allClientSend(string message, string username, bool flag)
        {
            String curDate = DateTime.Now.ToString("HH:mm:ss"); // 현재 날짜 받기
            String sendDate = DateTime.Now.ToString("G");
            String sendMsg = "";

            byte[] buffer = null;

            if (flag)
            {
                // 서버창에 클라이언트 접속 종료 메세지
                if (message.Equals("disConnect"))
                {
                    sendMsg = "[ " + curDate + " ] " + username + "님이 대화방을 나갔습니다.";
                    String sendChat = username + "님이 대화방을 나갔습니다.";
                    chatToSql(sendDate, "server", sendChat, "0");
                    chatToSql4(username);

                }
                else
                    sendMsg = "[ " + curDate + " ] " + username + " : " + message;

            }
            else
            {

                sendMsg = message;

            }
            displayMessage(sendMsg);
            multiServer.SendMessage(sendMsg);


        }

        private void displayMessage(string text)
        {
            if (chat_TextBox.InvokeRequired) //다른 쓰레드에서 실행되어 Invoke가 필요한 상태라면 
            {
                chat_TextBox.BeginInvoke(new MethodInvoker(delegate   ///델리게이트로 넘겨서 실행
                {
                    chat_TextBox.AppendText(text + Environment.NewLine);
                    chat_TextBox.ScrollToCaret();
                }));
            }
            else
            {
                chat_TextBox.AppendText(text + Environment.NewLine);
                chat_TextBox.ScrollToCaret();
            }

        }

        private void waiting_button_Click(object sender, EventArgs e)
        {
            waiting_button.Enabled = false;
            try
            {
                serverPort = Int32.Parse(port_box.Text.ToString()); // 소켓 번호 설정
            }
            catch (FormatException ex)
            {
                //textbox 에 숫자 외의 문자인 경우
                serverPort = 1004;
            }

            multiServer = new ServerProgram(serverPort);
            multiServer.OnConnect += clientConnected;
            multiServer.OnDisconnect += clientDisconncted;
            multiServer.OnReceive += clientReceive;
        }

        private void clientReceive(Socket sock, String msg)
        {
            String curDate = DateTime.Now.ToString("HH:mm:ss"); // 현재 날짜 받기
            String sendDate = DateTime.Now.ToString("G");
            String stCmd = "";
            String stData = "";
            String loginData1 = "";
            String loginData2 = "";
            String sendMsg = "";

            int index = msg.IndexOf("$");
            if (index > 0)
            {
                stCmd = msg.Substring(0, index); //$를 기준으로 앞 부분을 cmd로 
                stData = msg.Substring(index + 1);

            }
            int index1 = stData.IndexOf(":");
            if (index1 > 0)
            {
                loginData1 = stData.Substring(0, index1); //:를 기준으로 
                loginData2 = stData.Substring(index1 + 1);

            }
            if ((stCmd.ToUpper() == "Login".ToUpper()) || (stCmd.ToUpper() == "Lock".ToUpper()))
            {
                if (chatToSql1(loginData1, loginData2) == true)
                {
                    // 서버창에 클라이언트 접속 완료 메세지
                    clientSocketList[sock] = loginData1; // Login 사용자명 셋팅
                    sendMsg = "[ " + curDate + " ] " + loginData1 + "님이 입장하셨습니다.";
                    String sendChat = loginData1 + "님이 입장하셨습니다.";
                    chatToSql(sendDate, "server", sendChat, "0");
                    chatToSql3(loginData1);
                }
                else
                {
                    // 서버창에 클라이언트 접속 실패 메세지
                    sendMsg = "[ " + curDate + " ] " + loginData1 + "님이 로그인 실패하였습니다.";
                    String sendChat = loginData1 + "님이 로그인 실패하였습니다.";
                    chatToSql(sendDate, "server", sendChat, "0");
                }

            }
            else if (stCmd.ToUpper() == "Register".ToUpper())
            {
                // 서버창에 클라이언트 회원 가입 메세지
                chatToSql2(loginData1, loginData2);
                sendMsg = "[ " + curDate + " ] " + loginData1 + "님이 회원가입하셨습니다.";
                String sendChat = loginData1 + "님이 회원가입하셨습니다.";
                chatToSql(sendDate, "server", sendChat, "0");

            }
            else if (stData != "")
            {
                sendMsg = "[ " + curDate + " ] " + stCmd + " : " + stData;
                String sendChat = stCmd + " : " + stData;
                chatToSql(sendDate, stCmd, stData, "0");
            }
            if (stCmd != "")
            {
                displayMessage(sendMsg);
                if (multiServer != null) multiServer.SendMessage(sendMsg);
            }

        }

        private void clientDisconncted(Socket sock)
        {
            String userName;
            if (clientSocketList.ContainsKey(sock))
            {
                userName = clientSocketList[sock];
                allClientSend("disConnect", userName, true);
                clientSocketList.Remove(sock);
            }
        }

        private void clientConnected(Socket sock)
        {
            clientSocketList.Add(sock, "");
        }

        public void chatToSql(String savedate, String saveuser, String savechat, String saveerror) //로그 기록
        {
            using (MySqlConnection connection = new MySqlConnection("Server=192.168.100.48;Port=3306;Database=chat;Uid=test;Pwd=1111"))
            {

                string insertQuery = string.Format("INSERT INTO chatlog(date,user,log,errorcode) VALUES('{0}','{1}','{2}','{3}');", savedate, saveuser, savechat, saveerror);
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);

                    if (command.ExecuteNonQuery() == 1)
                    {
                        Console.WriteLine("로그기록 성공");
                    }
                    else
                    {
                        Console.WriteLine("로그기록 실패");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("실패");
                    Console.WriteLine(ex.ToString());
                }
            }
        }
        public bool chatToSql1(String loginData1, String loginData2) //아이디, 패스워드 일치하면 로그인 처리
        {
            using (MySqlConnection connection = new MySqlConnection("Server=192.168.100.48;Port=3306;Database=chat;Uid=test;Pwd=1111"))
            {
                bool login_status = false;
                string selectQuery = string.Format("SELECT * FROM idpw WHERE id = \'" + loginData1 + "\' ");
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(selectQuery, connection);

                    MySqlDataReader userAccount = command.ExecuteReader();
                    //userAccount에 데이터 조회하여 객체 반환하여 저장

                    while (userAccount.Read())
                    {
                        if (loginData1 == (string)userAccount["id"] && loginData2 == (string)userAccount["pw"])
                        {
                            //데이터베이스에 저장된 값과 같으면
                            login_status = true;
                        }
                    }
                    connection.Close();

                    if (login_status == true)
                    {
                        Console.WriteLine("로그인 성공");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("로그인 실패");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
        }
        public void chatToSql2(String id, String pw) //회원가입 데이터 저장
        {
            using (MySqlConnection connection = new MySqlConnection("Server=192.168.100.48;Port=3306;Database=chat;Uid=test;Pwd=1111"))
            {

                string insertQuery = string.Format("INSERT INTO idpw(id,pw) VALUES('{0}','{1}');", id, pw);
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);

                    if (command.ExecuteNonQuery() == 1)
                    {
                        Console.WriteLine("인서트 성공");
                    }
                    else
                    {
                        Console.WriteLine("인서트 실패");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("실패");
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        public void chatToSql3(String id) //접속 --> 접속자 id 리스트에 저장
        {
            using (MySqlConnection connection = new MySqlConnection("Server=192.168.100.48;Port=3306;Database=chat;Uid=test;Pwd=1111"))
            {

                string insertQuery = string.Format("INSERT INTO connected_id(id) VALUES('{0}');", id);
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);

                    if (command.ExecuteNonQuery() == 1)
                    {
                        Console.WriteLine("인서트 성공");
                        addIDlist(id);
                    }
                    else
                    {
                        Console.WriteLine("인서트 실패");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("실패");
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        public void chatToSql4(String id) //접속해제 --> 접속해제 id를 listbox에서 삭제
        {
            using (MySqlConnection connection = new MySqlConnection("Server=192.168.100.48;Port=3306;Database=chat;Uid=test;Pwd=1111"))
            {

                string deleteQuery = string.Format("DELETE FROM connected_id WHERE id=\'"+ id +"\'");
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(deleteQuery, connection);

                    if (command.ExecuteNonQuery() == 1)
                    {
                        Console.WriteLine("딜리트 성공");
                        remIDlist(id);
                    }
                    else
                    {
                        Console.WriteLine("딜리트 실패");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("실패");
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        public bool chatToSql5(String loginData1) //중복 로그인 체크 (완성X 사용X)
        {
            using (MySqlConnection connection = new MySqlConnection("Server=192.168.100.48;Port=3306;Database=chat;Uid=test;Pwd=1111"))
            {
                bool login_status = false;
                string selectQuery = string.Format("SELECT * FROM connected_id WHERE id = \'"+ loginData1 + "\' ");
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(selectQuery, connection);

                    MySqlDataReader userAccount = command.ExecuteReader();
                    //userAccount에 데이터 조회하여 객체 반환하여 저장

                    while (userAccount.Read())
                    {
                        if (loginData1 == (string)userAccount["id"]) //비교대상 중 하나를 접속id테이블로 변경해야함
                        {
                            //데이터베이스에 저장된 값과 같으면
                            login_status = true;
                            MessageBox.Show("이미 사용중입니다. 다시 로그인 해주세요");
                            return false;
                        }
                    }
                    connection.Close();

                    if (login_status == true)
                    {
                        Console.WriteLine("로그인 성공");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("로그인 실패");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
        }

        public void chatToSql6() //SocketClose시 접속자리스트(listbox)와 접속id DB데이터 비우기
        {
            using (MySqlConnection connection = new MySqlConnection("Server=192.168.100.48;Port=3306;Database=chat;Uid=test;Pwd=1111"))
            {

                string deleteQuery = string.Format("TRUNCATE connected_id");
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(deleteQuery, connection);

                    if (command.ExecuteNonQuery() == 1)
                    {
                        Console.WriteLine("초기화 성공");
                        clearIDlist();
                    }
                    else
                    {
                        Console.WriteLine("초기화 실패");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("실패");
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        public void addIDlist(String username) //접속자리스트(listbox)에 id 추가
        {

            connect_list.Add(username);
            connect_ListBox.Items.Clear(); //listbox 초기화
            foreach (var i in connect_list)
            {
                connect_ListBox.Items.Add(i); //textbox에 리스트 업데이트
                connect_ListBox.SelectedIndex = connect_ListBox.Items.Count - 1;
                connect_ListBox.SelectedIndex = -1;
            }
            
            //connect_TextBox.ScrollToCaret();

        }

        public void remIDlist(String username) //접속자리스트(listbox)에 id 삭제
        {
            connect_list.Remove(username);
            connect_ListBox.Items.Clear(); //listbox 초기화
            foreach (var i in connect_list)
            {
                connect_ListBox.Items.Add(i); //textbox에 리스트 업데이트
                connect_ListBox.SelectedIndex = connect_ListBox.Items.Count - 1;
                connect_ListBox.SelectedIndex = -1;
            }
            
            //connect_TextBox.ScrollToCaret();

        }

        public void clearIDlist() //접속자리스트(listbox) 비우기
        {
            //connect_list = null;
            connect_ListBox.Items.Clear(); //listbox 초기화
            //connect_TextBox.ScrollToCaret();

        }

        public void close_button_Click(object sender, EventArgs e)
        {
            //socket = null;
            chatToSql6();
            //connect_list = null;
            this.Close();
            //Application.Exit();

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
