﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace artis_lab
{
    public class User : Updatable
    {

        private String username;
        private String password;
        private String privLevel;
        private String notes;

        private DateTime createdOn;

        public User(String username, String password, String privLevel, DateTime createdOn, String notes)
        {
            this.username = username;
            this.password = password;
            this.privLevel = privLevel;
            this.createdOn = createdOn;
            this.notes = notes;   
        }

        public String save(String authToken)
        {
            ARTISLAB.ResUser user = new ARTISLAB.ResUser();
            String result = "";
            if (username != "" && password != "" && privLevel != "")
            {
                user.Username = username;
                user.Password = password;
                user.PrivLevel = privLevel;
                user.Notes = notes;
                result = Program.ARTISClient.insertResUser(user, authToken);
            }
            else
            {
                result = "Unable to save user.";
            }
            return result;
        }

        public String update(String authToken)
        {
            ARTISLAB.ResUser user = new ARTISLAB.ResUser();
            if (username != "")
                user.Username = username;
            if (password != "")
                user.Password = password;
            if (user.PrivLevel != "")
                user.PrivLevel = privLevel;
            if (user.Notes != "")
                user.Notes = notes;
            return Program.ARTISClient.saveResUser(user, authToken);
        }

        public string delete(String username, String authToken)
        {
            return Program.ARTISClient.deleteResUser(username, authToken);
        }

        public static String authenticate(String username, String password)
        {
            return Program.ARTISClient.logIn(username, password);
        }

        public static String logOut(String authToken)
        {
            return Program.ARTISClient.logOut(authToken);
        }

        public static ARTISLAB.ResUser find(String username, String token)
        {
            ARTISLAB.ResUser foundUser = Program.ARTISClient.getResUser(username, token);
            return foundUser;
        }

        public static System.Data.DataTable getAllUsers()
        {
            return Program.ARTISClient.getResUsers();
        }

    }
}
