using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CustomerDTO
    {
        public int id { get; set; }

        public string name { get; set; }

        public DateTime birthday { get; set; }

        public bool gender { get; set; }

        public string idCard { get; set; }

        public string phone { get; set; }

        public string address { get; set; } = null;

        public string email { get; set; }
        public int customer_type_id { get; set; }
        public string customer_type_name { get; set; }
    }
}
