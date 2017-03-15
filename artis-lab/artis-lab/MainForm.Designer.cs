﻿namespace artis_lab
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuTopMenu = new System.Windows.Forms.MenuStrip();
            this.menuUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnManageUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnAddNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnSeeTopUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMyAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnLogIn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.chartResourceUsage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.btnState = new System.Windows.Forms.Button();
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
            this.menuBtnSeeTopUsers.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
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
            chartArea3.Name = "ChartArea1";
            this.chartResourceUsage.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartResourceUsage.Legends.Add(legend3);
            this.chartResourceUsage.Location = new System.Drawing.Point(12, 69);
            this.chartResourceUsage.Name = "chartResourceUsage";
            this.chartResourceUsage.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartResourceUsage.Series.Add(series3);
            this.chartResourceUsage.Size = new System.Drawing.Size(984, 648);
            this.chartResourceUsage.TabIndex = 1;
            this.chartResourceUsage.Text = "Resource Usage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Resource usage by number of bookings";
            // 
            // btnState
            // 
            this.btnState.ForeColor = System.Drawing.Color.IndianRed;
            this.btnState.Location = new System.Drawing.Point(922, 40);
            this.btnState.Name = "btnState";
            this.btnState.Size = new System.Drawing.Size(75, 23);
            this.btnState.TabIndex = 4;
            this.btnState.Text = "Logged out";
            this.btnState.UseVisualStyleBackColor = true;
            this.btnState.Click += new System.EventHandler(this.lblState_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnState);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnState;
    }
}

