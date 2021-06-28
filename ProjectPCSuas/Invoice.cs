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
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void t_invoice_headerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_invoice_headerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uASDataSet2);

        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_UASDataSet.t_invoice_detail' table. You can move, or remove it, as needed.
            this.t_invoice_detailTableAdapter.Fill(this.project_UASDataSet.t_invoice_detail);
            // TODO: This line of code loads data into the 'project_UASDataSet.m_pelanggan' table. You can move, or remove it, as needed.
            this.m_pelangganTableAdapter.Fill(this.project_UASDataSet.m_pelanggan);
            // TODO: This line of code loads data into the 'project_UASDataSet.m_supplier' table. You can move, or remove it, as needed.
            this.m_supplierTableAdapter.Fill(this.project_UASDataSet.m_supplier);
            // TODO: This line of code loads data into the 'uASDataSet2.t_invoice_header' table. You can move, or remove it, as needed.
            this.t_invoice_headerTableAdapter.Fill(this.uASDataSet2.t_invoice_header);

        }
    }
}
