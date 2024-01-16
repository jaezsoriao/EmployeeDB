using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    public class DatabaseManager
    {
        public static MySqlConnection connection;
        public DatabaseManager()
        {
            string connectionString = "server=localhost;user=root;database=employee;port=3306;password=password";
            connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
            }
            catch (Exception e)
            {

            }
        }
    }
}
