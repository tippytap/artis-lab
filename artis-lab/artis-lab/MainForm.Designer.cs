namespace artis_lab
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuTopMenu = new System.Windows.Forms.MenuStrip();
            this.menuUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMyAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnManageUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnAddNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnSeeTopUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnLogIn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTopMenu
            // 
            this.menuTopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsers,
            this.menuMyAccount});
            this.menuTopMenu.Location = new System.Drawing.Point(0, 0);
            this.menuTopMenu.Name = "menuTopMenu";
            this.menuTopMenu.Size = new System.Drawing.Size(1008, 24);
            this.menuTopMenu.TabIndex = 0;
            this.menuTopMenu.Text = "menuStrip1";
            // 
            // menuUsers
            // 
            this.menuUsers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnManageUsers,
            this.menuBtnAddNewUser,
            this.menuBtnSeeTopUsers});
            this.menuUsers.Name = "menuUsers";
            this.menuUsers.Size = new System.Drawing.Size(47, 20);
            this.menuUsers.Text = "Users";
            // 
            // menuMyAccount
            // 
            this.menuMyAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnLogIn,
            this.menuBtnLogOut});
            this.menuMyAccount.Name = "menuMyAccount";
            this.menuMyAccount.Size = new System.Drawing.Size(84, 20);
            this.menuMyAccount.Text = "My Account";
            // 
            // menuBtnManageUsers
            // 
            this.menuBtnManageUsers.Name = "menuBtnManageUsers";
            this.menuBtnManageUsers.Size = new System.Drawing.Size(158, 22);
            this.menuBtnManageUsers.Text = "Manage Users...";
            // 
            // menuBtnAddNewUser
            // 
            this.menuBtnAddNewUser.Name = "menuBtnAddNewUser";
            this.menuBtnAddNewUser.Size = new System.Drawing.Size(158, 22);
            this.menuBtnAddNewUser.Text = "Add New User...";
            // 
            // menuBtnSeeTopUsers
            // 
            this.menuBtnSeeTopUsers.Name = "menuBtnSeeTopUsers";
            this.menuBtnSeeTopUsers.Size = new System.Drawing.Size(158, 22);
            this.menuBtnSeeTopUsers.Text = "See Top Users";
            // 
            // menuBtnLogIn
            // 
            this.menuBtnLogIn.Name = "menuBtnLogIn";
            this.menuBtnLogIn.Size = new System.Drawing.Size(152, 22);
            this.menuBtnLogIn.Text = "Log In..";
            // 
            // menuBtnLogOut
            // 
            this.menuBtnLogOut.Name = "menuBtnLogOut";
            this.menuBtnLogOut.Size = new System.Drawing.Size(152, 22);
            this.menuBtnLogOut.Text = "Log Out";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.menuTopMenu);
            this.MainMenuStrip = this.menuTopMenu;
            this.Name = "MainForm";
            this.Text = "ARTIS Lab Admin";
            this.menuTopMenu.ResumeLayout(false);
            this.menuTopMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTopMenu;
        private System.Windows.Forms.ToolStripMenuItem menuUsers;
        private System.Windows.Forms.ToolStripMenuItem menuBtnManageUsers;
        private System.Windows.Forms.ToolStripMenuItem menuBtnAddNewUser;
        private System.Windows.Forms.ToolStripMenuItem menuBtnSeeTopUsers;
        private System.Windows.Forms.ToolStripMenuItem menuMyAccount;
        private System.Windows.Forms.ToolStripMenuItem menuBtnLogIn;
        private System.Windows.Forms.ToolStripMenuItem menuBtnLogOut;
    }
}

