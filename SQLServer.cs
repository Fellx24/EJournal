using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace EJournal
{
    class SQLServer
    {
        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(
        @"Server=queenie.db.elephantsql.com;
        Port=5432;
        User Id=qenbptuc;
        Password=p96CcZ62GcjzSr7Ih0Gja7SH_asuHiag;
        Database=qenbptuc"
        );
        }
    }
}