namespace QLDSV
{
    partial class frmChuyenLop
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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label label1;
            this.qLDSVDataSet = new QLDSV.QLDSVDataSet();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLDSV.QLDSVDataSetTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.QLDSVDataSetTableAdapters.TableAdapterManager();
            this.txtMaLopChuyen = new System.Windows.Forms.TextBox();
            this.cmbTenLop = new System.Windows.Forms.ComboBox();
            this.btnChuyenLop = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.hocphiTableAdapter1 = new QLDSV.DS1TableAdapters.HOCPHITableAdapter();
            this.hocphiTableAdapter2 = new QLDSV.DS1TableAdapters.HOCPHITableAdapter();
            this.txtMaSVMoi = new System.Windows.Forms.TextBox();
            this.bdsSinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new QLDSV.QLDSVDataSetTableAdapters.SINHVIENTableAdapter();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(84, 90);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(83, 13);
            mALOPLabel.TabIndex = 3;
            mALOPLabel.Text = "Mã lớp chuyển :";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(80, 54);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(87, 13);
            tENLOPLabel.TabIndex = 4;
            tENLOPLabel.Text = "Tên lớp chuyển :";
            // 
            // qLDSVDataSet
            // 
            this.qLDSVDataSet.DataSetName = "QLDSVDataSet";
            this.qLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.qLDSVDataSet;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.QLDSVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtMaLopChuyen
            // 
            this.txtMaLopChuyen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLop, "MALOP", true));
            this.txtMaLopChuyen.Enabled = false;
            this.txtMaLopChuyen.Location = new System.Drawing.Point(174, 87);
            this.txtMaLopChuyen.Name = "txtMaLopChuyen";
            this.txtMaLopChuyen.Size = new System.Drawing.Size(309, 21);
            this.txtMaLopChuyen.TabIndex = 4;
            // 
            // cmbTenLop
            // 
            this.cmbTenLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLop, "TENLOP", true));
            this.cmbTenLop.DataSource = this.bdsLop;
            this.cmbTenLop.DisplayMember = "TENLOP";
            this.cmbTenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenLop.FormattingEnabled = true;
            this.cmbTenLop.Location = new System.Drawing.Point(174, 51);
            this.cmbTenLop.Name = "cmbTenLop";
            this.cmbTenLop.Size = new System.Drawing.Size(309, 21);
            this.cmbTenLop.TabIndex = 5;
            this.cmbTenLop.ValueMember = "TENLOP";
            // 
            // btnChuyenLop
            // 
            this.btnChuyenLop.Location = new System.Drawing.Point(193, 213);
            this.btnChuyenLop.Name = "btnChuyenLop";
            this.btnChuyenLop.Size = new System.Drawing.Size(92, 39);
            this.btnChuyenLop.TabIndex = 6;
            this.btnChuyenLop.Text = "Chuyển lớp";
            this.btnChuyenLop.Click += new System.EventHandler(this.btnChuyenLop_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(316, 213);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(92, 39);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // hocphiTableAdapter1
            // 
            this.hocphiTableAdapter1.ClearBeforeFill = true;
            // 
            // hocphiTableAdapter2
            // 
            this.hocphiTableAdapter2.ClearBeforeFill = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(76, 128);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 13);
            label1.TabIndex = 8;
            label1.Text = "Mã sinh viên mới :";
            // 
            // txtMaSVMoi
            // 
            this.txtMaSVMoi.Location = new System.Drawing.Point(174, 125);
            this.txtMaSVMoi.Name = "txtMaSVMoi";
            this.txtMaSVMoi.Size = new System.Drawing.Size(309, 21);
            this.txtMaSVMoi.TabIndex = 9;
            // 
            // bdsSinhVien
            // 
            this.bdsSinhVien.DataMember = "SINHVIEN";
            this.bdsSinhVien.DataSource = this.qLDSVDataSet;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // frmChuyenLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 301);
            this.Controls.Add(this.txtMaSVMoi);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnChuyenLop);
            this.Controls.Add(tENLOPLabel);
            this.Controls.Add(this.cmbTenLop);
            this.Controls.Add(mALOPLabel);
            this.Controls.Add(this.txtMaLopChuyen);
            this.Name = "frmChuyenLop";
            this.Text = "Chuyển lớp";
            this.Load += new System.EventHandler(this.frmChuyenLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource bdsLop;
        private QLDSVDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private QLDSVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtMaLopChuyen;
        private System.Windows.Forms.ComboBox cmbTenLop;
        private DevExpress.XtraEditors.SimpleButton btnChuyenLop;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DS1TableAdapters.HOCPHITableAdapter hocphiTableAdapter1;
        private DS1TableAdapters.HOCPHITableAdapter hocphiTableAdapter2;
        private System.Windows.Forms.TextBox txtMaSVMoi;
        private System.Windows.Forms.BindingSource bdsSinhVien;
        private QLDSVDataSetTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
    }
}