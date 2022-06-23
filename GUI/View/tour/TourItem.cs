using BLL;
using DTO;
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
    public partial class TourItem : UserControl
    {
        private Tour tour;
        private TourManagement tourManagement;
        public TourItem(Tour tour, TourManagement tourManagement)
        {
            InitializeComponent();
            this.tour = tour;
            this.tourManagement = tourManagement;
            SetTourItem();
        }

        public void SetTourItem()
        {
            List<Image> images = new List<Image>();
            foreach (TourImage tourImage in tour.TourImages) images.Add(Image.FromStream(new MemoryStream(tourImage.image)));
            SliderImage sliderImage = new SliderImage(images, false, true);
            panelPicture.Controls.Add(sliderImage);
            sliderImage.Dock = DockStyle.Fill;

            txtName.Text = tour.name;
            txtCategory.Text = tour.TourCategory.name;
            txtPriceAdult.Text = tour.price_adult_one_ticket.ToString("###,###,###,###") + " VNĐ";
            txtPriceChildren.Text = tour.price_children_one_ticket.ToString("###,###,###,###") + " VNĐ";
            txtShortDesc.Text = tour.short_desc;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormAddEditTour form = new FormAddEditTour(tour, tourManagement);
            form.Dock = DockStyle.Fill;
            tourManagement.Controls.Add(form);
            tourManagement.HideTourManagement();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete tour " + tour.name, "Notify", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                TourBLL.Instance.DeleteById(Convert.ToInt32(tour.id));
                MessageBox.Show("Delete tour " + tour.name + " successful");
            }
            tourManagement.Reload();
        }
        private void btnDetail_Click(object sender, EventArgs e)
        {
            TourDetail f = new TourDetail(tour, 0, false, false);
            f.showParent = new TourDetail.Mydel(tourManagement.Reload);
            f.Dock = DockStyle.Fill;
            tourManagement.Controls.Add(f);
            tourManagement.HideTourManagement();
        }
    }
}
