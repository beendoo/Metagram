using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MergeServer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (dbConnectCheck() == "success")
            {
                MessageBox.Show("Connected to DB OK...");
                Application.Run(new Open());
            }

            else
            {
                MessageBox.Show("Connected to DB Failed...");
                Application.Exit();
            }
        }

        public static string dbConnectCheck()    //DB 연결 확인 함수
        {
            using (MySqlConnection connection = new MySqlConnection("Server=192.168.100.48;Port=3306;Database=chat;Uid=test;Pwd=1111"))
            {
                try
                {
                    connection.Open();

                    if (connection.Ping() == true)
                    {
                        Console.WriteLine("Connected to DB OK...");
                        return "success";
                    }
                    else
                    {
                        Console.WriteLine("Connected to DB Failed...");
                        return "failed";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("DB 연결 실패");
                    Console.WriteLine(ex.ToString());
                    return ex.ToString();
                }
            }
        }
    }
}