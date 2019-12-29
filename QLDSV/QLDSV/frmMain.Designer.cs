namespace QLDSV
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnMon = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhapDiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangKy = new DevExpress.XtraBars.BarButtonItem();
            this.btnHocPhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhSachSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnBDMH = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSDTK = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSHP = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSTHM = new DevExpress.XtraBars.BarButtonItem();
            this.btnPD = new DevExpress.XtraBars.BarButtonItem();
            this.rbQuanTri = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbDangNhap = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbDangXuat = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbNhapLieu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbKhoa = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPhongKeToan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbInAn = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbDSSV = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MAGV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnDangXuat,
            this.barButtonItem2,
            this.btnSinhVien,
            this.btnLop,
            this.btnMonHoc,
            this.btnMon,
            this.btnNhapDiem,
            this.btnDangKy,
            this.btnHocPhi,
            this.btnDanhSachSinhVien,
            this.btnDangNhap,
            this.btnThoat,
            this.btnBDMH,
            this.btnDSDTK,
            this.btnDSHP,
            this.btnDSTHM,
            this.btnPD});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbQuanTri,
            this.rbNhapLieu,
            this.rbInAn});
            this.ribbonControl1.Size = new System.Drawing.Size(1012, 158);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Id = 2;
            this.btnDangXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangXuat.ImageOptions.SvgImage")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Đăng ký";
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Caption = "Sinh Viên";
            this.btnSinhVien.Id = 4;
            this.btnSinhVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSinhVien.ImageOptions.SvgImage")));
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSinhVien_ItemClick);
            // 
            // btnLop
            // 
            this.btnLop.Caption = "Lớp";
            this.btnLop.Id = 5;
            this.btnLop.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLop.ImageOptions.SvgImage")));
            this.btnLop.Name = "btnLop";
            this.btnLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLop_ItemClick);
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Caption = "Môn học";
            this.btnMonHoc.Id = 7;
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // btnMon
            // 
            this.btnMon.Caption = "Môn học";
            this.btnMon.Id = 8;
            this.btnMon.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMon.ImageOptions.SvgImage")));
            this.btnMon.Name = "btnMon";
            this.btnMon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMon_ItemClick);
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.Caption = "Nhập điểm";
            this.btnNhapDiem.Id = 9;
            this.btnNhapDiem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNhapDiem.ImageOptions.SvgImage")));
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhapDiem_ItemClick);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Caption = "Đăng ký";
            this.btnDangKy.Id = 10;
            this.btnDangKy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangKy.ImageOptions.SvgImage")));
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangKy_ItemClick);
            // 
            // btnHocPhi
            // 
            this.btnHocPhi.Caption = "Học phí";
            this.btnHocPhi.Id = 11;
            this.btnHocPhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHocPhi.ImageOptions.SvgImage")));
            this.btnHocPhi.Name = "btnHocPhi";
            this.btnHocPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHocPhi_ItemClick);
            // 
            // btnDanhSachSinhVien
            // 
            this.btnDanhSachSinhVien.Caption = "Danh sách sinh viên";
            this.btnDanhSachSinhVien.Id = 1;
            this.btnDanhSachSinhVien.Name = "btnDanhSachSinhVien";
            this.btnDanhSachSinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanhSachSinhVien_ItemClick);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng nhập";
            this.btnDangNhap.Id = 3;
            this.btnDangNhap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangNhap.ImageOptions.SvgImage")));
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 4;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // btnBDMH
            // 
            this.btnBDMH.Caption = "Bảng điểm môn học";
            this.btnBDMH.Id = 5;
            this.btnBDMH.Name = "btnBDMH";
            this.btnBDMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBDMH_ItemClick);
            // 
            // btnDSDTK
            // 
            this.btnDSDTK.Caption = "Danh sách điểm tổng kết";
            this.btnDSDTK.Id = 6;
            this.btnDSDTK.Name = "btnDSDTK";
            this.btnDSDTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSDTK_ItemClick);
            // 
            // btnDSHP
            // 
            this.btnDSHP.Caption = "Dánh sách học phí";
            this.btnDSHP.Id = 7;
            this.btnDSHP.Name = "btnDSHP";
            this.btnDSHP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSHP_ItemClick);
            // 
            // btnDSTHM
            // 
            this.btnDSTHM.Caption = "Danh sách thi hết môn";
            this.btnDSTHM.Id = 8;
            this.btnDSTHM.Name = "btnDSTHM";
            this.btnDSTHM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSTHM_ItemClick);
            // 
            // btnPD
            // 
            this.btnPD.Caption = "Phiếu điểm";
            this.btnPD.Id = 9;
            this.btnPD.Name = "btnPD";
            this.btnPD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPD_ItemClick);
            // 
            // rbQuanTri
            // 
            this.rbQuanTri.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbDangNhap,
            this.rbDangXuat,
            this.ribbonPageGroup1});
            this.rbQuanTri.Name = "rbQuanTri";
            this.rbQuanTri.Text = "Quản trị";
            // 
            // rbDangNhap
            // 
            this.rbDangNhap.ItemLinks.Add(this.btnDangNhap);
            this.rbDangNhap.Name = "rbDangNhap";
            // 
            // rbDangXuat
            // 
            this.rbDangXuat.ItemLinks.Add(this.btnDangXuat);
            this.rbDangXuat.ItemLinks.Add(this.btnDangKy);
            this.rbDangXuat.Name = "rbDangXuat";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPageGroup1.ImageOptions.SvgImage")));
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThoat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // rbNhapLieu
            // 
            this.rbNhapLieu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbKhoa,
            this.rbPhongKeToan});
            this.rbNhapLieu.Name = "rbNhapLieu";
            this.rbNhapLieu.Text = "Nhập liệu";
            // 
            // rbKhoa
            // 
            this.rbKhoa.ItemLinks.Add(this.btnSinhVien);
            this.rbKhoa.ItemLinks.Add(this.btnLop);
            this.rbKhoa.ItemLinks.Add(this.btnMon);
            this.rbKhoa.ItemLinks.Add(this.btnNhapDiem);
            this.rbKhoa.Name = "rbKhoa";
            // 
            // rbPhongKeToan
            // 
            this.rbPhongKeToan.ItemLinks.Add(this.btnHocPhi);
            this.rbPhongKeToan.Name = "rbPhongKeToan";
            // 
            // rbInAn
            // 
            this.rbInAn.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbDSSV,
            this.ribbonPageGroup2});
            this.rbInAn.Name = "rbInAn";
            this.rbInAn.Text = "In ấn";
            // 
            // rbDSSV
            // 
            this.rbDSSV.ItemLinks.Add(this.btnDanhSachSinhVien);
            this.rbDSSV.ItemLinks.Add(this.btnBDMH);
            this.rbDSSV.ItemLinks.Add(this.btnDSDTK);
            this.rbDSSV.ItemLinks.Add(this.btnDSTHM);
            this.rbDSSV.ItemLinks.Add(this.btnPD);
            this.rbDSSV.Name = "rbDSSV";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDSHP);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MAGV,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 499);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1012, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MAGV
            // 
            this.MAGV.Name = "MAGV";
            this.MAGV.Size = new System.Drawing.Size(41, 17);
            this.MAGV.Text = "MAGV";
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(45, 17);
            this.HOTEN.Text = "HOTEN";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(45, 17);
            this.NHOM.Text = "NHOM";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 521);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Quản lý điểm sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel MAGV;
        public System.Windows.Forms.ToolStripStatusLabel HOTEN;
        public System.Windows.Forms.ToolStripStatusLabel NHOM;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnSinhVien;
        private DevExpress.XtraBars.BarButtonItem btnLop;
        private DevExpress.XtraBars.BarButtonItem btnMonHoc;
        private DevExpress.XtraBars.BarButtonItem btnMon;
        private DevExpress.XtraBars.BarButtonItem btnNhapDiem;
        private DevExpress.XtraBars.BarButtonItem btnDangKy;
        private DevExpress.XtraBars.BarButtonItem btnHocPhi;
        private DevExpress.XtraBars.BarButtonItem btnDanhSachSinhVien;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        public DevExpress.XtraBars.Ribbon.RibbonPage rbQuanTri;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup rbDangXuat;
        public DevExpress.XtraBars.Ribbon.RibbonPage rbNhapLieu;
        public DevExpress.XtraBars.Ribbon.RibbonPage rbInAn;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup rbDangNhap;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup rbKhoa;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPhongKeToan;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup rbDSSV;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnBDMH;
        private DevExpress.XtraBars.BarButtonItem btnDSDTK;
        private DevExpress.XtraBars.BarButtonItem btnDSHP;
        private DevExpress.XtraBars.BarButtonItem btnDSTHM;
        private DevExpress.XtraBars.BarButtonItem btnPD;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}

