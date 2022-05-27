using BUS;
using DTO;
using DTO.CodeFirstDB;
using PBL3.View.ticket;
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
    public partial class BillManagement : UserControl
    {
        public BillManagement()
        {
            InitializeComponent();
        }

        private void tabStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowData();
        }
        private void ShowData()
        {
            List<BillDTO> bills;
            if (tabStatus.SelectedTab == tabStatus.TabPages["tabStatusWait"])
            {
                bills = BillBUS.Instance.GetBillDTOs("", 1);

                flowLayoutTabWait.Controls.Clear();
                foreach (BillDTO bill in bills)
                {
                    BillItem billItem = new BillItem(bill, true);
                    billItem.LoadDataParent = ShowData;
                    flowLayoutTabWait.Controls.Add(billItem);
                }
            }
            else if (tabStatus.SelectedTab == tabStatus.TabPages["tabStatusOK"])
            {
                bills = BillBUS.Instance.GetBillDTOs("", 2);

                flowLayouthTabOK.Controls.Clear();
                foreach (BillDTO bill in bills)
                {
                    BillItem billItem = new BillItem(bill, false);
                    billItem.LoadDataParent = ShowData;
                    flowLayouthTabOK.Controls.Add(billItem);
                }
            }
            else if (tabStatus.SelectedTab == tabStatus.TabPages["tabStatusCancel"])
            {
                bills = BillBUS.Instance.GetBillDTOs("", 3);

                flowLayoutTabCancel.Controls.Clear();
                foreach (BillDTO bill in bills)
                {
                    BillItem billItem = new BillItem(bill, false);
                    billItem.LoadDataParent = ShowData;
                    flowLayoutTabCancel.Controls.Add(billItem);
                }
            }
        }

        private void BillManagement_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                ShowData();
            }
        }
    }
}
