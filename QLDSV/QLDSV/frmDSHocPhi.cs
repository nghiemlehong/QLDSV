using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace QLDSV
{
    public partial class frmDSHocPhi : DevExpress.XtraEditors.XtraForm
    {
        public frmDSHocPhi()
        {
            InitializeComponent();
        }

        private void frmDSHocPhi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet.v_SISO' table. You can move, or remove it, as needed.
            this.v_SISOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_SISOTableAdapter.Fill(this.qLDSVDataSet.v_SISO);
           
            IDictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "1");
            dict.Add(2, "2");
            dict.Add(3, "3");
            cmbHocKy.DataSource = new BindingSource(dict, null);
            cmbHocKy.DisplayMember = "Value";
            cmbHocKy.ValueMember = "Key";



            int year = DateTime.Now.Year;

            IDictionary<int, string> dict1 = new Dictionary<int, string>();
            for (int i = 4; i >= 0; i--)
            {
                dict1.Add(i, year - i + " - " + (year - i + 1));
            }

            cmbNienKhoa.DataSource = new BindingSource(dict1, null);
            cmbNienKhoa.DisplayMember = "Value";
            cmbNienKhoa.ValueMember = "Value";
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            ReportHocPhi reportHP = new ReportHocPhi(cmbLop.SelectedValue.ToString(), cmbNienKhoa.SelectedValue.ToString(), cmbHocKy.SelectedIndex + 1);
            reportHP.xrLabelLop.Text = "Mã lớp: " + cmbLop.SelectedValue.ToString();
            reportHP.xrLabelNienKhoa.Text = "Niên khoa: " + cmbNienKhoa.SelectedValue.ToString();
            reportHP.xrLabelHocki.Text = "Học kì: " + cmbHocKy.SelectedValue.ToString();
            reportHP.xrLabelInfoNgTao.Text = "Mã giảng viên : " + Program.username + " ||   Họ và tên : " + Program.mHoten + " ||   Nhóm : " + Program.mGroup;

            ReportPrintTool print = new ReportPrintTool(reportHP);
            print.ShowPreviewDialog();
        }
    }
}