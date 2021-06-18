using Npgsql;
using System;
using System.Windows.Forms;

namespace DBUse
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn = new SQLServer().GetConnection();

        private void BackButton_Click(object sender, EventArgs e)
        {
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            string insertquery = $"INSERT INTO public.teacher(surname,name,fathername,email) VALUES ({SurnameTB.Text},{NameTB.Text},{FathernameTB.Text},{EmailTB.Text})";

            try
            {
                NpgsqlCommand insertpwd = new NpgsqlCommand($"INSERT INTO public.users(password) VALUES ({PasswordTB.Text})", conn);
                NpgsqlCommand insertinfo = new NpgsqlCommand(insertquery, conn);
                insertinfo.ExecuteReader();
                insertpwd.ExecuteReader();
            }
            catch (PostgresException)
            {
                MenuForm menu = new MenuForm();
                menu.Show();
            }
            conn.Close();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
        }
    }
}