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
    public partial class PenawaranHeader : Form
    {
        SqlConnection conn;

        public PenawaranHeader()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=UAS;Integrated Security=True");
        }

        private void t_penawaran_headerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (p_IDComboBox.SelectedIndex == -1 || mODELComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("P_ID/Model harus diisi");
            }
            else
            {
                this.Validate();
                this.t_penawaran_headerBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.uASDataSet2);
            }
        }

        private void PenawaranHeader_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uASDataSet2.m_barang' table. You can move, or remove it, as needed.
            this.m_barangTableAdapter.Fill(this.uASDataSet2.m_barang);
            // TODO: This line of code loads data into the 'uASDataSet2.t_penawaran_detail' table. You can move, or remove it, as needed.
            this.t_penawaran_detailTableAdapter.Fill(this.uASDataSet2.t_penawaran_detail);
            // TODO: This line of code loads data into the 'uASDataSet2.m_model' table. You can move, or remove it, as needed.
            this.m_modelTableAdapter.Fill(this.uASDataSet2.m_model);
            // TODO: This line of code loads data into the 'uASDataSet2.m_supplier' table. You can move, or remove it, as needed.
            this.m_supplierTableAdapter.Fill(this.uASDataSet2.m_supplier);
            // TODO: This line of code loads data into the 'uASDataSet2.m_users' table. You can move, or remove it, as needed.
            this.m_usersTableAdapter.Fill(this.uASDataSet2.m_users);
            // TODO: This line of code loads data into the 'uASDataSet2.t_penawaran_header' table. You can move, or remove it, as needed.
            this.t_penawaran_headerTableAdapter.Fill(this.uASDataSet2.t_penawaran_header);

            textBox1.ReadOnly = true;
            pPNTextBox.ReadOnly = true;
            pART_CHARGTextBox.ReadOnly = true;
            qTYTextBox.Text = "0";
            button2.Enabled = false;

            data();
            total();
        }

        private void data()
        {
            try
            {
                if ((int)dESCRIPTIONComboBox.SelectedValue != -1)
                {
                    conn.Open();
                    try
                    {
                        this.t_penawaran_detailTableAdapter.FillByNOPNW(this.uASDataSet2.t_penawaran_detail, nO_PNWTextBox.Text);
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                    qTYTextBox.Text = "";
                    conn.Close();
                }
            }
            catch (System.NullReferenceException)
            {

            }
        }

        private void total()
        {
            int t = t_penawaran_detailBindingSource.Count;
            int total2 = 0;
            for (int i = 0; i < t; i++)
            { 
                int jml = (int)t_penawaran_detailDataGridView.Rows[i].Cells[3].Value;
                int hrg = (int)t_penawaran_detailDataGridView.Rows[i].Cells[4].Value;

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

        private void pART_CHARGTextBox_TextChanged(object sender, EventArgs e)
        {

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
                conn.Close();
                button1.Text = "Tambah Barang";
                button2.Enabled = false;
            }    

            if (p_IDComboBox.SelectedIndex == -1 || mODELComboBox.SelectedIndex == -1 || tGL_PNWDateTimePicker.Text.Equals("") || tGL_TERIMADateTimePicker.Text.Equals(""))
            {
                MessageBox.Show("P_ID/Model/Tanggal harus diisi");
            }
            else
            {
                this.t_penawaran_detailTableAdapter.Fill(this.uASDataSet2.t_penawaran_detail);
                data();
                total();
            }
        }

        private void dESCRIPTIONComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            data();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            data();
            total();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            data();
            total();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
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

                 String query = "DELETE FROM t_penawaran_detail WHERE NO_PNW='" + nO_PNWTextBox.Text + "'";
                 comm = new SqlCommand(query, conn);
                 comm.ExecuteNonQuery();
                 conn.Close();

                 data();
                 total();

                 this.t_penawaran_headerBindingSource.RemoveCurrent();
                 this.tableAdapterManager.UpdateAll(this.uASDataSet2);

                 if (t_penawaran_headerBindingSource.Position == t_penawaran_headerBindingSource.Count)
                 {
                     t_penawaran_headerBindingSource.MovePrevious();
                 }
                 else
                 {
                     t_penawaran_headerBindingSource.MoveNext();
                 }
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

            String query = "DELETE FROM t_penawaran_detail WHERE NO_PNW='" + nO_PNWTextBox.Text + "'";
            comm = new SqlCommand(query, conn);
            comm.ExecuteNonQuery();
            conn.Close();

            total();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            data();
            total();
        }

        private void t_penawaran_detailDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String kode = t_penawaran_detailDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            try
            {
                this.t_penawaran_detailTableAdapter.FillBy1(this.uASDataSet2.t_penawaran_detail, nO_PNWTextBox.Text, kode);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            button2.Enabled = true;
            button1.Text = "Update Barang";
        }

        private void t_penawaran_detailDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByNoPNWToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.t_penawaran_headerTableAdapter.FillByNoPNW(this.uASDataSet2.t_penawaran_header, nO_PNWToolStripTextBox.Text);
                data();
                total();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.t_penawaran_detailTableAdapter.FillBy(this.uASDataSet2.t_penawaran_detail, textBox2.Text);
                button1.Text = "Update Barang";
                button2.Enabled = true;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                data();
                total();
                button2.Enabled = false;
                button1.Text = "Tambah Barang";
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PrintPenawaran pp = new PrintPenawaran();
            pp.Show();
        }
    }
}
