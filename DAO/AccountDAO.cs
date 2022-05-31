using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class AccountDAO
    {
        private static AccountDAO _Instance;
        public static AccountDAO Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new AccountDAO();
                }
                return _Instance;
            }
        }

        public Account CheckAccount(Account ac)
        {
            return EntityManager.Instance.Accounts.Where(t => t.username == ac.username && t.password == ac.password).FirstOrDefault();
        }

        public bool ChangePassword(Account account)
        {
            EntityManager db = EntityManager.Instance;
            var result = db.Accounts.Single(ac => ac.username == account.username);
            result.password = account.password;
            db.SaveChanges();
            return true;
        }

        public bool RegisterAccount(Account ac)
        {
            EntityManager db = EntityManager.Instance;
            try
            {
                var result = db.Accounts.Where(a => a.username == ac.username).FirstOrDefault();
                if (result != null)
                {
                    return false;
                }
                else db.Accounts.Add(ac);
            }
            catch (Exception)
            {
                return false;
            }
            db.SaveChanges();
            return true;
        }

        public bool DeleteAccount(string username)
        {
            try
            {
                EntityManager db = EntityManager.Instance;
                var result = db.Accounts.Single(ac => ac.username == username);
                db.Accounts.Remove(result);
                db.SaveChanges();
            }
            catch(Exception)
            {
                return false;
            }
            return true;
        }
        public List<AccountDTO> GetEmployeeAccounts(string search)
        {
            EntityManager db = EntityManager.Instance;
            var result =  from ac in db.Accounts
                          join e in db.Employees on ac.id equals e.account_id 
                          where (ac.username.ToLower().Contains(search) 
                          || e.name.ToLower().Contains(search) || e.idCard.ToLower().Contains(search))
                          select new { ac.id, ac.username, ac.status, e.name, e.idCard};
            List<AccountDTO> accounts = new List<AccountDTO>();
            foreach(var i in result)
            {
                accounts.Add(new AccountDTO
                {
                    id = i.id,
                    username = i.username,
                    status = i.status,
                    name = i.name,
                    idCard = i.idCard
                }) ;
            }
            return accounts;
        }
        public List<AccountDTO> GetCustomerAccounts()
        {
            EntityManager db = EntityManager.Instance;
            var result = from ac in db.Accounts
                         join c in db.Customers on ac.id equals c.account_id
                         select new { ac.id, ac.username, ac.status, c.name, c.idCard };
            List<AccountDTO> accounts = new List<AccountDTO>();
            foreach (var i in result)
            {
                accounts.Add(new AccountDTO
                {
                    id = i.id,
                    username = i.username,
                    status = i.status,
                    name = i.name,
                    idCard = i.idCard
                });
            }
            return accounts;
        }
        public Account GetAccountByUsername(string username)
        {
            return EntityManager.Instance.Accounts.Where(a => a.username == username).FirstOrDefault();
        }
        public void ChangeStatusAccount(int id, bool status)
        {
            var account = EntityManager.Instance.Accounts.Single(ac => ac.id == id);
            account.status = status;
            EntityManager.Instance.SaveChanges();
        }
    }
}
