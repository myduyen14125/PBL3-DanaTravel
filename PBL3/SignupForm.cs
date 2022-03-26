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

namespace PBL3
{
    public partial class SignupForm : Form
    {
        private SignupBUS signupBUS = new SignupBUS();
        public SignupForm()
        {
            InitializeComponent();
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string password = passInput.Text;
            string confirmPassword = confirmPassInput.Text;

            if(string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter email");
                usernameInput.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
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

            if(!password.Equals(confirmPassword))
            {
                MessageBox.Show("Password didn't match. Try again");
                confirmPassInput.Focus();
                return;
            }

            AccountDTO account = new AccountDTO(username, password);
            bool success = signupBUS.Register(account);
            if(success)
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
    }
}
