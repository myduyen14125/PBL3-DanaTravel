using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BillDTO
    {
        public int id { get; set; }
        public int bill_status_id { get; set; }
        public int tour_ticket_id { get; set; }
        public double number_adult { get; set; }
        public double number_children { get; set; }
        public double total_price { get; set; }
        public string note { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string identity_card { get; set; }
    }
}
