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
    public partial class formDashboard : Form
    {
        private formSearchScreen search;
        private formCheckout checkout;
        private formInventory inv;
        private ReportGenerator rpg;
        private formLogin login;
        private string userLoggedIn;

        public formDashboard(string username, formLogin owner)
        {
            InitializeComponent();

            login = owner;
            search = new formSearchScreen();
            checkout = new formCheckout(username);
            inv = new formInventory();
            rpg = new ReportGenerator();

            userLoggedIn = username;
            lblLogInStatus.Text = "Logged in as [" + userLoggedIn + "]";
            lblLogInStatus.ForeColor = Color.Red;

            if(!ConnectionManager.CheckAdminStatus(userLoggedIn))
            {
                btnInventory.Enabled = false;
                btnReports.Enabled = false;
                this.Size = new Size(this.Width, 350);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search.Show();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            checkout.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            inv.ReloadData();
            inv.Show();
        }
        private void btnReports_Click(object sender, EventArgs e)
        {
            rpg.Show();
        }
        private void miClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            search.Dispose();
            checkout.Dispose();
            inv.Dispose();
            login.Dispose();
            rpg.Dispose();
        }

        private void miCheckout_Click(object sender, EventArgs e)
        {
            btnCheckout.PerformClick();
        }

        private void miInventory_Click(object sender, EventArgs e)
        {
            btnInventory.PerformClick();
        }

        private void miSearch_Click(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        


        //Ignore this...accidental double click
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnReports.PerformClick();
        }


    }
}
