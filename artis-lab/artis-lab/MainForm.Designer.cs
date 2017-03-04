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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuTopMenu = new System.Windows.Forms.MenuStrip();
            this.menuUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnManageUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnAddNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnSeeTopUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMyAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnLogIn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.chartResourceUsage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResourceUsage)).BeginInit();
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
            this.menuUsers.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.U)));
            this.menuUsers.Size = new System.Drawing.Size(47, 20);
            this.menuUsers.Text = "Users";
            // 
            // menuBtnManageUsers
            // 
            this.menuBtnManageUsers.Name = "menuBtnManageUsers";
            this.menuBtnManageUsers.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.menuBtnManageUsers.Size = new System.Drawing.Size(198, 22);
            this.menuBtnManageUsers.Text = "Manage Users...";
            this.menuBtnManageUsers.Click += new System.EventHandler(this.menuBtnManageUsers_Click);
            // 
            // menuBtnAddNewUser
            // 
            this.menuBtnAddNewUser.Name = "menuBtnAddNewUser";
            this.menuBtnAddNewUser.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.menuBtnAddNewUser.Size = new System.Drawing.Size(198, 22);
            this.menuBtnAddNewUser.Text = "Add New User...";
            this.menuBtnAddNewUser.Click += new System.EventHandler(this.menuBtnAddNewUser_Click);
            // 
            // menuBtnSeeTopUsers
            // 
            this.menuBtnSeeTopUsers.Name = "menuBtnSeeTopUsers";
            this.menuBtnSeeTopUsers.Size = new System.Drawing.Size(198, 22);
            this.menuBtnSeeTopUsers.Text = "See Top Users";
            this.menuBtnSeeTopUsers.Click += new System.EventHandler(this.menuBtnSeeTopUsers_Click);
            // 
            // menuMyAccount
            // 
            this.menuMyAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnLogIn,
            this.menuBtnLogOut});
            this.menuMyAccount.Name = "menuMyAccount";
            this.menuMyAccount.ShortcutKeyDisplayString = "";
            this.menuMyAccount.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.menuMyAccount.Size = new System.Drawing.Size(84, 20);
            this.menuMyAccount.Text = "My Account";
            // 
            // menuBtnLogIn
            // 
            this.menuBtnLogIn.Name = "menuBtnLogIn";
            this.menuBtnLogIn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.menuBtnLogIn.Size = new System.Drawing.Size(156, 22);
            this.menuBtnLogIn.Text = "Log In...";
            this.menuBtnLogIn.Click += new System.EventHandler(this.menuBtnLogIn_Click);
            // 
            // menuBtnLogOut
            // 
            this.menuBtnLogOut.Name = "menuBtnLogOut";
            this.menuBtnLogOut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.menuBtnLogOut.Size = new System.Drawing.Size(156, 22);
            this.menuBtnLogOut.Text = "Log Out";
            this.menuBtnLogOut.Click += new System.EventHandler(this.menuBtnLogOut_Click);
            // 
            // chartResourceUsage
            // 
            chartArea2.Name = "ChartArea1";
            this.chartResourceUsage.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartResourceUsage.Legends.Add(legend2);
            this.chartResourceUsage.Location = new System.Drawing.Point(61, 82);
            this.chartResourceUsage.Name = "chartResourceUsage";
            this.chartResourceUsage.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartResourceUsage.Series.Add(series2);
            this.chartResourceUsage.Size = new System.Drawing.Size(890, 595);
            this.chartResourceUsage.TabIndex = 1;
            this.chartResourceUsage.Text = "Resource Usage";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.chartResourceUsage);
            this.Controls.Add(this.menuTopMenu);
            this.MainMenuStrip = this.menuTopMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARTIS Lab Admin";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuTopMenu.ResumeLayout(false);
            this.menuTopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResourceUsage)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem menuBtnLogOut;
        public System.Windows.Forms.ToolStripMenuItem menuBtnLogIn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResourceUsage;
    }
}

