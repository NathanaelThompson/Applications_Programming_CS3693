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
    public partial class formCheckout : Form
    {
        public formCheckout(string username)
        {
            InitializeComponent();
            lblLogInStatus.Text = "Logged in as[" + username + "]";
            lblLogInStatus.ForeColor = Color.Red;
        }
    }
}
