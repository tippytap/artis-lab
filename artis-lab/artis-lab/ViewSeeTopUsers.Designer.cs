namespace artis_lab
{
    partial class ViewSeeTopUsers
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
            this.chartTopUsers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTopUsers
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTopUsers.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTopUsers.Legends.Add(legend2);
            this.chartTopUsers.Location = new System.Drawing.Point(12, 54);
            this.chartTopUsers.Name = "chartTopUsers";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTopUsers.Series.Add(series2);
            this.chartTopUsers.Size = new System.Drawing.Size(978, 595);
            this.chartTopUsers.TabIndex = 0;
            this.chartTopUsers.Text = "See Top Users";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "User reservations by number of bookings";
            // 
            // ViewSeeTopUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartTopUsers);
            this.Name = "ViewSeeTopUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Top Users";
            this.Load += new System.EventHandler(this.ViewSeeTopUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTopUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopUsers;
        private System.Windows.Forms.Label label1;
    }
}