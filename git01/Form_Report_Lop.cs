using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace git01
{
    public partial class Form_Report_Lop : Form
    {
        public Form_Report_Lop()
        {
            InitializeComponent();
        }

        public void ShowReport_Lop()
        {
            ReportDocument report = new ReportDocument();
            report.Load(@"C:\Users\Windows\OneDrive\Desktop\C_Sharp\BTL_01\git01\git01\Report_Lop.rpt");
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }
    }
}
