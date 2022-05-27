using DTO;
using DTO.CodeFirstDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BillDAO
    {
        private static BillDAO _Instance;

        public static BillDAO Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BillDAO();
                }
                return _Instance;
            }
        }
        public List<BillDTO> GetBillDTOs(string search, int bill_status_id)
        {
            search = search.Trim().ToLower();
            EntityManager db = EntityManager.Instance;
            List<BillDTO> bills = new List<BillDTO>();
            var result = from tk in db.TourTickets
                         join b in db.Bills on tk.id equals b.tour_ticket_id
                         where (b.bill_status_id == bill_status_id)
                         && (tk.name.ToLower().Contains(search) || tk.email.ToLower().Equals(search)
                         || tk.phone.Equals(search) || tk.identity_card.Equals(search))
                         select new
                         {
                             tk.name,
                             tk.email,
                             tk.phone,
                             tk.identity_card,
                             tk.total_price,
                             tk.number_adult,
                             tk.number_children,
                             b.id,
                             b.date,
                             b.bill_status_id
                         };

            foreach (var i in result)
            {
                BillDTO c = new BillDTO
                {
                    id = i.id,
                    name = i.name,
                    identity_card = i.identity_card,
                    email = i.email,
                    phone = i.phone,
                    number_children = i.number_children,
                    number_adult = i.number_adult,  
                    total_price = i.total_price,
                };
                if (i.date != null) c.date = (DateTime)i.date;

                bills.Add(c);
            }
            return bills;
        }
        public void Save(Bill bill)
        {
            EntityManager db = EntityManager.Instance;
            if(db.Bills.Where(b => b.TourTicket.id == bill.tour_ticket_id).FirstOrDefault() != null)
            {
                return;
            }
            if(bill.id == 0)
            {
                db.Bills.Add(bill);
            }
            else
            {
                var result = db.Bills.Single(item => item.id == bill.id);
                result.bill_status_id = bill.bill_status_id;
                result.date = bill.date;
            }
            db.SaveChanges();
        }

    }
}
