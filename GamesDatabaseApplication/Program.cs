//Created By Robert Bryant
//
//Handles the singletons and eindows form application
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        //Log in form singleton
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

        //Directory form singleton
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

        //Random game form singleton
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
    }
}
