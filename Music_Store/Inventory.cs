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
        }

        private void menuArtist_Opening(object sender, CancelEventArgs e)
        {
            miDeleteArtist.Enabled = (gridArtist.SelectedRows.Count == 1);
        }
    }
}
