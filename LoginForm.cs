﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBUse
{
    public partial class LoginForm : Form
    {
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
            if (EmailTB.Text == "nigg3r@nig.ger" && PasswordTB.Text == "nigg333r")
            {
                MenuForm menu = new MenuForm();
                menu.Show();
                Hide();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
