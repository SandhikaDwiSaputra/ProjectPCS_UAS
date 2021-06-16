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
    public partial class MasterModel : Form
    {
        public MasterModel()
        {
            InitializeComponent();
        }

        private void m_modelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_modelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uASDataSet2);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uASDataSet2.m_model' table. You can move, or remove it, as needed.
            this.m_modelTableAdapter.Fill(this.uASDataSet2.m_model);

        }
    }
}
