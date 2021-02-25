using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mfy_Logistic_System
{
    public partial class PreviewInvoice : Form
    {
        public PreviewInvoice()
        {
            InitializeComponent();
        }

        private void PreviewInvoice_Load(object sender, EventArgs e)
        {
            CRInvoice crInvoince = new CRInvoice();
            crystalReportViewer1.ReportSource = crInvoince;
        }
    }
}
