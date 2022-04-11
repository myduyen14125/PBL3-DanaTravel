using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Util
{
    public class Validate
    {
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, AppConstant.regexEmail);
        }

        public bool ValidatePhone(string phone)
        {
            return Regex.IsMatch(phone, AppConstant.regexPhone);
        }

        public bool ValidateIdCard(string idCard)
        {
            return Regex.IsMatch(idCard, AppConstant.regexIdCard);
        }
    }
}
