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
    public partial class ChangePasswordForm : Form
    {
        private int code;
        private string email;
        public ChangePasswordForm(string email, int code)
        {
            InitializeComponent();
            this.email = email;
            this.code = code;
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.code.ToString());
            string password = txtNewPass.Text.Trim();
            string confirmPass = txtConfirmPass.Text.Trim();
            int code = Convert.ToInt32(txtCode.Text.Trim());

            if(string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password is empty. Please re-enter password");
                txtNewPass.Focus();
            }
            if (string.IsNullOrEmpty(confirmPass))
            {
                MessageBox.Show("Confirm Password is empty. Please re-enter confirm password");
                txtConfirmPass.Focus();
            }
            if(!confirmPass.Equals(password))
            {
                MessageBox.Show("Confirm Password didn't match. Try again");
                txtConfirmPass.Focus();
            }
            if(code != this.code)
            {
                MessageBox.Show("Verified code didn't match. Please check your email to get the verified code");
            }

            
            if(AccountBUS.Instance.ChangePassword(new Account(email, HashPassword.GetHash(password))))
            {
                this.Hide();
                LoginForm f = new LoginForm();
                f.Closed += (s, args) => this.Close();
                f.Show();
            }
        }
    }
}
