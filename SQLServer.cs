﻿using System;
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
        public void Query(string query, NpgsqlConnection conn)
        {
            conn.Open();
            NpgsqlCommand insertinfo = new NpgsqlCommand(query, conn);
            insertinfo.ExecuteReader();
            conn.Close();
        }
        public string[] SearchData(string table, string column, NpgsqlConnection conn)
        {
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand($"SELECT {column} FROM {table} ", conn);
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
    }
}