using MySql.Data.MySqlClient;
using System.Data;

namespace Airline.core.AirlineRepository
{
    class Connection
    {
        /// <summary>
        /// Opens a new database connection using the connection string from the environment variable.
        /// </summary>
        /// <returns>An open MySqlConnection instance.</returns>
        internal MySqlConnection OpenConnection()
        {
            string connectionString = Environment.GetEnvironmentVariable("EAFIT_DB_CONNECTION");
            if (string.IsNullOrEmpty(connectionString))
                throw new InvalidOperationException("Environment variable 'EAFIT_DB_CONNECTION' is not set.");

            var connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        /// <summary>
        /// Closes the given database connection if it is not already closed.
        /// </summary>
        /// <param name="connection">The MySqlConnection to close.</param>
        internal void CloseConnection(MySqlConnection connection)
        {
            if (connection.State != ConnectionState.Closed)
                connection.Close();
        }
    }
}