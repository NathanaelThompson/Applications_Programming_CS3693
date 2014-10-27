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
            if (txtArtistName.Text.Trim().Length != 0)
            {
                ConnectionManager.addArtist(txtArtistName.Text.Trim());
                txtArtistName.Clear();
                ReloadData();
                lblArtistName.Visible = false;
            }
            else
            {
                lblArtistName.Text = "Fields cannot be blank";
                lblArtistName.Visible = true;
            }
        }

        private void btnAddAlbum_Click(object sender, EventArgs e)
        {
            if (txtAlbumName.Text.Trim().Length != 0 && txtAlbumPrice.Text.Trim().Length != 0)
            {
                ConnectionManager.addAlbum(cbAlbumArtist.SelectedValue.ToString(), cbAlbumGenre.SelectedValue.ToString(),
                    txtAlbumName.Text.Trim(), txtAlbumPrice.Text.Trim(), udAlbumQty.Value.ToString());

                txtAlbumName.Clear();
                txtAlbumPrice.Clear();
                cbAlbumArtist.SelectedIndex = 0;
                cbAlbumGenre.SelectedIndex = 0;
                udAlbumQty.Value = 0;
                ReloadData();
                lblAlbumError.Visible = false;
            }
            else
            {
                lblAlbumError.Text = "Fields cannot be blank";
                lblAlbumError.Visible = true;
            }
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            if (txtGenreName.Text.Trim().Length != 0 && txtGenreDesc.Text.Trim().Length != 0)
            {
                ConnectionManager.addGenre(txtGenreName.Text.Trim(), txtGenreDesc.Text.Trim());
                txtGenreName.Clear();
                txtGenreDesc.Clear();
                ReloadData();
                lblGenreError.Visible = false;
            }
            else
            {
                lblGenreError.Text = "Fields cannot be blank";
                lblGenreError.Visible = false;
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (txtEmployeeFirstName.Text.Trim().Length != 0 && txtEmployeeLastName.Text.Trim().Length != 0
                && txtEmployeePass.Text.Trim().Length != 0 && txtEmployeeAnswer.Text.Trim().Length != 0)
            {
                int admin = chkEmployeeAdmin.Checked ? 1 : 0;
                string loginID = (txtEmployeeFirstName.Text[0] + txtEmployeeLastName.Text).ToLower();
                int count = ConnectionManager.EmployeeCheck(loginID);

                if (count != 0)
                    loginID = loginID + count.ToString();

                ConnectionManager.addEmployee(loginID, cbEmployeSeqQuestions.SelectedValue.ToString(),
                    txtEmployeePass.Text.Trim(), dtDemployeeHireDate.Value.ToString("MM/dd/yyyy"), admin.ToString(),
                    txtEmployeeAnswer.Text.Trim(), txtEmployeeFirstName.Text.Trim(),
                    txtEmployeeLastName.Text);

                txtEmployeePass.Clear();
                chkEmployeeAdmin.Checked = false;
                txtEmployeeAnswer.Clear();
                txtEmployeeFirstName.Clear();
                txtEmployeeLastName.Clear();
                dtDemployeeHireDate.Value = DateTime.Now;
                ReloadData();
                lblEmployeeError.Visible = false;
            }
            else
            {
                lblEmployeeError.Text = "Fields cannot be blank";
                lblEmployeeError.Visible = true;
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (txtCustomerFirstName.Text.Trim().Length != 0 && txtCustomerLastName.Text.Trim().Length != 0
                && txtCustomerEmail.Text.Trim().Length != 0 && txtCustomerPhone.Text.Trim().Length != 0)
            {
                ConnectionManager.addCustomer(txtCustomerFirstName.Text.Trim(), txtCustomerLastName.Text.Trim(),
                    txtCustomerEmail.Text.Trim(), txtCustomerPhone.Text.Trim());

                txtCustomerEmail.Clear();
                txtCustomerPhone.Clear();
                txtCustomerFirstName.Clear();
                txtCustomerLastName.Clear();
                ReloadData();
                lblCustomerError.Visible = false;
            }
            else
            {
                lblCustomerError.Text = "Fields cannot be blank";
                lblCustomerError.Visible = true;
            }
        }

        private void miDeleteArtist_Click(object sender, EventArgs e)
        {

        }

        private void formInventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void formInventory_VisibleChanged(object sender, EventArgs e)
        {
            ReloadData();
        }
    }
}
