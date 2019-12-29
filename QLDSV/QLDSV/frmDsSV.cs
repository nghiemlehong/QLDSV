using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace QLDSV
{
    public partial class frmDsSV : DevExpress.XtraEditors.XtraForm
    {
        public frmDsSV()
        {
            InitializeComponent();
        }

        private void CmbBoPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Program.FrmDangNhap.Visible == false)
            {
                if (cmbBoPhan.SelectedIndex == Program.mBoPhan)
                {
                    return;
                }
                else if (cmbBoPhan.SelectedValue != null && cmbBoPhan.SelectedValue.ToString() == "System.Data.DataRowView") return;
                {
                    Program.servername = cmbBoPhan.SelectedValue.ToString();
                    if (cmbBoPhan.SelectedIndex != Program.mBoPhan)
                    {
                        Program.mlogin = Program.remotelogin;
                        Program.password = Program.remotepassword;
                    }
                    else
                    {
                        Program.mlogin = Program.mloginDN;
                        Program.password = Program.passwordDN;
                    }

                    if (Program.KetNoi() == 0)
                        MessageBox.Show("Lỗi kết nối đến BỘ PHẬN mới", "", MessageBoxButtons.OK);
                    else
                    {
                        this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.lOPTableAdapter.Fill(this.dS.LOP);
                        
                        Program.mBoPhan = cmbBoPhan.SelectedIndex;

                    }
                }
            }
        }

        private void LOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FrmDsSV_Load(object sender, EventArgs e)
        {
            Program.bds_DSPM.Filter = "TENCN LIKE 'KHOA%'";
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            dS.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);

            cmbBoPhan.DataSource = Program.bds_DSPM;
            cmbBoPhan.DisplayMember = "TENCN";
            cmbBoPhan.ValueMember = "TENSERVER";
            cmbBoPhan.SelectedIndex = Program.mBoPhan;

            if (Program.mGroup == "PGV")
            {
                cmbBoPhan.Enabled = true;
                //bar2.Visible = false;
            }
            else cmbBoPhan.Enabled = false;

        }

        


        private void btnReview_Click(object sender, EventArgs e)
        {
           
                ReportDSSV reportDSSV = new ReportDSSV(mALOPTextEdit.Text);
                reportDSSV.xrMaLop.Text = "Mã lớp: " + mALOPTextEdit.Text;
                reportDSSV.xrTenLop.Text = "Lớp: " + tENLOPComboBox.SelectedValue.ToString();

                ReportPrintTool print = new ReportPrintTool(reportDSSV);
                print.ShowPreviewDialog();
            
        }
    }
}