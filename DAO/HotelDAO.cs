using DTO;
using DTO.CodeFirstDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HotelDAO
    {
        private static HotelDAO _Instance;

        public static HotelDAO Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new HotelDAO();
                }
                return _Instance;
            }
        }

        public List<HotelDTO> GetHotels()
        {
            EntityManager db = EntityManager.Instance;

            //searchKey = searchKey.ToLower();

            var result = from h in db.Hotels
                         join ht in db.HotelTypes on h.hotel_type_id equals ht.id
                         select new
                         {
                             h.id,
                             h.name,
                             h.price,
                             h.description,
                             h.hotel_type_id,
                             h.image,
                             hotel_type_name = ht.name 
                         };
            List<HotelDTO> list = new List<HotelDTO>();
            foreach (var i in result)
            {
                list.Add(new HotelDTO
                {
                    id = i.id,
                    name = i.name,
                    price = i.price,
                    description = i.description,
                    hotel_type_id = i.hotel_type_id,
                    hotel_type_name = i.hotel_type_name,
                    image = (Byte[])(i.image)
                }) ;
            }
            return list;
        }
        public List<HotelType> GetHotelTypes()
        {
            return EntityManager.Instance.HotelTypes.ToList();
        }

        public void Save(Hotel hotel)
        {
            EntityManager db = EntityManager.Instance;
            if (hotel.id == 0)
            {
                db.Hotels.Add(hotel);
            }
            else
            {
                var data = db.Hotels.Single(h => h.id == hotel.id);
                data.name = hotel.name;
                data.price = hotel.price;
                data.image = hotel.image;
                data.description = hotel.description;
                data.hotel_type_id = hotel.hotel_type_id;
            }
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            EntityManager db = EntityManager.Instance;
            var result = db.Hotels.Single(t => t.id == id);
            db.Hotels.Remove(result);
            db.SaveChanges();
        }
    }
}
