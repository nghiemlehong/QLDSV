using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV
{
    public partial class ReportHocPhi : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportHocPhi(String maLop, String nienKhoa, int hocKy)
        {
            InitializeComponent();
            qldsvDataSet1.EnforceConstraints = false;
            sp_DsDongHocPhi_ReportTableAdapter.Fill(qldsvDataSet1.sp_DsDongHocPhi_Report, maLop, nienKhoa, hocKy);
        }
    }
}
