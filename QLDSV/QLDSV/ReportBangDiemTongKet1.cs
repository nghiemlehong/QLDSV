using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV
{
    public partial class ReportBangDiemTongKet1 : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportBangDiemTongKet1(String maLop)
        {
            InitializeComponent();
            qldsvDataSet1.EnforceConstraints = false;
            sp_BangDiemTongKet_ReportTableAdapter1.Fill(qldsvDataSet1.sp_BangDiemTongKet_Report, maLop);
        }

    }
}
