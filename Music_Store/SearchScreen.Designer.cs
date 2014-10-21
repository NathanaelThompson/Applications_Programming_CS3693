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
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 419);
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
            this.gbSeachBox.Location = new System.Drawing.Point(13, 13);
            this.gbSeachBox.Name = "gbSeachBox";
            this.gbSeachBox.Size = new System.Drawing.Size(530, 112);
            this.gbSeachBox.TabIndex = 1;
            this.gbSeachBox.TabStop = false;
            this.gbSeachBox.Text = "Seach Information";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(419, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 30);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 8;
            // 
            // lblSearchTerm
            // 
            this.lblSearchTerm.AutoSize = true;
            this.lblSearchTerm.Location = new System.Drawing.Point(24, 69);
            this.lblSearchTerm.Name = "lblSearchTerm";
            this.lblSearchTerm.Size = new System.Drawing.Size(71, 13);
            this.lblSearchTerm.TabIndex = 7;
            this.lblSearchTerm.Text = "Search Term:";
            // 
            // rbAlbums
            // 
            this.rbAlbums.AutoSize = true;
            this.rbAlbums.Location = new System.Drawing.Point(151, 31);
            this.rbAlbums.Name = "rbAlbums";
            this.rbAlbums.Size = new System.Drawing.Size(59, 17);
            this.rbAlbums.TabIndex = 6;
            this.rbAlbums.TabStop = true;
            this.rbAlbums.Text = "Albums";
            this.rbAlbums.UseVisualStyleBackColor = true;
            // 
            // rdGenre
            // 
            this.rdGenre.AutoSize = true;
            this.rdGenre.Location = new System.Drawing.Point(216, 31);
            this.rdGenre.Name = "rdGenre";
            this.rdGenre.Size = new System.Drawing.Size(59, 17);
            this.rdGenre.TabIndex = 5;
            this.rdGenre.TabStop = true;
            this.rdGenre.Text = "Genres";
            this.rdGenre.UseVisualStyleBackColor = true;
            // 
            // rbOrder
            // 
            this.rbOrder.AutoSize = true;
            this.rbOrder.Location = new System.Drawing.Point(281, 31);
            this.rbOrder.Name = "rbOrder";
            this.rbOrder.Size = new System.Drawing.Size(56, 17);
            this.rbOrder.TabIndex = 4;
            this.rbOrder.TabStop = true;
            this.rbOrder.Text = "Orders";
            this.rbOrder.UseVisualStyleBackColor = true;
            // 
            // rbCustomer
            // 
            this.rbCustomer.AutoSize = true;
            this.rbCustomer.Location = new System.Drawing.Point(343, 31);
            this.rbCustomer.Name = "rbCustomer";
            this.rbCustomer.Size = new System.Drawing.Size(74, 17);
            this.rbCustomer.TabIndex = 3;
            this.rbCustomer.TabStop = true;
            this.rbCustomer.Text = "Customers";
            this.rbCustomer.UseVisualStyleBackColor = true;
            // 
            // rbEmployee
            // 
            this.rbEmployee.AutoSize = true;
            this.rbEmployee.Location = new System.Drawing.Point(423, 31);
            this.rbEmployee.Name = "rbEmployee";
            this.rbEmployee.Size = new System.Drawing.Size(76, 17);
            this.rbEmployee.TabIndex = 2;
            this.rbEmployee.TabStop = true;
            this.rbEmployee.Text = "Employees";
            this.rbEmployee.UseVisualStyleBackColor = true;
            // 
            // rbArtist
            // 
            this.rbArtist.AutoSize = true;
            this.rbArtist.Location = new System.Drawing.Point(92, 31);
            this.rbArtist.Name = "rbArtist";
            this.rbArtist.Size = new System.Drawing.Size(53, 17);
            this.rbArtist.TabIndex = 1;
            this.rbArtist.TabStop = true;
            this.rbArtist.Text = "Artists";
            this.rbArtist.UseVisualStyleBackColor = true;
            // 
            // lblSearchFor
            // 
            this.lblSearchFor.AutoSize = true;
            this.lblSearchFor.Location = new System.Drawing.Point(24, 33);
            this.lblSearchFor.Name = "lblSearchFor";
            this.lblSearchFor.Size = new System.Drawing.Size(62, 13);
            this.lblSearchFor.TabIndex = 0;
            this.lblSearchFor.Text = "Search For:";
            // 
            // formSearchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.gbSeachBox);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formSearchScreen";
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