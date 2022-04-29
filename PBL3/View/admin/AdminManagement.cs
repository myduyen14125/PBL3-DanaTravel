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

namespace PBL3.View.admin
{
    public partial class AdminManagement : Form
    {
        public AdminManagement()
        {
            InitializeComponent();
            Load += AdminManagement_Load;
        }
        public void SetActivePanel(UserControl control)
        {
            //set all usercontrol false
            employeeManagement1.Visible = false;
            customer1.Visible = false;
            tourManagement1.Visible = false;
            transportManagement1.Visible = false;
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

        private void btnTour_Click_1(object sender, EventArgs e)
        {
            SetActivePanel(tourManagement1);
        }

        private void btnTransport_Click(object sender, EventArgs e)
        {
            SetActivePanel(transportManagement1);
        }
    }
}
