using BLL;
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
        public void ShowData()
        {
            List<Bill> bills;
            if (tabStatus.SelectedTab == tabStatus.TabPages["tabStatusWait"])
            {
                bills = BillBLL.Instance.GetBills(txtSearch.Text, 1);

                flowLayoutTabWait.Controls.Clear();
                foreach (Bill bill in bills)
                {
                    BillItem billItem = new BillItem(bill, true);
                    billItem.LoadDataParent = ShowData;
                    flowLayoutTabWait.Controls.Add(billItem);
                }
            }
            else if (tabStatus.SelectedTab == tabStatus.TabPages["tabStatusOK"])
            {
                bills = BillBLL.Instance.GetBills(txtSearch.Text, 2);

                flowLayouthTabOK.Controls.Clear();
                foreach (Bill bill in bills)
                {
                    BillItem billItem = new BillItem(bill, false);
                    billItem.LoadDataParent = ShowData;
                    flowLayouthTabOK.Controls.Add(billItem);
                }
            }
            else if (tabStatus.SelectedTab == tabStatus.TabPages["tabStatusCancel"])
            {
                bills = BillBLL.Instance.GetBills(txtSearch.Text, 3);

                flowLayoutTabCancel.Controls.Clear();
                foreach (Bill bill in bills)
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

        private void btnReload_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}
