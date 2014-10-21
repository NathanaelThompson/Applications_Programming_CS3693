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
        formCheckout checkout;

        public formCustomerSearch(formCheckout owner)
        {
            checkout = owner;
            InitializeComponent();
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            SearchCustomers();
        }

        private void SearchCustomers()
        {
            DataTable results = ConnectionManager.CustomerSearch(txtPhoneNumber.Text.Trim());

            for(int i = 0; i < results.Rows.Count; i++)
            {
                string[] items = {results.Rows[i][0].ToString(), results.Rows[i][1].ToString(), 
                                     results.Rows[i][2].ToString(), results.Rows[i][3].ToString()};
                ListViewItem lv = new ListViewItem(items);
                lvSearchResults.Items.Add(lv);
            }
        }

        private void lbCustomerSearch_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void formCustomerSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
