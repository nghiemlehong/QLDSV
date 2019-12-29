namespace QLDSV
{
    partial class frmBangDiemMH
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
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label mAMHLabel;
            this.btnReview = new System.Windows.Forms.Button();
            this.cmbBoPhan = new System.Windows.Forms.ComboBox();
            this.mALOPTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENLOPComboBox = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV.DS();
            this.lOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new QLDSV.DSTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.tENMHComboBox = new System.Windows.Forms.ComboBox();
            this.mAMHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cmbLanThi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            tENCNLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mALOPTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAMHTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tENCNLabel
            // 
            tENCNLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tENCNLabel.AutoSize = true;
            tENCNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENCNLabel.Location = new System.Drawing.Point(150, 27);
            tENCNLabel.Name = "tENCNLabel";
            tENCNLabel.Size = new System.Drawing.Size(69, 17);
            tENCNLabel.TabIndex = 25;
            tENCNLabel.Text = "Bộ phận :";
            // 
            // mALOPLabel
            // 
            mALOPLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            mALOPLabel.AutoSize = true;
            mALOPLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOPLabel.ForeColor = System.Drawing.Color.Black;
            mALOPLabel.Location = new System.Drawing.Point(456, 66);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(50, 13);
            mALOPLabel.TabIndex = 27;
            mALOPLabel.Text = "Mã lớp :";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLOPLabel.ForeColor = System.Drawing.Color.Black;
            tENLOPLabel.Location = new System.Drawing.Point(121, 66);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(54, 13);
            tENLOPLabel.TabIndex = 26;
            tENLOPLabel.Text = "Tên lớp :";
            // 
            // btnReview
            // 
            this.btnReview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReview.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReview.ForeColor = System.Drawing.Color.Black;
            this.btnReview.Location = new System.Drawing.Point(390, 137);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(107, 23);
            this.btnReview.TabIndex = 30;
            this.btnReview.Text = "Review";
            this.btnReview.UseVisualStyleBackColor = true;
            // 
            // cmbBoPhan
            // 
            this.cmbBoPhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBoPhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoPhan.FormattingEnabled = true;
            this.cmbBoPhan.Location = new System.Drawing.Point(268, 26);
            this.cmbBoPhan.Name = "cmbBoPhan";
            this.cmbBoPhan.Size = new System.Drawing.Size(348, 21);
            this.cmbBoPhan.TabIndex = 24;
            this.cmbBoPhan.SelectedIndexChanged += new System.EventHandler(this.cmbBoPhan_SelectedIndexChanged);
            // 
            // mALOPTextEdit
            // 
            this.mALOPTextEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mALOPTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOPBindingSource, "MALOP", true));
            this.mALOPTextEdit.Enabled = false;
            this.mALOPTextEdit.Location = new System.Drawing.Point(525, 63);
            this.mALOPTextEdit.Name = "mALOPTextEdit";
            this.mALOPTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mALOPTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.mALOPTextEdit.Properties.Appearance.Options.UseFont = true;
            this.mALOPTextEdit.Properties.Appearance.Options.UseForeColor = true;
            this.mALOPTextEdit.Size = new System.Drawing.Size(120, 20);
            this.mALOPTextEdit.TabIndex = 29;
            // 
            // tENLOPComboBox
            // 
            this.tENLOPComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tENLOPComboBox.DataSource = this.lOPBindingSource;
            this.tENLOPComboBox.DisplayMember = "TENLOP";
            this.tENLOPComboBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tENLOPComboBox.FormattingEnabled = true;
            this.tENLOPComboBox.Location = new System.Drawing.Point(190, 63);
            this.tENLOPComboBox.Name = "tENLOPComboBox";
            this.tENLOPComboBox.Size = new System.Drawing.Size(258, 21);
            this.tENLOPComboBox.TabIndex = 28;
            this.tENLOPComboBox.ValueMember = "TENLOP";
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.dS;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
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
            // tENMHLabel
            // 
            tENMHLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tENMHLabel.AutoSize = true;
            tENMHLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENMHLabel.ForeColor = System.Drawing.Color.Black;
            tENMHLabel.Location = new System.Drawing.Point(121, 105);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(62, 13);
            tENMHLabel.TabIndex = 30;
            tENMHLabel.Text = "Tên môn :";
            // 
            // tENMHComboBox
            // 
            this.tENMHComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tENMHComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mONHOCBindingSource, "TENMH", true));
            this.tENMHComboBox.DataSource = this.mONHOCBindingSource;
            this.tENMHComboBox.DisplayMember = "TENMH";
            this.tENMHComboBox.FormattingEnabled = true;
            this.tENMHComboBox.Location = new System.Drawing.Point(190, 102);
            this.tENMHComboBox.Name = "tENMHComboBox";
            this.tENMHComboBox.Size = new System.Drawing.Size(258, 21);
            this.tENMHComboBox.TabIndex = 31;
            this.tENMHComboBox.ValueMember = "TENMH";
            // 
            // mAMHLabel
            // 
            mAMHLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            mAMHLabel.AutoSize = true;
            mAMHLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAMHLabel.ForeColor = System.Drawing.Color.Black;
            mAMHLabel.Location = new System.Drawing.Point(456, 105);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(58, 13);
            mAMHLabel.TabIndex = 31;
            mAMHLabel.Text = "Mã môn :";
            // 
            // mAMHTextEdit
            // 
            this.mAMHTextEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mAMHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mONHOCBindingSource, "MAMH", true));
            this.mAMHTextEdit.Enabled = false;
            this.mAMHTextEdit.Location = new System.Drawing.Point(525, 102);
            this.mAMHTextEdit.Name = "mAMHTextEdit";
            this.mAMHTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mAMHTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.mAMHTextEdit.Properties.Appearance.Options.UseFont = true;
            this.mAMHTextEdit.Properties.Appearance.Options.UseForeColor = true;
            this.mAMHTextEdit.Size = new System.Drawing.Size(120, 20);
            this.mAMHTextEdit.TabIndex = 32;
            // 
            // cmbLanThi
            // 
            this.cmbLanThi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbLanThi.FormattingEnabled = true;
            this.cmbLanThi.Location = new System.Drawing.Point(327, 139);
            this.cmbLanThi.Name = "cmbLanThi";
            this.cmbLanThi.Size = new System.Drawing.Size(47, 21);
            this.cmbLanThi.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(270, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Lần thi :";
            // 
            // frmBangDiemMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 187);
            this.Controls.Add(this.cmbLanThi);
            this.Controls.Add(this.label2);
            this.Controls.Add(mAMHLabel);
            this.Controls.Add(this.mAMHTextEdit);
            this.Controls.Add(tENMHLabel);
            this.Controls.Add(this.tENMHComboBox);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(tENCNLabel);
            this.Controls.Add(mALOPLabel);
            this.Controls.Add(this.cmbBoPhan);
            this.Controls.Add(this.mALOPTextEdit);
            this.Controls.Add(this.tENLOPComboBox);
            this.Controls.Add(tENLOPLabel);
            this.Name = "frmBangDiemMH";
            this.Text = "Bảng điểm môn học";
            this.Load += new System.EventHandler(this.frmBangDiemMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mALOPTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAMHTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.ComboBox cmbBoPhan;
        private DevExpress.XtraEditors.TextEdit mALOPTextEdit;
        private System.Windows.Forms.ComboBox tENLOPComboBox;
        private DS dS;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox tENMHComboBox;
        private DevExpress.XtraEditors.TextEdit mAMHTextEdit;
        private System.Windows.Forms.ComboBox cmbLanThi;
        private System.Windows.Forms.Label label2;
    }
}