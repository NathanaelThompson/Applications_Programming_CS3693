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

        //just like the function says, updates the totals of the order
        private void UpdateTotals()
        {
            double subTotal = 0.0;
            foreach(string[] itemArr in itemsInDGVCart)
            {
                subTotal += double.Parse(itemArr[2].Substring(1, itemArr[2].Length - 1));
                subTotal *= int.Parse(itemArr[3]);
            }

            txtSubtotal.Text = string.Format("{0:C}", subTotal);
            txtTax.Text = string.Format("{0:C}", (0.07 * subTotal));
            txtTotal.Text = string.Format("{0:C}", subTotal + (subTotal*0.07));
        }
        List<string[]> itemsInDGVCart = new List<string[]>();
        DataGridView grid = new DataGridView();

        //attempt to add an item to the customer's cart
        private void btnAddCart_Click(object sender, EventArgs e)
        {

            if (numQuantity.Value != 0)
            {
                double amount = double.Parse(txtAlbumPrice.Text.Substring(1, txtAlbumPrice.Text.Length - 1));

                string[] items = new string[6];
                items[0] = cbArtist.Text;
                items[1] = cbAlbum.Text;
                items[2] = string.Format("{0:C}", amount);
                items[3] = numQuantity.Value.ToString();
                items[4] = string.Format("{0:C}", (amount * (int)numQuantity.Value));
                items[5] = cbAlbum.SelectedValue.ToString();
                itemsInDGVCart.Add(items);

                //Processing each item in the itemsInDGVCart list into the cart DGV
                for (int i = 0; i < itemsInDGVCart.Count; i++)
                {
                    string[] tempItem = itemsInDGVCart[i];
                    string[] row = new string[]{
                        tempItem[0].ToString(),
                        tempItem[1].ToString(),
                        tempItem[2].ToString(),
                        tempItem[3].ToString(),
                        tempItem[4].ToString(),
                        tempItem[5].ToString()
                    };
                    grid = cartDGV;
                    grid.Rows.Add(row);
                }

                //asserts a minimum quantity and updates totals
                numQuantity.Value = 1;
                UpdateTotals();
            }
            else
            {
                //if there is too extreme of a number for quantity, this displays to the user
                MessageBox.Show("Album quantity too high or low.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //adds the items to the cart
        private int ProcessCart()
        {
            int currentCart = ConnectionManager.CartCount() + 1;
            foreach(string[] itemArr in itemsInDGVCart)
            {
                int qty = Int32.Parse(itemArr[3]);
                for (int i = 0; i < qty; i++)
                {
                    ConnectionManager.AddToCart(currentCart.ToString(), itemArr[5].ToString());
                    ConnectionManager.UpdateQuantity(itemArr[5].ToString());
                }
            }
            return currentCart;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();

        }

        //clears information from the checkout screen
        private void ClearFields()
        {
            txtAlbumPrice.Clear();
            txtCustomer.Clear();
            txtSubtotal.Clear();
            txtTax.Clear();
            txtTotal.Clear();

            cbArtist.SelectedIndex = 0;
            initAlbums(cbArtist.SelectedValue.ToString());

            cartDGV.Rows.Clear();
            cartDGV.Refresh();
            itemsInDGVCart.Clear();
            numQuantity.Value = 1;

            gbSale.Enabled = false;
        }

        //on checkout, this processes the cart and adds the cart to the database, clears the fields, then closes the form
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            string customerID = txtCustomer.Text;
            int cartID = ProcessCart();
            string employeeID = ConnectionManager.GetEmployeeID(currentUser);
            string Total = txtTotal.Text.Substring(1, txtTotal.Text.Length - 1);
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

        //removes items from the cart, and the cart DataGridView
        private void removeItemCartBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in cartDGV.SelectedRows)
            {
                itemsInDGVCart.RemoveAt(item.Index);
                cartDGV.Rows.RemoveAt(item.Index);
            }
        }

        
        //upon loading, the cart DataGridView gets its columns setup
        private void formCheckout_Load(object sender, EventArgs e)
        {
            cartDGV.ColumnCount = 6;
            cartDGV.Columns[0].Name = "Artist";
            cartDGV.Columns[1].Name = "Album";
            cartDGV.Columns[2].Name = "Cost";
            cartDGV.Columns[3].Name = "Quantity";
            cartDGV.Columns[4].Name = "Subtotal";
            cartDGV.Columns[5].Name = "Album ID";
        }
    }
}
