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

        // VIEWS : Windows
        private ViewLogIn viewLogin;
        private ViewUser viewUser;
        private ViewMessage viewMessage;
        private ViewManageUsers viewManageUsers;
        private ViewConfirm viewConfirm;
        private ViewSeeTopUsers viewSeeTopUsers;
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
            Dictionary<String, String> newValues = new Dictionary<String, String>();
            newValues.Add("username", username);
            newValues.Add("privLevel", privLevel);
            newValues.Add("notes", notes);
            User user = User.find(username, authToken);
            viewMessage = new ViewMessage(user.update(newValues, authToken));
            viewMessage.ShowDialog();
            viewUser.Close();
        }

        public bool confirm(String message)
        {
            viewConfirm = new ViewConfirm(message);
            viewConfirm.ShowDialog();
            return viewConfirm.getConfirm();
        }

        public void seeTopUsers()
        {
            viewSeeTopUsers = new ViewSeeTopUsers(this);
            viewSeeTopUsers.Show();
        }

        public System.Data.DataTable getTopUsers()
        {
            return Program.ARTISClient.getTopUsers();
        }

        public void deleteUser(String username)
        {
            User user = User.find(username, authToken);
            viewMessage = new ViewMessage(user.delete(authToken));
            viewMessage.ShowDialog();
        }

        public System.Data.DataTable updateUserList()
        {
            return User.getAllUserData();
        }

        public void showUser(String username)
        {
            Debug.WriteLine("showUser");
            Debug.WriteLine(username);
            User user = User.find(username, authToken);
            Debug.WriteLine(user.getUsername());
            viewUser = new ViewUser(this, 1, user);
            viewUser.Show();
        }

        public System.Data.DataTable getResourceUsage()
        {
            return Program.ARTISClient.getResourceUsage();
        }

        public void manageUsers()
        {
            if (isLoggedIn())
            {
                System.Data.DataTable users = User.getAllUserData();
                viewManageUsers = new ViewManageUsers(this, users);
                viewManageUsers.Show();
            }
            else
            {
                viewMessage = new ViewMessage(NOT_LOGGED_IN);
                viewMessage.ShowDialog();
            }
        }

    }
}
