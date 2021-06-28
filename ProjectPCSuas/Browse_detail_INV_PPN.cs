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
    public partial class Browse_detail_INV_PPN : Form
    {
        public Browse_detail_INV_PPN()
        {
            InitializeComponent();
        }

        private void t_invoiceppn_detailBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_invoiceppn_detailBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_UASDataSet);

        }

        private void Browse_detail_INV_PPN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_UASDataSet.t_invoiceppn_detail' table. You can move, or remove it, as needed.
            this.t_invoiceppn_detailTableAdapter.Fill(this.project_UASDataSet.t_invoiceppn_detail);

        }
    }
}
