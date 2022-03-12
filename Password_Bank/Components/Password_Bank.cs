using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private void Button1_Click(object sender, EventArgs e)
        {
            PassList pList = new PassList();
            pList.ShowDialog();
            Close();
        }
    }
}
