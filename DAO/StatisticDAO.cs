using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{

    public class StatisticDAO
    {
        private static StatisticDAO _Instance;
        public static StatisticDAO Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new StatisticDAO();
                }
                return _Instance;
            }
        }

        public List<Revenue> GetRevenues(int monthFrom, int monthTo, int year)
        {
            List<Revenue> revenues = new List<Revenue>();
            EntityManager db = EntityManager.Instance;

            var result = from b in db.Bills
                         join tk in db.TourTickets on b.tour_ticket_id equals tk.id
                         where b.date.Value.Month >= monthFrom && b.date.Value.Month <= monthTo
                         && b.date.Value.Year == year
                         group b by new { month = b.date.Value.Month } into m
                         select new
                         {
                             text = m.Key.month,
                             total = m.Sum(t => t.TourTicket.total_price)
                         };
            foreach(var i in result)
            {
                revenues.Add(new Revenue
                {
                    name = i.text.ToString(),
                    total = Convert.ToInt32(i.total)
                });
            }
            return revenues;
        }

        public List<Revenue> GetRevenuesTourOutStanding(int monthFrom, int monthTo, int year)
        {
            List<Revenue> revenues = new List<Revenue>();
            EntityManager db = EntityManager.Instance;

            var result = from b in db.Bills
                          join tk in db.TourTickets on b.tour_ticket_id equals tk.id
                          join t in db.Tours on tk.tour_id equals t.id
                          where b.date.Value.Month >= monthFrom && b.date.Value.Month <= monthTo
                          && b.date.Value.Year == year
                          group b by new { id = t.id, name = t.name } into m
                          select new
                          {
                              text = m.Key.name,
                              total = m.Sum(t => t.TourTicket.total_price)
                          };
            result = result.OrderByDescending(t => t.total);
            foreach (var i in result)
            {
                revenues.Add(new Revenue
                {
                    name = i.text,
                    total = Convert.ToInt32(i.total)
                });
            }
            return revenues;
        }
    }
}
