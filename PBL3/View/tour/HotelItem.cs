using BUS;
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
    public partial class HotelItem : UserControl
    {
        private HotelManagement hotelManagement;
        public HotelItem(HotelDTO item, HotelManagement hotelManagement)
        {
            InitializeComponent();
            this.hotelManagement = hotelManagement;
            lbId.Text = item.id.ToString();
            txtName.Text = item.name;
            txtPrice.Text = item.price.ToString();
            txtDesc.Text = item.description;
            if(item.image != null)
            {
                pictureHotel.Image = Image.FromStream(new MemoryStream(item.image));
            }
            if (!this.DesignMode)
            {
                setComboboxHotelType();
                cbbHotelType.SelectedIndex = cbbHotelType.FindStringExact(item.hotel_type_name);
            }
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            // Get image
            if (pictureHotel.Image != null)
            {
                pictureHotel.Image.Save(stream, pictureHotel.Image.RawFormat);
            }
            Hotel hotel = new Hotel
            {
                id = Convert.ToInt32(lbId.Text),
                name = txtName.Text,
                price = Convert.ToDouble(txtPrice.Text),
                image = pictureHotel.Image == null ? null : stream.ToArray(),
                description = txtDesc.Text,
                hotel_type_id = (cbbHotelType.SelectedItem as dynamic).Value
            };
            HotelBUS.Instance.Save(hotel);

            txtName.Enabled = false;
            txtPrice.Enabled = false;
            txtDesc.Enabled = false;
            btnUpdate.Visible = false;
            btnChooseImage.Visible = false;
            btnEdit.Visible = true;
            cbbHotelType.Enabled = false;
            MessageBox.Show("Update hotel successful");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            cbbHotelType.Enabled = true;
            txtPrice.Enabled = true;
            txtDesc.Enabled = true;
            btnChooseImage.Visible = true;
            btnUpdate.Visible = true;
            btnEdit.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete hotel", "Notify", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                HotelBUS.Instance.Delete(Convert.ToInt32(lbId.Text));
                MessageBox.Show("Delete hotel successful");
            }
            hotelManagement.ShowList();
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
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

        private void HotelItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Cornsilk;
        }

        private void HotelItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

    }
}
