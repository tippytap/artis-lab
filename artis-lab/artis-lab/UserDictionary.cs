using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;
using System.Threading;

namespace artis_lab
{
    public class UserDictionary
    {
        private Dictionary<String, ARTISLAB.ResUser> users;

        private Controller controller;
        
        public UserDictionary(Controller controller)
        {
            this.controller = controller;
            Thread t = new Thread(new ThreadStart(loadUsers));
            t.Start();
        }

        private void loadUsers()
        {
            List<ARTISLAB.ResUser> usersList = new List<ARTISLAB.ResUser>();
            System.Data.DataTable usersTable = User.getAllUsers();
            for(int i = 0; i < usersTable.Rows.Count; i++)
            {
                String username = usersTable.Rows[i]["USERNAME"].ToString();
                usersList.Add(User.find(username, controller.getAuthToken()));
            }
            users = usersList.ToDictionary(u => u.Username);
        }

    }
}
