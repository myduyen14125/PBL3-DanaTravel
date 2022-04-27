using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable GetDataTableTour(List<TourDTO> tours)
        {
            DataTable dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn {ColumnName="ID", DataType = typeof(int)},
                new DataColumn {ColumnName = "Tên địa điểm", DataType = typeof(string)},
                new DataColumn {ColumnName = "Hình ảnh", DataType = typeof(string)},
                new DataColumn {ColumnName = "Ngày khởi hành", DataType = typeof(DateTime)},
                new DataColumn {ColumnName = "Ngày trở về", DataType = typeof(DateTime)},
                new DataColumn {ColumnName = "Phương tiện", DataType = typeof(string)},
                new DataColumn {ColumnName = "Số lượng", DataType = typeof(int)},
                new DataColumn {ColumnName = "Hướng dẫn viên", DataType = typeof(bool)},
                new DataColumn {ColumnName = "Tổng chi phí", DataType = typeof(int)},
            });

            foreach (TourDTO t in tours)
            {
                dt.Rows.Add(t.id, t.namePlace, t.photo, t.departureDay, t.returnDay, t.transport, t.quantity, t.tourGuide, t.totalPrice);
            }
            return dt;
        }

        public List<TourDTO> GetListTours(string searchKey = "")
        {
            return TourDAO.Instance.GetListTours(searchKey);
        }
        public List<string> GetAllTransport()
        {
            return TourDAO.Instance.GetAllTransport();
        }
        public TourDTO GetTourDTOById(int id)
        {
            return TourDAO.Instance.GetTourDTOById(id);
        }

        public void Save(Tour e)
        {
            TourDAO.Instance.Save(e);
        }
        public void Delete(List<int> listId)
        {
            TourDAO.Instance.Delete(listId);
        }
    }
}
