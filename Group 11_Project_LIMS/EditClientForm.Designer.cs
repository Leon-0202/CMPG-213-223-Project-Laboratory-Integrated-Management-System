
namespace Group_11_Project_LIMS
{
    partial class EditClientForm
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
            this.msEditClient = new System.Windows.Forms.MenuStrip();
            this.tsHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.lblClientNoCaption = new System.Windows.Forms.Label();
            this.lblClientNoDisplay = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtAddressCity = new System.Windows.Forms.TextBox();
            this.txtAddressStreet = new System.Windows.Forms.TextBox();
            this.txtAddressNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.lblAddressCity = new System.Windows.Forms.Label();
            this.lblAddressStreet = new System.Windows.Forms.Label();
            this.lblAddressNo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.msEditClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // msEditClient
            // 
            this.msEditClient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsHelp});
            this.msEditClient.Location = new System.Drawing.Point(0, 0);
            this.msEditClient.Name = "msEditClient";
            this.msEditClient.Size = new System.Drawing.Size(800, 24);
            this.msEditClient.TabIndex = 0;
            this.msEditClient.Text = "menuStrip1";
            // 
            // tsHelp
            // 
            this.tsHelp.Name = "tsHelp";
            this.tsHelp.Size = new System.Drawing.Size(44, 20);
            this.tsHelp.Text = "Help";
            this.tsHelp.Click += new System.EventHandler(this.tsHelp_Click);
            // 
            // lblClientNoCaption
            // 
            this.lblClientNoCaption.AutoSize = true;
            this.lblClientNoCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientNoCaption.Location = new System.Drawing.Point(187, 93);
            this.lblClientNoCaption.Name = "lblClientNoCaption";
            this.lblClientNoCaption.Size = new System.Drawing.Size(94, 16);
            this.lblClientNoCaption.TabIndex = 1;
            this.lblClientNoCaption.Text = "Client Number:";
            // 
            // lblClientNoDisplay
            // 
            this.lblClientNoDisplay.AutoSize = true;
            this.lblClientNoDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientNoDisplay.Location = new System.Drawing.Point(355, 93);
            this.lblClientNoDisplay.Name = "lblClientNoDisplay";
            this.lblClientNoDisplay.Size = new System.Drawing.Size(44, 16);
            this.lblClientNoDisplay.TabIndex = 2;
            this.lblClientNoDisplay.Text = "label2";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(187, 135);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(75, 16);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(358, 132);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(256, 22);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(358, 174);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(256, 22);
            this.txtLastName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(187, 177);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(72, 16);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name";
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(237, 459);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(121, 46);
            this.btnApply.TabIndex = 8;
            this.btnApply.Text = "Apply Changes";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(422, 459);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 46);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtAddressCity
            // 
            this.txtAddressCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressCity.Location = new System.Drawing.Point(358, 397);
            this.txtAddressCity.Name = "txtAddressCity";
            this.txtAddressCity.Size = new System.Drawing.Size(256, 22);
            this.txtAddressCity.TabIndex = 7;
            // 
            // txtAddressStreet
            // 
            this.txtAddressStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressStreet.Location = new System.Drawing.Point(358, 352);
            this.txtAddressStreet.Name = "txtAddressStreet";
            this.txtAddressStreet.Size = new System.Drawing.Size(256, 22);
            this.txtAddressStreet.TabIndex = 6;
            // 
            // txtAddressNo
            // 
            this.txtAddressNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressNo.Location = new System.Drawing.Point(358, 304);
            this.txtAddressNo.Name = "txtAddressNo";
            this.txtAddressNo.Size = new System.Drawing.Size(256, 22);
            this.txtAddressNo.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(358, 259);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(256, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(358, 216);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(256, 22);
            this.txtContactNo.TabIndex = 3;
            // 
            // lblAddressCity
            // 
            this.lblAddressCity.AutoSize = true;
            this.lblAddressCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressCity.Location = new System.Drawing.Point(187, 400);
            this.lblAddressCity.Name = "lblAddressCity";
            this.lblAddressCity.Size = new System.Drawing.Size(125, 16);
            this.lblAddressCity.TabIndex = 23;
            this.lblAddressCity.Text = "Billing Address City:";
            // 
            // lblAddressStreet
            // 
            this.lblAddressStreet.AutoSize = true;
            this.lblAddressStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressStreet.Location = new System.Drawing.Point(187, 355);
            this.lblAddressStreet.Name = "lblAddressStreet";
            this.lblAddressStreet.Size = new System.Drawing.Size(138, 16);
            this.lblAddressStreet.TabIndex = 22;
            this.lblAddressStreet.Text = "Billing Address Street:";
            // 
            // lblAddressNo
            // 
            this.lblAddressNo.AutoSize = true;
            this.lblAddressNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressNo.Location = new System.Drawing.Point(187, 307);
            this.lblAddressNo.Name = "lblAddressNo";
            this.lblAddressNo.Size = new System.Drawing.Size(151, 16);
            this.lblAddressNo.TabIndex = 21;
            this.lblAddressNo.Text = "Billing Address Number:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(187, 262);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(98, 16);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "Email Address:";
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNo.Location = new System.Drawing.Point(187, 219);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(106, 16);
            this.lblContactNo.TabIndex = 19;
            this.lblContactNo.Text = "Contact Number:";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(243, 38);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(339, 16);
            this.lblInstructions.TabIndex = 29;
            this.lblInstructions.Text = "Change the desired values and click on Apply Changes:";
            // 
            // EditClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.txtAddressCity);
            this.Controls.Add(this.txtAddressStreet);
            this.Controls.Add(this.txtAddressNo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.lblAddressCity);
            this.Controls.Add(this.lblAddressStreet);
            this.Controls.Add(this.lblAddressNo);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblContactNo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblClientNoDisplay);
            this.Controls.Add(this.lblClientNoCaption);
            this.Controls.Add(this.msEditClient);
            this.MainMenuStrip = this.msEditClient;
            this.Name = "EditClientForm";
            this.Text = "Edit Client";
            this.Load += new System.EventHandler(this.EditClientForm_Load);
            this.msEditClient.ResumeLayout(false);
            this.msEditClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msEditClient;
        private System.Windows.Forms.ToolStripMenuItem tsHelp;
        private System.Windows.Forms.Label lblClientNoCaption;
        private System.Windows.Forms.Label lblClientNoDisplay;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtAddressCity;
        private System.Windows.Forms.TextBox txtAddressStreet;
        private System.Windows.Forms.TextBox txtAddressNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label lblAddressCity;
        private System.Windows.Forms.Label lblAddressStreet;
        private System.Windows.Forms.Label lblAddressNo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblInstructions;
    }
}