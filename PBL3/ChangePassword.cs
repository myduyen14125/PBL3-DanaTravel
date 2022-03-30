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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
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
    }
}
