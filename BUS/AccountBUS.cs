using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class AccountBUS
    {
        private static AccountBUS _Instance;

        public static AccountBUS Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new AccountBUS();
                }
                return _Instance;
            }
        }

        public Account CheckAccount(Account ac)
        {
            return AccountDAO.Instance.CheckAccount(ac);
        }

        public bool ChangePassword(Account ac)
        {
            return AccountDAO.Instance.ChangePassword(ac);
        }

        public bool RegisterAccount(Account ac)
        {
            return AccountDAO.Instance.RegisterAccount(ac);
        }

        public bool DeleteAccount(string username)
        {
            return AccountDAO.Instance.DeleteAccount(username);
        }

        public Account GetAccountByUsername(string username)
        {
            return AccountDAO.Instance.GetAccountByUsername(username);
        }
    }
}
