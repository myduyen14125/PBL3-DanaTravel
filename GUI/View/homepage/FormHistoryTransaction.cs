using BLL;
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

namespace PBL3.View.homepage
{
    public partial class FormHistoryTransaction : Form
    {
        public int account_id { get; set; }
        public FormHistoryTransaction()
        {
            InitializeComponent();
        }

        private void FormHistoryTransaction_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void ShowData()
        {
            List<TourTicketDTO> tourTickets;
            if (tabStatus.SelectedTab == tabStatus.TabPages["tabStatusWaitConfirm"])
            {
                tourTickets = TourTicketBLL.Instance.GetTourTicketsByAccount(account_id, 1, 0);
                flowLayoutTabWaitConfirm.Controls.Clear();
                foreach (TourTicketDTO ticket in tourTickets)
                {
                    TourTicketItemView ticketItem = new TourTicketItemView(ticket, false);
                    ticketItem.loadDataParent = ShowData;
                    flowLayoutTabWaitConfirm.Controls.Add(ticketItem);
                }
            }
            else if (tabStatus.SelectedTab == tabStatus.TabPages["tabStatusWaitPay"])
            {
                tourTickets = TourTicketBLL.Instance.GetTourTicketsByAccount(account_id, 2, 1);
                flowLayoutTabWaitPay.Controls.Clear();
                foreach (TourTicketDTO ticket in tourTickets)
                {
                    TourTicketItemView ticketItem = new TourTicketItemView(ticket, false);
                    ticketItem.loadDataParent = ShowData;
                    flowLayoutTabWaitPay.Controls.Add(ticketItem);
                }
            }
            else if (tabStatus.SelectedTab == tabStatus.TabPages["tabStatusOk"])
            {
                tourTickets = TourTicketBLL.Instance.GetTourTicketsByAccount(account_id, 2, 2);
                flowLayoutTabOk.Controls.Clear();
                foreach (TourTicketDTO ticket in tourTickets)
                {
                    TourTicketItemView ticketItem = new TourTicketItemView(ticket, true);
                    flowLayoutTabOk.Controls.Add(ticketItem);
                }
            }
            else if (tabStatus.SelectedTab == tabStatus.TabPages["tabStatusCancel"])
            {
                tourTickets = TourTicketBLL.Instance.GetTourTicketsByAccount(account_id, 3, 0);
                flowLayoutTabCancel.Controls.Clear();
                foreach (TourTicketDTO ticket in tourTickets)
                {
                    TourTicketItemView ticketItem = new TourTicketItemView(ticket, true);
                    flowLayoutTabCancel.Controls.Add(ticketItem);
                }
            }
        }

        private void tabStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}
