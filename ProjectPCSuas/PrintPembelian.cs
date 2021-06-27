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
    public partial class PrintPembelian : Form
    {
        public PrintPembelian()
        {
            InitializeComponent();
        }

        

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {
            ReportPembelian report = new ReportPembelian();
            crystalReportViewer2.ReportSource = report;
        }
    }
}
