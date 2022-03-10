using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Bank
{
    public class Password
    {
        private string passKey;
        private bool isHidden = false;

        public string User { get; set; }
        public string Website { get; set; }
        public string PassDisplay { get; set; }     // Either displays the password or a string of asterisks depending on whether it is hidden

        // default constructor
        public Password(string passKey, string user, string website)
        {
            this.passKey = passKey;
            User = user;
            Website = website;

            UpdateHidden();
        }

        // constructor without company name
        public Password(string passKey, string user)
        {
            this.passKey = passKey;
            User = user;
            Website = "None";

            UpdateHidden();
        }

        // constructor with only password
        public Password(string passKey)
        {
            this.passKey = passKey;
            User = "Unknown";
            Website = "None";

            UpdateHidden();
        }

        /**
         * Toggles whether the password displays asterisks in place of the actual password
         */
        public void ToggleHidden()
        {
            isHidden = !isHidden;

            UpdateHidden();
        }

        /**
         * Checks whether the password is hidden, then updates the status accordingly.
         */
        private void UpdateHidden()
        {
            if (!isHidden) PassDisplay = passKey;
            else
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < passKey.Length; i++)
                {
                    sb.Append("*");
                }
                PassDisplay = sb.ToString();
            }
        }

        public override string ToString()
        {
            return $"{User}, {Website}, {PassDisplay}";
        }

        /*
        private static void WriteListToConsole(Password[] passwords)
        {
            foreach (Password el in passwords)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine("");
        }

        // Main method for testing purposes 
        public static void Main(string[] args)
        {
            Password pass1 = new Password("12345", "Bob", "Bob Enterprises");
            Password pass2 = new Password("apple", "Georgie");
            Password pass3 = new Password("cherry", "Mary", "Googol");
            Password pass4 = new Password("elephant777");
            Password pass5 = new Password("ding_dong", "Lawrence");

            Password[] passwords = { pass1, pass2, pass3, pass4, pass5 };

            writeListToConsole(passwords);

            foreach (Password el in passwords)
            {
                el.ToggleHidden();
            }

            writeListToConsole(passwords);

            foreach (Password el in passwords)
            {
                el.ToggleHidden();
            }

            writeListToConsole(passwords);
        }
        */
    }
}
