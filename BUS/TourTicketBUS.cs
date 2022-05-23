using DAO;
using DTO;
using DTO.CodeFirstDB;

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
