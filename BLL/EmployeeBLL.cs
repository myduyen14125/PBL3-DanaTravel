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
            EntityManager db = EntityManager.Instance;
            searchKey = searchKey.ToLower();
            var result = from e in db.Employees
                         join d in db.Divisions on e.division_id equals d.id
                         join p in db.Positions on e.position_id equals p.id
                         join ed in db.Education_degrees on e.education_degree_id equals ed.id
                         where ((divisionId == 0) ? true : d.id == divisionId)
                               && (e.name.ToLower().Contains(searchKey) || e.address.ToLower().Contains(searchKey))
                         select new
                         {
                             e.id,
                             e.name,
                             e.birthday,
                             e.gender,
                             e.idCard,
                             e.phone,
                             e.email,
                             e.address,
                             e.salary,
                             d_id = d.id,
                             d_name = d.name,
                             p_id = p.id,
                             p_name = p.name,
                             ed_id = ed.id,
                             edu_name = ed.name
                         };
            
            List<EmployeeDTO> employeeDTOs = new List<EmployeeDTO>();
            foreach (var i in result)
            {
                employeeDTOs.Add(new EmployeeDTO
                {
                    id = i.id,
                    name = i.name,
                    birthday = (DateTime)i.birthday,
                    gender = (bool)i.gender,
                    idCard = i.idCard,
                    email = i.email,
                    phone = i.phone,
                    address = i.address,
                    salary = i.salary,
                    division_id = i.d_id,
                    division_name = i.d_name,
                    position_id = i.p_id,
                    position_name = i.p_name,
                    education_degree_id = i.ed_id,
                    education_degree_name = i.edu_name
                });
            }
            return employeeDTOs;
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

        public EmployeeDTO GetEmployeeDTOById(int id)
        {
            EntityManager db = EntityManager.Instance;
            var result = from e in db.Employees
                         join d in db.Divisions on e.division_id equals d.id
                         join p in db.Positions on e.position_id equals p.id
                         join ed in db.Education_degrees on e.education_degree_id equals ed.id
                         join ac in db.Accounts on e.account_id equals ac.id
                         where e.id == id
                         select new
                         {
                             e.id,
                             e.name,
                             e.birthday,
                             e.gender,
                             e.idCard,
                             e.phone,
                             e.email,
                             e.address,
                             e.salary,
                             e.image,
                             d_id = d.id,
                             d_name = d.name,
                             p_id = p.id,
                             p_name = p.name,
                             ed_id = ed.id,
                             edu_name = ed.name,
                             ac_id = ac.id,
                             username = ac.username
                         };
            var i = result.FirstOrDefault();
            List<Role> dataRoles = db.Roles.Where(r => r.Accounts.Any(ac => ac.id == i.ac_id)).ToList();
            return new EmployeeDTO
            {
                id = i.id,
                name = i.name,
                birthday = (DateTime)i.birthday,
                gender = (bool)i.gender,
                idCard = i.idCard,
                email = i.email,
                phone = i.phone,
                address = i.address,
                salary = i.salary,
                image = i.image,
                division_id = i.d_id,
                division_name = i.d_name,
                position_id = i.p_id,
                position_name = i.p_name,
                education_degree_id = i.ed_id,
                education_degree_name = i.edu_name,
                account_id = i.ac_id,
                account_name = i.username,
                roles = dataRoles
            };
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
