using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class Tour
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public string namePlace { get; set; }
        public string photo { get; set; }
        [Required]
        public DateTime departureDay { get; set; }
        [Required]

        public DateTime returnDay { get; set; }
        public string transport { get; set; }
        public int quantity { get; set; }
        public bool tourGuide { get; set; }
        [Required]
        public int totalPrice { get; set; }

    }
}
