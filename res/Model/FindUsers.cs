﻿using Coldi.res.Control;
using Microsoft.VisualBasic.Logging;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coldi.res.Model
{
    static class FindUsers
    {
        public static void findUser(string login, string password)
        {
            StartForm startForm = new StartForm();
            int rowsCount = 0;

            NpgsqlConnection vCon = ConnectDB.connection();
            NpgsqlCommand vCmd;

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
                    MessageBox.Show($"Welcome {login}");
                    //connect form
                    ModeSelection modeSelection = new ModeSelection(login);
                    modeSelection.Show();
                    //this.Close();

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
    }
}