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

        public void Save(Bill bill)
        {
            EntityManager db = EntityManager.Instance;
            if(bill.id == 0)
            {
                db.Bills.Add(bill);
            }
            else
            {
                var result = db.Bills.Single(item => item.id == bill.id);
                result.bill_status_id = bill.bill_status_id;
                result.tour_ticket_id = bill.tour_ticket_id;
            }
            db.SaveChanges();
        }
    }
}
