using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                viewUser.ShowDialog();
            }
            else
            {
                viewError = new ViewError();
                viewError.lblMessage.Text = "You must be logged in to perform this action.";
                viewError.ShowDialog();
            }
        }
    }
}
