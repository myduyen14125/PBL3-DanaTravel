using BUS;
using DTO.CodeFirstDB;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PBL3.View.tour
{
    public partial class TransportManagement : UserControl
    {
        public TransportManagement()
        {
            InitializeComponent();
            Show();
        }

        private void TransportManagement_Load(object sender, EventArgs e)
        {
            ShowList();
        }

        public void ShowList()
        {
            List<Transport> transports = TransportBUS.Instance.GetAll();
            FlowLayoutTransport.Controls.Clear();
            foreach (Transport t in transports)
            {
                Image image = Image.FromStream(new MemoryStream(t.image));
                FlowLayoutTransport.Controls.Add(new TransportItem(t.id, t.name, t.price, image, this));
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormAddTransport f = new FormAddTransport();
            f.Show();
            f.d = new FormAddTransport.MyDel(ShowList);
        }
    }
}
