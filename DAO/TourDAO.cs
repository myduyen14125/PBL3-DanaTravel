using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            private set { }
        }
        public List<TourDTO> GetListTours(string searchKey)
        {
            EntityManager db = EntityManager.Instance;
            searchKey = searchKey.ToLower();
            var result = from i in db.Tour
                         where (i.namePlace.ToLower().Contains(searchKey))
                         select new
                         {
                             i.id,
                             i.namePlace,
                             i.photo,
                             i.departureDay,
                             i.returnDay,
                             i.transport,
                             i.quantity,
                             i.tourGuide,
                             i.totalPrice,
                         };
            List<TourDTO> list = new List<TourDTO>();
            foreach (var i in result)
            {
                list.Add(new TourDTO
                {
                    id = i.id,
                    namePlace = i.namePlace,
                    photo = i.photo,
                    departureDay = i.departureDay,
                    returnDay = i.returnDay,
                    transport = i.transport,
                    quantity = i.quantity,
                    tourGuide = i.tourGuide,
                    totalPrice = i.totalPrice,
                });
            }
            return list;
        }
        public List<string> GetAllTransport()
        {
            List<string> data = new List<string>();
            foreach (Tour i in EntityManager.Instance.Tour)
            {
                data.Add(i.transport);
            }
            return data;
        }
        public void Save(Tour t)
        {
            EntityManager db = EntityManager.Instance;
            if (t.id == 0)
            {
                db.Tour.Add(t);
            }
            else
            {
                var data = db.Tour.Single(item => item.id == t.id);
                data.namePlace = t.namePlace;
                data.photo = t.photo;
                data.departureDay = t.departureDay;
                data.returnDay = t.returnDay;
                data.transport = t.transport;
                data.quantity = t.quantity;
                data.tourGuide = t.tourGuide;
                data.totalPrice = t.totalPrice;
            }
            db.SaveChanges();
        }
        public void Delete(List<int> listId)
        {
            EntityManager db = EntityManager.Instance;
            foreach (int id in listId)
            {
                var result = db.Tour.Single(item => item.id == id);
                db.Tour.Remove(result);
            }
            db.SaveChanges();
        }
    }
}
