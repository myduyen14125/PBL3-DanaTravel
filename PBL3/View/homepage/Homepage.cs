using BUS;
using DTO;
using PBL3.View.admin;
using PBL3.View.homepage;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PBL3
{
    public partial class Homepage : Form
    {
        private List<TourDTO> tours;
        public Account account { get; set; }
        private int index_start = 0;
        public Homepage(Account ac)
        {
            InitializeComponent();
            pnChoice.Visible = false;
            this.account = ac;

            btnAdmin.Visible = AccountBUS.Instance.IsRoleCustomer(account) ? false : true;
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
                ShowTour();
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

        private void btnRight_Click(object sender, EventArgs e)
        {
            if(index_start < tours.Count - 1)
            {
                index_start++;
                ShowTour();
            }        
        }

        private void btnleft_Click(object sender, EventArgs e)
        {
            if (index_start > 0)
            {
                index_start--;
                ShowTour();
            }
        }
        private void ShowTour()
        {
            string search = txtSearch.Text == "Search" ? "" : txtSearch.Text;
            tours = TourBUS.Instance.GetTourDTOs(0, search);

            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel3.Controls.Clear();
            panel4.Controls.Clear();

            if (tours.Count == 0) return;
            TourItemView t;
            t = new TourItemView(tours[index_start], this);
            t.Dock = DockStyle.Fill;
            panel1.Controls.Add(t);

            if (index_start + 1 >= tours.Count) return;
            t = new TourItemView(tours[index_start + 1], this);
            t.Dock = DockStyle.Fill;
            panel2.Controls.Add(t);


            if (index_start + 2 >= tours.Count) return;
            t = new TourItemView(tours[index_start + 2], this);
            panel3.Controls.Add(t);
            t.Dock = DockStyle.Fill;


            if (index_start + 3 >= tours.Count) return;
            t = new TourItemView(tours[index_start + 3], this);
            panel4.Controls.Add(t);
            t.Dock = DockStyle.Fill;
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowTour();
        }

        private void btnHistoryTransaction_Click(object sender, EventArgs e)
        {
            FormHistoryTransaction f = new FormHistoryTransaction();
            f.account_id = account.id;
            f.Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
           ForgetPass f = new ForgetPass();
            f.Show();
        }
    }
}
