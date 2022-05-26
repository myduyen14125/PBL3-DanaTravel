using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace PBL3
{
    public partial class ForgetPass : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidthEclipse,
                int nHeightEclipse
            );
        public ForgetPass()
        {
            InitializeComponent();
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm f = new LoginForm();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Validate validate = new Validate();
            SendEmailHelper sendEmail = new SendEmailHelper();
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrEmpty(email) || !validate.ValidateEmail(email))
            {
                MessageBox.Show("Email invalid. Please re-enter your email.");
                return;
            }
            int code = Convert.ToInt32(new Random().Next(100000, 999999));
            string subject = "DanaTravel send your code for change password";
            string body = "<h3>Please do not share the code to ensure safety and security.</h3> <h1> Your code: " + code.ToString() + "</h1>";
            if (sendEmail.SendEmail(email, subject, body))
            {
                this.Hide();
                ChangePassword f = new ChangePassword(email, code);
                f.Closed += (s, args) => this.Close();
                f.Show();
            }
            else
            {
                MessageBox.Show("Email not found !!!");
            }
        }

        private void ForgetPass_Load(object sender, EventArgs e)
        {
            btnReset.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnReset.Width, btnReset.Height, 30, 30));
        }
    }
}