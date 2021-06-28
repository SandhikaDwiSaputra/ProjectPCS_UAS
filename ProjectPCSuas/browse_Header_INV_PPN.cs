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
    public partial class browse_Header_INV_PPN : Form
    {
        public browse_Header_INV_PPN()
        {
            InitializeComponent();
        }

        private void t_invoiceppn_headerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_invoiceppn_headerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_UASDataSet);

        }

        private void browse_Header_INV_PPN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_UASDataSet.t_invoiceppn_header' table. You can move, or remove it, as needed.
            this.t_invoiceppn_headerTableAdapter.Fill(this.project_UASDataSet.t_invoiceppn_header);

        }
    }
}
