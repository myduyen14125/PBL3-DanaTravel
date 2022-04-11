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
            EntityManager db = EntityManager.Instance;
            var result = from a in db.Accounts
                         from r in db.Roles
                         where a.username == ac.username && a.password == ac.password
                         select new { a.id, a.username, a.password, a.status, role_id = r.id, r.name };
            var firstRow = result.FirstOrDefault();
            if (firstRow == null) return null;

            List<Role> roles = new List<Role>();
            foreach (var i in result) roles.Add(new Role { id = i.role_id, name = i.name });

            return new Account
            {
                id = firstRow.id,
                username = firstRow.username,
                password = firstRow.password,
                status = firstRow.status,
                Roles = roles
            };
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
                db.Accounts.Add(ac);
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

        public Account GetAccountByUsername(string username)
        {
            return EntityManager.Instance.Accounts.Where(a => a.username == username).FirstOrDefault();
        }
    }
}
