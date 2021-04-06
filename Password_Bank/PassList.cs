using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Bank
{
    public partial class PassList : Form
    {
        private bool passIsHidden = true;   // Is the password "hidden"?

        public PassList()
        {
            InitializeComponent();
        }

        // "New Password" button
        private void button1_Click(object sender, EventArgs e)
        {
            NewPass newPassForm = new NewPass();
            newPassForm.ShowDialog();

            if (!newPassForm.Visible) RefreshList();
        }

        // "Update Password" button
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // If passwords are not hidden, open the "Update" form with the selected parameters.
                if (!passIsHidden)
                {
                    ListViewItem selectedItem = pList.SelectedItems[0];

                    UpdatePass updateForm = new UpdatePass();

                    updateForm.Name = pList.SelectedItems[0].SubItems[0].Text;      // User Name
                    updateForm.Company = pList.SelectedItems[0].SubItems[1].Text;   // Company Name
                    updateForm.Password = pList.SelectedItems[0].SubItems[2].Text;  // Password

                    updateForm.ShowDialog();

                    if (!updateForm.Visible) RefreshList();
                }
                else // If passwords are hidden, prompt the user to show the passwords before continuing.
                {
                    MessageBox.Show("Please show passwords before updating selected item.", "Passwords are hidden");
                }
            } catch (ArgumentOutOfRangeException)
            {
                // If no password is selecetd, prompt the user to select a password.
                MessageBox.Show("Please select a password to update!", "No Password Selected");
            }
        }

        // "Delete Password" button
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string confirmMessage = "Are you sure you want to delete this password?";
                string confirmTitle = "Password Deletion";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(confirmMessage, confirmTitle, buttons);

                if (result == DialogResult.Yes)
                {
                    ListViewItem itemToRemove = pList.SelectedItems[0];
                    string itemAsString = itemToRemove.Text;
                    bool itemFound = false;
                    try
                    {
                        StreamReader reader = new StreamReader("passwords.txt");
                        LinkedList<string> lines = new LinkedList<string>();

                        while (!reader.EndOfStream)
                        {
                            lines.AddLast(reader.ReadLine());
                        }

                        reader.Close();
                        File.Delete("passwords.txt");

                        StreamWriter writer = new StreamWriter("passwords.txt", true);
                        string[] linesAsArray = lines.ToArray();

                        for (int i = 0; i < linesAsArray.Length; i++)
                        {
                            if ((linesAsArray[i].Substring(0, linesAsArray[i].IndexOf(",")) != itemAsString) || itemFound)
                            {
                                writer.WriteLine(linesAsArray[i]);
                            }
                            else
                            {
                                itemFound = true;
                            }
                        }

                        writer.Close();
                        RefreshList();
                    }
                    catch (IOException exception)
                    {
                        MessageBox.Show(exception.Message, "I/O Exception Occurred");
                    }
                    finally
                    {
                        pList.Items.Remove(itemToRemove);
                    }
                }
            } catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select a password to delete!", "No Password Selected");
            }
        }

        private void btnToggleHide_Click(object sender, EventArgs e)
        {
            passIsHidden = !passIsHidden;
            RefreshList();
        }

        /** This method is obsolete because the program refreshes itself after user interaction.
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }
        **/

        private void PassList_Load(object sender, EventArgs e)
        {
            pList.View = View.Details;
            pList.FullRowSelect = true;

            pList.Columns.Add("Name", 100);
            pList.Columns.Add("Company", 150);
            pList.Columns.Add("Password", 165);

            UpdateList();
        }

        public void UpdateList()
        {
            try
            {
                StreamReader streamReader = new StreamReader("passwords.txt");
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();

                    string name = line.Substring(0, line.IndexOf(","));
                    string company = line.Substring(line.IndexOf(",") + 2, line.LastIndexOf(",") - (name.Length + 2));
                    string password = line.Substring(line.LastIndexOf(",") + 2);

                    Password newPass = new Password(password, name, company);

                    if (passIsHidden) newPass.ToggleHidden();

                    string[] arr = new string[3];
                    ListViewItem item;

                    arr[0] = newPass.User;
                    arr[1] = newPass.Company;
                    arr[2] = newPass.PassDisplay;

                    item = new ListViewItem(arr);
                    pList.Items.Add(item);
                }
                streamReader.Close();

            }
            catch (IOException)
            {
                // If the passwords.txt file does not exist, create it.
                StreamWriter streamWriter = new StreamWriter("passwords.txt");
                streamWriter.Close();
                //Console.WriteLine(exception.Message);
            }
        }

        private void RefreshList()
        {
            pList.Items.Clear();
            UpdateList();
        }
    }
}
