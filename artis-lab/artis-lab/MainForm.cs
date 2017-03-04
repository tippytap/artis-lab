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

        private void menuBtnAddNewUser_Click(object sender, EventArgs e)
        {
            controller.newUser();
        }

        private void menuBtnManageUsers_Click(object sender, EventArgs e)
        {
            controller.manageUsers();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            chartResourceUsage.DataSource = controller.getResourceUsage();

            // series 1
            chartResourceUsage.Series[0].Name = "Current Semester";
            chartResourceUsage.Series[0].XValueMember = "RNAME";
            chartResourceUsage.Series[0].YValueMembers = "CURSEM";

            // series 2
            chartResourceUsage.Series.Add("Last Semester");
            chartResourceUsage.Series[1].XValueMember = "RNAME";
            chartResourceUsage.Series[1].YValueMembers = "LASTSEM";
        }

        private void menuBtnSeeTopUsers_Click(object sender, EventArgs e)
        {
            controller.seeTopUsers();
        }
    }
}
