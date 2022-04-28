using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.CodeFirstDB
{
    public class TourPrice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public double transport_price { get; set; }
        public double hotel_price { get; set; }
        public double service_price { get; set; }
        public double discount_price { get; set; } // = (transport + hotel + service) * percent_discount; // giảm giá phần dịch vụ
        public double profit_price { get; set; } // = (transport + hotel + service - discount_price) * percent_profit; // lợi nhuận mong muốn trên 1 khách
        public double VAT_price { get; set; } // = (transport + hotel + service - discount_price + profit_price) * percent_VAT; // thuế
        public double total_price_one_ticket { get; set; } // = transport + hotel + service - discount_price + profit_price + VAT_price; // tiền 1 vé
        public double price_audult { get; set; } // total_price_one_ticket * percent_adult_price
        public double price_children { get; set; } // total_price_one_ticket * percent_children_price
    }
}
