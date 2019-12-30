using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV
{
    public partial class ReportDiemMH : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDiemMH(String maLop, string maMon, int lan)
        {
            InitializeComponent();
            qldsvDataSet1.EnforceConstraints = false;
            sp_GetValueDiem_ReportTableAdapter1.Fill(qldsvDataSet1.sp_GetValueDiem_Report, maLop, maMon, lan);
        }

    }
}
