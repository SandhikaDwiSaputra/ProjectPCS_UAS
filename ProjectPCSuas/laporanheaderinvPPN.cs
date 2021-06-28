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
    public partial class laporanheaderinvPPN : Form
    {
        public laporanheaderinvPPN()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
           laporan_header_INV_PPN pl = new laporan_header_INV_PPN();
            crystalReportViewer1.ReportSource = pl;
        }
    }
}
