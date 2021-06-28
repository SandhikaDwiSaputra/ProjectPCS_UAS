using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryMasterMerk;

namespace ProjectPCSuas
{
    public partial class Invoice : Form
    {
        SqlConnection conn;

        public Invoice()
        {
            try
            {
                conn = dbUAS.GetConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
                throw;
            }
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

        private void fillByInvoiceNoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.t_invoice_headerTableAdapter.FillByInvoiceNo(this.uASDataSet2.t_invoice_header, nO_INVToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void iDComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (iDComboBox.SelectedValue != null)
            {
                nAMATextBox.Text = "";
                aLAMATTextBox.Text = "";
                eMAILTextBox.Text = "";
                kOTATextBox.Text = "";
                nAMA_NPWPTextBox.Text = "";
                aLAMAT_NPWTextBox.Text = "";
                conn.Open();
                String query = $"SELECT * FROM m_supplier WHERE P_ID = '{iDComboBox.SelectedValue.ToString()}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    aLAMATTextBox.Text = dr[2].ToString();
                    nAMATextBox.Text = dr[1].ToString();
                    eMAILTextBox.Text = dr[8].ToString();
                    kOTATextBox.Text = dr[3].ToString();
                    nAMA_NPWPTextBox.Text = dr[6].ToString();
                    aLAMAT_NPWTextBox.Text = dr[7].ToString();
                }

                conn.Close();
            }
            
        }
    }
}
