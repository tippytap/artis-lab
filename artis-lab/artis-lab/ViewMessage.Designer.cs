namespace artis_lab
{
    partial class ViewMessage
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnGotIt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(32, 30);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(568, 119);
            this.lblMessage.TabIndex = 0;
            // 
            // btnGotIt
            // 
            this.btnGotIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnGotIt.Location = new System.Drawing.Point(489, 152);
            this.btnGotIt.Name = "btnGotIt";
            this.btnGotIt.Size = new System.Drawing.Size(111, 39);
            this.btnGotIt.TabIndex = 1;
            this.btnGotIt.Text = "Got it";
            this.btnGotIt.UseVisualStyleBackColor = true;
            this.btnGotIt.Click += new System.EventHandler(this.btnGotIt_Click);
            // 
            // ViewMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 219);
            this.Controls.Add(this.btnGotIt);
            this.Controls.Add(this.lblMessage);
            this.Name = "ViewMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGotIt;
        public System.Windows.Forms.Label lblMessage;
    }
}