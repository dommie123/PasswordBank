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
    public partial class NewPass : Form
    {
        public NewPass()
        {
            InitializeComponent();
        }
        /**
         * When the user clicks "Create", they save the password to a file within the computer.
         */
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string website = txtWebsite.Text;
            string password = txtPassword.Text;

            Password newPass = new Password(password, name, website);

            // The following code saves the password to a file.
            try
            {
                StreamWriter writer = new StreamWriter("passwords.txt", true);
                writer.WriteLine(newPass);
                writer.Close();
            } catch(IOException exception)
            {
                Console.WriteLine(exception.Message);
            }

            Close();
        }
    }
}
