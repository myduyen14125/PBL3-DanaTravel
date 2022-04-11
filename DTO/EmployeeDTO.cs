using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EmployeeDTO
    {
        public int id { get; set; }

        public string name { get; set; }

        public DateTime birthday { get; set; }

        public bool gender { get; set; }

        public string idCard { get; set; }

        public string phone { get; set; }

        public string address { get; set; } = null;

        public string email { get; set; }

        public double salary { get; set; }

        public int position_id { get; set; }

        public int division_id { get; set; }

        public int education_degree_id { get; set; }

        public int account_id { get; set; }

        public string division_name { get; set; }

        public string position_name { get; set; }

        public string education_degree_name { get; set; }

        public string account_name { get; set; }

        public List<Role> roles { get; set; }
    }
}
