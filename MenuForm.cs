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
    public partial class MenuForm : Form
    {
        NpgsqlConnection conn = new SQLServer().GetConnection();
        SQLServer query = new SQLServer();
        public MenuForm()
        {
            InitializeComponent();
        }

        private void OpenSubject (string classValue, string subjectValue)
        {
            MarksViewForm marksForm = new MarksViewForm();
            marksForm.Show();
            Close();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.Show();
            Close();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            string welcome = "Здравствуйте, ";
            string[] fo = query.SearchData("Users", "Name", $"WHERE email = \'{LoginForm.email}\'", conn);
            welcome += fo[1] + " ";
            fo = query.SearchData("Users", "Fathername", $"WHERE email = \'{LoginForm.email}\'", conn);
            welcome += fo[1];
            MainLabel.Text = welcome;
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if(ClassesCB.SelectedItem != null && SubjectsCB.SelectedItem != null)
            {
                OpenSubject(ClassesCB.Text, SubjectsCB.Text);
            }

            if (ClassesCB.SelectedItem == null || SubjectsCB.SelectedItem == null)
            {
                MessageBox.Show("ИДИОТ! Не смей нажимать на кнопку, если не выбран класс и предмет!");
            }
        }

        private void ClassesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubjectsCB.Visible = true;
        }

        private void MenuForm_Load_1(object sender, EventArgs e)
        {

        }

        private void StudentsListButton_Click(object sender, EventArgs e)
        {
            StudentsViewForm studForm = new StudentsViewForm();
            studForm.Show();
            Close();
        }

        private void TeachersListButton_Click(object sender, EventArgs e)
        {
            TeachersViewForm teachForm = new TeachersViewForm();
            teachForm.Show();
            Close();
        }
    }
}
