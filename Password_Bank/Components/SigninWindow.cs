using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

using Password_Bank.Utils;

namespace Password_Bank.Components
{
    public partial class SigninWindow : Form
    {
        private string MasterPassword { get; set; }

        public SigninWindow()
        {
            InitializeComponent();
        }

        private void BtnSignInClick(object sender, EventArgs e)
        {
            try
            {
                // Set up variables
                StreamReader reader = new StreamReader("master_password.txt");
                string encryptedPass = reader.ReadLine();
                string encryptedInput = PasswordHasher.GetHashString(MasterPassword);

                // Check to see if passwords match. If so, direct user to the password list. Otherwise, 
                // prompt them to try again.
                if (encryptedPass == encryptedInput)
                {
                    PassList pList = new PassList();
                    pList.ShowDialog();
                    this.Hide();
                }
                else
                {
                    string errorDialog = "That password was incorrect! Please make sure you typed it correctly and try again.";
                    string errorTitle = "Incorrect Password";
                    MessageBox.Show(errorDialog, errorTitle);
                }

                // Cleanup
                reader.Close();
            }
            catch (IOException exception)
            {
                // Ideally, we shouldn't get to this block of code. If we do, there is a HUGE problem
                // and it needs to be fixed NOW!!!
                string errorDialog = $"An error occurred while loading your passwords! \nError: {exception.Message}\nThe program will now close.";
                string errorTitle = "Critical Error";
                MessageBox.Show(errorDialog, errorTitle);
                Environment.Exit(1);
            }
        }

        // Get this component to behave like an HTML input field of type "password".
        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            MasterPassword = txtPassword.Text;
            string asterisks = "";

            foreach (char c in MasterPassword)
            {
                asterisks += "*";
            }

            txtPassword.Text = asterisks;
            txtPassword.Select(txtPassword.Text.Length, 0); // move cursor to the end of the string
        }
    }
}
