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
        private TourManagement tourManagement;
        private IHTMLDocument2 documentDesc;
        public FormTourDetail(TourDTO tour, TourManagement tourManagement)
        {
            InitializeComponent();
            this.tourDTO = tour;
            this.tourManagement = tourManagement;
            GUI();
            
        }

        public void SetHTMLDescription(String html)
        {
            htmlDescription.Document.ExecCommand("Refresh", false, "");
            htmlDescription.DocumentText = html;
            documentDesc = htmlDescription.Document.DomDocument as IHTMLDocument2;
            documentDesc.designMode = "On";
        }
        public void GUI()
        {
            htmlDescription.DocumentText = "<html><body></body></html>";
            documentDesc = htmlDescription.Document.DomDocument as IHTMLDocument2;
            documentDesc.designMode = "On";
            
            List<Image> images = new List<Image>();
            foreach (TourImage tourImage in tourDTO.TourImages) images.Add(Image.FromStream(new MemoryStream(tourImage.image)));
            SliderImage sliderImage = new SliderImage(images);
            panel1.Controls.Add(sliderImage);
            sliderImage.Dock = DockStyle.Fill;

            lbTourName.Text = tourDTO.name;
            lbDepartureDate.Text = tourDTO.departureDate.ToString();
            lbReturnDate.Text = tourDTO.returnDate.ToString();
            lbTourCategory.Text = tourDTO.tour_category_name;
            lbTourName1.Text = tourDTO.name;
            lbTourID.Text = tourDTO.id.ToString();
            lbDepartureDate1.Text = tourDTO.departureDate.ToString();
            lbPrice.Text = tourDTO.price_adult_one_ticket.ToString();
            lbShortDescription.Text = tourDTO.short_desc;
            htmlDescription.DocumentText = tourDTO.detail_desc;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            tourManagement.Reload();
        }

        
    }
}
