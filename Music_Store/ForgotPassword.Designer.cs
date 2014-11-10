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
            this.emailBox = new System.Windows.Forms.TextBox();
            this.answerBox = new System.Windows.Forms.TextBox();
            this.answerLbl = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.secretQuestionLabel = new System.Windows.Forms.Label();
            this.sqLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.forgotPasswordErrorLabel = new System.Windows.Forms.Label();
            this.forgotPasswordUsernameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordForgotContinueButton1 = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.passwordForgotLayout1.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordForgotLayout1
            // 
            this.passwordForgotLayout1.Controls.Add(this.sendButton);
            this.passwordForgotLayout1.Controls.Add(this.emailBox);
            this.passwordForgotLayout1.Controls.Add(this.answerBox);
            this.passwordForgotLayout1.Controls.Add(this.answerLbl);
            this.passwordForgotLayout1.Controls.Add(this.checkButton);
            this.passwordForgotLayout1.Controls.Add(this.secretQuestionLabel);
            this.passwordForgotLayout1.Controls.Add(this.sqLabel);
            this.passwordForgotLayout1.Controls.Add(this.emailLabel);
            this.passwordForgotLayout1.Controls.Add(this.forgotPasswordErrorLabel);
            this.passwordForgotLayout1.Controls.Add(this.forgotPasswordUsernameTextBox);
            this.passwordForgotLayout1.Controls.Add(this.label1);
            this.passwordForgotLayout1.Controls.Add(this.passwordForgotContinueButton1);
            this.passwordForgotLayout1.Location = new System.Drawing.Point(16, 15);
            this.passwordForgotLayout1.Margin = new System.Windows.Forms.Padding(4);
            this.passwordForgotLayout1.Name = "passwordForgotLayout1";
            this.passwordForgotLayout1.Padding = new System.Windows.Forms.Padding(4);
            this.passwordForgotLayout1.Size = new System.Drawing.Size(640, 305);
            this.passwordForgotLayout1.TabIndex = 0;
            this.passwordForgotLayout1.TabStop = false;
            this.passwordForgotLayout1.Text = "Enter User Name";
            // 
            // emailBox
            // 
            this.emailBox.Enabled = false;
            this.emailBox.Location = new System.Drawing.Point(99, 206);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(224, 22);
            this.emailBox.TabIndex = 9;
            // 
            // answerBox
            // 
            this.answerBox.Enabled = false;
            this.answerBox.Location = new System.Drawing.Point(99, 156);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(224, 22);
            this.answerBox.TabIndex = 8;
            // 
            // answerLbl
            // 
            this.answerLbl.AutoSize = true;
            this.answerLbl.Enabled = false;
            this.answerLbl.Location = new System.Drawing.Point(35, 159);
            this.answerLbl.Name = "answerLbl";
            this.answerLbl.Size = new System.Drawing.Size(58, 17);
            this.answerLbl.TabIndex = 7;
            this.answerLbl.Text = "Answer:";
            // 
            // checkButton
            // 
            this.checkButton.Enabled = false;
            this.checkButton.Location = new System.Drawing.Point(341, 153);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(120, 28);
            this.checkButton.TabIndex = 6;
            this.checkButton.Text = "Check Answer";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // secretQuestionLabel
            // 
            this.secretQuestionLabel.AutoSize = true;
            this.secretQuestionLabel.Enabled = false;
            this.secretQuestionLabel.Location = new System.Drawing.Point(127, 105);
            this.secretQuestionLabel.Name = "secretQuestionLabel";
            this.secretQuestionLabel.Size = new System.Drawing.Size(40, 17);
            this.secretQuestionLabel.TabIndex = 5;
            this.secretQuestionLabel.Text = "-null-";
            // 
            // sqLabel
            // 
            this.sqLabel.AutoSize = true;
            this.sqLabel.Enabled = false;
            this.sqLabel.Location = new System.Drawing.Point(7, 105);
            this.sqLabel.Name = "sqLabel";
            this.sqLabel.Size = new System.Drawing.Size(114, 17);
            this.sqLabel.TabIndex = 4;
            this.sqLabel.Text = "Secret Question:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Enabled = false;
            this.emailLabel.Location = new System.Drawing.Point(45, 209);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(46, 17);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "Email:";
            // 
            // forgotPasswordErrorLabel
            // 
            this.forgotPasswordErrorLabel.AutoSize = true;
            this.forgotPasswordErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.forgotPasswordErrorLabel.Location = new System.Drawing.Point(96, 122);
            this.forgotPasswordErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forgotPasswordErrorLabel.Name = "forgotPasswordErrorLabel";
            this.forgotPasswordErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.forgotPasswordErrorLabel.TabIndex = 3;
            // 
            // forgotPasswordUsernameTextBox
            // 
            this.forgotPasswordUsernameTextBox.Location = new System.Drawing.Point(99, 49);
            this.forgotPasswordUsernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.forgotPasswordUsernameTextBox.Name = "forgotPasswordUsernameTextBox";
            this.forgotPasswordUsernameTextBox.Size = new System.Drawing.Size(224, 22);
            this.forgotPasswordUsernameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name:";
            // 
            // passwordForgotContinueButton1
            // 
            this.passwordForgotContinueButton1.Location = new System.Drawing.Point(341, 46);
            this.passwordForgotContinueButton1.Margin = new System.Windows.Forms.Padding(4);
            this.passwordForgotContinueButton1.Name = "passwordForgotContinueButton1";
            this.passwordForgotContinueButton1.Size = new System.Drawing.Size(120, 28);
            this.passwordForgotContinueButton1.TabIndex = 0;
            this.passwordForgotContinueButton1.Text = "Continue";
            this.passwordForgotContinueButton1.UseVisualStyleBackColor = true;
            this.passwordForgotContinueButton1.Click += new System.EventHandler(this.passwordForgotContinueButton1_Click);
            // 
            // sendButton
            // 
            this.sendButton.Enabled = false;
            this.sendButton.Location = new System.Drawing.Point(341, 203);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(120, 28);
            this.sendButton.TabIndex = 10;
            this.sendButton.Text = "Send Password";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 340);
            this.Controls.Add(this.passwordForgotLayout1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.Label answerLbl;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label secretQuestionLabel;
        private System.Windows.Forms.Label sqLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button sendButton;

    }
}