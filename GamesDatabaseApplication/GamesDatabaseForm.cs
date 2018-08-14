//Created by Robert Bryant
//
//Allows the user to add, remove, and edit a list of games to a table in a SQL Database.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GamesDatabaseApplication
{
    public partial class GamesDatabaseForm : Form
    {
        SqlConnection sqlConnection;        //SQL connection
        string connString;                  //SQL connection string
        string query;                       //SQL query

        public GamesDatabaseForm()
        {
            sqlConnection = DatabaseConnection.SQLConnect(LogInForm.user, LogInForm.pass);
            connString = DatabaseConnection.connectionString;
            InitializeComponent();
        }

        //Shows the database in the data grid.
        private void ShowTable()
        {
            try
            {
                //SQL SELECT query
                query = "SELECT * FROM GameCollection";

                DataTable table = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connString);
                bindingSource1.DataSource = table;
                dataAdapter.Fill(table);
                gamesDataView.DataSource = bindingSource1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Inserts an item into the database.
        private void InsertDB()
        {
            //SQL INSERT query
            query = "INSERT INTO GameCollection(GameName,GamePlatform,GameCompletion) " +
                "VALUES (@GameName,@GamePlatform,@GameCompletion)";
            try
            {
                //Creates and opens a new SQL Connection
                sqlConnection = new SqlConnection(connString);
                sqlConnection.Open();

                //Creates the command and adds parameters.
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@GameName", gameNameTextBox.Text);
                command.Parameters.AddWithValue("@GamePlatform", platformComboBox.SelectedItem.ToString());
                command.Parameters.AddWithValue("@GameCompletion", completionComboBox.SelectedItem.ToString());

                //Executes the command then closes the connection.
                command.ExecuteNonQuery();
                sqlConnection.Close();                
            }
            catch (SqlException ex)
            {
                //Generic Error Handling.
                MessageBox.Show(ex.ToString());            
            }
        }

        //Changes an item already in the database.
        private void UpdateDB()
        {
            //SQL UPDATE Query
            query = "UPDATE GameCollection " +
                "SET GamePlatform = @GamePlatform, GameCompletion = @GameCompletion " +
                "WHERE (GameName = @GameName)";
            try
            {
                //Creates and opens a new SQL Connection
                sqlConnection = new SqlConnection(connString);
                sqlConnection.Open();

                //Creates the UPDATE command and adds parameters.
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@GameName", gameNameTextBox.Text);
                command.Parameters.AddWithValue("@GamePlatform", platformComboBox.SelectedItem.ToString());
                command.Parameters.AddWithValue("@GameCompletion", completionComboBox.SelectedItem.ToString());

                //Execute and then close the connection
                command.ExecuteNonQuery();
                sqlConnection.Close();

            }
            catch (SqlException ex)
            {
                //Generic Error Handling
                MessageBox.Show(ex.ToString());

            }
        }

        //Removes an item from the database.
        private void DeleteDB()
        {
            //SQL DELETE query
            query = "DELETE FROM GameCollection WHERE GameName=@GameName";

            try
            {
                //Create and open a new SQL Connection
                sqlConnection = new SqlConnection(connString);
                sqlConnection.Open();

                //Create the DELETE command and adds parameters
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@GameName", gameNameTextBox.Text);

                //Executes the command and closes the connection
                command.ExecuteNonQuery();
                sqlConnection.Close();

               
            }
            catch (SqlException ex)
            {
                //Generic Error Handling
                MessageBox.Show(ex.ToString());
            }
        }

        //Resets the user input fields to empty.
        private void ResetInput()
        {
            //Makes the text box and combo boxes show no input.
            gameNameTextBox.Text = "";
            platformComboBox.SelectedIndex = -1;
            completionComboBox.SelectedIndex = -1;
        }

        //Fill the table on the form being loaded.
        private void GamesDatabaseForm_Load(object sender, EventArgs e)
        {
            ShowTable();
        }

        //Loads the table again and resets input.
        private void refreshDatabase_Click(object sender, EventArgs e)
        {
            ShowTable();
            ResetInput();
        }

        //Hides the current form and shows the Directory Form.
        private void directoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.Directoy.Show();
        }

        //Adds a game to the table then resets input.
        private void addGameButton_Click(object sender, EventArgs e)
        {
            //Check for input in the gameNameTextBoc
            if (String.IsNullOrWhiteSpace(gameNameTextBox.Text) ||
               platformComboBox.SelectedIndex == -1 ||
               completionComboBox.SelectedIndex == -1)
            {
                //Display an error to the user that input is needed in all fields.
                MessageBox.Show("Please enter the name of the game, select a platform, and completion amount, then try again.");
            }
            else
            {
                InsertDB();
                ShowTable();
                ResetInput();
            }
        }

        //Edits an item in the database then resets input.
        private void editGameButton_Click(object sender, EventArgs e)
        {
            //Check for empty input fields
            if (String.IsNullOrWhiteSpace(gameNameTextBox.Text) ||
               platformComboBox.SelectedIndex == -1 ||
               completionComboBox.SelectedIndex == -1)
            {
                //Display an error to the user that input is needed in all fields.
                MessageBox.Show("Please enter the name of the game, select a platform, and completion amount, then try again.");
            }
            else
            {
                UpdateDB();
                ShowTable();
                ResetInput();
            }
        }

        //Deletes an item from the database then resets input.
        private void removeGameButton_Click(object sender, EventArgs e)
        {
            //Check for input in the gameNameTextBoc
            if (String.IsNullOrWhiteSpace(gameNameTextBox.Text))
            {
                //Display an error to the user that input is needed in all fields.
                MessageBox.Show("Please enter the name of the game you wish to remove from the database.");
            }
            else
            {
                DeleteDB();
                ShowTable();
                ResetInput();
            }
        }
    }
}
