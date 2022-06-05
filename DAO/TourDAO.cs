using DTO;
using DTO.CodeFirstDB;
using System.Collections.Generic;
using System.Linq;

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
        public List<TourDTO> GetTourDTOs(int tour_category_id, string searchKey)
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
                             t.transport,
                             t.departureDate,
                             t.returnDate,
                             tour_status_id = ts.id,
                             tour_status_name = ts.name,
                             tour_category_id = tc.id,
                             tour_category_name = tc.name,
                             t.price_adult_one_ticket,
                             t.price_children_one_ticket
                         };

            if (result == null) return tourDTOs;

            foreach (var i in result)
            {
                List<TourImage> tourImages = db.TourImages.Where(ti => ti.tour_id == i.id).ToList();
                tourDTOs.Add(new TourDTO
                {
                    id = i.id,
                    name = i.name,
                    short_desc = i.short_desc,
                    detail_desc = i.detail_desc,
                    transport = i.transport,
                    departureDate = i.departureDate,
                    returnDate = i.returnDate,
                    tour_category_id = i.tour_category_id,
                    tour_category_name = i.tour_category_name,
                    tour_status_id = i.tour_status_id,
                    tour_status_name = i.tour_status_name,
                    price_adult_one_ticket = i.price_adult_one_ticket,
                    price_children_one_ticket = i.price_children_one_ticket,
                    TourImages = tourImages
                });
            }
            return tourDTOs;
        }

        public TourDTO GetTourDTOById(int tour_id)
        {
            EntityManager db = EntityManager.Instance;

            List<TourImage> tourImages = db.TourImages.Where(ti => ti.tour_id == tour_id).ToList();
            var result = from t in db.Tours
                         join ts in db.TourStatuses on t.tour_status_id equals ts.id
                         join tc in db.TourCategories on t.tour_category_id equals tc.id
                         where t.id == tour_id
                         select new
                         {
                             t.id,
                             t.name,
                             t.short_desc,
                             t.detail_desc,
                             t.transport,
                             t.departureDate,
                             t.returnDate,
                             tour_status_id = ts.id,
                             tour_status_name = ts.name,
                             tour_category_id = tc.id,
                             tour_category_name = tc.name,
                             t.price_adult_one_ticket,
                             t.price_children_one_ticket
                         };
            var i = result.FirstOrDefault();
            return new TourDTO
            {
                id = i.id,
                name = i.name,
                short_desc = i.short_desc,
                detail_desc = i.detail_desc,
                transport = i.transport,
                departureDate = i.departureDate,
                returnDate = i.returnDate,
                tour_category_id = i.tour_category_id,
                tour_category_name = i.tour_category_name,
                tour_status_id = i.tour_status_id,
                tour_status_name = i.tour_status_name,
                price_adult_one_ticket = i.price_adult_one_ticket,
                price_children_one_ticket = i.price_children_one_ticket,
                TourImages = tourImages
            };
        }
        public List<TourCategory> GetListTourCategory()
        {
            return EntityManager.Instance.TourCategories.ToList();
        }
        public void Save(Tour t)
        {
            EntityManager db = EntityManager.Instance;
            List<TourImage> tourImages = db.TourImages.Where(ti => ti.tour_id == t.id).ToList();
            db.TourImages.RemoveRange(tourImages);
            db.TourImages.AddRange(t.TourImages);

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
                data.transport = t.transport;
                data.departureDate = t.departureDate;
                data.returnDate = t.returnDate;
                data.price_adult_one_ticket = t.price_adult_one_ticket;
                data.price_children_one_ticket = t.price_children_one_ticket;
                data.tour_status_id = t.tour_status_id;
                data.tour_category_id = t.tour_category_id;
                data.tour_category_id = t.tour_category_id;
            }
            db.SaveChanges();
        }

        public void DeleteById(int id)
        {
            EntityManager db = EntityManager.Instance;
            var data = db.Tours.Single(t => t.id == id);
            db.Tours.Remove(data);
            db.SaveChanges();
        }
    }
}
