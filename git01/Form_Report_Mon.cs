using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace git01
{
    public partial class Form_Report_Mon : Form
    {
        public Form_Report_Mon()
        {
            InitializeComponent();
        }
        public void ShowReport_Mon()
        {
            /*
                ReportDocument report = new ReportDocument();
                report.Load(@"C:\Users\Windows\OneDrive\Desktop\C_Sharp\BTL_01\git01\git01\Report_Mon.rpt");
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Refresh();*/


            CrystalDecisions.CrystalReports.Engine.ReportDocument
                rpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            rpt.Load(@"C:\Users\Windows\OneDrive\Desktop\C_Sharp\BTL_01\git01\git01\Report_Mon.rpt");

            CrystalDecisions.Shared.TableLogOnInfo
                 tableLogOnInfo = new CrystalDecisions.Shared.TableLogOnInfo();
            tableLogOnInfo.ConnectionInfo.ServerName = ".\\SQLEXPRESS";
            tableLogOnInfo.ConnectionInfo.DatabaseName = "BTL01";
            tableLogOnInfo.ConnectionInfo.UserID = "sa";
            tableLogOnInfo.ConnectionInfo.Password = "123";

            foreach (CrystalDecisions.CrystalReports.Engine.Table tb in rpt.Database.Tables)
            {
                tb.ApplyLogOnInfo(tableLogOnInfo);
            }

            rpt.RecordSelectionFormula = FormMon.dieukienReport;
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }

    }
}
