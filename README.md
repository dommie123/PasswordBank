# PasswordBank
An Application created for the purpose of storing and managing passwords.

## Get started!
To use this project as a regular person: 
* Create a Batch file (a file with the .bat extension)
* In that batch file, type `cd <full directory of git repo>/Password_Bank/bin/Debug`.
* Press 'Enter' to create a new line, then type `start Password_Bank.exe`.
* Have fun keeping track of your passwords! Signing in is as simple as clicking a button and the UI is pretty straightforward!

To download this project as a developer:
* Have Visual Studio 2019 ready. If you don't have it, you can download it at https://visualstudio.microsoft.com/downloads/.
* If you have GIT, you can clone this repo by typing `git clone https://github.com/dommie123/PasswordBank/edit/master/README.md`. 
* Navigate to the Password_Bank.sln file and open it with Visual Studio. This should be in the main project directory.
* That's all there is to it! You can run this project at any time simply by clicking the green arrow at the top of the IDE.

## Using the Password Bank
To use the project as it's running: 
* Click "Sign In". At this point, no credentials are necessary, however there is only one account associated with the project.
* To add a password, click "New Password" and fill out the information provided.
* Note* the "Company" property can also act as the website that uses the password.
* The password should now be populated in the List component.
* To update a password, click the password you want to update, then update any fields accordingly.
* To delete a password, click the password you want to delete. 
* Note* It will ask for confirmation before it deletes the password. To delete the password, click "Yes". 
* You can hide/show the passwords at any time using the "Hide/Show" Passwords button. 

## Technologies used
This project was made purely in C# and was configured as a Windows Forms Application that implements the .NET Framework.

## Future Implementations
If you are a developer and want to help me further develop this project, here are some of the implementations I would like to see:
* Users can add new passwords as well as view, update, and delete their saved passwords from a database rather than from a file.
* Users will be able to log in or register with a username and master password to ensure greater security.
* The system will be able to encrypt stored passwords and decrypt them for user viewing.
* The system will email the user each time they log in so they will be notified if anyone else logs in to their account.
* The system will use RegEx to verify that a password meets a number of requirements before being saved to the database.
* The application will have a more decorative, but streamlined view (so it looks organized, but not gray or boring). 
* The application will be available as a browser extension as well as an offline application.

