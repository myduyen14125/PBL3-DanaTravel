using BUS;
using DTO;
using DTO.CodeFirstDB;
using mshtml;
using PBL3.View.homepage;
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
    public partial class TourDetail : UserControl
    {
        private TourDTO tourDTO;
        private bool isBookTour;
        private int account_id;
        private bool isHideBtnBack;

        private IHTMLDocument2 documentDesc;

        public delegate void Mydel();
        public Mydel showParent { get; set; }
        public TourDetail(TourDTO tour, int account_id, bool isHideBtnBack, bool isBookTour)
        {
            InitializeComponent();
            this.tourDTO = tour;
            this.account_id = account_id;
            this.isHideBtnBack = isHideBtnBack;
            this.isBookTour = isBookTour;
            GUI();
        }
        public void GUI()
        {
            btnBack.Visible = !isHideBtnBack;
            htmlDescription.DocumentText = "<html><body></body></html>";
            documentDesc = htmlDescription.Document.DomDocument as IHTMLDocument2;
            documentDesc.designMode = "On";

            if (tourDTO.TourImages != null)
            {
                List<Image> images = new List<Image>();
                foreach (TourImage tourImage in tourDTO.TourImages) images.Add(Image.FromStream(new MemoryStream(tourImage.image)));
                SliderImage sliderImage = new SliderImage(images, false);
                panel1.Controls.Add(sliderImage);
                sliderImage.Dock = DockStyle.Fill;
            }

            TimeSpan timeSpan = tourDTO.returnDate - tourDTO.departureDate;
            string departDate = tourDTO.departureDate.ToString("dd/MM/yyyy");
            string time = "";
            if (timeSpan.Days == 0) time = "1 ngày 0 đêm";
            else time = (timeSpan.Days).ToString() + " ngày " + (timeSpan.Days - 1).ToString() + " đêm";

            lbTourName.Text = tourDTO.name;
            lbDepartTime.Text = departDate;
            lbTourCategory.Text = tourDTO.tour_category_name;
            lbTourName1.Text = tourDTO.name;
            lbTourID.Text = tourDTO.id.ToString();
            lbDepartureDate1.Text = departDate;
            lbPrice.Text = tourDTO.price_adult_one_ticket.ToString("###,###,###,###") + " VNĐ";
            lbShortDescription.Text = tourDTO.short_desc;
            lbTime.Text = time;
            lbTime1.Text = time;
            htmlDescription.DocumentText = tourDTO.detail_desc;

            btnOrderTour.Visible = isBookTour;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            showParent();
        }
        private void btnOrderTour_Click(object sender, EventArgs e)
        {
            FormBookTour f = new FormBookTour(tourDTO, account_id);
            f.Show();
        }

        private void FormTourDetail_Load(object sender, EventArgs e)
        {

        }
    }
}
