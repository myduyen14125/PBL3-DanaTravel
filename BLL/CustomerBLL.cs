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
            return EntityManager.Instance.Customers.Where(c => c.idCard == id_card).FirstOrDefault();
        }
        public List<CustomerDTO> GetListCustomers(int typeID, string searchKey = "")
        {
            EntityManager db = EntityManager.Instance;

            searchKey = searchKey.ToLower();

            var result = from c in db.Customers
                         join ct in db.CustomerTypes on c.customer_type_id equals ct.id
                         where ((typeID == 0) ? true : ct.id == typeID) &&
                         (c.name.ToLower().Contains(searchKey) || c.address.ToLower().Contains(searchKey))
                         select new
                         {
                             c.id,
                             c.name,
                             c.birthday,
                             c.gender,
                             c.idCard,
                             c.phone,
                             c.email,
                             c.address,
                             ct_id = ct.id,
                             ct_name = ct.name,
                         };
            List<CustomerDTO> list = new List<CustomerDTO>();
            foreach (var i in result)
            {
                CustomerDTO c = new CustomerDTO
                {
                    id = i.id,
                    name = i.name,
                    idCard = i.idCard,
                    email = i.email,
                    phone = i.phone,
                    address = i.address,
                    customer_type_id = i.ct_id,
                    customer_type_name = i.ct_name
                };
                if (i.birthday != null) c.birthday = (DateTime)i.birthday;
                if (i.gender != null) c.gender = (bool)i.gender;
                list.Add(c);
            }
            return list;
        }

        public List<CustomerType> GetListCustomerType()
        {
            return EntityManager.Instance.CustomerTypes.ToList();
        }

        public CustomerDTO GetCustomerDTOById(int id)
        {
            EntityManager db = EntityManager.Instance;
            var result = from c in db.Customers
                         join ct in db.CustomerTypes on c.customer_type_id equals ct.id
                         where c.id == id
                         select new
                         {
                             c.id,
                             c.name,
                             c.birthday,
                             c.gender,
                             c.idCard,
                             c.phone,
                             c.email,
                             c.address,
                             ct_id = ct.id,
                             ct_name = ct.name,
                         };
            var i = result.FirstOrDefault();
            List<CustomerType> customerTypes = db.CustomerTypes.Where(r => r.Customers.Any(c => c.id == i.ct_id)).ToList();
            CustomerDTO customer = new CustomerDTO
            {
                id = i.id,
                name = i.name,
                idCard = i.idCard,
                email = i.email,
                phone = i.phone,
                address = i.address,
                customer_type_id = i.ct_id,
                customer_type_name = i.ct_name,
            };
            if (i.birthday != null) customer.birthday = (DateTime)i.birthday;
            if (i.gender != null) customer.gender = (bool)i.gender;
            return customer;
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
