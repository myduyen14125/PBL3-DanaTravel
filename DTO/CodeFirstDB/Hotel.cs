using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.CodeFirstDB
{
    public class Hotel : BaseClass
    {
        public string address { get; set; }
        public string description { get; set; }
        public int hotel_type_id { get; set; }

        [ForeignKey("hotel_type_id")]
        public virtual HotelType HotelType { get; set; }
        public Hotel()
        {
            Tours = new List<Tour>();
        }
    }
}
