namespace QLDSV
{
    partial class frmDSHocPhi
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
            System.Windows.Forms.Label tENLOPLabel;
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMaLop = new System.Windows.Forms.ComboBox();
            this.btnReview = new System.Windows.Forms.Button();
            this.dS1 = new QLDSV.DS1();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLDSV.DS1TableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.DS1TableAdapters.TableAdapterManager();
            this.tENLOPTextEdit = new DevExpress.XtraEditors.TextEdit();
            tENLOPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENLOPTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(392, 21);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(113, 21);
            this.cmbNienKhoa.TabIndex = 17;
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Location = new System.Drawing.Point(153, 64);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(113, 21);
            this.cmbHocKy.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(77, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Học kỳ :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(316, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Niên khóa :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(77, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã Lớp :";
            // 
            // cmbMaLop
            // 
            this.cmbMaLop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbMaLop.DataSource = this.lOPBindingSource;
            this.cmbMaLop.DisplayMember = "MALOP";
            this.cmbMaLop.FormattingEnabled = true;
            this.cmbMaLop.Location = new System.Drawing.Point(153, 21);
            this.cmbMaLop.Name = "cmbMaLop";
            this.cmbMaLop.Size = new System.Drawing.Size(113, 21);
            this.cmbMaLop.TabIndex = 19;
            this.cmbMaLop.ValueMember = "MALOP";
            // 
            // btnReview
            // 
            this.btnReview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReview.Location = new System.Drawing.Point(319, 62);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(186, 23);
            this.btnReview.TabIndex = 20;
            this.btnReview.Text = "Review";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // dS1
            // 
            this.dS1.DataSetName = "DS1";
            this.dS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.dS1;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DS1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(47, 54);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(0, 13);
            tENLOPLabel.TabIndex = 20;
            // 
            // tENLOPTextEdit
            // 
            this.tENLOPTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "TENLOP", true));
            this.tENLOPTextEdit.Location = new System.Drawing.Point(153, 22);
            this.tENLOPTextEdit.Name = "tENLOPTextEdit";
            this.tENLOPTextEdit.Size = new System.Drawing.Size(100, 20);
            this.tENLOPTextEdit.TabIndex = 21;
            this.tENLOPTextEdit.Visible = false;
            // 
            // frmDSHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 107);
            this.Controls.Add(tENLOPLabel);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(this.cmbMaLop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbNienKhoa);
            this.Controls.Add(this.cmbHocKy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tENLOPTextEdit);
            this.Name = "frmDSHocPhi";
            this.Text = "Danh sách học phí";
            this.Load += new System.EventHandler(this.frmDSHocPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENLOPTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMaLop;
        private System.Windows.Forms.Button btnReview;
        private DS1 dS1;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DS1TableAdapters.LOPTableAdapter lOPTableAdapter;
        private DS1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit tENLOPTextEdit;
    }
}