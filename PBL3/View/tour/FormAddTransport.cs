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
    public partial class FormAddTransport : Form
    {
        public delegate void MyDel();
        public MyDel d { get; set; }
        public FormAddTransport()
        {
            InitializeComponent();
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
            pictureTransport.Image = myImage;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            pictureTransport.Image.Save(stream, pictureTransport.Image.RawFormat);

            Transport transport = new Transport
            {
                id = 0,
                name = txtName.Text,
                price = Convert.ToDouble(txtPrice.Text),
                image = stream.ToArray()
            };
            TransportBUS.Instance.Save(transport);
            MessageBox.Show("Add transport successful");
            this.Hide();
            d();
        }
    }
}
