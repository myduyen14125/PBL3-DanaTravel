using DTO.CodeFirstDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TourDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string short_desc { get; set; }
        public string detail_desc { get; set; }
        public string transport { get; set; }
        public DateTime departureDate { get; set; }
        public DateTime returnDate { get; set; }
        public double total_price_service { get; set; }
        public double percent_VAT { get; set; } = 0;
        public double percent_profit { get; set; } = 0;
        public double percent_price_children { get; set; } = 100;
        public double price_adult_one_ticket { get; set; }
        public double price_children_one_ticket { get; set; }
        public int tour_status_id { get; set; }
        public string tour_status_name { get; set; }
        public int tour_category_id { get; set; }
        public string tour_category_name { get; set; }
        public List<TourImage> TourImages { get; set; }
    }
}
