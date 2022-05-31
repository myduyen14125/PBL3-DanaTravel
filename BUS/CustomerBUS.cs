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
    public class CustomerBUS
    {
        private static CustomerBUS _Instance;

        public static CustomerBUS Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new CustomerBUS();
                }
                return _Instance;
            }
        }

        public DataTable GetDataTableCustomer(List<CustomerDTO> customers)
        {
            DataTable dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn {ColumnName="ID", DataType = typeof(int)},
                new DataColumn {ColumnName = "Tên khách hàng", DataType = typeof(string)},
                new DataColumn {ColumnName = "Ngày sinh", DataType = typeof(string)},
                new DataColumn {ColumnName = "Giới tính", DataType = typeof(string)},
                new DataColumn {ColumnName = "CCCD", DataType = typeof(string)},
                new DataColumn {ColumnName = "Số điện thoại", DataType = typeof(string)},
                new DataColumn {ColumnName = "Địa chỉ", DataType = typeof(string)},
                new DataColumn {ColumnName = "Email", DataType = typeof(string)},
                new DataColumn {ColumnName = "Loại khách hàng", DataType = typeof(string)},
            });

            foreach (CustomerDTO c in customers)
            {
                string birthday = c.birthday == null ? null : ((DateTime)c.birthday).ToString("dd/MM/yyyy");
                string gender = c.gender == null ? null : Convert.ToBoolean(c.gender) ? "Nam" : "Nữ";

                dt.Rows.Add(c.id, c.name, birthday, gender, c.idCard, c.phone, c.address, c.email, c.customer_type_name);
            }
            return dt;
        }
        public Customer GetCustomerByIdCard(string id_card)
        {
            return CustomerDAO.Instance.GetCustomerByIdCard(id_card);
        }
        public List<CustomerDTO> GetListCustomers(int typeID, string searchKey = "")
        {
            return CustomerDAO.Instance.GetListCustomers(typeID, searchKey);
        }

        public List<CustomerType> GetListCustomerType()
        {
            return CustomerDAO.Instance.GetListCustomerType();
        }

        public CustomerDTO GetCustomerDTOById(int id)
        {
            return CustomerDAO.Instance.GetCustomerDTOById(id);
        }

        public void Save(Customer e)
        {
            CustomerDAO.Instance.Save(e);
        }
        public void Delete(List<int> listId)
        {
            CustomerDAO.Instance.Delete(listId);
        }
    }
}
