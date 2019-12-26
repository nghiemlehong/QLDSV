namespace QLDSV
{
    partial class frmHocPhi
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
            this.DS1 = new QLDSV.DS1();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new QLDSV.DS1TableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager = new QLDSV.DS1TableAdapters.TableAdapterManager();
            this.sINHVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbMaLop = new System.Windows.Forms.Label();
            this.gvNhap = new System.Windows.Forms.GroupBox();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.hOCPHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTienDaDong = new System.Windows.Forms.TextBox();
            this.txtHocPhi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.panelHocPhi = new System.Windows.Forms.Panel();
            this.hOCPHIGridControl = new DevExpress.XtraGrid.GridControl();
            this.gvData1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENDADONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hOCPHITableAdapter = new QLDSV.DS1TableAdapters.HOCPHITableAdapter();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            this.gvNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHIBindingSource)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.panelHocPhi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData1)).BeginInit();
            this.SuspendLayout();
            // 
            // DS1
            // 
            this.DS1.DataSetName = "DS1";
            this.DS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.DS1;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLDSV.DS1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sINHVIENGridControl
            // 
            this.sINHVIENGridControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sINHVIENGridControl.DataSource = this.sINHVIENBindingSource;
            this.sINHVIENGridControl.Location = new System.Drawing.Point(135, 90);
            this.sINHVIENGridControl.MainView = this.gvData;
            this.sINHVIENGridControl.Name = "sINHVIENGridControl";
            this.sINHVIENGridControl.Size = new System.Drawing.Size(933, 215);
            this.sINHVIENGridControl.TabIndex = 1;
            this.sINHVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // gvData
            // 
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colMALOP});
            this.gvData.GridControl = this.sINHVIENGridControl;
            this.gvData.Name = "gvData";
            this.gvData.OptionsBehavior.ReadOnly = true;
            this.gvData.OptionsView.ShowGroupPanel = false;
            // 
            // colMASV
            // 
            this.colMASV.Caption = "Mã sinh viên";
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.OptionsColumn.AllowEdit = false;
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 139;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.AllowEdit = false;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 158;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 104;
            // 
            // colMALOP
            // 
            this.colMALOP.Caption = "Mã lớp";
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.OptionsColumn.AllowEdit = false;
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 3;
            this.colMALOP.Width = 212;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(317, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã sinh viên :";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sINHVIENBindingSource, "MASV", true));
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(406, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(360, 22);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(772, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 33);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Cập nhật học phí";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // lbHoTen
            // 
            this.lbHoTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.ForeColor = System.Drawing.Color.Black;
            this.lbHoTen.Location = new System.Drawing.Point(422, 53);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(64, 16);
            this.lbHoTen.TabIndex = 5;
            this.lbHoTen.Text = "Họ tên : ";
            // 
            // lbMaLop
            // 
            this.lbMaLop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMaLop.AutoSize = true;
            this.lbMaLop.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLop.ForeColor = System.Drawing.Color.Black;
            this.lbMaLop.Location = new System.Drawing.Point(168, 53);
            this.lbMaLop.Name = "lbMaLop";
            this.lbMaLop.Size = new System.Drawing.Size(59, 16);
            this.lbMaLop.TabIndex = 6;
            this.lbMaLop.Text = "Mã lớp :";
            // 
            // gvNhap
            // 
            this.gvNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvNhap.Controls.Add(this.btnThem);
            this.gvNhap.Controls.Add(this.cmbNienKhoa);
            this.gvNhap.Controls.Add(this.cmbHocKy);
            this.gvNhap.Controls.Add(this.btnSave);
            this.gvNhap.Controls.Add(this.lbHoTen);
            this.gvNhap.Controls.Add(this.lbMaLop);
            this.gvNhap.Controls.Add(this.txtTienDaDong);
            this.gvNhap.Controls.Add(this.txtHocPhi);
            this.gvNhap.Controls.Add(this.label5);
            this.gvNhap.Controls.Add(this.label4);
            this.gvNhap.Controls.Add(this.label3);
            this.gvNhap.Controls.Add(this.btnCapNhat);
            this.gvNhap.Controls.Add(this.label2);
            this.gvNhap.Controls.Add(this.btnHuy);
            this.gvNhap.Controls.Add(this.btnQuayLai);
            this.gvNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gvNhap.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvNhap.ForeColor = System.Drawing.Color.Black;
            this.gvNhap.Location = new System.Drawing.Point(194, 27);
            this.gvNhap.Name = "gvNhap";
            this.gvNhap.Size = new System.Drawing.Size(815, 258);
            this.gvNhap.TabIndex = 7;
            this.gvNhap.TabStop = false;
            this.gvNhap.Text = "Thông tin nộp học phí";
            this.gvNhap.Visible = false;
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbNienKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOCPHIBindingSource, "NIENKHOA", true));
            this.cmbNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(244, 87);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(113, 24);
            this.cmbNienKhoa.TabIndex = 13;
            // 
            // hOCPHIBindingSource
            // 
            this.hOCPHIBindingSource.DataMember = "FK_HOCPHI_SINHVIEN";
            this.hOCPHIBindingSource.DataSource = this.sINHVIENBindingSource;
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbHocKy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOCPHIBindingSource, "HOCKY", true));
            this.cmbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Location = new System.Drawing.Point(244, 127);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(113, 24);
            this.cmbHocKy.TabIndex = 12;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuayLai.Location = new System.Drawing.Point(533, 177);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(110, 29);
            this.btnQuayLai.TabIndex = 11;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.BtnHuy_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(412, 177);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 29);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Lưu SQL";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtTienDaDong
            // 
            this.txtTienDaDong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTienDaDong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOCPHIBindingSource, "SOTIENDADONG", true));
            this.txtTienDaDong.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienDaDong.Location = new System.Drawing.Point(525, 130);
            this.txtTienDaDong.Name = "txtTienDaDong";
            this.txtTienDaDong.Size = new System.Drawing.Size(120, 21);
            this.txtTienDaDong.TabIndex = 7;
            // 
            // txtHocPhi
            // 
            this.txtHocPhi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHocPhi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOCPHIBindingSource, "HOCPHI", true));
            this.txtHocPhi.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHocPhi.Location = new System.Drawing.Point(525, 90);
            this.txtHocPhi.Name = "txtHocPhi";
            this.txtHocPhi.Size = new System.Drawing.Size(120, 21);
            this.txtHocPhi.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(168, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Học kỳ :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(422, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Học phí :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(422, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số tiền đã đóng :";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCapNhat.Location = new System.Drawing.Point(170, 177);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCapNhat.Size = new System.Drawing.Size(110, 29);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.BtnCapNhat_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(168, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Niên khóa :";
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.sINHVIENGridControl);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Location = new System.Drawing.Point(0, -2);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1203, 359);
            this.panelSearch.TabIndex = 11;
            // 
            // panelHocPhi
            // 
            this.panelHocPhi.Controls.Add(this.hOCPHIGridControl);
            this.panelHocPhi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHocPhi.Location = new System.Drawing.Point(0, 391);
            this.panelHocPhi.Name = "panelHocPhi";
            this.panelHocPhi.Size = new System.Drawing.Size(1203, 164);
            this.panelHocPhi.TabIndex = 12;
            // 
            // hOCPHIGridControl
            // 
            this.hOCPHIGridControl.DataSource = this.hOCPHIBindingSource;
            this.hOCPHIGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hOCPHIGridControl.Location = new System.Drawing.Point(0, 0);
            this.hOCPHIGridControl.MainView = this.gvData1;
            this.hOCPHIGridControl.Name = "hOCPHIGridControl";
            this.hOCPHIGridControl.Size = new System.Drawing.Size(1203, 164);
            this.hOCPHIGridControl.TabIndex = 0;
            this.hOCPHIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData1});
            // 
            // gvData1
            // 
            this.gvData1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNIENKHOA,
            this.colHOCKY,
            this.colHOCPHI,
            this.colSOTIENDADONG});
            this.gvData1.GridControl = this.hOCPHIGridControl;
            this.gvData1.Name = "gvData1";
            this.gvData1.OptionsView.ShowGroupPanel = false;
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNIENKHOA.AppearanceCell.Options.UseFont = true;
            this.colNIENKHOA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNIENKHOA.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colNIENKHOA.AppearanceHeader.Options.UseFont = true;
            this.colNIENKHOA.AppearanceHeader.Options.UseForeColor = true;
            this.colNIENKHOA.Caption = "Niên khóa";
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.OptionsColumn.AllowEdit = false;
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 0;
            this.colNIENKHOA.Width = 229;
            // 
            // colHOCKY
            // 
            this.colHOCKY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHOCKY.AppearanceCell.Options.UseFont = true;
            this.colHOCKY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHOCKY.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colHOCKY.AppearanceHeader.Options.UseFont = true;
            this.colHOCKY.AppearanceHeader.Options.UseForeColor = true;
            this.colHOCKY.Caption = "Học kỳ";
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.OptionsColumn.AllowEdit = false;
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 1;
            this.colHOCKY.Width = 140;
            // 
            // colHOCPHI
            // 
            this.colHOCPHI.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHOCPHI.AppearanceCell.Options.UseFont = true;
            this.colHOCPHI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHOCPHI.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colHOCPHI.AppearanceHeader.Options.UseFont = true;
            this.colHOCPHI.AppearanceHeader.Options.UseForeColor = true;
            this.colHOCPHI.Caption = "Học phí";
            this.colHOCPHI.FieldName = "HOCPHI";
            this.colHOCPHI.Name = "colHOCPHI";
            this.colHOCPHI.OptionsColumn.AllowEdit = false;
            this.colHOCPHI.Visible = true;
            this.colHOCPHI.VisibleIndex = 2;
            this.colHOCPHI.Width = 256;
            // 
            // colSOTIENDADONG
            // 
            this.colSOTIENDADONG.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSOTIENDADONG.AppearanceCell.Options.UseFont = true;
            this.colSOTIENDADONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSOTIENDADONG.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colSOTIENDADONG.AppearanceHeader.Options.UseFont = true;
            this.colSOTIENDADONG.AppearanceHeader.Options.UseForeColor = true;
            this.colSOTIENDADONG.Caption = "Số tiền đã đóng";
            this.colSOTIENDADONG.FieldName = "SOTIENDADONG";
            this.colSOTIENDADONG.Name = "colSOTIENDADONG";
            this.colSOTIENDADONG.OptionsColumn.AllowEdit = false;
            this.colSOTIENDADONG.Visible = true;
            this.colSOTIENDADONG.VisibleIndex = 3;
            this.colSOTIENDADONG.Width = 295;
            // 
            // hOCPHITableAdapter
            // 
            this.hOCPHITableAdapter.ClearBeforeFill = true;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.Location = new System.Drawing.Point(291, 177);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 29);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHuy.Location = new System.Drawing.Point(533, 177);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(112, 29);
            this.btnHuy.TabIndex = 15;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click_1);
            // 
            // frmHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 555);
            this.Controls.Add(this.panelHocPhi);
            this.Controls.Add(this.gvNhap);
            this.Controls.Add(this.panelSearch);
            this.Name = "frmHocPhi";
            this.Text = "Học phí";
            this.Load += new System.EventHandler(this.FrmHocPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            this.gvNhap.ResumeLayout(false);
            this.gvNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHIBindingSource)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelHocPhi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DS1 DS1;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private DS1TableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private DS1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sINHVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbMaLop;
        private System.Windows.Forms.GroupBox gvNhap;
        private System.Windows.Forms.TextBox txtTienDaDong;
        private System.Windows.Forms.TextBox txtHocPhi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Panel panelHocPhi;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private System.Windows.Forms.BindingSource hOCPHIBindingSource;
        private DS1TableAdapters.HOCPHITableAdapter hOCPHITableAdapter;
        private DevExpress.XtraGrid.GridControl hOCPHIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData1;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCPHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENDADONG;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
    }
}