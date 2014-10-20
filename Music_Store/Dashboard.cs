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
        formSearchScreen search;
        formCheckout checkout;
        formInventory inv;
        string userLoggedIn;

        public formDashboard(string username)
        {
            InitializeComponent();
            userLoggedIn = username;
            lblLogInStatus.Text = "Logged in as [" + userLoggedIn + "]";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search = new formSearchScreen();
            search.Show();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            checkout = new formCheckout(userLoggedIn);
            checkout.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            inv = new formInventory();
            inv.Show();
        }


    }
}
