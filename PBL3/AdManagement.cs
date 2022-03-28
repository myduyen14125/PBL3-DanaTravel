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
    public partial class AdManagement : Form
    {
        public AdManagement()
        {
            InitializeComponent();
            Load += AdManagement_Load;
        }

        private void AdManagement_Load(object sender, EventArgs e)
        {
            SetActivePanel(humanResource);
        }
        private void btnHuman_Click(object sender, EventArgs e)
        {
            SetActivePanel(humanResource);
            //Or: humanResource.BringToFront();
        }

        private void btnTour_Click(object sender, EventArgs e)
        {
            SetActivePanel(tourManagement);
        }
        public void SetActivePanel(UserControl control)
        {
            //set all usercontrol false
            humanResource.Visible = false;
            tourManagement.Visible = false;
            control.Visible = true;
        }
    }
}
