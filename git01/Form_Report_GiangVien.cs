using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
namespace git01
{
    public partial class Form_Report_GiangVien : Form
    {
        public Form_Report_GiangVien()
        {
            InitializeComponent();
        }
        public void ShowReport_GiangVien()
        {

            ReportDocument report = new ReportDocument();
            report.Load(@"C:\Users\Windows\OneDrive\Desktop\C_Sharp\BTL_01\git01\git01\Report_Giangvien.rpt");
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }
    }
}
