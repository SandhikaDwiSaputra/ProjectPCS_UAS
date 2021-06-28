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
    public partial class Master_GroupUser : Form
    {
        SqlConnection conn;
        string sebelum = "";

        private bool cekGroupUser(String nm_Group)
        {
            int group = 0;
            conn.Open();
            String query = $"SELECT ISNULL(COUNT(*), 0) as Jumlah " +
                           $"FROM m_groupuser " +
                           $"WHERE NAMAGROUPUSER = '{nm_Group}'";
            SqlCommand command = new SqlCommand(query, conn);
            group = Convert.ToInt32(command.ExecuteScalar().ToString());
            conn.Close();

            if (group == 0)
            {
                return false;
            }
            MessageBox.Show("Nama Gruop User sudah ada di database");
            return true;
        }

        private bool cekInput()
        {
            if (tbNamaGroup.Text.Length == 0)
            {
                MessageBox.Show("Isi Semua Field Yang Ada!");
                return false;
            }
            return true;
        }

        private String getSebelum(String i)
        {
            return i;
        }

        private void refreshData()
        {
            dgvGroup.Columns.Clear();
            tbNamaGroup.Text = "";
            sebelum = "";

            conn.Open();
            DataSet ds = new DataSet();
            String query = $"SELECT * " +
                           $"FROM m_groupuser " ;
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            dgvGroup.DataSource = ds.Tables[0];
            dgvGroup.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            conn.Close();
        }

        public Master_GroupUser()
        {
            InitializeComponent();
            try
            {
                conn = dbUAS.GetConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
                throw;
            }
        }

        private void Master_GroupUser_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (cekInput())
            {
                if (!cekGroupUser(tbNamaGroup.Text))
                {
                    conn.Open();
                    String query = $"INSERT INTO m_groupuser VALUES('{tbNamaGroup.Text}')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Berhasil Menambah Group User");
                    refreshData();
                }
            }
        }

        private void dgvGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNamaGroup.Text = dgvGroup.Rows[e.RowIndex].Cells[0].Value.ToString();
            sebelum = getSebelum(dgvGroup.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!cekGroupUser(tbNamaGroup.Text))
            {
                conn.Open();
                String query = $"UPDATE m_groupuser SET NAMAGROUPUSER = '{tbNamaGroup.Text}' WHERE NAMAGROUPUSER = '{sebelum}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Berhasil Mengubah Group User");
                refreshData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this group user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                String query = $"DELETE FROM m_groupuser WHERE NAMAGROUPUSER = '{tbNamaGroup.Text}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Berhasil Menghapus Group User");
                refreshData();
            }
        }
    }
}
