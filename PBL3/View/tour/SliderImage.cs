using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View.tour
{
    public partial class SliderImage : UserControl
    {
        public List<Image> images { get; set; }
        private int indexImage = 0;
        private bool isEdit;
        public SliderImage(List<Image> images, bool isEdit)
        {
            InitializeComponent();
            this.images = images;
            this.isEdit = isEdit;
        }

        private void LoadNextImage()
        {
            if (images.Count == 0)
            {
                btnDeleteImage.Visible = false;
                return;
            }
            SetVisibleBtnDelete();
            timer1.Start();
            indexImage++;
            if (indexImage == images.Count)
            {
                indexImage = 0;
            }
            pictureBox1.Image = images[indexImage];
        }

        private void LoadPreviousImage()
        {
            if (images.Count == 0)
            {
                btnDeleteImage.Visible = false;
                return;
            }
            SetVisibleBtnDelete();
            timer1.Start();
            indexImage--;
            if (indexImage == -1)
            {
                indexImage = images.Count - 1;
            }
            pictureBox1.Image = images[indexImage];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            LoadPreviousImage();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            LoadNextImage();
        }

        private void SliderImage_Load(object sender, EventArgs e)
        {
            if (images.Count != 0)
            {
                pictureBox1.Image = images[0];
            }
            SetVisibleBtnDelete();
        }

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            DialogResult result = MessageBox.Show("Do you want to delete this image", "Notify", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Delete this image " + "successful");
                timer1.Start();
            }
            else timer1.Start();
            images.Remove(images[indexImage]);
            if (images.Count == 0)
            {
                pictureBox1.Image = null;
                SetVisibleBtnDelete();
                return;
            }

            if(indexImage == images.Count)  indexImage = 0;

            pictureBox1.Image = images[indexImage];
        }
        private void SetVisibleBtnDelete()
        {
            if (isEdit && images.Count != 0) btnDeleteImage.Visible = true;
            else btnDeleteImage.Visible = false;
        }
    }
}
