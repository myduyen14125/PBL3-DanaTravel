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

namespace PBL3.View.bill
{
    public partial class FormPrintBill : Form
    {
        public FormPrintBill()
        {
            InitializeComponent();
        }

        private void FormPrintBill_Load(object sender, EventArgs e)
        {
            receiptBindingSource.DataSource = new Receipt
            {
                number_adult = 2,
                number_children = 1,
                price_adult_one_ticket = 2000,
                price_children_one_ticket = 1000,
                total_price_adult = 4000,
                total_price_children = 1000,
                total_price = 5000       
            };
            this.reportViewer1.RefreshReport();
        }

    }
}
