using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV
{
    public partial class ReportDSSV : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDSSV(String maLop)
        {
            InitializeComponent();
            qldsvDataSet1.EnforceConstraints = false;
            sp_GetInfoSV_ReportTableAdapter.Fill(qldsvDataSet1.sp_GetInfoSV_Report, maLop);
        }
    }
}
