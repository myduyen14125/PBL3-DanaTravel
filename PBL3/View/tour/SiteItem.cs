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
    public partial class SiteItem : UserControl
    {
        private SiteManagement siteManagement;
        public SiteItem(Site site, SiteManagement siteManagement)
        {
            InitializeComponent();
            this.siteManagement = siteManagement;
            lbId.Text = site.id.ToString();
            txtName.Text = site.name;
            txtPrice.Text = site.price.ToString();
            txtDesc.Text = site.description;
            txtAddress.Text = site.address;
            if (site.image != null)
            {
                pictureSite.Image = Image.FromStream(new MemoryStream(site.image));
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            // Get image
            if (pictureSite.Image != null)
            {
                pictureSite.Image.Save(stream, pictureSite.Image.RawFormat);
            }
            Site site = new Site
            {
                id = Convert.ToInt32(lbId.Text),
                name = txtName.Text,
                price = Convert.ToDouble(txtPrice.Text),
                address = txtAddress.Text,
                image = pictureSite.Image == null ? null : stream.ToArray(),
                description = txtDesc.Text,
            };
            SiteBUS.Instance.Save(site);

            txtName.Enabled = false;
            txtPrice.Enabled = false;
            txtDesc.Enabled = false;
            txtAddress.Enabled = false;
            btnUpdate.Visible = false;
            btnChooseImage.Visible = false;
            btnEdit.Visible = true;
            MessageBox.Show("Update site successful");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtPrice.Enabled = true;
            txtDesc.Enabled = true;
            txtAddress.Enabled = true;
            btnChooseImage.Visible = true;
            btnUpdate.Visible = true;
            btnEdit.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete site", "Notify", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                SiteBUS.Instance.Delete(Convert.ToInt32(lbId.Text));
                MessageBox.Show("Delete site successful");
            }
            siteManagement.ShowList();
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
            pictureSite.Image = myImage;
        }

        private void SiteItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Cornsilk;
        }

        private void SiteItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

    }
}
