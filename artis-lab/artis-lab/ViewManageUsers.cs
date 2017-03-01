﻿using System;
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
            foreach (DataRow row in users.Rows)
            {
                listboxUsers.Items.Add(row[0].ToString());
            }
            Debug.WriteLine(listboxUsers.SelectedIndex);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            controller.newUser();
        }

        private void btnEditSelected_Click(object sender, EventArgs e)
        {
            if(listboxUsers.SelectedIndex != -1)
                foreach(Object user in listboxUsers.SelectedItems)
                    controller.showUser(user.ToString());
        }
    }
}
