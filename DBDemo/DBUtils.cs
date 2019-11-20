using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DBDemo
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            //Data Source=DESKTOP-MHABU3S;Initial Catalog=DBDemo;Integrated Security=True
            string datasource = @"DESKTOP-MHABU3S";
            string database = "DBDemo";
            string username = "sa";
            string password = "1234";

            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }

}