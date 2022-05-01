using BUS;
using DTO;
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
    public partial class HotelManagement : UserControl
    {
        public HotelManagement()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormAddHotel formAddHotel = new FormAddHotel(this);
            formAddHotel.Dock = DockStyle.Fill;
            this.Controls.Add(formAddHotel);
            btnCreate.Visible = false;
            flowLayoutHotel.Visible = false;
            label1.Visible = false;
        }

        private void HotelManagement_Load(object sender, EventArgs e)
        { 
            if (!this.DesignMode)
            {
                ShowList();
            }
        }
        public void ShowList()
        {
            List<HotelDTO> hotels = HotelBUS.Instance.GetHotels();
            flowLayoutHotel.Controls.Clear();
            foreach (HotelDTO hotel in hotels)
            {
                HotelItem hotelItem = new HotelItem(hotel, this);
                hotelItem.Width = flowLayoutHotel.Width;
                flowLayoutHotel.Controls.Add(hotelItem); 
            }
        }

        public void Reload()
        {
            btnCreate.Visible = true;
            flowLayoutHotel.Visible = true;
            label1.Visible = true;
            ShowList();
        }
    }
}
