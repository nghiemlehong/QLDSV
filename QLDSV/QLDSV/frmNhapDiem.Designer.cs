namespace QLDSV
{
    partial class frmNhapDiem
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
            System.Windows.Forms.Label tENCNLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapDiem));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuuSQL = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbBoPhan = new System.Windows.Forms.ComboBox();
            this.gbNhapDiem = new System.Windows.Forms.GroupBox();
            this.cmbLanThi = new System.Windows.Forms.ComboBox();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.txtTenMonHoc = new DevExpress.XtraEditors.TextEdit();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV.DS();
            this.cmbMaMonHoc = new System.Windows.Forms.ComboBox();
            this.txtTenLop = new DevExpress.XtraEditors.TextEdit();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.cmbMaLop = new System.Windows.Forms.ComboBox();
            this.lOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.mONHOCTableAdapter = new QLDSV.DSTableAdapters.MONHOCTableAdapter();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.gbGhiDiem = new System.Windows.Forms.GroupBox();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.sINHVIENTableAdapter = new QLDSV.DSTableAdapters.SINHVIENTableAdapter();
            this.gcNhapDiem = new DevExpress.XtraGrid.GridControl();
            this.gvNhapDiem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsSinhVien = new System.Windows.Forms.BindingSource(this.components);
            tENCNLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbNhapDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMonHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.gbGhiDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhapDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhapDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // tENCNLabel
            // 
            tENCNLabel.AutoSize = true;
            tENCNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENCNLabel.Location = new System.Drawing.Point(14, 16);
            tENCNLabel.Name = "tENCNLabel";
            tENCNLabel.Size = new System.Drawing.Size(69, 17);
            tENCNLabel.TabIndex = 0;
            tENCNLabel.Text = "Bộ phận :";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(38, 43);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(45, 13);
            mALOPLabel.TabIndex = 0;
            mALOPLabel.Text = "Mã lớp :";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(342, 43);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(49, 13);
            tENLOPLabel.TabIndex = 2;
            tENLOPLabel.Text = "Tên lớp :";
            tENLOPLabel.Click += new System.EventHandler(this.tENLOPLabel_Click);
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(12, 85);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(71, 13);
            mAMHLabel.TabIndex = 4;
            mAMHLabel.Text = "Mã môn học :";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(316, 86);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(75, 13);
            tENMHLabel.TabIndex = 6;
            tENMHLabel.Text = "Tên môn học :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(647, 86);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 13);
            label1.TabIndex = 9;
            label1.Text = "Lần thi :";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnLuuSQL,
            this.btnPhucHoi});
            this.barManager1.MaxItemId = 5;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1179, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 494);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1179, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 494);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1179, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 494);
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            // 
            // btnLuuSQL
            // 
            this.btnLuuSQL.Caption = "Lưu SQL";
            this.btnLuuSQL.Id = 3;
            this.btnLuuSQL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuSQL.ImageOptions.Image")));
            this.btnLuuSQL.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuuSQL.ImageOptions.LargeImage")));
            this.btnLuuSQL.Name = "btnLuuSQL";
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(tENCNLabel);
            this.panel1.Controls.Add(this.cmbBoPhan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 55);
            this.panel1.TabIndex = 4;
            // 
            // cmbBoPhan
            // 
            this.cmbBoPhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoPhan.FormattingEnabled = true;
            this.cmbBoPhan.Location = new System.Drawing.Point(89, 12);
            this.cmbBoPhan.Name = "cmbBoPhan";
            this.cmbBoPhan.Size = new System.Drawing.Size(836, 24);
            this.cmbBoPhan.TabIndex = 1;
            this.cmbBoPhan.SelectedIndexChanged += new System.EventHandler(this.cmbBoPhan_SelectedIndexChanged);
            // 
            // gbNhapDiem
            // 
            this.gbNhapDiem.Controls.Add(this.cmbLanThi);
            this.gbNhapDiem.Controls.Add(label1);
            this.gbNhapDiem.Controls.Add(this.btnBatDau);
            this.gbNhapDiem.Controls.Add(tENMHLabel);
            this.gbNhapDiem.Controls.Add(this.txtTenMonHoc);
            this.gbNhapDiem.Controls.Add(mAMHLabel);
            this.gbNhapDiem.Controls.Add(this.cmbMaMonHoc);
            this.gbNhapDiem.Controls.Add(tENLOPLabel);
            this.gbNhapDiem.Controls.Add(this.txtTenLop);
            this.gbNhapDiem.Controls.Add(mALOPLabel);
            this.gbNhapDiem.Controls.Add(this.cmbMaLop);
            this.gbNhapDiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbNhapDiem.Location = new System.Drawing.Point(0, 55);
            this.gbNhapDiem.Name = "gbNhapDiem";
            this.gbNhapDiem.Size = new System.Drawing.Size(1179, 176);
            this.gbNhapDiem.TabIndex = 5;
            this.gbNhapDiem.TabStop = false;
            this.gbNhapDiem.Text = "Nhập thông tin";
            // 
            // cmbLanThi
            // 
            this.cmbLanThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanThi.FormattingEnabled = true;
            this.cmbLanThi.Location = new System.Drawing.Point(699, 81);
            this.cmbLanThi.Name = "cmbLanThi";
            this.cmbLanThi.Size = new System.Drawing.Size(79, 21);
            this.cmbLanThi.TabIndex = 10;
            // 
            // btnBatDau
            // 
            this.btnBatDau.Location = new System.Drawing.Point(835, 40);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(75, 55);
            this.btnBatDau.TabIndex = 8;
            this.btnBatDau.Text = "Bắt đầu ";
            this.btnBatDau.UseVisualStyleBackColor = true;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // txtTenMonHoc
            // 
            this.txtTenMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMonHoc, "TENMH", true));
            this.txtTenMonHoc.Enabled = false;
            this.txtTenMonHoc.Location = new System.Drawing.Point(408, 82);
            this.txtTenMonHoc.MenuManager = this.barManager1;
            this.txtTenMonHoc.Name = "txtTenMonHoc";
            this.txtTenMonHoc.Size = new System.Drawing.Size(219, 20);
            this.txtTenMonHoc.TabIndex = 7;
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "MONHOC";
            this.bdsMonHoc.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbMaMonHoc
            // 
            this.cmbMaMonHoc.DataSource = this.bdsMonHoc;
            this.cmbMaMonHoc.DisplayMember = "MAMH";
            this.cmbMaMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaMonHoc.FormattingEnabled = true;
            this.cmbMaMonHoc.Location = new System.Drawing.Point(89, 82);
            this.cmbMaMonHoc.Name = "cmbMaMonHoc";
            this.cmbMaMonHoc.Size = new System.Drawing.Size(202, 21);
            this.cmbMaMonHoc.TabIndex = 5;
            this.cmbMaMonHoc.ValueMember = "MAMH";
            // 
            // txtTenLop
            // 
            this.txtTenLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "TENLOP", true));
            this.txtTenLop.Enabled = false;
            this.txtTenLop.Location = new System.Drawing.Point(408, 40);
            this.txtTenLop.MenuManager = this.barManager1;
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(370, 20);
            this.txtTenLop.TabIndex = 3;
            this.txtTenLop.EditValueChanged += new System.EventHandler(this.tENLOPTextEdit_EditValueChanged);
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.dS;
            // 
            // cmbMaLop
            // 
            this.cmbMaLop.DataSource = this.bdsLop;
            this.cmbMaLop.DisplayMember = "MALOP";
            this.cmbMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaLop.FormattingEnabled = true;
            this.cmbMaLop.Location = new System.Drawing.Point(89, 40);
            this.cmbMaLop.Name = "cmbMaLop";
            this.cmbMaLop.Size = new System.Drawing.Size(202, 21);
            this.cmbMaLop.TabIndex = 1;
            this.cmbMaLop.ValueMember = "MALOP";
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // gbGhiDiem
            // 
            this.gbGhiDiem.Controls.Add(this.btnHuy);
            this.gbGhiDiem.Controls.Add(this.btnCapNhat);
            this.gbGhiDiem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbGhiDiem.Location = new System.Drawing.Point(0, 383);
            this.gbGhiDiem.Name = "gbGhiDiem";
            this.gbGhiDiem.Size = new System.Drawing.Size(1179, 111);
            this.gbGhiDiem.TabIndex = 11;
            this.gbGhiDiem.TabStop = false;
            this.gbGhiDiem.Text = "Ghi điểm";
            // 
            // btnHuy
            // 
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Location = new System.Drawing.Point(520, 37);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 47);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCapNhat.ImageOptions.SvgImage")));
            this.btnCapNhat.Location = new System.Drawing.Point(385, 37);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(119, 47);
            this.btnCapNhat.TabIndex = 0;
            this.btnCapNhat.Text = "Lưu vào SQL";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // gcNhapDiem
            // 
            this.gcNhapDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNhapDiem.Location = new System.Drawing.Point(0, 231);
            this.gcNhapDiem.MainView = this.gvNhapDiem;
            this.gcNhapDiem.MenuManager = this.barManager1;
            this.gcNhapDiem.Name = "gcNhapDiem";
            this.gcNhapDiem.Size = new System.Drawing.Size(1179, 152);
            this.gcNhapDiem.TabIndex = 51;
            this.gcNhapDiem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhapDiem});
            // 
            // gvNhapDiem
            // 
            this.gvNhapDiem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MASV,
            this.HOTEN,
            this.DIEM});
            this.gvNhapDiem.GridControl = this.gcNhapDiem;
            this.gvNhapDiem.Name = "gvNhapDiem";
            this.gvNhapDiem.OptionsView.ShowGroupPanel = false;
            // 
            // MASV
            // 
            this.MASV.Caption = "Mã sinh viên";
            this.MASV.FieldName = "MASV";
            this.MASV.Name = "MASV";
            this.MASV.OptionsColumn.AllowEdit = false;
            this.MASV.Visible = true;
            this.MASV.VisibleIndex = 0;
            this.MASV.Width = 114;
            // 
            // HOTEN
            // 
            this.HOTEN.Caption = "Họ và tên";
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.OptionsColumn.AllowEdit = false;
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 1;
            this.HOTEN.Width = 648;
            // 
            // DIEM
            // 
            this.DIEM.Caption = "Điểm";
            this.DIEM.FieldName = "DIEM";
            this.DIEM.Name = "DIEM";
            this.DIEM.Visible = true;
            this.DIEM.VisibleIndex = 2;
            this.DIEM.Width = 196;
            // 
            // bdsSinhVien
            // 
            this.bdsSinhVien.DataMember = "FK_SINHVIEN_LOP";
            this.bdsSinhVien.DataSource = this.bdsLop;
            // 
            // frmNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 494);
            this.Controls.Add(this.gcNhapDiem);
            this.Controls.Add(this.gbGhiDiem);
            this.Controls.Add(this.gbNhapDiem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmNhapDiem";
            this.Text = "Nhập điếm";
            this.Load += new System.EventHandler(this.frmNhapDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbNhapDiem.ResumeLayout(false);
            this.gbNhapDiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMonHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.gbGhiDiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNhapDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhapDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnLuuSQL;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbBoPhan;
        private System.Windows.Forms.BindingSource bdsLop;
        private DS dS;
        private System.Windows.Forms.GroupBox gbNhapDiem;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit txtTenLop;
        private System.Windows.Forms.ComboBox cmbMaLop;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private DevExpress.XtraEditors.TextEdit txtTenMonHoc;
        private System.Windows.Forms.ComboBox cmbMaMonHoc;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.ComboBox cmbLanThi;
        private System.Windows.Forms.GroupBox gbGhiDiem;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private DevExpress.XtraGrid.GridControl gcNhapDiem;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhapDiem;
        private DevExpress.XtraGrid.Columns.GridColumn MASV;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn DIEM;
        private System.Windows.Forms.BindingSource bdsSinhVien;
    }
}