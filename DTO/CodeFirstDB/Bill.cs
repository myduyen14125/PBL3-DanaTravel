using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.CodeFirstDB
{
    public class Bill
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public Nullable<DateTime> date { get; set; }
        [Required]
        public int bill_status_id { get; set; }
        public int tour_ticket_id { get; set; }

        [ForeignKey("bill_status_id")]
        public virtual BillStatus BillStatus { get; set; }

        [ForeignKey("tour_ticket_id")]
        public virtual TourTicket TourTicket { get; set; }
    }
}
