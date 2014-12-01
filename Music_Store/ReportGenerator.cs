using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Music_Store
{
    public partial class ReportGenerator : Form
    {
        
        public ReportGenerator()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select an option above, then click generate report."+
                "\nThe section on the right side of this form will allow you to preview"+
                "\nthe pdf generated from this report.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (rbGrossSales.Checked)
                dt = ConnectionManager.GrossSales();
            else if (rbMonthlySales.Checked)
                dt = ConnectionManager.MonthlySales(DateTime.Now.ToString("MM"));
            else if (rbMostPopGenre.Checked)
                dt = ConnectionManager.PopularGenres();
            else if (rbMostPopArtist.Checked)
                dt = ConnectionManager.PopularArtists();
            else if (rbEmployees.Checked)
                dt = ConnectionManager.EmployeeSales();
            else if (rbCustomers.Checked)
                dt = ConnectionManager.CustomerSales();
            else if (rbMostPopAlbum.Checked)
                dt = ConnectionManager.PopularAlbums();

            gvReports.DataSource = dt;
        }

        private void emailButton_Click(object sender, EventArgs e)
        {
            //Create new mail message and attachment
            MailMessage mail = new MailMessage();
            Attachment attachment = new Attachment("placeholderHtmlFile.html");

            string emailToSplit = emailBox.Text;
            char[] emailSplit = emailToSplit.ToCharArray();

            //check for the characters @ and . in the submitted email address
            if ((!(emailSplit.Contains<char>('@'))) || (!(emailSplit.Contains<char>('.'))))
            {
                MessageBox.Show("Email address not formatted correctly", "Input error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Create the message
            mail.Attachments.Add(attachment);
            mail.From = new MailAddress("musicstoredonotreply@gmail.com");
            mail.To.Add(emailBox.Text);
            mail.Subject = "Music Store Lost Password (Do Not Reply)";
            mail.Body = "";

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
                    MessageBox.Show("Report sent to email: " + emailToSplit + " ", "Job complete",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error sending message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ReportGenerator_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void gvReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
