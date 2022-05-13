using PBL3.View.admin;
using PBL3.View.tour;
using PBL3.viewHtml;
using System;
using System.Windows.Forms;

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
            Application.Run(new AdminManagement());
        }
    }
}
