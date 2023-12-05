namespace Group_11_Project_LIMS
{
    partial class SelectTimePeriodForm
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.cmbStartDate = new System.Windows.Forms.ComboBox();
            this.cmbStartEnd = new System.Windows.Forms.ComboBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(101, 256);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(131, 39);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(101, 48);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(336, 16);
            this.lblInstruction.TabIndex = 1;
            this.lblInstruction.Text = "Please select both a start and an end date from the lists:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(135, 103);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(69, 16);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Start Date:";
            // 
            // cmbStartDate
            // 
            this.cmbStartDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStartDate.FormattingEnabled = true;
            this.cmbStartDate.Items.AddRange(new object[] {
            "2022/01/01",
            "2022/02/01",
            "2022/03/01",
            "2022/04/01",
            "2022/05/01",
            "2022/06/01",
            "2022/07/01",
            "2022/08/01",
            "2022/09/01",
            "2022/10/01",
            "2022/11/01",
            "2022/12/01",
            "2023/01/01",
            "2023/02/01",
            "2023/03/01",
            "2023/04/01",
            "2023/05/01",
            "2023/06/01",
            "2023/07/01",
            "2023/08/01",
            "2023/09/01",
            "2023/10/01",
            "2023/11/01",
            "2023/12/01"});
            this.cmbStartDate.Location = new System.Drawing.Point(250, 100);
            this.cmbStartDate.Name = "cmbStartDate";
            this.cmbStartDate.Size = new System.Drawing.Size(145, 24);
            this.cmbStartDate.TabIndex = 0;
            // 
            // cmbStartEnd
            // 
            this.cmbStartEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStartEnd.FormattingEnabled = true;
            this.cmbStartEnd.Items.AddRange(new object[] {
            "2022/01/31",
            "2022/02/28",
            "2022/03/31",
            "2022/04/30",
            "2022/05/31",
            "2022/06/30",
            "2022/07/31",
            "2022/08/31",
            "2022/09/30",
            "2022/10/31",
            "2022/11/30",
            "2022/12/31",
            "2023/01/31",
            "2023/02/28",
            "2023/03/31",
            "2023/04/30",
            "2023/05/31",
            "2023/06/30",
            "2023/07/31",
            "2023/08/31",
            "2023/09/30",
            "2023/10/31",
            "2023/11/30",
            "2023/12/31"});
            this.cmbStartEnd.Location = new System.Drawing.Point(250, 169);
            this.cmbStartEnd.Name = "cmbStartEnd";
            this.cmbStartEnd.Size = new System.Drawing.Size(145, 24);
            this.cmbStartEnd.TabIndex = 1;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(135, 172);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(69, 16);
            this.lblEndDate.TabIndex = 4;
            this.lblEndDate.Text = "Start Date:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(306, 256);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 39);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SelectTimePeriodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 366);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cmbStartEnd);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.cmbStartDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.btnGenerate);
            this.Name = "SelectTimePeriodForm";
            this.Text = "Select Time Period";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.ComboBox cmbStartDate;
        private System.Windows.Forms.ComboBox cmbStartEnd;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Button btnBack;
    }
}