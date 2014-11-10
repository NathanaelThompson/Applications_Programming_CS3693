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
            this.lblArtistError = new System.Windows.Forms.Label();
            this.gbAddArtist = new System.Windows.Forms.GroupBox();
            this.btnAddArtist = new System.Windows.Forms.Button();
            this.lblArtistName = new System.Windows.Forms.Label();
            this.txtArtistName = new System.Windows.Forms.TextBox();
            this.gvArtist = new System.Windows.Forms.DataGridView();
            this.menuArtist = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miDeleteArtist = new System.Windows.Forms.ToolStripMenuItem();
            this.miEditArtist = new System.Windows.Forms.ToolStripMenuItem();
            this.tabAlbums = new System.Windows.Forms.TabPage();
            this.lblAlbumError = new System.Windows.Forms.Label();
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
            this.lblGenreError = new System.Windows.Forms.Label();
            this.gbAddGenre = new System.Windows.Forms.GroupBox();
            this.txtGenreDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGenreName = new System.Windows.Forms.TextBox();
            this.gvGenres = new System.Windows.Forms.DataGridView();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.lblCustomerError = new System.Windows.Forms.Label();
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
            this.lblEmployeeError = new System.Windows.Forms.Label();
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
            this.tcInventory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tcInventory.Name = "tcInventory";
            this.tcInventory.SelectedIndex = 0;
            this.tcInventory.Size = new System.Drawing.Size(1312, 815);
            this.tcInventory.TabIndex = 0;
            // 
            // tabArtist
            // 
            this.tabArtist.BackColor = System.Drawing.SystemColors.Control;
            this.tabArtist.Controls.Add(this.lblArtistError);
            this.tabArtist.Controls.Add(this.gbAddArtist);
            this.tabArtist.Controls.Add(this.gvArtist);
            this.tabArtist.Location = new System.Drawing.Point(4, 29);
            this.tabArtist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabArtist.Name = "tabArtist";
            this.tabArtist.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabArtist.Size = new System.Drawing.Size(1304, 782);
            this.tabArtist.TabIndex = 0;
            this.tabArtist.Text = "Artists";
            // 
            // lblArtistError
            // 
            this.lblArtistError.AutoSize = true;
            this.lblArtistError.ForeColor = System.Drawing.Color.Red;
            this.lblArtistError.Location = new System.Drawing.Point(879, 192);
            this.lblArtistError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArtistError.Name = "lblArtistError";
            this.lblArtistError.Size = new System.Drawing.Size(130, 20);
            this.lblArtistError.TabIndex = 2;
            this.lblArtistError.Text = "[Error Message]";
            this.lblArtistError.Visible = false;
            // 
            // gbAddArtist
            // 
            this.gbAddArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAddArtist.Controls.Add(this.btnAddArtist);
            this.gbAddArtist.Controls.Add(this.lblArtistName);
            this.gbAddArtist.Controls.Add(this.txtArtistName);
            this.gbAddArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddArtist.Location = new System.Drawing.Point(879, 7);
            this.gbAddArtist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAddArtist.Name = "gbAddArtist";
            this.gbAddArtist.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAddArtist.Size = new System.Drawing.Size(412, 181);
            this.gbAddArtist.TabIndex = 1;
            this.gbAddArtist.TabStop = false;
            this.gbAddArtist.Text = "Add Artist";
            // 
            // btnAddArtist
            // 
            this.btnAddArtist.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddArtist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddArtist.Location = new System.Drawing.Point(253, 91);
            this.btnAddArtist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddArtist.Name = "btnAddArtist";
            this.btnAddArtist.Size = new System.Drawing.Size(133, 62);
            this.btnAddArtist.TabIndex = 1;
            this.btnAddArtist.Text = "Add Artist";
            this.btnAddArtist.UseVisualStyleBackColor = false;
            this.btnAddArtist.Click += new System.EventHandler(this.btnAddArtist_Click);
            // 
            // lblArtistName
            // 
            this.lblArtistName.AutoSize = true;
            this.lblArtistName.Location = new System.Drawing.Point(8, 48);
            this.lblArtistName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArtistName.Name = "lblArtistName";
            this.lblArtistName.Size = new System.Drawing.Size(103, 20);
            this.lblArtistName.TabIndex = 1;
            this.lblArtistName.Text = "Artist Name:";
            // 
            // txtArtistName
            // 
            this.txtArtistName.Location = new System.Drawing.Point(159, 48);
            this.txtArtistName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtArtistName.Name = "txtArtistName";
            this.txtArtistName.Size = new System.Drawing.Size(245, 26);
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
            this.gvArtist.Location = new System.Drawing.Point(4, 4);
            this.gvArtist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gvArtist.MultiSelect = false;
            this.gvArtist.Name = "gvArtist";
            this.gvArtist.ReadOnly = true;
            this.gvArtist.RowHeadersVisible = false;
            this.gvArtist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvArtist.ShowEditingIcon = false;
            this.gvArtist.Size = new System.Drawing.Size(867, 774);
            this.gvArtist.TabIndex = 0;
            // 
            // menuArtist
            // 
            this.menuArtist.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDeleteArtist,
            this.miEditArtist});
            this.menuArtist.Name = "menuArtist";
            this.menuArtist.Size = new System.Drawing.Size(167, 52);
            this.menuArtist.Opening += new System.ComponentModel.CancelEventHandler(this.menuArtist_Opening);
            // 
            // miDeleteArtist
            // 
            this.miDeleteArtist.Name = "miDeleteArtist";
            this.miDeleteArtist.Size = new System.Drawing.Size(166, 24);
            this.miDeleteArtist.Text = "Delete Artrist";
            this.miDeleteArtist.Click += new System.EventHandler(this.miDeleteArtist_Click);
            // 
            // miEditArtist
            // 
            this.miEditArtist.Name = "miEditArtist";
            this.miEditArtist.Size = new System.Drawing.Size(166, 24);
            this.miEditArtist.Text = "Edit Artist";
            // 
            // tabAlbums
            // 
            this.tabAlbums.BackColor = System.Drawing.SystemColors.Control;
            this.tabAlbums.Controls.Add(this.lblAlbumError);
            this.tabAlbums.Controls.Add(this.gbAddAlbum);
            this.tabAlbums.Controls.Add(this.gvAlbums);
            this.tabAlbums.Location = new System.Drawing.Point(4, 29);
            this.tabAlbums.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAlbums.Name = "tabAlbums";
            this.tabAlbums.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAlbums.Size = new System.Drawing.Size(1304, 782);
            this.tabAlbums.TabIndex = 1;
            this.tabAlbums.Text = "Albums";
            // 
            // lblAlbumError
            // 
            this.lblAlbumError.AutoSize = true;
            this.lblAlbumError.ForeColor = System.Drawing.Color.Red;
            this.lblAlbumError.Location = new System.Drawing.Point(875, 402);
            this.lblAlbumError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlbumError.Name = "lblAlbumError";
            this.lblAlbumError.Size = new System.Drawing.Size(130, 20);
            this.lblAlbumError.TabIndex = 5;
            this.lblAlbumError.Text = "[Error Message]";
            this.lblAlbumError.Visible = false;
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
            this.gbAddAlbum.Location = new System.Drawing.Point(879, 9);
            this.gbAddAlbum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAddAlbum.Name = "gbAddAlbum";
            this.gbAddAlbum.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAddAlbum.Size = new System.Drawing.Size(417, 390);
            this.gbAddAlbum.TabIndex = 4;
            this.gbAddAlbum.TabStop = false;
            this.gbAddAlbum.Text = "Add Album";
            // 
            // udAlbumQty
            // 
            this.udAlbumQty.Location = new System.Drawing.Point(151, 234);
            this.udAlbumQty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.udAlbumQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udAlbumQty.Name = "udAlbumQty";
            this.udAlbumQty.Size = new System.Drawing.Size(93, 26);
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
            this.label6.Location = new System.Drawing.Point(84, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Artist:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Genre:";
            // 
            // txtAlbumPrice
            // 
            this.txtAlbumPrice.Location = new System.Drawing.Point(151, 181);
            this.txtAlbumPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAlbumPrice.Name = "txtAlbumPrice";
            this.txtAlbumPrice.Size = new System.Drawing.Size(92, 26);
            this.txtAlbumPrice.TabIndex = 3;
            this.txtAlbumPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbAlbumGenre
            // 
            this.cbAlbumGenre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAlbumGenre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAlbumGenre.FormattingEnabled = true;
            this.cbAlbumGenre.Location = new System.Drawing.Point(163, 132);
            this.cbAlbumGenre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAlbumGenre.Name = "cbAlbumGenre";
            this.cbAlbumGenre.Size = new System.Drawing.Size(233, 28);
            this.cbAlbumGenre.TabIndex = 2;
            // 
            // cbAlbumArtist
            // 
            this.cbAlbumArtist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAlbumArtist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAlbumArtist.FormattingEnabled = true;
            this.cbAlbumArtist.Location = new System.Drawing.Point(163, 82);
            this.cbAlbumArtist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAlbumArtist.Name = "cbAlbumArtist";
            this.cbAlbumArtist.Size = new System.Drawing.Size(233, 28);
            this.cbAlbumArtist.TabIndex = 1;
            // 
            // btnAddAlbum
            // 
            this.btnAddAlbum.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAlbum.Location = new System.Drawing.Point(264, 302);
            this.btnAddAlbum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddAlbum.Name = "btnAddAlbum";
            this.btnAddAlbum.Size = new System.Drawing.Size(133, 62);
            this.btnAddAlbum.TabIndex = 5;
            this.btnAddAlbum.Text = "Add Album";
            this.btnAddAlbum.UseVisualStyleBackColor = false;
            this.btnAddAlbum.Click += new System.EventHandler(this.btnAddAlbum_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Album Name:";
            // 
            // txtAlbumName
            // 
            this.txtAlbumName.Location = new System.Drawing.Point(151, 36);
            this.txtAlbumName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAlbumName.Name = "txtAlbumName";
            this.txtAlbumName.Size = new System.Drawing.Size(245, 26);
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
            this.gvAlbums.Dock = System.Windows.Forms.DockStyle.Left;
            this.gvAlbums.Location = new System.Drawing.Point(4, 4);
            this.gvAlbums.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gvAlbums.MultiSelect = false;
            this.gvAlbums.Name = "gvAlbums";
            this.gvAlbums.ReadOnly = true;
            this.gvAlbums.RowHeadersVisible = false;
            this.gvAlbums.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvAlbums.Size = new System.Drawing.Size(867, 774);
            this.gvAlbums.TabIndex = 3;
            // 
            // tabGenre
            // 
            this.tabGenre.BackColor = System.Drawing.SystemColors.Control;
            this.tabGenre.Controls.Add(this.lblGenreError);
            this.tabGenre.Controls.Add(this.gbAddGenre);
            this.tabGenre.Controls.Add(this.gvGenres);
            this.tabGenre.Location = new System.Drawing.Point(4, 29);
            this.tabGenre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabGenre.Name = "tabGenre";
            this.tabGenre.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabGenre.Size = new System.Drawing.Size(1304, 782);
            this.tabGenre.TabIndex = 2;
            this.tabGenre.Text = "Genres";
            // 
            // lblGenreError
            // 
            this.lblGenreError.AutoSize = true;
            this.lblGenreError.ForeColor = System.Drawing.Color.Red;
            this.lblGenreError.Location = new System.Drawing.Point(879, 327);
            this.lblGenreError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenreError.Name = "lblGenreError";
            this.lblGenreError.Size = new System.Drawing.Size(130, 20);
            this.lblGenreError.TabIndex = 4;
            this.lblGenreError.Text = "[Error Message]";
            this.lblGenreError.Visible = false;
            // 
            // gbAddGenre
            // 
            this.gbAddGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAddGenre.Controls.Add(this.txtGenreDesc);
            this.gbAddGenre.Controls.Add(this.lblDesc);
            this.gbAddGenre.Controls.Add(this.btnAddGenre);
            this.gbAddGenre.Controls.Add(this.label7);
            this.gbAddGenre.Controls.Add(this.txtGenreName);
            this.gbAddGenre.Location = new System.Drawing.Point(879, 9);
            this.gbAddGenre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAddGenre.Name = "gbAddGenre";
            this.gbAddGenre.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAddGenre.Size = new System.Drawing.Size(417, 315);
            this.gbAddGenre.TabIndex = 3;
            this.gbAddGenre.TabStop = false;
            this.gbAddGenre.Text = "Add Genre";
            // 
            // txtGenreDesc
            // 
            this.txtGenreDesc.Location = new System.Drawing.Point(153, 92);
            this.txtGenreDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGenreDesc.Multiline = true;
            this.txtGenreDesc.Name = "txtGenreDesc";
            this.txtGenreDesc.Size = new System.Drawing.Size(245, 115);
            this.txtGenreDesc.TabIndex = 1;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(40, 96);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(95, 20);
            this.lblDesc.TabIndex = 3;
            this.lblDesc.Text = "Description";
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGenre.Location = new System.Drawing.Point(267, 233);
            this.btnAddGenre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(133, 62);
            this.btnAddGenre.TabIndex = 2;
            this.btnAddGenre.Text = "Add Genre";
            this.btnAddGenre.UseVisualStyleBackColor = false;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Genre Name";
            // 
            // txtGenreName
            // 
            this.txtGenreName.Location = new System.Drawing.Point(153, 33);
            this.txtGenreName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGenreName.Name = "txtGenreName";
            this.txtGenreName.Size = new System.Drawing.Size(245, 26);
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
            this.gvGenres.Dock = System.Windows.Forms.DockStyle.Left;
            this.gvGenres.Location = new System.Drawing.Point(4, 4);
            this.gvGenres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gvGenres.MultiSelect = false;
            this.gvGenres.Name = "gvGenres";
            this.gvGenres.ReadOnly = true;
            this.gvGenres.RowHeadersVisible = false;
            this.gvGenres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvGenres.Size = new System.Drawing.Size(867, 774);
            this.gvGenres.TabIndex = 2;
            // 
            // tabCustomer
            // 
            this.tabCustomer.BackColor = System.Drawing.SystemColors.Control;
            this.tabCustomer.Controls.Add(this.lblCustomerError);
            this.tabCustomer.Controls.Add(this.gbAddCustomer);
            this.tabCustomer.Controls.Add(this.gvCustomers);
            this.tabCustomer.Location = new System.Drawing.Point(4, 29);
            this.tabCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCustomer.Size = new System.Drawing.Size(1304, 782);
            this.tabCustomer.TabIndex = 3;
            this.tabCustomer.Text = "Customers";
            // 
            // lblCustomerError
            // 
            this.lblCustomerError.AutoSize = true;
            this.lblCustomerError.ForeColor = System.Drawing.Color.Red;
            this.lblCustomerError.Location = new System.Drawing.Point(879, 366);
            this.lblCustomerError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerError.Name = "lblCustomerError";
            this.lblCustomerError.Size = new System.Drawing.Size(130, 20);
            this.lblCustomerError.TabIndex = 6;
            this.lblCustomerError.Text = "[Error Message]";
            this.lblCustomerError.Visible = false;
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
            this.gbAddCustomer.Location = new System.Drawing.Point(879, 9);
            this.gbAddCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAddCustomer.Name = "gbAddCustomer";
            this.gbAddCustomer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAddCustomer.Size = new System.Drawing.Size(417, 353);
            this.gbAddCustomer.TabIndex = 5;
            this.gbAddCustomer.TabStop = false;
            this.gbAddCustomer.Text = "Add Customer";
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(140, 185);
            this.txtCustomerEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(241, 26);
            this.txtCustomerEmail.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 185);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Email:";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(140, 132);
            this.txtCustomerPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(241, 26);
            this.txtCustomerPhone.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 135);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Phone #:";
            // 
            // txtCustomerLastName
            // 
            this.txtCustomerLastName.Location = new System.Drawing.Point(140, 82);
            this.txtCustomerLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustomerLastName.Name = "txtCustomerLastName";
            this.txtCustomerLastName.Size = new System.Drawing.Size(241, 26);
            this.txtCustomerLastName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Last Name:";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Location = new System.Drawing.Point(249, 273);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(133, 62);
            this.btnAddCustomer.TabIndex = 4;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "First Name:";
            // 
            // txtCustomerFirstName
            // 
            this.txtCustomerFirstName.Location = new System.Drawing.Point(136, 33);
            this.txtCustomerFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustomerFirstName.Name = "txtCustomerFirstName";
            this.txtCustomerFirstName.Size = new System.Drawing.Size(245, 26);
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
            this.gvCustomers.Dock = System.Windows.Forms.DockStyle.Left;
            this.gvCustomers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvCustomers.Location = new System.Drawing.Point(4, 4);
            this.gvCustomers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gvCustomers.MultiSelect = false;
            this.gvCustomers.Name = "gvCustomers";
            this.gvCustomers.ReadOnly = true;
            this.gvCustomers.RowHeadersVisible = false;
            this.gvCustomers.Size = new System.Drawing.Size(867, 774);
            this.gvCustomers.TabIndex = 4;
            // 
            // tabEmployee
            // 
            this.tabEmployee.BackColor = System.Drawing.SystemColors.Control;
            this.tabEmployee.Controls.Add(this.lblEmployeeError);
            this.tabEmployee.Controls.Add(this.gbAddEmployee);
            this.tabEmployee.Controls.Add(this.gvEmployees);
            this.tabEmployee.Location = new System.Drawing.Point(4, 29);
            this.tabEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabEmployee.Size = new System.Drawing.Size(1304, 782);
            this.tabEmployee.TabIndex = 4;
            this.tabEmployee.Text = "Employees";
            // 
            // lblEmployeeError
            // 
            this.lblEmployeeError.AutoSize = true;
            this.lblEmployeeError.ForeColor = System.Drawing.Color.Red;
            this.lblEmployeeError.Location = new System.Drawing.Point(879, 596);
            this.lblEmployeeError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeError.Name = "lblEmployeeError";
            this.lblEmployeeError.Size = new System.Drawing.Size(130, 20);
            this.lblEmployeeError.TabIndex = 8;
            this.lblEmployeeError.Text = "[Error Message]";
            this.lblEmployeeError.Visible = false;
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
            this.gbAddEmployee.Location = new System.Drawing.Point(879, 9);
            this.gbAddEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAddEmployee.Name = "gbAddEmployee";
            this.gbAddEmployee.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAddEmployee.Size = new System.Drawing.Size(417, 583);
            this.gbAddEmployee.TabIndex = 7;
            this.gbAddEmployee.TabStop = false;
            this.gbAddEmployee.Text = "Add Employee";
            // 
            // txtEmployeeAnswer
            // 
            this.txtEmployeeAnswer.Location = new System.Drawing.Point(23, 336);
            this.txtEmployeeAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmployeeAnswer.Name = "txtEmployeeAnswer";
            this.txtEmployeeAnswer.Size = new System.Drawing.Size(363, 26);
            this.txtEmployeeAnswer.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(23, 298);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 20);
            this.label18.TabIndex = 17;
            this.label18.Text = "Answer:";
            // 
            // cbEmployeSeqQuestions
            // 
            this.cbEmployeSeqQuestions.FormattingEnabled = true;
            this.cbEmployeSeqQuestions.Location = new System.Drawing.Point(23, 249);
            this.cbEmployeSeqQuestions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEmployeSeqQuestions.Name = "cbEmployeSeqQuestions";
            this.cbEmployeSeqQuestions.Size = new System.Drawing.Size(363, 28);
            this.cbEmployeSeqQuestions.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(23, 212);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(147, 20);
            this.label17.TabIndex = 15;
            this.label17.Text = "Security Question:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 37);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 20);
            this.label16.TabIndex = 14;
            this.label16.Text = "First Name:";
            // 
            // txtEmployeeFirstName
            // 
            this.txtEmployeeFirstName.Location = new System.Drawing.Point(136, 33);
            this.txtEmployeeFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmployeeFirstName.Name = "txtEmployeeFirstName";
            this.txtEmployeeFirstName.Size = new System.Drawing.Size(249, 26);
            this.txtEmployeeFirstName.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 86);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 20);
            this.label15.TabIndex = 12;
            this.label15.Text = "Last Name:";
            // 
            // txtEmployeeLastName
            // 
            this.txtEmployeeLastName.Location = new System.Drawing.Point(136, 86);
            this.txtEmployeeLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmployeeLastName.Name = "txtEmployeeLastName";
            this.txtEmployeeLastName.Size = new System.Drawing.Size(249, 26);
            this.txtEmployeeLastName.TabIndex = 1;
            // 
            // chkEmployeeAdmin
            // 
            this.chkEmployeeAdmin.AutoSize = true;
            this.chkEmployeeAdmin.Location = new System.Drawing.Point(136, 516);
            this.chkEmployeeAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkEmployeeAdmin.Name = "chkEmployeeAdmin";
            this.chkEmployeeAdmin.Size = new System.Drawing.Size(18, 17);
            this.chkEmployeeAdmin.TabIndex = 7;
            this.chkEmployeeAdmin.UseVisualStyleBackColor = true;
            // 
            // dtDemployeeHireDate
            // 
            this.dtDemployeeHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDemployeeHireDate.Location = new System.Drawing.Point(136, 432);
            this.dtDemployeeHireDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtDemployeeHireDate.Name = "dtDemployeeHireDate";
            this.dtDemployeeHireDate.Size = new System.Drawing.Size(249, 26);
            this.dtDemployeeHireDate.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 513);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Admin:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 438);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Date Hired:";
            // 
            // txtEmployeePass
            // 
            this.txtEmployeePass.Location = new System.Drawing.Point(136, 139);
            this.txtEmployeePass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmployeePass.Name = "txtEmployeePass";
            this.txtEmployeePass.PasswordChar = '*';
            this.txtEmployeePass.Size = new System.Drawing.Size(249, 26);
            this.txtEmployeePass.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 143);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Password:";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Location = new System.Drawing.Point(209, 492);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(140, 62);
            this.btnAddEmployee.TabIndex = 8;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
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
            this.gvEmployees.Dock = System.Windows.Forms.DockStyle.Left;
            this.gvEmployees.Location = new System.Drawing.Point(4, 4);
            this.gvEmployees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gvEmployees.MultiSelect = false;
            this.gvEmployees.Name = "gvEmployees";
            this.gvEmployees.ReadOnly = true;
            this.gvEmployees.RowHeadersVisible = false;
            this.gvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvEmployees.Size = new System.Drawing.Size(867, 774);
            this.gvEmployees.TabIndex = 6;
            // 
            // formInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 815);
            this.Controls.Add(this.tcInventory);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "formInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Inventory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formInventory_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.formInventory_VisibleChanged);
            this.tcInventory.ResumeLayout(false);
            this.tabArtist.ResumeLayout(false);
            this.tabArtist.PerformLayout();
            this.gbAddArtist.ResumeLayout(false);
            this.gbAddArtist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvArtist)).EndInit();
            this.menuArtist.ResumeLayout(false);
            this.tabAlbums.ResumeLayout(false);
            this.tabAlbums.PerformLayout();
            this.gbAddAlbum.ResumeLayout(false);
            this.gbAddAlbum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udAlbumQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAlbums)).EndInit();
            this.tabGenre.ResumeLayout(false);
            this.tabGenre.PerformLayout();
            this.gbAddGenre.ResumeLayout(false);
            this.gbAddGenre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGenres)).EndInit();
            this.tabCustomer.ResumeLayout(false);
            this.tabCustomer.PerformLayout();
            this.gbAddCustomer.ResumeLayout(false);
            this.gbAddCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomers)).EndInit();
            this.tabEmployee.ResumeLayout(false);
            this.tabEmployee.PerformLayout();
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
        private System.Windows.Forms.Label lblArtistError;
        private System.Windows.Forms.Label lblAlbumError;
        private System.Windows.Forms.Label lblGenreError;
        private System.Windows.Forms.Label lblCustomerError;
        private System.Windows.Forms.Label lblEmployeeError;
    }
}