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
    public partial class FormAddSite : UserControl
    {
        private SiteManagement siteManagement;
        public FormAddSite(SiteManagement siteManagement)
        {
            InitializeComponent();
            this.siteManagement = siteManagement;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            siteManagement.Reload();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            if (pictureSite.Image != null)
            {
                pictureSite.Image.Save(stream, pictureSite.Image.RawFormat);
            }
            SiteBUS.Instance.Save(new Site
            {
                name = txtName.Text,
                address = txtAddress.Text,
                price = Convert.ToDouble(txtPrice.Text),
                description = txtDesc.Text,
                image = pictureSite.Image == null ? null : stream.ToArray(),
            });
            MessageBox.Show("Add site successful");
            btnBack.PerformClick();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtPrice.Text = "";
            txtDesc.Text = "";
            pictureSite.Image = null;
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
            pictureSite.Image = myImage;
        }
    }
}
