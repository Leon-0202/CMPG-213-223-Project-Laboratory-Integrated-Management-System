
namespace Group_11_Project_LIMS
{
    partial class ReceivePaymentForm
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
            this.msPaymentConfirmation = new System.Windows.Forms.MenuStrip();
            this.tsHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.lblConfirmation = new System.Windows.Forms.Label();
            this.lblAmountPaidDisplay = new System.Windows.Forms.Label();
            this.lblAmountPaidCaption = new System.Windows.Forms.Label();
            this.lblAmountDisplay = new System.Windows.Forms.Label();
            this.lblAmountCaption = new System.Windows.Forms.Label();
            this.lblDatePayableDisplay = new System.Windows.Forms.Label();
            this.lblDatePayableCaption = new System.Windows.Forms.Label();
            this.lblDateInvoicedDisplay = new System.Windows.Forms.Label();
            this.lblDateInvoicedCaption = new System.Windows.Forms.Label();
            this.lblWRNoDisplay = new System.Windows.Forms.Label();
            this.lblWRNoCaption = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReceivePayment = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblInvoiceNoDisplay = new System.Windows.Forms.Label();
            this.lblInvoiceNoCaption = new System.Windows.Forms.Label();
            this.lblAmountDueDisplay = new System.Windows.Forms.Label();
            this.lblAmountDueCaption = new System.Windows.Forms.Label();
            this.msPaymentConfirmation.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPaymentConfirmation
            // 
            this.msPaymentConfirmation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsHelp});
            this.msPaymentConfirmation.Location = new System.Drawing.Point(0, 0);
            this.msPaymentConfirmation.Name = "msPaymentConfirmation";
            this.msPaymentConfirmation.Size = new System.Drawing.Size(879, 24);
            this.msPaymentConfirmation.TabIndex = 0;
            this.msPaymentConfirmation.Text = "menuStrip1";
            // 
            // tsHelp
            // 
            this.tsHelp.Name = "tsHelp";
            this.tsHelp.Size = new System.Drawing.Size(44, 20);
            this.tsHelp.Text = "Help";
            this.tsHelp.Click += new System.EventHandler(this.tsHelp_Click);
            // 
            // lblConfirmation
            // 
            this.lblConfirmation.AutoSize = true;
            this.lblConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmation.Location = new System.Drawing.Point(273, 55);
            this.lblConfirmation.Name = "lblConfirmation";
            this.lblConfirmation.Size = new System.Drawing.Size(256, 16);
            this.lblConfirmation.TabIndex = 40;
            this.lblConfirmation.Text = "Receive payment for the following invoice:";
            // 
            // lblAmountPaidDisplay
            // 
            this.lblAmountPaidDisplay.AutoSize = true;
            this.lblAmountPaidDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountPaidDisplay.Location = new System.Drawing.Point(509, 334);
            this.lblAmountPaidDisplay.Name = "lblAmountPaidDisplay";
            this.lblAmountPaidDisplay.Size = new System.Drawing.Size(44, 16);
            this.lblAmountPaidDisplay.TabIndex = 39;
            this.lblAmountPaidDisplay.Text = "label9";
            // 
            // lblAmountPaidCaption
            // 
            this.lblAmountPaidCaption.AutoSize = true;
            this.lblAmountPaidCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountPaidCaption.Location = new System.Drawing.Point(273, 331);
            this.lblAmountPaidCaption.Name = "lblAmountPaidCaption";
            this.lblAmountPaidCaption.Size = new System.Drawing.Size(86, 16);
            this.lblAmountPaidCaption.TabIndex = 38;
            this.lblAmountPaidCaption.Text = "Amount Paid:";
            // 
            // lblAmountDisplay
            // 
            this.lblAmountDisplay.AutoSize = true;
            this.lblAmountDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountDisplay.Location = new System.Drawing.Point(509, 284);
            this.lblAmountDisplay.Name = "lblAmountDisplay";
            this.lblAmountDisplay.Size = new System.Drawing.Size(44, 16);
            this.lblAmountDisplay.TabIndex = 37;
            this.lblAmountDisplay.Text = "label7";
            // 
            // lblAmountCaption
            // 
            this.lblAmountCaption.AutoSize = true;
            this.lblAmountCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountCaption.Location = new System.Drawing.Point(273, 281);
            this.lblAmountCaption.Name = "lblAmountCaption";
            this.lblAmountCaption.Size = new System.Drawing.Size(145, 16);
            this.lblAmountCaption.TabIndex = 36;
            this.lblAmountCaption.Text = "Amount invoiced + Tax:";
            // 
            // lblDatePayableDisplay
            // 
            this.lblDatePayableDisplay.AutoSize = true;
            this.lblDatePayableDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatePayableDisplay.Location = new System.Drawing.Point(509, 236);
            this.lblDatePayableDisplay.Name = "lblDatePayableDisplay";
            this.lblDatePayableDisplay.Size = new System.Drawing.Size(44, 16);
            this.lblDatePayableDisplay.TabIndex = 35;
            this.lblDatePayableDisplay.Text = "label5";
            // 
            // lblDatePayableCaption
            // 
            this.lblDatePayableCaption.AutoSize = true;
            this.lblDatePayableCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatePayableCaption.Location = new System.Drawing.Point(273, 233);
            this.lblDatePayableCaption.Name = "lblDatePayableCaption";
            this.lblDatePayableCaption.Size = new System.Drawing.Size(93, 16);
            this.lblDatePayableCaption.TabIndex = 34;
            this.lblDatePayableCaption.Text = "Date Payable:";
            // 
            // lblDateInvoicedDisplay
            // 
            this.lblDateInvoicedDisplay.AutoSize = true;
            this.lblDateInvoicedDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateInvoicedDisplay.Location = new System.Drawing.Point(509, 189);
            this.lblDateInvoicedDisplay.Name = "lblDateInvoicedDisplay";
            this.lblDateInvoicedDisplay.Size = new System.Drawing.Size(44, 16);
            this.lblDateInvoicedDisplay.TabIndex = 33;
            this.lblDateInvoicedDisplay.Text = "label3";
            // 
            // lblDateInvoicedCaption
            // 
            this.lblDateInvoicedCaption.AutoSize = true;
            this.lblDateInvoicedCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateInvoicedCaption.Location = new System.Drawing.Point(273, 186);
            this.lblDateInvoicedCaption.Name = "lblDateInvoicedCaption";
            this.lblDateInvoicedCaption.Size = new System.Drawing.Size(93, 16);
            this.lblDateInvoicedCaption.TabIndex = 32;
            this.lblDateInvoicedCaption.Text = "Date Invoiced:";
            // 
            // lblWRNoDisplay
            // 
            this.lblWRNoDisplay.AutoSize = true;
            this.lblWRNoDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWRNoDisplay.Location = new System.Drawing.Point(509, 146);
            this.lblWRNoDisplay.Name = "lblWRNoDisplay";
            this.lblWRNoDisplay.Size = new System.Drawing.Size(44, 16);
            this.lblWRNoDisplay.TabIndex = 31;
            this.lblWRNoDisplay.Text = "label2";
            // 
            // lblWRNoCaption
            // 
            this.lblWRNoCaption.AutoSize = true;
            this.lblWRNoCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWRNoCaption.Location = new System.Drawing.Point(273, 143);
            this.lblWRNoCaption.Name = "lblWRNoCaption";
            this.lblWRNoCaption.Size = new System.Drawing.Size(147, 16);
            this.lblWRNoCaption.TabIndex = 30;
            this.lblWRNoCaption.Text = "Work Request Number:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(500, 489);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 44);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReceivePayment
            // 
            this.btnReceivePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceivePayment.Location = new System.Drawing.Point(327, 489);
            this.btnReceivePayment.Name = "btnReceivePayment";
            this.btnReceivePayment.Size = new System.Drawing.Size(129, 44);
            this.btnReceivePayment.TabIndex = 2;
            this.btnReceivePayment.Text = "Receive Payment";
            this.btnReceivePayment.UseVisualStyleBackColor = true;
            this.btnReceivePayment.Click += new System.EventHandler(this.btnReceivePayment_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(512, 432);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(160, 22);
            this.txtAmount.TabIndex = 1;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(273, 432);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(209, 16);
            this.lblInstruction.TabIndex = 26;
            this.lblInstruction.Text = "Please enter the payment amount:";
            // 
            // lblInvoiceNoDisplay
            // 
            this.lblInvoiceNoDisplay.AutoSize = true;
            this.lblInvoiceNoDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNoDisplay.Location = new System.Drawing.Point(509, 95);
            this.lblInvoiceNoDisplay.Name = "lblInvoiceNoDisplay";
            this.lblInvoiceNoDisplay.Size = new System.Drawing.Size(44, 16);
            this.lblInvoiceNoDisplay.TabIndex = 42;
            this.lblInvoiceNoDisplay.Text = "label2";
            // 
            // lblInvoiceNoCaption
            // 
            this.lblInvoiceNoCaption.AutoSize = true;
            this.lblInvoiceNoCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNoCaption.Location = new System.Drawing.Point(273, 95);
            this.lblInvoiceNoCaption.Name = "lblInvoiceNoCaption";
            this.lblInvoiceNoCaption.Size = new System.Drawing.Size(104, 16);
            this.lblInvoiceNoCaption.TabIndex = 41;
            this.lblInvoiceNoCaption.Text = "Invoice Number:";
            // 
            // lblAmountDueDisplay
            // 
            this.lblAmountDueDisplay.AutoSize = true;
            this.lblAmountDueDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountDueDisplay.Location = new System.Drawing.Point(509, 382);
            this.lblAmountDueDisplay.Name = "lblAmountDueDisplay";
            this.lblAmountDueDisplay.Size = new System.Drawing.Size(44, 16);
            this.lblAmountDueDisplay.TabIndex = 44;
            this.lblAmountDueDisplay.Text = "label9";
            // 
            // lblAmountDueCaption
            // 
            this.lblAmountDueCaption.AutoSize = true;
            this.lblAmountDueCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountDueCaption.Location = new System.Drawing.Point(273, 379);
            this.lblAmountDueCaption.Name = "lblAmountDueCaption";
            this.lblAmountDueCaption.Size = new System.Drawing.Size(83, 16);
            this.lblAmountDueCaption.TabIndex = 43;
            this.lblAmountDueCaption.Text = "Amount Due:";
            // 
            // ReceivePaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 561);
            this.Controls.Add(this.lblAmountDueDisplay);
            this.Controls.Add(this.lblAmountDueCaption);
            this.Controls.Add(this.lblInvoiceNoDisplay);
            this.Controls.Add(this.lblInvoiceNoCaption);
            this.Controls.Add(this.lblConfirmation);
            this.Controls.Add(this.lblAmountPaidDisplay);
            this.Controls.Add(this.lblAmountPaidCaption);
            this.Controls.Add(this.lblAmountDisplay);
            this.Controls.Add(this.lblAmountCaption);
            this.Controls.Add(this.lblDatePayableDisplay);
            this.Controls.Add(this.lblDatePayableCaption);
            this.Controls.Add(this.lblDateInvoicedDisplay);
            this.Controls.Add(this.lblDateInvoicedCaption);
            this.Controls.Add(this.lblWRNoDisplay);
            this.Controls.Add(this.lblWRNoCaption);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReceivePayment);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.msPaymentConfirmation);
            this.MainMenuStrip = this.msPaymentConfirmation;
            this.Name = "ReceivePaymentForm";
            this.Text = "Payment Confirmation";
            this.Load += new System.EventHandler(this.ReceivePaymentForm_Load);
            this.msPaymentConfirmation.ResumeLayout(false);
            this.msPaymentConfirmation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPaymentConfirmation;
        private System.Windows.Forms.ToolStripMenuItem tsHelp;
        private System.Windows.Forms.Label lblConfirmation;
        private System.Windows.Forms.Label lblAmountPaidDisplay;
        private System.Windows.Forms.Label lblAmountPaidCaption;
        private System.Windows.Forms.Label lblAmountDisplay;
        private System.Windows.Forms.Label lblAmountCaption;
        private System.Windows.Forms.Label lblDatePayableDisplay;
        private System.Windows.Forms.Label lblDatePayableCaption;
        private System.Windows.Forms.Label lblDateInvoicedDisplay;
        private System.Windows.Forms.Label lblDateInvoicedCaption;
        private System.Windows.Forms.Label lblWRNoDisplay;
        private System.Windows.Forms.Label lblWRNoCaption;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReceivePayment;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblInvoiceNoDisplay;
        private System.Windows.Forms.Label lblInvoiceNoCaption;
        private System.Windows.Forms.Label lblAmountDueDisplay;
        private System.Windows.Forms.Label lblAmountDueCaption;
    }
}