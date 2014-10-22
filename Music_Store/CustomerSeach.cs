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
    public partial class formCustomerSearch : Form
    {
        private formCheckout checkout;

        public formCustomerSearch(formCheckout owner)
        {
            checkout = owner;
            InitializeComponent();
            
            lvSearchResults.Columns.Add("Last Name", 80);
            lvSearchResults.Columns.Add("First Name", 80);
            lvSearchResults.Columns.Add("Email Address", 160);
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            lvSearchResults.Items.Clear();
            SearchCustomers();
        }

        private void SearchCustomers()
        {
            DataTable results = ConnectionManager.CustomerSearch(txtPhoneNumber.Text.Trim());

            if (results.Rows.Count != 0)
            {
                for (int i = 0; i < results.Rows.Count; i++)
                {
                    string[] items = {results.Rows[i][0].ToString(), results.Rows[i][1].ToString(), 
                                     results.Rows[i][2].ToString(), results.Rows[i][3].ToString()};
                    ListViewItem lv = new ListViewItem(items);
                    lvSearchResults.Items.Add(lv);
                    lblError.Visible = false;
                }
            }
            else
            {
                lblError.Text = "No customer found, add a new one.";
                lblError.Visible = true;
            }
        }

        private void lvSearchResults_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            checkout.setCustomerID(lvSearchResults.SelectedItems[0].SubItems[3].Text);
            this.Close();
        }

        private void formCustomerSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
