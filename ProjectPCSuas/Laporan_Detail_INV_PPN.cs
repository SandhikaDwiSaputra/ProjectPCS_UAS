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
    public partial class Laporan_Detail_INV_PPN : Form
    {
        public Laporan_Detail_INV_PPN()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            laporanDetail_INV_PPN lp = new laporanDetail_INV_PPN();
            crystalReportViewer1.ReportSource = lp;
        }
    }
}
