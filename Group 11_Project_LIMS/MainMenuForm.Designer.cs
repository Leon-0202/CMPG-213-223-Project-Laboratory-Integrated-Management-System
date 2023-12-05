
namespace Group_11_Project_LIMS
{
    partial class MainMenuForm
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
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.tsAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.btnWorkRequests = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnInvoicesPayments = new System.Windows.Forms.Button();
            this.lblUserCaption = new System.Windows.Forms.Label();
            this.lblUserDisplay = new System.Windows.Forms.Label();
            this.lblRoleDisplay = new System.Windows.Forms.Label();
            this.lblRoleCaption = new System.Windows.Forms.Label();
            this.msMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAccount,
            this.tsHelp});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(910, 24);
            this.msMainMenu.TabIndex = 0;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // tsAccount
            // 
            this.tsAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLogout});
            this.tsAccount.Name = "tsAccount";
            this.tsAccount.Size = new System.Drawing.Size(64, 20);
            this.tsAccount.Text = "Account";
            // 
            // tsLogout
            // 
            this.tsLogout.Name = "tsLogout";
            this.tsLogout.Size = new System.Drawing.Size(115, 22);
            this.tsLogout.Text = "Log out";
            this.tsLogout.Click += new System.EventHandler(this.tsLogout_Click);
            // 
            // tsHelp
            // 
            this.tsHelp.Name = "tsHelp";
            this.tsHelp.Size = new System.Drawing.Size(44, 20);
            this.tsHelp.Text = "Help";
            this.tsHelp.Click += new System.EventHandler(this.tsHelp_Click);
            // 
            // btnWorkRequests
            // 
            this.btnWorkRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkRequests.Location = new System.Drawing.Point(336, 123);
            this.btnWorkRequests.Name = "btnWorkRequests";
            this.btnWorkRequests.Size = new System.Drawing.Size(190, 41);
            this.btnWorkRequests.TabIndex = 1;
            this.btnWorkRequests.Text = "Work Requests";
            this.btnWorkRequests.UseVisualStyleBackColor = true;
            this.btnWorkRequests.Click += new System.EventHandler(this.btnWorkRequests_Click);
            // 
            // btnClients
            // 
            this.btnClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClients.Location = new System.Drawing.Point(336, 200);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(190, 41);
            this.btnClients.TabIndex = 2;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.Location = new System.Drawing.Point(336, 278);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(190, 41);
            this.btnEmployees.TabIndex = 3;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnInvoicesPayments
            // 
            this.btnInvoicesPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoicesPayments.Location = new System.Drawing.Point(336, 361);
            this.btnInvoicesPayments.Name = "btnInvoicesPayments";
            this.btnInvoicesPayments.Size = new System.Drawing.Size(190, 41);
            this.btnInvoicesPayments.TabIndex = 4;
            this.btnInvoicesPayments.Text = "Invoices and Payments";
            this.btnInvoicesPayments.UseVisualStyleBackColor = true;
            this.btnInvoicesPayments.Click += new System.EventHandler(this.btnInvoicesPayments_Click);
            // 
            // lblUserCaption
            // 
            this.lblUserCaption.AutoSize = true;
            this.lblUserCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserCaption.Location = new System.Drawing.Point(625, 47);
            this.lblUserCaption.Name = "lblUserCaption";
            this.lblUserCaption.Size = new System.Drawing.Size(94, 17);
            this.lblUserCaption.TabIndex = 7;
            this.lblUserCaption.Text = "Logged in as:";
            // 
            // lblUserDisplay
            // 
            this.lblUserDisplay.AutoSize = true;
            this.lblUserDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDisplay.Location = new System.Drawing.Point(725, 47);
            this.lblUserDisplay.Name = "lblUserDisplay";
            this.lblUserDisplay.Size = new System.Drawing.Size(94, 17);
            this.lblUserDisplay.TabIndex = 8;
            this.lblUserDisplay.Text = "Logged in as:";
            // 
            // lblRoleDisplay
            // 
            this.lblRoleDisplay.AutoSize = true;
            this.lblRoleDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleDisplay.Location = new System.Drawing.Point(725, 93);
            this.lblRoleDisplay.Name = "lblRoleDisplay";
            this.lblRoleDisplay.Size = new System.Drawing.Size(94, 17);
            this.lblRoleDisplay.TabIndex = 10;
            this.lblRoleDisplay.Text = "Logged in as:";
            // 
            // lblRoleCaption
            // 
            this.lblRoleCaption.AutoSize = true;
            this.lblRoleCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleCaption.Location = new System.Drawing.Point(625, 93);
            this.lblRoleCaption.Name = "lblRoleCaption";
            this.lblRoleCaption.Size = new System.Drawing.Size(41, 17);
            this.lblRoleCaption.TabIndex = 9;
            this.lblRoleCaption.Text = "Role:";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 528);
            this.Controls.Add(this.lblRoleDisplay);
            this.Controls.Add(this.lblRoleCaption);
            this.Controls.Add(this.lblUserDisplay);
            this.Controls.Add(this.lblUserCaption);
            this.Controls.Add(this.btnInvoicesPayments);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnWorkRequests);
            this.Controls.Add(this.msMainMenu);
            this.MainMenuStrip = this.msMainMenu;
            this.Name = "MainMenuForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsAccount;
        private System.Windows.Forms.ToolStripMenuItem tsLogout;
        private System.Windows.Forms.ToolStripMenuItem tsHelp;
        private System.Windows.Forms.Button btnWorkRequests;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnInvoicesPayments;
        private System.Windows.Forms.Label lblUserCaption;
        private System.Windows.Forms.Label lblUserDisplay;
        private System.Windows.Forms.Label lblRoleDisplay;
        private System.Windows.Forms.Label lblRoleCaption;
    }
}