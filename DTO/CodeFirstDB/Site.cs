using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.CodeFirstDB
{
    public class Site : BaseClass
    {
        public Site()
        {
            Tours = new List<Tour>();
        }
    }
}
