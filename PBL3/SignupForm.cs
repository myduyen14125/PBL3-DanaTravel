using BUS;
using DTO;
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
    public partial class SignupForm : Form
    {
        private int code;
        private string username;
        private string pass;
        public SignupForm()
        {
            InitializeComponent();
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            username = usernameInput.Text.Trim();
            pass = passInput.Text.Trim();
            string confirmPassword = confirmPassInput.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter email");
                usernameInput.Focus();
                return;
            }

            if (string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please enter password");
                passInput.Focus();
                return;
            }

            if (string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please enter confirm password");
                confirmPassInput.Focus();
                return;
            }

            if (!pass.Equals(confirmPassword))
            {
                MessageBox.Show("Password didn't match. Try again");
                confirmPassInput.Focus();
                return;
            }

            Account account = new Account(username, HashPassword.GetHash(pass), true);
            bool success = AccountBUS.Instance.RegisterAccount(account);
            if (success)
            {
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Email already exists");
            }
            //frontend
            OTPbox.Visible = true;
            txtOTP.Visible = true;
        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm f = new LoginForm();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void usernameInput_Click(object sender, EventArgs e)
        {
            usernameInput.Text = "";
        }

        private void passInput_Click(object sender, EventArgs e)
        {
            passInput.Text = "";
            passInput.PasswordChar = '*';
        }

        private void confirmPassInput_Click(object sender, EventArgs e)
        {
            confirmPassInput.Text = "";
            confirmPassInput.PasswordChar = '*';
        }
<<<<<<< HEAD
        private void txtOTP_Click(object sender, EventArgs e)
        {
            confirmPassInput.Text = "";
        }

        private void btnGetCode_Click(object sender, EventArgs e)
        {
            username = usernameInput.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter email");
                usernameInput.Focus();
                return;
            }
            SendEmailHelper send = new SendEmailHelper();
            send.SendCodeToEmail(username, "DanaTravel send your code for register account");
            code = send.GetCode();
        }


        private void btnGetOTP_Click(object sender, EventArgs e)
        {
            username = usernameInput.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter email");
                usernameInput.Focus();
                return;
            }
            SendEmailHelper send = new SendEmailHelper();
            send.SendCodeToEmail(username, "DanaTravel send your code for register account");
            code = send.GetCode();
        }
=======
>>>>>>> 1f610b108cb2bcdb6e5e00232094a61663f2281c
    }
}
