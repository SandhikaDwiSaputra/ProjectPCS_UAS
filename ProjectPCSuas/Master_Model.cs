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
    public partial class Master_Model : Form
    {
        private MasterModel model;
        private List<MasterModel> modelList;

        public Master_Model()
        {
            InitializeComponent();
        }

        private void GetModelData()
        {
            string modelDESC = TBcari.Text;
            listView1.Items.Clear();
            try
            {
                modelList = ClassModel.getByModelDesc(modelDESC);
                if (modelList.Count > 0)
                {
                    MasterModel masterModel;
                    for (int i = 0; i < modelList.Count; i++)
                    {
                        masterModel = modelList[i];
                        listView1.Items.Add(masterModel.Id.ToString());
                        listView1.Items[i].SubItems.Add(masterModel.Model_desc);
                    }
                }
                else
                {
                    listView1.Items.Clear();
                    MessageBox.Show("Data tidak ditemukan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void BrowseBTN_Click(object sender, EventArgs e)
        {
            BrowseModel BB = new BrowseModel();
            BB.Show();
        }

        private void m_modelBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.m_modelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uASDataSet2);

        }

        private void Master_Model_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uASDataSet2.m_model' table. You can move, or remove it, as needed.
            this.m_modelTableAdapter.Fill(this.uASDataSet2.m_model);
            dESCRIPTIONTextBox.Clear();
            listView1.Items.Clear();
            List<MasterModel> modelList;
            try
            {
                modelList = ClassModel.get();
                if (modelList.Count > 0)
                {
                    MasterModel masterModel;
                    for (int i = 0; i < modelList.Count; i++)
                    {
                        masterModel = modelList[i];
                        listView1.Items.Add(masterModel.Id.ToString());
                        listView1.Items[i].SubItems.Add(masterModel.Model_desc);
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

        private void btnCari_Click(object sender, EventArgs e)
        {
            this.GetModelData();
        }
    }
}
