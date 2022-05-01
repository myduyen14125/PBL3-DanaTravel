using DAO;
using DTO.CodeFirstDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SiteBUS
    {
        private static SiteBUS _Instance;

        public static SiteBUS Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new SiteBUS();
                }
                return _Instance;
            }
        }

        public List<Site> GetAll(string search_key)
        {
            return SiteDAO.Instance.GetAll(search_key);
        }

        public void Save(Site site)
        {
            SiteDAO.Instance.Save(site);
        }

        public void Delete(int id)
        {
            SiteDAO.Instance.Delete(id);
        }
    }
}
