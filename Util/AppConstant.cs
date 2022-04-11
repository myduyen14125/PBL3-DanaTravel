using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class AppConstant
    {
        public static string regexEmail = "^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$";
        public static string regexPhone = "^[0-9]{10}$";
        public static string regexNumber = "^\\d+$";
        public static string regexIdCard = "[0-9]{12}$";
    }
}
