using DTO;
using DTO.CodeFirstDB;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class TourTicketBLL
    {
        private static TourTicketBLL _Instance;

        public static TourTicketBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new TourTicketBLL();
                }
                return _Instance;
            }
        }
        public List<TourTicket> GetTourTickets(string search, int tour_ticket_status_id)
        {
            search = search.Trim();
            search = search.ToLower();
            return EntityManager.Instance.TourTickets.Where(tk =>
                     (tk.name.ToLower().Contains(search)
                     || tk.email.ToLower().Contains(search)
                     || tk.phone.ToLower().Contains(search)
                     || tk.identity_card.ToLower().Contains(search))
                     && tk.tour_ticket_status_id == tour_ticket_status_id).ToList();
        }
        public List<TourTicket> GetTourTicketsByAccount(int account_id, int tour_ticket_status_id, int bill_status_id)
        {
            EntityManager db = EntityManager.Instance;

            List<TourTicket> tourTickets = (from tk in db.TourTickets
                                            join t in db.Tours on tk.tour_id equals t.id
                                            join b in db.Bills on tk.id equals b.tour_ticket_id into tkbTable
                                            from tkb in tkbTable.DefaultIfEmpty()
                                            where tk.account_id == account_id && tk.tour_ticket_status_id == tour_ticket_status_id
                                            && ((bill_status_id == 0) ? true : tkb.bill_status_id == bill_status_id)
                                            select tk).ToList();
            return tourTickets;
        }
        public void Save(TourTicket tourTicket)
        {
            // Save customer info if customer not exist in db
            Customer customer = CustomerBLL.Instance.GetCustomerByIdCard(tourTicket.identity_card);
            if (customer == null)
            {
                CustomerBLL.Instance.Save(new Customer
                {
                    name = tourTicket.name,
                    email = tourTicket.email,
                    phone = tourTicket.phone,
                    idCard = tourTicket.identity_card,
                    customer_type_id = 1
                });
            }
            tourTicket.customer_id = CustomerBLL.Instance.GetCustomerByIdCard(tourTicket.identity_card).id;

            // Save tour ticket
            EntityManager db = EntityManager.Instance;
            var ticket = db.TourTickets.Where(tk => tk.id == tourTicket.id).FirstOrDefault();

            if (ticket == null)
            {
                db.TourTickets.Add(tourTicket);
            }
            else
            {
                ticket.tour_ticket_status_id = tourTicket.tour_ticket_status_id;
            }
            db.SaveChanges();
        }
    }
}
