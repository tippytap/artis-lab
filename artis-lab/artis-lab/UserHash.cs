using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace artis_lab
{
    public class UserHash
    {
        private Hashtable users;
        
        public UserHash()
        {
            users = new Hashtable();
            loadUsers();
        }

        private void loadUsers()
        {
            
        }

    }
}
