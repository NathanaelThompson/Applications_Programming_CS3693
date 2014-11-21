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
    public partial class formLogin : Form
    {
        private formDashboard dashboard;
        private ForgotPassword forgotPasswordForm;

        public formLogin()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ConnectionManager.checkCredentials(txtUserName.Text, txtPassword.Text))
            {
                dashboard = new formDashboard(txtUserName.Text, this);
                dashboard.Show();
                this.Hide();
                lblErrorMessage.Visible = false;
            }
            else
            {
                lblErrorMessage.Text = "Incorrect username and/or password";
                lblErrorMessage.Visible = true;
            }
        }

        private void forgotPasswordButton_Click(object sender, EventArgs e)
        {
            forgotPasswordForm = new ForgotPassword(txtUserName.Text.Trim());
            forgotPasswordForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "guest";
            txtPassword.Text = "password";
            ConnectionManager.checkCredentials(txtUserName.Text, txtPassword.Text);
            dashboard = new formDashboard("Guest", this);
            dashboard.Show();
            this.Hide();
            lblErrorMessage.Visible = false;
        }

    }
}
