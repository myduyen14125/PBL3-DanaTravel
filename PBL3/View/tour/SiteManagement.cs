using BUS;
using DTO.CodeFirstDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View.tour
{
    public partial class SiteManagement : UserControl
    {
        public SiteManagement()
        {
            InitializeComponent();
        }

        private void SiteManagement_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                ShowList();
            }
        }

        public void ShowList()
        {
            string search_key = txtSearch.Text;
            List<Site> sites = SiteBUS.Instance.GetAll(search_key);
            flowLayoutSite.Controls.Clear();
            foreach (Site site in sites)
            {
                flowLayoutSite.Controls.Add(new SiteItem(site, this));
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormAddSite formAddSite = new FormAddSite(this);
            formAddSite.Dock = DockStyle.Fill;
            this.Controls.Add(formAddSite);
            btnCreate.Visible = false;
            flowLayoutSite.Visible = false;
            label1.Visible = false;
        }
        public void Reload()
        {
            btnCreate.Visible = true;
            flowLayoutSite.Visible = true;
            label1.Visible = true;
            ShowList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowList();
        }
    }
}
