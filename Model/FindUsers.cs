using Coldi.Controls;
using Npgsql;
using NpgsqlTypes;

namespace Coldi.Model
{
    static class FindUsers
    {
        public static void findUser(string login, string password)
        {
            StartForm startForm = new StartForm();
            bool userFound = false;

            NpgsqlConnection vCon = ConnectDB.connection();
            NpgsqlCommand vCmd;

            using (vCmd = new NpgsqlCommand("SELECT password FROM users WHERE login = @login", vCon))
            {
                vCmd.Parameters.Add("@login", NpgsqlDbType.Text).Value = login;
                // vCmd.Parameters.Add("@pass", NpgsqlDbType.Text).Value = password;

                // Execute the command and get the result
                using (NpgsqlDataReader reader = vCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        userFound = true;
                        //rowsCount = Convert.ToInt32(reader[0]);
                        string storedHash = reader.GetString(0);

                        if (VerifyPasswordHash(password, storedHash))
                        {

                            MessageBox.Show($"Welcome {login}");
                            //connect form
                            ModeSelection modeSelection = new ModeSelection(login);
                            modeSelection.Show();
                            //this.Close();                                                   
                        }
                        else
                        {
                            MessageBox.Show("Неверный пароль");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден");
                    }


                }
            }


            vCon.Close();
            startForm.Close();
        }

        private static bool VerifyPasswordHash(string password, string storedHash)
        {
            // Используется bcrypt
            var algorithm = new BCrypt.Net.BCrypt();
            return BCrypt.Net.BCrypt.Verify(password, storedHash);

        }
    }


}
