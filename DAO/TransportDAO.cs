using DTO;
using DTO.CodeFirstDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TransportDAO
    {
        private static TransportDAO _Instance;
        public static TransportDAO Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new TransportDAO();
                }
                return _Instance;
            }
        }
        public List<Transport> GetAll()
        {
            return EntityManager.Instance.Transports.ToList();
        }

        public void Save(Transport t)
        {
            EntityManager db = EntityManager.Instance;
            if (t.id == 0)
            {
                db.Transports.Add(t);
            }
            else
            {
                var data = db.Transports.Single(tsp => tsp.id == t.id);
                data.name = t.name;
                data.price = t.price;
                data.image = t.image;
            }
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            EntityManager db = EntityManager.Instance;
            var result = db.Transports.Single(t => t.id == id);
            db.Transports.Remove(result);
            db.SaveChanges();
        }
    }
}
