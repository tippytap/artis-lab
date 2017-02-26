using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace artis_lab
{
    class User : Updatable
    {

        ARTISLAB.ResUser user;

        public void save()
        {
            throw new NotImplementedException();
        }

        public static String authenticate(String username, String password)
        {
            return Program.ARTISClient.logIn(username, password);
        }

        public static String logOut(String authToken)
        {
            return Program.ARTISClient.logOut(authToken);
        }
    }
}
