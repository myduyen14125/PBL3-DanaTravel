using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class EmployeeBLL
    {
        private static EmployeeBLL _Instance;

        public static EmployeeBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new EmployeeBLL();
                }
                return _Instance;
            }
        }

        public DataTable GetDataTableEmployee(List<Employee> employees)
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

            foreach (Employee e in employees)
            {
                dt.Rows.Add(e.id, e.name, ((DateTime)e.birthday).ToString("dd/MM/yyyy"), (bool)e.gender ? "Nam" : "Nữ", e.idCard, e.phone, e.address, e.email, e.salary,
                    e.Education_degree.name, e.Division.name, e.Position.name);
            }
            return dt;
        }

        public List<Employee> GetListEmployee(int divisionId, string searchKey, string sortBy, string sortDir)
        {
            EntityManager db = EntityManager.Instance;

            List<Employee> employees = (from e in db.Employees
                                        where (divisionId == 0 || e.Division.id == divisionId)
                                              && (e.name.Contains(searchKey) || e.address.Contains(searchKey)
                                                 || e.email.Contains(searchKey))
                                        select e).ToList();

            return Sort(employees, sortBy, sortDir);
        }
        public List<Employee> Sort(List<Employee> employees, string sortBy, string sortDir)
        {
            if (sortBy.ToLower() == "nosort") 
                return employees;
            else
            {
                switch (sortBy.ToLower())
                {
                    case "name":
                        return (sortDir.ToLower() == "asc" ? employees.OrderBy(e => e.name)
                                    : employees.OrderByDescending(e => e.name)).ToList();
                    case "salary":
                        return (sortDir.ToLower() == "asc" ? employees.OrderBy(e => e.salary)
                                    : employees.OrderByDescending(e => e.salary)).ToList();
                    case "birthday":
                        return (sortDir.ToLower() == "asc" ? employees.OrderBy(e => e.birthday)
                                    : employees.OrderByDescending(e => e.birthday)).ToList();
                    default:
                        return employees;
                }
            }
        }

        public List<Division> GetListDivision()
        {
            return EntityManager.Instance.Divisions.ToList();
        }

        public List<Position> GetListPosition()
        {
            return EntityManager.Instance.Positions.ToList();
        }

        public List<Education_degree> GetListEducation()
        {
            return EntityManager.Instance.Education_degrees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            return EntityManager.Instance.Employees.Single(e => e.id == id);
        }
        public void Save(Employee e)
        {
            EntityManager db = EntityManager.Instance;
            if (e.id == 0)
            {
                db.Employees.Add(e);
            }
            else
            {
                var data = db.Employees.Single(t => t.id == e.id);
                data.name = e.name;
                data.gender = e.gender;
                data.birthday = e.birthday;
                data.idCard = e.idCard;
                data.salary = e.salary;
                data.address = e.address;
                data.phone = e.phone;
                data.email = e.email;
                data.division_id = e.division_id;
                data.position_id = e.position_id;
                data.education_degree_id = e.education_degree_id;
                data.account_id = e.account_id;
                data.image = e.image;
            }
            db.SaveChanges();
        }

        public void Delete(List<int> listId)
        {
            EntityManager db = EntityManager.Instance;
            foreach (int id in listId)
            {
                var result = db.Employees.Single(c => c.id == id);
                db.Employees.Remove(result);
                AccountBLL.Instance.DeleteAccount(result.email);
            }
            db.SaveChanges();
        }
    }
}
