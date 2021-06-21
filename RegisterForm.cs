using Npgsql;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

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
            SQLServer query = new SQLServer();
            string[] emailarr = query.SearchData("public.teacher", "email", conn);

            if (emailarr.Contains(EmailTB.Text))
            {
                MessageBox.Show("E-mail уже зарегестрирован");
                conn.Close();
            }
            else if (EmailTB.Text.Contains('@'))
            {
                query.InsertQuery("public.teacher(surname,name,fathername,email)", $"{SurnameTB.Text},{NameTB.Text},{FathernameTB.Text},\'{EmailTB.Text}\'", conn);
                query.InsertQuery("public.users(password, email)",$"{PasswordTB.Text},\'{EmailTB.Text}\'" , conn);
                query.InsertQuery("public.roles(role, email)", $"(student,\'{EmailTB.Text}\')", conn);
                MenuForm menu = new MenuForm();
                menu.Show();
            }
            emailarr = null;
            conn.Close();
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
        }
    }
}