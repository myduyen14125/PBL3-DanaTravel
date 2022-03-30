using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace PBL3
{
    public partial class ForgetPass : Form
    {
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
            if (sendEmail.SendCodeToEmail(email, "DanaTravel send your code for change password"))
            {
                this.Hide();
                ChangePassword f = new ChangePassword(email, sendEmail.GetCode());
                f.Closed += (s, args) => this.Close();
                f.Show();
            }
            else
            {
                MessageBox.Show("Email not found !!!");
            }
        }
    }
}