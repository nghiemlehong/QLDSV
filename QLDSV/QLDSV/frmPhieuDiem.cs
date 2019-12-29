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
using DevExpress.XtraEditors.Repository;

namespace QLDSV
{
    public partial class frmPhieuDiem : DevExpress.XtraEditors.XtraForm
    {
        public frmPhieuDiem()
        {
            InitializeComponent();
        }

        private void cmbBoPhan_SelectedIndexChanged(object sender, EventArgs e)
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
                        this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

                        Program.mBoPhan = cmbBoPhan.SelectedIndex;

                    }
                }
            }
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sINHVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmPhieuDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            dS.EnforceConstraints = false;
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

           
            Program.bds_DSPM.Filter = "TENCN LIKE 'KHOA%'";
            cmbBoPhan.DataSource = Program.bds_DSPM;
            cmbBoPhan.DisplayMember = "TENCN";
            cmbBoPhan.ValueMember = "TENSERVER";
            cmbBoPhan.SelectedIndex = Program.mBoPhan;

            if (Program.mGroup == "PGV")
            {
                cmbBoPhan.Enabled = true;
            
            }
            else cmbBoPhan.Enabled = false;
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                sINHVIENBindingSource.Filter = "MASV LIKE '%" + txtSearch.Text + "%'";
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            try
            {
                if (sINHVIENBindingSource.SupportsSearching != true)
                    MessageBox.Show("Cannot search the list.");
                else
                {

                    int foundIndex = sINHVIENBindingSource.Find("MASV", txtSearch.Text);

                    if (foundIndex > -1)
                    {
                        if (gvData.GetRowCellValue(foundIndex, "NGHIHOC").ToString() == false.ToString())
                        {
                            //code xử lý in báo cáo
                            MessageBox.Show(txtSearch.Text, "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Sinh viên đã nghỉ học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}