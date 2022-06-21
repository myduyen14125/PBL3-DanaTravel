using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace PBL3
{
    public partial class LoadingScr : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidthEclipse,
                int nHeightEclipse
            );
        public LoadingScr()
        {
            InitializeComponent();
            timer1.Start();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            frameBox.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, frameBox.Width, frameBox.Height, 20, 20));
            pictureInside.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureInside.Width, pictureInside.Height, 20, 20));
            dots.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dots.Width, dots.Height, 25, 25));
            blurBg.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, blurBg.Width, blurBg.Height, 20, 20));
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Hide and appear some components
            this.logoBox.Visible = false;
            this.loadingBox.Visible = false;
            this.frameBox.Visible = true;
            this.pictureInside.Visible = true;
            this.dots.Visible = true;
            this.BaNaLabel.Visible = true;
            this.blurBg.Visible = true;
            //custom bgImage of form
            this.BackgroundImage = global::GUI.Properties.Resources.Ba_Na_Hills_Blur;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            timer1.Stop();
        }

        
        private void blurBg_Click(object sender, EventArgs e)
        {
            //Link to another form: . When calling this.Close(), current form is disposed together with form2.
            //Therefore you need to hide it and set form2.Closed event to call this.Close().
            this.Hide();
            LoginScr f = new LoginScr();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
