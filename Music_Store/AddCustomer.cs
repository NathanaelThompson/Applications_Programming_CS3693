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
    public partial class formAddCustomer : Form
    {
        private formCheckout checkout;

        public formAddCustomer(formCheckout owner)
        {
            checkout = owner;
            InitializeComponent();
        }

        private void clearFields()
        {
            txtCustomerEmail.Clear();
            txtCustomerFirstName.Clear();
            txtCustomerLastName.Clear();
            txtCustomerPhone.Clear();
        }

        private void AddCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            clearFields();
            this.Hide();
            e.Cancel = true;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (txtCustomerFirstName.Text.Trim().Length != 0 && txtCustomerLastName.Text.Trim().Length != 0
                && txtCustomerEmail.Text.Trim().Length != 0 && txtCustomerPhone.Text.Trim().Length != 0)
            {
                ConnectionManager.addCustomer(txtCustomerFirstName.Text.Trim(), txtCustomerLastName.Text.Trim(),
                    txtCustomerEmail.Text.Trim(), txtCustomerPhone.Text.Trim());

                checkout.setCustomerID(ConnectionManager.GetCustomerIDFromCreatedCustomer(txtCustomerFirstName.Text.Trim(), txtCustomerLastName.Text.Trim()));
                lblError.Visible = false;
            }
            else
            {
                lblError.Text = "Fields cannot be blank";
                lblError.Visible = true;
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
