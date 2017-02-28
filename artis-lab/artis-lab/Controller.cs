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

        private Dictionary<String, ARTISLAB.ResUser> users;

        private ViewLogIn viewLogin;
        private ViewUser viewUser;
        private ViewError viewError;
        private ViewManageUsers viewManageUsers;

        public Controller(MainForm mainForm)
        {
            this.mainForm = mainForm;
            loggedIn = false;
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
                viewError = new ViewError(NOT_LOGGED_IN);
                viewError.ShowDialog();
            }
        }

        public void saveNewUser(String username, String password, String privLevel, DateTime createdOn, String notes)
        {
            User newUser = new User(username, password, privLevel, createdOn, notes);
            viewError = new ViewError(newUser.save(authToken));
            viewError.ShowDialog();
            viewUser.Close();
        }

        public void updateUser(String username, String password, String privLevel, String notes)
        {
            Debug.WriteLine(username);
        }

        public void manageUsers()
        {
            if (isLoggedIn())
            {
                Thread t = new Thread(new ThreadStart(loadUsers));
                t.Start();
                viewManageUsers = new ViewManageUsers();
                viewManageUsers.Show();
            }
            else
            {
                viewError = new ViewError(NOT_LOGGED_IN);
                viewError.ShowDialog();
            }
        }

        private void loadUsers()
        {
            List<ARTISLAB.ResUser> usersList = new List<ARTISLAB.ResUser>();
            System.Data.DataTable usersTable = User.getAllUsers();
            for(int i = 0; i < usersTable.Rows.Count; i++)
            {
                String username = usersTable.Rows[i]["USERNAME"].ToString();
                usersList.Add(User.find(username, authToken));
            }
            users = usersList.ToDictionary(u => u.Username);
            if (viewManageUsers.Visible)
            {
                //viewManageUsers.listviewUsers.Items.AddRange(usersList.ToArray());
            }
        }
    }
}
