using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.CodeFirstDB
{
    public class Transport : BaseClass
    {
        public Transport()
        {
            Tours = new List<Tour>();
        }
    }
}
