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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login Success!");
            this.Hide();
            Homepage f = new Homepage();
            f.Closed += (s, args) => this.Close();
            f.Show();
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
