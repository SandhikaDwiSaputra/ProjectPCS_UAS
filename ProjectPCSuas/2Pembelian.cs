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
    public partial class _2Pembelian : Form
    {
        public _2Pembelian()
        {
            InitializeComponent();
        }

        

        private void _2Pembelian_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_UASDataSet.t_pembelian_header' table. You can move, or remove it, as needed.
            this.t_pembelian_headerTableAdapter.Fill(this.project_UASDataSet.t_pembelian_header);
            // TODO: This line of code loads data into the 'project_UASDataSet.t_invoiceppn_header' table. You can move, or remove it, as needed.


        }

        private void t_pembelian_headerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_pembelian_headerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_UASDataSet);

        }
    }
}
