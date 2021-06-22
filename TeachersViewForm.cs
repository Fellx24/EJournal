using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace EJournal
{
    public partial class TeachersViewForm : Form
    {
        public TeachersViewForm()
        {
            InitializeComponent();
        }

        NpgsqlConnection conn = new SQLServer().GetConnection();
        private void refresher(DataGridView table)
        {
            conn.Open();
            string query = "SELECT * FROM \"Users\" WHERE role = 1";
            NpgsqlDataAdapter dataStudent = new NpgsqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            dataStudent.Fill(dt);
            table.DataSource = dt;
            table.Columns[0].Visible = false;
            table.Columns[6].Visible = false;
            table.Columns[5].Visible = false;
            table.Columns[1].HeaderText = "Фамилия";
            table.Columns[2].HeaderText = "Имя";
            table.Columns[3].HeaderText = "Отчество";
            table.Columns[4].HeaderText = "Email";
            table.Columns[7].HeaderText = "Дата рождения";
            table.Columns[8].HeaderText = "Класс";
            conn.Close();
        }

        private void TeachersViewForm_Load(object sender, EventArgs e)
        {
            refresher(TeachersDGV);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            Close();
        }
    }
}
