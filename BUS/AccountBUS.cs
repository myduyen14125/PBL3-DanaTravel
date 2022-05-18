using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
        public DataTable GetDataTableEmployeeAccounts()
        {
            List<AccountDTO> accounts = GetEmployeeAccounts();
            DataTable dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn {ColumnName="ID", DataType = typeof(int)},
                new DataColumn {ColumnName = "Name", DataType = typeof(string)},
                new DataColumn {ColumnName = "Identity Card", DataType = typeof(string)},
                new DataColumn {ColumnName = "Account", DataType = typeof(string)},
                new DataColumn {ColumnName = "Status", DataType = typeof(bool)}
            });

            foreach (AccountDTO ac in accounts)
            {
                dt.Rows.Add(ac.id, ac.name, ac.idCard, ac.username, ac.status);
            }
            return dt;
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

        public List<AccountDTO> GetEmployeeAccounts()
        {
            return AccountDAO.Instance.GetEmployeeAccounts();
        }
        public List<AccountDTO> GetCustomerAccounts()
        {
            return AccountDAO.Instance.GetCustomerAccounts();
        }
        public Account GetAccountByUsername(string username)
        {
            return AccountDAO.Instance.GetAccountByUsername(username);
        }
    }
}
