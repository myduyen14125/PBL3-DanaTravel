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

namespace PBL3
{
    public partial class LoginScr : Form
    {
        public LoginScr()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f = new LoginForm();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignupForm f = new SignupForm();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
