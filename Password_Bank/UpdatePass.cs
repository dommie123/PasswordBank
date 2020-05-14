using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Password_Bank
{
    public partial class UpdatePass : Form
    {
        public new string Name { get; set; }
        public string Company { get; set; }
        public string Password { get; set; }

        public UpdatePass()
        {
            InitializeComponent();
        }
        /**
         * Sets the above properties upon loading.
         */
        private void UpdatePass_Load(object sender, EventArgs e)
        {
            txtName.Text = Name;
            txtCompany.Text = Company;
            txtPassword.Text = Password;
        }
        /**
         * When the user clicks "Update", the password they have selected will be
         * updated with the new credentials.
         */
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string newName = txtName.Text;
            string newCompany = txtCompany.Text;
            string newPassword = txtPassword.Text;

            try
            {
                // Reads the passwords from a file and stores them into a list.
                StreamReader reader = new StreamReader("passwords.txt");
                Password selectedPassword = new Password(Password, Name, Company);
                Password newPass = new Password(newPassword, newName, newCompany);
                List<string> passwords = new List<string>();

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (line.Equals(selectedPassword.ToString())) passwords.Add(newPass.ToString());
                    else passwords.Add(line);
                }

                reader.Close();

                // The old password.txt file is deleted, then replaced with a new version with the updated password.
                File.Delete("passwords.txt");   

                StreamWriter writer = new StreamWriter("passwords.txt");
                string[] passwordsAsArray = passwords.ToArray();

                // Write passwords from the list to the file.
                for (int i = 0; i < passwords.Count; i++)
                {
                    writer.WriteLine(passwordsAsArray[i]);
                }

                writer.Close();
            } catch (IOException exception)
            {
                MessageBox.Show(exception.Message, "Cannot update password due to an error!");
            } finally
            {
                Close();
            }
        }
    }
}
