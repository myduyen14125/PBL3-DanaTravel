using DTO.CodeFirstDB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DTO
{
    public class Tour 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public string transport { get; set; }
        [Required]
        public string short_desc { get; set; }
        [Required]
        public string detail_desc { get; set; }
        [Required]
        public DateTime departureDate { get; set; }
        [Required]
        public DateTime returnDate { get; set; }
        [Required]
        public double price_adult_one_ticket { get; set; }
        [Required]
        public double price_children_one_ticket { get; set; }
        public int tour_status_id { get; set; }
        public int tour_category_id { get; set; }

        [ForeignKey("tour_status_id")]
        public virtual TourStatus TourStatus { get; set; }

        [ForeignKey("tour_category_id")]
        public virtual TourCategory TourCategory { get; set; }
        public ICollection<TourImage> TourImages { get; set; } = null;
        public ICollection<TourTicket> TourTickets { get; set; } = null;
        public Tour()
        {
            TourImages = new List<TourImage>();
            TourTickets = new List<TourTicket>();
        }
    }
}
