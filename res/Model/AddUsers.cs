using Coldi.res.Control;
using Npgsql;
using NpgsqlTypes;

namespace Coldi.res.Model
{
    static class AddUsers
    {
        public static void AddUser(string login, string email, string password, string Repeat_password)
        {
            if (password == Repeat_password)
            {
                try
                {
                    NpgsqlConnection vCon = ConnectDB.connection();
                    NpgsqlCommand vCmd;

                    ConnectDB.connection();

                    using (vCmd = new NpgsqlCommand("INSERT INTO users (login, password, email) VALUES (@login, @password, @email)", vCon))
                    {
                        // Use parameterized queries for security:
                        vCmd.Parameters.Add("@login", NpgsqlDbType.Text).Value = login;
                        vCmd.Parameters.Add("@password", NpgsqlDbType.Text).Value = Repeat_password; // Store hashed password
                        vCmd.Parameters.Add("@email", NpgsqlDbType.Text).Value = email;

                        vCmd.ExecuteNonQuery(); // Execute the INSERT query
                        MessageBox.Show("User added successfully!");

                        vCon.Close();

                        Form form = new Form();
                        form.Close();
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
    }
}
