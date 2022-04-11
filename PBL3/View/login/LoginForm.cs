using BUS;
using DAO;
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
    public partial class LoginForm : Form
    {
        private Validate validate = new Validate();


        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text.Trim();
            string password = passwdInput.Text.Trim();

            if(!ValidateFormLogin())
            {
                return;
            }
            Account account = new Account(username, HashPassword.GetHash(password));
            account = AccountBUS.Instance.CheckAccount(account);
            if (account != null)
            {
                if (!account.status)
                {
                    MessageBox.Show("Your account has been lock");
                    return;
                }

                this.Hide();
                Homepage f = new Homepage(account);
                f.Closed += (s, args) => this.Close();
                f.Show();
            }
            else   MessageBox.Show("Email or Password incorrect");
            
        }

        private void signupLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignupForm f = new SignupForm();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void forgotPassLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgetPass f = new ForgetPass();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private bool ValidateFormLogin()
        {
            // Nếu chưa nhập email
            if (string.IsNullOrEmpty(usernameInput.Text))
            {
                MessageBox.Show("Please re-enter your email !!!");
                usernameInput.Focus();
                return false;
            }
            if (!validate.ValidateEmail(usernameInput.Text))
            {
                MessageBox.Show("Email invalid !!!");
                usernameInput.Focus();
                return false;
            }

            // Nếu chưa nhập password
            if (string.IsNullOrEmpty(passwdInput.Text))
            {
                MessageBox.Show("Please re-enter your password !!!");
                passwdInput.Focus();
                return false;
            }
            return true;
        }
    }
}
