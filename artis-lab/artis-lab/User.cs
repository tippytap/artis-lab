using System;
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
                user.CreateDate = createdOn;
                result = Program.ARTISClient.insertResUser(user, authToken);
            }
            else
            {
                result = "Unable to save user.";
            }
            return result;
        }

        public String update(Dictionary<String, String> newValues, String authToken)
        {
            /*ARTISLAB.ResUser userToUpdate = new ARTISLAB.ResUser();
            String notes;
            String username;
            newValues.TryGetValue("username", out username);
            newValues.TryGetValue("notes", out notes);
            if (notes != "")
                userToUpdate.Notes = notes;
            if (username != "")
                userToUpdate.Username = username;*/
            /*if (privLevel != "")
                userToUpdate.PrivLevel = privLevel;*/
            //return Program.ARTISClient.saveResUser(userToUpdate, authToken);
            return "";
        }

        public string delete(String authToken)
        {
            return Program.ARTISClient.deleteResUser(username, authToken);
        }

        public String getUsername()
        {
            return username;
        }

        public String getPassword()
        {
            return password;
        }

        public String getNotes()
        {
            return notes;
        }

        public String getPrivLevel()
        {
            return privLevel;
        }

        public DateTime getCreateDate()
        {
            return createdOn;
        }

        public static String authenticate(String username, String password)
        {
            return Program.ARTISClient.logIn(username, password);
        }

        public static String logOut(String authToken)
        {
            return Program.ARTISClient.logOut(authToken);
        }

        public static User find(String username, String token)
        {
            ARTISLAB.ResUser foundUser = Program.ARTISClient.getResUser(username, token);
            return new User(foundUser.Username, foundUser.Password, foundUser.PrivLevel, foundUser.CreateDate, foundUser.Notes);
        }

        public static System.Data.DataTable getAllUsers()
        {
            return Program.ARTISClient.getResUsers();
        }

        public override String ToString()
        {
            return "Username: " + username + "\n" + password + "\n" + privLevel + "\n" + createdOn + "\n" + notes + "\n";
        }
    }
}
