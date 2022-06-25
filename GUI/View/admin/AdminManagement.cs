using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using DTO;

namespace PBL3.View.admin
{
    public partial class AdminManagement : Form
    {

        private Account account;
        public AdminManagement(Account ac)
        {
            InitializeComponent();
            Load += AdminManagement_Load;
            account = ac;
        }
        public void SetActivePanel(UserControl control)
        {
            employeeManagement1.Visible = false;
            customer1.Visible = false;
            tourManagement1.Visible = false;
            accountEmployee1.Visible = false;
            ticketManagement1.Visible = false;
            billManagement1.Visible = false;
            statistic1.Visible = false;
            control.Visible = true;
        }

        private void AdminManagement_Load(object sender, EventArgs e)
        {
            SetActivePanel(employeeManagement1);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            SetActivePanel(employeeManagement1);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            SetActivePanel(customer1);
        }

        private void btnTour_Click(object sender, EventArgs e)
        {
            SetActivePanel(tourManagement1);
        }
        private void btnStatistic_Click(object sender, EventArgs e)
        {
            SetActivePanel(statistic1);
        }

        private void btnAccountEmployee_Click(object sender, EventArgs e)
        {
            SetActivePanel(accountEmployee1);
            accountEmployee1.ShowDataAccount();
        
        }
      
        private void btnBackHomepage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage homepage = new Homepage(account);
            homepage.Closed += (s, args) => this.Close();
            homepage.Show();
        }

      
        private void btnTicket_Click(object sender, EventArgs e)
        {
            SetActivePanel(ticketManagement1);
            ticketManagement1.ShowData();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
             SetActivePanel(billManagement1);
            billManagement1.ShowData();
        }

    }
}
