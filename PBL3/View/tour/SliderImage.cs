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
        public SliderImage(List<Image> images)
        {
            InitializeComponent();
            this.images = images;
        }

        private void LoadNextImage()
        {
            if (images.Count == 0) return;
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
            if(images.Count == 0) return;
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
        }
    }
}
