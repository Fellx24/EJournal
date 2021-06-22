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
    public partial class LoginForm : Form
    {
        SQLServer query = new SQLServer();
        NpgsqlConnection conn = new SQLServer().GetConnection();
        public static string email;
        public static int role;
        

        public LoginForm()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            Hide();
            
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] passwordcheck = query.SearchData("Users", "password",$"WHERE email = \'{EmailTB.Text}\'", conn);
                if (passwordcheck.Contains(PasswordTB.Text))
                {
                    MenuForm menu = new MenuForm();
                    menu.Show();
                    email = EmailTB.Text;
                    string[] rolecheck = query.SearchData("Users", "role", $"WHERE email = \'{EmailTB.Text}\'", conn);
                    role = int.Parse(rolecheck[1]);
                    Hide();
                }
                else MessageBox.Show("E-mail уже зарегестрирован");
            }
            catch (NpgsqlException)
            {
                MessageBox.Show("E-mail не зарегестрирован");
            }
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
