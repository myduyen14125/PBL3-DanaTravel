using BUS;
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
using Util;

namespace PBL3.View.homepage
{
    public partial class FormBookTour : Form
    {
        private TourDTO tourDTO;
        public FormBookTour(TourDTO tourDTO)
        {
            InitializeComponent();
            this.tourDTO = tourDTO;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormBookTour_Load(object sender, EventArgs e)
        {
            List<Image> images = new List<Image>();
            foreach (TourImage tourImage in tourDTO.TourImages) images.Add(Image.FromStream(new MemoryStream(tourImage.image)));
            SliderImage sliderImage = new SliderImage(images, false);
            panelPicture.Controls.Add(sliderImage);
            sliderImage.Dock = DockStyle.Fill;

            lbTourName1.Text = tourDTO.name;
            lbTourID.Text = tourDTO.id.ToString();


            lbDepartureDate1.Text = tourDTO.departureDate.ToString("dd/MM/yyyy");
            TimeSpan timeSpan = tourDTO.returnDate - tourDTO.departureDate;
            string time = "";
            if (timeSpan.Days == 0) time = "1 ngày 0 đêm";
            else time = (timeSpan.Days).ToString() + " ngày " + (timeSpan.Days - 1).ToString() + " đêm";
            lbTime.Text = time;

            txtPriceAdult.Text = tourDTO.price_adult_one_ticket.ToString("###,###,###,###") + " VNĐ";
            txtPriceChildren.Text = tourDTO.price_children_one_ticket.ToString("###,###,###,###") + " VNĐ";
        }
        private void textChange(object sender, EventArgs e)
        {
            Validate validate = new Validate();
            int number_adult = txtNumberAdults.Text == "" || !validate.ValidateNumber(txtNumberAdults.Text)
                                    ? 0 : Convert.ToInt32(txtNumberAdults.Text);
            int number_children = txtNumberChildrens.Text == "" || !validate.ValidateNumber(txtNumberChildrens.Text)
                                    ? 0 : Convert.ToInt32(txtNumberChildrens.Text);
            txtTotalPrice.Text = (number_adult * tourDTO.price_adult_one_ticket
                                + number_children * tourDTO.price_children_one_ticket).ToString("###,###,###,###");
        }
        private void btnBookTour_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string id_card = txtCCCD.Text;
            string phone = txtPhone.Text;
            string note = txtNote.Text;
            int number_adult = Convert.ToInt32(txtNumberAdults.Text);
            int number_children = Convert.ToInt32(txtNumberChildrens.Text);
            double total_price = Convert.ToDouble(txtTotalPrice.Text);
            TourTicket ticket = new TourTicket()
            {
                name = name,
                email = email,
                phone = phone,
                note = note,
                identity_card = id_card,
                number_adult = number_adult,
                number_children = number_children,
                total_price = total_price,
                date = DateTime.Now,
                tour_ticket_status_id = 1,
                tour_id = tourDTO.id
            };
            TourTicketBUS.Instance.Save(ticket);
            this.Hide();
            MessageBox.Show("Book tour success");
        }
    }
}
