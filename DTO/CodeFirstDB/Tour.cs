using DTO.CodeFirstDB;
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
        public string name { get; set; }
        [Required]
        public string desc { get; set; }
        [Required]
        public DateTime departureDate { get; set; }
        [Required]
        public DateTime returnDate { get; set; }
        public double percent_VAT { get; set; } = 0;
        public double percent_profit { get; set; } = 0;
        public double percent_adult_price { get; set; } = 100;
        public double percent_children_price { get; set; } = 100;

        public int tour_status_id { get; set; }
        public int tour_price_id { get; set; }
        public int tour_category_id { get; set; }

        [ForeignKey("tour_status_id")]
        public virtual TourStatus TourStatus { get; set; }

        [ForeignKey("tour_price_id")]
        public virtual TourPrice TourPrice { get; set; }

        [ForeignKey("tour_category_id")]
        public virtual TourCategory TourCategory { get; set; }

        public ICollection<Hotel> Hotels { get; set; }
        public ICollection<Service> Services { get; set; }
        public ICollection<Transport> Transports { get; set; }
        public ICollection<Site> Sites { get; set; }

        public Tour()
        {
            Hotels = new List<Hotel>();
            Services = new List<Service>();
            Transports = new List<Transport>();
            Sites = new List<Site>();
        }
    }
}
