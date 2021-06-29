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
    public partial class MasterBarang : Form
    {
        SqlConnection conn;
        public MasterBarang()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=UAS;Integrated Security=True");
        }

        private void m_barangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_barangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uASDataSet2);

            conn.Open();

            String DataBrg = "SELECT count(*) " +
                             "FROM stock_history ";
            SqlCommand comm = new SqlCommand(DataBrg, conn);
            String kode = comm.ExecuteScalar().ToString();

            String DataBrg2 = "SELECT ID " +
                             "FROM m_barang " +
                             "where kode='" + kODETextBox.Text + "'";
            SqlCommand comm2 = new SqlCommand(DataBrg2, conn);
            String kode2 = comm2.ExecuteScalar().ToString();

            if (Convert.ToInt32(kode) < 1)
            {
                String query = "Insert into stock_history(ID_STOCK_HISTORY, ID_BARANG, STOCK_HISTORY_VALUE, STOCK_HISTORY_DATE) values(1, " + Convert.ToInt32(kode2) + ", " + Convert.ToInt32(uNITTextBox.Text) + ", GETDATE())";
                comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();
            }
            else
            {
                String id = "SELECT MAX(ID_STOCK_HISTORY) " +
                             "FROM stock_history ";
                SqlCommand comm3 = new SqlCommand(id, conn);
                String kode3 = comm3.ExecuteScalar().ToString();

                String query = "Insert into stock_history(ID_STOCK_HISTORY, ID_BARANG, STOCK_HISTORY_VALUE, STOCK_HISTORY_DATE) values("+(Convert.ToInt32(kode3)+1)+", " + Convert.ToInt32(kode2) + ", " + Convert.ToInt32(uNITTextBox.Text) + ", GETDATE())";
                comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();
            }
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_UASDataSet1.m_merk' table. You can move, or remove it, as needed.
            this.m_merkTableAdapter.Fill(this.project_UASDataSet1.m_merk);
            // TODO: This line of code loads data into the 'project_UASDataSet.m_barang' table. You can move, or remove it, as needed.
            this.m_barangTableAdapter1.Fill(this.project_UASDataSet.m_barang);
            // TODO: This line of code loads data into the 'uASDataSet2.m_barang' table. You can move, or remove it, as needed.
            this.m_barangTableAdapter.Fill(this.uASDataSet2.m_barang);

        }

        private void kODELabel_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            

        }

        private void BrowseBTN_Click(object sender, EventArgs e)
        {
            BrowseBarang BB = new BrowseBarang();
            BB.Show();
        }
    }
}
