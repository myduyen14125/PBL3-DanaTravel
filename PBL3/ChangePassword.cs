<<<<<<< HEAD
﻿using BUS;
using DTO;
using System;
=======
﻿using System;
>>>>>>> 1f610b108cb2bcdb6e5e00232094a61663f2281c
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using Util;
=======
>>>>>>> 1f610b108cb2bcdb6e5e00232094a61663f2281c

namespace PBL3
{
    public partial class ChangePassword : Form
    {
<<<<<<< HEAD
        private string email;
        private int code;
        public ChangePassword(string email, int code)
        {
            InitializeComponent();
            this.email = email;
            this.code = code;
=======
        public ChangePassword()
        {
            InitializeComponent();
>>>>>>> 1f610b108cb2bcdb6e5e00232094a61663f2281c
        }

        private void newPassword_Click(object sender, EventArgs e)
        {
            txtPass.Text = "";
            txtPass.PasswordChar = '*';
        }

        private void txtConfirm_Click(object sender, EventArgs e)
        {
            txtConfirm.Text = "";
            txtConfirm.PasswordChar = '*';
        }

        private void txtCode_Click(object sender, EventArgs e)
        {
            txtCode.Text = "";
        
        }
<<<<<<< HEAD

        private void btnChange_Click(object sender, EventArgs e)
        {
            string password = txtPass.Text.Trim();
            string confirmPass = txtConfirm.Text.Trim();
            int code = Convert.ToInt32(txtCode.Text.Trim());

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password is empty. Please re-enter password");
                txtPass.Focus();
            }
            if (string.IsNullOrEmpty(confirmPass))
            {
                MessageBox.Show("Confirm Password is empty. Please re-enter confirm password");
                txtConfirm.Focus();
            }
            if (!confirmPass.Equals(password))
            {
                MessageBox.Show("Confirm Password didn't match. Try again");
                txtConfirm.Focus();
            }
            if (code != this.code)
            {
                MessageBox.Show("Verified code didn't match. Please check your email to get the verified code");
            }


            if (AccountBUS.Instance.ChangePassword(new Account(email, HashPassword.GetHash(password))))
            {
                this.Hide();
                LoginForm f = new LoginForm();
                f.Closed += (s, args) => this.Close();
                f.Show();
            }
        }
=======
>>>>>>> 1f610b108cb2bcdb6e5e00232094a61663f2281c
    }
}
