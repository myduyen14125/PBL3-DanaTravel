using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.CodeFirstDB
{
    public class TourImage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public Byte[] image { get; set; }

        public int tour_id { get; set; }

        [ForeignKey("tour_id")]
        public virtual Tour Tour { get; set; }

        public TourImage()
        {

        }
    }
}
