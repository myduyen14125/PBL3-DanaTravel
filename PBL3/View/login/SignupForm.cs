﻿using BUS;
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
    public partial class SignupForm : Form
    {
        private int code;
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

        public SignupForm()
        {
            InitializeComponent();
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
            if (usernameInput.Text == "E-mail address")
                usernameInput.Text = "";
            if (passInput.Text == "")
            {
                passInput.Text = "Password";
                passInput.PasswordChar = '\0';
            }
            if (confirmPassInput.Text == "")
            {
                confirmPassInput.Text = "Confirm password";
                confirmPassInput.PasswordChar = '\0';
            }
            if (txtOTP.Text == "")
            {
                txtOTP.Text = "Input OTP";
            }
        }

        private void passInput_Click(object sender, EventArgs e)
        {
            if (passInput.Text == "Password")
            {
                passInput.Text = "";
                passInput.PasswordChar = '*';
            }
            if (usernameInput.Text == "")
            {
                usernameInput.Text = "E-mail address";
            }
            if (confirmPassInput.Text == "")
            {
                confirmPassInput.Text = "Confirm password";
                confirmPassInput.PasswordChar = '\0';
            }
            if (txtOTP.Text == "")
            {
                txtOTP.Text = "Input OTP";
            }
        }

        private void confirmPassInput_Click(object sender, EventArgs e)
        {
            if (confirmPassInput.Text == "Confirm password")
            {
                confirmPassInput.Text = "";
                confirmPassInput.PasswordChar = '*';
            }
            if (usernameInput.Text == "")
            {
                usernameInput.Text = "E-mail address";
            }
            if (passInput.Text == "")
            {
                passInput.Text = "Password";
                passInput.PasswordChar = '\0';
            }
            if (txtOTP.Text == "")
            {
                txtOTP.Text = "Input OTP";
            }
        }


        private void txtOTP_Click(object sender, EventArgs e)
        {
            if (txtOTP.Text == "Input OTP")
            {
                txtOTP.Text = "";
            }
            if (usernameInput.Text == "")
            {
                usernameInput.Text = "E-mail address";
            }
            if (passInput.Text == "")
            {
                passInput.Text = "Password";
                passInput.PasswordChar = '\0';
            }
            if (confirmPassInput.Text == "")
            {
                confirmPassInput.Text = "Confirm password";
                confirmPassInput.PasswordChar = '\0';
            }
        }


        private void btnGetOTP_Click(object sender, EventArgs e)
        {
            if (!ValidateEmail()) return;
            this.BeginInvoke((MethodInvoker)delegate
            {
                this.code = Convert.ToInt32(new Random().Next(100000, 999999));
                string sendTo = usernameInput.Text;
                string subject = "DanaTravel send your code for register account";
                string body = "<h3>Please do not share the code to ensure safety and security.</h3> <h1> Your code: " + this.code.ToString() + "</h1>";
                new SendEmailHelper().SendEmail(sendTo, subject, body);
            });
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            string user = usernameInput.Text.Trim();
            string pass = passInput.Text.Trim();
            string confirmPassword = confirmPassInput.Text.Trim();

            if (!ValidateSignUpForm())
            {
                return;
            }
            if (txtOTP.Text != code.ToString())
            {
                MessageBox.Show("OTP invalid");
                return;
            }
                
            Account account = new Account(user, HashPassword.GetHash(pass), true);
            bool success = AccountBUS.Instance.RegisterAccount(account);
            if (success)
            {
                MessageBox.Show("Register account success");
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Email already exists");
            }
        }

        private bool ValidateSignUpForm()
        {
            ValidateEmail();

            if (string.IsNullOrEmpty(passInput.Text) || passInput.Text == "Password")
            {
                MessageBox.Show("Please enter password");
                passInput.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(confirmPassInput.Text) || confirmPassInput.Text == "Confirm password")
            {
                MessageBox.Show("Please enter confirm password");
                confirmPassInput.Focus();
                return false;
            }

            if (!passInput.Text.Equals(confirmPassInput.Text))
            {
                MessageBox.Show("Password didn't match. Try again");
                confirmPassInput.Focus();
                return false;
            }
            if (txtOTP.Text == "Input OTP" || txtOTP.Text == "")
            {
                MessageBox.Show("Enter code OTP to register account.");
                return false;
            }

            return true;
        }

        private bool ValidateEmail()
        {
            Validate validate = new Validate();
            if (string.IsNullOrEmpty(usernameInput.Text))
            {
                MessageBox.Show("Please enter email");
                usernameInput.Focus();
                return false;
            }

            if (!validate.ValidateEmail(usernameInput.Text))
            {
                MessageBox.Show("Email invalid");
                usernameInput.Focus();
                return false;
            }
            return true;
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {
            btnGetOTP.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnGetOTP.Width, btnGetOTP.Height, 30, 30));
            signupBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, signupBtn.Width, signupBtn.Height, 30, 30));
        }
    }
}
