namespace Group_11_Project_LIMS
{
    partial class DisplayInvoice
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
            this.lblFirstPage = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDateTimeIssued = new System.Windows.Forms.Label();
            this.lblInvoiceNoCaption = new System.Windows.Forms.Label();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.lblDatePayableDisplay = new System.Windows.Forms.Label();
            this.lblDatePayableCaption = new System.Windows.Forms.Label();
            this.lblDateInvoicedDisplay = new System.Windows.Forms.Label();
            this.lblDateInvoicedCaption = new System.Windows.Forms.Label();
            this.lblWorkRequestNoDisplay = new System.Windows.Forms.Label();
            this.lblWorkRequestNoCaption = new System.Windows.Forms.Label();
            this.lblInvoiceNoDisplay = new System.Windows.Forms.Label();
            this.gbPricing = new System.Windows.Forms.GroupBox();
            this.lblAmountDueDisplay = new System.Windows.Forms.Label();
            this.lblAmountDueCaption = new System.Windows.Forms.Label();
            this.lblAmountInvoicedCaption = new System.Windows.Forms.Label();
            this.lblTotalTaxDisplay = new System.Windows.Forms.Label();
            this.lblTotalTaxCaption = new System.Windows.Forms.Label();
            this.lblTaxRateDisplay = new System.Windows.Forms.Label();
            this.lblTaxRateCaption = new System.Windows.Forms.Label();
            this.lblAmountInvoicedDisplay = new System.Windows.Forms.Label();
            this.lblTestDescription = new System.Windows.Forms.Label();
            this.gbBillInfo = new System.Windows.Forms.GroupBox();
            this.lblEmailCaption = new System.Windows.Forms.Label();
            this.lblContactNoCaption = new System.Windows.Forms.Label();
            this.lblEmailDisplay = new System.Windows.Forms.Label();
            this.lblContactNoDisplay = new System.Windows.Forms.Label();
            this.lblAddressCityCaption = new System.Windows.Forms.Label();
            this.lblAddressCityDisplay = new System.Windows.Forms.Label();
            this.lblAddressStreetCaption = new System.Windows.Forms.Label();
            this.lblAddressStreetDisplay = new System.Windows.Forms.Label();
            this.lblAddressNoCaption = new System.Windows.Forms.Label();
            this.lblAddressNoDisplay = new System.Windows.Forms.Label();
            this.lblClientNameDisplay = new System.Windows.Forms.Label();
            this.lblClientNameCaption = new System.Windows.Forms.Label();
            this.lblPageBreakdown = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbDetails.SuspendLayout();
            this.gbPricing.SuspendLayout();
            this.gbBillInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstPage
            // 
            this.lblFirstPage.AutoSize = true;
            this.lblFirstPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstPage.Location = new System.Drawing.Point(922, 9);
            this.lblFirstPage.Name = "lblFirstPage";
            this.lblFirstPage.Size = new System.Drawing.Size(53, 16);
            this.lblFirstPage.TabIndex = 5;
            this.lblFirstPage.Text = "Page: 1";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(465, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(66, 20);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Invoice";
            // 
            // lblDateTimeIssued
            // 
            this.lblDateTimeIssued.AutoSize = true;
            this.lblDateTimeIssued.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTimeIssued.Location = new System.Drawing.Point(12, 9);
            this.lblDateTimeIssued.Name = "lblDateTimeIssued";
            this.lblDateTimeIssued.Size = new System.Drawing.Size(44, 16);
            this.lblDateTimeIssued.TabIndex = 3;
            this.lblDateTimeIssued.Text = "label1";
            // 
            // lblInvoiceNoCaption
            // 
            this.lblInvoiceNoCaption.AutoSize = true;
            this.lblInvoiceNoCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNoCaption.Location = new System.Drawing.Point(6, 32);
            this.lblInvoiceNoCaption.Name = "lblInvoiceNoCaption";
            this.lblInvoiceNoCaption.Size = new System.Drawing.Size(104, 16);
            this.lblInvoiceNoCaption.TabIndex = 6;
            this.lblInvoiceNoCaption.Text = "Invoice Number:";
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.lblDatePayableDisplay);
            this.gbDetails.Controls.Add(this.lblDatePayableCaption);
            this.gbDetails.Controls.Add(this.lblDateInvoicedDisplay);
            this.gbDetails.Controls.Add(this.lblDateInvoicedCaption);
            this.gbDetails.Controls.Add(this.lblWorkRequestNoDisplay);
            this.gbDetails.Controls.Add(this.lblWorkRequestNoCaption);
            this.gbDetails.Controls.Add(this.lblInvoiceNoDisplay);
            this.gbDetails.Controls.Add(this.lblInvoiceNoCaption);
            this.gbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.Location = new System.Drawing.Point(15, 53);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(476, 202);
            this.gbDetails.TabIndex = 7;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details:";
            // 
            // lblDatePayableDisplay
            // 
            this.lblDatePayableDisplay.AutoSize = true;
            this.lblDatePayableDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatePayableDisplay.Location = new System.Drawing.Point(241, 164);
            this.lblDatePayableDisplay.Name = "lblDatePayableDisplay";
            this.lblDatePayableDisplay.Size = new System.Drawing.Size(37, 16);
            this.lblDatePayableDisplay.TabIndex = 13;
            this.lblDatePayableDisplay.Text = "label";
            // 
            // lblDatePayableCaption
            // 
            this.lblDatePayableCaption.AutoSize = true;
            this.lblDatePayableCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatePayableCaption.Location = new System.Drawing.Point(6, 164);
            this.lblDatePayableCaption.Name = "lblDatePayableCaption";
            this.lblDatePayableCaption.Size = new System.Drawing.Size(93, 16);
            this.lblDatePayableCaption.TabIndex = 12;
            this.lblDatePayableCaption.Text = "Date Payable:";
            // 
            // lblDateInvoicedDisplay
            // 
            this.lblDateInvoicedDisplay.AutoSize = true;
            this.lblDateInvoicedDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateInvoicedDisplay.Location = new System.Drawing.Point(241, 119);
            this.lblDateInvoicedDisplay.Name = "lblDateInvoicedDisplay";
            this.lblDateInvoicedDisplay.Size = new System.Drawing.Size(37, 16);
            this.lblDateInvoicedDisplay.TabIndex = 11;
            this.lblDateInvoicedDisplay.Text = "label";
            // 
            // lblDateInvoicedCaption
            // 
            this.lblDateInvoicedCaption.AutoSize = true;
            this.lblDateInvoicedCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateInvoicedCaption.Location = new System.Drawing.Point(6, 119);
            this.lblDateInvoicedCaption.Name = "lblDateInvoicedCaption";
            this.lblDateInvoicedCaption.Size = new System.Drawing.Size(93, 16);
            this.lblDateInvoicedCaption.TabIndex = 10;
            this.lblDateInvoicedCaption.Text = "Date Invoiced:";
            // 
            // lblWorkRequestNoDisplay
            // 
            this.lblWorkRequestNoDisplay.AutoSize = true;
            this.lblWorkRequestNoDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkRequestNoDisplay.Location = new System.Drawing.Point(241, 75);
            this.lblWorkRequestNoDisplay.Name = "lblWorkRequestNoDisplay";
            this.lblWorkRequestNoDisplay.Size = new System.Drawing.Size(37, 16);
            this.lblWorkRequestNoDisplay.TabIndex = 9;
            this.lblWorkRequestNoDisplay.Text = "label";
            // 
            // lblWorkRequestNoCaption
            // 
            this.lblWorkRequestNoCaption.AutoSize = true;
            this.lblWorkRequestNoCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkRequestNoCaption.Location = new System.Drawing.Point(6, 75);
            this.lblWorkRequestNoCaption.Name = "lblWorkRequestNoCaption";
            this.lblWorkRequestNoCaption.Size = new System.Drawing.Size(147, 16);
            this.lblWorkRequestNoCaption.TabIndex = 8;
            this.lblWorkRequestNoCaption.Text = "Work Request Number:";
            // 
            // lblInvoiceNoDisplay
            // 
            this.lblInvoiceNoDisplay.AutoSize = true;
            this.lblInvoiceNoDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNoDisplay.Location = new System.Drawing.Point(241, 32);
            this.lblInvoiceNoDisplay.Name = "lblInvoiceNoDisplay";
            this.lblInvoiceNoDisplay.Size = new System.Drawing.Size(37, 16);
            this.lblInvoiceNoDisplay.TabIndex = 7;
            this.lblInvoiceNoDisplay.Text = "label";
            // 
            // gbPricing
            // 
            this.gbPricing.Controls.Add(this.lblAmountDueDisplay);
            this.gbPricing.Controls.Add(this.lblAmountDueCaption);
            this.gbPricing.Controls.Add(this.lblAmountInvoicedCaption);
            this.gbPricing.Controls.Add(this.lblTotalTaxDisplay);
            this.gbPricing.Controls.Add(this.lblTotalTaxCaption);
            this.gbPricing.Controls.Add(this.lblTaxRateDisplay);
            this.gbPricing.Controls.Add(this.lblTaxRateCaption);
            this.gbPricing.Controls.Add(this.lblAmountInvoicedDisplay);
            this.gbPricing.Controls.Add(this.lblTestDescription);
            this.gbPricing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPricing.Location = new System.Drawing.Point(24, 376);
            this.gbPricing.Name = "gbPricing";
            this.gbPricing.Size = new System.Drawing.Size(951, 209);
            this.gbPricing.TabIndex = 8;
            this.gbPricing.TabStop = false;
            this.gbPricing.Text = "Pricing Details:";
            // 
            // lblAmountDueDisplay
            // 
            this.lblAmountDueDisplay.AutoSize = true;
            this.lblAmountDueDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountDueDisplay.Location = new System.Drawing.Point(799, 159);
            this.lblAmountDueDisplay.Name = "lblAmountDueDisplay";
            this.lblAmountDueDisplay.Size = new System.Drawing.Size(42, 16);
            this.lblAmountDueDisplay.TabIndex = 14;
            this.lblAmountDueDisplay.Text = "label";
            this.lblAmountDueDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmountDueCaption
            // 
            this.lblAmountDueCaption.AutoSize = true;
            this.lblAmountDueCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountDueCaption.Location = new System.Drawing.Point(609, 159);
            this.lblAmountDueCaption.Name = "lblAmountDueCaption";
            this.lblAmountDueCaption.Size = new System.Drawing.Size(134, 16);
            this.lblAmountDueCaption.TabIndex = 13;
            this.lblAmountDueCaption.Text = "Total Amount Due:";
            // 
            // lblAmountInvoicedCaption
            // 
            this.lblAmountInvoicedCaption.AutoSize = true;
            this.lblAmountInvoicedCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountInvoicedCaption.Location = new System.Drawing.Point(609, 33);
            this.lblAmountInvoicedCaption.Name = "lblAmountInvoicedCaption";
            this.lblAmountInvoicedCaption.Size = new System.Drawing.Size(34, 16);
            this.lblAmountInvoicedCaption.TabIndex = 12;
            this.lblAmountInvoicedCaption.Text = "Cost";
            // 
            // lblTotalTaxDisplay
            // 
            this.lblTotalTaxDisplay.AutoSize = true;
            this.lblTotalTaxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTaxDisplay.Location = new System.Drawing.Point(799, 116);
            this.lblTotalTaxDisplay.Name = "lblTotalTaxDisplay";
            this.lblTotalTaxDisplay.Size = new System.Drawing.Size(37, 16);
            this.lblTotalTaxDisplay.TabIndex = 11;
            this.lblTotalTaxDisplay.Text = "label";
            this.lblTotalTaxDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalTaxCaption
            // 
            this.lblTotalTaxCaption.AutoSize = true;
            this.lblTotalTaxCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTaxCaption.Location = new System.Drawing.Point(609, 116);
            this.lblTotalTaxCaption.Name = "lblTotalTaxCaption";
            this.lblTotalTaxCaption.Size = new System.Drawing.Size(67, 16);
            this.lblTotalTaxCaption.TabIndex = 10;
            this.lblTotalTaxCaption.Text = "Total Tax:";
            // 
            // lblTaxRateDisplay
            // 
            this.lblTaxRateDisplay.AutoSize = true;
            this.lblTaxRateDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxRateDisplay.Location = new System.Drawing.Point(799, 75);
            this.lblTaxRateDisplay.Name = "lblTaxRateDisplay";
            this.lblTaxRateDisplay.Size = new System.Drawing.Size(33, 16);
            this.lblTaxRateDisplay.TabIndex = 9;
            this.lblTaxRateDisplay.Text = "15%";
            // 
            // lblTaxRateCaption
            // 
            this.lblTaxRateCaption.AutoSize = true;
            this.lblTaxRateCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxRateCaption.Location = new System.Drawing.Point(609, 75);
            this.lblTaxRateCaption.Name = "lblTaxRateCaption";
            this.lblTaxRateCaption.Size = new System.Drawing.Size(65, 16);
            this.lblTaxRateCaption.TabIndex = 8;
            this.lblTaxRateCaption.Text = "Tax Rate:";
            // 
            // lblAmountInvoicedDisplay
            // 
            this.lblAmountInvoicedDisplay.AutoSize = true;
            this.lblAmountInvoicedDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountInvoicedDisplay.Location = new System.Drawing.Point(799, 33);
            this.lblAmountInvoicedDisplay.Name = "lblAmountInvoicedDisplay";
            this.lblAmountInvoicedDisplay.Size = new System.Drawing.Size(44, 16);
            this.lblAmountInvoicedDisplay.TabIndex = 7;
            this.lblAmountInvoicedDisplay.Text = "label2";
            this.lblAmountInvoicedDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTestDescription
            // 
            this.lblTestDescription.AutoSize = true;
            this.lblTestDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestDescription.Location = new System.Drawing.Point(6, 33);
            this.lblTestDescription.Name = "lblTestDescription";
            this.lblTestDescription.Size = new System.Drawing.Size(44, 16);
            this.lblTestDescription.TabIndex = 6;
            this.lblTestDescription.Text = "label2";
            // 
            // gbBillInfo
            // 
            this.gbBillInfo.Controls.Add(this.lblEmailCaption);
            this.gbBillInfo.Controls.Add(this.lblContactNoCaption);
            this.gbBillInfo.Controls.Add(this.lblEmailDisplay);
            this.gbBillInfo.Controls.Add(this.lblContactNoDisplay);
            this.gbBillInfo.Controls.Add(this.lblAddressCityCaption);
            this.gbBillInfo.Controls.Add(this.lblAddressCityDisplay);
            this.gbBillInfo.Controls.Add(this.lblAddressStreetCaption);
            this.gbBillInfo.Controls.Add(this.lblAddressStreetDisplay);
            this.gbBillInfo.Controls.Add(this.lblAddressNoCaption);
            this.gbBillInfo.Controls.Add(this.lblAddressNoDisplay);
            this.gbBillInfo.Controls.Add(this.lblClientNameDisplay);
            this.gbBillInfo.Controls.Add(this.lblClientNameCaption);
            this.gbBillInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBillInfo.Location = new System.Drawing.Point(510, 53);
            this.gbBillInfo.Name = "gbBillInfo";
            this.gbBillInfo.Size = new System.Drawing.Size(465, 301);
            this.gbBillInfo.TabIndex = 14;
            this.gbBillInfo.TabStop = false;
            this.gbBillInfo.Text = "Bill to:";
            // 
            // lblEmailCaption
            // 
            this.lblEmailCaption.AutoSize = true;
            this.lblEmailCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCaption.Location = new System.Drawing.Point(6, 119);
            this.lblEmailCaption.Name = "lblEmailCaption";
            this.lblEmailCaption.Size = new System.Drawing.Size(98, 16);
            this.lblEmailCaption.TabIndex = 32;
            this.lblEmailCaption.Text = "Email Address:";
            // 
            // lblContactNoCaption
            // 
            this.lblContactNoCaption.AutoSize = true;
            this.lblContactNoCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNoCaption.Location = new System.Drawing.Point(6, 75);
            this.lblContactNoCaption.Name = "lblContactNoCaption";
            this.lblContactNoCaption.Size = new System.Drawing.Size(106, 16);
            this.lblContactNoCaption.TabIndex = 31;
            this.lblContactNoCaption.Text = "Contact Number:";
            // 
            // lblEmailDisplay
            // 
            this.lblEmailDisplay.AutoSize = true;
            this.lblEmailDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailDisplay.Location = new System.Drawing.Point(212, 119);
            this.lblEmailDisplay.Name = "lblEmailDisplay";
            this.lblEmailDisplay.Size = new System.Drawing.Size(51, 16);
            this.lblEmailDisplay.TabIndex = 30;
            this.lblEmailDisplay.Text = "label10";
            // 
            // lblContactNoDisplay
            // 
            this.lblContactNoDisplay.AutoSize = true;
            this.lblContactNoDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNoDisplay.Location = new System.Drawing.Point(212, 75);
            this.lblContactNoDisplay.Name = "lblContactNoDisplay";
            this.lblContactNoDisplay.Size = new System.Drawing.Size(44, 16);
            this.lblContactNoDisplay.TabIndex = 29;
            this.lblContactNoDisplay.Text = "label8";
            // 
            // lblAddressCityCaption
            // 
            this.lblAddressCityCaption.AutoSize = true;
            this.lblAddressCityCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressCityCaption.Location = new System.Drawing.Point(6, 253);
            this.lblAddressCityCaption.Name = "lblAddressCityCaption";
            this.lblAddressCityCaption.Size = new System.Drawing.Size(125, 16);
            this.lblAddressCityCaption.TabIndex = 26;
            this.lblAddressCityCaption.Text = "Billing Address City:";
            // 
            // lblAddressCityDisplay
            // 
            this.lblAddressCityDisplay.AutoSize = true;
            this.lblAddressCityDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressCityDisplay.Location = new System.Drawing.Point(212, 253);
            this.lblAddressCityDisplay.Name = "lblAddressCityDisplay";
            this.lblAddressCityDisplay.Size = new System.Drawing.Size(37, 16);
            this.lblAddressCityDisplay.TabIndex = 13;
            this.lblAddressCityDisplay.Text = "label";
            // 
            // lblAddressStreetCaption
            // 
            this.lblAddressStreetCaption.AutoSize = true;
            this.lblAddressStreetCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressStreetCaption.Location = new System.Drawing.Point(6, 208);
            this.lblAddressStreetCaption.Name = "lblAddressStreetCaption";
            this.lblAddressStreetCaption.Size = new System.Drawing.Size(138, 16);
            this.lblAddressStreetCaption.TabIndex = 25;
            this.lblAddressStreetCaption.Text = "Billing Address Street:";
            // 
            // lblAddressStreetDisplay
            // 
            this.lblAddressStreetDisplay.AutoSize = true;
            this.lblAddressStreetDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressStreetDisplay.Location = new System.Drawing.Point(212, 208);
            this.lblAddressStreetDisplay.Name = "lblAddressStreetDisplay";
            this.lblAddressStreetDisplay.Size = new System.Drawing.Size(37, 16);
            this.lblAddressStreetDisplay.TabIndex = 11;
            this.lblAddressStreetDisplay.Text = "label";
            // 
            // lblAddressNoCaption
            // 
            this.lblAddressNoCaption.AutoSize = true;
            this.lblAddressNoCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressNoCaption.Location = new System.Drawing.Point(6, 164);
            this.lblAddressNoCaption.Name = "lblAddressNoCaption";
            this.lblAddressNoCaption.Size = new System.Drawing.Size(151, 16);
            this.lblAddressNoCaption.TabIndex = 24;
            this.lblAddressNoCaption.Text = "Billing Address Number:";
            // 
            // lblAddressNoDisplay
            // 
            this.lblAddressNoDisplay.AutoSize = true;
            this.lblAddressNoDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressNoDisplay.Location = new System.Drawing.Point(212, 164);
            this.lblAddressNoDisplay.Name = "lblAddressNoDisplay";
            this.lblAddressNoDisplay.Size = new System.Drawing.Size(37, 16);
            this.lblAddressNoDisplay.TabIndex = 9;
            this.lblAddressNoDisplay.Text = "label";
            // 
            // lblClientNameDisplay
            // 
            this.lblClientNameDisplay.AutoSize = true;
            this.lblClientNameDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientNameDisplay.Location = new System.Drawing.Point(212, 32);
            this.lblClientNameDisplay.Name = "lblClientNameDisplay";
            this.lblClientNameDisplay.Size = new System.Drawing.Size(37, 16);
            this.lblClientNameDisplay.TabIndex = 7;
            this.lblClientNameDisplay.Text = "label";
            // 
            // lblClientNameCaption
            // 
            this.lblClientNameCaption.AutoSize = true;
            this.lblClientNameCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientNameCaption.Location = new System.Drawing.Point(6, 32);
            this.lblClientNameCaption.Name = "lblClientNameCaption";
            this.lblClientNameCaption.Size = new System.Drawing.Size(83, 16);
            this.lblClientNameCaption.TabIndex = 6;
            this.lblClientNameCaption.Text = "Client Name:";
            // 
            // lblPageBreakdown
            // 
            this.lblPageBreakdown.AutoSize = true;
            this.lblPageBreakdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageBreakdown.Location = new System.Drawing.Point(898, 637);
            this.lblPageBreakdown.Name = "lblPageBreakdown";
            this.lblPageBreakdown.Size = new System.Drawing.Size(77, 16);
            this.lblPageBreakdown.TabIndex = 15;
            this.lblPageBreakdown.Text = "Page: 1 of 1";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(429, 604);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(148, 48);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DisplayInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 685);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPageBreakdown);
            this.Controls.Add(this.gbBillInfo);
            this.Controls.Add(this.gbPricing);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.lblFirstPage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDateTimeIssued);
            this.Name = "DisplayInvoice";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.DisplayInvoice_Load);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.gbPricing.ResumeLayout(false);
            this.gbPricing.PerformLayout();
            this.gbBillInfo.ResumeLayout(false);
            this.gbBillInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstPage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDateTimeIssued;
        private System.Windows.Forms.Label lblInvoiceNoCaption;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.GroupBox gbPricing;
        private System.Windows.Forms.Label lblTestDescription;
        private System.Windows.Forms.Label lblInvoiceNoDisplay;
        private System.Windows.Forms.Label lblDateInvoicedDisplay;
        private System.Windows.Forms.Label lblDateInvoicedCaption;
        private System.Windows.Forms.Label lblWorkRequestNoDisplay;
        private System.Windows.Forms.Label lblWorkRequestNoCaption;
        private System.Windows.Forms.Label lblDatePayableDisplay;
        private System.Windows.Forms.Label lblDatePayableCaption;
        private System.Windows.Forms.GroupBox gbBillInfo;
        private System.Windows.Forms.Label lblAddressCityDisplay;
        private System.Windows.Forms.Label lblAddressStreetDisplay;
        private System.Windows.Forms.Label lblAddressNoDisplay;
        private System.Windows.Forms.Label lblClientNameDisplay;
        private System.Windows.Forms.Label lblClientNameCaption;
        private System.Windows.Forms.Label lblAddressCityCaption;
        private System.Windows.Forms.Label lblAddressStreetCaption;
        private System.Windows.Forms.Label lblAddressNoCaption;
        private System.Windows.Forms.Label lblAmountInvoicedCaption;
        private System.Windows.Forms.Label lblTotalTaxDisplay;
        private System.Windows.Forms.Label lblTotalTaxCaption;
        private System.Windows.Forms.Label lblTaxRateDisplay;
        private System.Windows.Forms.Label lblTaxRateCaption;
        private System.Windows.Forms.Label lblAmountInvoicedDisplay;
        private System.Windows.Forms.Label lblAmountDueDisplay;
        private System.Windows.Forms.Label lblAmountDueCaption;
        private System.Windows.Forms.Label lblPageBreakdown;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblEmailCaption;
        private System.Windows.Forms.Label lblContactNoCaption;
        private System.Windows.Forms.Label lblEmailDisplay;
        private System.Windows.Forms.Label lblContactNoDisplay;
    }
}