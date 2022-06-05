using DTO;
using DTO.CodeFirstDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class TourTicketDAO
    {
        private static TourTicketDAO _Instance;

        public static TourTicketDAO Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new TourTicketDAO();
                }
                return _Instance;
            }
        }
        public List<TourTicket> GetTourTickets(string search, int tour_ticket_status_id)
        {
            search = search.Trim();
            search = search.ToLower();
            return EntityManager.Instance.TourTickets.Where(tk => (tk.name.ToLower().Contains(search)
                    || tk.email.ToLower().Contains(search) || tk.phone.ToLower().Contains(search)
                    || tk.identity_card.ToLower().Contains(search)) && tk.tour_ticket_status_id == tour_ticket_status_id).ToList();
        }

        public List<TourTicketDTO> GetTourTicketsByAccount(int account_id, int tour_ticket_status_id, int bill_status_id)
        {
            EntityManager db = EntityManager.Instance;
            List<TourTicketDTO> tourTickets = new List<TourTicketDTO>();
            var result = from tk in db.TourTickets
                         join t in db.Tours on tk.tour_id equals t.id
                         join b in db.Bills on tk.id equals b.tour_ticket_id into tkbTable
                         from tkb in tkbTable.DefaultIfEmpty()
                         where tk.account_id == account_id && tk.tour_ticket_status_id == tour_ticket_status_id
                         && ((bill_status_id == 0) ? true : tkb.bill_status_id == bill_status_id)
                         select new { 
                            tk.id,
                            tk.tour_id,
                            tk.account_id,
                            tk.tour_ticket_status_id,
                            tk.name,
                            tk.email,
                            tk.phone,
                            tk.identity_card,
                            tk.number_adult,
                            tk.number_children,
                            tk.total_price,
                            tour_name = t.name,
                            t.departureDate,
                         };
            if (result == null) return tourTickets;
            foreach(var i in result)
            {
                List<TourImage> tourImages = db.TourImages.Where(ti => ti.tour_id == i.tour_id).ToList();
                tourTickets.Add(new TourTicketDTO
                {
                    id = i.id,
                    name = i.name,
                    email = i.email,
                    phone = i.phone,
                    identity_card = i.identity_card,
                    number_adult = i.number_adult,
                    number_children = i.number_children,
                    total_price = i.total_price,
                    tour_id = i.tour_id,
                    ticket_status_id = i.tour_ticket_status_id,
                    tour_name = i.tour_name,
                    account_id = i.account_id,
                    departureDate = i.departureDate,
                    TourImages = tourImages
                });
            }
            return tourTickets;
        }
        public void Save(TourTicket tourTicket)
        {
            EntityManager db = EntityManager.Instance;
            var ticket = db.TourTickets.Where(tk => tk.id == tourTicket.id).FirstOrDefault();
            if(ticket == null)
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
