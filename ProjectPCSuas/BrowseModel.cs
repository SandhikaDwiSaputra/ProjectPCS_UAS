using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPCSuas
{
    public partial class BrowseModel : Form
    {
        public BrowseModel()
        {
            InitializeComponent();
        }

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
    }
}
