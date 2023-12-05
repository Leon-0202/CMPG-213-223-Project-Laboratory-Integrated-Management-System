
namespace Group_11_Project_LIMS
{
    partial class InvoiceConfirmationForm
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
            this.msInvoiceConfirmation = new System.Windows.Forms.MenuStrip();
            this.tsHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblConfirmation = new System.Windows.Forms.Label();
            this.lblDateDueDisplay = new System.Windows.Forms.Label();
            this.lblDateDueCaption = new System.Windows.Forms.Label();
            this.lblDateReceivedDisplay = new System.Windows.Forms.Label();
            this.lblDateReceivedCaption = new System.Windows.Forms.Label();
            this.lblEmployeeDisplay = new System.Windows.Forms.Label();
            this.lblEmployeeCaption = new System.Windows.Forms.Label();
            this.lblClientDisplay = new System.Windows.Forms.Label();
            this.lblClientCaption = new System.Windows.Forms.Label();
            this.lblWRNoDisplay = new System.Windows.Forms.Label();
            this.lblWRNoCaption = new System.Windows.Forms.Label();
            this.lblTestDescriptionDisplay = new System.Windows.Forms.Label();
            this.lblTestDescriptionCaption = new System.Windows.Forms.Label();
            this.msInvoiceConfirmation.SuspendLayout();
            this.SuspendLayout();
            // 
            // msInvoiceConfirmation
            // 
            this.msInvoiceConfirmation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsHelp});
            this.msInvoiceConfirmation.Location = new System.Drawing.Point(0, 0);
            this.msInvoiceConfirmation.Name = "msInvoiceConfirmation";
            this.msInvoiceConfirmation.Size = new System.Drawing.Size(875, 24);
            this.msInvoiceConfirmation.TabIndex = 0;
            this.msInvoiceConfirmation.Text = "menuStrip1";
            // 
            // tsHelp
            // 
            this.tsHelp.Name = "tsHelp";
            this.tsHelp.Size = new System.Drawing.Size(44, 20);
            this.tsHelp.Text = "Help";
            this.tsHelp.Click += new System.EventHandler(this.tsHelp_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(251, 425);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(200, 16);
            this.lblAmount.TabIndex = 11;
            this.lblAmount.Text = "Please enter the invoice amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(490, 422);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(160, 22);
            this.txtAmount.TabIndex = 1;
            // 
            // btnInvoice
            // 
            this.btnInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoice.Location = new System.Drawing.Point(280, 495);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(118, 39);
            this.btnInvoice.TabIndex = 2;
            this.btnInvoice.Text = "Invoice";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(453, 495);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 39);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblConfirmation
            // 
            this.lblConfirmation.AutoSize = true;
            this.lblConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmation.Location = new System.Drawing.Point(251, 58);
            this.lblConfirmation.Name = "lblConfirmation";
            this.lblConfirmation.Size = new System.Drawing.Size(379, 16);
            this.lblConfirmation.TabIndex = 25;
            this.lblConfirmation.Text = "Are you sure that you want to invoice the following work request:";
            // 
            // lblDateDueDisplay
            // 
            this.lblDateDueDisplay.AutoSize = true;
            this.lblDateDueDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDueDisplay.Location = new System.Drawing.Point(487, 359);
            this.lblDateDueDisplay.Name = "lblDateDueDisplay";
            this.lblDateDueDisplay.Size = new System.Drawing.Size(44, 16);
            this.lblDateDueDisplay.TabIndex = 24;
            this.lblDateDueDisplay.Text = "label9";
            // 
            // lblDateDueCaption
            // 
            this.lblDateDueCaption.AutoSize = true;
            this.lblDateDueCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDueCaption.Location = new System.Drawing.Point(251, 359);
            this.lblDateDueCaption.Name = "lblDateDueCaption";
            this.lblDateDueCaption.Size = new System.Drawing.Size(67, 16);
            this.lblDateDueCaption.TabIndex = 23;
            this.lblDateDueCaption.Text = "Date Due:";
            // 
            // lblDateReceivedDisplay
            // 
            this.lblDateReceivedDisplay.AutoSize = true;
            this.lblDateReceivedDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReceivedDisplay.Location = new System.Drawing.Point(487, 307);
            this.lblDateReceivedDisplay.Name = "lblDateReceivedDisplay";
            this.lblDateReceivedDisplay.Size = new System.Drawing.Size(44, 16);
            this.lblDateReceivedDisplay.TabIndex = 22;
            this.lblDateReceivedDisplay.Text = "label7";
            // 
            // lblDateReceivedCaption
            // 
            this.lblDateReceivedCaption.AutoSize = true;
            this.lblDateReceivedCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReceivedCaption.Location = new System.Drawing.Point(251, 304);
            this.lblDateReceivedCaption.Name = "lblDateReceivedCaption";
            this.lblDateReceivedCaption.Size = new System.Drawing.Size(101, 16);
            this.lblDateReceivedCaption.TabIndex = 21;
            this.lblDateReceivedCaption.Text = "Date Received:";
            // 
            // lblEmployeeDisplay
            // 
            this.lblEmployeeDisplay.AutoSize = true;
            this.lblEmployeeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeDisplay.Location = new System.Drawing.Point(487, 204);
            this.lblEmployeeDisplay.Name = "lblEmployeeDisplay";
            this.lblEmployeeDisplay.Size = new System.Drawing.Size(44, 16);
            this.lblEmployeeDisplay.TabIndex = 20;
            this.lblEmployeeDisplay.Text = "label5";
            // 
            // lblEmployeeCaption
            // 
            this.lblEmployeeCaption.AutoSize = true;
            this.lblEmployeeCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeCaption.Location = new System.Drawing.Point(251, 201);
            this.lblEmployeeCaption.Name = "lblEmployeeCaption";
            this.lblEmployeeCaption.Size = new System.Drawing.Size(152, 16);
            this.lblEmployeeCaption.TabIndex = 19;
            this.lblEmployeeCaption.Text = "Responsible Employee:";
            // 
            // lblClientDisplay
            // 
            this.lblClientDisplay.AutoSize = true;
            this.lblClientDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientDisplay.Location = new System.Drawing.Point(487, 157);
            this.lblClientDisplay.Name = "lblClientDisplay";
            this.lblClientDisplay.Size = new System.Drawing.Size(44, 16);
            this.lblClientDisplay.TabIndex = 18;
            this.lblClientDisplay.Text = "label3";
            // 
            // lblClientCaption
            // 
            this.lblClientCaption.AutoSize = true;
            this.lblClientCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCaption.Location = new System.Drawing.Point(251, 154);
            this.lblClientCaption.Name = "lblClientCaption";
            this.lblClientCaption.Size = new System.Drawing.Size(43, 16);
            this.lblClientCaption.TabIndex = 17;
            this.lblClientCaption.Text = "Client:";
            // 
            // lblWRNoDisplay
            // 
            this.lblWRNoDisplay.AutoSize = true;
            this.lblWRNoDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWRNoDisplay.Location = new System.Drawing.Point(487, 114);
            this.lblWRNoDisplay.Name = "lblWRNoDisplay";
            this.lblWRNoDisplay.Size = new System.Drawing.Size(44, 16);
            this.lblWRNoDisplay.TabIndex = 16;
            this.lblWRNoDisplay.Text = "label2";
            // 
            // lblWRNoCaption
            // 
            this.lblWRNoCaption.AutoSize = true;
            this.lblWRNoCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWRNoCaption.Location = new System.Drawing.Point(251, 111);
            this.lblWRNoCaption.Name = "lblWRNoCaption";
            this.lblWRNoCaption.Size = new System.Drawing.Size(147, 16);
            this.lblWRNoCaption.TabIndex = 15;
            this.lblWRNoCaption.Text = "Work Request Number:";
            // 
            // lblTestDescriptionDisplay
            // 
            this.lblTestDescriptionDisplay.AutoSize = true;
            this.lblTestDescriptionDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestDescriptionDisplay.Location = new System.Drawing.Point(487, 253);
            this.lblTestDescriptionDisplay.Name = "lblTestDescriptionDisplay";
            this.lblTestDescriptionDisplay.Size = new System.Drawing.Size(44, 16);
            this.lblTestDescriptionDisplay.TabIndex = 27;
            this.lblTestDescriptionDisplay.Text = "label7";
            // 
            // lblTestDescriptionCaption
            // 
            this.lblTestDescriptionCaption.AutoSize = true;
            this.lblTestDescriptionCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestDescriptionCaption.Location = new System.Drawing.Point(251, 250);
            this.lblTestDescriptionCaption.Name = "lblTestDescriptionCaption";
            this.lblTestDescriptionCaption.Size = new System.Drawing.Size(169, 16);
            this.lblTestDescriptionCaption.TabIndex = 26;
            this.lblTestDescriptionCaption.Text = "Analytical Test Description:";
            // 
            // InvoiceConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 567);
            this.Controls.Add(this.lblTestDescriptionDisplay);
            this.Controls.Add(this.lblTestDescriptionCaption);
            this.Controls.Add(this.lblConfirmation);
            this.Controls.Add(this.lblDateDueDisplay);
            this.Controls.Add(this.lblDateDueCaption);
            this.Controls.Add(this.lblDateReceivedDisplay);
            this.Controls.Add(this.lblDateReceivedCaption);
            this.Controls.Add(this.lblEmployeeDisplay);
            this.Controls.Add(this.lblEmployeeCaption);
            this.Controls.Add(this.lblClientDisplay);
            this.Controls.Add(this.lblClientCaption);
            this.Controls.Add(this.lblWRNoDisplay);
            this.Controls.Add(this.lblWRNoCaption);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.msInvoiceConfirmation);
            this.MainMenuStrip = this.msInvoiceConfirmation;
            this.Name = "InvoiceConfirmationForm";
            this.Text = "Invoice Confirmation";
            this.Load += new System.EventHandler(this.InvoiceConfirmationForm_Load);
            this.msInvoiceConfirmation.ResumeLayout(false);
            this.msInvoiceConfirmation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msInvoiceConfirmation;
        private System.Windows.Forms.ToolStripMenuItem tsHelp;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblConfirmation;
        private System.Windows.Forms.Label lblDateDueDisplay;
        private System.Windows.Forms.Label lblDateDueCaption;
        private System.Windows.Forms.Label lblDateReceivedDisplay;
        private System.Windows.Forms.Label lblDateReceivedCaption;
        private System.Windows.Forms.Label lblEmployeeDisplay;
        private System.Windows.Forms.Label lblEmployeeCaption;
        private System.Windows.Forms.Label lblClientDisplay;
        private System.Windows.Forms.Label lblClientCaption;
        private System.Windows.Forms.Label lblWRNoDisplay;
        private System.Windows.Forms.Label lblWRNoCaption;
        private System.Windows.Forms.Label lblTestDescriptionDisplay;
        private System.Windows.Forms.Label lblTestDescriptionCaption;
    }
}