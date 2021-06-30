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
    public partial class print_PPN : Form
    {
        public print_PPN()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            detail_header_PPN report = new detail_header_PPN();
           crystalReportViewer1.ReportSource = report;
        }
    }
}
