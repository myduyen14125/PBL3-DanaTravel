using BUS;
using DTO;
using PBL3.View.admin;
using PBL3.View.homepage;
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
        private List<TourDTO> tours;
        private Account account;
        private int index_start = 0;
        public Homepage(Account ac)
        {
            InitializeComponent();
            pnChoice.Visible = false;
            this.account = ac;
            //if (account.Roles.FirstOrDefault().name.ToLower() == "customer")
            //{
            //    // Customer
            //    btnAdmin.Visible = false;
            //}
            //else btnAdmin.Visible = true;
        }
         private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminManagement f = new AdminManagement(account);
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

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            pnChoice.Visible = true;
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                tours = TourBUS.Instance.GetTourDTOs(0, "");
                if (tours.Count == 0) return;
                TourItemView t;
                t = new TourItemView(tours[index_start], this);
                t.Dock = DockStyle.Fill;
                panel1.Controls.Add(t);
                
                if (tours.Count == 1) return;
                t = new TourItemView(tours[index_start + 1], this);
                panel2.Controls.Add(t);
                t.Dock = DockStyle.Fill;
                if (tours.Count == 2) return;
                t = new TourItemView(tours[index_start + 2], this);
                panel3.Controls.Add(t);
                t.Dock = DockStyle.Fill;
                if (tours.Count == 3) return;
                t = new TourItemView(tours[index_start + 3], this);
                panel4.Controls.Add(t);
                t.Dock = DockStyle.Fill;
            }
        }
        public void HideHomePage()
        {
            panelHomepage.Visible = false;
            this.Size = new System.Drawing.Size(880, 820);
            this.AutoScrollMinSize = new System.Drawing.Size(0, 1050);
        }

        public void ShowHomePage()
        {
            panelHomepage.Visible = true;
            this.Size = new System.Drawing.Size(1115, 820);
            this.AutoScrollMinSize = new System.Drawing.Size(0, 1500);
        }

        private void lbHomepage_MouseLeave(object sender, EventArgs e)
        {
            lbHomepage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(132)))));
        }

        private void lbHomepage_MouseHover(object sender, EventArgs e)
        {
            lbHomepage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(104)))), ((int)(((byte)(49)))));
        }
    }
}
