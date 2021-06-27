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
    public partial class PrintMasterMerk : Form
    {
        public PrintMasterMerk()
        {
            InitializeComponent();
        }

        private void crystalReportViewerMerk_Load(object sender, EventArgs e)
        {
            ReportMerk report = new ReportMerk();
            crystalReportViewerMerk.ReportSource = report;
        }
    }
}
