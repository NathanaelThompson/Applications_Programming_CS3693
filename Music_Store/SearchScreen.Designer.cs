namespace Music_Store
{
    partial class formSearchScreen
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbSeachBox = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSearchTerm = new System.Windows.Forms.Label();
            this.rbAlbums = new System.Windows.Forms.RadioButton();
            this.rdGenre = new System.Windows.Forms.RadioButton();
            this.rbOrder = new System.Windows.Forms.RadioButton();
            this.rbCustomer = new System.Windows.Forms.RadioButton();
            this.rbEmployee = new System.Windows.Forms.RadioButton();
            this.rbArtist = new System.Windows.Forms.RadioButton();
            this.lblSearchFor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbSeachBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 154);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(884, 508);
            this.dataGridView1.TabIndex = 0;
            // 
            // gbSeachBox
            // 
            this.gbSeachBox.Controls.Add(this.btnSearch);
            this.gbSeachBox.Controls.Add(this.textBox1);
            this.gbSeachBox.Controls.Add(this.lblSearchTerm);
            this.gbSeachBox.Controls.Add(this.rbAlbums);
            this.gbSeachBox.Controls.Add(this.rdGenre);
            this.gbSeachBox.Controls.Add(this.rbOrder);
            this.gbSeachBox.Controls.Add(this.rbCustomer);
            this.gbSeachBox.Controls.Add(this.rbEmployee);
            this.gbSeachBox.Controls.Add(this.rbArtist);
            this.gbSeachBox.Controls.Add(this.lblSearchFor);
            this.gbSeachBox.Location = new System.Drawing.Point(13, 16);
            this.gbSeachBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSeachBox.Name = "gbSeachBox";
            this.gbSeachBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSeachBox.Size = new System.Drawing.Size(858, 130);
            this.gbSeachBox.TabIndex = 1;
            this.gbSeachBox.TabStop = false;
            this.gbSeachBox.Text = "Seach Information";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(718, 41);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 50);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 82);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 23);
            this.textBox1.TabIndex = 8;
            // 
            // lblSearchTerm
            // 
            this.lblSearchTerm.AutoSize = true;
            this.lblSearchTerm.Location = new System.Drawing.Point(32, 85);
            this.lblSearchTerm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchTerm.Name = "lblSearchTerm";
            this.lblSearchTerm.Size = new System.Drawing.Size(94, 17);
            this.lblSearchTerm.TabIndex = 7;
            this.lblSearchTerm.Text = "Search Term:";
            // 
            // rbAlbums
            // 
            this.rbAlbums.AutoSize = true;
            this.rbAlbums.Location = new System.Drawing.Point(201, 38);
            this.rbAlbums.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbAlbums.Name = "rbAlbums";
            this.rbAlbums.Size = new System.Drawing.Size(72, 21);
            this.rbAlbums.TabIndex = 6;
            this.rbAlbums.TabStop = true;
            this.rbAlbums.Text = "Albums";
            this.rbAlbums.UseVisualStyleBackColor = true;
            // 
            // rdGenre
            // 
            this.rdGenre.AutoSize = true;
            this.rdGenre.Location = new System.Drawing.Point(288, 38);
            this.rdGenre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdGenre.Name = "rdGenre";
            this.rdGenre.Size = new System.Drawing.Size(73, 21);
            this.rdGenre.TabIndex = 5;
            this.rdGenre.TabStop = true;
            this.rdGenre.Text = "Genres";
            this.rdGenre.UseVisualStyleBackColor = true;
            // 
            // rbOrder
            // 
            this.rbOrder.AutoSize = true;
            this.rbOrder.Location = new System.Drawing.Point(375, 38);
            this.rbOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbOrder.Name = "rbOrder";
            this.rbOrder.Size = new System.Drawing.Size(70, 21);
            this.rbOrder.TabIndex = 4;
            this.rbOrder.TabStop = true;
            this.rbOrder.Text = "Orders";
            this.rbOrder.UseVisualStyleBackColor = true;
            // 
            // rbCustomer
            // 
            this.rbCustomer.AutoSize = true;
            this.rbCustomer.Location = new System.Drawing.Point(457, 38);
            this.rbCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbCustomer.Name = "rbCustomer";
            this.rbCustomer.Size = new System.Drawing.Size(93, 21);
            this.rbCustomer.TabIndex = 3;
            this.rbCustomer.TabStop = true;
            this.rbCustomer.Text = "Customers";
            this.rbCustomer.UseVisualStyleBackColor = true;
            // 
            // rbEmployee
            // 
            this.rbEmployee.AutoSize = true;
            this.rbEmployee.Location = new System.Drawing.Point(564, 38);
            this.rbEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbEmployee.Name = "rbEmployee";
            this.rbEmployee.Size = new System.Drawing.Size(95, 21);
            this.rbEmployee.TabIndex = 2;
            this.rbEmployee.TabStop = true;
            this.rbEmployee.Text = "Employees";
            this.rbEmployee.UseVisualStyleBackColor = true;
            // 
            // rbArtist
            // 
            this.rbArtist.AutoSize = true;
            this.rbArtist.Location = new System.Drawing.Point(123, 38);
            this.rbArtist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbArtist.Name = "rbArtist";
            this.rbArtist.Size = new System.Drawing.Size(65, 21);
            this.rbArtist.TabIndex = 1;
            this.rbArtist.TabStop = true;
            this.rbArtist.Text = "Artists";
            this.rbArtist.UseVisualStyleBackColor = true;
            // 
            // lblSearchFor
            // 
            this.lblSearchFor.AutoSize = true;
            this.lblSearchFor.Location = new System.Drawing.Point(32, 41);
            this.lblSearchFor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchFor.Name = "lblSearchFor";
            this.lblSearchFor.Size = new System.Drawing.Size(82, 17);
            this.lblSearchFor.TabIndex = 0;
            this.lblSearchFor.Text = "Search For:";
            // 
            // formSearchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 662);
            this.Controls.Add(this.gbSeachBox);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "formSearchScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formSearchScreen_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbSeachBox.ResumeLayout(false);
            this.gbSeachBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbSeachBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSearchTerm;
        private System.Windows.Forms.RadioButton rbAlbums;
        private System.Windows.Forms.RadioButton rdGenre;
        private System.Windows.Forms.RadioButton rbOrder;
        private System.Windows.Forms.RadioButton rbCustomer;
        private System.Windows.Forms.RadioButton rbEmployee;
        private System.Windows.Forms.RadioButton rbArtist;
        private System.Windows.Forms.Label lblSearchFor;
    }
}