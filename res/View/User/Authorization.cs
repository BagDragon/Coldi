﻿using Coldi.res.Control;
using Coldi.res.Model;
using Npgsql;
using NpgsqlTypes;
using System.Data;


namespace Coldi
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }



        private void Log_in_Click(object sender, EventArgs e)
        {
            FindUsers.findUser(loginBox.Text, passwordBox.Text);

        }

        private void unregistered_Click(object sender, EventArgs e)
        {

            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Close();

        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            BackgroundForms.backgroundForm(this);
        }
    }
}