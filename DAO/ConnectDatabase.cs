using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace DAO
{
    class ConnectDatabase
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(AppConstant.PathConnectDatabase);
            return connection;
        }
    }
}
