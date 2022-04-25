using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows;

namespace NewProjectAvt
{
    class Users
    {
        MySqlBaseConnectionStringBuilder ConnectionString;
        MySqlConnection connection;
        public void ConnectionUsers()
        {
            ConnectionString = new MySqlConnectionStringBuilder();
            ConnectionString.Server = "localhost";
            ConnectionString.UserID = "root";
            ConnectionString.Password = "root";
            ConnectionString.Database = "authorization";

            connection = new MySqlConnection(ConnectionString.ToString());
        }
        public int UsersLogin(string Login, string Password)
        {
            string CommandText = $"SELECT * FROM user WHERE login = '{Login}' and password ='{Password}'";
            int code = -1;
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(CommandText, connection);
                code = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            connection.Close();
            return code;
        }
        public int AddUsers(string FirstName, string LastName, string Login, string Password)
        {
            string CommandText = $"INSERT INTO user (FirstName, LastName, Login, Password) VALUES ('{FirstName}','{LastName}','{Login}','{Password}')";
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(CommandText, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Пользователь удачно добавлен!");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            return 0;
         }
    }
}

