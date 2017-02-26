using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace artis_lab
{
    public class Controller
    {
        private MainForm mainForm;

        private String authToken;

        private bool loggedIn;

        private ViewLogIn viewLogin;
        private ViewUser viewUser;
        private ViewError viewError;

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
                viewUser = new ViewUser();
                viewUser.Text = "New User";
                viewUser.Show();
            }
            else
            {
                viewError = new ViewError();
                viewError.lblMessage.Text = "You must be logged in to perform this action.";
                viewError.ShowDialog();
            }
        }

        public void manageUsers()
        {
            Dictionary<String, ARTISLAB.ResUser> users = new Dictionary<String, ARTISLAB.ResUser>();
            System.Data.DataTable usersTable = User.getAllUsers();
            /*for(int i = 0; i < usersTable.Rows.Count; i++)
            {
                String username = usersTable.Rows[i]["USERNAME"].ToString();
                users.Add(username, User.find(username, authToken));
            }
            Debug.WriteLine("done");*/
        }
    }
}
