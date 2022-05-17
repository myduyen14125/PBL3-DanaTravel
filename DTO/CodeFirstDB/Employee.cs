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
    public class Employee : Person
    {
        public double salary { get; set; }

        public int position_id { get; set; }

        public int division_id { get; set; }

        public int education_degree_id { get; set; }

        public int account_id { get; set; }

        public byte[] image { get; set; } = null;

        [ForeignKey("division_id")]
        public virtual Division Division { get; set; }

        [ForeignKey("position_id")]
        public virtual Position Position { get; set; }

        [ForeignKey("education_degree_id")]
        public virtual Education_degree Education_degree { get; set; }

        [ForeignKey("account_id")]
        public virtual Account Account { get; set; }
    }
}
