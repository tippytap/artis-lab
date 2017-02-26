using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artis_lab
{
    class Controller
    {
        MainForm mainForm;

        public Controller(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        public void logIn()
        {
            ViewLogIn login = new ViewLogIn();
            login.ShowDialog();
        }
        public void authenticate()
        {
            
        }
    }
}
