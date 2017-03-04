using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace artis_lab
{
    public partial class ViewSeeTopUsers : Form
    {
        Controller controller;
        public ViewSeeTopUsers(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void ViewSeeTopUsers_Load(object sender, EventArgs e)
        {
            chartTopUsers.DataSource = controller.getTopUsers();
            chartTopUsers.Series[0].Name = "Current Semester";
            chartTopUsers.Series[0].XValueMember = "USERNAME";
            chartTopUsers.Series[0].YValueMembers = "CURSEM";
            chartTopUsers.Series.Add("Last Semester");
            chartTopUsers.Series[1].XValueMember = "USERNAME";
            chartTopUsers.Series[1].YValueMembers = "LASTSEM";
        }
    }
}
