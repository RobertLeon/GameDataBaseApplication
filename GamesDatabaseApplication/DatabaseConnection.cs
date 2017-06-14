//Created by Robert Bryant
//
//Connection class for the SQL Database
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GamesDatabaseApplication
{
    class DatabaseConnection
    {
        static SqlConnection sqlConnection;
        public static bool connOpen = false;
        static string serverName = "Server Name";     //These variables need to be changed based
        static string dataBase = "DataBase";          //on the server and database that are being connected to.
        public static string connectionString;

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
                        "\n"+ "Error Details: " +ex.ToString());

                    return null;
                }
            }
        }
    }
}
