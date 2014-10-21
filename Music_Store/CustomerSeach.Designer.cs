namespace Music_Store
{
    partial class formCustomerSearch
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
            this.btnSeach = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lvSearchResults = new System.Windows.Forms.ListView();
            this.chLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmailAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnSeach
            // 
            this.btnSeach.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSeach.Location = new System.Drawing.Point(267, 11);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(75, 50);
            this.btnSeach.TabIndex = 0;
            this.btnSeach.Text = "Search";
            this.btnSeach.UseVisualStyleBackColor = false;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phone Number:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(99, 27);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(150, 20);
            this.txtPhoneNumber.TabIndex = 2;
            // 
            // lvSearchResults
            // 
            this.lvSearchResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLastName,
            this.chFirstName,
            this.chEmailAddress});
            this.lvSearchResults.FullRowSelect = true;
            this.lvSearchResults.Location = new System.Drawing.Point(12, 67);
            this.lvSearchResults.Name = "lvSearchResults";
            this.lvSearchResults.Size = new System.Drawing.Size(330, 122);
            this.lvSearchResults.TabIndex = 3;
            this.lvSearchResults.UseCompatibleStateImageBehavior = false;
            // 
            // chLastName
            // 
            this.chLastName.Text = "Last Name";
            // 
            // chFirstName
            // 
            this.chFirstName.Text = "First Name";
            // 
            // chEmailAddress
            // 
            this.chEmailAddress.Text = "Email Address";
            // 
            // formCustomerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 201);
            this.Controls.Add(this.lvSearchResults);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSeach);
            this.Name = "formCustomerSearch";
            this.Text = "Search for Customer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formCustomerSearch_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.ListView lvSearchResults;
        private System.Windows.Forms.ColumnHeader chLastName;
        private System.Windows.Forms.ColumnHeader chFirstName;
        private System.Windows.Forms.ColumnHeader chEmailAddress;
    }
}