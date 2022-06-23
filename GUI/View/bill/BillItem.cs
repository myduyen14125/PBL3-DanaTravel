using BLL;
using DTO;
using DTO.CodeFirstDB;
using GUI.Properties;
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

namespace PBL3.View.bill
{
    public partial class BillItem : UserControl
    {
        private Bill bill;
        private bool isWait;
        public delegate void Mydel();
        public Mydel LoadDataParent { get; set; }
        public BillItem(Bill bill, bool isWait)
        {
            InitializeComponent();
            this.bill = bill;
            this.isWait = isWait;
            GUI();
        }
        private void GUI()
        {
            if (isWait)
            {
                btnViewDetail.Visible = false;
            }
            else
            {
                btnAccept.Visible = false;
                btnCancel.Visible = false;
            }
            lbName.Text = bill.TourTicket.Customer.name;
            lbEmail.Text = bill.TourTicket.Customer.email;
            lbPhone.Text = bill.TourTicket.Customer.phone;
            lbCCCD.Text = bill.TourTicket.Customer.idCard;
            lbTotalPrice.Text = bill.TourTicket.total_price.ToString("###,###,###,###");

            if (bill.bill_status_id == 2)
            {
                btnAccept.Image = Resources.icon_success;
            }
            else if (bill.bill_status_id == 3)
            {
                btnCancel.Image = Resources.icon_success;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn muốn xác nhận thanh toán vé tour này không?", "Notify", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                bill.bill_status_id = 2;
                btnAccept.Image = Resources.icon_success;

                BillBLL.Instance.Save(new Bill
                {
                    id = bill.id,
                    bill_status_id = 2,
                    date = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd")),
                });
                LoadDataParent();
                SendEmail();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn muốn hủy vé tour này không?", "Notify", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                bill.bill_status_id = 3;
                btnCancel.Image = Resources.icon_success;

                BillBLL.Instance.Save(new Bill
                {
                    id = bill.id,
                    bill_status_id = 3,
                    date = DateTime.Now,
                });
                TourTicketBLL.Instance.Save(new TourTicket 
                { 
                    id = bill.TourTicket.id, 
                    tour_ticket_status_id = 3,
                    identity_card = bill.TourTicket.Customer.idCard,
                });
                LoadDataParent();
            }
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            FormPrintBill f = new FormPrintBill(bill);
            f.Show();
        }

        public void SendEmail()
        {
            string subject = "Xác nhận thanh toán du lịch DanaTravel";
            string body = "<h2>Vé tour của bạn đã được thanh toán thành công</h2> <br>"
                + "<b>Thông tin vé của bạn:</b> <br>"
                + "<b>Tên tour:</b> " + bill.TourTicket.Tour.name + "<br>"
                + "<b>Họ và tên:</b> " + bill.TourTicket.Customer.name + "<br>"
                + "<b>Email:</b> " + bill.TourTicket.Customer.email + "<br>"
                + "<b>CCCD:</b> " + bill.TourTicket.Customer.idCard + "<br>"
                + "<b>Số điện thoại:</b> " + bill.TourTicket.Customer.phone + "<br>"
                + "<b>Số người lớn:</b> " + bill.TourTicket.number_adult.ToString() + "<br>"
                + "<b>Số trẻ em:</b> " + bill.TourTicket.number_children.ToString() + "<br>"
                + "<b>Tổng tiền:</b> " + bill.TourTicket.total_price.ToString("###,###,###,###") + " VNĐ" + "<br>"
                + "<b>Tổng tiền đã thanh toán:</b> " + bill.TourTicket.total_price.ToString("###,###,###,###") + " VNĐ" + "<br>"
                + "Nếu thông tin có sai xót vui lòng bạn liên hệ đến bộ phận chăm sóc khách hàng qua hotline: 1900.9999 để được tư vấn <br>"
                + "Cảm ơn bạn đã sử dụng dịch vụ của chúng tôi.";
            new SendEmailHelper().SendEmail(bill.TourTicket.Customer.email, subject, body);
        }
    }
}
