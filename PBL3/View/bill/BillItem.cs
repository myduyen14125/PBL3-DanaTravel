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
            Gui();
        }
        private void Gui()
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
            lbTotalPrice.Text = bill.total_price.ToString();

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
                //SendEmailAcceptTicket();
                BillBUS.Instance.Save(new Bill
                {
                    id = bill.id,
                    bill_status_id = 2,
                    date = DateTime.Now,
                });
                LoadDataParent();
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
                //SendEmailAcceptTicket();
                BillBUS.Instance.Save(new Bill
                {
                    id = bill.id,
                    bill_status_id = 3,
                    date = DateTime.Now,
                });
                LoadDataParent();
            }
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            FormPrintBill f = new FormPrintBill();
            f.Show();
        }
    }
}
