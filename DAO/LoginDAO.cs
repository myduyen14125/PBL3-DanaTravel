using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace DAO
{
    public class LoginDAO
    {
        public AccountDTO checkAccount(AccountDTO account)
        {
            string username, password, role_name;
            bool status;
            int role_id;
            List<int> permission_ids = new List<int>();
            List<string> permission_names = new List<string>();
            SqlDataReader reader;

            AccountDTO temp = null;

            SqlConnection sqlConnection = ConnectDatabase.GetConnection();

            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(AppConstant.PathConnectDatabase);
            }
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            string query = "select username, password, status, r.id, r.name, p.id, p.name" +
                           " from ACCOUNT ac" +
                           " left join ACCOUNT_ROLE acr on ac.id = acr.account_id" +
                           " left join ROLE r on acr.role_id = r.id" +
                           " left join ROLE_PERMISSION rp on r.id = rp.role_id" +
                           " left join PERMISSION p on rp.permission_id = p.id" +
                           " where username = '" + account.username + "' and password = '" + account.password + "'";

            // Để khởi tạo 
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = query;
            reader = sqlCommand.ExecuteReader();

            if (reader.Read())
            {
                username = reader.GetString(0);
                password = reader.GetString(1);
                status = reader.GetBoolean(2);
                role_id = reader.GetInt32(3);
                role_name = reader.GetString(4);

                if (reader.IsDBNull(5))
                {
                    temp = new AccountDTO(username, password, status, role_id, role_name);
                    return temp;
                }
                else
                {
                    permission_ids.Add(reader.GetInt32(5));
                    permission_names.Add(reader.GetString(6));
                }
            }
            else return temp;

            while (reader.Read())
            {
                if (string.IsNullOrEmpty(reader.GetInt32(5).ToString()))
                {
                    permission_ids.Add(reader.GetInt32(5));
                    permission_names.Add(reader.GetString(6));
                }
            }
            temp = new AccountDTO(username, password, status, role_id, role_name, permission_ids, permission_names);
            return temp;
        }
    }
}
