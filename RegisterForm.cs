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
            NpgsqlDataAdapter emails = new NpgsqlDataAdapter($"SELECT email FROM public.teacher",);
            emails.ToString();
            string insertquery = $"INSERT INTO public.teacher(surname,name,fathername,email) VALUES ({SurnameTB.Text},{NameTB.Text},{FathernameTB.Text},{EmailTB.Text})";
            if (EmailTB.Text.Contains("@"))
            {
                try
                {

                    conn.Open();
                    NpgsqlCommand insertinfo = new NpgsqlCommand(insertquery, conn);
                    insertinfo.ExecuteReader();
                    conn.Close();
                    conn.Open();
                    NpgsqlCommand insertpwd = new NpgsqlCommand($"INSERT INTO public.users(password) VALUES ({PasswordTB.Text})", conn);
                    insertpwd.ExecuteReader();
                    conn.Close();

                }
                catch (PostgresException)
                {
                    MessageBox.Show("Неправильный ввод либо E-mail уже зарегестрирован");
                }
            }
            else MessageBox.Show("Неправильный ввод");

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {

        }
    }
}