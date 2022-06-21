using BLL;
using DTO;
using PBL3.View.tour;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View.homepage
{
    public partial class FormTourDetail : Form
    {
        private int tour_id { get; set; }
        private int account_id { get; set; }
        public FormTourDetail(int tour_id, int account_id)
        {
            InitializeComponent();
            this.tour_id = tour_id;
            this.account_id = account_id;
            if(!this.DesignMode)
            {
                TourDTO tour = TourBLL.Instance.GetTourDTOById(tour_id);
                TourDetail tourDetail = new TourDetail(tour, account_id, true, true);
                this.Controls.Add(tourDetail);
            }
        }
    }
}
