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
    public partial class ForgotPassword : Form
    {
        private string username;

        public ForgotPassword(string username)
        {
            InitializeComponent();
            this.username = username;
            if (username.Length > 0)
            {
                forgotPasswordUsernameTextBox.Text = this.username;
            }
            
        }

        private void passwordForgotContinueButton1_Click(object sender, EventArgs e)
        {
            bool checkEmployee = ConnectionManager.checkEmployeeUsername(forgotPasswordUsernameTextBox.Text.Trim());
            string emailActual, emailToCheck;
            emailToCheck = emailBox.Text;
            if (checkEmployee)
            {
                passwordForgotLayout1.Visible = false;
            }
            else
            {   
                forgotPasswordErrorLabel.Text = "Sorry, we could not find your username!";
            }
        }
    }
}
