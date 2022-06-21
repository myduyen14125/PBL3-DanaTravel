using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    class LoginBUS
    {
        private LoginDAO loginDAO = new LoginDAO();
        public AccountDTO checkAccount(AccountDTO account)
        {
            return loginDAO.checkAccount(account);
        }
    }
}
