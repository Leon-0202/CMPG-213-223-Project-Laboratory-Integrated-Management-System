
namespace Group_11_Project_LIMS
{
    partial class InvoicesPaymentsForm
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
            this.msInvoicesPayments = new System.Windows.Forms.MenuStrip();
            this.tsHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.lstInvoices = new System.Windows.Forms.ListBox();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.rdoUnpaid = new System.Windows.Forms.RadioButton();
            this.rdoPaid = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnCreateInvoice = new System.Windows.Forms.Button();
            this.btnDisplayInvoice = new System.Windows.Forms.Button();
            this.btnReceivePayment = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.gpRadioButtons = new System.Windows.Forms.GroupBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.msInvoicesPayments.SuspendLayout();
            this.gpRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // msInvoicesPayments
            // 
            this.msInvoicesPayments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsHelp});
            this.msInvoicesPayments.Location = new System.Drawing.Point(0, 0);
            this.msInvoicesPayments.Name = "msInvoicesPayments";
            this.msInvoicesPayments.Size = new System.Drawing.Size(1432, 24);
            this.msInvoicesPayments.TabIndex = 0;
            this.msInvoicesPayments.Text = "menuStrip1";
            // 
            // tsHelp
            // 
            this.tsHelp.Name = "tsHelp";
            this.tsHelp.Size = new System.Drawing.Size(44, 20);
            this.tsHelp.Text = "Help";
            this.tsHelp.Click += new System.EventHandler(this.tsHelp_Click);
            // 
            // lstInvoices
            // 
            this.lstInvoices.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInvoices.FormattingEnabled = true;
            this.lstInvoices.ItemHeight = 15;
            this.lstInvoices.Location = new System.Drawing.Point(41, 91);
            this.lstInvoices.Name = "lstInvoices";
            this.lstInvoices.Size = new System.Drawing.Size(1132, 439);
            this.lstInvoices.TabIndex = 2;
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAll.Location = new System.Drawing.Point(19, 21);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(40, 20);
            this.rdoAll.TabIndex = 2;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "All";
            this.rdoAll.UseVisualStyleBackColor = true;
            this.rdoAll.CheckedChanged += new System.EventHandler(this.rdoAll_CheckedChanged);
            // 
            // rdoUnpaid
            // 
            this.rdoUnpaid.AutoSize = true;
            this.rdoUnpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoUnpaid.Location = new System.Drawing.Point(197, 21);
            this.rdoUnpaid.Name = "rdoUnpaid";
            this.rdoUnpaid.Size = new System.Drawing.Size(69, 20);
            this.rdoUnpaid.TabIndex = 3;
            this.rdoUnpaid.TabStop = true;
            this.rdoUnpaid.Text = "Unpaid";
            this.rdoUnpaid.UseVisualStyleBackColor = true;
            this.rdoUnpaid.CheckedChanged += new System.EventHandler(this.rdoAll_CheckedChanged);
            // 
            // rdoPaid
            // 
            this.rdoPaid.AutoSize = true;
            this.rdoPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPaid.Location = new System.Drawing.Point(386, 21);
            this.rdoPaid.Name = "rdoPaid";
            this.rdoPaid.Size = new System.Drawing.Size(53, 20);
            this.rdoPaid.TabIndex = 4;
            this.rdoPaid.TabStop = true;
            this.rdoPaid.Text = "Paid";
            this.rdoPaid.UseVisualStyleBackColor = true;
            this.rdoPaid.CheckedChanged += new System.EventHandler(this.rdoAll_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(1214, 124);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(178, 22);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnCreateInvoice
            // 
            this.btnCreateInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateInvoice.Location = new System.Drawing.Point(1214, 270);
            this.btnCreateInvoice.Name = "btnCreateInvoice";
            this.btnCreateInvoice.Size = new System.Drawing.Size(178, 41);
            this.btnCreateInvoice.TabIndex = 5;
            this.btnCreateInvoice.Text = "Invoice a Work Request";
            this.btnCreateInvoice.UseVisualStyleBackColor = true;
            this.btnCreateInvoice.Click += new System.EventHandler(this.btnCreateInvoice_Click);
            // 
            // btnDisplayInvoice
            // 
            this.btnDisplayInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayInvoice.Location = new System.Drawing.Point(1214, 191);
            this.btnDisplayInvoice.Name = "btnDisplayInvoice";
            this.btnDisplayInvoice.Size = new System.Drawing.Size(178, 41);
            this.btnDisplayInvoice.TabIndex = 4;
            this.btnDisplayInvoice.Text = "Display Selected Invoice";
            this.btnDisplayInvoice.UseVisualStyleBackColor = true;
            this.btnDisplayInvoice.Click += new System.EventHandler(this.btnDisplayInvoice_Click);
            // 
            // btnReceivePayment
            // 
            this.btnReceivePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceivePayment.Location = new System.Drawing.Point(1214, 348);
            this.btnReceivePayment.Name = "btnReceivePayment";
            this.btnReceivePayment.Size = new System.Drawing.Size(178, 41);
            this.btnReceivePayment.TabIndex = 6;
            this.btnReceivePayment.Text = "Receive Payment";
            this.btnReceivePayment.UseVisualStyleBackColor = true;
            this.btnReceivePayment.Click += new System.EventHandler(this.btnReceivePayment_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1214, 489);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(178, 41);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gpRadioButtons
            // 
            this.gpRadioButtons.Controls.Add(this.rdoPaid);
            this.gpRadioButtons.Controls.Add(this.rdoAll);
            this.gpRadioButtons.Controls.Add(this.rdoUnpaid);
            this.gpRadioButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpRadioButtons.Location = new System.Drawing.Point(41, 28);
            this.gpRadioButtons.Name = "gpRadioButtons";
            this.gpRadioButtons.Size = new System.Drawing.Size(469, 57);
            this.gpRadioButtons.TabIndex = 1;
            this.gpRadioButtons.TabStop = false;
            this.gpRadioButtons.Text = "Display Invoices";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(1211, 91);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(158, 16);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Search (Invoice Number):";
            // 
            // InvoicesPaymentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 576);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.gpRadioButtons);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReceivePayment);
            this.Controls.Add(this.btnDisplayInvoice);
            this.Controls.Add(this.btnCreateInvoice);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstInvoices);
            this.Controls.Add(this.msInvoicesPayments);
            this.MainMenuStrip = this.msInvoicesPayments;
            this.Name = "InvoicesPaymentsForm";
            this.Text = "Invoices and Payments";
            this.Load += new System.EventHandler(this.InvoicesPaymentsForm_Load);
            this.msInvoicesPayments.ResumeLayout(false);
            this.msInvoicesPayments.PerformLayout();
            this.gpRadioButtons.ResumeLayout(false);
            this.gpRadioButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msInvoicesPayments;
        private System.Windows.Forms.ToolStripMenuItem tsHelp;
        private System.Windows.Forms.ListBox lstInvoices;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.RadioButton rdoUnpaid;
        private System.Windows.Forms.RadioButton rdoPaid;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnCreateInvoice;
        private System.Windows.Forms.Button btnDisplayInvoice;
        private System.Windows.Forms.Button btnReceivePayment;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox gpRadioButtons;
        private System.Windows.Forms.Label lblSearch;
    }
}