using DTO;
using PBL3.View.admin;
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
    public partial class Homepage : Form
    {
        private Account account;
        public Homepage(Account ac)
        {
            InitializeComponent();
            this.account = ac;
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void choiceAdmin_Click(object sender, EventArgs e)
        {
            //this.Hide();
            AdminManagement f = new AdminManagement();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void choiceLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f = new LoginForm();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
