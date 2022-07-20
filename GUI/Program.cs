using BLL;
using DTO;
using PBL3.View.admin;
using PBL3.View.homepage;
using PBL3.View.statistics;
using System;
using System.Windows.Forms;
using Util;

namespace PBL3
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
            Account account = AccountBLL.Instance.CheckAccount(new Account
            {
                username = "daitoan2000@gmail.com",
                password = HashPassword.GetHash("admin")
            }); 
            //Application.Run(new AdminManagement(account));
            Application.Run(new Homepage(account));
            //Application.Run(new LoginForm());
            //Application.Run(new Form1());
        }
    }
}
