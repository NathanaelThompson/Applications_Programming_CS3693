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

        private void ReportGenerator_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Check all options above that apply.  Then click generate report."+
                "\nThe section on the right side of this form will allow you to preview"+
                "\nthe pdf generated from this report.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            if(gIncomeCB.Checked)
            {
                Decimal grossIncome = ConnectionManager.grossIncome();

            }
        }

        private void emailButton_Click(object sender, EventArgs e)
        {

        }


    }
}
