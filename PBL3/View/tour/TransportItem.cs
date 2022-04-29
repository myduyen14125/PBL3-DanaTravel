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
using Util;

namespace PBL3.View.tour
{
    public partial class TransportItem : UserControl
    {
        private TransportManagement transportManagement;
        public TransportItem(int id, string name, double price, Image image, TransportManagement t)
        {
            InitializeComponent();
            lbId.Text = id.ToString();
            txtName.Text = name;
            txtPrice.Text = price.ToString();
            pictureTransport.Image = image;
            this.transportManagement = t;
        }

        private void TransportItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Cornsilk;
        }

        private void TransportItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtPrice.Enabled = true;
            btnChooseImage.Visible = true;
            btnUpdate.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Get image
            MemoryStream stream = new MemoryStream();
            pictureTransport.Image.Save(stream, pictureTransport.Image.RawFormat);
            Transport transport = new Transport
            {
                id = Convert.ToInt32(lbId.Text),
                name = txtName.Text,
                price = Convert.ToDouble(txtPrice.Text),
                image = stream.ToArray()
            };
            TransportBUS.Instance.Save(transport);

            txtName.Enabled = false;
            txtPrice.Enabled = false;
            btnUpdate.Visible = false;
            btnChooseImage.Visible = false;
            MessageBox.Show("Update transport successful");
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
            pictureTransport.Image = myImage;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete transport", "Notify", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                TransportBUS.Instance.Delete(Convert.ToInt32(lbId.Text));
                MessageBox.Show("Delete transport successful");
            }
            transportManagement.ShowList();
        }
    }
}
