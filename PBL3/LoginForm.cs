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
        private LoginDAO loginDAO = new LoginDAO();


        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string password = passwdInput.Text;

            // Nếu chưa nhập email
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please re-enter your email !!!");
                usernameInput.Focus();
                return;
            }
            if(!validate.ValidateEmail(username))
            {
                MessageBox.Show("Email invalid !!!");
                usernameInput.Focus();
                return;
            }
            // Nếu chưa nhập password
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please re-enter your password !!!");
                passwdInput.Focus();
                return;
            }
            username = username.Trim();
            password = password.Trim();
            AccountDTO account = new AccountDTO(username, password);
            account = loginDAO.checkAccount(account);
            if (account != null)
            {
                if (!account.status)
                {
                    MessageBox.Show("Your account has been lock");
                    return;
                }
                Homepage homepage = new Homepage();
                homepage.Show();
                this.Hide();
            }
            else   MessageBox.Show("Please re-enter your email and password !!!");
            
        }

        private void signupLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignupForm f = new SignupForm();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
