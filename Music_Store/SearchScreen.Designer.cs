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
            this.searchDGV = new System.Windows.Forms.DataGridView();
            this.gbSeachBox = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.lblSearchTerm = new System.Windows.Forms.Label();
            this.rbAlbums = new System.Windows.Forms.RadioButton();
            this.rbGenre = new System.Windows.Forms.RadioButton();
            this.rbOrder = new System.Windows.Forms.RadioButton();
            this.rbCustomer = new System.Windows.Forms.RadioButton();
            this.rbEmployee = new System.Windows.Forms.RadioButton();
            this.rbArtist = new System.Windows.Forms.RadioButton();
            this.lblSearchFor = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.searchDGV)).BeginInit();
            this.gbSeachBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchDGV
            // 
            this.searchDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchDGV.Location = new System.Drawing.Point(0, 196);
            this.searchDGV.Margin = new System.Windows.Forms.Padding(4);
            this.searchDGV.Name = "searchDGV";
            this.searchDGV.RowHeadersVisible = false;
            this.searchDGV.Size = new System.Drawing.Size(936, 508);
            this.searchDGV.TabIndex = 0;
            // 
            // gbSeachBox
            // 
            this.gbSeachBox.Controls.Add(this.label1);
            this.gbSeachBox.Controls.Add(this.btnSearch);
            this.gbSeachBox.Controls.Add(this.searchBox);
            this.gbSeachBox.Controls.Add(this.lblSearchTerm);
            this.gbSeachBox.Controls.Add(this.rbAlbums);
            this.gbSeachBox.Controls.Add(this.rbGenre);
            this.gbSeachBox.Controls.Add(this.rbOrder);
            this.gbSeachBox.Controls.Add(this.rbCustomer);
            this.gbSeachBox.Controls.Add(this.rbEmployee);
            this.gbSeachBox.Controls.Add(this.rbArtist);
            this.gbSeachBox.Controls.Add(this.lblSearchFor);
            this.gbSeachBox.Location = new System.Drawing.Point(13, 42);
            this.gbSeachBox.Margin = new System.Windows.Forms.Padding(4);
            this.gbSeachBox.Name = "gbSeachBox";
            this.gbSeachBox.Padding = new System.Windows.Forms.Padding(4);
            this.gbSeachBox.Size = new System.Drawing.Size(910, 130);
            this.gbSeachBox.TabIndex = 1;
            this.gbSeachBox.TabStop = false;
            this.gbSeachBox.Text = "Seach Information";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(802, 38);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 50);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(151, 82);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(265, 26);
            this.searchBox.TabIndex = 8;
            // 
            // lblSearchTerm
            // 
            this.lblSearchTerm.AutoSize = true;
            this.lblSearchTerm.Location = new System.Drawing.Point(32, 85);
            this.lblSearchTerm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchTerm.Name = "lblSearchTerm";
            this.lblSearchTerm.Size = new System.Drawing.Size(111, 20);
            this.lblSearchTerm.TabIndex = 7;
            this.lblSearchTerm.Text = "Search Term:";
            // 
            // rbAlbums
            // 
            this.rbAlbums.AutoSize = true;
            this.rbAlbums.Location = new System.Drawing.Point(248, 37);
            this.rbAlbums.Margin = new System.Windows.Forms.Padding(4);
            this.rbAlbums.Name = "rbAlbums";
            this.rbAlbums.Size = new System.Drawing.Size(86, 24);
            this.rbAlbums.TabIndex = 6;
            this.rbAlbums.TabStop = true;
            this.rbAlbums.Text = "Albums";
            this.rbAlbums.UseVisualStyleBackColor = true;
            // 
            // rbGenre
            // 
            this.rbGenre.AutoSize = true;
            this.rbGenre.Location = new System.Drawing.Point(342, 37);
            this.rbGenre.Margin = new System.Windows.Forms.Padding(4);
            this.rbGenre.Name = "rbGenre";
            this.rbGenre.Size = new System.Drawing.Size(85, 24);
            this.rbGenre.TabIndex = 5;
            this.rbGenre.TabStop = true;
            this.rbGenre.Text = "Genres";
            this.rbGenre.UseVisualStyleBackColor = true;
            // 
            // rbOrder
            // 
            this.rbOrder.AutoSize = true;
            this.rbOrder.Location = new System.Drawing.Point(435, 38);
            this.rbOrder.Margin = new System.Windows.Forms.Padding(4);
            this.rbOrder.Name = "rbOrder";
            this.rbOrder.Size = new System.Drawing.Size(82, 24);
            this.rbOrder.TabIndex = 4;
            this.rbOrder.TabStop = true;
            this.rbOrder.Text = "Orders";
            this.rbOrder.UseVisualStyleBackColor = true;
            // 
            // rbCustomer
            // 
            this.rbCustomer.AutoSize = true;
            this.rbCustomer.Location = new System.Drawing.Point(525, 37);
            this.rbCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.rbCustomer.Name = "rbCustomer";
            this.rbCustomer.Size = new System.Drawing.Size(112, 24);
            this.rbCustomer.TabIndex = 3;
            this.rbCustomer.TabStop = true;
            this.rbCustomer.Text = "Customers";
            this.rbCustomer.UseVisualStyleBackColor = true;
            // 
            // rbEmployee
            // 
            this.rbEmployee.AutoSize = true;
            this.rbEmployee.Location = new System.Drawing.Point(645, 37);
            this.rbEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.rbEmployee.Name = "rbEmployee";
            this.rbEmployee.Size = new System.Drawing.Size(112, 24);
            this.rbEmployee.TabIndex = 2;
            this.rbEmployee.TabStop = true;
            this.rbEmployee.Text = "Employees";
            this.rbEmployee.UseVisualStyleBackColor = true;
            // 
            // rbArtist
            // 
            this.rbArtist.AutoSize = true;
            this.rbArtist.Location = new System.Drawing.Point(161, 37);
            this.rbArtist.Margin = new System.Windows.Forms.Padding(4);
            this.rbArtist.Name = "rbArtist";
            this.rbArtist.Size = new System.Drawing.Size(79, 24);
            this.rbArtist.TabIndex = 1;
            this.rbArtist.TabStop = true;
            this.rbArtist.Text = "Artists";
            this.rbArtist.UseVisualStyleBackColor = true;
            // 
            // lblSearchFor
            // 
            this.lblSearchFor.AutoSize = true;
            this.lblSearchFor.Location = new System.Drawing.Point(46, 39);
            this.lblSearchFor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchFor.Name = "lblSearchFor";
            this.lblSearchFor.Size = new System.Drawing.Size(97, 20);
            this.lblSearchFor.TabIndex = 0;
            this.lblSearchFor.Text = "Search For:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(936, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "*Leave blank to see all results in one category";
            // 
            // formSearchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 704);
            this.Controls.Add(this.gbSeachBox);
            this.Controls.Add(this.searchDGV);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "formSearchScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formSearchScreen_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.searchDGV)).EndInit();
            this.gbSeachBox.ResumeLayout(false);
            this.gbSeachBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView searchDGV;
        private System.Windows.Forms.GroupBox gbSeachBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label lblSearchTerm;
        private System.Windows.Forms.RadioButton rbAlbums;
        private System.Windows.Forms.RadioButton rbGenre;
        private System.Windows.Forms.RadioButton rbOrder;
        private System.Windows.Forms.RadioButton rbCustomer;
        private System.Windows.Forms.RadioButton rbEmployee;
        private System.Windows.Forms.RadioButton rbArtist;
        private System.Windows.Forms.Label lblSearchFor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}