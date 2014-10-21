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
            this.lblArtwork = new System.Windows.Forms.Label();
            this.pbArtwork = new System.Windows.Forms.PictureBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.cbArtist = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAlbum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogInStatus = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lvCart = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbTotal = new System.Windows.Forms.GroupBox();
            this.gbSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArtwork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCustomer
            // 
            this.txtCustomer.Enabled = false;
            this.txtCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.Location = new System.Drawing.Point(122, 41);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(70, 23);
            this.txtCustomer.TabIndex = 21;
            this.txtCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(27, 44);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(89, 17);
            this.lblCustomer.TabIndex = 2;
            this.lblCustomer.Text = "Customer ID:";
            // 
            // btnCustomerLookup
            // 
            this.btnCustomerLookup.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCustomerLookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerLookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerLookup.Location = new System.Drawing.Point(226, 27);
            this.btnCustomerLookup.Name = "btnCustomerLookup";
            this.btnCustomerLookup.Size = new System.Drawing.Size(100, 50);
            this.btnCustomerLookup.TabIndex = 0;
            this.btnCustomerLookup.Text = "Cusotmer Lookup";
            this.btnCustomerLookup.UseVisualStyleBackColor = false;
            this.btnCustomerLookup.Click += new System.EventHandler(this.btnCustomerLookup_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(342, 27);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(100, 50);
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            // 
            // gbSale
            // 
            this.gbSale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSale.Controls.Add(this.gbTotal);
            this.gbSale.Controls.Add(this.groupBox1);
            this.gbSale.Controls.Add(this.lblError);
            this.gbSale.Controls.Add(this.lvCart);
            this.gbSale.Controls.Add(this.btnCancel);
            this.gbSale.Controls.Add(this.btnCheckout);
            this.gbSale.Controls.Add(this.label5);
            this.gbSale.Enabled = false;
            this.gbSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSale.Location = new System.Drawing.Point(18, 92);
            this.gbSale.Name = "gbSale";
            this.gbSale.Size = new System.Drawing.Size(854, 458);
            this.gbSale.TabIndex = 4;
            this.gbSale.TabStop = false;
            this.gbSale.Text = "New Sale";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(57, 23);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Price:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Salmon;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(591, 307);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 120);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel Sale";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(431, 307);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(120, 120);
            this.btnCheckout.TabIndex = 8;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(541, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Items in Cart:";
            // 
            // lblArtwork
            // 
            this.lblArtwork.AutoSize = true;
            this.lblArtwork.Location = new System.Drawing.Point(289, 33);
            this.lblArtwork.Name = "lblArtwork";
            this.lblArtwork.Size = new System.Drawing.Size(102, 17);
            this.lblArtwork.TabIndex = 11;
            this.lblArtwork.Text = "Album Artwork:";
            // 
            // pbArtwork
            // 
            this.pbArtwork.Location = new System.Drawing.Point(292, 53);
            this.pbArtwork.Name = "pbArtwork";
            this.pbArtwork.Size = new System.Drawing.Size(150, 150);
            this.pbArtwork.TabIndex = 10;
            this.pbArtwork.TabStop = false;
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(84, 184);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(57, 23);
            this.numQuantity.TabIndex = 5;
            // 
            // btnAddCart
            // 
            this.btnAddCart.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCart.Location = new System.Drawing.Point(174, 143);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(60, 50);
            this.btnAddCart.TabIndex = 6;
            this.btnAddCart.Text = "Add to Cart";
            this.btnAddCart.UseVisualStyleBackColor = false;
            // 
            // cbArtist
            // 
            this.cbArtist.FormattingEnabled = true;
            this.cbArtist.Location = new System.Drawing.Point(84, 33);
            this.cbArtist.Name = "cbArtist";
            this.cbArtist.Size = new System.Drawing.Size(150, 24);
            this.cbArtist.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Artist:";
            // 
            // cbAlbum
            // 
            this.cbAlbum.FormattingEnabled = true;
            this.cbAlbum.Location = new System.Drawing.Point(84, 83);
            this.cbAlbum.Name = "cbAlbum";
            this.cbAlbum.Size = new System.Drawing.Size(150, 24);
            this.cbAlbum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Album:";
            // 
            // lblLogInStatus
            // 
            this.lblLogInStatus.AutoSize = true;
            this.lblLogInStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogInStatus.Location = new System.Drawing.Point(706, 27);
            this.lblLogInStatus.Name = "lblLogInStatus";
            this.lblLogInStatus.Size = new System.Drawing.Size(166, 17);
            this.lblLogInStatus.TabIndex = 5;
            this.lblLogInStatus.Text = "Logged In As [username]";
            // 
            // txtTax
            // 
            this.txtTax.Enabled = false;
            this.txtTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(93, 68);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(75, 23);
            this.txtTax.TabIndex = 19;
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tax:";
            // 
            // lvCart
            // 
            this.lvCart.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvCart.Location = new System.Drawing.Point(544, 49);
            this.lvCart.MultiSelect = false;
            this.lvCart.Name = "lvCart";
            this.lvCart.Size = new System.Drawing.Size(280, 216);
            this.lvCart.TabIndex = 20;
            this.lvCart.UseCompatibleStateImageBehavior = false;
            this.lvCart.View = System.Windows.Forms.View.Details;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantity:";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(17, 268);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(109, 17);
            this.lblError.TabIndex = 21;
            this.lblError.Text = "[Error Message]";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(34, 111);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 17);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(94, 108);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(150, 23);
            this.txtTotal.TabIndex = 20;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(93, 28);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(150, 23);
            this.txtSubtotal.TabIndex = 23;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Sub-Total:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAddCart);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.cbAlbum);
            this.groupBox1.Controls.Add(this.numQuantity);
            this.groupBox1.Controls.Add(this.pbArtwork);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblArtwork);
            this.groupBox1.Controls.Add(this.cbArtist);
            this.groupBox1.Location = new System.Drawing.Point(20, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 235);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Album";
            // 
            // gbTotal
            // 
            this.gbTotal.Controls.Add(this.label7);
            this.gbTotal.Controls.Add(this.lblTotal);
            this.gbTotal.Controls.Add(this.txtSubtotal);
            this.gbTotal.Controls.Add(this.txtTotal);
            this.gbTotal.Controls.Add(this.label6);
            this.gbTotal.Controls.Add(this.txtTax);
            this.gbTotal.Location = new System.Drawing.Point(20, 288);
            this.gbTotal.Name = "gbTotal";
            this.gbTotal.Size = new System.Drawing.Size(270, 150);
            this.gbTotal.TabIndex = 25;
            this.gbTotal.TabStop = false;
            this.gbTotal.Text = "Order Total";
            // 
            // formCheckout
            // 
            this.AcceptButton = this.btnCustomerLookup;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.lblLogInStatus);
            this.Controls.Add(this.gbSale);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.btnCustomerLookup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formCheckout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer Checkout";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formCheckout_FormClosing);
            this.gbSale.ResumeLayout(false);
            this.gbSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArtwork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbTotal.ResumeLayout(false);
            this.gbTotal.PerformLayout();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblArtwork;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblLogInStatus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAlbum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvCart;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox gbTotal;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}