using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV
{
    public partial class ReportPhieuDiem : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportPhieuDiem(String maSV)
        {
            InitializeComponent();
            qldsvDataSet1.EnforceConstraints = false;
            sp_GetMaxValueDiem_ReportTableAdapter.Fill(qldsvDataSet1.sp_GetMaxValueDiem_Report, maSV);
        }

    }
}
