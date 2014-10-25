﻿using System;
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
        private formLogin login;
        private string userLoggedIn;

        public formDashboard(string username, formLogin owner)
        {
            InitializeComponent();

            login = owner;
            search = new formSearchScreen();
            checkout = new formCheckout(username);
            inv = new formInventory();

            userLoggedIn = username;
            lblLogInStatus.Text = "Logged in as [" + userLoggedIn + "]";
            lblLogInStatus.ForeColor = Color.Red;
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


    }
}
