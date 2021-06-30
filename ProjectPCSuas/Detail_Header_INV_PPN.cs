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
    public partial class Detail_Header_INV_PPN : Form
    {
        public Detail_Header_INV_PPN()
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
            // TODO: This line of code loads data into the 'project_UASDataSet.t_invoiceppn_detail' table. You can move, or remove it, as needed.
            this.t_invoiceppn_detailTableAdapter.Fill(this.project_UASDataSet.t_invoiceppn_detail);
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
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void kODELabel_Click(object sender, EventArgs e)
        {

        }

        private void kODETextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pPNLabel_Click(object sender, EventArgs e)
        {

        }

        private void pPNTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void qTY_MLabel_Click(object sender, EventArgs e)
        {

        }

        private void qTY_MTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
