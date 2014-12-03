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
using System.IO;
using System.Diagnostics;

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
                "\nThe section on the left side of this form will allow you to preview"+
                "\nthe information generated for this report." + 
                "\n\nAdd any information necessary, then click 'Generate Report'.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            //generates the html report line by line here
            try
            {
                using (StreamWriter sw = new StreamWriter("placeholderHtmlFile.html", true))
                {
                    foreach (StringBuilder sb in tablesAsStrings)
                    {
                        sw.WriteLine(sb.ToString());
                    }
                }
                //upon writing the file, the viewer should navigate to new file
                string filePath = Path.Combine(Application.StartupPath, "placeholderHtmlFile.html");
                reportViewer.Navigate(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("File error, exit this form and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void emailButton_Click(object sender, EventArgs e)
        {

            if (tablesAsStrings.Count <= 2)
            {
                MessageBox.Show("You must generate a report before you can email a report.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        DataTable dt = new DataTable();
        List<StringBuilder> tablesAsStrings = new List<StringBuilder>();
        private void addButton_Click(object sender, EventArgs e)
        {
            StringBuilder firstElement, lastElement;

            //if this is the first table to add, add some basic html stuff at the beginning and end of the file
            if (tablesAsStrings.Count == 0)
            {

                firstElement = new StringBuilder();
                firstElement.Append("<html><body>");
                tablesAsStrings.Add(firstElement);

                lastElement = new StringBuilder();
                lastElement.Append("</body></html>");
                tablesAsStrings.Add(lastElement);
            }
            else
            {
                lastElement = tablesAsStrings[tablesAsStrings.Count - 1];
            }

            //getting the necessary information to add
            if (rbGrossSales.Checked)
            {
                dt = ConnectionManager.GrossSales();
                //asserts a currency format where necessary
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string moneyToFormat = dt.Rows[i]["Gross Sales ($)"].ToString();
                    double moneyFormatted = Math.Round(double.Parse(moneyToFormat), 2);
                    dt.Rows[i]["Gross Sales ($)"] = moneyFormatted;
                }
            }
            else if (rbMonthlySales.Checked)
            {
                dt = ConnectionManager.MonthlySales(DateTime.Now.ToString("MM"));
                //asserts a currency format where necessary
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string moneyToFormat = dt.Rows[i]["Gross Sales ($)"].ToString();
                    double moneyFormatted = Math.Round(double.Parse(moneyToFormat), 2);
                    dt.Rows[i]["Gross Sales ($)"] = moneyFormatted;
                }
            }
            else if (rbMostPopGenre.Checked)
                dt = ConnectionManager.PopularGenres();
            else if (rbMostPopArtist.Checked)
                dt = ConnectionManager.PopularArtists();
            else if (rbEmployees.Checked)
            {
                dt = ConnectionManager.EmployeeSales();
                //asserts a currency format where necessary
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string moneyToFormat = dt.Rows[i]["Gross Sales ($)"].ToString();
                    double moneyFormatted = Math.Round(double.Parse(moneyToFormat), 2);
                    dt.Rows[i]["Gross Sales ($)"] = moneyFormatted;
                }
            }
            else if (rbCustomers.Checked)
            {
                dt = ConnectionManager.CustomerSales();
                //asserts a currency format where necessary
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string moneyToFormat = dt.Rows[i]["Total Spent ($)"].ToString();
                    double moneyFormatted = Math.Round(double.Parse(moneyToFormat), 2);
                    dt.Rows[i]["Total Spent ($)"] = moneyFormatted;
                }
            }
            else if (rbMostPopAlbum.Checked)
                dt = ConnectionManager.PopularAlbums();

            gvReports.DataSource = dt;
            StringBuilder sb = new StringBuilder();

            sb.Append("<table border = 1>");

            //creates a table containing information added
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sb.Append("<tr>");
                if (i == 0)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        sb.Append("<th>" + dt.Columns[j].ColumnName);
                    }
                    sb.Append("</tr>");
                    sb.Append("<tr>");
                }
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    sb.Append("<td>");
                    sb.Append(dt.Rows[i][j].ToString());
                    sb.Append("</td>");
                }
                sb.Append("</tr>");
            }
            sb.Append("</table>");
            sb.Append("<p></p><p>--------------------------</p><p></p>");
            int lastIndex = tablesAsStrings.IndexOf(lastElement);
            tablesAsStrings.Insert(lastIndex, sb);
            if (tablesAsStrings.Count <= 3)
            {
                MessageBox.Show("Data added to report. Click generate to view the file or continue editing data.",
                    "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //adds the information selected to the preview DGV
        private void previewButton_Click(object sender, EventArgs e)
        {
            if (rbGrossSales.Checked)
            {
                dt = ConnectionManager.GrossSales();
                //asserts a currency format where necessary
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string moneyToFormat = dt.Rows[i]["Gross Sales ($)"].ToString();
                    double moneyFormatted = Math.Round(double.Parse(moneyToFormat), 2);
                    dt.Rows[i]["Gross Sales ($)"] = moneyFormatted;
                }
            }
            else if (rbMonthlySales.Checked)
            {
                dt = ConnectionManager.MonthlySales(DateTime.Now.ToString("MM"));
                //asserts a currency format where necessary
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string moneyToFormat = dt.Rows[i]["Gross Sales ($)"].ToString();
                    double moneyFormatted = Math.Round(double.Parse(moneyToFormat), 2);
                    dt.Rows[i]["Gross Sales ($)"] = moneyFormatted;
                }
            }
            else if (rbMostPopGenre.Checked)
                dt = ConnectionManager.PopularGenres();
            else if (rbMostPopArtist.Checked)
                dt = ConnectionManager.PopularArtists();
            else if (rbEmployees.Checked)
            {
                dt = ConnectionManager.EmployeeSales();
                //asserts a currency format where necessary
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string moneyToFormat = dt.Rows[i]["Gross Sales ($)"].ToString();
                    double moneyFormatted = Math.Round(double.Parse(moneyToFormat), 2);
                    dt.Rows[i]["Gross Sales ($)"] = moneyFormatted;
                }
            }
            else if (rbCustomers.Checked)
            {
                dt = ConnectionManager.CustomerSales();
                //asserts a currency format where necessary
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string moneyToFormat = dt.Rows[i]["Total Spent ($)"].ToString();
                    double moneyFormatted = Math.Round(double.Parse(moneyToFormat), 2);
                    dt.Rows[i]["Total Spent ($)"] = moneyFormatted;
                }
            }
            else if (rbMostPopAlbum.Checked)
                dt = ConnectionManager.PopularAlbums();

            gvReports.DataSource = dt;
        }
        
        //upon loading, clear the report file
        private void ReportGenerator_Load(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "placeholderHtmlFile.html");
            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                sw.Write("");
            }
        }


        //clear the report file and the web browser
        private void clearButton_Click(object sender, EventArgs e)
        {
            
            string filePath = Path.Combine(Application.StartupPath, "placeholderHtmlFile.html");

            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                sw.Write("");
            }
            tablesAsStrings.Clear();
            reportViewer.Refresh();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            //After the print button is clicked,
            //a new process is created which
            //should find the first available printer
            //and print the pdf from there.
            try
            {
                Process printProcess = new Process();
                printProcess.StartInfo = new ProcessStartInfo()
                {
                    CreateNoWindow = true,
                    Verb = "print",
                    FileName = Path.Combine(Application.StartupPath, "placeholderHtmlFile.html")
                };
                printProcess.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No printer found. Please try again.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
