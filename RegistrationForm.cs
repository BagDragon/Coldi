using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coldi
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        public string login;
        public string email;
        public string password;
        public string Repeat_password;



        string vStrConnection = "Server= localhost; port= 5432; user id= postgres; password= 93538565; database= UserBD;";

        NpgsqlCommand vCmd;
        NpgsqlConnection vCon;

        private void connection()
        {
            vCon = new NpgsqlConnection();
            vCon.ConnectionString = vStrConnection;//connect 

            if (vCon.State == ConnectionState.Closed)
            {
                vCon.Open();
            }

        }


        private void RegBTN_Click(object sender, EventArgs e)
        {
            login = loginBox.Text;
            email = emailBox.Text;
            password = PasswordBox.Text;
            Repeat_password = Repeat_PasswordBox.Text;

            if (password == Repeat_password)
            {
                try
                {
                    connection();
                    using (vCmd = new NpgsqlCommand("INSERT INTO users (login, password, email) VALUES (@login, @password, @email)", vCon))
                    {
                        // Use parameterized queries for security:
                        vCmd.Parameters.Add("@login", NpgsqlDbType.Text).Value = login;
                        vCmd.Parameters.Add("@password", NpgsqlDbType.Text).Value = Repeat_password; // Store hashed password
                        vCmd.Parameters.Add("@email", NpgsqlDbType.Text).Value = email;

                        vCmd.ExecuteNonQuery(); // Execute the INSERT query
                        MessageBox.Show("User added successfully!");

                        vCon.Close();

                        this.Close();
                        Authorization authorization = new Authorization();
                        authorization.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No connection");

                }
            }


        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            LinearGradientBrush gradientBrush = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(20, 20, 20), Color.FromArgb(120, 0, 0), LinearGradientMode.Vertical);

            // Fill the form's background with the gradient brush
            this.Paint += (sender, e) =>
            {
                e.Graphics.FillRectangle(gradientBrush, this.ClientRectangle);
            };
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            Authorization auth = new Authorization();
            auth.Show();
        }
    }
}
