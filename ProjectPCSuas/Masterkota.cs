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
    public partial class Masterkota : Form
    {
        public Masterkota()
        {
            InitializeComponent();
        }

        private void m_kotaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_kotaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_UASDataSet);

        }

        private void Masterkota_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_UASDataSet.m_kota' table. You can move, or remove it, as needed.
            this.m_kotaTableAdapter.Fill(this.project_UASDataSet.m_kota);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            browsekota bk = new browsekota();
            bk.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Print_data_kota pdk = new Print_data_kota();
            pdk.Show();
        }
    }
}
