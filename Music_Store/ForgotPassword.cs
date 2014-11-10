using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace Music_Store
{
    public partial class ForgotPassword : Form
    {
        private string username;

        public ForgotPassword(string username)
        {
            InitializeComponent();
            this.username = username;
            if (username.Length > 0)
            {
                forgotPasswordUsernameTextBox.Text = this.username;
            }
            
        }

        private string securityAnswer, password;
        private void passwordForgotContinueButton1_Click(object sender, EventArgs e)
        {
            string loginID = forgotPasswordUsernameTextBox.Text;
            bool isEmployee = ConnectionManager.checkCredentials(loginID);
            string securityQuestion, securityQuestionID;

            if (!isEmployee)
            {
                MessageBox.Show("Username error, check spelling. If error persists, there is a conflict in the database.",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SQLiteConnection conn = ConnectionManager.getConnection())
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT SecurityQuestionId FROM Employee WHERE Employee.LoginID = '" + loginID + "'";
                    securityQuestionID = cmd.ExecuteScalar().ToString();
                    
                    cmd.CommandText = "SELECT Question FROM Security_Questions WHERE SecurityQuestionID = '" + securityQuestionID + "'";
                    securityQuestion = cmd.ExecuteScalar().ToString();
                    
                    cmd.CommandText = "SELECT SecurityQuestionAns FROM Employee WHERE Employee.LoginID = '" +loginID+"'";
                    securityAnswer = cmd.ExecuteScalar().ToString();

                    cmd.CommandText = "SELECT Password FROM Employee WHERE Employee.LoginID = '"+loginID+"'";
                    password = cmd.ExecuteScalar().ToString();

                    sqLabel.Enabled = true;
                    secretQuestionLabel.Enabled = true;
                    answerLbl.Enabled = true;
                    answerBox.Enabled = true;
                    checkButton.Enabled = true;
                    secretQuestionLabel.Text = securityQuestion;
                }
            }
        }

        static int securityAttempts = 0;
        private void checkButton_Click(object sender, EventArgs e)
        {
            if (securityAttempts > 3)
            {
                MessageBox.Show("You have done this too many times.", "Security Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string answerToCheck = answerBox.Text;
            if (answerToCheck == securityAnswer)
            {
                emailLabel.Enabled = true;
                emailBox.Enabled = true;
                sendButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Incorrect Answer, try again.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                securityAttempts++;
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            //Create new mail message and attachment
            MailMessage mail = new MailMessage();
            string emailToSplit = emailBox.Text;
            char[] emailSplit = emailToSplit.ToCharArray();

            //check for the characters @ and . in the submitted email address
            if ((!(emailSplit.Contains<char>('@'))) || (!(emailSplit.Contains<char>('.'))))
            {
                MessageBox.Show("Email address not formatted correctly", "Input error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Create the message
            mail.From = new MailAddress("musicstoredonotreply@gmail.com");
            mail.To.Add(emailBox.Text);
            mail.Subject = "Music Store Lost Password (Do Not Reply)";
            mail.Body = "The password is: " + password;

            using (SmtpClient client = new SmtpClient())
            {
                //setting up the network
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("musicstoredonotreply@gmail.com", "AppProgCS3693");
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                //try to send the message, display message if it fails
                try
                {
                    client.Send(mail);
                    MessageBox.Show("Password sent to email: " + emailToSplit + " ", "Job complete",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error sending message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
