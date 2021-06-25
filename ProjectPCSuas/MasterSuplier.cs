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
    public partial class MasterSuplier : Form
    {
        public MasterSuplier()
        {
            InitializeComponent();
        }

        private void m_supplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_supplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uASDataSet2);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_UASDataSet.m_supplier' table. You can move, or remove it, as needed.
            this.m_supplierTableAdapter1.Fill(this.project_UASDataSet.m_supplier);
            // TODO: This line of code loads data into the 'uASDataSet2.m_supplier' table. You can move, or remove it, as needed.
            this.m_supplierTableAdapter.Fill(this.uASDataSet2.m_supplier);

        }

        private void BrowseBTN_Click(object sender, EventArgs e)
        {
            BrowseSuplier BB = new BrowseSuplier();
            BB.Show();
        }

        private void fillByPIdToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.m_supplierTableAdapter1.FillByPId(this.project_UASDataSet.m_supplier, p_IDToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
