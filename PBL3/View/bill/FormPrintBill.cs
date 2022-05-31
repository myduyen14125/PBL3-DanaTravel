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
        BillDTO bill;
        public FormPrintBill(BillDTO bill)
        {
            InitializeComponent();
            this.bill = bill;
        }

        private void FormPrintBill_Load(object sender, EventArgs e)
        {
            receiptBindingSource.DataSource = bill;
            
            Microsoft.Reporting.WinForms.ReportParameter[] reportParameters = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("price_adult", bill.price_adult.ToString("###,###,###,###,###")),
                new Microsoft.Reporting.WinForms.ReportParameter("price_children", bill.price_children.ToString("###,###,###,###,###")),
                new Microsoft.Reporting.WinForms.ReportParameter("total_price_before_VAT", bill.total_price.ToString("###,###,###,###,###")),
                new Microsoft.Reporting.WinForms.ReportParameter("total_price_adult", (bill.number_adult * bill.price_adult).ToString("###,###,###,###,###")),
                new Microsoft.Reporting.WinForms.ReportParameter("total_price_children", (bill.number_children * bill.price_children).ToString("###,###,###,###,###")),
                new Microsoft.Reporting.WinForms.ReportParameter("priceVAT", Convert.ToInt32(bill.total_price * 0.1).ToString("###,###,###,###,###")),
                new Microsoft.Reporting.WinForms.ReportParameter("total_price_pay", Convert.ToInt32(bill.total_price * 1.1).ToString("###,###,###,###,###")),
                new Microsoft.Reporting.WinForms.ReportParameter("tour_name", bill.tour_name),
                new Microsoft.Reporting.WinForms.ReportParameter("name", bill.name),
                new Microsoft.Reporting.WinForms.ReportParameter("email", bill.email),
                new Microsoft.Reporting.WinForms.ReportParameter("identity_card", bill.identity_card),
                new Microsoft.Reporting.WinForms.ReportParameter("phone", bill.phone),
            };

            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.reportViewer1.RefreshReport();
        }

    }
}
