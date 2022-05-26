using DTO;
using DTO.CodeFirstDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
