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
    public partial class Master_Merk : Form
    {
        public Master_Merk()
        {
            InitializeComponent();
        }

        private void m_merkBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_merkBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uASDataSet2);

        }

        private void Master_Merk_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uASDataSet2.m_merk' table. You can move, or remove it, as needed.
            this.m_merkTableAdapter.Fill(this.uASDataSet2.m_merk);

        }
        
        private void mERK_DESCTextBox_TextChanged(object sender, EventArgs e)
        {
            mERK_DESCTextBox.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
