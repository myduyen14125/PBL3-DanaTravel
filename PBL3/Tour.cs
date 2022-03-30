using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3
{
    public class Tour
    {
        public string TourID { get; set; }
        public string Destination { get; set; }//diem den
        public string Departure { get; set; }//diem di
        public string Type { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime DestinationDate { get; set; }

    }
}
