
namespace Group_11_Project_LIMS
{
    partial class InvoiceWorkRequestForm
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
            this.msInvoiceWorkRequest = new System.Windows.Forms.MenuStrip();
            this.tsHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.lstWorkRequests = new System.Windows.Forms.ListBox();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.msInvoiceWorkRequest.SuspendLayout();
            this.SuspendLayout();
            // 
            // msInvoiceWorkRequest
            // 
            this.msInvoiceWorkRequest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsHelp});
            this.msInvoiceWorkRequest.Location = new System.Drawing.Point(0, 0);
            this.msInvoiceWorkRequest.Name = "msInvoiceWorkRequest";
            this.msInvoiceWorkRequest.Size = new System.Drawing.Size(1390, 24);
            this.msInvoiceWorkRequest.TabIndex = 0;
            this.msInvoiceWorkRequest.Text = "menuStrip1";
            // 
            // tsHelp
            // 
            this.tsHelp.Name = "tsHelp";
            this.tsHelp.Size = new System.Drawing.Size(44, 20);
            this.tsHelp.Text = "Help";
            this.tsHelp.Click += new System.EventHandler(this.tsHelp_Click);
            // 
            // lstWorkRequests
            // 
            this.lstWorkRequests.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstWorkRequests.FormattingEnabled = true;
            this.lstWorkRequests.ItemHeight = 15;
            this.lstWorkRequests.Location = new System.Drawing.Point(45, 47);
            this.lstWorkRequests.Name = "lstWorkRequests";
            this.lstWorkRequests.Size = new System.Drawing.Size(1032, 484);
            this.lstWorkRequests.TabIndex = 1;
            // 
            // btnInvoice
            // 
            this.btnInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoice.Location = new System.Drawing.Point(1125, 133);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(184, 48);
            this.btnInvoice.TabIndex = 3;
            this.btnInvoice.Text = "Invoice Selected Work Request";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1125, 493);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(184, 38);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(1122, 47);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(201, 16);
            this.lblSearch.TabIndex = 9;
            this.lblSearch.Text = "Search (Work Request Number):";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(1125, 73);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(184, 23);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // InvoiceWorkRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 557);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.lstWorkRequests);
            this.Controls.Add(this.msInvoiceWorkRequest);
            this.MainMenuStrip = this.msInvoiceWorkRequest;
            this.Name = "InvoiceWorkRequestForm";
            this.Text = "Invoice Work Request";
            this.Load += new System.EventHandler(this.InvoiceWorkRequestForm_Load);
            this.msInvoiceWorkRequest.ResumeLayout(false);
            this.msInvoiceWorkRequest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msInvoiceWorkRequest;
        private System.Windows.Forms.ToolStripMenuItem tsHelp;
        private System.Windows.Forms.ListBox lstWorkRequests;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}