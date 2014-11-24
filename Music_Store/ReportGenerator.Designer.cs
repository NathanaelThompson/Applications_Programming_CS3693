namespace Music_Store
{
    partial class ReportGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportGenerator));
            this.label1 = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.emailButton = new System.Windows.Forms.Button();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.helpButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gvReports = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbGrossSales = new System.Windows.Forms.RadioButton();
            this.rbMonthlySales = new System.Windows.Forms.RadioButton();
            this.rbEmployees = new System.Windows.Forms.RadioButton();
            this.rbMostPopGenre = new System.Windows.Forms.RadioButton();
            this.rbMostPopArtist = new System.Windows.Forms.RadioButton();
            this.rbMostPopAlbum = new System.Windows.Forms.RadioButton();
            this.rbCustomers = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReports)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(195, 90);
            this.generateButton.Margin = new System.Windows.Forms.Padding(2);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(100, 23);
            this.generateButton.TabIndex = 8;
            this.generateButton.Text = "Generate Report";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(64, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Email:";
            // 
            // emailButton
            // 
            this.emailButton.Enabled = false;
            this.emailButton.Location = new System.Drawing.Point(349, 188);
            this.emailButton.Margin = new System.Windows.Forms.Padding(2);
            this.emailButton.Name = "emailButton";
            this.emailButton.Size = new System.Drawing.Size(100, 23);
            this.emailButton.TabIndex = 10;
            this.emailButton.Text = "Email Report";
            this.emailButton.UseVisualStyleBackColor = true;
            this.emailButton.Click += new System.EventHandler(this.emailButton_Click);
            // 
            // emailBox
            // 
            this.emailBox.Enabled = false;
            this.emailBox.Location = new System.Drawing.Point(103, 191);
            this.emailBox.Margin = new System.Windows.Forms.Padding(2);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(242, 20);
            this.emailBox.TabIndex = 11;
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(12, 562);
            this.helpButton.Margin = new System.Windows.Forms.Padding(2);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(70, 25);
            this.helpButton.TabIndex = 13;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(424, 562);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(70, 25);
            this.closeButton.TabIndex = 14;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(178, 301);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // gvReports
            // 
            this.gvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvReports.Location = new System.Drawing.Point(500, 12);
            this.gvReports.Name = "gvReports";
            this.gvReports.RowHeadersVisible = false;
            this.gvReports.Size = new System.Drawing.Size(550, 575);
            this.gvReports.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCustomers);
            this.groupBox1.Controls.Add(this.rbMostPopAlbum);
            this.groupBox1.Controls.Add(this.rbMostPopArtist);
            this.groupBox1.Controls.Add(this.rbMostPopGenre);
            this.groupBox1.Controls.Add(this.generateButton);
            this.groupBox1.Controls.Add(this.rbEmployees);
            this.groupBox1.Controls.Add(this.rbMonthlySales);
            this.groupBox1.Controls.Add(this.rbGrossSales);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 128);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "What should be including in the report?";
            // 
            // rbGrossSales
            // 
            this.rbGrossSales.AutoSize = true;
            this.rbGrossSales.Checked = true;
            this.rbGrossSales.Location = new System.Drawing.Point(7, 31);
            this.rbGrossSales.Name = "rbGrossSales";
            this.rbGrossSales.Size = new System.Drawing.Size(81, 17);
            this.rbGrossSales.TabIndex = 0;
            this.rbGrossSales.TabStop = true;
            this.rbGrossSales.Text = "Gross Sales";
            this.rbGrossSales.UseVisualStyleBackColor = true;
            // 
            // rbMonthlySales
            // 
            this.rbMonthlySales.AutoSize = true;
            this.rbMonthlySales.Location = new System.Drawing.Point(6, 54);
            this.rbMonthlySales.Name = "rbMonthlySales";
            this.rbMonthlySales.Size = new System.Drawing.Size(91, 17);
            this.rbMonthlySales.TabIndex = 1;
            this.rbMonthlySales.Text = "Monthly Sales";
            this.rbMonthlySales.UseVisualStyleBackColor = true;
            // 
            // rbEmployees
            // 
            this.rbEmployees.AutoSize = true;
            this.rbEmployees.Location = new System.Drawing.Point(105, 31);
            this.rbEmployees.Name = "rbEmployees";
            this.rbEmployees.Size = new System.Drawing.Size(100, 17);
            this.rbEmployees.TabIndex = 2;
            this.rbEmployees.Text = "Employee Sales";
            this.rbEmployees.UseVisualStyleBackColor = true;
            // 
            // rbMostPopGenre
            // 
            this.rbMostPopGenre.AutoSize = true;
            this.rbMostPopGenre.Location = new System.Drawing.Point(211, 31);
            this.rbMostPopGenre.Name = "rbMostPopGenre";
            this.rbMostPopGenre.Size = new System.Drawing.Size(124, 17);
            this.rbMostPopGenre.TabIndex = 4;
            this.rbMostPopGenre.Text = "Most Popular Genres";
            this.rbMostPopGenre.UseVisualStyleBackColor = true;
            // 
            // rbMostPopArtist
            // 
            this.rbMostPopArtist.AutoSize = true;
            this.rbMostPopArtist.Location = new System.Drawing.Point(211, 54);
            this.rbMostPopArtist.Name = "rbMostPopArtist";
            this.rbMostPopArtist.Size = new System.Drawing.Size(118, 17);
            this.rbMostPopArtist.TabIndex = 6;
            this.rbMostPopArtist.Text = "Most Popular Artists";
            this.rbMostPopArtist.UseVisualStyleBackColor = true;
            // 
            // rbMostPopAlbum
            // 
            this.rbMostPopAlbum.AutoSize = true;
            this.rbMostPopAlbum.Location = new System.Drawing.Point(341, 31);
            this.rbMostPopAlbum.Name = "rbMostPopAlbum";
            this.rbMostPopAlbum.Size = new System.Drawing.Size(124, 17);
            this.rbMostPopAlbum.TabIndex = 9;
            this.rbMostPopAlbum.Text = "Most Popular Albums";
            this.rbMostPopAlbum.UseVisualStyleBackColor = true;
            // 
            // rbCustomers
            // 
            this.rbCustomers.AutoSize = true;
            this.rbCustomers.Location = new System.Drawing.Point(105, 54);
            this.rbCustomers.Name = "rbCustomers";
            this.rbCustomers.Size = new System.Drawing.Size(74, 17);
            this.rbCustomers.TabIndex = 10;
            this.rbCustomers.Text = "Customers";
            this.rbCustomers.UseVisualStyleBackColor = true;
            // 
            // ReportGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 599);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gvReports);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.emailButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ReportGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReportGenerator_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReports)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button emailButton;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView gvReports;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCustomers;
        private System.Windows.Forms.RadioButton rbMostPopAlbum;
        private System.Windows.Forms.RadioButton rbMostPopArtist;
        private System.Windows.Forms.RadioButton rbMostPopGenre;
        private System.Windows.Forms.RadioButton rbEmployees;
        private System.Windows.Forms.RadioButton rbMonthlySales;
        private System.Windows.Forms.RadioButton rbGrossSales;
    }
}