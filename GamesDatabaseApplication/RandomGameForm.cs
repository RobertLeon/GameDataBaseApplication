//Created by Robert Bryant
//
//Shows a random amount of games based on the user's input.
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GamesDatabaseApplication
{
    public partial class RandomGameForm : Form
    {
        SqlConnection sqlConnection;
        string connString;
        string query;

        public RandomGameForm()
        {
            InitializeComponent();
            sqlConnection = DatabaseConnection.SQLConnect(LogInForm.user, LogInForm.pass);
            connString = DatabaseConnection.connectionString;
        }

        //Main menu button
        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Hide();
            FormProvider.Directoy.Show();
        }

        //Show random number of games based on user input.
        private void RandomGameButton_Click(object sender, EventArgs e)
        {
            if (numberGamesComboBox.SelectedIndex != -1)
            {
                //The number of games selected as an integer
                int numGames = int.Parse(numberGamesComboBox.SelectedItem.ToString());
                            
                //All parameters have input
                if (platformComboBox.SelectedIndex != -1 && completionComboBox.SelectedIndex != -1)
                {
                    ShowRandomGames(numGames, platformComboBox.SelectedItem.ToString(), completionComboBox.SelectedItem.ToString());
                    ResetInput();
                }
                //If only the platform and number of games are the input
                else if (platformComboBox.SelectedIndex != -1 && completionComboBox.SelectedIndex == -1)
                {
                    ShowRandomGames(numGames, platformComboBox.SelectedItem.ToString());
                    ResetInput();
                }
                //If the completion and number of games are the input given
                else if (completionComboBox.SelectedIndex != -1 && platformComboBox.SelectedIndex == -1)
                {
                    ShowRandomGames(numGames, completionComboBox.SelectedItem.ToString());
                    ResetInput();
                }
                //Only the number of games is selected
                else
                {
                    ShowRandomGames(numGames);
                    ResetInput();
                }
            }
            else
            {
                //Message box to show the user needs to select a number of games.
                MessageBox.Show("Please select the number of random games you wish to select.");
            }
        }

        //Sets the combo boxes to empty on clicking the button
        private void ResetComboBoxesButton_Click(object sender, EventArgs e)
        {
            ResetInput();
        }

        //Shows random list of games specified by the user with all three inputs
        private void ShowRandomGames(int numGames, string platform, string completion)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            try
            {
                //SQL Query
                query = "SELECT TOP (@GamesNum) * FROM GameCollection " +
                    "WHERE (GamePlatform=@Platform AND GameCompletion=@Completion)" + 
                    "ORDER BY NEWID()";

                //SQL Connection
                sqlConnection = new SqlConnection(connString);
                sqlConnection.Open();


                DataTable table = new DataTable();

                //SQL Command and parameters
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@GamesNum", numGames);
                command.Parameters.AddWithValue("@Platform", platform);
                command.Parameters.AddWithValue("@Completion", completion);
                dataAdapter.SelectCommand = command;

                //Execute the command and show results on the table
                command.ExecuteNonQuery();
                bindingSource1.DataSource = table;
                dataAdapter.Fill(table);
                gameView.DataSource = bindingSource1;
                
                //Close Connection
                sqlConnection.Close();
            }
            //Show an error if the query fails
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Shows random games with two of the tree inputs
        private void ShowRandomGames(int numGames, string condition)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            //If the platform was the input used
            if(platformComboBox.SelectedIndex != -1)
            {
                try
                {
                    //SQL Query
                    query = "SELECT TOP (@GamesNum) * FROM GameCollection " +
                        "WHERE GamePlatform=@Platform " +
                        "ORDER BY NEWID()";

                    //SQL Connection
                    sqlConnection = new SqlConnection(connString);
                    sqlConnection.Open();


                    DataTable table = new DataTable();

                    //SQL Command and parameters
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    command.Parameters.AddWithValue("@GamesNum", numGames);
                    command.Parameters.AddWithValue("@Platform", condition);
                    dataAdapter.SelectCommand = command;

                    //Execute the command and shows the results
                    command.ExecuteNonQuery();
                    bindingSource1.DataSource = table;
                    dataAdapter.Fill(table);
                    gameView.DataSource = bindingSource1;
                    
                    //Close the connection
                    sqlConnection.Close();
                }
                //Show an error if the query fails
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            //Completion was the input
            else
            {
                try
                {
                    //SQL Query
                    query = "SELECT TOP (@GamesNum) * FROM GameCollection " +
                        "WHERE GameCompletion=@Completion " +
                        "ORDER BY NEWID()";

                    //SQL Connection
                    sqlConnection = new SqlConnection(connString);
                    sqlConnection.Open();


                    DataTable table = new DataTable();

                    //SQL Command and parameters
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    command.Parameters.AddWithValue("@GamesNum", numGames);                    
                    command.Parameters.AddWithValue("@Completion", condition);
                    dataAdapter.SelectCommand = command;

                    //Execute the command and show the results
                    command.ExecuteNonQuery();
                    bindingSource1.DataSource = table;
                    dataAdapter.Fill(table);
                    gameView.DataSource = bindingSource1;

                    //Close the Connection
                    sqlConnection.Close();
                }
                //Show an error if the quety fails
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        //Shows random games with only the number of games as input
        private void ShowRandomGames(int numGames)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

           try
            {
                //SQL Query
                query = "SELECT TOP (@GamesNum) * FROM GameCollection ORDER BY NEWID()";

                //SQL Connection
                sqlConnection = new SqlConnection(connString);
                sqlConnection.Open();

                DataTable table = new DataTable();

                //SQL Command
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@GamesNum", numGames);
                dataAdapter.SelectCommand = command;

                command.ExecuteNonQuery();

                bindingSource1.DataSource = table;
                dataAdapter.Fill(table);
                gameView.DataSource = bindingSource1;

                //Closes the connection
                sqlConnection.Close();
            }
            //Show an error if the query fails
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Clears the input fields
        private void ResetInput()
        {
            platformComboBox.SelectedIndex = -1;
            completionComboBox.SelectedIndex = -1;
            numberGamesComboBox.SelectedIndex = -1;
        }

        //Shows the directory form if this form was closed
        private void RandomGameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormProvider.Directoy.Show();
        }
    }
}
