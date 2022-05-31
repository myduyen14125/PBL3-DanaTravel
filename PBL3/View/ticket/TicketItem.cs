using BUS;
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

namespace PBL3.View.ticket
{
    public partial class TicketItem : UserControl
    {
        private TourTicket tourTicket;
        public delegate void Mydel();
        public Mydel LoadDataParent { get; set; }
        public TicketItem(TourTicket tourTicket)
        {
            InitializeComponent();
            this.tourTicket = tourTicket;
            Gui();
        }
        private void Gui()
        {
            lbName.Text = tourTicket.name;
            lbEmail.Text = tourTicket.email;
            lbCCCD.Text = tourTicket.identity_card;
            lbPhone.Text = tourTicket.phone;
            lbDate.Text = tourTicket.date.ToShortDateString();
            lbNumberAdults.Text = tourTicket.number_adult.ToString();
            lbNumberChildren.Text = tourTicket.number_children.ToString();

            if (tourTicket.tour_ticket_status_id == 2)
            {
                btnAccept.Image = Resources.icon_success;
            }
            else if(tourTicket.tour_ticket_status_id == 3)
            {
                btnCancel.Image = Resources.icon_success;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (tourTicket.tour_ticket_status_id == 1 || tourTicket.tour_ticket_status_id == 3)
            {
                result = MessageBox.Show("Bạn muốn xác nhận vé tour này không?","Notify", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    tourTicket.tour_ticket_status_id = 2;
                    btnAccept.Image = Resources.icon_success;
                    SendEmailAcceptTicket();
                    CreateBill();
                }
            }
            else
            {
                result = MessageBox.Show("Bạn muốn chuyển vé tour này sang chờ xác nhận không?", "Notify", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    tourTicket.tour_ticket_status_id = 1;
                    btnAccept.Image = Resources.icon_khoa;
                }
            }

            if (result == DialogResult.Yes)
            {
                TourTicketBUS.Instance.Save(tourTicket);
                LoadDataParent();
            }
        }

        private void CreateBill()
        {
            BillBUS.Instance.Save(new Bill()
            {
                id = 0,
                bill_status_id = 1,
                tour_ticket_id = tourTicket.id
            });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if(tourTicket.tour_ticket_status_id == 3)
            {
                result = MessageBox.Show("Bạn muốn xác nhận vé tour này không?", "Notify", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    tourTicket.tour_ticket_status_id = 2;
                    btnCancel.Image = Resources.icon_khoa;
                }
            }
            else
            {
                result = MessageBox.Show("Bạn muốn hủy vé tour này không?", "Notify", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    tourTicket.tour_ticket_status_id = 3;
                    btnCancel.Image = Resources.icon_success;
                }
            }
            if (result == DialogResult.Yes)
            {
                TourTicketBUS.Instance.Save(tourTicket);
                LoadDataParent();
            }
        }

        public void SendEmailAcceptTicket()
        {
            string subject = "Thông báo trạng thái tour";
            string body = "<h2>Vé tour của bạn đã được xác nhận</h2> <br>"
                + "<b>Thông tin vé của bạn:</b> <br>"
                + "<b>Mã tour:</b> " + tourTicket.tour_id + "<br>"
                + "<b>Họ và tên:</b> " + tourTicket.name + "<br>"
                + "<b>Email:</b> " + tourTicket.email + "<br>"
                + "<b>CCCD:</b> " + tourTicket.identity_card + "<br>"
                + "<b>Số điện thoại:</b> " + tourTicket.phone + "<br>"
                + "<b>Số người lớn:</b> " + tourTicket.number_adult.ToString() + "<br>"
                + "<b>Số trẻ em:</b> " + tourTicket.number_children.ToString() + "<br>"
                + "<b>Tổng tiền:</b> " + tourTicket.total_price.ToString("###,###,###,###") + " VNĐ" + "<br>"
                + "Vui lòng thanh toán hóa đơn trước ngày diễn ra tour <br>"
                + "Nếu thông tin có sai xót vui lòng bạn liên hệ đến bộ phận chăm sóc khách hàng qua hotline: 1900.9999 để được tư vấn <br>"
                + "Cảm ơn bạn đã sử dụng dịch vụ của chúng tôi.";
            new SendEmailHelper().SendEmail(tourTicket.email, subject, body);
        }
    }
}
