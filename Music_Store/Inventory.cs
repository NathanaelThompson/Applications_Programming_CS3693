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
            InitDataSource();
        }

        private void InitDataSource()
        {
            //Grid view datasources
            gvArtist.DataSource = ConnectionManager.ArtistView();
            gvAlbums.DataSource = ConnectionManager.AlbumView();
            gvCustomers.DataSource = ConnectionManager.CustomerView();
            gvEmployees.DataSource = ConnectionManager.EmployeeView();
            gvGenres.DataSource = ConnectionManager.GenreView();

            //combo box datasources
            cbAlbumArtist.DataSource = ConnectionManager.ArtistComboBox();
            cbAlbumArtist.DisplayMember = "Name";
            cbAlbumArtist.ValueMember = "ArtistID";

            cbAlbumGenre.DataSource = ConnectionManager.GenreComboBox();
            cbAlbumGenre.DisplayMember = "Name";
            cbAlbumGenre.ValueMember = "GenreID";

            cbEmployeSeqQuestions.DataSource = ConnectionManager.SecurityQuestionComboBox();
            cbEmployeSeqQuestions.DisplayMember = "Question";
            cbEmployeSeqQuestions.ValueMember = "SecurityQuestionID";
        }

        public void ReloadData()
        {
            gvArtist.DataSource = null;
            gvAlbums.DataSource = null;
            gvCustomers.DataSource = null;
            gvEmployees.DataSource = null;
            gvGenres.DataSource = null;
            cbAlbumGenre.DataSource = null;
            cbAlbumArtist.DataSource = null;
            cbEmployeSeqQuestions.DataSource = null;
            InitDataSource();
        }

        private void menuArtist_Opening(object sender, CancelEventArgs e)
        {
            miDeleteArtist.Enabled = (gvArtist.SelectedRows.Count == 1);
            miEditArtist.Enabled = (gvArtist.SelectedRows.Count == 1);
        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            ConnectionManager.addArtist(txtArtistName.Text.Trim());
            txtArtistName.Clear();
            ReloadData();
        }

        private void btnAddAlbum_Click(object sender, EventArgs e)
        {
            ConnectionManager.addAlbum(cbAlbumArtist.SelectedValue.ToString(), cbAlbumGenre.SelectedValue.ToString(),
                txtAlbumName.Text.Trim(), txtAlbumPrice.Text.Trim(), udAlbumQty.Value.ToString());

            txtAlbumName.Clear();
            txtAlbumPrice.Clear();
            cbAlbumArtist.SelectedIndex = 0;
            cbAlbumGenre.SelectedIndex = 0;
            udAlbumQty.Value = 0;
            ReloadData();
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            ConnectionManager.addGenre(txtGenreName.Text.Trim(), txtGenreDesc.Text.Trim());
            txtGenreName.Clear();
            txtGenreDesc.Clear();
            ReloadData();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            int admin = chkEmployeeAdmin.Checked ? 1 : 0;

            ConnectionManager.addEmployee(txtEmployeeLogin.Text.Trim(), cbEmployeSeqQuestions.SelectedValue.ToString(), 
                txtEmployeePass.Text.Trim(), dtDemployeeHireDate.Value.ToString(), admin.ToString(), 
                txtEmployeeAnswer.Text.Trim(), txtEmployeeFirstName.Text.Trim(),
                txtEmployeeLastName.Text); 

            txtEmployeePass.Clear();
            txtEmployeeLogin.Clear();
            chkEmployeeAdmin.Checked = false;
            txtEmployeeAnswer.Clear();
            txtEmployeeFirstName.Clear();
            txtEmployeeLastName.Clear();
            dtDemployeeHireDate.Value = DateTime.Now;
            ReloadData();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            ConnectionManager.addCustomer(txtCustomerFirstName.Text.Trim(), txtCustomerLastName.Text.Trim(),
                txtCustomerEmail.Text.Trim(), txtCustomerPhone.Text.Trim());

            txtCustomerEmail.Clear();
            txtCustomerPhone.Clear();
            txtCustomerFirstName.Clear();
            txtCustomerLastName.Clear();
            ReloadData();
        }

        private void miDeleteArtist_Click(object sender, EventArgs e)
        {

        }

        private void formInventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }


    }
}
