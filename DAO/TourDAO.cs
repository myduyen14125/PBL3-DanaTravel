using DTO;
using DTO.CodeFirstDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TourDAO
    {
        private static TourDAO _Instance;

        public static TourDAO Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new TourDAO();
                }
                return _Instance;
            }
        }
        public List<TourDTO> GetTourDTOs(int tour_category_id, string searchKey = "")
        {
            List<TourDTO> tourDTOs = new List<TourDTO>();
            EntityManager db = EntityManager.Instance;

            searchKey = searchKey.ToLower();

            var result = from t in db.Tours
                         join ts in db.TourStatuses on t.tour_status_id equals ts.id
                         join tc in db.TourCategories on t.tour_category_id equals tc.id
                         where ((tour_category_id == 0) ? true : t.tour_category_id == tour_category_id)
                               && (t.name.ToLower().Contains(searchKey) || tc.name.ToLower().Contains(searchKey)
                               || ts.name.ToLower().Contains(searchKey))
                         select new
                         {
                             t.id,
                             t.name,
                             t.short_desc,
                             t.detail_desc,
                             t.departureDate,
                             t.returnDate,
                             ts_id = ts.id,
                             ts_name = ts.name,
                             tc_id = tc.id,
                             tc_name = tc.name,
                             t.total_price_service,
                             t.percent_VAT,
                             t.percent_profit,
                             t.percent_price_children,
                             t.price_adult_one_ticket,
                             t.price_children_one_ticket
                         };
            
            foreach (var i in result)
            {
                int id = i.id;
                List<TourImage> tourImages = db.TourImages.Where(ti => ti.tour_id == id).ToList();
                
                tourDTOs.Add(new TourDTO
                {
                    id = i.id,
                    name = i.name,
                    short_desc = i.short_desc,
                    detail_desc = i.detail_desc,
                    departureDate = i.departureDate,
                    returnDate = i.returnDate,
                    tour_category_id = i.tc_id,
                    tour_category_name = i.tc_name,
                    tour_status_id = i.ts_id,
                    tour_status_name = i.ts_name,
                    total_price_service = i.total_price_service,
                    percent_VAT = i.percent_VAT,
                    percent_profit = i.percent_profit,
                    percent_price_children = i.percent_price_children,
                    price_adult_one_ticket = i.price_adult_one_ticket,
                    price_children_one_ticket = i.price_children_one_ticket,
                    TourImages = tourImages
                });
            }
            return tourDTOs;
        }
        public List<TourCategory> GetListTourCategory()
        {
            return EntityManager.Instance.TourCategories.ToList();
        }
        public void Save(Tour t)
        {
            EntityManager db = EntityManager.Instance;
            if (t.id == 0)
            {
                db.Tours.Add(t);
            }
            else
            {
                var data = db.Tours.Single(item => item.id == t.id);
                data.name = t.name;
                data.short_desc = t.short_desc;
                data.detail_desc = t.detail_desc;
                data.departureDate = t.departureDate;
                data.returnDate = t.returnDate;
                data.total_price_service = t.total_price_service;
                data.percent_VAT = t.percent_VAT;
                data.percent_profit = t.percent_profit;
                data.percent_price_children = t.percent_price_children;
                data.price_adult_one_ticket = t.price_adult_one_ticket;
                data.price_children_one_ticket = t.price_children_one_ticket;
                data.tour_status_id = t.tour_status_id;
                data.tour_category_id = t.tour_category_id;
                data.tour_category_id = t.tour_category_id;
                data.TourImages = t.TourImages;
            }
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            EntityManager db = EntityManager.Instance;
            var data = db.Tours.Single(s => s.id == id);
            db.Tours.Remove(data);
            db.SaveChanges();
        }
    }
}
