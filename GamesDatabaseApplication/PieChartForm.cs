//Created by Robert Bryant
//
//Shows information from the database in pie charts.
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;

namespace GamesDatabaseApplication
{
    public partial class PieChartForm : Form
    {
        private SqlConnection sqlConn;          //SQL connection
        private string connString;              //SQL connection string
        private string query;                   //SQL query
        private List<int> chartValues;          //Values used for the charts information

        public PieChartForm()
        {
            //Get the database connection
            sqlConn = DatabaseConnection.SQLConnect(LogInForm.user, LogInForm.pass);
            connString = DatabaseConnection.connectionString;
            chartValues = new List<int>();

            InitializeComponent();
        }
        
        private void PieChartForm_Load(object sender, EventArgs e)
        {
            //Show the completion values pie chart on loading the form
            GetCompletionValues();
        }

        //Hides the current form and shows the Directory form
        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            FormProvider.Directoy.Show();
        }

        //Shows the pie chart for games completed
        private void Completion_Click(object sender, EventArgs e)
        {
            GetCompletionValues();
        }

        //
        private void GetCompletionValues()
        {
            //List of completion states in the database
            List<string> completion = new List<string>(new string[]
                           { "'Unplayed'", "'Played'", "'Finished'","'Completed'" } );
            chartValues = new List<int>();

            //Try to connect to the database
            try
            {
                using (sqlConn)
                {
                    sqlConn.ConnectionString = connString;
                    sqlConn.Open();

                    //Loop through each completion type for the chart values
                    for (int i = 0; i < completion.Count; i++)
                    {
                        query = "SELECT COUNT(*) FROM GameCollection WHERE GameCompletion = " + completion[i] + ";";
                        SqlCommand command = new SqlCommand(query, sqlConn);
                        SqlDataReader reader = command.ExecuteReader();

                        //Add the chart values
                        if (reader.HasRows)
                        {
                            reader.Read();
                            chartValues.Add(reader.GetInt32(0));
                        }
                        reader.Close();
                    }
                    sqlConn.Close();
                }

                //Remove the single quotes from each string to make it look better on the pie chart
                List<string> complete = new List<string>();

                foreach(string s in completion)
                {
                    complete.Add(s.Replace("'", null));
                }

                //Draw the pie chart
                DrawPieChart(chartValues, complete, "Completion");
            }
            //Display an error if it fails to connect
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        //Draws the pie chart
        private void DrawPieChart(List<int> values, List<string> data, string legend)
        {
            //Clear the charts series and legends
            chart1.Series.Clear();
            chart1.Legends.Clear();

            //Add a new legend and 
            chart1.Legends.Add(new Legend(legend));
            chart1.Legends[legend].LegendStyle = LegendStyle.Table;
            chart1.Legends[legend].Docking = Docking.Right;
            chart1.Legends[legend].Title = legend;           
            chart1.Legends[legend].Alignment = StringAlignment.Center;

            //Add a new series and set the chart type to pie chart
            chart1.Series.Add(legend);
            chart1.Series[legend].ChartType = SeriesChartType.Pie;

            //Loop through each point of data
            for (int i = 0; i < data.Count; i++)
            {
                //Check if the value is greater than 0 and then add it to the chart
                if (values[i] > 0)
                {
                    chart1.Series[legend].Points.AddXY(data[i] + ": " + values[i], values[i]);
                }
            }
        }

        //Show the data for how many games are owned on each platform
        private void Platform_Click(object sender, EventArgs e)
        {
            GetPlatformValues();
        }

        //Gets thenumber of games owned on each platform in the database
        private void GetPlatformValues()
        {
            //List of game platforms and consoles
            List<string> platforms = new List<string>(new string[] {
                "'Atari 2600'", "'Sega Master System'","'Nintendo Entertainment System'",
                "'Commodore 64'","'TurboGrafx-16'","'Sega Genesis'","'Neo-Geo'","'Super Nintendo'",
                "'CD-i'","'Sega 32X'","'Atari Jaguar'","'PlayStation'","'Sega Saturn'","'3DO'",
                "'Nintendo 64'","'Amiga CD32'","'Dreamcast'","'PlayStation 2'","'GameCube'","'Xbox'",
                "'Xbox360'","'PlayStation 3'","'Wii'","'Wii U'","'Playstation 4'","'Xbox One'",
                "'Steam (PC)'","'Origin (PC)'","'Uplay (PC)'"});
            chartValues = new List<int>();

            //try to connect to the database
            try
            {
                using (sqlConn)
                {
                    sqlConn.ConnectionString = connString;
                    sqlConn.Open();

                    //Loop through each platform for the chart values
                    for (int i = 0; i < platforms.Count; i++)
                    {
                        query = "SELECT COUNT(*) FROM GameCollection WHERE GamePlatform = " + platforms[i] + ";";
                        SqlCommand command = new SqlCommand(query, sqlConn);
                        SqlDataReader reader = command.ExecuteReader();

                        //Add the chart values
                        if (reader.HasRows)
                        {
                            reader.Read();
                            chartValues.Add(reader.GetInt32(0));
                        }
                        reader.Close();
                    }
                    sqlConn.Close();
                }

                //Remove the single quotes from each string to make it look better on the pie chart
                List<string> platform = new List<string>();

                foreach(string s in platforms)
                {
                    platform.Add(s.Replace("'", null));
                }

                //Draw the pie chart
                DrawPieChart(chartValues, platform, "Platforms");
            }
            //Display an error if it fails to connect
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        //Show the directory form if the user closes the form
        private void PieChartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormProvider.Directoy.Show();
        }
    }
    
}
