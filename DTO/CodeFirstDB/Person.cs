using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.CodeFirstDB
{
    public abstract class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public DateTime birthday { get; set; }

        [Required]
        public bool gender { get; set; }

        [Required]
        public string idCard { get; set; }

        [Required]
        public string phone { get; set; }

        public string address { get; set; } = null;

        [Required]
        public string email { get; set; }
    }
}
