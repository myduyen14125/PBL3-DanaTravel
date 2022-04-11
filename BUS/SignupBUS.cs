using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SignupBUS
    {
        private SignupDAO signupDAO = new SignupDAO();
        public bool Register(AccountDTO account)
        {
            return signupDAO.Register(account);
        }    
    }
}
