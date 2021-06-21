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
        public void InsertQuery(string table, string values, NpgsqlConnection conn)
        {
            conn.Open();
            NpgsqlCommand insertinfo = new NpgsqlCommand($"INSERT INTO {table} VALUES({values}) ", conn);
            insertinfo.ExecuteReader();
            conn.Close();
        }
        public string[] SearchData(string table, string column, string condition ,NpgsqlConnection conn)
        {
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand($"SELECT {column} FROM {table} {condition} ", conn);
            NpgsqlDataReader reader = command.ExecuteReader();
            string String = " ";
            foreach (var item in reader)
            {
                String += reader[$"{column}"].ToString() + " ";
            }
            string[] stringarr = String.Split(' ').ToArray();
            conn.Close();
            return stringarr;
        }
        enum Roles
        {
            student = 0,
            teacher = 1,
            admin = 2,
        }
    }
}