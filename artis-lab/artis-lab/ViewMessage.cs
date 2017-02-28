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
    public partial class ViewMessage : Form
    {
        public ViewMessage(String message)
        {
            InitializeComponent();
            this.lblMessage.Text = message;
        }

        private void btnGotIt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
