using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StatisticDTO
    {
        public int id { get; set; }
        public string month { get; set; }
        public int totalMoney { get; set; }
        public int totalTour { get; set; }
    }
}
