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
    public partial class Master_HakAkses : Form
    {
        SqlConnection conn;
        string sebelum = "";
        string grupSebelum = "";

        private bool cekMenuUser(String nm_Group, String nm_Menu)
        {
            int menu = 0;
            conn.Open();
            String query = $"SELECT ISNULL(COUNT(*), 0) as Jumlah " +
                           $"FROM m_hakaksesgroupuser " +
                           $"WHERE NAMAGROUPUSER = '{nm_Group}' AND NAMAMENU = '{nm_Menu}'";
            SqlCommand command = new SqlCommand(query, conn);
            menu = Convert.ToInt32(command.ExecuteScalar().ToString());
            conn.Close();

            if (menu == 0)
            {
                return false;
            }
            MessageBox.Show("Menu sudah terdaftar di database");
            return true;
        }

        private bool cekInput()
        {
            if (txtMenu.Text.Length == 0)
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

        private String getGroupSebelum(String i)
        {
            return i;
        }

        private void refreshData()
        {
            dgvHakAkses.Columns.Clear();
            cbGroupUser.SelectedValue = 1;
            txtMenu.Text = "";
            grupSebelum = "";
            sebelum = "";

            conn.Open();
            DataSet ds = new DataSet();
            String query = $"SELECT * " +
                           $"FROM m_hakaksesgroupuser ";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            dgvHakAkses.DataSource = ds.Tables[0];
            dgvHakAkses.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataTable nama = new DataTable();
            String data = "SELECT * FROM m_groupuser";
            SqlCommand comm = new SqlCommand(data, conn);
            SqlDataAdapter adapt = new SqlDataAdapter(comm);
            adapt.Fill(nama);
            cbGroupUser.DataSource = nama;
            cbGroupUser.DisplayMember = "NAMAGROUPUSER";
            cbGroupUser.ValueMember = "NAMAGROUPUSER";
            conn.Close();
        }

        public Master_HakAkses()
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

        private void Master_HakAkses_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cekInput())
            {
                if (!cekMenuUser(cbGroupUser.SelectedValue.ToString(), txtMenu.Text))
                {
                    conn.Open();
                    String query = $"INSERT INTO m_hakaksesgroupuser VALUES('{cbGroupUser.SelectedValue.ToString().Trim()}', '{txtMenu.Text}')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Berhasil Menambah Hak Akses Group User");
                    refreshData();
                }
            }
        }

        private void dgvHakAkses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbGroupUser.SelectedValue = dgvHakAkses.Rows[e.RowIndex].Cells[0].Value;
            txtMenu.Text = dgvHakAkses.Rows[e.RowIndex].Cells[1].Value.ToString();
            sebelum = getSebelum(dgvHakAkses.Rows[e.RowIndex].Cells[1].Value.ToString());
            grupSebelum = getGroupSebelum(dgvHakAkses.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!cekMenuUser(cbGroupUser.SelectedValue.ToString(), txtMenu.Text))
            {
                conn.Open();
                String query = $"UPDATE m_hakaksesgroupuser SET NAMAGROUPUSER = '{cbGroupUser.SelectedValue.ToString().Trim()}', NAMAMENU = '{txtMenu.Text}' WHERE NAMAGROUPUSER = '{grupSebelum}' AND NAMAMENU = '{sebelum}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Berhasil Menambah Hak Akses Group User");
                refreshData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete Access for this group user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                String query = $"DELETE FROM m_groupuser WHERE NAMAGROUPUSER = '{cbGroupUser.SelectedValue.ToString()}' AND NAMAMENU = '{txtMenu.Text}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Berhasil Menghapus Hak Akses Group User");
                refreshData();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshData();
        }
    }
}
