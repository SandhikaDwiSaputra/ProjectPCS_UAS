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

namespace ProjectPCSuas
{
    public partial class Rework : Form
    {
        SqlConnection conn;
        public Rework()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=UAS;Integrated Security=True");
        }

        private void reworkBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reworkBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uASDataSet2);

        }

        private void Rework_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uASDataSet2.t_invoice_header' table. You can move, or remove it, as needed.
            this.t_invoice_headerTableAdapter.Fill(this.uASDataSet2.t_invoice_header);
            // TODO: This line of code loads data into the 'uASDataSet2.m_barang' table. You can move, or remove it, as needed.
            this.m_barangTableAdapter.Fill(this.uASDataSet2.m_barang);
            // TODO: This line of code loads data into the 'uASDataSet2.t_invoice_detail' table. You can move, or remove it, as needed.
            this.t_invoice_detailTableAdapter.Fill(this.uASDataSet2.t_invoice_detail);
            // TODO: This line of code loads data into the 'uASDataSet2.rework_detail' table. You can move, or remove it, as needed.
            this.rework_detailTableAdapter.Fill(this.uASDataSet2.rework_detail);
            // TODO: This line of code loads data into the 'uASDataSet2.rework' table. You can move, or remove it, as needed.
            this.reworkTableAdapter.Fill(this.uASDataSet2.rework);

            rework_detail_item_codeTextBox.ReadOnly = true;
            rework_detail_item_descTextBox.ReadOnly = true;
            rework_detail_item_part_noTextBox.ReadOnly = true;
            rework_detail_unit_priceTextBox.ReadOnly = true;
            rework_detail_unitTextBox.ReadOnly = true;
            rework_detail_amountTextBox.ReadOnly = true;

            data();
        }

        private void data()
        {
            rework_detail_qtyTextBox.Text = "0";
            rework_detail_unit_price_tempTextBox.Text = "0";
            rework_detail_amountTextBox.Text = "0";
            rework_detail_brandTextBox.Text = "";
            if (rework_idTextBox.Text.Length == 0)
            {
                rework_idTextBox.Text = "0";
            }
            if (rework_idTextBox.Text.Length > 0)
            {
                try
                {
                    this.rework_detailTableAdapter.FillByReworkId(this.uASDataSet2.rework_detail, Convert.ToInt32(rework_idTextBox.Text));
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            String D = "SELECT  count(rework_id) " +
                       "FROM rework " +
                       "where rework_id="+rework_idTextBox.Text;
            SqlCommand c = new SqlCommand(D, conn);
            String c2 = c.ExecuteScalar().ToString();

            if (Convert.ToInt32(c2) < 1)
            {
                this.Validate();
                this.reworkBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.uASDataSet2);
            }

            String Data = "SELECT  count(*) " +
                            "FROM rework_detail ";
            SqlCommand com = new SqlCommand(Data, conn);
            String kode = com.ExecuteScalar().ToString();

            if (Convert.ToInt32(kode) < 1)
            {
                String query = "Insert into rework_detail values(1, " + Convert.ToInt32(rework_idTextBox.Text) + ", " + (int)rework_detail_item_idComboBox.SelectedValue + ", '" + rework_detail_item_codeTextBox.Text + "', '" + rework_detail_item_part_noTextBox.Text + "', '" + rework_detail_item_descTextBox.Text + "', '" + rework_detail_unitTextBox.Text + "', " + Convert.ToInt32(rework_detail_qtyTextBox.Text) + ", " + Convert.ToInt32(rework_detail_unit_priceTextBox.Text) + ", " + Convert.ToInt32(rework_detail_unit_price_tempTextBox.Text) + ", " + Convert.ToInt32(rework_detail_amountTextBox.Text) + ", '"+rework_detail_brandTextBox.Text+"')";
                SqlCommand comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();
            }
            else
            {
                String id = "SELECT  max(rework_detail_id) " +
                            "FROM rework_detail ";
                SqlCommand comId = new SqlCommand(id, conn);
                String id2 = comId.ExecuteScalar().ToString();

                String query = "Insert into rework_detail values("+(Convert.ToInt32(id2)+1)+" , " + Convert.ToInt32(rework_idTextBox.Text) + ", " + (int)rework_detail_item_idComboBox.SelectedValue + ", '" + rework_detail_item_codeTextBox.Text + "', '" + rework_detail_item_part_noTextBox.Text + "', '" + rework_detail_item_descTextBox.Text + "', '" + rework_detail_unitTextBox.Text + "', " + Convert.ToInt32(rework_detail_qtyTextBox.Text) + ", " + Convert.ToInt32(rework_detail_unit_priceTextBox.Text) + ", " + Convert.ToInt32(rework_detail_unit_price_tempTextBox.Text) + ", " + Convert.ToInt32(rework_detail_amountTextBox.Text) + ", '" + rework_detail_brandTextBox.Text + "' )";
                SqlCommand comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();
            }
            String Qty = "SELECT  qty " +
                         "FROM t_invoice_detail "+
                         "where no_inv="+invoice_idComboBox.SelectedValue +
                         " and kode='"+rework_detail_item_codeTextBox.Text+"'";
            SqlCommand comq = new SqlCommand(Qty, conn);
            String qty2 = comq.ExecuteScalar().ToString();

            if (qty2.Length > 0 && Convert.ToInt32(qty2) >= Convert.ToInt32(rework_detail_qtyTextBox.Text))
            {
                int qtyA = (Convert.ToInt32(qty2) - Convert.ToInt32(rework_detail_qtyTextBox.Text));
                String query2 = "update t_invoice_detail set qty=" + qtyA + " where no_inv=" + invoice_idComboBox.SelectedValue + " and kode='" + rework_detail_item_codeTextBox.Text + "'";
                SqlCommand commQu = new SqlCommand(query2, conn);
                commQu.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Barang hanya ada " + qty2);
            }
            data();
            conn.Close();
        }

        private void rework_detail_item_idComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rework_detail_item_idComboBox.SelectedIndex != -1)
            {
                conn.Open();
                String Data = "SELECT kode " +
                               "FROM m_barang " +
                               "WHERE id = " + rework_detail_item_idComboBox.SelectedValue;
                SqlCommand com = new SqlCommand(Data, conn);
                String kode = com.ExecuteScalar().ToString();

                String Data2 = "SELECT part_no " +
                               "FROM m_barang " +
                               "WHERE id = " + rework_detail_item_idComboBox.SelectedValue;
                SqlCommand com2 = new SqlCommand(Data2, conn);
                String partNo = com2.ExecuteScalar().ToString();

                String Data3 = "SELECT description " +
                               "FROM m_barang " +
                               "WHERE id = " + rework_detail_item_idComboBox.SelectedValue;
                SqlCommand com3 = new SqlCommand(Data3, conn);
                String desc = com3.ExecuteScalar().ToString();

                String Data4 = "SELECT unit_price " +
                               "FROM m_barang " +
                               "WHERE id = " + rework_detail_item_idComboBox.SelectedValue;
                SqlCommand com4 = new SqlCommand(Data4, conn);
                String price = com4.ExecuteScalar().ToString();

                String Data5 = "SELECT unit " +
                               "FROM m_barang " +
                               "WHERE id = " + rework_detail_item_idComboBox.SelectedValue;
                SqlCommand com5 = new SqlCommand(Data5, conn);
                String unit = com5.ExecuteScalar().ToString();
                conn.Close();

                rework_detail_item_codeTextBox.Text = kode;
                rework_detail_item_descTextBox.Text = desc;
                rework_detail_item_part_noTextBox.Text = partNo;
                rework_detail_unit_priceTextBox.Text = price;
                rework_detail_unitTextBox.Text = unit;
            }
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            data();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            data();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            data();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            data();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            data();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            conn.Open();
            String query = "DELETE FROM rework_detail WHERE rework_id=" + rework_idTextBox.Text;
            SqlCommand comm = new SqlCommand(query, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }

        private void rework_detail_qtyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (rework_detail_qtyTextBox.Text.Length > 0)
            {
                int ttl = Convert.ToInt32(rework_detail_qtyTextBox.Text) * Convert.ToInt32(rework_detail_unit_priceTextBox.Text);
                rework_detail_amountTextBox.Text = ttl.ToString();
            }
        }
    }
}
