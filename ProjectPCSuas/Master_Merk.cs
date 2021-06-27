using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryMasterMerk;

namespace ProjectPCSuas
{
    public partial class Master_Merk : Form
    {
        private MasterMerk merk;
        private List<MasterMerk> merkList;
        public Master_Merk()
        {
            InitializeComponent();
        }
        private void GetMerkData()
        {
            string merkDESC = TBcari.Text;
            try
            {
                merkList = ClassMerk.getByMerkDesc(merkDESC);
                if (merkList.Count > 0)
                {
                    MasterMerk masterMerk;
                    for (int i = 0; i < merkList.Count; i++)
                    {
                        masterMerk = merkList[i];
                    }
                    m_merkDataGridView.DataSource = merkList;
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        private void MasterMerk_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_UASDataSet.m_merk' table. You can move, or remove it, as needed.
            this.m_merkTableAdapter.Fill(this.project_UASDataSet.m_merk);
            mERK_DESCTextBox.Clear(); 
            listView1.Items.Clear();
            List<MasterMerk> merkList;
            try
            {
                merkList = ClassMerk.get();
                if (merkList.Count > 0)
                {
                    MasterMerk masterMerk;
                    for (int i = 0; i < merkList.Count; i++)
                    {
                        masterMerk = merkList[i];
                        listView1.Items.Add(masterMerk.Id.ToString());
                        listView1.Items[i].SubItems.Add(masterMerk.Merk_desc);
                    }
                }
                else
                {
                    //MessageBox.Show("All invoices are paid in full.",
                    //    "No Balance Due");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.GetMerkData();
        }

        private void m_merkBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_merkBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_UASDataSet);

        }

        private void BrowseBTN_Click(object sender, EventArgs e)
        {
            BrowseMerk BM = new BrowseMerk();
            BM.Show();
        }

        private void m_merkDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                int i = e.RowIndex;
                DataGridViewRow row = m_merkDataGridView.Rows[i];
                DataGridViewCell cell = row.Cells[0];
                int ID = (int)cell.Value;
                DialogResult result = MessageBox.Show("Apakah anda yakin ingin delete?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (!(ClassMerk.deleteMerk(ID)))
                        {
                            MessageBox.Show("Another user has updated or deleted " +
                                "that vendor.", "Database Error");
                        }
                        else
                        {
                            this.m_merkTableAdapter.Fill(this.project_UASDataSet.m_merk);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }

            if (e.ColumnIndex == 3)
            {
                
                int i = e.RowIndex;
                DataGridViewRow row = m_merkDataGridView.Rows[i];
                DataGridViewCell cell = row.Cells[0];
                int ID = (int)cell.Value;
                DataGridViewRow row2 = m_merkDataGridView.Rows[i];
                DataGridViewCell cell2 = row.Cells[1];
                string des = cell2.Value.ToString();

                UpdateMasterMerk update = new UpdateMasterMerk();
                update.id2 = ID;
                update.desc = des;

                this.Dispose();

                DialogResult result = update.ShowDialog();

                

                if (result == DialogResult.OK)
                {
                    CurrencyManager cm = (CurrencyManager)m_merkDataGridView.BindingContext[merkList];
                }
            }
        }

        private void m_merkBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            List<MasterMerk> merkList;
            String desc = mERK_DESCTextBox.Text;
            try
            {
                merkList = ClassMerk.Tambah(desc);
                MessageBox.Show("Berhasil Menambah");
                merkList = ClassMerk.get();
                if (merkList.Count > 0)
                {
                    MasterMerk masterMerk;
                    for (int i = 0; i < merkList.Count; i++)
                    {
                        masterMerk = merkList[i];
                    }
                    m_merkDataGridView.DataSource = merkList;
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                merkList = ClassMerk.get();
                if (merkList.Count > 0)
                {
                    MasterMerk masterMerk;
                    for (int i = 0; i < merkList.Count; i++)
                    {
                        masterMerk = merkList[i];
                    }
                    m_merkDataGridView.DataSource = merkList;
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void mERK_DESCTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            BrowseMerk bm = new BrowseMerk();
            bm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PrintMasterMerk bm = new PrintMasterMerk();
            bm.Show();
        }
    }
}
