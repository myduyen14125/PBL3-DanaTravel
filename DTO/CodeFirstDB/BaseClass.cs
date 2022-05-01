
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.CodeFirstDB
{
    public abstract class BaseClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public string name { get; set; }
        [Required]
        public double price { get; set; } = 0;
        
        [Column(TypeName = "image")]
        public Byte[] image { get; set; }
        public ICollection<Tour> Tours { get; set; }
    }
}
