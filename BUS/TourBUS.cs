using DAO;
using DTO;
using DTO.CodeFirstDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TourBUS
    {
        private static TourBUS _Instance;

        public static TourBUS Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new TourBUS();
                }
                return _Instance;
            }
        }
        public List<TourDTO> GetTourDTOs(int tour_category_id, string searchKey)
        {
            return TourDAO.Instance.GetTourDTOs(tour_category_id, searchKey);
        }
        public List<TourCategory> GetListTourCategory()
        {
            return TourDAO.Instance.GetListTourCategory();
        }

        public void Save(Tour t)
        {
            TourDAO.Instance.Save(t);
        }
        public void Delete(int id)
        {
            TourDAO.Instance.Delete(id);
        }
    }
}
