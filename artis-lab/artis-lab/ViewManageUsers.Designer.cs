namespace artis_lab
{
    partial class ViewManageUsers
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.comboSearchMethod = new System.Windows.Forms.ComboBox();
            this.btnEditSelected = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(236, 46);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(269, 30);
            this.txtSearch.TabIndex = 0;
            // 
            // comboSearchMethod
            // 
            this.comboSearchMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.comboSearchMethod.FormattingEnabled = true;
            this.comboSearchMethod.Items.AddRange(new object[] {
            "Username contains",
            "Note contains"});
            this.comboSearchMethod.Location = new System.Drawing.Point(51, 45);
            this.comboSearchMethod.Name = "comboSearchMethod";
            this.comboSearchMethod.Size = new System.Drawing.Size(179, 30);
            this.comboSearchMethod.TabIndex = 2;
            // 
            // btnEditSelected
            // 
            this.btnEditSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnEditSelected.Location = new System.Drawing.Point(404, 421);
            this.btnEditSelected.Name = "btnEditSelected";
            this.btnEditSelected.Size = new System.Drawing.Size(171, 45);
            this.btnEditSelected.TabIndex = 4;
            this.btnEditSelected.Text = "Edit Selected...";
            this.btnEditSelected.UseVisualStyleBackColor = true;
            this.btnEditSelected.Click += new System.EventHandler(this.btnEditSelected_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(227, 421);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(171, 45);
            this.btnAddUser.TabIndex = 5;
            this.btnAddUser.Text = "Add User...";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnDeleteSelected.Location = new System.Drawing.Point(50, 421);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(171, 45);
            this.btnDeleteSelected.TabIndex = 6;
            this.btnDeleteSelected.Text = "Delete Selected";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Find a user";
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.AllowUserToAddRows = false;
            this.dataGridUsers.AllowUserToDeleteRows = false;
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridUsers.Location = new System.Drawing.Point(51, 82);
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.ReadOnly = true;
            this.dataGridUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUsers.Size = new System.Drawing.Size(524, 333);
            this.dataGridUsers.TabIndex = 9;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnRefresh.Image = global::artis_lab.Properties.Resources.loop;
            this.btnRefresh.Location = new System.Drawing.Point(546, 46);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(29, 31);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnSearch.Image = global::artis_lab.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(511, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(29, 31);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ViewManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 528);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnEditSelected);
            this.Controls.Add(this.comboSearchMethod);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "ViewManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboSearchMethod;
        private System.Windows.Forms.Button btnEditSelected;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.Button btnRefresh;
    }
}