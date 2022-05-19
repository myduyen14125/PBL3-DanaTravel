using BUS;
using DTO;
using DTO.CodeFirstDB;
using mshtml;
using PBL3.viewHtml;
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
using Util;


namespace PBL3.View.tour
{
    public partial class FormTourDetail : UserControl
    {
        private TourDTO tourDTO;
        private bool isBooktour;
        private IHTMLDocument2 documentDesc;

        public delegate void Mydel();
        public Mydel showParent { get; set; }
        public FormTourDetail(TourDTO tour, bool isBooktour)
        {
            InitializeComponent();
            this.tourDTO = tour;
            this.isBooktour = isBooktour;
            GUI();
        }
        public void GUI()
        {
            htmlDescription.DocumentText = "<html><body></body></html>";
            documentDesc = htmlDescription.Document.DomDocument as IHTMLDocument2;
            documentDesc.designMode = "On";
            
            List<Image> images = new List<Image>();
            foreach (TourImage tourImage in tourDTO.TourImages) images.Add(Image.FromStream(new MemoryStream(tourImage.image)));
            SliderImage sliderImage = new SliderImage(images, false);
            panel1.Controls.Add(sliderImage);
            sliderImage.Dock = DockStyle.Fill;

            string departDate = tourDTO.departureDate.Day + "/" + tourDTO.departureDate.Month + "/" + tourDTO.departureDate.Year;
            string time = (tourDTO.returnDate.Day - tourDTO.departureDate.Day).ToString() + " ngày "
                + (tourDTO.returnDate.Day - tourDTO.departureDate.Day - 1).ToString() + " đêm";
            lbTourName.Text = tourDTO.name;
            lbDepartTime.Text = departDate;
            lbTourCategory.Text = tourDTO.tour_category_name;
            lbTourName1.Text = tourDTO.name;
            lbTourID.Text = tourDTO.id.ToString();
            lbDepartureDate1.Text = departDate;
            lbPrice.Text = tourDTO.price_adult_one_ticket.ToString() + "VNĐ";
            lbShortDescription.Text = tourDTO.short_desc;
            lbTime.Text = time;
            lbTime1.Text = time;
            htmlDescription.DocumentText = tourDTO.detail_desc;

            if (!isBooktour)
            {
                //btnOrderTour.Visible = false;
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            showParent();
        }
        private void HideTourDetail()
        {
            lbTourName.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            htmlDescription.Visible = false;
            btnBack.Visible = false;
            btnOrderTour.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            this.AutoScroll = false;
        }
        public void ShowTourDetail()
        {
            lbTourName.Visible = true;
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            htmlDescription.Visible = true;
            btnBack.Visible = true;
            btnOrderTour.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            this.AutoScroll = true;
        }
        private void btnOrderTour_Click(object sender, EventArgs e)
        {
            FormBookTour f = new FormBookTour();
            f.Dock = DockStyle.Fill;
            f.showParent = ShowTourDetail;
            this.Controls.Add(f);
            HideTourDetail();
        }
    }
}
