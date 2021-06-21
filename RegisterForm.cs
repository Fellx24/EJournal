﻿using Npgsql;
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
            string[] emailarr = query.SearchData("public.users", "email", "" , conn);

            if (emailarr.Contains(EmailTB.Text))
            {
                MessageBox.Show("E-mail уже зарегестрирован");
            }
            else if (EmailTB.Text.Contains('@'))
            {
                query.InsertQuery($"public.users(surname, name, fathername, password, email)", $"{SurnameTB.Text},{NameTB.Text},{FathernameTB.Text},{PasswordTB.Text}, \'{EmailTB.Text}\'" , conn);
                LoginForm login = new LoginForm();
                login.Show();
                Close();

            }
            emailarr = null;
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
        }
    }
}