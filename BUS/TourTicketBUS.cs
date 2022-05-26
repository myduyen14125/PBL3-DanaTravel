using DAO;
using DTO;
using DTO.CodeFirstDB;
using System.Collections.Generic;

namespace BUS
{
    public class TourTicketBUS
    {
        private static TourTicketBUS _Instance;

        public static TourTicketBUS Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new TourTicketBUS();
                }
                return _Instance;
            }
        }
        public List<TourTicket> GetTourTickets(string search, int tour_ticket_status_id)
        {
            return TourTicketDAO.Instance.GetTourTickets(search, tour_ticket_status_id);
        }
        public void Save(TourTicket tourTicket)
        {
            Customer customer = CustomerBUS.Instance.GetCustomerByIdCard(tourTicket.identity_card);
            if (customer == null)
            {
                CustomerBUS.Instance.Save(new Customer
                {
                    name = tourTicket.name,
                    email = tourTicket.email,
                    phone = tourTicket.phone,
                    idCard = tourTicket.identity_card,
                    customer_type_id = 1
                }) ;
            }
            tourTicket.customer_id = CustomerBUS.Instance.GetCustomerByIdCard(tourTicket.identity_card).id;
            TourTicketDAO.Instance.Save(tourTicket);
        }
    }
}
