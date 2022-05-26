using DAO;
using DTO.CodeFirstDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BillBUS
    {
        private static BillBUS _Instance;

        public static BillBUS Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BillBUS();
                }
                return _Instance;
            }
        }
        public void Save(Bill bill)
        {
            BillDAO.Instance.Save(bill);
        }
    }
}
