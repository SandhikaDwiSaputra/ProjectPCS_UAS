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
    public partial class Print_data_kota : Form
    {
        public Print_data_kota()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            Printdatakota pd = new Printdatakota();
            crystalReportViewer1.ReportSource = pd;
        }
    }
}
