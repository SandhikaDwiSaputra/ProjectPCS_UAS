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
    public partial class PrintSupp : Form
    {
        public PrintSupp()
        {
            InitializeComponent();
        }

        private void PrintSupp_Load(object sender, EventArgs e)
        {
            DataSupplier rep = new DataSupplier();
            rep.SetDatabaseLogon("", "", "UAS", "");
            crystalReportViewer1.ReportSource = rep;
            crystalReportViewer1.Refresh();
        }
    }
}
