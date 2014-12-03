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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCheckout));
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.btnCustomerLookup = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.gbSale = new System.Windows.Forms.GroupBox();
            this.gbTotal = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlbumPrice = new System.Windows.Forms.TextBox();
            this.cbAlbum = new System.Windows.Forms.ComboBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.pbArtwork = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbArtist = new System.Windows.Forms.ComboBox();
            this.lblLogInStatus = new System.Windows.Forms.Label();
            this.removeItemCartBtn = new System.Windows.Forms.Button();
            this.cartDGV = new System.Windows.Forms.DataGridView();
            this.gbSale.SuspendLayout();
            this.gbTotal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArtwork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustomer
            // 
            this.txtCustomer.Enabled = false;
            this.txtCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.Location = new System.Drawing.Point(163, 50);
            this.txtCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(92, 26);
            this.txtCustomer.TabIndex = 21;
            this.txtCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(36, 54);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(109, 20);
            this.lblCustomer.TabIndex = 2;
            this.lblCustomer.Text = "Customer ID:";
            // 
            // btnCustomerLookup
            // 
            this.btnCustomerLookup.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCustomerLookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerLookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerLookup.Location = new System.Drawing.Point(301, 33);
            this.btnCustomerLookup.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustomerLookup.Name = "btnCustomerLookup";
            this.btnCustomerLookup.Size = new System.Drawing.Size(133, 62);
            this.btnCustomerLookup.TabIndex = 0;
            this.btnCustomerLookup.Text = "Customer Lookup";
            this.btnCustomerLookup.UseVisualStyleBackColor = false;
            this.btnCustomerLookup.Click += new System.EventHandler(this.btnCustomerLookup_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(456, 33);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(133, 62);
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // gbSale
            // 
            this.gbSale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSale.Controls.Add(this.gbTotal);
            this.gbSale.Controls.Add(this.groupBox1);
            this.gbSale.Enabled = false;
            this.gbSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSale.Location = new System.Drawing.Point(24, 113);
            this.gbSale.Margin = new System.Windows.Forms.Padding(4);
            this.gbSale.Name = "gbSale";
            this.gbSale.Padding = new System.Windows.Forms.Padding(4);
            this.gbSale.Size = new System.Drawing.Size(1213, 581);
            this.gbSale.TabIndex = 4;
            this.gbSale.TabStop = false;
            this.gbSale.Text = "New Sale";
            // 
            // gbTotal
            // 
            this.gbTotal.Controls.Add(this.label7);
            this.gbTotal.Controls.Add(this.lblTotal);
            this.gbTotal.Controls.Add(this.txtSubtotal);
            this.gbTotal.Controls.Add(this.txtTotal);
            this.gbTotal.Controls.Add(this.btnCheckout);
            this.gbTotal.Controls.Add(this.btnCancel);
            this.gbTotal.Controls.Add(this.label6);
            this.gbTotal.Controls.Add(this.txtTax);
            this.gbTotal.Location = new System.Drawing.Point(899, 37);
            this.gbTotal.Margin = new System.Windows.Forms.Padding(4);
            this.gbTotal.Name = "gbTotal";
            this.gbTotal.Padding = new System.Windows.Forms.Padding(4);
            this.gbTotal.Size = new System.Drawing.Size(307, 537);
            this.gbTotal.TabIndex = 25;
            this.gbTotal.TabStop = false;
            this.gbTotal.Text = "Order Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Sub-Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(45, 137);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 20);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(124, 34);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(159, 26);
            this.txtSubtotal.TabIndex = 23;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Red;
            this.txtTotal.Location = new System.Drawing.Point(124, 133);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(159, 26);
            this.txtTotal.TabIndex = 20;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(21, 382);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(267, 148);
            this.btnCheckout.TabIndex = 8;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Salmon;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(21, 203);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(267, 148);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel Sale";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tax:";
            // 
            // txtTax
            // 
            this.txtTax.BackColor = System.Drawing.SystemColors.Window;
            this.txtTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(124, 84);
            this.txtTax.Margin = new System.Windows.Forms.Padding(4);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(159, 26);
            this.txtTax.TabIndex = 19;
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cartDGV);
            this.groupBox1.Controls.Add(this.removeItemCartBtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAddCart);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAlbumPrice);
            this.groupBox1.Controls.Add(this.cbAlbum);
            this.groupBox1.Controls.Add(this.numQuantity);
            this.groupBox1.Controls.Add(this.pbArtwork);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbArtist);
            this.groupBox1.Location = new System.Drawing.Point(27, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(864, 537);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Album";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Artist:";
            // 
            // btnAddCart
            // 
            this.btnAddCart.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCart.Location = new System.Drawing.Point(31, 246);
            this.btnAddCart.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(213, 62);
            this.btnAddCart.TabIndex = 6;
            this.btnAddCart.Text = "Add to Cart";
            this.btnAddCart.UseVisualStyleBackColor = false;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Album:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Price:";
            // 
            // txtAlbumPrice
            // 
            this.txtAlbumPrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtAlbumPrice.Location = new System.Drawing.Point(112, 164);
            this.txtAlbumPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlbumPrice.Name = "txtAlbumPrice";
            this.txtAlbumPrice.ReadOnly = true;
            this.txtAlbumPrice.Size = new System.Drawing.Size(132, 26);
            this.txtAlbumPrice.TabIndex = 4;
            // 
            // cbAlbum
            // 
            this.cbAlbum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAlbum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAlbum.FormattingEnabled = true;
            this.cbAlbum.Location = new System.Drawing.Point(112, 102);
            this.cbAlbum.Margin = new System.Windows.Forms.Padding(4);
            this.cbAlbum.Name = "cbAlbum";
            this.cbAlbum.Size = new System.Drawing.Size(399, 28);
            this.cbAlbum.TabIndex = 3;
            this.cbAlbum.SelectedIndexChanged += new System.EventHandler(this.cbAlbum_SelectedIndexChanged);
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(379, 164);
            this.numQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(133, 26);
            this.numQuantity.TabIndex = 5;
            this.numQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pbArtwork
            // 
            this.pbArtwork.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbArtwork.ErrorImage")));
            this.pbArtwork.Location = new System.Drawing.Point(537, 25);
            this.pbArtwork.Margin = new System.Windows.Forms.Padding(4);
            this.pbArtwork.Name = "pbArtwork";
            this.pbArtwork.Size = new System.Drawing.Size(307, 283);
            this.pbArtwork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArtwork.TabIndex = 10;
            this.pbArtwork.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantity:";
            // 
            // cbArtist
            // 
            this.cbArtist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbArtist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbArtist.FormattingEnabled = true;
            this.cbArtist.Location = new System.Drawing.Point(112, 41);
            this.cbArtist.Margin = new System.Windows.Forms.Padding(4);
            this.cbArtist.Name = "cbArtist";
            this.cbArtist.Size = new System.Drawing.Size(399, 28);
            this.cbArtist.TabIndex = 2;
            this.cbArtist.SelectedIndexChanged += new System.EventHandler(this.cbArtist_SelectedIndexChanged);
            // 
            // lblLogInStatus
            // 
            this.lblLogInStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogInStatus.AutoSize = true;
            this.lblLogInStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogInStatus.Location = new System.Drawing.Point(1015, 33);
            this.lblLogInStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogInStatus.Name = "lblLogInStatus";
            this.lblLogInStatus.Size = new System.Drawing.Size(196, 20);
            this.lblLogInStatus.TabIndex = 5;
            this.lblLogInStatus.Text = "Logged In As [username]";
            // 
            // removeItemCartBtn
            // 
            this.removeItemCartBtn.BackColor = System.Drawing.Color.Salmon;
            this.removeItemCartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeItemCartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeItemCartBtn.Location = new System.Drawing.Point(299, 246);
            this.removeItemCartBtn.Margin = new System.Windows.Forms.Padding(4);
            this.removeItemCartBtn.Name = "removeItemCartBtn";
            this.removeItemCartBtn.Size = new System.Drawing.Size(213, 62);
            this.removeItemCartBtn.TabIndex = 21;
            this.removeItemCartBtn.Text = "Remove Item from Cart";
            this.removeItemCartBtn.UseVisualStyleBackColor = false;
            this.removeItemCartBtn.Click += new System.EventHandler(this.removeItemCartBtn_Click);
            // 
            // cartDGV
            // 
            this.cartDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cartDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartDGV.Location = new System.Drawing.Point(31, 350);
            this.cartDGV.Name = "cartDGV";
            this.cartDGV.RowTemplate.Height = 24;
            this.cartDGV.Size = new System.Drawing.Size(802, 150);
            this.cartDGV.TabIndex = 22;
            // 
            // formCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 709);
            this.Controls.Add(this.lblLogInStatus);
            this.Controls.Add(this.gbSale);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.btnCustomerLookup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "formCheckout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Checkout";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formCheckout_FormClosing);
            this.Load += new System.EventHandler(this.formCheckout_Load);
            this.gbSale.ResumeLayout(false);
            this.gbTotal.ResumeLayout(false);
            this.gbTotal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArtwork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Button btnCustomerLookup;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.GroupBox gbSale;
        private System.Windows.Forms.PictureBox pbArtwork;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.ComboBox cbArtist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblLogInStatus;
        private System.Windows.Forms.TextBox txtAlbumPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAlbum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox gbTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button removeItemCartBtn;
        private System.Windows.Forms.DataGridView cartDGV;
    }
}