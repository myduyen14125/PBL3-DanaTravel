using DTO;
using DTO.CodeFirstDB;
using PBL3.View.tour;
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

namespace PBL3.View.homepage
{
    public partial class TourItemView : UserControl
    {
        private TourDTO tour;
        private Homepage homepage;
        public TourItemView(TourDTO tour, Homepage homepage)
        {
            InitializeComponent();
            this.tour = tour;
            this.homepage = homepage;
            SetGUI();
        }
        private void SetGUI()
        {
            lbName.Text = tour.name;

            TimeSpan timeSpan = tour.returnDate - tour.departureDate;
            lbTime.Text = timeSpan.Days == 0 ? "1 ngày 0 đêm" : timeSpan.Days + " ngày " + (timeSpan.Days - 1) + " đêm";
            lbDepart.Text = tour.departureDate.ToString();
            lbPrice.Text = tour.price_adult_one_ticket.ToString() + "VNĐ";

            List<Image> images = new List<Image>();
            foreach (TourImage tourImage in tour.TourImages) images.Add(Image.FromStream(new MemoryStream(tourImage.image)));
            SliderImage sliderImage = new SliderImage(images, false);
            panelPicture.Controls.Add(sliderImage);
            sliderImage.Dock = DockStyle.Fill;
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            FormTourDetail f = new FormTourDetail(tour, true);
            f.Dock = DockStyle.Fill;
            f.showParent = homepage.ShowHomePage;
            homepage.HideHomePage();
            homepage.Controls.Add(f);
        }
    }
}
