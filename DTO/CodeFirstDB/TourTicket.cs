using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.CodeFirstDB
{
    public class TourTicket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public DateTime date { get; set; }
        public double number_adult { get; set; }
        public double number_children { get; set; }
        public double total_price { get; set; }
        public string note { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string identity_card { get; set; }
        public int customer_id { get; set; }
        public int tour_id { get; set; }
        public int account_id { get; set; }
        public int tour_ticket_status_id { get; set; }

        [ForeignKey("customer_id")]
        public virtual Customer Customer { get; set; }

        [ForeignKey("account_id")]
        public virtual Account Account { get; set; }

        [ForeignKey("tour_ticket_status_id")]
        public virtual TourTicketStatus TourTicketStatus { get; set; }

        [ForeignKey("tour_id")]
        public virtual Tour tour { get; set; }
    }
}
