namespace Group_11_Project_LIMS
{
    partial class WorkRequestsPerTime
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
            this.lblDateTimeIssued = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFirstPage = new System.Windows.Forms.Label();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.lblPageBreakdown = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDateTimeIssued
            // 
            this.lblDateTimeIssued.AutoSize = true;
            this.lblDateTimeIssued.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTimeIssued.Location = new System.Drawing.Point(12, 9);
            this.lblDateTimeIssued.Name = "lblDateTimeIssued";
            this.lblDateTimeIssued.Size = new System.Drawing.Size(44, 16);
            this.lblDateTimeIssued.TabIndex = 4;
            this.lblDateTimeIssued.Text = "label1";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(272, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(219, 20);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Work Requests Per Month";
            // 
            // lblFirstPage
            // 
            this.lblFirstPage.AutoSize = true;
            this.lblFirstPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstPage.Location = new System.Drawing.Point(735, 9);
            this.lblFirstPage.Name = "lblFirstPage";
            this.lblFirstPage.Size = new System.Drawing.Size(53, 16);
            this.lblFirstPage.TabIndex = 6;
            this.lblFirstPage.Text = "Page: 1";
            // 
            // lstDisplay
            // 
            this.lstDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.ItemHeight = 20;
            this.lstDisplay.Location = new System.Drawing.Point(181, 79);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(421, 524);
            this.lstDisplay.TabIndex = 0;
            // 
            // lblPageBreakdown
            // 
            this.lblPageBreakdown.AutoSize = true;
            this.lblPageBreakdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageBreakdown.Location = new System.Drawing.Point(711, 650);
            this.lblPageBreakdown.Name = "lblPageBreakdown";
            this.lblPageBreakdown.Size = new System.Drawing.Size(77, 16);
            this.lblPageBreakdown.TabIndex = 16;
            this.lblPageBreakdown.Text = "Page: 1 of 1";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(313, 618);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(148, 48);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.Location = new System.Drawing.Point(256, 40);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(71, 20);
            this.lblPeriod.TabIndex = 18;
            this.lblPeriod.Text = "From to";
            this.lblPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WorkRequestsPerTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 687);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPageBreakdown);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.lblFirstPage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDateTimeIssued);
            this.Name = "WorkRequestsPerTime";
            this.Text = "Work Requests per Time Period";
            this.Load += new System.EventHandler(this.WorkRequestsPerTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateTimeIssued;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFirstPage;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Label lblPageBreakdown;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPeriod;
    }
}