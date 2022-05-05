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
            pnChoice.Visible = false;
            this.account = ac;
            if (account.Roles.FirstOrDefault().name.ToLower() == "customer")
            {
                // Customer
                btnAdmin.Visible = false;
            }
            else btnAdmin.Visible = true;
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pnChoice.Visible = true;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminManagement f = new AdminManagement();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f = new LoginForm();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
