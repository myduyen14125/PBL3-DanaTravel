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
        public SignupForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Signup success!");
            this.Hide();
            Homepage f = new Homepage();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm f = new LoginForm();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
