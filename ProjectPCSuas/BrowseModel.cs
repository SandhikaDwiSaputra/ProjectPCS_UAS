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
    public partial class BrowseModel : Form
    {
        public BrowseModel()
        {
            InitializeComponent();
        }
        private MasterModel model;
        private List<LibraryMasterMerk.MasterModel> modelList;

        private void m_modelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_modelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_UASDataSet);

        }

        private void BrowseModel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_UASDataSet.m_model' table. You can move, or remove it, as needed.
            this.m_modelTableAdapter.Fill(this.project_UASDataSet.m_model);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                modelList = ClassModel.get();
                if (modelList.Count > 0)
                {
                    LibraryMasterMerk.MasterModel masterModel;
                    for (int i = 0; i < modelList.Count; i++)
                    {
                        masterModel = modelList[i];
                    }
                    m_modelDataGridView.DataSource = modelList;
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
    }
}
