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
            this.label1 = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.emailButton = new System.Windows.Forms.Button();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.helpButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.previewButton = new System.Windows.Forms.Button();
            this.rbCustomers = new System.Windows.Forms.RadioButton();
            this.rbMostPopAlbum = new System.Windows.Forms.RadioButton();
            this.rbMostPopArtist = new System.Windows.Forms.RadioButton();
            this.rbMostPopGenre = new System.Windows.Forms.RadioButton();
            this.rbEmployees = new System.Windows.Forms.RadioButton();
            this.rbMonthlySales = new System.Windows.Forms.RadioButton();
            this.rbGrossSales = new System.Windows.Forms.RadioButton();
            this.reportViewer = new System.Windows.Forms.WebBrowser();
            this.gvReports = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(509, 549);
            this.generateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(133, 28);
            this.generateButton.TabIndex = 8;
            this.generateButton.Text = "Generate Report";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 619);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Email:";
            // 
            // emailButton
            // 
            this.emailButton.Location = new System.Drawing.Point(509, 613);
            this.emailButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailButton.Name = "emailButton";
            this.emailButton.Size = new System.Drawing.Size(133, 28);
            this.emailButton.TabIndex = 10;
            this.emailButton.Text = "Email Report";
            this.emailButton.UseVisualStyleBackColor = true;
            this.emailButton.Click += new System.EventHandler(this.emailButton_Click);
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(91, 616);
            this.emailBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(361, 22);
            this.emailBox.TabIndex = 11;
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(16, 692);
            this.helpButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(93, 31);
            this.helpButton.TabIndex = 13;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(565, 692);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(93, 31);
            this.closeButton.TabIndex = 14;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.previewButton);
            this.groupBox1.Controls.Add(this.rbCustomers);
            this.groupBox1.Controls.Add(this.rbMostPopAlbum);
            this.groupBox1.Controls.Add(this.rbMostPopArtist);
            this.groupBox1.Controls.Add(this.rbMostPopGenre);
            this.groupBox1.Controls.Add(this.rbEmployees);
            this.groupBox1.Controls.Add(this.rbMonthlySales);
            this.groupBox1.Controls.Add(this.rbGrossSales);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(643, 158);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "What should be including in the report?";
            // 
            // previewButton
            // 
            this.previewButton.Location = new System.Drawing.Point(9, 118);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(86, 23);
            this.previewButton.TabIndex = 13;
            this.previewButton.Text = "Preview";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // rbCustomers
            // 
            this.rbCustomers.AutoSize = true;
            this.rbCustomers.Location = new System.Drawing.Point(140, 66);
            this.rbCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.rbCustomers.Name = "rbCustomers";
            this.rbCustomers.Size = new System.Drawing.Size(96, 21);
            this.rbCustomers.TabIndex = 10;
            this.rbCustomers.Text = "Customers";
            this.rbCustomers.UseVisualStyleBackColor = true;
            // 
            // rbMostPopAlbum
            // 
            this.rbMostPopAlbum.AutoSize = true;
            this.rbMostPopAlbum.Location = new System.Drawing.Point(455, 38);
            this.rbMostPopAlbum.Margin = new System.Windows.Forms.Padding(4);
            this.rbMostPopAlbum.Name = "rbMostPopAlbum";
            this.rbMostPopAlbum.Size = new System.Drawing.Size(162, 21);
            this.rbMostPopAlbum.TabIndex = 9;
            this.rbMostPopAlbum.Text = "Most Popular Albums";
            this.rbMostPopAlbum.UseVisualStyleBackColor = true;
            // 
            // rbMostPopArtist
            // 
            this.rbMostPopArtist.AutoSize = true;
            this.rbMostPopArtist.Location = new System.Drawing.Point(281, 66);
            this.rbMostPopArtist.Margin = new System.Windows.Forms.Padding(4);
            this.rbMostPopArtist.Name = "rbMostPopArtist";
            this.rbMostPopArtist.Size = new System.Drawing.Size(155, 21);
            this.rbMostPopArtist.TabIndex = 6;
            this.rbMostPopArtist.Text = "Most Popular Artists";
            this.rbMostPopArtist.UseVisualStyleBackColor = true;
            // 
            // rbMostPopGenre
            // 
            this.rbMostPopGenre.AutoSize = true;
            this.rbMostPopGenre.Location = new System.Drawing.Point(281, 38);
            this.rbMostPopGenre.Margin = new System.Windows.Forms.Padding(4);
            this.rbMostPopGenre.Name = "rbMostPopGenre";
            this.rbMostPopGenre.Size = new System.Drawing.Size(163, 21);
            this.rbMostPopGenre.TabIndex = 4;
            this.rbMostPopGenre.Text = "Most Popular Genres";
            this.rbMostPopGenre.UseVisualStyleBackColor = true;
            // 
            // rbEmployees
            // 
            this.rbEmployees.AutoSize = true;
            this.rbEmployees.Location = new System.Drawing.Point(140, 38);
            this.rbEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.rbEmployees.Name = "rbEmployees";
            this.rbEmployees.Size = new System.Drawing.Size(130, 21);
            this.rbEmployees.TabIndex = 2;
            this.rbEmployees.Text = "Employee Sales";
            this.rbEmployees.UseVisualStyleBackColor = true;
            // 
            // rbMonthlySales
            // 
            this.rbMonthlySales.AutoSize = true;
            this.rbMonthlySales.Location = new System.Drawing.Point(8, 66);
            this.rbMonthlySales.Margin = new System.Windows.Forms.Padding(4);
            this.rbMonthlySales.Name = "rbMonthlySales";
            this.rbMonthlySales.Size = new System.Drawing.Size(117, 21);
            this.rbMonthlySales.TabIndex = 1;
            this.rbMonthlySales.Text = "Monthly Sales";
            this.rbMonthlySales.UseVisualStyleBackColor = true;
            // 
            // rbGrossSales
            // 
            this.rbGrossSales.AutoSize = true;
            this.rbGrossSales.Checked = true;
            this.rbGrossSales.Location = new System.Drawing.Point(9, 38);
            this.rbGrossSales.Margin = new System.Windows.Forms.Padding(4);
            this.rbGrossSales.Name = "rbGrossSales";
            this.rbGrossSales.Size = new System.Drawing.Size(106, 21);
            this.rbGrossSales.TabIndex = 0;
            this.rbGrossSales.TabStop = true;
            this.rbGrossSales.Text = "Gross Sales";
            this.rbGrossSales.UseVisualStyleBackColor = true;
            // 
            // reportViewer
            // 
            this.reportViewer.Location = new System.Drawing.Point(696, 15);
            this.reportViewer.MinimumSize = new System.Drawing.Size(20, 20);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(703, 708);
            this.reportViewer.TabIndex = 11;
            // 
            // gvReports
            // 
            this.gvReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvReports.Location = new System.Drawing.Point(25, 218);
            this.gvReports.Name = "gvReports";
            this.gvReports.RowTemplate.Height = 24;
            this.gvReports.Size = new System.Drawing.Size(617, 277);
            this.gvReports.TabIndex = 18;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(25, 501);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(86, 23);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(509, 645);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(133, 28);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "Clear Report";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(509, 581);
            this.printButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(133, 28);
            this.printButton.TabIndex = 20;
            this.printButton.Text = "Print Report";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // ReportGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 737);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.gvReports);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.emailButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ReportGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReportGenerator_FormClosing);
            this.Load += new System.EventHandler(this.ReportGenerator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvReports)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCustomers;
        private System.Windows.Forms.RadioButton rbMostPopAlbum;
        private System.Windows.Forms.RadioButton rbMostPopArtist;
        private System.Windows.Forms.RadioButton rbMostPopGenre;
        private System.Windows.Forms.RadioButton rbEmployees;
        private System.Windows.Forms.RadioButton rbMonthlySales;
        private System.Windows.Forms.RadioButton rbGrossSales;
        private System.Windows.Forms.WebBrowser reportViewer;
        private System.Windows.Forms.DataGridView gvReports;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button printButton;
    }
}