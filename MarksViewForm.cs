using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBUse
{
    public partial class MarksViewForm : Form
    {
        SqlConnection conn = SQLServer.GetDBConnection();
        public MarksViewForm()
        {
            InitializeComponent();
        }

        private void refresher(DataGridView table)
        {
            conn.Open();
            string query = "SELECT * FROM Student";
            SqlDataAdapter dataStudent = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            dataStudent.Fill(dt);
            table.DataSource = dt;
            table.Columns[0].Visible = false;
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresher(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SurnameTB.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            NameTB.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            MarkTB.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Class_Click(object sender, EventArgs e)
        {

        }
    }
}
