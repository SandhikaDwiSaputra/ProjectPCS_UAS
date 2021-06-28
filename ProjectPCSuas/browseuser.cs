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
    public partial class browseuser : Form
    {
        public browseuser()
        {
            InitializeComponent();
        }

        private void m_usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_UASDataSet);

        }

        private void browseuser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_UASDataSet.m_users' table. You can move, or remove it, as needed.
            this.m_usersTableAdapter.Fill(this.project_UASDataSet.m_users);

        }
    }
}
