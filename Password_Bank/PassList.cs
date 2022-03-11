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

        public string Keyword {get; set;}   // The website to search for
        public IList<Password> FullPassList { get; set; }

        public PassList()
        {
            InitializeComponent();
        }

        // "New Password" button
        private void button1_Click(object sender, EventArgs e)
        {
            NewPass newPassForm = new NewPass();
            newPassForm.ShowDialog();

            if (!newPassForm.Visible) RefreshList(true);
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
                    updateForm.Website = pList.SelectedItems[0].SubItems[1].Text;   // Company Name
                    updateForm.Password = pList.SelectedItems[0].SubItems[2].Text;  // Password

                    updateForm.ShowDialog();

                    if (!updateForm.Visible) RefreshList(true);
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

        private void PassList_Load(object sender, EventArgs e)
        {
            pList.View = View.Details;
            pList.FullRowSelect = true;

            pList.Columns.Add("Name", 100);
            pList.Columns.Add("Website", 150);
            pList.Columns.Add("Password", 165);

            UpdateList(true);
        }

        public void UpdateList(bool firstTime)
        {
            try
            {
                if (firstTime)
                    FullPassList = new List<Password>();

                StreamReader streamReader = new StreamReader("passwords.txt");
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();

                    string name = line.Substring(0, line.IndexOf(","));
                    string website = line.Substring(line.IndexOf(",") + 2, line.LastIndexOf(",") - (name.Length + 2));
                    string password = line.Substring(line.LastIndexOf(",") + 2);

                    Password newPass = new Password(password, name, website);

                    if (passIsHidden) newPass.ToggleHidden();

                    string[] arr = new string[3];
                    ListViewItem item;

                    arr[0] = newPass.User;
                    arr[1] = newPass.Website;
                    arr[2] = newPass.PassDisplay;

                    item = new ListViewItem(arr);
                    pList.Items.Add(item);

                    // If this is the first time loading the window, keep record of the unfiltered passwords.
                    if (firstTime)
                    {
                        FullPassList.Add(newPass);
                    }

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

        public void UpdateList()
        {
            UpdateList(false);
        }

        private void RefreshList()
        {
            RefreshList(false);
        }

        private void RefreshList(bool manipPassList)
        {
            pList.Items.Clear();
            UpdateList(manipPassList);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Keyword = txtSearch.Text;

            // If there is no keyword or the search bar is empty, display the whole list.
            if (Keyword == "" || Keyword == null)
            {
                pList.Items.Clear();
                foreach (Password pass in FullPassList)
                {
                    ListViewItem item = new ListViewItem(new string[] { pass.User, pass.Website, pass.PassDisplay });
                    pList.Items.Add(item);
                }
                return;
            }

            // Create the enumerable that filters the passwords whose websites contain the current keyword.
            IList<Password> filterPasswords = new List<Password>();
            foreach (Password pass in FullPassList)
            {
                if (pass.Website.Contains(Keyword))
                {
                    filterPasswords.Add(pass);
                }
            }

            // Clear the items and add the filtered items
            pList.Items.Clear();
            foreach (Password pass in filterPasswords)
            {
                ListViewItem item = new ListViewItem(new string[] { pass.User, pass.Website, pass.PassDisplay });
                pList.Items.Add(item);
            }
        }

        private void backupPasswordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If the passwords are hidden, prompt the user to show them and exit the method.
            if (passIsHidden)
            {
                MessageBox.Show("Please show your passwords before you back them up!", "Passwords are hidden");
                return;
            }

            // Displays a SaveFileDialog so the user can backup their passwords in case things go south.
            SaveFileDialog backupDialog = new SaveFileDialog();
            backupDialog.Filter = "Text File|*.txt";
            backupDialog.Title = "Save your passwords";
            backupDialog.ShowDialog();

            // If the filename is not empty, write the passwords to the text file and save the file.
            if (backupDialog.FileName != "")
            {
                try
                {
                    //StreamWriter writer = new StreamWriter($"{backupDialog.InitialDirectory}{backupDialog.FileName}", true);
                    //foreach (Password pass in FullPassList)
                    //{
                    //    writer.WriteLine(pass);
                    //}
                    //writer.Close();

                    string sourceFile = "passwords.txt";
                    string destFile = $"{backupDialog.InitialDirectory}{backupDialog.FileName}";

                    // To copy a file to another location and
                    // overwrite the destination file if it already exists.
                    System.IO.File.Copy(sourceFile, destFile, true);
                }
                catch (IOException exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
    }
}
