using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPCSuas
{
    public partial class MasterPelanggan : Form
    {
        public MasterPelanggan()
        {
            InitializeComponent();
        }

        

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_UASDataSet.m_pelanggan' table. You can move, or remove it, as needed.
            this.m_pelangganTableAdapter.Fill(this.project_UASDataSet.m_pelanggan);

        }



        private void BrowseBTN_Click(object sender, EventArgs e)
        {
            BrowsePelanggan BB = new BrowsePelanggan();
            BB.Show();
        }

        private void m_pelangganBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_pelangganBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_UASDataSet);

        }

        private void PrintPelanggan_Click(object sender, EventArgs e)
        {
            PrintMasterPelanggan PP = new PrintMasterPelanggan();
            PP.Show();
        }

        private void m_pelangganBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
