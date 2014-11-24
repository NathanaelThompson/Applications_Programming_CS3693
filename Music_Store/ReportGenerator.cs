using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            
            gvReports.DataSource = dt;
        }

        private void emailButton_Click(object sender, EventArgs e)
        {

        }

        private void ReportGenerator_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }


    }
}
