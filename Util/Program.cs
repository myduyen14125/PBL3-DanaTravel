using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
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
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            SendEmailHelper send = new SendEmailHelper();
            if (send.SendEmail("nguyentoan102002@gmail.com", "Hello", "123"))
                Console.WriteLine("success");
            Console.WriteLine("Đã gửi mail");
            Console.ReadLine();
        }
    }
}
