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

namespace Password_Bank
{
    public partial class Password_Bank : Form
    {
        public Password_Bank()
        {
            InitializeComponent();
        }

        /**
         * Once the user clicks "Sign in", a list of passwords will be displayed (unless said list
         * is empty). 
         */
        private void BtnSigninClick(object sender, EventArgs e)
        {
            // Check to see if the user has created a master password. The window
            // they are directed to depends on this condition.
            try
            {
                // This just checks to see if the file exists.
                StreamReader reader = new StreamReader("master_password.txt");  
                reader.Close();

                // If we get to this point, we know the file exists.
                Components.SigninWindow signin = new Components.SigninWindow();
                signin.ShowDialog();

            }
            catch (IOException)
            {
                // If we get to this point, we know the file doesn't exist.
                Components.SignupWindow signup = new Components.SignupWindow();
                signup.ShowDialog();
            }
        }
    }
}
