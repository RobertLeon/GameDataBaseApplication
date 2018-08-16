//Created by Robert Bryant
//
//Connection class for the SQL Database
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GamesDatabaseApplication
{
    class DatabaseConnection
    {
        static SqlConnection sqlConnection;           //SQL connection
        public static bool connOpen = false;          //Is the connection open?
        static string serverName = "Server";          //These variables need to be changed based
        static string dataBase = "Database";          //on the server and database that are being connected to.
        public static string connectionString;        //Connection string for SQL

        public static SqlConnection SQLConnect(string userName, string userPass)
        {
            //Connection string for the server
            connectionString = "Server=" + serverName + ";" +                
                "Database=" + dataBase + ";" +
                "User ID=" + userName + ";" +
                "Password=" + userPass + ";";

            //Attempt to connect ot the SQL Database
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    //Open the connection
                    sqlConnection.Open();

                    //If the connection is open
                    if (sqlConnection.State == ConnectionState.Open)
                    {
                        connOpen = true;
                    }
                    else
                    {
                        connOpen = false;
                    }

                    return sqlConnection;
                }
                catch (SqlException ex)
                {
                    //Display the error in a message box
                    MessageBox.Show("Error Number: " + ex.Number.ToString() +
                        "\n"+ "Error Details: " + ex.ToString());

                    return null;
                }
            }
        }
    }
}
