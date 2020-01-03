using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        Boolean dangXuat = false;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            rbNhapLieu.Visible = rbInAn.Visible =  rbDangXuat.Visible = false;

        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangXuat = true;
               Program.FrmMain.Hide();
        
            
            Program.bds_DSPM.Filter = "TENCN LIKE '%'";
            Program.FrmMain = new frmMain();
            Program.FrmMain.Visible = true;
            
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmSinhVien));
            if (frm != null) frm.Activate();
            else
            {
                frmSinhVien f = new frmSinhVien();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void btnLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLop));
            if (frm != null) frm.Activate();
            else
            {
                frmLop f = new frmLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                frmMonHoc f = new frmMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnNhapDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhapDiem));
            if (frm != null) frm.Activate();
            else
            {
                frmNhapDiem f = new frmNhapDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form[] childArray = this.MdiChildren;
            foreach (Form childForm in childArray)
            {
                childForm.Close();
            }
            Form frm = this.CheckExists(typeof(frmDangKy));
            if (frm != null) frm.Activate();
            else
            {
                frmDangKy f = new frmDangKy();
                f.MdiParent = this;
                f.Show();
            }
            
        }

        private void btnDanhSachSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDsSV));
            if (frm != null) frm.Activate();
            else
            {
                frmDsSV f = new frmDsSV();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnHocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmHocPhi));
            if (frm != null) frm.Activate();
            else
            {
                frmHocPhi f = new frmHocPhi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
               Program.FrmDangNhap = new frmDangNhap();
               Program.FrmDangNhap.Show();
            
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           Application.Exit();
        }

        private void btnBDMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmBangDiemMH));
            if (frm != null) frm.Activate();
            else
            {
                frmBangDiemMH f = new frmBangDiemMH();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDSDTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             Form frm = this.CheckExists(typeof(frmDiemTongKet));
            if (frm != null) frm.Activate();
            else
            {
                frmDiemTongKet f = new frmDiemTongKet();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDSHP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDSHocPhi));
            if (frm != null) frm.Activate();
            else
            {
                frmDSHocPhi f = new frmDSHocPhi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDSTHM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDSthiHetMon));
            if (frm != null) frm.Activate();
            else
            {
                frmDSthiHetMon f = new frmDSthiHetMon();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnPD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmPhieuDiem));
            if (frm != null) frm.Activate();
            else
            {
                frmPhieuDiem f = new frmPhieuDiem();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
