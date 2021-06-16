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

        private void m_pelangganBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_pelangganBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uASDataSet2);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uASDataSet2.m_pelanggan' table. You can move, or remove it, as needed.
            this.m_pelangganTableAdapter.Fill(this.uASDataSet2.m_pelanggan);

        }

        private void hPTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void iDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
