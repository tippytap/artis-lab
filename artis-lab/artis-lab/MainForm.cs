using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace artis_lab
{
    public partial class MainForm : Form
    {
        Controller controller;
        public MainForm()
        {
            InitializeComponent();
            controller = new Controller(this);
        }

        private void menuBtnLogIn_Click(object sender, EventArgs e)
        {
            controller.logIn();
            
        }

        private void menuBtnLogOut_Click(object sender, EventArgs e)
        {
            controller.logOut();
        }
    }
}
