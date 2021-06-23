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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MasterBarang MB = new MasterBarang();
            MB.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Master_Merk MM = new Master_Merk();
            MM.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Master_Model MM = new Master_Model();
            MM.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MasterPelanggan MP = new MasterPelanggan();
            MP.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MasterSuplier MS = new MasterSuplier();
            MS.Show();
        }

        private void m_merkBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }
    }
}
