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
    public class HotelBUS
    {
        private static HotelBUS _Instance;

        public static HotelBUS Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new HotelBUS();
                }
                return _Instance;
            }
        }

        public List<HotelDTO> GetHotels()
        {
            return HotelDAO.Instance.GetHotels();
        }

        public List<HotelType> GetHotelTypes()
        {
            return HotelDAO.Instance.GetHotelTypes();
        }

        public void Save(Hotel hotel)
        {
            HotelDAO.Instance.Save(hotel);
        }

        public void Delete(int id)
        {
            HotelDAO.Instance.Delete(id);
        }
    }
}
