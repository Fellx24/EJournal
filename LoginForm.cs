﻿using System;
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

            MenuForm menu = new MenuForm();
            menu.Show();
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
