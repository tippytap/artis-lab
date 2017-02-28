using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace artis_lab
{
    public class Controller
    {
        private MainForm mainForm;

        private String authToken;

        private bool loggedIn;

        private const String NOT_LOGGED_IN = "You must be logged in to perform this action.";

        // VIEWS
        private ViewLogIn viewLogin;
        private ViewUser viewUser;
        private ViewMessage viewMessage;
        private ViewManageUsers viewManageUsers;
        //

        public Controller(MainForm mainForm)
        {
            this.mainForm = mainForm;
            loggedIn = false;
            authToken = "";
        }

        public void logIn()
        {
            viewLogin = new ViewLogIn(this);
            viewLogin.ShowDialog();
        }

        public void authenticate(String username, String password)
        {
            authToken = User.authenticate(username, password);
            if(authToken != "Invalid Credentials")
            {
                loggedIn = true;
                mainForm.menuBtnLogIn.Enabled = false;
                viewLogin.Close();
            }
            else
            {
                viewLogin.lblError.Text = authToken;
            }
        }

        public String getAuthToken()
        {
            return authToken;
        }

        public void logOut()
        {
            String result = User.logOut(authToken);
            mainForm.menuBtnLogIn.Enabled = true;
            loggedIn = (result == "Success") ? false : true;
        }

        public bool isLoggedIn()
        {
            return loggedIn;
        }

        public void newUser()
        {
            if (isLoggedIn())
            {
                viewUser = new ViewUser(this, 0);
                viewUser.Text = "New User";
                viewUser.Show();
            }
            else
            {
                viewMessage = new ViewMessage(NOT_LOGGED_IN);
                viewMessage.ShowDialog();
            }
        }

        public void saveNewUser(String username, String password, String privLevel, DateTime createdOn, String notes)
        {
            User newUser = new User(username, password, privLevel, createdOn, notes);
            viewMessage = new ViewMessage(newUser.save(authToken));
            viewMessage.ShowDialog();
            viewUser.Close();
        }

        public void updateUser(String username, String password, String privLevel, String notes)
        {
            Debug.WriteLine(username);
        }

        public void manageUsers()
        {
            /*if (isLoggedIn())
            {*/
                System.Data.DataTable users = User.getAllUsers();
                viewManageUsers = new ViewManageUsers(this, users);
                viewManageUsers.Show();
            /*}
            else
            {
                viewMessage = new ViewMessage(NOT_LOGGED_IN);
                viewMessage.ShowDialog();
            }*/
        }

    }
}
