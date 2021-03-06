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
    public partial class BrowseMerk : Form
    {
        private MasterMerk merk;
        private List<MasterMerk> merkList;

        public BrowseMerk()
        {
            InitializeComponent();
        }

        private void m_merkBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_merkBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_UASDataSet);

        }

        private void BrowseMerk_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_UASDataSet.m_merk' table. You can move, or remove it, as needed.
            this.m_merkTableAdapter.Fill(this.project_UASDataSet.m_merk);
            this.Refresh();
        }

        private void GetMerkData()
        {
            int merkID = Convert.ToInt32(textBox1.Text);
                try
                {
                    merkList = ClassMerk.getByMerkID(merkID);
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

                DialogResult result = update.ShowDialog();

                if (result == DialogResult.OK)
                {
                    CurrencyManager cm = (CurrencyManager)m_merkDataGridView.BindingContext[merkList];
                }
            }
        }

        private void m_merkDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.GetMerkData();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            Master_Merk mm = new Master_Merk();
            mm.Show();
        }
    }
}
