﻿using System;
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
    public partial class frmDiemTongKet : DevExpress.XtraEditors.XtraForm
    {
        public frmDiemTongKet()
        {
            InitializeComponent();
        }

        private void frmDiemTongKet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            dS.EnforceConstraints = false;
            
            
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

        private void btnReview_Click(object sender, EventArgs e)
        {
            ReportBangDiemTongKet1 reportBDTK = new ReportBangDiemTongKet1(mALOPTextEdit.Text);
            reportBDTK.xrLop.Text = "Lớp: " + tENLOPComboBox.SelectedValue.ToString();
            reportBDTK.xrLabelInfoNgTao.Text = "Mã giảng viên : " + Program.username + " ||   Họ và tên : " + Program.mHoten + " ||   Nhóm : " + Program.mGroup;
            ReportPrintTool print = new ReportPrintTool(reportBDTK);
            print.ShowPreviewDialog();
        }
    }
}