using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DBUse
{
    class SQLServer
    {
        public static SqlConnection
        GetDBConnection(string datasource, string database)
        {
                string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Integrated Security=True;";
                SqlConnection conn = new SqlConnection(connString);

                return conn;
        }
        public static SqlConnection GetDBConnection()
        {
                string datasource = "HDPC2";
                string database = "SchoolDB";

                return GetDBConnection(datasource, database);
        }
    }
}
