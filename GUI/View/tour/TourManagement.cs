using BLL;
using DTO;
using DTO.CodeFirstDB;
using PBL3.View.tour;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PBL3.View
{
    public partial class TourManagement : UserControl
    {
        public TourManagement()
        {
            InitializeComponent();
        }
        private void TourManagement_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                SetComboboxTourCategory();
                ShowDataTour();
            }
        }
        private void SetComboboxTourCategory()
        {
            cbbTourCategory.DisplayMember = "Text";
            cbbTourCategory.ValueMember = "Value";
            List<TourCategory> tourCategories = TourBLL.Instance.GetListTourCategory();
            List<object> items = new List<object>();
            items.Add(new
            {
                Text = "All",
                Value = 0
            });
            foreach (TourCategory tc in tourCategories)
            {
                items.Add(new
                {
                    Text = tc.name,
                    Value = tc.id
                });
            }
            cbbTourCategory.DataSource = items;
        }
        private void ShowDataTour()
        {
            flowLayoutTours.Controls.Clear();
            string searchKey = txtSearch.Text;
            int category_id = (cbbTourCategory.SelectedItem as dynamic).Value;
            List<TourDTO> tourDTOs = TourBLL.Instance.GetTourDTOs(category_id, searchKey);
            if(tourDTOs != null)
            {
                foreach(TourDTO tourDTO in tourDTOs)
                {
                    flowLayoutTours.Controls.Add(new TourItem(tourDTO, this));
                }
            }
            txtTotal.Text = tourDTOs.Count.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddEditTour form = new FormAddEditTour(new TourDTO { id = 0}, this);
            form.Dock = DockStyle.Fill;
            this.Controls.Add(form);
            HideTourManagement();
        }
        public void HideTourManagement()
        {
            btnAdd.Visible = false;
            btnSearch.Visible = false;
            txtSearch.Visible = false;
            txtTotal.Visible = false;
            totalLb.Visible = false;
            pictureBox1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            flowLayoutTours.Visible = false;
            lbCategory.Visible = false;
            cbbTourCategory.Visible = false;
        }
        public void Reload()
        {
            btnAdd.Visible = true;
            flowLayoutTours.Visible = true;
            pictureBox1.Visible = true;
            totalLb.Visible = true;
            txtTotal.Visible = true;
            txtSearch.Visible = true;
            btnSearch.Visible = true;
            flowLayoutTours.Enabled = true;
            lbCategory.Visible = true;
            cbbTourCategory.Visible = true;
            txtSearch.Text = "";
            cbbTourCategory.SelectedIndex = 0;
            ShowDataTour();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowDataTour();
        }
        private void cbbTourCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDataTour();
        }
    }
}
