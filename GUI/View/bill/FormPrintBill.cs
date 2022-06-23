using DTO;
using DTO.CodeFirstDB;
using Microsoft.Reporting.WinForms;
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
        private Bill bill;
        public FormPrintBill(Bill bill)
        {
            InitializeComponent();
            this.bill = bill;
        }

        private void FormPrintBill_Load(object sender, EventArgs e)
        {
            receiptBindingSource.DataSource = bill;

            Microsoft.Reporting.WinForms.ReportParameter[] reportParameters = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new ReportParameter("price_adult", bill.TourTicket.Tour.price_adult_one_ticket
                                    .ToString("###,###,###,###,###")),
                new ReportParameter("price_children", bill.TourTicket.Tour.price_children_one_ticket
                                    .ToString("###,###,###,###,###")),
                new ReportParameter("total_price_before_VAT", bill.TourTicket.total_price
                                    .ToString("###,###,###,###,###")),
                new ReportParameter("total_price_adult", (bill.TourTicket.number_adult * bill.TourTicket.Tour.price_adult_one_ticket)
                                    .ToString("###,###,###,###,###")),
                new ReportParameter("total_price_children", (bill.TourTicket.number_children * bill.TourTicket.Tour.price_children_one_ticket)
                                    .ToString("###,###,###,###,###")),
                new ReportParameter("priceVAT", Convert.ToInt32(bill.TourTicket.total_price * 0.1)
                                    .ToString("###,###,###,###,###")),
                new ReportParameter("total_price_pay", Convert.ToInt32(bill.TourTicket.total_price * 1.1)
                                    .ToString("###,###,###,###,###")),
                new ReportParameter("tour_name", bill.TourTicket.Tour.name),
                new ReportParameter("name", bill.TourTicket.Customer.name),
                new ReportParameter("email", bill.TourTicket.Customer.email),
                new ReportParameter("identity_card", bill.TourTicket.Customer.idCard),
                new ReportParameter("phone", bill.TourTicket.Customer.phone),
            };
            
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.reportViewer1.RefreshReport();
        }

    }
}
