using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            NpgsqlCommand insertinfo = new NpgsqlCommand($"INSERT INTO {table} VALUES {values} ", conn);
            insertinfo.ExecuteReader();
            conn.Close();
        }
        public string[] SearchData(string table, string column, string condition, NpgsqlConnection conn)
        {
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand($"SELECT \"{column}\" FROM \"{table}\"", conn);
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
        public string[] RecieveFIO(TextBox SurnameTB, TextBox NameTB, TextBox FathernameTB, NpgsqlConnection conn)
        {
            string[] fio = SearchData("Users", "Surname", $"WHERE email = \'{LoginForm.email}\'", conn);
            SurnameTB.Text = fio[1];
            fio = SearchData("Users", "Name", $"WHERE email = \'{LoginForm.email}\'", conn);
            NameTB.Text = fio[1];
            fio = SearchData("Users", "Fathername", $"WHERE email = \'{LoginForm.email}\'", conn);
            FathernameTB.Text = fio[1];
            return fio;
        }
        p
    }
}