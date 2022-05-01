using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HotelDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string description { get; set; }
        public Byte[] image { get; set; }
        public int hotel_type_id { get; set; }
        public string hotel_type_name { get; set; }
    }
}
