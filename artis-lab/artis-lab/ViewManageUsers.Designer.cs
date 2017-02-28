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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboSearchMethod = new System.Windows.Forms.ComboBox();
            this.listviewUsers = new System.Windows.Forms.ListView();
            this.Select = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Privelege = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Created = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Notes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEditSelected = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(214, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(533, 30);
            this.textBox1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(754, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // comboSearchMethod
            // 
            this.comboSearchMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.comboSearchMethod.FormattingEnabled = true;
            this.comboSearchMethod.Items.AddRange(new object[] {
            "Username",
            "Note"});
            this.comboSearchMethod.Location = new System.Drawing.Point(51, 45);
            this.comboSearchMethod.Name = "comboSearchMethod";
            this.comboSearchMethod.Size = new System.Drawing.Size(157, 30);
            this.comboSearchMethod.TabIndex = 2;
            // 
            // listviewUsers
            // 
            this.listviewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Select,
            this.Username,
            this.Privelege,
            this.Created,
            this.Notes});
            this.listviewUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.listviewUsers.Location = new System.Drawing.Point(51, 81);
            this.listviewUsers.Name = "listviewUsers";
            this.listviewUsers.Size = new System.Drawing.Size(822, 338);
            this.listviewUsers.TabIndex = 3;
            this.listviewUsers.UseCompatibleStateImageBehavior = false;
            // 
            // btnEditSelected
            // 
            this.btnEditSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnEditSelected.Location = new System.Drawing.Point(701, 425);
            this.btnEditSelected.Name = "btnEditSelected";
            this.btnEditSelected.Size = new System.Drawing.Size(171, 45);
            this.btnEditSelected.TabIndex = 4;
            this.btnEditSelected.Text = "Edit Selected...";
            this.btnEditSelected.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(524, 425);
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
            this.btnDeleteSelected.Location = new System.Drawing.Point(347, 425);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(171, 45);
            this.btnDeleteSelected.TabIndex = 6;
            this.btnDeleteSelected.Text = "Delete Selected";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            // 
            // ViewManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 528);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnEditSelected);
            this.Controls.Add(this.listviewUsers);
            this.Controls.Add(this.comboSearchMethod);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox1);
            this.Name = "ViewManageUsers";
            this.Text = "Manage Users";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboSearchMethod;
        private System.Windows.Forms.ColumnHeader Select;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Privelege;
        private System.Windows.Forms.ColumnHeader Created;
        private System.Windows.Forms.ColumnHeader Notes;
        public System.Windows.Forms.ListView listviewUsers;
        private System.Windows.Forms.Button btnEditSelected;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnDeleteSelected;
    }
}