using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coldi
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();

        }

        public string login;
        public string password;

        StartForm startForm = new StartForm();
        

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
       
        private void Log_in_Click(object sender, EventArgs e)
        {
            login = loginBox.Text;
            password = passwordBox.Text;

            int rowsCount = 0;


            connection();

            using (vCmd = new NpgsqlCommand("SELECT COUNT(*) FROM users WHERE login = @login AND password = @pass", vCon))
            {
                vCmd.Parameters.Add("@login", NpgsqlDbType.Text).Value = login;
                vCmd.Parameters.Add("@pass", NpgsqlDbType.Text).Value = password;

                // Execute the command and get the result
                using (NpgsqlDataReader reader = vCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        rowsCount = Convert.ToInt32(reader[0]); // Get the count from the reader
                    }
                }

                if (rowsCount > 0)
                {
                    MessageBox.Show("there is an account");
                        //connect form
                   // ModeSelection modeSelection = new ModeSelection(login);
                   // modeSelection.Show();

                    
                }
                else
                {
                    MessageBox.Show("Пользователь не найден");
                }
            }

            // Close the connection after the operation
            vCon.Close();
            startForm.Close();
        }

        private void unregistered_Click(object sender, EventArgs e)
        {
            startForm.Close();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            LinearGradientBrush gradientBrush = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(20, 20, 20), Color.FromArgb(120, 0, 0), LinearGradientMode.Vertical);

            // Fill the form's background with the gradient brush
            this.Paint += (sender, e) =>
            {
                e.Graphics.FillRectangle(gradientBrush, this.ClientRectangle);
            };
        }
    }
}
