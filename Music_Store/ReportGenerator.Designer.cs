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
            this.gIncomeCB = new System.Windows.Forms.CheckBox();
            this.nIncomeCB = new System.Windows.Forms.CheckBox();
            this.expenseCB = new System.Windows.Forms.CheckBox();
            this.numAlbumsCB = new System.Windows.Forms.CheckBox();
            this.popArtistsCB = new System.Windows.Forms.CheckBox();
            this.popGenresCB = new System.Windows.Forms.CheckBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.emailButton = new System.Windows.Forms.Button();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.pdfPreviewer = new System.Windows.Forms.WebBrowser();
            this.helpButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "What should be included in this report? (check all that apply)";
            // 
            // gIncomeCB
            // 
            this.gIncomeCB.AutoSize = true;
            this.gIncomeCB.Location = new System.Drawing.Point(32, 63);
            this.gIncomeCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gIncomeCB.Name = "gIncomeCB";
            this.gIncomeCB.Size = new System.Drawing.Size(91, 17);
            this.gIncomeCB.TabIndex = 2;
            this.gIncomeCB.Text = "Gross Income";
            this.gIncomeCB.UseVisualStyleBackColor = true;
            // 
            // nIncomeCB
            // 
            this.nIncomeCB.AutoSize = true;
            this.nIncomeCB.Location = new System.Drawing.Point(32, 85);
            this.nIncomeCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nIncomeCB.Name = "nIncomeCB";
            this.nIncomeCB.Size = new System.Drawing.Size(81, 17);
            this.nIncomeCB.TabIndex = 3;
            this.nIncomeCB.Text = "Net Income";
            this.nIncomeCB.UseVisualStyleBackColor = true;
            // 
            // expenseCB
            // 
            this.expenseCB.AutoSize = true;
            this.expenseCB.Location = new System.Drawing.Point(127, 63);
            this.expenseCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.expenseCB.Name = "expenseCB";
            this.expenseCB.Size = new System.Drawing.Size(72, 17);
            this.expenseCB.TabIndex = 4;
            this.expenseCB.Text = "Expenses";
            this.expenseCB.UseVisualStyleBackColor = true;
            // 
            // numAlbumsCB
            // 
            this.numAlbumsCB.AutoSize = true;
            this.numAlbumsCB.Location = new System.Drawing.Point(127, 85);
            this.numAlbumsCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numAlbumsCB.Name = "numAlbumsCB";
            this.numAlbumsCB.Size = new System.Drawing.Size(163, 17);
            this.numAlbumsCB.TabIndex = 5;
            this.numAlbumsCB.Text = "Total Number of Albums Sold";
            this.numAlbumsCB.UseVisualStyleBackColor = true;
            // 
            // popArtistsCB
            // 
            this.popArtistsCB.AutoSize = true;
            this.popArtistsCB.Location = new System.Drawing.Point(292, 63);
            this.popArtistsCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.popArtistsCB.Name = "popArtistsCB";
            this.popArtistsCB.Size = new System.Drawing.Size(119, 17);
            this.popArtistsCB.TabIndex = 6;
            this.popArtistsCB.Text = "Most Popular Artists";
            this.popArtistsCB.UseVisualStyleBackColor = true;
            // 
            // popGenresCB
            // 
            this.popGenresCB.AutoSize = true;
            this.popGenresCB.Location = new System.Drawing.Point(292, 85);
            this.popGenresCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.popGenresCB.Name = "popGenresCB";
            this.popGenresCB.Size = new System.Drawing.Size(125, 17);
            this.popGenresCB.TabIndex = 7;
            this.popGenresCB.Text = "Most Popular Genres";
            this.popGenresCB.UseVisualStyleBackColor = true;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(314, 132);
            this.generateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.label2.Location = new System.Drawing.Point(29, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Email:";
            // 
            // emailButton
            // 
            this.emailButton.Enabled = false;
            this.emailButton.Location = new System.Drawing.Point(314, 188);
            this.emailButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.emailBox.Location = new System.Drawing.Point(68, 191);
            this.emailBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(242, 20);
            this.emailBox.TabIndex = 11;
            // 
            // pdfPreviewer
            // 
            this.pdfPreviewer.Location = new System.Drawing.Point(479, 34);
            this.pdfPreviewer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pdfPreviewer.MinimumSize = new System.Drawing.Size(15, 16);
            this.pdfPreviewer.Name = "pdfPreviewer";
            this.pdfPreviewer.Size = new System.Drawing.Size(623, 555);
            this.pdfPreviewer.TabIndex = 12;
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(9, 564);
            this.helpButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(70, 25);
            this.helpButton.TabIndex = 13;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(405, 564);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.pictureBox1.Location = new System.Drawing.Point(158, 342);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 125);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // ReportGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 599);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.pdfPreviewer);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.emailButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.popGenresCB);
            this.Controls.Add(this.popArtistsCB);
            this.Controls.Add(this.numAlbumsCB);
            this.Controls.Add(this.expenseCB);
            this.Controls.Add(this.nIncomeCB);
            this.Controls.Add(this.gIncomeCB);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReportGenerator";
            this.Text = "Report Generator";
            this.Load += new System.EventHandler(this.ReportGenerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox gIncomeCB;
        private System.Windows.Forms.CheckBox nIncomeCB;
        private System.Windows.Forms.CheckBox expenseCB;
        private System.Windows.Forms.CheckBox numAlbumsCB;
        private System.Windows.Forms.CheckBox popArtistsCB;
        private System.Windows.Forms.CheckBox popGenresCB;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button emailButton;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.WebBrowser pdfPreviewer;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}