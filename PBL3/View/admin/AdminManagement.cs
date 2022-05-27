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
            manacontainer.Visible = false;
            btnStatistic.Location = new Point(0, 496);
            account = ac;
        }
        public void SetActivePanel(UserControl control)
        {
            //set all usercontrol false
            employeeManagement1.Visible = false;
            customer1.Visible = false;
            tourManagement1.Visible = false;
            accountEmployee1.Visible = false;
            customerAccount1.Visible = false;
            roleAccount1.Visible = false;
            ticketManagement1.Visible = false;
            billManagement1.Visible = false;
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
        private void btnAccountEmployee_Click(object sender, EventArgs e)
        {
            SetActivePanel(accountEmployee1);
            hidesubmenu();
            btnStatistic.Location = new Point(0, 496);
        }
        private void hidesubmenu()
        {
            if (manacontainer.Visible == true)
            {
                manacontainer.Visible = false;
            }

        }
        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
                btnStatistic.Location = new Point(0, 602);
            }
            else
            {
                submenu.Visible = false;
                btnStatistic.Location = new Point(0, 496);
            }

        }
        private void btnBackHomepage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage homepage = new Homepage(account);
            homepage.Closed += (s, args) => this.Close();
            homepage.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            showsubmenu(manacontainer);
        }

        private void btnCustomerAcc_Click(object sender, EventArgs e)
        {
            hidesubmenu();
            btnStatistic.Location = new Point(0, 496);
            SetActivePanel(customerAccount1);
        }

        private void btnRoleAcc_Click(object sender, EventArgs e)
        {
            hidesubmenu();
            btnStatistic.Location = new Point(0, 496);
            SetActivePanel(roleAccount1);
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            SetActivePanel(ticketManagement1);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
             SetActivePanel(billManagement1);
        }
    }
}
