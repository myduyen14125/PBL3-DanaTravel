using BUS;
using DTO;
using PBL3.View.admin;
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
            Account account = AccountBUS.Instance.CheckAccount(new Account
            {
                username = "daitoan2000@gmail.com",
                password = HashPassword.GetHash("admin")
            }); ;
            Application.Run(new AdminManagement(account));
           // Application.Run(new Homepage(account));
        }
    }
}
