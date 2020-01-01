using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV
{
    public partial class ReportThiHetMon : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportThiHetMon(String maLop, int lan, String maMon)
        {
            InitializeComponent();
            qldsvDataSet1.EnforceConstraints = false;
            sp_GetInfoSV_Report_DSTHMTableAdapter.Fill(qldsvDataSet1.sp_GetInfoSV_Report_DSTHM, maLop,  lan, maMon);
        }

    }
}
