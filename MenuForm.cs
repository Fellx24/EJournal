using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJournal
{
    public partial class MenuForm : Form
    {
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
    }
}
