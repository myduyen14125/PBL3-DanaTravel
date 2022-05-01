using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.CodeFirstDB
{
    public class Site : BaseClass
    {
        public string address { get; set; }
        public string description { get; set; }
        public Site()
        {
            Tours = new List<Tour>();
        }
    }
}
