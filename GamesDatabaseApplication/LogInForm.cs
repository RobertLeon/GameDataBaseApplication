//Created By Robert Bryant
//
//Log in form to certify access to the SQL Database and other windows forms.
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
    public partial class LogInForm : Form
    {

        public static string user;          //Username
        public static string pass;          //Password
       
        public LogInForm()
        {
            InitializeComponent();
        }

        //Logs the user into the database then shows the main menu.
        private void logInButton_Click(object sender, EventArgs e)
        {
            user = userNameTxtBox.Text;
            pass = passwordTxtBox.Text;

            //Check for user input
            if (String.IsNullOrWhiteSpace(user) || String.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Please enter a user name and password.");
                ResetTextBoxes();
            }
            else
            {   
                //Attempts to connect to the database.
                DatabaseConnection.SQLConnect(user, pass);

                //Hide this form if the connection is made
                if(DatabaseConnection.connOpen)
                {
                    Hide();
                    FormProvider.Directoy.ShowDialog();
                    ResetTextBoxes();
                }
                //Show an error
                else
                {
                    MessageBox.Show("Something unexpeted happened.");
                    Application.Exit();
                }
            }
        }

        //Exits the application
        private void exitButton_Click(object sender, EventArgs e)
        {
            //Strings for the message box.
            string message, caption;

            message = "Are you sure you want to exit?";
            caption = "Exit Application";
            
            //Show a message box to confirm the uder wants to exit the application.
            if(MessageBox.Show(message, caption, MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                ResetTextBoxes();                
            }
            
        }

        //Resets the text fields to empty.
        void ResetTextBoxes()
        {
                userNameTxtBox.Text = "";
                passwordTxtBox.Text = "";
        }

        //Shows the password when checked
        private void showPasswordChkBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTxtBox.PasswordChar = showPasswordChkBox.Checked ? '\0' : '*';
        }
    }

   
    
}
