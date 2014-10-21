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
    public partial class formCheckout : Form
    {

        private formCustomerSearch search;

        public formCheckout(string username)
        {
            search = new formCustomerSearch(this);
            InitializeComponent();
            lblLogInStatus.Text = "Logged in as[" + username + "]";
            lblLogInStatus.ForeColor = Color.Red;
        }

        private void btnCustomerLookup_Click(object sender, EventArgs e)
        {
            search.Show();
        }

        public void setCustomerID(string id)
        {
            txtCustomer.Text = id;
        }

        private void formCheckout_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
