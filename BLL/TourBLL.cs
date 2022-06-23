using DTO;
using DTO.CodeFirstDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TourBLL
    {
        private static TourBLL _Instance;

        public static TourBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new TourBLL();
                }
                return _Instance;
            }
        }
        public List<Tour> GetTours(int tour_category_id, string searchKey)
        {
            EntityManager db = EntityManager.Instance;

            searchKey = searchKey.ToLower();

            List<Tour> tours = (from t in db.Tours
                                where (tour_category_id == 0 || t.TourCategory.id == tour_category_id)
                                  && (t.name.Contains(searchKey)
                                   || t.TourCategory.name.Contains(searchKey)
                                   || t.TourStatus.name.Contains(searchKey))
                                select t).ToList();
            foreach (Tour t in tours)
            {
                t.TourImages = db.TourImages.Where(ti => ti.tour_id == t.id).ToList();
            };
            return tours;
        }
        public Tour GetTourById(int tour_id)
        {
            return GetTours(0, "").Where(t => t.id == tour_id).FirstOrDefault();
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
