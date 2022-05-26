using BUS;
using DTO.CodeFirstDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View.ticket
{
    public partial class TicketManagement : UserControl
    {
        public TicketManagement()
        {
            InitializeComponent();
        }

        private void tabStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowData();
        }

        private void ShowData()
        {
            List<TourTicket> tourTickets;
            if (tabStatus.SelectedTab == tabStatus.TabPages["tabStatusWait"])
            {
                tourTickets = TourTicketBUS.Instance.GetTourTickets("", 1);

                flowLayoutTabWait.Controls.Clear();
                foreach (TourTicket ticket in tourTickets)
                {
                    TicketItem ticketItem = new TicketItem(ticket);
                    ticketItem.LoadDataParent = ShowData;
                    flowLayoutTabWait.Controls.Add(ticketItem);
                }
            }
            else if (tabStatus.SelectedTab == tabStatus.TabPages["tabStatusOK"])
            {
                tourTickets = TourTicketBUS.Instance.GetTourTickets("", 2);

                flowLayouthTabOK.Controls.Clear();
                foreach (TourTicket ticket in tourTickets)
                {
                    TicketItem ticketItem = new TicketItem(ticket);
                    ticketItem.LoadDataParent = ShowData;
                    flowLayouthTabOK.Controls.Add(ticketItem);
                }
            }
            else if (tabStatus.SelectedTab == tabStatus.TabPages["tabStatusCancel"])
            {
                tourTickets = TourTicketBUS.Instance.GetTourTickets("", 3);

                flowLayoutTabCancel.Controls.Clear();
                foreach (TourTicket ticket in tourTickets)
                {
                    TicketItem ticketItem = new TicketItem(ticket);
                    ticketItem.LoadDataParent = ShowData;
                    flowLayoutTabCancel.Controls.Add(ticketItem);
                }
            }
        }

        private void TicketManagement_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                ShowData();
            }
        }
    }
}
