namespace QLDSV
{
    partial class frmDSthiHetMon
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
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label tENMHLabel;
            this.cmbBoPhan = new System.Windows.Forms.ComboBox();
            this.dS = new QLDSV.DS();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.mONHOCTableAdapter = new QLDSV.DSTableAdapters.MONHOCTableAdapter();
            this.tENLOPComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TimeEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLanThi = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tENMHComboBox = new System.Windows.Forms.ComboBox();
            this.btnReview = new System.Windows.Forms.Button();
            tENCNLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tENCNLabel
            // 
            tENCNLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tENCNLabel.AutoSize = true;
            tENCNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENCNLabel.Location = new System.Drawing.Point(50, 19);
            tENCNLabel.Name = "tENCNLabel";
            tENCNLabel.Size = new System.Drawing.Size(69, 17);
            tENCNLabel.TabIndex = 8;
            tENCNLabel.Text = "Bộ phận :";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(50, 69);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(49, 13);
            tENLOPLabel.TabIndex = 9;
            tENLOPLabel.Text = "Tên lớp :";
            // 
            // tENMHLabel
            // 
            tENMHLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(50, 103);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(75, 13);
            tENMHLabel.TabIndex = 14;
            tENMHLabel.Text = "Tên môn học :";
            // 
            // cmbBoPhan
            // 
            this.cmbBoPhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBoPhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoPhan.FormattingEnabled = true;
            this.cmbBoPhan.Location = new System.Drawing.Point(131, 19);
            this.cmbBoPhan.Name = "cmbBoPhan";
            this.cmbBoPhan.Size = new System.Drawing.Size(404, 21);
            this.cmbBoPhan.TabIndex = 7;
            this.cmbBoPhan.SelectedIndexChanged += new System.EventHandler(this.cmbBoPhan_SelectedIndexChanged);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.dS;
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
            // tENLOPComboBox
            // 
            this.tENLOPComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tENLOPComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "TENLOP", true));
            this.tENLOPComboBox.DataSource = this.lOPBindingSource;
            this.tENLOPComboBox.DisplayMember = "TENLOP";
            this.tENLOPComboBox.FormattingEnabled = true;
            this.tENLOPComboBox.Location = new System.Drawing.Point(131, 66);
            this.tENLOPComboBox.Name = "tENLOPComboBox";
            this.tENLOPComboBox.Size = new System.Drawing.Size(175, 21);
            this.tENLOPComboBox.TabIndex = 10;
            this.tENLOPComboBox.ValueMember = "TENLOP";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ngày thi :";
            // 
            // textEdit1
            // 
            this.textEdit1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textEdit1.EditValue = null;
            this.textEdit1.Location = new System.Drawing.Point(420, 66);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.textEdit1.Properties.Mask.EditMask = "d";
            this.textEdit1.Size = new System.Drawing.Size(115, 20);
            this.textEdit1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Lần thi :";
            // 
            // cmbLanThi
            // 
            this.cmbLanThi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbLanThi.FormattingEnabled = true;
            this.cmbLanThi.Location = new System.Drawing.Point(420, 103);
            this.cmbLanThi.Name = "cmbLanThi";
            this.cmbLanThi.Size = new System.Drawing.Size(115, 21);
            this.cmbLanThi.TabIndex = 14;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.dS;
            // 
            // tENMHComboBox
            // 
            this.tENMHComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tENMHComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mONHOCBindingSource, "TENMH", true));
            this.tENMHComboBox.DataSource = this.mONHOCBindingSource;
            this.tENMHComboBox.DisplayMember = "TENMH";
            this.tENMHComboBox.FormattingEnabled = true;
            this.tENMHComboBox.Location = new System.Drawing.Point(131, 100);
            this.tENMHComboBox.Name = "tENMHComboBox";
            this.tENMHComboBox.Size = new System.Drawing.Size(175, 21);
            this.tENMHComboBox.TabIndex = 15;
            this.tENMHComboBox.ValueMember = "TENMH";
            // 
            // btnReview
            // 
            this.btnReview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReview.Location = new System.Drawing.Point(199, 145);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(186, 23);
            this.btnReview.TabIndex = 21;
            this.btnReview.Text = "Review";
            this.btnReview.UseVisualStyleBackColor = true;
            // 
            // frmDSthiHetMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 180);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(tENMHLabel);
            this.Controls.Add(this.tENMHComboBox);
            this.Controls.Add(this.cmbLanThi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(tENLOPLabel);
            this.Controls.Add(this.tENLOPComboBox);
            this.Controls.Add(tENCNLabel);
            this.Controls.Add(this.cmbBoPhan);
            this.Controls.Add(this.textEdit1);
            this.Name = "frmDSthiHetMon";
            this.Text = "Danh sách thi hết môn";
            this.Load += new System.EventHandler(this.frmDSthiHetMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoPhan;
        private DS dS;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox tENLOPComboBox;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TimeEdit textEdit1;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLanThi;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private System.Windows.Forms.ComboBox tENMHComboBox;
        private System.Windows.Forms.Button btnReview;
    }
}