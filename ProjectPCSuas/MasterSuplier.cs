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
        public string id;
        public bool detail = false;

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
            // TODO: This line of code loads data into the 'uASDataSet2.m_supplier' table. You can move, or remove it, as needed.
            this.m_supplierTableAdapter.Fill(this.uASDataSet2.m_supplier);

            if (detail)
            {
                fillByPId2ToolStrip.Visible = true;
                m_supplierBindingNavigator.Visible = false;
                label1.Visible = false;
                BrowseBTN.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
                p_IDTextBox.ReadOnly = true;

                p_IDToolStripTextBox.Text = id;
                try
                {
                    this.m_supplierTableAdapter.FillByPId2(this.uASDataSet2.m_supplier, p_IDToolStripTextBox.Text);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            else
            {
                fillByPId2ToolStrip.Visible = false;
                m_supplierBindingNavigator.Visible = true;
                label1.Visible = true;
                BrowseBTN.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
                p_IDTextBox.ReadOnly = false;
            }
        }

        private void BrowseBTN_Click(object sender, EventArgs e)
        {
            BrowseSuplier BB = new BrowseSuplier();
            BB.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.m_supplierBindingSource.RemoveCurrent();
            this.tableAdapterManager.UpdateAll(this.uASDataSet2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.m_supplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uASDataSet2);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void fillByPId2ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.m_supplierTableAdapter.FillByPId2(this.uASDataSet2.m_supplier, p_IDToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
