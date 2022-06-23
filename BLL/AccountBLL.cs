using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace BLL
{
    public class AccountBLL
    {
        private static AccountBLL _Instance;

        public static AccountBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new AccountBLL();
                }
                return _Instance;
            }
        }
        
        public DataTable GetDataTableEmployeeAccounts(string search = "")
        {
            List<Employee> employees = EmployeeBLL.Instance.GetListEmployee(0, search, "", "NoSort");
            DataTable dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn {ColumnName = "STT", DataType = typeof(int)},
                new DataColumn {ColumnName = "Name", DataType = typeof(string)},
                new DataColumn {ColumnName = "Identity Card", DataType = typeof(string)},
                new DataColumn {ColumnName = "Username", DataType = typeof(string)},
                new DataColumn {ColumnName = "Status", DataType = typeof(bool)}
            });
            int i = 1;
            foreach (Employee e in employees)
            {
                dt.Rows.Add(i, e.name, e.idCard, e.Account.username, e.Account.status);
                i++;
            }
            return dt;
        }
        
        public Account CheckAccount(Account ac)
        {
            return EntityManager.Instance.Accounts.Where(t => t.username == ac.username && t.password == ac.password).FirstOrDefault();
        }
        
        public bool IsRoleCustomer(Account ac)
        {
            return ac.Roles.FirstOrDefault().name.ToLower() == "customer";
        }

        public bool ChangePassword(Account account)
        {
            EntityManager db = EntityManager.Instance;
            var result = db.Accounts.Single(ac => ac.username == account.username);
            result.password = account.password;
            db.SaveChanges();
            return true;
        }
        
        public bool RegisterAccount(Account ac, bool isSendEmail = true)
        {
            EntityManager db = EntityManager.Instance;

            var result = db.Accounts.Where(a => a.username == ac.username).FirstOrDefault();
            if (result != null)
            {
                return false;
            }
            db.Accounts.Add(ac);
            db.SaveChanges();
            if(isSendEmail)
            {
                SendEmailHelper send = new SendEmailHelper();
                string header = "DanaTravel send your account for login Danatravel Application";
                string body = "<h3> Your account: " + ac.username + "</h3>"
                    + "<h3>Password: " + ac.password + "</h3>"
                    + "<h3>Please login to change your password</h3>";
                new SendEmailHelper().SendEmail(ac.username, header, body);
            }
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
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        
        public Account GetAccountByUsername(string username)
        {
            return EntityManager.Instance.Accounts.Where(a => a.username == username).FirstOrDefault();
        }
        
        public void ChangeStatusAccount(string username, bool status)
        {
            var account = EntityManager.Instance.Accounts.Single(ac => ac.username == username);
            account.status = status;
            EntityManager.Instance.SaveChanges();

            SendEmailHelper send = new SendEmailHelper();

            string status_string = status ? "unlocked" : "locked";
            string header = "Notify" + status_string + "your account of Danatravel Application";
            string body = "<h3> Your account: " + username + "</h3>"
                        + "<h3>has" + status_string + "</h3>"
                        + "<h3>Please contact hotline 1900.9999 if you have any questions </h3>";
            new SendEmailHelper().SendEmail(username, header, body);
        }
    }
}
