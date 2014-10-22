﻿namespace Music_Store
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
            this.gbAddArtist = new System.Windows.Forms.GroupBox();
            this.btnAddArtist = new System.Windows.Forms.Button();
            this.lblArtistName = new System.Windows.Forms.Label();
            this.txtArtistName = new System.Windows.Forms.TextBox();
            this.gvArtist = new System.Windows.Forms.DataGridView();
            this.menuArtist = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miDeleteArtist = new System.Windows.Forms.ToolStripMenuItem();
            this.miEditArtist = new System.Windows.Forms.ToolStripMenuItem();
            this.tabAlbums = new System.Windows.Forms.TabPage();
            this.gbAddAlbum = new System.Windows.Forms.GroupBox();
            this.udAlbumQty = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlbumPrice = new System.Windows.Forms.TextBox();
            this.cbAlbumGenre = new System.Windows.Forms.ComboBox();
            this.cbAlbumArtist = new System.Windows.Forms.ComboBox();
            this.btnAddAlbum = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlbumName = new System.Windows.Forms.TextBox();
            this.gvAlbums = new System.Windows.Forms.DataGridView();
            this.tabGenre = new System.Windows.Forms.TabPage();
            this.gbAddGenre = new System.Windows.Forms.GroupBox();
            this.txtGenreDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGenreName = new System.Windows.Forms.TextBox();
            this.gvGenres = new System.Windows.Forms.DataGridView();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.gbAddCustomer = new System.Windows.Forms.GroupBox();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCustomerLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCustomerFirstName = new System.Windows.Forms.TextBox();
            this.gvCustomers = new System.Windows.Forms.DataGridView();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.gbAddEmployee = new System.Windows.Forms.GroupBox();
            this.txtEmployeeAnswer = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbEmployeSeqQuestions = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtEmployeeFirstName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEmployeeLastName = new System.Windows.Forms.TextBox();
            this.chkEmployeeAdmin = new System.Windows.Forms.CheckBox();
            this.dtDemployeeHireDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmployeePass = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEmployeeLogin = new System.Windows.Forms.TextBox();
            this.gvEmployees = new System.Windows.Forms.DataGridView();
            this.tcInventory.SuspendLayout();
            this.tabArtist.SuspendLayout();
            this.gbAddArtist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvArtist)).BeginInit();
            this.menuArtist.SuspendLayout();
            this.tabAlbums.SuspendLayout();
            this.gbAddAlbum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udAlbumQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAlbums)).BeginInit();
            this.tabGenre.SuspendLayout();
            this.gbAddGenre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGenres)).BeginInit();
            this.tabCustomer.SuspendLayout();
            this.gbAddCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomers)).BeginInit();
            this.tabEmployee.SuspendLayout();
            this.gbAddEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployees)).BeginInit();
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
            this.tcInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcInventory.Location = new System.Drawing.Point(0, 0);
            this.tcInventory.Name = "tcInventory";
            this.tcInventory.SelectedIndex = 0;
            this.tcInventory.Size = new System.Drawing.Size(984, 662);
            this.tcInventory.TabIndex = 0;
            // 
            // tabArtist
            // 
            this.tabArtist.BackColor = System.Drawing.SystemColors.Control;
            this.tabArtist.Controls.Add(this.gbAddArtist);
            this.tabArtist.Controls.Add(this.gvArtist);
            this.tabArtist.Location = new System.Drawing.Point(4, 25);
            this.tabArtist.Name = "tabArtist";
            this.tabArtist.Padding = new System.Windows.Forms.Padding(3);
            this.tabArtist.Size = new System.Drawing.Size(976, 633);
            this.tabArtist.TabIndex = 0;
            this.tabArtist.Text = "Artists";
            // 
            // gbAddArtist
            // 
            this.gbAddArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAddArtist.Controls.Add(this.btnAddArtist);
            this.gbAddArtist.Controls.Add(this.lblArtistName);
            this.gbAddArtist.Controls.Add(this.txtArtistName);
            this.gbAddArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddArtist.Location = new System.Drawing.Point(659, 6);
            this.gbAddArtist.Name = "gbAddArtist";
            this.gbAddArtist.Size = new System.Drawing.Size(309, 147);
            this.gbAddArtist.TabIndex = 1;
            this.gbAddArtist.TabStop = false;
            this.gbAddArtist.Text = "Add Artist";
            // 
            // btnAddArtist
            // 
            this.btnAddArtist.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddArtist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddArtist.Location = new System.Drawing.Point(164, 74);
            this.btnAddArtist.Name = "btnAddArtist";
            this.btnAddArtist.Size = new System.Drawing.Size(100, 50);
            this.btnAddArtist.TabIndex = 1;
            this.btnAddArtist.Text = "Add Artist";
            this.btnAddArtist.UseVisualStyleBackColor = false;
            this.btnAddArtist.Click += new System.EventHandler(this.btnAddArtist_Click);
            // 
            // lblArtistName
            // 
            this.lblArtistName.AutoSize = true;
            this.lblArtistName.Location = new System.Drawing.Point(18, 32);
            this.lblArtistName.Name = "lblArtistName";
            this.lblArtistName.Size = new System.Drawing.Size(81, 17);
            this.lblArtistName.TabIndex = 1;
            this.lblArtistName.Text = "Artist Name";
            // 
            // txtArtistName
            // 
            this.txtArtistName.Location = new System.Drawing.Point(105, 29);
            this.txtArtistName.Name = "txtArtistName";
            this.txtArtistName.Size = new System.Drawing.Size(159, 23);
            this.txtArtistName.TabIndex = 0;
            // 
            // gvArtist
            // 
            this.gvArtist.AllowUserToAddRows = false;
            this.gvArtist.AllowUserToDeleteRows = false;
            this.gvArtist.AllowUserToOrderColumns = true;
            this.gvArtist.AllowUserToResizeColumns = false;
            this.gvArtist.AllowUserToResizeRows = false;
            this.gvArtist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvArtist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvArtist.ContextMenuStrip = this.menuArtist;
            this.gvArtist.Dock = System.Windows.Forms.DockStyle.Left;
            this.gvArtist.Location = new System.Drawing.Point(3, 3);
            this.gvArtist.MultiSelect = false;
            this.gvArtist.Name = "gvArtist";
            this.gvArtist.ReadOnly = true;
            this.gvArtist.RowHeadersVisible = false;
            this.gvArtist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvArtist.ShowEditingIcon = false;
            this.gvArtist.Size = new System.Drawing.Size(650, 627);
            this.gvArtist.TabIndex = 0;
            // 
            // menuArtist
            // 
            this.menuArtist.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDeleteArtist,
            this.miEditArtist});
            this.menuArtist.Name = "menuArtist";
            this.menuArtist.Size = new System.Drawing.Size(143, 48);
            this.menuArtist.Opening += new System.ComponentModel.CancelEventHandler(this.menuArtist_Opening);
            // 
            // miDeleteArtist
            // 
            this.miDeleteArtist.Name = "miDeleteArtist";
            this.miDeleteArtist.Size = new System.Drawing.Size(142, 22);
            this.miDeleteArtist.Text = "Delete Artrist";
            this.miDeleteArtist.Click += new System.EventHandler(this.miDeleteArtist_Click);
            // 
            // miEditArtist
            // 
            this.miEditArtist.Name = "miEditArtist";
            this.miEditArtist.Size = new System.Drawing.Size(142, 22);
            this.miEditArtist.Text = "Edit Artist";
            // 
            // tabAlbums
            // 
            this.tabAlbums.BackColor = System.Drawing.SystemColors.Control;
            this.tabAlbums.Controls.Add(this.gbAddAlbum);
            this.tabAlbums.Controls.Add(this.gvAlbums);
            this.tabAlbums.Location = new System.Drawing.Point(4, 25);
            this.tabAlbums.Name = "tabAlbums";
            this.tabAlbums.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlbums.Size = new System.Drawing.Size(976, 633);
            this.tabAlbums.TabIndex = 1;
            this.tabAlbums.Text = "Albums";
            // 
            // gbAddAlbum
            // 
            this.gbAddAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAddAlbum.Controls.Add(this.udAlbumQty);
            this.gbAddAlbum.Controls.Add(this.label6);
            this.gbAddAlbum.Controls.Add(this.label5);
            this.gbAddAlbum.Controls.Add(this.label4);
            this.gbAddAlbum.Controls.Add(this.label2);
            this.gbAddAlbum.Controls.Add(this.txtAlbumPrice);
            this.gbAddAlbum.Controls.Add(this.cbAlbumGenre);
            this.gbAddAlbum.Controls.Add(this.cbAlbumArtist);
            this.gbAddAlbum.Controls.Add(this.btnAddAlbum);
            this.gbAddAlbum.Controls.Add(this.label3);
            this.gbAddAlbum.Controls.Add(this.txtAlbumName);
            this.gbAddAlbum.Location = new System.Drawing.Point(659, 7);
            this.gbAddAlbum.Name = "gbAddAlbum";
            this.gbAddAlbum.Size = new System.Drawing.Size(313, 317);
            this.gbAddAlbum.TabIndex = 4;
            this.gbAddAlbum.TabStop = false;
            this.gbAddAlbum.Text = "Add Album";
            // 
            // udAlbumQty
            // 
            this.udAlbumQty.Location = new System.Drawing.Point(113, 190);
            this.udAlbumQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udAlbumQty.Name = "udAlbumQty";
            this.udAlbumQty.Size = new System.Drawing.Size(70, 23);
            this.udAlbumQty.TabIndex = 4;
            this.udAlbumQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.udAlbumQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Artist:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Genre:";
            // 
            // txtAlbumPrice
            // 
            this.txtAlbumPrice.Location = new System.Drawing.Point(113, 147);
            this.txtAlbumPrice.Name = "txtAlbumPrice";
            this.txtAlbumPrice.Size = new System.Drawing.Size(70, 23);
            this.txtAlbumPrice.TabIndex = 3;
            this.txtAlbumPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbAlbumGenre
            // 
            this.cbAlbumGenre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAlbumGenre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAlbumGenre.FormattingEnabled = true;
            this.cbAlbumGenre.Location = new System.Drawing.Point(113, 107);
            this.cbAlbumGenre.Name = "cbAlbumGenre";
            this.cbAlbumGenre.Size = new System.Drawing.Size(150, 24);
            this.cbAlbumGenre.TabIndex = 2;
            // 
            // cbAlbumArtist
            // 
            this.cbAlbumArtist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAlbumArtist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAlbumArtist.FormattingEnabled = true;
            this.cbAlbumArtist.Location = new System.Drawing.Point(113, 67);
            this.cbAlbumArtist.Name = "cbAlbumArtist";
            this.cbAlbumArtist.Size = new System.Drawing.Size(150, 24);
            this.cbAlbumArtist.TabIndex = 1;
            // 
            // btnAddAlbum
            // 
            this.btnAddAlbum.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAlbum.Location = new System.Drawing.Point(163, 247);
            this.btnAddAlbum.Name = "btnAddAlbum";
            this.btnAddAlbum.Size = new System.Drawing.Size(100, 50);
            this.btnAddAlbum.TabIndex = 5;
            this.btnAddAlbum.Text = "Add Album";
            this.btnAddAlbum.UseVisualStyleBackColor = false;
            this.btnAddAlbum.Click += new System.EventHandler(this.btnAddAlbum_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Album Name:";
            // 
            // txtAlbumName
            // 
            this.txtAlbumName.Location = new System.Drawing.Point(113, 29);
            this.txtAlbumName.Name = "txtAlbumName";
            this.txtAlbumName.Size = new System.Drawing.Size(150, 23);
            this.txtAlbumName.TabIndex = 0;
            // 
            // gvAlbums
            // 
            this.gvAlbums.AllowUserToAddRows = false;
            this.gvAlbums.AllowUserToDeleteRows = false;
            this.gvAlbums.AllowUserToOrderColumns = true;
            this.gvAlbums.AllowUserToResizeColumns = false;
            this.gvAlbums.AllowUserToResizeRows = false;
            this.gvAlbums.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAlbums.ContextMenuStrip = this.menuArtist;
            this.gvAlbums.Dock = System.Windows.Forms.DockStyle.Left;
            this.gvAlbums.Location = new System.Drawing.Point(3, 3);
            this.gvAlbums.MultiSelect = false;
            this.gvAlbums.Name = "gvAlbums";
            this.gvAlbums.ReadOnly = true;
            this.gvAlbums.RowHeadersVisible = false;
            this.gvAlbums.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvAlbums.Size = new System.Drawing.Size(650, 627);
            this.gvAlbums.TabIndex = 3;
            // 
            // tabGenre
            // 
            this.tabGenre.BackColor = System.Drawing.SystemColors.Control;
            this.tabGenre.Controls.Add(this.gbAddGenre);
            this.tabGenre.Controls.Add(this.gvGenres);
            this.tabGenre.Location = new System.Drawing.Point(4, 25);
            this.tabGenre.Name = "tabGenre";
            this.tabGenre.Padding = new System.Windows.Forms.Padding(3);
            this.tabGenre.Size = new System.Drawing.Size(976, 633);
            this.tabGenre.TabIndex = 2;
            this.tabGenre.Text = "Genres";
            // 
            // gbAddGenre
            // 
            this.gbAddGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAddGenre.Controls.Add(this.txtGenreDesc);
            this.gbAddGenre.Controls.Add(this.lblDesc);
            this.gbAddGenre.Controls.Add(this.btnAddGenre);
            this.gbAddGenre.Controls.Add(this.label7);
            this.gbAddGenre.Controls.Add(this.txtGenreName);
            this.gbAddGenre.Location = new System.Drawing.Point(659, 7);
            this.gbAddGenre.Name = "gbAddGenre";
            this.gbAddGenre.Size = new System.Drawing.Size(313, 256);
            this.gbAddGenre.TabIndex = 3;
            this.gbAddGenre.TabStop = false;
            this.gbAddGenre.Text = "Add Genre";
            // 
            // txtGenreDesc
            // 
            this.txtGenreDesc.Location = new System.Drawing.Point(115, 75);
            this.txtGenreDesc.Multiline = true;
            this.txtGenreDesc.Name = "txtGenreDesc";
            this.txtGenreDesc.Size = new System.Drawing.Size(150, 94);
            this.txtGenreDesc.TabIndex = 1;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(30, 78);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(79, 17);
            this.lblDesc.TabIndex = 3;
            this.lblDesc.Text = "Description";
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGenre.Location = new System.Drawing.Point(165, 189);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(100, 50);
            this.btnAddGenre.TabIndex = 2;
            this.btnAddGenre.Text = "Add Genre";
            this.btnAddGenre.UseVisualStyleBackColor = false;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Genre Name";
            // 
            // txtGenreName
            // 
            this.txtGenreName.Location = new System.Drawing.Point(115, 27);
            this.txtGenreName.Name = "txtGenreName";
            this.txtGenreName.Size = new System.Drawing.Size(150, 23);
            this.txtGenreName.TabIndex = 0;
            // 
            // gvGenres
            // 
            this.gvGenres.AllowUserToAddRows = false;
            this.gvGenres.AllowUserToDeleteRows = false;
            this.gvGenres.AllowUserToOrderColumns = true;
            this.gvGenres.AllowUserToResizeColumns = false;
            this.gvGenres.AllowUserToResizeRows = false;
            this.gvGenres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGenres.ContextMenuStrip = this.menuArtist;
            this.gvGenres.Dock = System.Windows.Forms.DockStyle.Left;
            this.gvGenres.Location = new System.Drawing.Point(3, 3);
            this.gvGenres.MultiSelect = false;
            this.gvGenres.Name = "gvGenres";
            this.gvGenres.ReadOnly = true;
            this.gvGenres.RowHeadersVisible = false;
            this.gvGenres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvGenres.Size = new System.Drawing.Size(650, 627);
            this.gvGenres.TabIndex = 2;
            // 
            // tabCustomer
            // 
            this.tabCustomer.BackColor = System.Drawing.SystemColors.Control;
            this.tabCustomer.Controls.Add(this.gbAddCustomer);
            this.tabCustomer.Controls.Add(this.gvCustomers);
            this.tabCustomer.Location = new System.Drawing.Point(4, 25);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomer.Size = new System.Drawing.Size(976, 633);
            this.tabCustomer.TabIndex = 3;
            this.tabCustomer.Text = "Customers";
            // 
            // gbAddCustomer
            // 
            this.gbAddCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAddCustomer.Controls.Add(this.txtCustomerEmail);
            this.gbAddCustomer.Controls.Add(this.label10);
            this.gbAddCustomer.Controls.Add(this.txtCustomerPhone);
            this.gbAddCustomer.Controls.Add(this.label9);
            this.gbAddCustomer.Controls.Add(this.txtCustomerLastName);
            this.gbAddCustomer.Controls.Add(this.label1);
            this.gbAddCustomer.Controls.Add(this.btnAddCustomer);
            this.gbAddCustomer.Controls.Add(this.label8);
            this.gbAddCustomer.Controls.Add(this.txtCustomerFirstName);
            this.gbAddCustomer.Location = new System.Drawing.Point(659, 7);
            this.gbAddCustomer.Name = "gbAddCustomer";
            this.gbAddCustomer.Size = new System.Drawing.Size(313, 287);
            this.gbAddCustomer.TabIndex = 5;
            this.gbAddCustomer.TabStop = false;
            this.gbAddCustomer.Text = "Add Customer";
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(105, 150);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(167, 23);
            this.txtCustomerEmail.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Email:";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(105, 107);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(167, 23);
            this.txtCustomerPhone.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Phone #:";
            // 
            // txtCustomerLastName
            // 
            this.txtCustomerLastName.Location = new System.Drawing.Point(105, 67);
            this.txtCustomerLastName.Name = "txtCustomerLastName";
            this.txtCustomerLastName.Size = new System.Drawing.Size(167, 23);
            this.txtCustomerLastName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Last Name:";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Location = new System.Drawing.Point(172, 222);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(100, 50);
            this.btnAddCustomer.TabIndex = 4;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "First Name:";
            // 
            // txtCustomerFirstName
            // 
            this.txtCustomerFirstName.Location = new System.Drawing.Point(102, 27);
            this.txtCustomerFirstName.Name = "txtCustomerFirstName";
            this.txtCustomerFirstName.Size = new System.Drawing.Size(170, 23);
            this.txtCustomerFirstName.TabIndex = 0;
            // 
            // gvCustomers
            // 
            this.gvCustomers.AllowUserToAddRows = false;
            this.gvCustomers.AllowUserToDeleteRows = false;
            this.gvCustomers.AllowUserToOrderColumns = true;
            this.gvCustomers.AllowUserToResizeColumns = false;
            this.gvCustomers.AllowUserToResizeRows = false;
            this.gvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCustomers.ContextMenuStrip = this.menuArtist;
            this.gvCustomers.Dock = System.Windows.Forms.DockStyle.Left;
            this.gvCustomers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvCustomers.Location = new System.Drawing.Point(3, 3);
            this.gvCustomers.MultiSelect = false;
            this.gvCustomers.Name = "gvCustomers";
            this.gvCustomers.ReadOnly = true;
            this.gvCustomers.RowHeadersVisible = false;
            this.gvCustomers.Size = new System.Drawing.Size(650, 627);
            this.gvCustomers.TabIndex = 4;
            // 
            // tabEmployee
            // 
            this.tabEmployee.BackColor = System.Drawing.SystemColors.Control;
            this.tabEmployee.Controls.Add(this.gbAddEmployee);
            this.tabEmployee.Controls.Add(this.gvEmployees);
            this.tabEmployee.Location = new System.Drawing.Point(4, 25);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployee.Size = new System.Drawing.Size(976, 633);
            this.tabEmployee.TabIndex = 4;
            this.tabEmployee.Text = "Employees";
            // 
            // gbAddEmployee
            // 
            this.gbAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAddEmployee.Controls.Add(this.txtEmployeeAnswer);
            this.gbAddEmployee.Controls.Add(this.label18);
            this.gbAddEmployee.Controls.Add(this.cbEmployeSeqQuestions);
            this.gbAddEmployee.Controls.Add(this.label17);
            this.gbAddEmployee.Controls.Add(this.label16);
            this.gbAddEmployee.Controls.Add(this.txtEmployeeFirstName);
            this.gbAddEmployee.Controls.Add(this.label15);
            this.gbAddEmployee.Controls.Add(this.txtEmployeeLastName);
            this.gbAddEmployee.Controls.Add(this.chkEmployeeAdmin);
            this.gbAddEmployee.Controls.Add(this.dtDemployeeHireDate);
            this.gbAddEmployee.Controls.Add(this.label11);
            this.gbAddEmployee.Controls.Add(this.label12);
            this.gbAddEmployee.Controls.Add(this.txtEmployeePass);
            this.gbAddEmployee.Controls.Add(this.label13);
            this.gbAddEmployee.Controls.Add(this.btnAddEmployee);
            this.gbAddEmployee.Controls.Add(this.label14);
            this.gbAddEmployee.Controls.Add(this.txtEmployeeLogin);
            this.gbAddEmployee.Location = new System.Drawing.Point(659, 7);
            this.gbAddEmployee.Name = "gbAddEmployee";
            this.gbAddEmployee.Size = new System.Drawing.Size(313, 505);
            this.gbAddEmployee.TabIndex = 7;
            this.gbAddEmployee.TabStop = false;
            this.gbAddEmployee.Text = "Add Employee";
            // 
            // txtEmployeeAnswer
            // 
            this.txtEmployeeAnswer.Location = new System.Drawing.Point(22, 310);
            this.txtEmployeeAnswer.Name = "txtEmployeeAnswer";
            this.txtEmployeeAnswer.PasswordChar = '*';
            this.txtEmployeeAnswer.Size = new System.Drawing.Size(268, 23);
            this.txtEmployeeAnswer.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 279);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 17);
            this.label18.TabIndex = 17;
            this.label18.Text = "Answer:";
            // 
            // cbEmployeSeqQuestions
            // 
            this.cbEmployeSeqQuestions.FormattingEnabled = true;
            this.cbEmployeSeqQuestions.Location = new System.Drawing.Point(22, 239);
            this.cbEmployeSeqQuestions.Name = "cbEmployeSeqQuestions";
            this.cbEmployeSeqQuestions.Size = new System.Drawing.Size(268, 24);
            this.cbEmployeSeqQuestions.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 209);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 17);
            this.label17.TabIndex = 15;
            this.label17.Text = "Security Question:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 17);
            this.label16.TabIndex = 14;
            this.label16.Text = "First Name:";
            // 
            // txtEmployeeFirstName
            // 
            this.txtEmployeeFirstName.Location = new System.Drawing.Point(102, 27);
            this.txtEmployeeFirstName.Name = "txtEmployeeFirstName";
            this.txtEmployeeFirstName.Size = new System.Drawing.Size(188, 23);
            this.txtEmployeeFirstName.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 17);
            this.label15.TabIndex = 12;
            this.label15.Text = "Last Name:";
            // 
            // txtEmployeeLastName
            // 
            this.txtEmployeeLastName.Location = new System.Drawing.Point(102, 70);
            this.txtEmployeeLastName.Name = "txtEmployeeLastName";
            this.txtEmployeeLastName.Size = new System.Drawing.Size(188, 23);
            this.txtEmployeeLastName.TabIndex = 1;
            // 
            // chkEmployeeAdmin
            // 
            this.chkEmployeeAdmin.AutoSize = true;
            this.chkEmployeeAdmin.Location = new System.Drawing.Point(107, 456);
            this.chkEmployeeAdmin.Name = "chkEmployeeAdmin";
            this.chkEmployeeAdmin.Size = new System.Drawing.Size(15, 14);
            this.chkEmployeeAdmin.TabIndex = 7;
            this.chkEmployeeAdmin.UseVisualStyleBackColor = true;
            // 
            // dtDemployeeHireDate
            // 
            this.dtDemployeeHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDemployeeHireDate.Location = new System.Drawing.Point(107, 388);
            this.dtDemployeeHireDate.Name = "dtDemployeeHireDate";
            this.dtDemployeeHireDate.Size = new System.Drawing.Size(183, 23);
            this.dtDemployeeHireDate.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 454);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Admin:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 393);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "Date Hired:";
            // 
            // txtEmployeePass
            // 
            this.txtEmployeePass.Location = new System.Drawing.Point(107, 150);
            this.txtEmployeePass.Name = "txtEmployeePass";
            this.txtEmployeePass.PasswordChar = '*';
            this.txtEmployeePass.Size = new System.Drawing.Size(183, 23);
            this.txtEmployeePass.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "Password:";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Location = new System.Drawing.Point(162, 437);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(100, 50);
            this.btnAddEmployee.TabIndex = 8;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(36, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 17);
            this.label14.TabIndex = 1;
            this.label14.Text = "Login ID:";
            // 
            // txtEmployeeLogin
            // 
            this.txtEmployeeLogin.Location = new System.Drawing.Point(106, 110);
            this.txtEmployeeLogin.Name = "txtEmployeeLogin";
            this.txtEmployeeLogin.Size = new System.Drawing.Size(184, 23);
            this.txtEmployeeLogin.TabIndex = 2;
            // 
            // gvEmployees
            // 
            this.gvEmployees.AllowUserToAddRows = false;
            this.gvEmployees.AllowUserToDeleteRows = false;
            this.gvEmployees.AllowUserToOrderColumns = true;
            this.gvEmployees.AllowUserToResizeColumns = false;
            this.gvEmployees.AllowUserToResizeRows = false;
            this.gvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEmployees.ContextMenuStrip = this.menuArtist;
            this.gvEmployees.Dock = System.Windows.Forms.DockStyle.Left;
            this.gvEmployees.Location = new System.Drawing.Point(3, 3);
            this.gvEmployees.MultiSelect = false;
            this.gvEmployees.Name = "gvEmployees";
            this.gvEmployees.ReadOnly = true;
            this.gvEmployees.RowHeadersVisible = false;
            this.gvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvEmployees.Size = new System.Drawing.Size(650, 627);
            this.gvEmployees.TabIndex = 6;
            // 
            // formInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.tcInventory);
            this.MaximizeBox = false;
            this.Name = "formInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Inventory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formInventory_FormClosing);
            this.tcInventory.ResumeLayout(false);
            this.tabArtist.ResumeLayout(false);
            this.gbAddArtist.ResumeLayout(false);
            this.gbAddArtist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvArtist)).EndInit();
            this.menuArtist.ResumeLayout(false);
            this.tabAlbums.ResumeLayout(false);
            this.gbAddAlbum.ResumeLayout(false);
            this.gbAddAlbum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udAlbumQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAlbums)).EndInit();
            this.tabGenre.ResumeLayout(false);
            this.gbAddGenre.ResumeLayout(false);
            this.gbAddGenre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGenres)).EndInit();
            this.tabCustomer.ResumeLayout(false);
            this.gbAddCustomer.ResumeLayout(false);
            this.gbAddCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomers)).EndInit();
            this.tabEmployee.ResumeLayout(false);
            this.gbAddEmployee.ResumeLayout(false);
            this.gbAddEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployees)).EndInit();
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
        private System.Windows.Forms.DataGridView gvArtist;
        private System.Windows.Forms.Button btnAddArtist;
        private System.Windows.Forms.Label lblArtistName;
        private System.Windows.Forms.TextBox txtArtistName;
        private System.Windows.Forms.ContextMenuStrip menuArtist;
        private System.Windows.Forms.ToolStripMenuItem miDeleteArtist;
        private System.Windows.Forms.GroupBox gbAddAlbum;
        private System.Windows.Forms.Button btnAddAlbum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlbumName;
        private System.Windows.Forms.DataGridView gvAlbums;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAlbumPrice;
        private System.Windows.Forms.ComboBox cbAlbumGenre;
        private System.Windows.Forms.ComboBox cbAlbumArtist;
        private System.Windows.Forms.NumericUpDown udAlbumQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbAddGenre;
        private System.Windows.Forms.TextBox txtGenreDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGenreName;
        private System.Windows.Forms.DataGridView gvGenres;
        private System.Windows.Forms.GroupBox gbAddCustomer;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCustomerLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCustomerFirstName;
        private System.Windows.Forms.DataGridView gvCustomers;
        private System.Windows.Forms.GroupBox gbAddEmployee;
        private System.Windows.Forms.CheckBox chkEmployeeAdmin;
        private System.Windows.Forms.DateTimePicker dtDemployeeHireDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEmployeePass;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEmployeeLogin;
        private System.Windows.Forms.DataGridView gvEmployees;
        private System.Windows.Forms.TextBox txtEmployeeAnswer;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbEmployeSeqQuestions;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtEmployeeFirstName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEmployeeLastName;
        private System.Windows.Forms.ToolStripMenuItem miEditArtist;
    }
}