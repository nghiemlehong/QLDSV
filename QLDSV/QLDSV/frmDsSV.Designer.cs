namespace QLDSV
{
    partial class frmDsSV
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
            this.tENCNLabel = new System.Windows.Forms.Label();
            this.tENLOPLabel = new System.Windows.Forms.Label();
            this.mALOPLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReview = new System.Windows.Forms.Button();
            this.cmbBoPhan = new System.Windows.Forms.ComboBox();
            this.mALOPTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV.DS();
            this.tENLOPComboBox = new System.Windows.Forms.ComboBox();
            this.lOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mALOPTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.SuspendLayout();
            // 
            // tENCNLabel
            // 
            this.tENCNLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tENCNLabel.AutoSize = true;
            this.tENCNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tENCNLabel.Location = new System.Drawing.Point(85, 71);
            this.tENCNLabel.Name = "tENCNLabel";
            this.tENCNLabel.Size = new System.Drawing.Size(69, 17);
            this.tENCNLabel.TabIndex = 6;
            this.tENCNLabel.Text = "Bộ phận :";
            // 
            // tENLOPLabel
            // 
            this.tENLOPLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tENLOPLabel.AutoSize = true;
            this.tENLOPLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tENLOPLabel.Location = new System.Drawing.Point(85, 118);
            this.tENLOPLabel.Name = "tENLOPLabel";
            this.tENLOPLabel.Size = new System.Drawing.Size(54, 13);
            this.tENLOPLabel.TabIndex = 13;
            this.tENLOPLabel.Text = "Tên lớp :";
            // 
            // mALOPLabel
            // 
            this.mALOPLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mALOPLabel.AutoSize = true;
            this.mALOPLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mALOPLabel.Location = new System.Drawing.Point(85, 153);
            this.mALOPLabel.Name = "mALOPLabel";
            this.mALOPLabel.Size = new System.Drawing.Size(50, 13);
            this.mALOPLabel.TabIndex = 14;
            this.mALOPLabel.Text = "Mã lớp :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnReview);
            this.panel1.Controls.Add(this.tENCNLabel);
            this.panel1.Controls.Add(this.mALOPLabel);
            this.panel1.Controls.Add(this.cmbBoPhan);
            this.panel1.Controls.Add(this.mALOPTextEdit);
            this.panel1.Controls.Add(this.tENLOPComboBox);
            this.panel1.Controls.Add(this.tENLOPLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 264);
            this.panel1.TabIndex = 12;
            // 
            // btnReview
            // 
            this.btnReview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReview.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReview.ForeColor = System.Drawing.Color.Black;
            this.btnReview.Location = new System.Drawing.Point(444, 131);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(107, 23);
            this.btnReview.TabIndex = 16;
            this.btnReview.Text = "Review";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // cmbBoPhan
            // 
            this.cmbBoPhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBoPhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoPhan.FormattingEnabled = true;
            this.cmbBoPhan.Location = new System.Drawing.Point(203, 70);
            this.cmbBoPhan.Name = "cmbBoPhan";
            this.cmbBoPhan.Size = new System.Drawing.Size(348, 21);
            this.cmbBoPhan.TabIndex = 1;
            this.cmbBoPhan.SelectedIndexChanged += new System.EventHandler(this.CmbBoPhan_SelectedIndexChanged);
            // 
            // mALOPTextEdit
            // 
            this.mALOPTextEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mALOPTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOPBindingSource, "MALOP", true));
            this.mALOPTextEdit.Enabled = false;
            this.mALOPTextEdit.Location = new System.Drawing.Point(154, 150);
            this.mALOPTextEdit.Name = "mALOPTextEdit";
            this.mALOPTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mALOPTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.mALOPTextEdit.Properties.Appearance.Options.UseFont = true;
            this.mALOPTextEdit.Properties.Appearance.Options.UseForeColor = true;
            this.mALOPTextEdit.Size = new System.Drawing.Size(258, 20);
            this.mALOPTextEdit.TabIndex = 15;
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
            // tENLOPComboBox
            // 
            this.tENLOPComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tENLOPComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "TENLOP", true));
            this.tENLOPComboBox.DataSource = this.lOPBindingSource;
            this.tENLOPComboBox.DisplayMember = "TENLOP";
            this.tENLOPComboBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tENLOPComboBox.FormattingEnabled = true;
            this.tENLOPComboBox.Location = new System.Drawing.Point(154, 115);
            this.tENLOPComboBox.Name = "tENLOPComboBox";
            this.tENLOPComboBox.Size = new System.Drawing.Size(258, 21);
            this.tENLOPComboBox.TabIndex = 14;
            this.tENLOPComboBox.ValueMember = "TENLOP";
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
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmDsSV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(640, 264);
            this.Controls.Add(this.panel1);
            this.Name = "frmDsSV";
            this.Text = "Dánh sách sinh viên";
            this.Load += new System.EventHandler(this.FrmDsSV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mALOPTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbBoPhan;
        private DS dS;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox tENLOPComboBox;
        private DevExpress.XtraEditors.TextEdit mALOPTextEdit;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.Label tENCNLabel;
        private System.Windows.Forms.Label tENLOPLabel;
        private System.Windows.Forms.Label mALOPLabel;
    }
}