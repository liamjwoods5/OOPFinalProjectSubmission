using
/* Unmerged change from project 'FinalProjectIOOP (net8.0-android)'
Before:
using System;
After:
using MySqlConnector;
using System;
*/

/* Unmerged change from project 'FinalProjectIOOP (net8.0-ios)'
Before:
using System;
After:
using MySqlConnector;
using System;
*/

/* Unmerged change from project 'FinalProjectIOOP (net8.0-maccatalyst)'
Before:
using System;
After:
using MySqlConnector;
using System;
*/

/* Unmerged change from project 'FinalProjectIOOP (net8.0-android)'
Before:
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
After:
using System.Diagnostics;
using System.Linq;
using System.Text;
*/

/* Unmerged change from project 'FinalProjectIOOP (net8.0-ios)'
Before:
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
After:
using System.Diagnostics;
using System.Linq;
using System.Text;
*/

/* Unmerged change from project 'FinalProjectIOOP (net8.0-maccatalyst)'
Before:
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
After:
using System.Diagnostics;
using System.Linq;
using System.Text;
*/
MySqlConnector;
using System.Diagnostics;

namespace FinalProjectIOOP
{
    public class DatabaseConnection
    {

        //Database Accessor
        protected MySqlConnection connection;

        public DatabaseConnection()
        {
            // get environment variable
            string dbHost = Environment.GetEnvironmentVariable("DB_HOST");
            string dbUser = Environment.GetEnvironmentVariable("DB_USER");
            string dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");

            var builder = new MySqlConnectionStringBuilder
            {
                Server = "192.168.250.52",
                UserID = "root",
                Password = "1234",
                Database = "gym_system",
            };

            connection = new MySqlConnection(builder.ConnectionString);

            try
            {
                connection.Open();
                Debug.WriteLine("Connection successful!");
                connection.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Connection failed: {ex.Message}");
            }
        }
    }

}
