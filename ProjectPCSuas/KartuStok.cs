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
    public partial class KartuStok : Form
    {
        public KartuStok()
        {
            InitializeComponent();
        }

        private void stockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stockBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uASDataSet2);

        }

        private void KartuStok_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uASDataSet2.stock_history' table. You can move, or remove it, as needed.
            this.stock_historyTableAdapter.Fill(this.uASDataSet2.stock_history);
            // TODO: This line of code loads data into the 'uASDataSet2.stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.uASDataSet2.stock);

        }
    }
}
