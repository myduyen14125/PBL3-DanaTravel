using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class EmployeeBUS
    {
        private static EmployeeBUS _Instance;

        public static EmployeeBUS Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new EmployeeBUS();
                }
                return _Instance;
            }
        }

        public DataTable GetDataTableEmployee(List<EmployeeDTO> employees)
        {
            DataTable dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn {ColumnName="ID", DataType = typeof(int)},
                new DataColumn {ColumnName = "Tên nhân viên", DataType = typeof(string)},
                new DataColumn {ColumnName = "Ngày sinh", DataType = typeof(string)},
                new DataColumn {ColumnName = "Giới tính", DataType = typeof(string)},
                new DataColumn {ColumnName = "CCCD", DataType = typeof(string)},
                new DataColumn {ColumnName = "Số điện thoại", DataType = typeof(string)},
                new DataColumn {ColumnName = "Địa chỉ", DataType = typeof(string)},
                new DataColumn {ColumnName = "Email", DataType = typeof(string)},
                new DataColumn {ColumnName = "Lương", DataType = typeof(double)},
                new DataColumn {ColumnName = "Trình độ", DataType = typeof(string)},
                new DataColumn {ColumnName = "Bộ phận", DataType = typeof(string)},
                new DataColumn {ColumnName = "Vị trí", DataType = typeof(string)},
            });

            foreach (EmployeeDTO e in employees)
            {
                dt.Rows.Add(e.id, e.name, e.birthday.ToString("dd/MM/yyyy"), e.gender ? "Nam" : "Nữ", e.idCard, e.phone, e.address, e.email, e.salary,
                    e.education_degree_name, e.division_name, e.position_name);
            }
            return dt;
        }

        public List<EmployeeDTO> GetListEmployee(int divisionId, string searchKey)
        {
            return EmployeeDAO.Instance.GetListEmployee(divisionId, searchKey);
        }

        public List<Division> GetListDivision()
        {
            return EmployeeDAO.Instance.GetListDivision();
        }

        public List<Position> GetListPosition()
        {
            return EmployeeDAO.Instance.GetListPosition();
        }

        public List<Education_degree> GetListEducation()
        {
            return EmployeeDAO.Instance.GetListEducation();
        }

        public EmployeeDTO GetEmployeeDTOById(int id)
        {
            return EmployeeDAO.Instance.GetEmployeeDTOById(id);
        }
        public void Save(Employee e)
        {
            EmployeeDAO.Instance.Save(e);
        }

        public void Delete(List<int> listId)
        {
            EmployeeDAO.Instance.Delete(listId);
        }
    }
}
