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
    public partial class SupplierDetail : Form
    {
        public string id;

        public SupplierDetail()
        {
            InitializeComponent();
        }

        private void m_supplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_supplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_UASDataSet);

        }

        private void SupplierDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_UASDataSet.m_supplier' table. You can move, or remove it, as needed.
            this.m_supplierTableAdapter.Fill(this.project_UASDataSet.m_supplier);

            p_IDToolStripTextBox.Text = id;
            try
            {
                this.m_supplierTableAdapter.FillByPId(this.project_UASDataSet.m_supplier, p_IDToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.m_supplierBindingSource.RemoveCurrent();
            this.tableAdapterManager.UpdateAll(this.project_UASDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.m_supplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_UASDataSet);
        }
    }
}
