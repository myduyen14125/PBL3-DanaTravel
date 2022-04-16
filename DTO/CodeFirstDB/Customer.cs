using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Customer : DTO.CodeFirstDB.Person
    {
        public int customer_type_id { get; set; }

        [ForeignKey("customer_type_id")]
        public virtual CustomerType CustomerType { get; set; }
    }
}
