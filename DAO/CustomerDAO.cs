using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO _Instance;

        public static CustomerDAO Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new CustomerDAO();
                }
                return _Instance;
            }
        }
        public List<CustomerDTO> GetListCustomers(int typeID, string searchKey)
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
                list.Add(new CustomerDTO
                {
                    id = i.id,
                    name = i.name,
                    birthday = i.birthday,
                    gender = i.gender,
                    idCard = i.idCard,
                    email = i.email,
                    phone = i.phone,
                    address = i.address,
                    customer_type_id = i.ct_id,
                    customer_type_name = i.ct_name
                });
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
            return new CustomerDTO
            {
                id = i.id,
                name = i.name,
                birthday = i.birthday,
                gender = i.gender,
                idCard = i.idCard,
                email = i.email,
                phone = i.phone,
                address = i.address,
                customer_type_id = i.ct_id,
                customer_type_name = i.ct_name,
            };
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
                //data.customer_type_id = c.customer_type_id;
            }
            db.SaveChanges();
        }
        public void Delete(List<int> listId)
        {
            EntityManager db = EntityManager.Instance;
            foreach (int id in listId)
            {
                var result = db.Customers.Single(c => c.id == id);
                db.Customers.Remove(result);
                AccountDAO.Instance.DeleteAccount(result.email);
            }
            db.SaveChanges();
        }
    }
}
