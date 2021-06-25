﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPCSuas
{
    public partial class BrowseSuplier : Form
    {
        SqlConnection conn;

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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void fillByPIdToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.m_supplierTableAdapter.FillByPId(this.project_UASDataSet.m_supplier, p_IDToolStripTextBox.Text);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        private void m_supplierDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11)
            {
                SupplierDetail sd = new SupplierDetail();
                sd.id = m_supplierDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                sd.Show();
            }
        }
    }
}
