namespace Music_Store
{
    partial class formInventory
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
            this.components = new System.ComponentModel.Container();
            this.tcInventory = new System.Windows.Forms.TabControl();
            this.tabArtist = new System.Windows.Forms.TabPage();
            this.tabAlbums = new System.Windows.Forms.TabPage();
            this.tabGenre = new System.Windows.Forms.TabPage();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.gridArtist = new System.Windows.Forms.DataGridView();
            this.gbAddArtist = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblArtistName = new System.Windows.Forms.Label();
            this.btnAddArtist = new System.Windows.Forms.Button();
            this.gbUpdateArtist = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuArtist = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miDeleteArtist = new System.Windows.Forms.ToolStripMenuItem();
            this.tcInventory.SuspendLayout();
            this.tabArtist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridArtist)).BeginInit();
            this.gbAddArtist.SuspendLayout();
            this.gbUpdateArtist.SuspendLayout();
            this.menuArtist.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcInventory
            // 
            this.tcInventory.Controls.Add(this.tabArtist);
            this.tcInventory.Controls.Add(this.tabAlbums);
            this.tcInventory.Controls.Add(this.tabGenre);
            this.tcInventory.Controls.Add(this.tabCustomer);
            this.tcInventory.Controls.Add(this.tabEmployee);
            this.tcInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcInventory.Location = new System.Drawing.Point(0, 0);
            this.tcInventory.Name = "tcInventory";
            this.tcInventory.SelectedIndex = 0;
            this.tcInventory.Size = new System.Drawing.Size(784, 562);
            this.tcInventory.TabIndex = 0;
            // 
            // tabArtist
            // 
            this.tabArtist.Controls.Add(this.gbUpdateArtist);
            this.tabArtist.Controls.Add(this.gbAddArtist);
            this.tabArtist.Controls.Add(this.gridArtist);
            this.tabArtist.Location = new System.Drawing.Point(4, 22);
            this.tabArtist.Name = "tabArtist";
            this.tabArtist.Padding = new System.Windows.Forms.Padding(3);
            this.tabArtist.Size = new System.Drawing.Size(776, 536);
            this.tabArtist.TabIndex = 0;
            this.tabArtist.Text = "Artists";
            this.tabArtist.UseVisualStyleBackColor = true;
            // 
            // tabAlbums
            // 
            this.tabAlbums.Location = new System.Drawing.Point(4, 22);
            this.tabAlbums.Name = "tabAlbums";
            this.tabAlbums.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlbums.Size = new System.Drawing.Size(776, 536);
            this.tabAlbums.TabIndex = 1;
            this.tabAlbums.Text = "Albums";
            this.tabAlbums.UseVisualStyleBackColor = true;
            // 
            // tabGenre
            // 
            this.tabGenre.Location = new System.Drawing.Point(4, 22);
            this.tabGenre.Name = "tabGenre";
            this.tabGenre.Padding = new System.Windows.Forms.Padding(3);
            this.tabGenre.Size = new System.Drawing.Size(776, 536);
            this.tabGenre.TabIndex = 2;
            this.tabGenre.Text = "Genres";
            this.tabGenre.UseVisualStyleBackColor = true;
            // 
            // tabCustomer
            // 
            this.tabCustomer.Location = new System.Drawing.Point(4, 22);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomer.Size = new System.Drawing.Size(776, 536);
            this.tabCustomer.TabIndex = 3;
            this.tabCustomer.Text = "Customers";
            this.tabCustomer.UseVisualStyleBackColor = true;
            // 
            // tabEmployee
            // 
            this.tabEmployee.Location = new System.Drawing.Point(4, 22);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployee.Size = new System.Drawing.Size(776, 536);
            this.tabEmployee.TabIndex = 4;
            this.tabEmployee.Text = "Employees";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // gridArtist
            // 
            this.gridArtist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridArtist.ContextMenuStrip = this.menuArtist;
            this.gridArtist.Location = new System.Drawing.Point(3, 6);
            this.gridArtist.Name = "gridArtist";
            this.gridArtist.Size = new System.Drawing.Size(465, 522);
            this.gridArtist.TabIndex = 0;
            // 
            // gbAddArtist
            // 
            this.gbAddArtist.Controls.Add(this.btnAddArtist);
            this.gbAddArtist.Controls.Add(this.lblArtistName);
            this.gbAddArtist.Controls.Add(this.textBox1);
            this.gbAddArtist.Location = new System.Drawing.Point(474, 6);
            this.gbAddArtist.Name = "gbAddArtist";
            this.gbAddArtist.Size = new System.Drawing.Size(296, 129);
            this.gbAddArtist.TabIndex = 1;
            this.gbAddArtist.TabStop = false;
            this.gbAddArtist.Text = "Add Artist";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lblArtistName
            // 
            this.lblArtistName.AutoSize = true;
            this.lblArtistName.Location = new System.Drawing.Point(19, 32);
            this.lblArtistName.Name = "lblArtistName";
            this.lblArtistName.Size = new System.Drawing.Size(61, 13);
            this.lblArtistName.TabIndex = 1;
            this.lblArtistName.Text = "Artist Name";
            // 
            // btnAddArtist
            // 
            this.btnAddArtist.Location = new System.Drawing.Point(180, 85);
            this.btnAddArtist.Name = "btnAddArtist";
            this.btnAddArtist.Size = new System.Drawing.Size(80, 30);
            this.btnAddArtist.TabIndex = 2;
            this.btnAddArtist.Text = "Add Artist";
            this.btnAddArtist.UseVisualStyleBackColor = true;
            // 
            // gbUpdateArtist
            // 
            this.gbUpdateArtist.Controls.Add(this.button1);
            this.gbUpdateArtist.Controls.Add(this.label1);
            this.gbUpdateArtist.Controls.Add(this.textBox2);
            this.gbUpdateArtist.Location = new System.Drawing.Point(474, 141);
            this.gbUpdateArtist.Name = "gbUpdateArtist";
            this.gbUpdateArtist.Size = new System.Drawing.Size(296, 138);
            this.gbUpdateArtist.TabIndex = 2;
            this.gbUpdateArtist.TabStop = false;
            this.gbUpdateArtist.Text = "Update Artist";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Artist Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Update Artist";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuArtist
            // 
            this.menuArtist.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDeleteArtist});
            this.menuArtist.Name = "menuArtist";
            this.menuArtist.Size = new System.Drawing.Size(153, 48);
            this.menuArtist.Opening += new System.ComponentModel.CancelEventHandler(this.menuArtist_Opening);
            // 
            // miDeleteArtist
            // 
            this.miDeleteArtist.Name = "miDeleteArtist";
            this.miDeleteArtist.Size = new System.Drawing.Size(152, 22);
            this.miDeleteArtist.Text = "Delete Artrist";
            // 
            // formInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tcInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formInventory";
            this.Text = "Manage Inventory";
            this.tcInventory.ResumeLayout(false);
            this.tabArtist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridArtist)).EndInit();
            this.gbAddArtist.ResumeLayout(false);
            this.gbAddArtist.PerformLayout();
            this.gbUpdateArtist.ResumeLayout(false);
            this.gbUpdateArtist.PerformLayout();
            this.menuArtist.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcInventory;
        private System.Windows.Forms.TabPage tabArtist;
        private System.Windows.Forms.TabPage tabAlbums;
        private System.Windows.Forms.TabPage tabGenre;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.GroupBox gbAddArtist;
        private System.Windows.Forms.DataGridView gridArtist;
        private System.Windows.Forms.Button btnAddArtist;
        private System.Windows.Forms.Label lblArtistName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gbUpdateArtist;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ContextMenuStrip menuArtist;
        private System.Windows.Forms.ToolStripMenuItem miDeleteArtist;
    }
}