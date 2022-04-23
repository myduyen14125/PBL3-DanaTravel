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

        public string namePlace { get; set; }
        public string photo { get; set; }
        public DateTime departureDay { get; set; }

        public DateTime returnDay { get; set; }
        public string transport { get; set; }
        public int quantity { get; set; } //số lượng người
        public bool tourGuide { get; set; }
        public int totalPrice { get; set; }
    }
}
