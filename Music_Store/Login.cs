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

        public formLogin()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dashboard = new formDashboard(txtUserName.Text);
            dashboard.Show();
            this.Hide();
        }

        private void forgotPasswordButton_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPasswordForm = new ForgotPassword(txtUserName.Text.Trim());
            forgotPasswordForm.Show();
            
        }



    }
}
