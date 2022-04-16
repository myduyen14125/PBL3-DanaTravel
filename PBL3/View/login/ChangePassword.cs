using BUS;
using DTO;
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
    public partial class ChangePassword : Form
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

        private string email;
        private int code;
        public ChangePassword(string email, int code)
        {
            InitializeComponent();
            this.email = email;
            this.code = code;
        }

        private void newPassword_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "New password")
            {
                txtPass.Text = "";
                txtPass.PasswordChar = '*';
            }
            if (txtConfirm.Text == "")
            {
                txtConfirm.Text = "Confirm password";
                txtConfirm.PasswordChar = '\0';
            }
            if (txtCode.Text == "")
            {
                txtCode.Text = "Code";
            }
        }

        private void txtConfirm_Click(object sender, EventArgs e)
        {
            if (txtConfirm.Text == "Confirm password")
            {
                txtConfirm.Text = "";
                txtConfirm.PasswordChar = '*';
            }

            if (txtPass.Text == "")
            {
                txtPass.Text = "New password";
                txtPass.PasswordChar = '\0';
            }
            if (txtCode.Text == "")
            {
                txtCode.Text = "Code";
            }
        }

        private void txtCode_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "Code")
            {
                txtCode.Text = "";
            }
            if (txtPass.Text == "")
            {
                txtPass.Text = "New password";
                txtPass.PasswordChar = '\0';
            }
            if (txtConfirm.Text == "")
            {
                txtConfirm.Text = "Confirm password";
                txtConfirm.PasswordChar = '\0';
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string password = txtPass.Text.Trim();
            string confirmPass = txtConfirm.Text.Trim();
            
            if(!ValidateFormChange())
            {
                return;
            }

            if (AccountBUS.Instance.ChangePassword(new Account(email, HashPassword.GetHash(txtPass.Text))))
            {
                this.Hide();
                LoginForm f = new LoginForm();
                f.Closed += (s, args) => this.Close();
                f.Show();
            }
        }
        private bool ValidateFormChange()
        {
            if (string.IsNullOrEmpty(txtPass.Text) || txtPass.Text == "New password")
            {
                MessageBox.Show("Password is empty. Please re-enter password");
                txtPass.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtConfirm.Text) || txtConfirm.Text == "Confirm password")
            {
                MessageBox.Show("Confirm Password is empty. Please re-enter confirm password");
                txtConfirm.Focus();
                return false;
            }
            if (!txtConfirm.Text.Equals(txtPass.Text))
            {
                MessageBox.Show("Confirm Password didn't match. Try again");
                txtConfirm.Focus();
                return false;
            }

            if(txtCode.Text == "")
            {
                MessageBox.Show("Code is empty. Please re-enter code");
                txtCode.Focus();
                return false;
            }
            int code = Convert.ToInt32(txtCode.Text.Trim());
            if (code != this.code)
            {
                MessageBox.Show("Verified code didn't match. Please check your email to get the verified code");
                return false;
            }
            return true;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            btnChange.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnChange.Width, btnChange.Height, 30, 30));
        }
    }
}
