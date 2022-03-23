using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace DAO
{
    public class SignupDAO
    {
        public bool Register(AccountDTO account)
        {
            int n;
            SqlDataReader reader;

            SqlConnection sqlConnection = ConnectDatabase.GetConnection();
            if (sqlConnection == null)    sqlConnection = new SqlConnection(AppConstant.PathConnectDatabase);
            if (sqlConnection.State == ConnectionState.Closed)  sqlConnection.Open();
            
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.Text;

            // Kiểm tra email đã tồn tại hay chưa
            string queryCheckExist = "SELECT COUNT(*) FROM ACCOUNT WHERE username = '" + account.username + "'";
            sqlCommand.CommandText = queryCheckExist;
            n = (int)sqlCommand.ExecuteScalar();
            if (n == 1)     return false;

            // Thêm dữ liệu vào ACCOUNT
            string queryInsert = "insert into ACCOUNT values ('" + account.username + "', '" + account.password + "', 1);";
            sqlCommand.CommandText = queryInsert;
            n = sqlCommand.ExecuteNonQuery();
            if (n != 1) return false;

            // Lấy Id mới thêm vào
            string querySelectIdAccount = "SELECT id FROM ACCOUNT WHERE username = '" + account.username + "'";
            sqlCommand.CommandText = querySelectIdAccount;
            int id = (int)sqlCommand.ExecuteScalar();

            // Thêm dữ liệu vào ACCOUNT_ROLE
            string queryInsertRole = "insert into ACCOUNT_ROLE values(" + id + ", 6)";
            sqlCommand.CommandText = queryInsertRole;
            n = sqlCommand.ExecuteNonQuery();
            if (n != 1) return false;

            return true;
        }
    }
}
