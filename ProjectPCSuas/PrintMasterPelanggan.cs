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
    public partial class PrintMasterPelanggan : Form
    {
        public PrintMasterPelanggan()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportMasterPelanggan CetakPelanggan = new ReportMasterPelanggan();
            crystalReportViewer1.ReportSource = CetakPelanggan;

        }
    }
}
