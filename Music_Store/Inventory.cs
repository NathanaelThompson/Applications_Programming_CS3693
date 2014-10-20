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
    public partial class formInventory : Form
    {
        public formInventory()
        {
            InitializeComponent();
            gvArtist.DataSource = ConnectionManager.ArtistView();
            gvAlbums.DataSource = ConnectionManager.AlbumView();
            gvCustomers.DataSource = ConnectionManager.CustomerView();
            gvEmployees.DataSource = ConnectionManager.EmployeeView();
            gvGenres.DataSource = ConnectionManager.GenreView();
            
        }

        private void menuArtist_Opening(object sender, CancelEventArgs e)
        {
            miDeleteArtist.Enabled = (gvArtist.SelectedRows.Count == 1);
        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            ConnectionManager.addArtist(txtArtistName.Text);
        }


    }
}
