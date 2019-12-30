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
    public partial class frmBangDiemMH : DevExpress.XtraEditors.XtraForm
    {
        public frmBangDiemMH()
        {
            InitializeComponent();
        }

        private void cmbBoPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Program.FrmDangNhap.Visible == false)
            {
                if (cmbBoPhan.SelectedIndex == Program.mBoPhan)
                {
                    return;
                }
                else if (cmbBoPhan.SelectedValue != null && cmbBoPhan.SelectedValue.ToString() == "System.Data.DataRowView") return;
                {
                    Program.servername = cmbBoPhan.SelectedValue.ToString();
                    if (cmbBoPhan.SelectedIndex != Program.mBoPhan)
                    {
                        Program.mlogin = Program.remotelogin;
                        Program.password = Program.remotepassword;
                    }
                    else
                    {
                        Program.mlogin = Program.mloginDN;
                        Program.password = Program.passwordDN;
                    }

                    if (Program.KetNoi() == 0)
                        MessageBox.Show("Lỗi kết nối đến BỘ PHẬN mới", "", MessageBoxButtons.OK);
                    else
                    {
                        this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.lOPTableAdapter.Fill(this.dS.LOP);

                        Program.mBoPhan = cmbBoPhan.SelectedIndex;

                    }
                }
            }
        }

        private void frmBangDiemMH_Load(object sender, EventArgs e)
        {
           
            
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            dS.EnforceConstraints = false;

            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);

            Program.bds_DSPM.Filter = "TENCN LIKE 'KHOA%'";
            cmbBoPhan.DataSource = Program.bds_DSPM;
            cmbBoPhan.DisplayMember = "TENCN";
            cmbBoPhan.ValueMember = "TENSERVER";
            cmbBoPhan.SelectedIndex = Program.mBoPhan;

            if (Program.mGroup == "PGV")
            {
                cmbBoPhan.Enabled = true;

            }
            else cmbBoPhan.Enabled = false;

            IDictionary<int, int> dict = new Dictionary<int, int>();
            dict.Add(1, 1);
            dict.Add(2, 2);

            cmbLanThi.DataSource = new BindingSource(dict, null);
            cmbLanThi.DisplayMember = "Value";
            cmbLanThi.ValueMember = "Key";
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            ReportDiemMH reportD = new ReportDiemMH(mALOPTextEdit.Text, mAMHTextEdit.Text, cmbLanThi.SelectedIndex+1);
            reportD.xrLop.Text = "Lớp: " + tENLOPComboBox.SelectedValue.ToString();          
            reportD.xrMonHoc.Text = "Môn học: " + tENMHComboBox.SelectedValue.ToString();
            reportD.xrLanthi.Text = "Lần thi: " + cmbLanThi.SelectedValue.ToString();
            reportD.xrLabelInfoNgTao.Text = "Mã giảng viên : " + Program.username + " ||   Họ và tên : " + Program.mHoten + " ||   Nhóm : " + Program.mGroup;

            ReportPrintTool print = new ReportPrintTool(reportD);
            print.ShowPreviewDialog();
        }
    }
    
}