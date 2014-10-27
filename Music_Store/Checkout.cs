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
        private formAddCustomer addCustomer;
        private string currentUser;


        public formCheckout(string username)
        {
            search = new formCustomerSearch(this);
            addCustomer = new formAddCustomer(this);
            InitializeComponent();
            lblLogInStatus.Text = "Logged in as [" + username + "]";
            currentUser = username;
            lblLogInStatus.ForeColor = Color.Red;

            lvCart.Columns.Add("Arist", 225);
            lvCart.Columns.Add("Album", 225);
            lvCart.Columns.Add("Price", 50);
            lvCart.Columns.Add("Quantity", 50);
            lvCart.Columns.Add("Total Price", 50);

            numQuantity.Minimum = 1;
            numQuantity.Value = 1;
        }

        private void btnCustomerLookup_Click(object sender, EventArgs e)
        {
            search.Show();
        }

        public void setCustomerID(string id)
        {
            txtCustomer.Text = id;
            gbSale.Enabled = true;
            
            cbArtist.DataSource = ConnectionManager.ArtistComboBox();
            cbArtist.DisplayMember = "Name";
            cbArtist.ValueMember = "ArtistID";

            initAlbums(cbArtist.SelectedValue.ToString());
            getAlbumPrice(cbAlbum.SelectedValue.ToString());
            getAlbumArtwork(cbAlbum.SelectedValue.ToString());
        }

        private void getAlbumPrice(string albumID)
        {
            double price = double.Parse(ConnectionManager.AlbumPrice(albumID));
            txtAlbumPrice.Text = string.Format("{0:C}", price);
        }

        private void getAlbumArtwork(string albumID)
        {
            pbArtwork.ImageLocation = ConnectionManager.AlbumArtwork(albumID);
        }

        private void initAlbums(string artistID)
        {
            cbAlbum.DataSource = ConnectionManager.AlbumComboBox(artistID);
            cbAlbum.DisplayMember = "Title";
            cbAlbum.ValueMember = "AlbumID";
        }

        private void formCheckout_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void cbArtist_SelectedIndexChanged(object sender, EventArgs e)
        {
            initAlbums(cbArtist.SelectedValue.ToString());
        }

        private void cbAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            getAlbumPrice(cbAlbum.SelectedValue.ToString());
            getAlbumArtwork(cbAlbum.SelectedValue.ToString());
        }

        private void UpdateTotals()
        {
            double subTotal = 0.0;
            foreach(ListViewItem item in lvCart.Items)
            {
                subTotal += double.Parse(item.SubItems[2].Text.Substring(1, item.SubItems[2].Text.Length - 1));
            }

            txtSubtotal.Text = string.Format("{0:C}", subTotal);
            txtTax.Text = string.Format("{0:C}", (0.07 * subTotal));
            txtTotal.Text = string.Format("{0:C}", subTotal + (subTotal*0.07));
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            if (numQuantity.Value != 0)
            {
                double amount = double.Parse(txtAlbumPrice.Text.Substring(1, txtAlbumPrice.Text.Length - 1));
                
                string[] items = new string[6];
                items[0] = cbArtist.Text;
                items[1] = cbAlbum.Text;
                items[2] = string.Format("{0:C}", amount);
                items[3] = "x " + numQuantity.Value.ToString();
                items[4] = string.Format("{0:C}", (amount * (int)numQuantity.Value));
                items[5] = cbAlbum.SelectedValue.ToString();

                ListViewItem lvItem = new ListViewItem(items);
                lvCart.Items.Add(lvItem);
                numQuantity.Value = 1;
                UpdateTotals();
            }
        }

        private int ProcessCart()
        {
            int currentCart = ConnectionManager.CartCount() + 1;
            foreach(ListViewItem item in lvCart.Items)
            {
                int qty = Int32.Parse(item.SubItems[3].Text.Substring(2,item.SubItems[3].Text.Length - 2));
                for (int i = 0; i < qty; i++)
                {
                    ConnectionManager.AddToCart(currentCart.ToString(), item.SubItems[5].Text);
                    ConnectionManager.UpdateQuantity(item.SubItems[5].Text);
                }
            }
            return currentCart;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtAlbumPrice.Clear();
            txtCustomer.Clear();
            txtSubtotal.Clear();
            txtTax.Clear();
            txtTotal.Clear();

            cbArtist.SelectedIndex = 0;
            initAlbums(cbArtist.SelectedValue.ToString());

            lvCart.Items.Clear();
            numQuantity.Value = 1;

            gbSale.Enabled = false;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            string customerID = txtCustomer.Text;
            int cartID = ProcessCart();
            string employeeID = ConnectionManager.GetEmployeeID(currentUser);
            string Total = txtTotal.Text;
            string orderDate = DateTime.Now.Date.ToString("MM/dd/yyyy");
            ConnectionManager.AddNewOrder(customerID, cartID.ToString(), employeeID, Total, orderDate);
            MessageBox.Show("Order Processed");
            ClearFields();
            this.Close();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            addCustomer.Show();
        }
    }
}
