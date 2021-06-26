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
    public partial class BrowseSuplier : Form
    {
        public BrowseSuplier()
        {
            InitializeComponent();
        }

        private void m_supplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_supplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_UASDataSet);

        }

        private void BrowseSuplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_UASDataSet.m_supplier' table. You can move, or remove it, as needed.
            this.m_supplierTableAdapter.Fill(this.project_UASDataSet.m_supplier);

        }

        private void fillByPIdToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.m_supplierTableAdapter.FillByPId(this.project_UASDataSet.m_supplier, p_IDToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void m_supplierDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11)
            {
                MasterSuplier ms = new MasterSuplier();
                ms.id = m_supplierDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                ms.detail = true;
                ms.Show();
            }
        }

        private void fillByPIdToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
