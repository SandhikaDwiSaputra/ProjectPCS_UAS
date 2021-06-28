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
    public partial class Header_INV_PPN : Form
    {
        public Header_INV_PPN()
        {
            InitializeComponent();
        }

        private void t_invoiceppn_headerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_invoiceppn_headerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_UASDataSet);

        }

        private void Header_INV_PPN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_UASDataSet.t_invoiceppn_header' table. You can move, or remove it, as needed.
            this.t_invoiceppn_headerTableAdapter.Fill(this.project_UASDataSet.t_invoiceppn_header);

        }

        private void mEKANIKLabel_Click(object sender, EventArgs e)
        {

        }

        private void mEKANIKTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            browse_Header_INV_PPN bp = new browse_Header_INV_PPN();
            bp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            laporanheaderinvPPN lh = new laporanheaderinvPPN();
            lh.Show();
        }
    }
}
