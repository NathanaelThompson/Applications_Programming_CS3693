namespace Music_Store
{
    partial class formCheckout
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
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.btnCustomerLookup = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.gbSale = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCart = new System.Windows.Forms.ListBox();
            this.lblArtwork = new System.Windows.Forms.Label();
            this.pbArtwork = new System.Windows.Forms.PictureBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.cbArtist = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cbAlbum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogInStatus = new System.Windows.Forms.Label();
            this.gbSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArtwork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustomer
            // 
            this.txtCustomer.Enabled = false;
            this.txtCustomer.Location = new System.Drawing.Point(72, 28);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(150, 20);
            this.txtCustomer.TabIndex = 1;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(12, 31);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(54, 13);
            this.lblCustomer.TabIndex = 2;
            this.lblCustomer.Text = "Customer:";
            // 
            // btnCustomerLookup
            // 
            this.btnCustomerLookup.Location = new System.Drawing.Point(240, 12);
            this.btnCustomerLookup.Name = "btnCustomerLookup";
            this.btnCustomerLookup.Size = new System.Drawing.Size(80, 50);
            this.btnCustomerLookup.TabIndex = 0;
            this.btnCustomerLookup.Text = "Cusotmer Lookup";
            this.btnCustomerLookup.UseVisualStyleBackColor = true;
            this.btnCustomerLookup.Click += new System.EventHandler(this.btnCustomerLookup_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(342, 12);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(80, 50);
            this.btnAddCustomer.TabIndex = 3;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // gbSale
            // 
            this.gbSale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSale.Controls.Add(this.textBox1);
            this.gbSale.Controls.Add(this.label2);
            this.gbSale.Controls.Add(this.btnCancel);
            this.gbSale.Controls.Add(this.btnCheckout);
            this.gbSale.Controls.Add(this.label5);
            this.gbSale.Controls.Add(this.lbCart);
            this.gbSale.Controls.Add(this.lblArtwork);
            this.gbSale.Controls.Add(this.pbArtwork);
            this.gbSale.Controls.Add(this.numQuantity);
            this.gbSale.Controls.Add(this.label4);
            this.gbSale.Controls.Add(this.btnAddCart);
            this.gbSale.Controls.Add(this.cbArtist);
            this.gbSale.Controls.Add(this.label3);
            this.gbSale.Controls.Add(this.txtTotal);
            this.gbSale.Controls.Add(this.lblTotal);
            this.gbSale.Controls.Add(this.cbAlbum);
            this.gbSale.Controls.Add(this.label1);
            this.gbSale.Enabled = false;
            this.gbSale.Location = new System.Drawing.Point(18, 77);
            this.gbSale.Name = "gbSale";
            this.gbSale.Size = new System.Drawing.Size(675, 308);
            this.gbSale.TabIndex = 4;
            this.gbSale.TabStop = false;
            this.gbSale.Text = "New Sale";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(57, 20);
            this.textBox1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Price:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Salmon;
            this.btnCancel.Location = new System.Drawing.Point(496, 218);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 70);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel Sale";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCheckout.Location = new System.Drawing.Point(357, 218);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(100, 70);
            this.btnCheckout.TabIndex = 14;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Items in Cart:";
            // 
            // lbCart
            // 
            this.lbCart.FormattingEnabled = true;
            this.lbCart.Location = new System.Drawing.Point(459, 43);
            this.lbCart.Name = "lbCart";
            this.lbCart.Size = new System.Drawing.Size(198, 147);
            this.lbCart.TabIndex = 12;
            // 
            // lblArtwork
            // 
            this.lblArtwork.AutoSize = true;
            this.lblArtwork.Location = new System.Drawing.Point(280, 27);
            this.lblArtwork.Name = "lblArtwork";
            this.lblArtwork.Size = new System.Drawing.Size(78, 13);
            this.lblArtwork.TabIndex = 11;
            this.lblArtwork.Text = "Album Artwork:";
            // 
            // pbArtwork
            // 
            this.pbArtwork.Location = new System.Drawing.Point(283, 43);
            this.pbArtwork.Name = "pbArtwork";
            this.pbArtwork.Size = new System.Drawing.Size(150, 150);
            this.pbArtwork.TabIndex = 10;
            this.pbArtwork.TabStop = false;
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(89, 164);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(57, 20);
            this.numQuantity.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantity:";
            // 
            // btnAddCart
            // 
            this.btnAddCart.Location = new System.Drawing.Point(179, 129);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(60, 50);
            this.btnAddCart.TabIndex = 7;
            this.btnAddCart.Text = "Add to Cart";
            this.btnAddCart.UseVisualStyleBackColor = true;
            // 
            // cbArtist
            // 
            this.cbArtist.FormattingEnabled = true;
            this.cbArtist.Location = new System.Drawing.Point(89, 41);
            this.cbArtist.Name = "cbArtist";
            this.cbArtist.Size = new System.Drawing.Size(150, 21);
            this.cbArtist.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Artist:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(89, 244);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(150, 20);
            this.txtTotal.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(36, 247);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total:";
            // 
            // cbAlbum
            // 
            this.cbAlbum.FormattingEnabled = true;
            this.cbAlbum.Location = new System.Drawing.Point(89, 84);
            this.cbAlbum.Name = "cbAlbum";
            this.cbAlbum.Size = new System.Drawing.Size(150, 21);
            this.cbAlbum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Album:";
            // 
            // lblLogInStatus
            // 
            this.lblLogInStatus.AutoSize = true;
            this.lblLogInStatus.Location = new System.Drawing.Point(577, 9);
            this.lblLogInStatus.Name = "lblLogInStatus";
            this.lblLogInStatus.Size = new System.Drawing.Size(125, 13);
            this.lblLogInStatus.TabIndex = 5;
            this.lblLogInStatus.Text = "Logged In As [username]";
            // 
            // formCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 397);
            this.Controls.Add(this.lblLogInStatus);
            this.Controls.Add(this.gbSale);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.btnCustomerLookup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formCheckout";
            this.Text = "Customer Checkout";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formCheckout_FormClosing);
            this.gbSale.ResumeLayout(false);
            this.gbSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArtwork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Button btnCustomerLookup;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.GroupBox gbSale;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.PictureBox pbArtwork;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.ComboBox cbArtist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbCart;
        private System.Windows.Forms.Label lblArtwork;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblLogInStatus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAlbum;
        private System.Windows.Forms.Label label1;
    }
}