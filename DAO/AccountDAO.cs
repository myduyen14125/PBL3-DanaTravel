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
            private set { }
        }

        public Account CheckAccount(Account ac)
        {
            EntityManager db = EntityManager.Instance;
            var result = from a in db.Accounts
                         from r in db.Roles
                         where a.username == ac.username && a.password == ac.password
                         select new { a.account_id, a.username, a.password, a.status, r.role_id, r.role_name };
            var firstRow = result.FirstOrDefault();
            if (firstRow == null) return null;

            List<Role> roles = new List<Role>();
            foreach (var i in result) roles.Add(new Role { role_id = i.role_id, role_name = i.role_name });

            return new Account
            {
                account_id = firstRow.account_id,
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
                db.Accounts.Add(ac);
            }
            catch (Exception e)
            {
                return false;
            }
            db.SaveChanges();
            return true;
        }
    }
}
