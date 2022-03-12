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
using System.Security.Cryptography;

using Password_Bank.Utils;

namespace Password_Bank.Components
{
    public partial class SignupWindow : Form
    {
        private string MasterPassword { get; set; }
        private string ConfirmPassword { get; set; }

        public SignupWindow()
        {
            InitializeComponent();
        }

        private void BtnSignUpClick(object sender, EventArgs e)
        {
            // Check to see if passwords match, then redirect the user to the password list.
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                // Encrypt the Master Password and store it in the application's local directory.
                StreamWriter writer = new StreamWriter("master_password.txt");
                string masterPass = PasswordHasher.GetHashString(txtPassword.Text);
                writer.Write(masterPass, true);
                writer.Close();

                // Redirect the user to the list of passwords.
                PassList pList = new PassList();
                pList.ShowDialog();
                this.Hide();
            }
            else
            {
                string errorDialog = "Passwords don't match! Please ensure you typed your passwords correctly and try again!";
                string errorTitle = "Signup Error";
                MessageBox.Show(errorDialog, errorTitle);
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

        // Same with this component.
        private void TxtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            ConfirmPassword = txtConfirmPassword.Text;
            string asterisks = "";

            foreach (char c in ConfirmPassword)
            {
                asterisks += "*";
            }

            txtConfirmPassword.Text = asterisks;
            txtConfirmPassword.Select(txtConfirmPassword.Text.Length, 0); // move cursor to the end of the string
        }
    }
}
