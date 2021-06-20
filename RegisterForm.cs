using Npgsql;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EJournal
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
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Close();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string insertquery = $"INSERT INTO public.teacher(surname,name,fathername,email) VALUES ({SurnameTB.Text},{NameTB.Text},{FathernameTB.Text},\'{EmailTB.Text}\')";
            conn.Open();

            NpgsqlDataReader reader = null;
            NpgsqlCommand emailcheck = new NpgsqlCommand($"SELECT email FROM public.teacher", conn);
            reader = emailcheck.ExecuteReader();
            string email = " ";
            foreach (var item in reader)
            {
                email += reader["email"].ToString() + " ";
            }
            string[] emailmas = email.Split(' ').ToArray();
            conn.Close();
            if (emailmas.Contains(EmailTB.Text))
            {
                MessageBox.Show("E-mail уже зарегестрирован");
                conn.Close();
            }
            else if (EmailTB.Text.Contains('@'))
            {
                conn.Open();
                NpgsqlCommand insertinfo = new NpgsqlCommand(insertquery, conn);
                insertinfo.ExecuteReader();
                conn.Close();
                conn.Open();
                NpgsqlCommand insertpwd = new NpgsqlCommand($"INSERT INTO public.users(password,email) VALUES ({PasswordTB.Text.ToString()},\'{EmailTB.Text.ToString()}\')", conn);
                insertpwd.ExecuteReader();
                conn.Close();
                MenuForm menu = new MenuForm();
                menu.Show();
            }
            conn.Close();
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
        }
    }
}