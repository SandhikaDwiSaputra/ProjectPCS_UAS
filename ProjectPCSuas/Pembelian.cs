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
    public partial class Pembelian : Form
    {
        SqlConnection conn;
        public Pembelian()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=UAS;Integrated Security=True");
        }
        public void data()
        {
            conn.Open();

            DataSet ds = new DataSet();
            String query = $"SELECT mb.kode as KODE,mb.part_no AS 'PART NO',mb.description AS DESCRIPTION,mb.unit AS UNIT ,mb.merk1 AS MERK,td.qty AS QUANTITY ,FORMAT(mb.unit_price,'C') AS PRICE,FORMAT((td.qty*mb.unit_price),'C') as Amount " +
                           $"FROM m_barang mb,t_pembelian_detail td,t_pembelian_header th " +
                           $"where th.no_pnw = td.no_pnw " +
                           $"and mb.kode = td.kode " +
                           $"and th.no_nota = td.no_nota " +
                             $"and th.no_nota = '{nO_NOTATextBox.Text}' ";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            //SUM
            String SUM1 = $"SELECT Sum(td.qty*mb.unit_price) " +
                        $"FROM m_barang mb,t_pembelian_detail td,t_pembelian_header th " +
                        $"WHERE mb.kode = td.kode " +
                         $"and th.no_nota = td.no_nota " +
                        $"and th.p_id = '{p_IDComboBox.Text}' " +
                         $"and '{nO_NOTATextBox.Text}' = td.no_nota ";
            SqlCommand commSum1 = new SqlCommand(SUM1, conn);
            String totalHarga = commSum1.ExecuteScalar().ToString();

            //SUM
            String SUM = $"SELECT FORMAT(Sum(td.qty*mb.unit_price),'C') " +
                        $"FROM m_barang mb,t_pembelian_detail td,t_pembelian_header th " +
                        $"WHERE mb.kode = td.kode " +
                         $"and th.no_nota = td.no_nota " +
                        $"and th.p_id = '{p_IDComboBox.Text}' " +
                         $"and '{nO_NOTATextBox.Text}' = td.no_nota ";
            SqlCommand commSum = new SqlCommand(SUM, conn);
            Totalsemua.Text = commSum.ExecuteScalar().ToString();
            conn.Close();
            Discount.Text = "0";
            PPN.Text = "0";
            Gtotal.Text = "0";
            int discount = Convert.ToInt32(Discount.Text);
            int ppn = Convert.ToInt32(PPN.Text);
            if (totalHarga.Equals(""))
            {
                Totalsemua.Text = "0";
            }
            else
            {
                int total = Convert.ToInt32(totalHarga);

                Gtotal.Text = "$" + (total - discount + ppn).ToString() + ",00";
            }
            conn.Close();


        }
        private void t_pembelian_headerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_pembelian_headerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_UASDataSet);

        }

        private void Pembelian_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_UASDataSet.m_barang' table. You can move, or remove it, as needed.
            this.m_barangTableAdapter.Fill(this.project_UASDataSet.m_barang);
            // TODO: This line of code loads data into the 'project_UASDataSet.m_supplier' table. You can move, or remove it, as needed.
            this.m_supplierTableAdapter.Fill(this.project_UASDataSet.m_supplier);
            // TODO: This line of code loads data into the 'project_UASDataSet.t_pembelian_header' table. You can move, or remove it, as needed.
            this.t_pembelian_headerTableAdapter.Fill(this.project_UASDataSet.t_pembelian_header);
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

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            data();
        }

        private void TambahItem_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            String DataBrg = $"SELECT kode " +
                         $"FROM m_barang " +
                         $"WHERE id = '{NamaBarang.SelectedValue}'";
            SqlCommand comm = new SqlCommand(DataBrg, conn);
            String DataBrg2 = $"SELECT part_no " +
                         $"FROM m_barang " +
                         $"WHERE id = '{NamaBarang.SelectedValue}'";
            SqlCommand comm2 = new SqlCommand(DataBrg2, conn);
            String DataBrg3 = $"SELECT description " +
                         $"FROM m_barang " +
                         $"WHERE id = '{NamaBarang.SelectedValue}'";
            SqlCommand comm3 = new SqlCommand(DataBrg3, conn);
            String DataBrg4 = $"SELECT unit " +
                         $"FROM m_barang " +
                         $"WHERE id = '{NamaBarang.SelectedValue}'";
            SqlCommand comm4 = new SqlCommand(DataBrg4, conn);
            String DataBrgUnitP = $"SELECT unit_price " +
                         $"FROM m_barang " +
                         $"WHERE id = '{NamaBarang.SelectedValue}'";
            SqlCommand communitp = new SqlCommand(DataBrgUnitP, conn);
            String DataBrg5 = $"SELECT merk1 " +
                         $"FROM m_barang " +
                         $"WHERE id = '{NamaBarang.SelectedValue}'";
            SqlCommand comm5 = new SqlCommand(DataBrg5, conn);



            String merk = comm5.ExecuteScalar().ToString();
            String kode = comm.ExecuteScalar().ToString();
            String part_no = comm2.ExecuteScalar().ToString();
            String description = comm3.ExecuteScalar().ToString();
            String unit = comm4.ExecuteScalar().ToString();
            String unitP = communitp.ExecuteScalar().ToString();


            String DataBrg6 = $"SELECT COUNT(*) FROM t_pembelian_detail WHERE kode = '{kode}' and no_pnw = '{nO_PNWTextBox.Text}'";
            SqlCommand comm6 = new SqlCommand(DataBrg6, conn);
            String cekBarang = comm6.ExecuteScalar().ToString();

            String cek = textboxQTY.Text;
            int num = -1;
            if (!int.TryParse(cek, out num))
            {
                MessageBox.Show("Input Harus Angka");
            }
            else if (Convert.ToInt32(cekBarang) > 0)
            {
                String jmlhBarang = $"SELECT unit FROM m_barang WHERE kode = '{kode}' ";
                SqlCommand commjmlhBR = new SqlCommand(jmlhBarang, conn);

                String JumlahAwal = commjmlhBR.ExecuteScalar().ToString();
                int TambahJumlah = Convert.ToInt32(JumlahAwal) + Convert.ToInt32(cek);
                String querytambahunit = $"UPDATE m_barang SET unit = {TambahJumlah} where kode = '{kode}'";
                comm = new SqlCommand(querytambahunit, conn);
                comm.ExecuteNonQuery();

                String DataBrg7 = $"SELECT qty FROM t_pembelian_detail WHERE kode = '{kode}' and no_pnw = '{nO_PNWTextBox.Text}'";
                SqlCommand comm7 = new SqlCommand(DataBrg7, conn);
                
                String qtyAwal = comm7.ExecuteScalar().ToString();
                int tambahQTY = Convert.ToInt32(textboxQTY.Text) + Convert.ToInt32(qtyAwal);
                
                String query = $"UPDATE t_pembelian_detail SET qty = {tambahQTY} where kode = '{kode}' and no_pnw = '{nO_PNWTextBox.Text}'";
                
                comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();
                this.Validate();
                this.t_pembelian_headerBindingSource.EndEdit();

                this.tableAdapterManager.UpdateAll(this.project_UASDataSet);
            }
            else
            {
                String jmlhBarang = $"SELECT unit FROM m_barang WHERE kode = '{kode}' ";
                SqlCommand commjmlhBR = new SqlCommand(jmlhBarang, conn);

                String JumlahAwal = commjmlhBR.ExecuteScalar().ToString();
                int TambahJumlah = Convert.ToInt32(JumlahAwal) + Convert.ToInt32(cek);
                String querytambahunit = $"UPDATE m_barang SET unit = {TambahJumlah} where kode = '{kode}'";
                comm = new SqlCommand(querytambahunit, conn);
                comm.ExecuteNonQuery();

                String query = $"Insert into t_pembelian_detail(no_pnw,no_nota,kode,part_no,descriptio,unit,merk,qty,unit_price) values('{nO_PNWTextBox.Text}','{nO_NOTATextBox.Text}','{kode}','{part_no}','{description}','{unit}','{merk}','{Convert.ToInt32(textboxQTY.Text)}',{unitP})";
                comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();
                this.Validate();
                this.t_pembelian_headerBindingSource.EndEdit();

                this.tableAdapterManager.UpdateAll(this.project_UASDataSet);
            }

            conn.Close();
            data();
        }

        private void HapusItem_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Warning!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {

                conn.Open();


                String DataBrg = $"SELECT kode " +
                             $"FROM m_barang " +
                             $"WHERE id = '{NamaBarang.SelectedValue}'";
                SqlCommand comm = new SqlCommand(DataBrg, conn);
                String DataBrg2 = $"SELECT part_no " +
                             $"FROM m_barang " +
                             $"WHERE id = '{NamaBarang.SelectedValue}'";
                SqlCommand comm2 = new SqlCommand(DataBrg2, conn);
                String DataBrg3 = $"SELECT description " +
                             $"FROM m_barang " +
                             $"WHERE id = '{NamaBarang.SelectedValue}'";
                SqlCommand comm3 = new SqlCommand(DataBrg3, conn);
                String DataBrg4 = $"SELECT unit " +
                             $"FROM m_barang " +
                             $"WHERE id = '{NamaBarang.SelectedValue}'";
                SqlCommand comm4 = new SqlCommand(DataBrg4, conn);
                String DataBrg5 = $"SELECT merk1 " +
                             $"FROM m_barang " +
                             $"WHERE id = '{NamaBarang.SelectedValue}'";
                SqlCommand comm5 = new SqlCommand(DataBrg5, conn);
                String merk = comm5.ExecuteScalar().ToString();
                String kode = comm.ExecuteScalar().ToString();
                String part_no = comm2.ExecuteScalar().ToString();
                String description = comm3.ExecuteScalar().ToString();
                String unit = comm3.ExecuteScalar().ToString();


                String jmlhBarang = $"SELECT unit FROM m_barang WHERE kode = '{kode}' ";
                SqlCommand commjmlhBR = new SqlCommand(jmlhBarang, conn);

                String JumlahAwal = commjmlhBR.ExecuteScalar().ToString();

                String jmlhBarangawal2 = $"SELECT qty FROM t_pembelian_detail WHERE kode = '{kode}' ";
                SqlCommand commjmlhBR2 = new SqlCommand(jmlhBarangawal2, conn);

                int JumlahAwal2 = Convert.ToInt32(commjmlhBR2.ExecuteScalar().ToString());
                int TambahJumlah = Convert.ToInt32(JumlahAwal) - JumlahAwal2;
                String querytambahunit = $"UPDATE m_barang SET unit = {TambahJumlah} where kode = '{kode}'";
                comm = new SqlCommand(querytambahunit, conn);
                comm.ExecuteNonQuery();


                String cek = textboxQTY.Text;
                String query = $"DELETE FROM t_pembelian_detail WHERE KODE = '{KodeBr.Text}' AND NO_NOTA = '{nO_NOTATextBox.Text}'";
                comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();


                

                conn.Close();
                data();
                HapusItem.Enabled = false;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            HapusItem.Enabled = true;
            int rowIndex = e.RowIndex;
            KodeBr.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintPembelian PP = new PrintPembelian();
            PP.Show();
        }

        private void t_pembelian_headerBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            conn.Open();
            String query = $"delete from t_pembelian_detail where no_pnw = '{nO_PNWTextBox.Text}'";
            SqlCommand comm = new SqlCommand(query, conn);
            comm.ExecuteNonQuery();
            MessageBox.Show("Berhasil Menghapus");
            conn.Close();


            this.Validate();
            this.t_pembelian_headerBindingSource.EndEdit();

            this.tableAdapterManager.UpdateAll(this.project_UASDataSet);
        }
    }
}
