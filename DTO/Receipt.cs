using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Receipt
    {
        public string tour_name { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public double number_adult { get; set; }
        public double number_children { get; set; }
        public double price_adult_one_ticket { get; set; }
        public double price_children_one_ticket { get; set; }
        public double total_price_adult { get; set; }
        public double total_price_children { get; set; }
        public double total_price { get; set; }
    }
}
