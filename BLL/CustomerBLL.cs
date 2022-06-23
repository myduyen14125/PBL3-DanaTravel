using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CustomerBLL
    {
        private static CustomerBLL _Instance;

        public static CustomerBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new CustomerBLL();
                }
                return _Instance;
            }
        }

        public DataTable GetDataTableCustomer(List<Customer> customers)
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

            foreach (Customer c in customers)
            {
                string birthday = c.birthday == null ? null : ((DateTime)c.birthday).ToString("dd/MM/yyyy");
                //string gender = c.gender == null ? null : Convert.ToBoolean(c.gender) ? "Nam" : "Nữ";

                dt.Rows.Add(c.id, c.name, birthday, c.gender, c.idCard, c.phone, c.address, c.email, c.CustomerType.name);
            }
            return dt;
        }
        public Customer GetCustomerByIdCard(string id_card)
        {
            return EntityManager.Instance.Customers.Where(c => c.idCard == id_card).FirstOrDefault();
        }
        public List<Customer> GetListCustomers(int typeID, string searchKey = "")
        {
            EntityManager db = EntityManager.Instance;

            searchKey = searchKey.ToLower();

            return db.Customers.Where(c =>
                       (typeID == 0 || c.CustomerType.id == typeID)
                    && (c.name.Contains(searchKey) || c.address.Contains(searchKey))).ToList();
        }

        public List<CustomerType> GetListCustomerType()
        {
            return EntityManager.Instance.CustomerTypes.ToList();
        }

        public Customer GetCustomerDTOById(int id)
        {
            return EntityManager.Instance.Customers.SingleOrDefault(c => c.id == id);
        }

        public void Save(Customer c)
        {
            EntityManager db = EntityManager.Instance;
            if (c.id == 0)
            {
                db.Customers.Add(c);
            }
            else
            {
                var data = db.Customers.Single(t => t.id == c.id);
                data.name = c.name;
                data.gender = c.gender;
                data.birthday = c.birthday;
                data.idCard = c.idCard;
                data.address = c.address;
                data.phone = c.phone;
                data.email = c.email;
                data.customer_type_id = c.customer_type_id;
            }
            db.SaveChanges();
        }
        public void Delete(List<int> listId)
        {
            EntityManager db = EntityManager.Instance;
            foreach (int id in listId)
            {
                var result = db.Customers.Single(c => c.id == id);
                var account = from c in db.Customers
                              join ac in db.Accounts
                              on c.account_id equals ac.id
                              where c.id == id
                              select new
                              {
                                  ac.username
                              };

                db.Customers.Remove(result);
                if (account.FirstOrDefault() != null)
                {
                    AccountBLL.Instance.DeleteAccount(account.FirstOrDefault().username);
                }
            }
            db.SaveChanges();
        }
    }
}
