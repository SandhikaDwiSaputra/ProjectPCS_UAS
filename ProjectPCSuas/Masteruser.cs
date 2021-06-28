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
    public partial class Masteruser : Form
    {
        public Masteruser()
        {
            InitializeComponent();
        }

        private void m_usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_UASDataSet);

        }

        private void Masteruser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_UASDataSet.m_users' table. You can move, or remove it, as needed.
            this.m_usersTableAdapter.Fill(this.project_UASDataSet.m_users);

        }

        private void pASSWORDLabel_Click(object sender, EventArgs e)
        {

        }

        private void pASSWORDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            browseuser bu = new browseuser();
            bu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Print_data_user pdu = new Print_data_user();
                pdu.Show();
        }
    }
}
