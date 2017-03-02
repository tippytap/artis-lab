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
            dataGridUsers.DataSource = null;
            dataGridUsers.DataSource = users;
        }

        private void refreshUsers()
        {
            users = controller.updateUserList();
            loadUsers();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            controller.newUser();
        }

        private void btnEditSelected_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(dataGridUsers.SelectedRows);
            foreach(DataGridViewRow row in dataGridUsers.SelectedRows)
            {
                Debug.WriteLine(row.Cells[0].Value);
                controller.showUser(row.Cells[0].Value.ToString());
            }
            //if(dataGridUsers.SelectedIndex != -1)
            //    foreach(DataRowView row in listboxUsers.SelectedItems)
            //        controller.showUser(row[0].ToString());
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            //if (listboxUsers.SelectedIndex != -1)
            //    foreach (DataRowView row in listboxUsers.SelectedItems)
            //        controller.deleteUser(row[0].ToString());
        }
    }
}
