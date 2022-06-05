using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class StatisticBUS
    {
        private static StatisticBUS _Instance;
        public static StatisticBUS Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new StatisticBUS();
                }
                return _Instance;
            }
        }
        public List<Revenue> GetRevenues(int monthFrom, int monthTo, int year)
        {
            return StatisticDAO.Instance.GetRevenues(monthFrom, monthTo, year);
        }

        public List<Revenue> GetRevenuesTourOutStanding(int monthFrom, int monthTo, int year)
        {
            return StatisticDAO.Instance.GetRevenuesTourOutStanding(monthFrom, monthTo, year);
        }
    }
}
