//Created by Robert Bryant
//
//Menu form that allows the user to navigate to other forms.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamesDatabaseApplication
{
    public partial class DirectoryForm : Form
    {
        public DirectoryForm()
        { 
            InitializeComponent();
        }


        //Returns the user to the log in form
        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Hide();
            FormProvider.LogIn.Show();            
        }

        //Shows a form that allows users to edit a database of owned games
        private void GamesDatabaseButton_Click(object sender, EventArgs e)
        {
            Hide();
            FormProvider.GamesDatabase.ShowDialog();
        }

        //Shows a form that selects random games from the user's collection.
        private void RandomGameButton_Click(object sender, EventArgs e)
        {
            Hide();
            FormProvider.RandomGame.ShowDialog();
        }

        //Shows the pie chart form
        private void PieChartButton_Click(object sender, EventArgs e)
        {
            Hide();
            FormProvider.PieChart.ShowDialog();
        }

        //Show the log in form when the directory form is closed
        private void DirectoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormProvider.LogIn.Show();
        }
    }
}
