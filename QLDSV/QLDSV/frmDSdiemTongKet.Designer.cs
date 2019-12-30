﻿namespace QLDSV
{
    partial class frmDiemTongKet
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
            this.btnReview = new System.Windows.Forms.Button();
            this.cmbBoPhan = new System.Windows.Forms.ComboBox();
            this.mALOPTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV.DS();
            this.tENLOPComboBox = new System.Windows.Forms.ComboBox();
            this.lOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            tENCNLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mALOPTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.SuspendLayout();
            // 
            // tENCNLabel
            // 
            tENCNLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tENCNLabel.AutoSize = true;
            tENCNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENCNLabel.Location = new System.Drawing.Point(56, 90);
            tENCNLabel.Name = "tENCNLabel";
            tENCNLabel.Size = new System.Drawing.Size(69, 17);
            tENCNLabel.TabIndex = 18;
            tENCNLabel.Text = "Bộ phận :";
            // 
            // mALOPLabel
            // 
            mALOPLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            mALOPLabel.AutoSize = true;
            mALOPLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOPLabel.Location = new System.Drawing.Point(56, 172);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(50, 13);
            mALOPLabel.TabIndex = 20;
            mALOPLabel.Text = "Mã lớp :";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLOPLabel.Location = new System.Drawing.Point(56, 137);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(54, 13);
            tENLOPLabel.TabIndex = 19;
            tENLOPLabel.Text = "Tên lớp :";
            // 
            // btnReview
            // 
            this.btnReview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReview.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReview.ForeColor = System.Drawing.Color.Black;
            this.btnReview.Location = new System.Drawing.Point(415, 150);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(107, 23);
            this.btnReview.TabIndex = 23;
            this.btnReview.Text = "Review";
            this.btnReview.UseVisualStyleBackColor = true;
            // 
            // cmbBoPhan
            // 
            this.cmbBoPhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBoPhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoPhan.FormattingEnabled = true;
            this.cmbBoPhan.Location = new System.Drawing.Point(174, 89);
            this.cmbBoPhan.Name = "cmbBoPhan";
            this.cmbBoPhan.Size = new System.Drawing.Size(348, 21);
            this.cmbBoPhan.TabIndex = 17;
            this.cmbBoPhan.SelectedIndexChanged += new System.EventHandler(this.cmbBoPhan_SelectedIndexChanged);
            // 
            // mALOPTextEdit
            // 
            this.mALOPTextEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mALOPTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "MALOP", true));
            this.mALOPTextEdit.Enabled = false;
            this.mALOPTextEdit.Location = new System.Drawing.Point(125, 169);
            this.mALOPTextEdit.Name = "mALOPTextEdit";
            this.mALOPTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mALOPTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.mALOPTextEdit.Properties.Appearance.Options.UseFont = true;
            this.mALOPTextEdit.Properties.Appearance.Options.UseForeColor = true;
            this.mALOPTextEdit.Size = new System.Drawing.Size(258, 20);
            this.mALOPTextEdit.TabIndex = 22;
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
            this.tENLOPComboBox.DataSource = this.lOPBindingSource;
            this.tENLOPComboBox.DisplayMember = "TENLOP";
            this.tENLOPComboBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tENLOPComboBox.FormattingEnabled = true;
            this.tENLOPComboBox.Location = new System.Drawing.Point(125, 134);
            this.tENLOPComboBox.Name = "tENLOPComboBox";
            this.tENLOPComboBox.Size = new System.Drawing.Size(258, 21);
            this.tENLOPComboBox.TabIndex = 21;
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
            // frmDiemTongKet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 279);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(tENCNLabel);
            this.Controls.Add(mALOPLabel);
            this.Controls.Add(this.cmbBoPhan);
            this.Controls.Add(this.mALOPTextEdit);
            this.Controls.Add(this.tENLOPComboBox);
            this.Controls.Add(tENLOPLabel);
            this.Name = "frmDiemTongKet";
            this.Text = "Danh sách điểm tổng kết";
            this.Load += new System.EventHandler(this.frmDiemTongKet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mALOPTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
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
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
    }
}