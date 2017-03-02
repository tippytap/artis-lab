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
    public partial class ViewUser : Form
    {
        private int type;
        private const int SAVING = 0;
        private const int UPDATING = 1;
        private Controller controller;
        public ViewUser(Controller controller, int type)
        {
            InitializeComponent();
            this.type = type;
            this.controller = controller;
            comboPriv.SelectedIndex = 0;
        }

        public ViewUser(Controller controller, int type, User user)
        {
            InitializeComponent();
            this.type = type;
            this.controller = controller;
            setDefaultValues(user);
            txtPassword.Enabled = false;
            this.Text = user.getUsername();
        }

        private void setDefaultValues(User user)
        {
            txtUsername.Text = user.getUsername();
            txtNotes.Text = user.getNotes();
            Debug.WriteLine(user.getUsername());
            Debug.WriteLine(user.getNotes());
            //dateCreatedOn.Text = user.getCreateDate().ToString();
            /*for(int i = 0; i < comboPriv.Items.Count; i++)
            {
                if(comboPriv.Items[i].ToString() == user.getPrivLevel())
                {
                    comboPriv.SelectedIndex = i;
                }
            }*/
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String username = (txtUsername.Text == null) ? "" : txtUsername.Text;
            String password = (txtPassword.Text == null) ? "" : txtPassword.Text;
            String privLevel = (comboPriv.SelectedItem == null) ? "" : comboPriv.SelectedItem.ToString();
            String notes = (txtNotes == null) ? "" : txtNotes.Text;
            switch (type)
            {
                case SAVING:
                    controller.saveNewUser(
                        username,
                        password,
                        privLevel,
                        dateCreatedOn.Value,
                        notes
                    );
                    break;
                case UPDATING:
                    controller.updateUser(
                        username,
                        password,
                        privLevel,
                        notes
                    );
                    break;
            }
        }
    }
}
