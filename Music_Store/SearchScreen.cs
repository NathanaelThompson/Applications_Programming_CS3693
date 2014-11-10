using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Music_Store
{
    public partial class formSearchScreen : Form
    {
        public formSearchScreen()
        {
            InitializeComponent();
        }

        private void formSearchScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = searchBox.Text;
            string termQuery = "%" + searchTerm + "%";
            SQLiteDataAdapter ad;
            DataTable dt;
            if (rbArtist.Checked == true)
            {
                dt = new DataTable();
                using (SQLiteConnection conn = ConnectionManager.getConnection())
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT DISTINCT * FROM Artist WHERE Artist.Name Like '"+termQuery+"'";
                    ad = new SQLiteDataAdapter(cmd);
                    ad.Fill(dt);
                    searchDGV.DataSource = dt;       
                }
            }
            else if (rbAlbums.Checked == true)
            {
                dt = new DataTable();
                using (SQLiteConnection conn = ConnectionManager.getConnection())
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT DISTINCT * FROM Album WHERE Album.Title Like '" + termQuery + "'";
                    ad = new SQLiteDataAdapter(cmd);
                    ad.Fill(dt);
                    searchDGV.DataSource = dt;
                }
            }
            else if (rbGenre.Checked == true)
            {
                dt = new DataTable();
                using (SQLiteConnection conn = ConnectionManager.getConnection())
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT DISTINCT * FROM Genre WHERE Genre.Name Like '" + termQuery + "'";
                    ad = new SQLiteDataAdapter(cmd);
                    ad.Fill(dt);
                    searchDGV.DataSource = dt;
                }
            }
            else if(rbOrder.Checked == true)
            {
                dt = new DataTable();
                using (SQLiteConnection conn = ConnectionManager.getConnection())
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT DISTINCT * FROM MusicOrder WHERE MusicOrder.CustomerId Like '" + termQuery + "'";
                    ad = new SQLiteDataAdapter(cmd);
                    ad.Fill(dt);
                    searchDGV.DataSource = dt;
                }
            }
            else if (rbCustomer.Checked == true)
            {
                dt = new DataTable();
                using (SQLiteConnection conn = ConnectionManager.getConnection())
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT DISTINCT * FROM Customer WHERE Customer.LastName Like '" + termQuery + "'";
                    ad = new SQLiteDataAdapter(cmd);
                    ad.Fill(dt);
                    searchDGV.DataSource = dt;
                }
            }
            else if (rbEmployee.Checked == true)
            {
                dt = new DataTable();
                using (SQLiteConnection conn = ConnectionManager.getConnection())
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT DISTINCT * FROM Employee WHERE Employee.LastName Like '" + termQuery + "'";
                    ad = new SQLiteDataAdapter(cmd);
                    ad.Fill(dt);
                    searchDGV.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Must select something to search.", "Input Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string helpString = "Partial search terms accepted." + 
                "\nTo search for Artists, search by artist name." +
                "\nTo search for Albums, search by album name." +
                "\nTo search for Genres, search by genre name." +
                "\nTo search for Customers, search by last name." +
                "\nTo search for Orders, search by customer ID" +
                "\nTo search for Employees, search by last name.";
            MessageBox.Show(helpString, "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
    }
}
