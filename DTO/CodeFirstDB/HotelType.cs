using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.CodeFirstDB
{
    public class HotelType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public string name { get; set; }
        public ICollection<Hotel> Hotels { get; set; }

        public HotelType()
        {
            Hotels = new List<Hotel>();
        }
    }
}
