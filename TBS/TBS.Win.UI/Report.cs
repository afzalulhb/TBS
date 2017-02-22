using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBS.Domain.DB.DBContext;

namespace TBS.Win.UI
{
    public partial class Report : Form
    {
        public TBSContext context;
        public Report()
        {
            InitializeComponent();
            context = new TBSContext();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TBS.Win.UI.Reports.Report1.rdlc";

            var data1 = context.TmpMonthlyBills.ToList();
            var data = data1;
            
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", data));

            this.reportViewer1.RefreshReport();
        }
    }
}
