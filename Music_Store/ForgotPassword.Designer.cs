namespace Music_Store
{
    partial class ForgotPassword
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
            this.passwordForgotLayout1 = new System.Windows.Forms.GroupBox();
            this.forgotPasswordErrorLabel = new System.Windows.Forms.Label();
            this.forgotPasswordUsernameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordForgotContinueButton1 = new System.Windows.Forms.Button();
            this.passwordForgotLayout1.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordForgotLayout1
            // 
            this.passwordForgotLayout1.Controls.Add(this.forgotPasswordErrorLabel);
            this.passwordForgotLayout1.Controls.Add(this.forgotPasswordUsernameTextBox);
            this.passwordForgotLayout1.Controls.Add(this.label1);
            this.passwordForgotLayout1.Controls.Add(this.passwordForgotContinueButton1);
            this.passwordForgotLayout1.Location = new System.Drawing.Point(12, 12);
            this.passwordForgotLayout1.Name = "passwordForgotLayout1";
            this.passwordForgotLayout1.Size = new System.Drawing.Size(480, 248);
            this.passwordForgotLayout1.TabIndex = 0;
            this.passwordForgotLayout1.TabStop = false;
            this.passwordForgotLayout1.Text = "Enter User Name";
            // 
            // forgotPasswordErrorLabel
            // 
            this.forgotPasswordErrorLabel.AutoSize = true;
            this.forgotPasswordErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.forgotPasswordErrorLabel.Location = new System.Drawing.Point(221, 161);
            this.forgotPasswordErrorLabel.Name = "forgotPasswordErrorLabel";
            this.forgotPasswordErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.forgotPasswordErrorLabel.TabIndex = 3;
            // 
            // forgotPasswordUsernameTextBox
            // 
            this.forgotPasswordUsernameTextBox.Location = new System.Drawing.Point(221, 58);
            this.forgotPasswordUsernameTextBox.Name = "forgotPasswordUsernameTextBox";
            this.forgotPasswordUsernameTextBox.Size = new System.Drawing.Size(169, 20);
            this.forgotPasswordUsernameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name:";
            // 
            // passwordForgotContinueButton1
            // 
            this.passwordForgotContinueButton1.Location = new System.Drawing.Point(221, 125);
            this.passwordForgotContinueButton1.Name = "passwordForgotContinueButton1";
            this.passwordForgotContinueButton1.Size = new System.Drawing.Size(75, 23);
            this.passwordForgotContinueButton1.TabIndex = 0;
            this.passwordForgotContinueButton1.Text = "Continue";
            this.passwordForgotContinueButton1.UseVisualStyleBackColor = true;
            this.passwordForgotContinueButton1.Click += new System.EventHandler(this.passwordForgotContinueButton1_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 261);
            this.Controls.Add(this.passwordForgotLayout1);
            this.Name = "ForgotPassword";
            this.Text = "Forgot Password";
            this.passwordForgotLayout1.ResumeLayout(false);
            this.passwordForgotLayout1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox passwordForgotLayout1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button passwordForgotContinueButton1;
        private System.Windows.Forms.TextBox forgotPasswordUsernameTextBox;
        private System.Windows.Forms.Label forgotPasswordErrorLabel;

    }
}