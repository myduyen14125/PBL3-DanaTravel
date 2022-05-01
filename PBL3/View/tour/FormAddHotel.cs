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
    public partial class FormAddHotel : UserControl
    {
        private HotelManagement hotelManagement;
        public FormAddHotel(HotelManagement hotelManagement)
        {
            InitializeComponent();

            if(!this.DesignMode) {
                setComboboxHotelType();
                cbbHotelType.SelectedIndex = 0;
            }
            this.hotelManagement = hotelManagement;
        }
        public void setComboboxHotelType()
        {
            cbbHotelType.DisplayMember = "Text";
            cbbHotelType.ValueMember = "Value";
            List<HotelType> hotelTypes = HotelBUS.Instance.GetHotelTypes();
            List<object> items = new List<object>();
            foreach (HotelType type in hotelTypes)
            {
                items.Add(new
                {
                    Text = type.name,
                    Value = type.id
                });
            }
            cbbHotelType.DataSource = items;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            hotelManagement.Reload();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            if (pictureHotel.Image != null)
            {
                pictureHotel.Image.Save(stream, pictureHotel.Image.RawFormat);
            }
            HotelBUS.Instance.Save(new Hotel
            {
                name = txtName.Text,
                price = Convert.ToDouble(txtPrice.Text),
                description = txtDesc.Text,
                image = pictureHotel.Image == null ? null : stream.ToArray(),
                hotel_type_id = (cbbHotelType.SelectedItem as dynamic).Value,
            });
            MessageBox.Show("Add hotel successful");
            btnBack.PerformClick();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string file = ofd.FileName;
            if (string.IsNullOrEmpty(file))
            {
                return;
            }
            Image myImage = Image.FromFile(file);
            pictureHotel.Image = myImage;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPrice.Text = "";
            txtDesc.Text = "";
            pictureHotel.Image = null;
        }
    }
}
