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

        public void Save(TourTicket tourTicket)
        {
            EntityManager.Instance.TourTicket.Add(tourTicket);
            EntityManager.Instance.SaveChanges();
        }
    }
}
