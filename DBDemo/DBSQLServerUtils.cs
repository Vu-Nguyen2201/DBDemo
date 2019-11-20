using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DBDemo

{
    class DBSQLServerUtils
    {

        public static SqlConnection
                 GetDBConnection(string datasource, string database, string username, string password)
        {
            //Data Source=DESKTOP-MHABU3S;Initial Catalog=DBDemo;Integrated Security=True

            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Integrated Security=SSPI;"; //";Persist Security Info=True;User ID=" + username + ";Password=" + password;

            SqlConnection conn = new SqlConnection(connString);

            return conn;
        }


    }
}