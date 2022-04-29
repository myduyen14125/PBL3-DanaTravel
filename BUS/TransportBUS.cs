using DAO;
using DTO.CodeFirstDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TransportBUS
    {
        private static TransportBUS _Instance;
        public static TransportBUS Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new TransportBUS();
                }
                return _Instance;
            }
        }
        public List<Transport> GetAll()
        {
            return TransportDAO.Instance.GetAll();
        }
        public void Save(Transport t)
        {
            TransportDAO.Instance.Save(t);
        }
        public void Delete(int id)
        {
            TransportDAO.Instance.Delete(id);
        }
    }
}
