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
    public partial class BrowsePelanggan : Form
    {
        SqlConnection conn;
        public BrowsePelanggan()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=UAS;Integrated Security=True");
        }

        private void m_pelangganBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_pelangganBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_UASDataSet);

        }

        private void BrowsePelanggan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_UASDataSet.m_pelanggan' table. You can move, or remove it, as needed.
            this.m_pelangganTableAdapter.Fill(this.project_UASDataSet.m_pelanggan);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            DataSet ds = new DataSet();
            String query = $"SELECT *" +
                          $"FROM m_pelanggan " +
                          $"WHERE p_code like '%{textBox1.Text}%'" +
                          $"or nama like '%{textBox1.Text}%'" +
                           $"or kota like '%{textBox1.Text}%'" +
                          $"or alamat like '%{textBox1.Text}%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            m_pelangganDataGridView.DataSource = ds.Tables[0];
            m_pelangganDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            conn.Close();
        }

        private void m_pelangganDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
