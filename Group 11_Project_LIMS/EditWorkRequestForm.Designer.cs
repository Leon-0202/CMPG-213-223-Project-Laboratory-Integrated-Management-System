
namespace Group_11_Project_LIMS
{
    partial class EditWorkRequestForm
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
            this.msEditWorkRequest = new System.Windows.Forms.MenuStrip();
            this.tsHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWRNoCaption = new System.Windows.Forms.Label();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.lblSelectClient = new System.Windows.Forms.Label();
            this.lblSelectEmployee = new System.Windows.Forms.Label();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.lblWRNoDisplay = new System.Windows.Forms.Label();
            this.lblDateReceivedDisplay = new System.Windows.Forms.Label();
            this.lblDateReceivedCaption = new System.Windows.Forms.Label();
            this.lblDateDueDisplay = new System.Windows.Forms.Label();
            this.lblDateDueCaption = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtTestDescription = new System.Windows.Forms.TextBox();
            this.lblTestDescription = new System.Windows.Forms.Label();
            this.lblInvoicedDisplay = new System.Windows.Forms.Label();
            this.lblInvoicedCaption = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblSelectEmployeePrevious = new System.Windows.Forms.Label();
            this.lblSelectClientPrevious = new System.Windows.Forms.Label();
            this.msEditWorkRequest.SuspendLayout();
            this.SuspendLayout();
            // 
            // msEditWorkRequest
            // 
            this.msEditWorkRequest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsHelp});
            this.msEditWorkRequest.Location = new System.Drawing.Point(0, 0);
            this.msEditWorkRequest.Name = "msEditWorkRequest";
            this.msEditWorkRequest.Size = new System.Drawing.Size(731, 24);
            this.msEditWorkRequest.TabIndex = 0;
            this.msEditWorkRequest.Text = "menuStrip1";
            // 
            // tsHelp
            // 
            this.tsHelp.Name = "tsHelp";
            this.tsHelp.Size = new System.Drawing.Size(44, 20);
            this.tsHelp.Text = "Help";
            this.tsHelp.Click += new System.EventHandler(this.tsHelp_Click);
            // 
            // lblWRNoCaption
            // 
            this.lblWRNoCaption.AutoSize = true;
            this.lblWRNoCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWRNoCaption.Location = new System.Drawing.Point(129, 82);
            this.lblWRNoCaption.Name = "lblWRNoCaption";
            this.lblWRNoCaption.Size = new System.Drawing.Size(147, 16);
            this.lblWRNoCaption.TabIndex = 1;
            this.lblWRNoCaption.Text = "Work Request Number:";
            // 
            // cmbClient
            // 
            this.cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(368, 134);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(261, 24);
            this.cmbClient.TabIndex = 1;
            // 
            // lblSelectClient
            // 
            this.lblSelectClient.AutoSize = true;
            this.lblSelectClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectClient.Location = new System.Drawing.Point(129, 140);
            this.lblSelectClient.Name = "lblSelectClient";
            this.lblSelectClient.Size = new System.Drawing.Size(84, 16);
            this.lblSelectClient.TabIndex = 3;
            this.lblSelectClient.Text = "Select Client:";
            // 
            // lblSelectEmployee
            // 
            this.lblSelectEmployee.AutoSize = true;
            this.lblSelectEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectEmployee.Location = new System.Drawing.Point(129, 191);
            this.lblSelectEmployee.Name = "lblSelectEmployee";
            this.lblSelectEmployee.Size = new System.Drawing.Size(193, 16);
            this.lblSelectEmployee.TabIndex = 4;
            this.lblSelectEmployee.Text = "Select Responsible Employee:";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(368, 188);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(261, 24);
            this.cmbEmployee.TabIndex = 2;
            // 
            // lblWRNoDisplay
            // 
            this.lblWRNoDisplay.AutoSize = true;
            this.lblWRNoDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWRNoDisplay.Location = new System.Drawing.Point(365, 82);
            this.lblWRNoDisplay.Name = "lblWRNoDisplay";
            this.lblWRNoDisplay.Size = new System.Drawing.Size(44, 16);
            this.lblWRNoDisplay.TabIndex = 6;
            this.lblWRNoDisplay.Text = "label4";
            // 
            // lblDateReceivedDisplay
            // 
            this.lblDateReceivedDisplay.AutoSize = true;
            this.lblDateReceivedDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReceivedDisplay.Location = new System.Drawing.Point(365, 299);
            this.lblDateReceivedDisplay.Name = "lblDateReceivedDisplay";
            this.lblDateReceivedDisplay.Size = new System.Drawing.Size(44, 16);
            this.lblDateReceivedDisplay.TabIndex = 8;
            this.lblDateReceivedDisplay.Text = "label5";
            // 
            // lblDateReceivedCaption
            // 
            this.lblDateReceivedCaption.AutoSize = true;
            this.lblDateReceivedCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReceivedCaption.Location = new System.Drawing.Point(129, 299);
            this.lblDateReceivedCaption.Name = "lblDateReceivedCaption";
            this.lblDateReceivedCaption.Size = new System.Drawing.Size(101, 16);
            this.lblDateReceivedCaption.TabIndex = 7;
            this.lblDateReceivedCaption.Text = "Date Received:";
            // 
            // lblDateDueDisplay
            // 
            this.lblDateDueDisplay.AutoSize = true;
            this.lblDateDueDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDueDisplay.Location = new System.Drawing.Point(365, 351);
            this.lblDateDueDisplay.Name = "lblDateDueDisplay";
            this.lblDateDueDisplay.Size = new System.Drawing.Size(44, 16);
            this.lblDateDueDisplay.TabIndex = 10;
            this.lblDateDueDisplay.Text = "label7";
            // 
            // lblDateDueCaption
            // 
            this.lblDateDueCaption.AutoSize = true;
            this.lblDateDueCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDueCaption.Location = new System.Drawing.Point(129, 351);
            this.lblDateDueCaption.Name = "lblDateDueCaption";
            this.lblDateDueCaption.Size = new System.Drawing.Size(67, 16);
            this.lblDateDueCaption.TabIndex = 9;
            this.lblDateDueCaption.Text = "Date Due:";
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(192, 470);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(162, 51);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply Changes";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(382, 470);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(162, 51);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtTestDescription
            // 
            this.txtTestDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTestDescription.Location = new System.Drawing.Point(368, 246);
            this.txtTestDescription.Name = "txtTestDescription";
            this.txtTestDescription.Size = new System.Drawing.Size(261, 22);
            this.txtTestDescription.TabIndex = 3;
            // 
            // lblTestDescription
            // 
            this.lblTestDescription.AutoSize = true;
            this.lblTestDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestDescription.Location = new System.Drawing.Point(129, 249);
            this.lblTestDescription.Name = "lblTestDescription";
            this.lblTestDescription.Size = new System.Drawing.Size(179, 17);
            this.lblTestDescription.TabIndex = 13;
            this.lblTestDescription.Text = "Analytical Test Description:";
            // 
            // lblInvoicedDisplay
            // 
            this.lblInvoicedDisplay.AutoSize = true;
            this.lblInvoicedDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoicedDisplay.Location = new System.Drawing.Point(365, 403);
            this.lblInvoicedDisplay.Name = "lblInvoicedDisplay";
            this.lblInvoicedDisplay.Size = new System.Drawing.Size(44, 16);
            this.lblInvoicedDisplay.TabIndex = 16;
            this.lblInvoicedDisplay.Text = "label7";
            // 
            // lblInvoicedCaption
            // 
            this.lblInvoicedCaption.AutoSize = true;
            this.lblInvoicedCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoicedCaption.Location = new System.Drawing.Point(129, 403);
            this.lblInvoicedCaption.Name = "lblInvoicedCaption";
            this.lblInvoicedCaption.Size = new System.Drawing.Size(61, 16);
            this.lblInvoicedCaption.TabIndex = 15;
            this.lblInvoicedCaption.Text = "Invoiced:";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(205, 35);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(339, 16);
            this.lblInstructions.TabIndex = 30;
            this.lblInstructions.Text = "Change the desired values and click on Apply Changes:";
            // 
            // lblSelectEmployeePrevious
            // 
            this.lblSelectEmployeePrevious.AutoSize = true;
            this.lblSelectEmployeePrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectEmployeePrevious.Location = new System.Drawing.Point(646, 191);
            this.lblSelectEmployeePrevious.Name = "lblSelectEmployeePrevious";
            this.lblSelectEmployeePrevious.Size = new System.Drawing.Size(44, 16);
            this.lblSelectEmployeePrevious.TabIndex = 32;
            this.lblSelectEmployeePrevious.Text = "label7";
            // 
            // lblSelectClientPrevious
            // 
            this.lblSelectClientPrevious.AutoSize = true;
            this.lblSelectClientPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectClientPrevious.Location = new System.Drawing.Point(646, 137);
            this.lblSelectClientPrevious.Name = "lblSelectClientPrevious";
            this.lblSelectClientPrevious.Size = new System.Drawing.Size(44, 16);
            this.lblSelectClientPrevious.TabIndex = 31;
            this.lblSelectClientPrevious.Text = "label5";
            // 
            // EditWorkRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 553);
            this.Controls.Add(this.lblSelectEmployeePrevious);
            this.Controls.Add(this.lblSelectClientPrevious);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblInvoicedDisplay);
            this.Controls.Add(this.lblInvoicedCaption);
            this.Controls.Add(this.txtTestDescription);
            this.Controls.Add(this.lblTestDescription);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lblDateDueDisplay);
            this.Controls.Add(this.lblDateDueCaption);
            this.Controls.Add(this.lblDateReceivedDisplay);
            this.Controls.Add(this.lblDateReceivedCaption);
            this.Controls.Add(this.lblWRNoDisplay);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.lblSelectEmployee);
            this.Controls.Add(this.lblSelectClient);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.lblWRNoCaption);
            this.Controls.Add(this.msEditWorkRequest);
            this.MainMenuStrip = this.msEditWorkRequest;
            this.Name = "EditWorkRequestForm";
            this.Text = "Edit Work Request";
            this.Load += new System.EventHandler(this.EditWorkRequestForm_Load);
            this.msEditWorkRequest.ResumeLayout(false);
            this.msEditWorkRequest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msEditWorkRequest;
        private System.Windows.Forms.ToolStripMenuItem tsHelp;
        private System.Windows.Forms.Label lblWRNoCaption;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Label lblSelectClient;
        private System.Windows.Forms.Label lblSelectEmployee;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label lblWRNoDisplay;
        private System.Windows.Forms.Label lblDateReceivedDisplay;
        private System.Windows.Forms.Label lblDateReceivedCaption;
        private System.Windows.Forms.Label lblDateDueDisplay;
        private System.Windows.Forms.Label lblDateDueCaption;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtTestDescription;
        private System.Windows.Forms.Label lblTestDescription;
        private System.Windows.Forms.Label lblInvoicedDisplay;
        private System.Windows.Forms.Label lblInvoicedCaption;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblSelectEmployeePrevious;
        private System.Windows.Forms.Label lblSelectClientPrevious;
    }
}