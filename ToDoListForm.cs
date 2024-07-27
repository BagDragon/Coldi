using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coldi
{
    public partial class ToDoListForm : Form
    {
        public ToDoListForm()
        {
            InitializeComponent();
        }


        public string task;
        public string SelectTask;

        string vStrConnection = "Server= localhost; port= 5432; user id= postgres; password= 93538565; database= todolistdb;";

        NpgsqlCommand vCmd;
        NpgsqlConnection vCon;



        private void addBTN_Click(object sender, EventArgs e)
        {
            task = WriteTaskTextBox.Text;
            try
            {
                connection();
                using (vCmd = new NpgsqlCommand("INSERT INTO tasktodo(task) VALUES (@task)", vCon))
                {
                    vCmd.Parameters.Add("@task", NpgsqlDbType.Text).Value = task;

                    vCmd.ExecuteNonQuery(); // Execute the INSERT query

                    vCon.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            executionListBox.Items.Clear();
            EXElistLoad();
            tasksListBox.Items.Clear();
            listLoad();

        }

        private void ToDoListForm_Load(object sender, EventArgs e)
        {
            listLoad();
            EXElistLoad();

        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {

            task = tasksListBox.SelectedItem.ToString();
            try
            {
                connection();
                using (vCmd = new NpgsqlCommand("DELETE FROM tasktodo WHERE task = @task", vCon))
                {
                    vCmd.Parameters.Add("@task", NpgsqlDbType.Text).Value = task;

                    vCmd.ExecuteNonQuery(); // Execute the INSERT query

                    vCon.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            executionListBox.Items.Clear();
            EXElistLoad();
            tasksListBox.Items.Clear();
            listLoad();
        }

        private void СhangeBTN_Click(object sender, EventArgs e)
        {
            
            ChangeBox.Visible = true;

            bool doblecl= false;

            if (doblecl == false)
            {
                if (ChangeBox.Text != "")
                {
                    task = ChangeBox.Text;
                    SelectTask = tasksListBox.SelectedItem.ToString();
                    try
                    {
                        connection();
                        using (vCmd = new NpgsqlCommand("Update tasktodo set task = @task Where task = @seltask", vCon))
                        {
                            vCmd.Parameters.Add("@task", NpgsqlDbType.Text).Value = task;
                            vCmd.Parameters.Add("@seltask", NpgsqlDbType.Text).Value = SelectTask;

                            vCmd.ExecuteNonQuery(); // Execute the INSERT query

                            vCon.Close();

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    ChangeBox.Visible = false;
                    executionListBox.Items.Clear();
                    EXElistLoad();
                    tasksListBox.Items.Clear();
                    listLoad();
                   

                }
                doblecl = true;
            }
            if (doblecl)
            {
                ChangeBox.Text = "";
            }
               
        }



        private void CloseBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void listLoad()
        {

            try
            {
                connection();
                using (vCmd = new NpgsqlCommand("SELECT task FROM tasktodo", vCon))
                {
                    using (NpgsqlDataReader reader = vCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            tasksListBox.Items.Add(Text = reader["task"].ToString());

                        }
                    }
                }
                vCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      
        private void executionBTN_Click(object sender, EventArgs e)
        {
            executionCheck();
        }

        private void executionCheck()
        {
            
            SelectTask = tasksListBox.SelectedItem.ToString();

            try
            {
                connection();
                using (vCmd = new NpgsqlCommand("Update tasktodo set executiontask = 'Выполнено' Where task = @seltask", vCon))
                {
                    vCmd.Parameters.Add("@seltask", NpgsqlDbType.Text).Value = SelectTask;
                   

                    vCmd.ExecuteNonQuery(); // Execute the INSERT query

                    vCon.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            tasksListBox.Items.Clear();
            executionListBox.Items.Clear();
            EXElistLoad();
            listLoad();
        }

        private void EXElistLoad()
        {

            try
            {
                connection();
                using (vCmd = new NpgsqlCommand("SELECT executiontask FROM tasktodo", vCon))
                {
                    using (NpgsqlDataReader reader = vCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            executionListBox.Items.Add(Text = reader["executiontask"].ToString());

                        }
                    }
                }
                vCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void connection()
        {
            vCon = new NpgsqlConnection();
            vCon.ConnectionString = vStrConnection;//connect 

            if (vCon.State == ConnectionState.Closed)
            {
                vCon.Open();
            }
        }
    }
}
