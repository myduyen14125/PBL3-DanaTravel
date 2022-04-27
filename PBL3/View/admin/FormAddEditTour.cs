using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace PBL3.View
{
    public partial class FormAddEditTour : Form
    {
        public delegate void MyDel();
        public MyDel myDel { get; set; }
        private int tourID;
        private TourDTO tour;
        public FormAddEditTour(int id = 0)
        {
            InitializeComponent();
            tourID = id;
            if (id != 0) tour = TourBUS.Instance.GetTourDTOById(tourID);
        }
        public void AddCbbTransportValue()
        {
            foreach (string i in TourBUS.Instance.GetAllTransport().Distinct())
            {
                cbbTransport.Items.Add(i);
            }
            cbbTransport.Items.Add("Motorbike");
            cbbTransport.Items.Add("Plane");
            cbbTransport.Items.Add("Train");
            cbbTransport.Items.Add("Bicycle");
        }
        public void GUI()
        {
            if (tourID != 0)
            {
                txtNamePlace.Text = tour.namePlace;
                txtPhoto.Text = tour.photo;
                dateTimePickerStart.Value = tour.departureDay;
                dateTimePickerEnd.Value = tour.returnDay;
                cbbTransport.SelectedItem = tour.transport;
                txtQuantity.Text = tour.quantity.ToString();
                rbYes.Checked = tour.tourGuide;
                rbNo.Checked = !rbYes.Checked;
                btnTotal.Text = tour.totalPrice.ToString();
            }
            this.Show();
        }
        private bool ValidateFormSave()
        {
            // Validate 
            Validate validate = new Validate();
            if (txtNamePlace.Text == "")
            {
                MessageBox.Show("Please enter name place");
                txtNamePlace.Focus();
                return false;
            }
            if (dateTimePickerEnd.Text == "" || dateTimePickerStart.Text == "")
            {
                MessageBox.Show("Please choose departure and return day");
                return false;
            }
            if (!rbYes.Checked && !rbNo.Checked)
            {
                MessageBox.Show("Please choose tour guide");
                return false;
            }
            if (txtQuantity.Text == "")
            {
                MessageBox.Show("Please fill in number of people");
                txtQuantity.Focus();
                return false;
            }
            if (cbbTransport.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a mean of transport");
                cbbTransport.Focus();
                return false;
            }
            if (btnTotal.Text == "")
            {
                MessageBox.Show("Click the calculate button to get total price!");
                btnCalTotal.Focus();
                return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateFormSave())
            {
                return;
            }
            // Add tour
            Tour tou = new Tour
            {
                id = tourID,
                namePlace = txtNamePlace.Text,
                photo = txtPhoto.Text,
                departureDay = dateTimePickerStart.Value,
                returnDay = dateTimePickerEnd.Value,
                transport = cbbTransport.SelectedItem.ToString(),
                quantity = Convert.ToInt32(txtQuantity.Text),
                tourGuide = rbYes.Checked,
                totalPrice = Convert.ToInt32(btnTotal.Text),
            };
            TourBUS.Instance.Save(tou);

            MessageBox.Show("Successfully add tour");
            myDel();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            myDel();
            this.Hide();
        }

        private void btnCalTotal_Click(object sender, EventArgs e)
        {
            int price = 100 * Convert.ToInt32(txtQuantity.Text);
            btnTotal.Text = price.ToString();
        }

        private void FormAddEditTour_Load(object sender, EventArgs e)
        {
            AddCbbTransportValue();
            GUI();
        }
    }
}
