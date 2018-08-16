//Created By Robert Bryant
//
//Handles the singletons and windows form application
using System;
using System.Windows.Forms;

namespace GamesDatabaseApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(FormProvider.LogIn);
        }       
    }

   

    //For showing and hiding individual forms.
    public class FormProvider
    {
        //Log In Form singleton
        public static LogInForm LogIn
        {
            get
            {
                if (_logIn == null)
                {
                    _logIn = new LogInForm();
                }
                return _logIn;
            }
        }
        private static LogInForm _logIn;

        //Directory Form singleton
        public static DirectoryForm Directoy
        {
            get
            {
                if (_directory == null)
                {
                    _directory = new DirectoryForm();
                }
                return _directory;
            }
        }
        private static DirectoryForm _directory;

        //Games Database singleton
        public static GamesDatabaseForm GamesDatabase
        {
            get
            {
                if(_gamesDatabase == null)
                {
                    _gamesDatabase = new GamesDatabaseForm();
                }
                return _gamesDatabase;
            }
        }
        private static GamesDatabaseForm _gamesDatabase;

        //Random Game Form singleton
        public static RandomGameForm RandomGame
        {
            get
            {
                if(_randomGame == null)
                {
                    _randomGame = new RandomGameForm();
                }
                return _randomGame;
            }
        }
        private static RandomGameForm _randomGame;

        //Pie Chart Form singleton
        public static PieChartForm PieChart
        {
            get
            {
                if(_pieChart == null)
                {
                    _pieChart = new PieChartForm();
                }
                return _pieChart;
            }
        }
        private static PieChartForm _pieChart;
    }
}
