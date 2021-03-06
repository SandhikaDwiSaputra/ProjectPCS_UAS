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

        private void button6_Click(object sender, EventArgs e)
        {
            Pembelian MM = new Pembelian();
            MM.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PenawaranHeader ph = new PenawaranHeader();
            ph.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new Master_HakAkses().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new Master_GroupUser().Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new Invoice().Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new Masterkota().Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            new Masteruser().Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            new Detail_Header_INV_PPN().Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            KartuStok ks = new KartuStok();
            ks.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Rework r = new Rework();
            r.Show();
        }
    }
}
