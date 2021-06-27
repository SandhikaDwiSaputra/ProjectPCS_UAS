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
    public partial class PrintPenawaran : Form
    {
        public PrintPenawaran()
        {
            InitializeComponent();
        }

        private void PrintPenawaran_Load(object sender, EventArgs e)
        {
            DataPenawaran rep = new DataPenawaran();
            rep.SetDatabaseLogon("", "", "UAS", "");
            crystalReportViewer1.ReportSource = rep;
            crystalReportViewer1.Refresh();
        }
    }
}
