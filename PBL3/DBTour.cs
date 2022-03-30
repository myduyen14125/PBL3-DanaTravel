using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3
{
    public class DBTour
    {
        private DataTable DTTour;
        public DBTour()
        {
            DTTour = new DataTable();
            DTTour.Columns.AddRange(new DataColumn[]
            {
                new DataColumn{ColumnName = "TourID", DataType = typeof(string)},
                new DataColumn{ColumnName = "Destination", DataType = typeof(string)},
                new DataColumn{ColumnName = "Departure", DataType = typeof (string)},
                new DataColumn{ColumnName = "Type", DataType = typeof(string)},
                new DataColumn{ColumnName = "Departure Date", DataType= typeof(DateTime)},
                new DataColumn{ColumnName = "Destination Date", DataType = typeof(DateTime)}
            });
            DTTour.Rows.Add("T1", "Bà Nà Hill", "Liên Chiểu", "Du lịch", "1/1/2022", "2/3/2022");
            DTTour.Rows.Add("T2", "Biển Mỹ Khê", "Liên Chiểu", "Du lịch", "1/1/2022", "2/3/2022");
            DTTour.Rows.Add("T3", "Cầu Rồng", "Liên Chiểu", "Tham quan", "1/1/2022", "2/3/2022");
            DTTour.Rows.Add("T4", "Đại học Bách Khoa", "Liên Chiểu", "Tham quan", "1/1/2022", "2/3/2022");
            DTTour.Rows.Add("T5", "Bà Nà Hill", "Liên Chiểu", "Du lịch", "1/1/2022", "2/3/2022");
        }
        public DataTable GetDTTour()
        {
            return DTTour;
        }

    }
}
