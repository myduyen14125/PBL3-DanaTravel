using DTO;
using DTO.CodeFirstDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SiteDAO
    {
        private static SiteDAO _Instance;

        public static SiteDAO Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new SiteDAO();
                }
                return _Instance;
            }
        }

        public List<Site> GetAll(string search_key)
        {
            search_key = search_key.ToLower();
            return EntityManager.Instance.Sites.Where(t => t.name.ToLower().Contains(search_key) 
            || t.address.ToLower().Contains(search_key)).ToList();
        }
        
        public void Save(Site site)
        {
            EntityManager db = EntityManager.Instance;
            if(site.id == 0)
            {
                db.Sites.Add(site);
            }
            else
            {
                var data = db.Sites.Single(s => s.id == site.id);
                data.name = site.name;
                data.price = site.price;
                data.address = site.address;
                data.description = site.description;
                data.image = site.image;
            }
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            EntityManager db = EntityManager.Instance;
            var data = db.Sites.Single(s => s.id == id);
            db.Sites.Remove(data);
            db.SaveChanges();
        }
    }
}
