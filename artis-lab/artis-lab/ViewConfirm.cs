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
    public partial class ViewConfirm : Form
    {
        private bool confirm;
        public ViewConfirm(String message)
        {
            InitializeComponent();
            confirm = false;
            lblMessage.Text = message;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            confirm = true;
            this.Close();
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool getConfirm()
        {
            return confirm;
        }
    }
}
