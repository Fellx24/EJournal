using Npgsql;
using System;
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
            conn.Close();
                try
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
                catch (NpgsqlException)
                {
                    MessageBox.Show("Неправильный ввод либо E-mail уже зарегестрирован");
                    conn.Close();
                }

            conn.Close();
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            
        }
    }
}