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
    public partial class ViewManageUsers : Form
    {
        private Controller controller;
        private System.Data.DataTable users;
        public ViewManageUsers(Controller controller, System.Data.DataTable users)
        {
            InitializeComponent();
            comboSearchMethod.SelectedIndex = 0;
            this.controller = controller;
            this.users = users;
            loadUsers();
        }

        private void loadUsers()
        {
            foreach(DataRow row in users.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for(int i = 1; i < users.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                listviewUsers.Items.Add(item);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            controller.newUser();
        }
    }
}
