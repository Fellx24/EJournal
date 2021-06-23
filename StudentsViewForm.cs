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
    public partial class StudentsViewForm : Form
    {
        public StudentsViewForm()
        {
            InitializeComponent();
        }

        NpgsqlConnection conn = new SQLServer().GetConnection();
        private void refresher(DataGridView table)
        {
            if (MenuForm.SelectedClass != null && MenuForm.SelectedClass != "Все")
            {
                conn.Open();
                string query = $"SELECT * FROM \"Users\" WHERE role = 0, class = {MenuForm.SelectedClass}";
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

            if (MenuForm.SelectedClass == null || MenuForm.SelectedClass == "Все")
            {
                conn.Open();
                string query = "SELECT * FROM \"Users\" WHERE role = 0";
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
        }

        private void StudentsViewForm_Load(object sender, EventArgs e)
        {
            refresher(StudentsDGV);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            Close();
        }

        private void StudentDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SurnameTB.Text = StudentsDGV.SelectedRows[0].Cells[1].Value.ToString();
            NameTB.Text = StudentsDGV.SelectedRows[0].Cells[2].Value.ToString();
            FathernameTB.Text = StudentsDGV.SelectedRows[0].Cells[3].Value.ToString();
            BirthdayTB.Text = StudentsDGV.SelectedRows[0].Cells[7].Value.ToString();
            ClassTB.Text = StudentsDGV.SelectedRows[0].Cells[8].Value.ToString();
            EmailTB.Text = StudentsDGV.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
