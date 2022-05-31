using BUS;
using DTO;
using DTO.CodeFirstDB;
using PBL3.Properties;
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
        private BillDTO bill;
        private bool isWait;
        public delegate void Mydel();
        public Mydel LoadDataParent { get; set; }
        public BillItem(BillDTO bill, bool isWait)
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
            lbName.Text = bill.name;
            lbEmail.Text = bill.email;
            lbPhone.Text = bill.phone;
            lbCCCD.Text = bill.identity_card;
            lbTotalPrice.Text = bill.total_price.ToString("###,###,###,###");

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

                BillBUS.Instance.Save(new Bill
                {
                    id = bill.id,
                    bill_status_id = 2,
                    date = DateTime.Now,
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

                BillBUS.Instance.Save(new Bill
                {
                    id = bill.id,
                    bill_status_id = 3,
                    date = DateTime.Now,
                });
                TourTicketBUS.Instance.Save(new TourTicket 
                { 
                    id = bill.ticket_id, 
                    tour_ticket_status_id = 3,
                    identity_card = bill.identity_card,
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
                + "<b>Tên tour:</b> " + bill.tour_name + "<br>"
                + "<b>Họ và tên:</b> " + bill.name + "<br>"
                + "<b>Email:</b> " + bill.email + "<br>"
                + "<b>CCCD:</b> " + bill.identity_card + "<br>"
                + "<b>Số điện thoại:</b> " + bill.phone + "<br>"
                + "<b>Số người lớn:</b> " + bill.number_adult.ToString() + "<br>"
                + "<b>Số trẻ em:</b> " + bill.number_children.ToString() + "<br>"
                + "<b>Tổng tiền:</b> " + bill.total_price.ToString("###,###,###,###") + " VNĐ" + "<br>"
                + "<b>Tổng tiền đã thanh toán:</b> " + bill.total_price.ToString("###,###,###,###") + " VNĐ" + "<br>"
                + "Nếu thông tin có sai xót vui lòng bạn liên hệ đến bộ phận chăm sóc khách hàng qua hotline: 1900.9999 để được tư vấn <br>"
                + "Cảm ơn bạn đã sử dụng dịch vụ của chúng tôi.";
            new SendEmailHelper().SendEmail(bill.email, subject, body);
        }
    }
}
