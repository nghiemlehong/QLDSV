﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVDataSet.V_DS_PHANMANH);
            cmbBoPhanDN.SelectedIndex = 1; cmbBoPhanDN.SelectedIndex = 0;

        }

      

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim() == "" )
            {
                MessageBox.Show("Login name và mật mã không được trống", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                txtTenDangNhap.Focus();  
                return;
            }

            Program.mlogin = txtTenDangNhap.Text;
            Program.password = txtMatKhau.Text;
          
            if (Program.KetNoi() == 0) return;
            //MessageBox.Show("Thành công", "", MessageBoxButtons.OK);

            Program.mBoPhan = cmbBoPhanDN.SelectedIndex - 1;
        
            Program.bds_DSPM = bdsDSPM;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            String strLenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null)
            {
                //MessageBox.Show("Tài khoản này không tồn tại trong hệ thống.\nKhông tìm thấy: " + Program.mlogin, "Lỗi đăng nhập!", MessageBoxButtons.OK);
                return;
            }
            Program.myReader.Read();
            Program.username = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login này không có quyền truy cập dữ liệu.", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Console.WriteLine("group :" + Program.mGroup);

            
            Program.myReader.Close();
            Program.conn.Close();

          //  Program.FrmMain = new frmMain();
            Program.FrmMain.MAGV.Text = "Mã giảng viên : " + Program.username;
            Program.FrmMain.HOTEN.Text = " ||   Họ và tên : " + Program.mHoten;
            Program.FrmMain.NHOM.Text = " ||   Nhóm : " + Program.mGroup;

            //  Program.FrmMain.Show();
            Program.FrmDangNhap.Hide();
            Program.FrmMain.rbNhapLieu.Visible = Program.FrmMain.rbInAn.Visible  = Program.FrmMain.rbDangXuat.Visible = true;
            Program.FrmMain.rbDangNhap.Visible = false;
            if(Program.mGroup == "PGV" || Program.mGroup == "KHOA")
            {
                Program.FrmMain.rbPhongKeToan.Visible = false ;
                Program.FrmMain.rbDSHP.Visible = false;
            }
            else
            {
                Program.FrmMain.rbKhoa.Visible = false;
                Program.FrmMain.rbDSSV.Visible = false;
            }


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Program.FrmDangNhap.Close();
        }

        private void cmbBoPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoPhanDN.SelectedValue != null)
                Program.servername = cmbBoPhanDN.SelectedValue.ToString();
        }
    }
}
