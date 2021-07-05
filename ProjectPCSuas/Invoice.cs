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
        int no_inv;

        public void data()
        {
            try
            {
                try
                {
                    this.t_invoice_detailTableAdapter.FillBy3(this.project_UASDataSet.t_invoice_detail, nO_INVTextBox.Text);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            catch (System.NullReferenceException)
            {

            }
        }

        private void total()
        {
            int t = t_invoice_detailBindingSource.Count;
            int total2 = 0;
            for (int i = 0; i < t; i++)
            {
                int jml = (int)t_invoice_detailDataGridView.Rows[i].Cells[4].Value;
                int hrg = (int)t_invoice_detailDataGridView.Rows[i].Cells[6].Value;

                int total = jml * hrg;
                total2 += total;
            }
            pART_CHARGTextBox.Text = total2.ToString();
            pPNTextBox.Text = total2 / 10 + "";
            if (dISCOUNTTextBox.Text.Equals("") && sERVICE_CHTextBox.Text.Equals(""))
            {
                int gt = Convert.ToInt32(pART_CHARGTextBox.Text) + Convert.ToInt32(pPNTextBox.Text);
                textBox1.Text = gt.ToString();
            }
            else if (sERVICE_CHTextBox.Text.Equals(""))
            {
                int gt = Convert.ToInt32(pART_CHARGTextBox.Text) + Convert.ToInt32(pPNTextBox.Text) - Convert.ToInt32(dISCOUNTTextBox.Text);
                textBox1.Text = gt.ToString();
            }
            else if (dISCOUNTTextBox.Text.Equals(""))
            {
                int gt = Convert.ToInt32(pART_CHARGTextBox.Text) + Convert.ToInt32(pPNTextBox.Text) + Convert.ToInt32(sERVICE_CHTextBox.Text);
                textBox1.Text = gt.ToString();
            }
            else
            {
                int gt = Convert.ToInt32(pART_CHARGTextBox.Text) + Convert.ToInt32(pPNTextBox.Text) + Convert.ToInt32(sERVICE_CHTextBox.Text) - Convert.ToInt32(dISCOUNTTextBox.Text);
                textBox1.Text = gt.ToString();
            }
        }

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

            conn.Open();

            String DataBrg = "SELECT count(*) " +
                             "FROM stock_history ";
            SqlCommand comm = new SqlCommand(DataBrg, conn);
            String kode = comm.ExecuteScalar().ToString();

            int QTY = Convert.ToInt32(qTYTextBox.Text);

            if (Convert.ToInt32(kode) < 1)
            {
                String query = "Insert into stock_history(ID_STOCK_HISTORY, ID_INVOICE, STOCK_HISTORY_VALUE, STOCK_HISTORY_DATE) values(1, " + Convert.ToInt32(nO_INVTextBox.Text) + ", " + QTY + ", GETDATE())";
                comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();
            }
            else
            {
                String id = "SELECT MAX(ID_STOCK_HISTORY) " +
                             "FROM stock_history ";
                SqlCommand comm3 = new SqlCommand(id, conn);
                String kode3 = comm3.ExecuteScalar().ToString();

                String query = "Insert into stock_history(ID_STOCK_HISTORY, ID_INVOICE, STOCK_HISTORY_VALUE, STOCK_HISTORY_DATE) values(" + (Convert.ToInt32(kode3) + 1) + ", " + Convert.ToInt32(nO_INVTextBox.Text) + ", " + QTY + ", GETDATE())";
                comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();
            }
            conn.Close();

        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_UASDataSet.t_invoice_header' table. You can move, or remove it, as needed.
            this.t_invoice_headerTableAdapter1.Fill(this.project_UASDataSet.t_invoice_header);
            // TODO: This line of code loads data into the 'project_UASDataSet.m_barang' table. You can move, or remove it, as needed.
            this.m_barangTableAdapter.Fill(this.project_UASDataSet.m_barang);
            // TODO: This line of code loads data into the 'project_UASDataSet.t_invoice_detail' table. You can move, or remove it, as needed.
            this.t_invoice_detailTableAdapter.Fill(this.project_UASDataSet.t_invoice_detail);
            // TODO: This line of code loads data into the 'project_UASDataSet.m_pelanggan' table. You can move, or remove it, as needed.
            this.m_pelangganTableAdapter.Fill(this.project_UASDataSet.m_pelanggan);
            // TODO: This line of code loads data into the 'project_UASDataSet.m_supplier' table. You can move, or remove it, as needed.
            this.m_supplierTableAdapter.Fill(this.project_UASDataSet.m_supplier);
            // TODO: This line of code loads data into the 'uASDataSet2.t_invoice_header' table. You can move, or remove it, as needed.
            this.t_invoice_headerTableAdapter.Fill(this.uASDataSet2.t_invoice_header);
            data();
            total();
        }

        private void fillByInvoiceNoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.t_invoice_headerTableAdapter.FillByInvoiceNo(this.uASDataSet2.t_invoice_header, nO_INVToolStripTextBox.Text);
                data();
                total();
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

        private void dISCOUNTTextBox_TextChanged(object sender, EventArgs e)
        {
            total();
        }

        private void sERVICE_CHTextBox_TextChanged(object sender, EventArgs e)
        {
            total();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            data();
            total();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text.Equals("Tambah Barang"))
            {
                conn.Open();
                String Data = "SELECT COUNT(NO_PNW) " +
                                 "FROM t_penawaran_header " +
                                 "WHERE NO_PNW = '" + nO_PNWTextBox.Text + "'";
                SqlCommand com = new SqlCommand(Data, conn);
                String pnw = com.ExecuteScalar().ToString();

                if (Convert.ToInt32(pnw) < 1)
                {
                    this.t_invoice_headerBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.uASDataSet2);
                }


                String DataBrg = "SELECT kode " +
                                 "FROM m_barang " +
                                 "WHERE id = " + dESCRIPTIONComboBox.SelectedValue;
                SqlCommand comm = new SqlCommand(DataBrg, conn);

                String DataBrg2 = "SELECT part_no " +
                                 "FROM m_barang " +
                                 "WHERE id = " + dESCRIPTIONComboBox.SelectedValue;
                SqlCommand comm2 = new SqlCommand(DataBrg2, conn);

                String DataBrg3 = "SELECT description " +
                                 "FROM m_barang " +
                                 "WHERE id = " + dESCRIPTIONComboBox.SelectedValue;
                SqlCommand comm3 = new SqlCommand(DataBrg3, conn);

                String DataBrg4 = "SELECT unit_price " +
                                 "FROM m_barang " +
                                 "WHERE id = " + dESCRIPTIONComboBox.SelectedValue;
                SqlCommand comm4 = new SqlCommand(DataBrg4, conn);

                String kode = comm.ExecuteScalar().ToString();
                String part_no = comm2.ExecuteScalar().ToString();
                String description = comm3.ExecuteScalar().ToString();
                String unit = comm4.ExecuteScalar().ToString();

                String query = "Insert into t_penawaran_detail values('" + nO_PNWTextBox.Text + "', '" + kode + "', '" + part_no + "', '" + description + "', " + Convert.ToInt32(qTYTextBox.Text) + ", 0, " + Convert.ToInt32(unit) + ", " + Convert.ToInt32(unit) + ")";
                comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();

                String data = "Insert into t_invoice_detail values('" + no_inv + "', '" + kode + "', '" + part_no + "', '" + description + "', " + Convert.ToInt32(qTYTextBox.Text) + ", 0, " + Convert.ToInt32(unit) + ", " + Convert.ToInt32(unit) + ")";
                SqlCommand command = new SqlCommand(data, conn);
                command.ExecuteNonQuery();

                conn.Close();
            }
            else
            {
                conn.Open();
                String DataBrg = "SELECT kode " +
                                 "FROM m_barang " +
                                 "WHERE id = " + dESCRIPTIONComboBox.SelectedValue;
                SqlCommand comm = new SqlCommand(DataBrg, conn);

                String kode = comm.ExecuteScalar().ToString();

                String query = "UPDATE t_penawaran_detail SET qty = " + Convert.ToInt32(qTYTextBox.Text) + " WHERE kode = '" + kode + "' AND NO_PNW='" + nO_PNWTextBox.Text + "'";
                comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();

                String data = "UPDATE t_invoice_detail SET qty = " + Convert.ToInt32(qTYTextBox.Text) + " WHERE kode = '" + kode + "' AND NO_INV='" + no_inv + "'";
                SqlCommand command = new SqlCommand(data, conn);
                command.ExecuteNonQuery();
                conn.Close();
                button1.Text = "Tambah Barang";
                button2.Enabled = false;
            }

            if (p_IDTextBox.Text.Length == -1 || tGL_INVDateTimePicker.Text.Equals("") || tGL_TERIMADateTimePicker.Text.Equals(""))
            {
                MessageBox.Show("P_ID/Model/Tanggal harus diisi");
            }
            else
            {
                this.t_invoice_detailTableAdapter.Fill(this.project_UASDataSet.t_invoice_detail);
                data();
                total();
            }
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            data();
            total();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            data();
            total();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            data();
            total();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Warning!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                conn.Open();

                String DataBrg = "SELECT kode " +
                                 "FROM m_barang " +
                                 "WHERE id = " + dESCRIPTIONComboBox.SelectedValue;
                SqlCommand comm = new SqlCommand(DataBrg, conn);

                String DataBrg2 = "SELECT part_no " +
                                 "FROM m_barang " +
                                 "WHERE id = " + dESCRIPTIONComboBox.SelectedValue;
                SqlCommand comm2 = new SqlCommand(DataBrg2, conn);

                String DataBrg3 = "SELECT description " +
                                 "FROM m_barang " +
                                 "WHERE id = " + dESCRIPTIONComboBox.SelectedValue;
                SqlCommand comm3 = new SqlCommand(DataBrg3, conn);

                String DataBrg4 = "SELECT unit_price " +
                                 "FROM m_barang " +
                                 "WHERE id = " + dESCRIPTIONComboBox.SelectedValue;
                SqlCommand comm4 = new SqlCommand(DataBrg4, conn);

                String kode = comm.ExecuteScalar().ToString();
                String part_no = comm2.ExecuteScalar().ToString();
                String description = comm3.ExecuteScalar().ToString();
                String unit = comm4.ExecuteScalar().ToString();

                String query = "DELETE FROM t_invoice_detail WHERE NO_PNW='" + no_inv + "' AND KODE='" + kode + "'";
                comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();
                conn.Close();

                data();
                total();

                this.tableAdapterManager.UpdateAll(this.uASDataSet2);
            }
            button2.Enabled = false;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            conn.Open();

            String DataBrg = "SELECT kode " +
                             "FROM m_barang " +
                             "WHERE id = " + dESCRIPTIONComboBox.SelectedValue;
            SqlCommand comm = new SqlCommand(DataBrg, conn);

            String DataBrg2 = "SELECT part_no " +
                             "FROM m_barang " +
                             "WHERE id = " + dESCRIPTIONComboBox.SelectedValue;
            SqlCommand comm2 = new SqlCommand(DataBrg2, conn);

            String DataBrg3 = "SELECT description " +
                             "FROM m_barang " +
                             "WHERE id = " + dESCRIPTIONComboBox.SelectedValue;
            SqlCommand comm3 = new SqlCommand(DataBrg3, conn);

            String DataBrg4 = "SELECT unit_price " +
                             "FROM m_barang " +
                             "WHERE id = " + dESCRIPTIONComboBox.SelectedValue;
            SqlCommand comm4 = new SqlCommand(DataBrg4, conn);

            String kode = comm.ExecuteScalar().ToString();
            String part_no = comm2.ExecuteScalar().ToString();
            String description = comm3.ExecuteScalar().ToString();
            String unit = comm4.ExecuteScalar().ToString();

            String query = "DELETE FROM t_invoice_detail WHERE NO_INV='" + no_inv + "'";
            comm = new SqlCommand(query, conn);
            comm.ExecuteNonQuery();
            conn.Close();

            total();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            dISCOUNTTextBox.Text = "0";
            sERVICE_CHTextBox.Text = "0";
            data();
            total();
        }

        private void t_invoice_detailDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();
            String kode = t_invoice_detailDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            String DataBrg = "SELECT id " +
                             "FROM m_barang " +
                             "WHERE kode = '" + kode + "'";
            SqlCommand comm = new SqlCommand(DataBrg, conn);
            String code = comm.ExecuteScalar().ToString();

            dESCRIPTIONComboBox.SelectedValue = code;
            conn.Close();
            button2.Enabled = true;
            button1.Text = "Update Barang";
        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.t_invoice_headerTableAdapter1.FillBy2(this.project_UASDataSet.t_invoice_header, nO_INVTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
