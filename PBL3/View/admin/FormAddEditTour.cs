using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace PBL3.View
{
    public partial class FormAddEditTour : Form
    {
        public delegate void MyDel(string txt);
        public MyDel myDel { get; set; }
        public string ID { get; set; }
        public FormAddEditTour(string s)
        {
            InitializeComponent();
            ID = s;
            AddCbbTransportValue();
        }
        public void AddCbbTransportValue()
        {
            foreach (string i in TourBUS.Instance.GetAllTransport().Distinct())
            {
                cbbTransport.Items.Add(i);
            }
            cbbTransport.Items.Add("hehe");
        }
    }
}
