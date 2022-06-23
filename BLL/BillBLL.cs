using DTO;
using DTO.CodeFirstDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BillBLL
    {
        private static BillBLL _Instance;

        public static BillBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BillBLL();
                }
                return _Instance;
            }
        }

        public List<Bill> GetBills(string search, int bill_status_id)
        {
            search = search.Trim().ToLower();
            EntityManager db = EntityManager.Instance;

            List<Bill> bills = (from b in db.Bills
                                where b.bill_status_id == bill_status_id
                                && (b.TourTicket.name.Contains(search) 
                                    || b.TourTicket.email.Equals(search)
                                    || b.TourTicket.phone.Equals(search) 
                                    || b.TourTicket.identity_card.Equals(search))
                                select b).ToList();
            return bills;
        }

        public void Save(Bill bill)
        {
            EntityManager db = EntityManager.Instance;
            if (db.Bills.Where(b => b.TourTicket.id == bill.tour_ticket_id).FirstOrDefault() != null)
            {
                return;
            }
            if (bill.id == 0)
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
