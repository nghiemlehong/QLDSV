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
using System.Data.SqlClient;

namespace QLDSV
{
    public partial class frmDangKy : DevExpress.XtraEditors.XtraForm
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void GIANGVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gIANGVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            
            DS.EnforceConstraints = false;
            this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIANGVIENTableAdapter.Fill(this.DS.GIANGVIEN);
            Program.bds_DSPM.Filter = "TENCN LIKE '%'";
            cmbBoPhan.DataSource = Program.bds_DSPM;
            cmbBoPhan.DisplayMember = "TENCN";
            cmbBoPhan.ValueMember = "TENSERVER";

           // Fix lỗi cmb 
            if(Program.mBoPhan == 2)
            cmbBoPhan.SelectedIndex = Program.mBoPhan;
            else
            {
                cmbBoPhan.SelectedIndex = Program.mBoPhan + 1;
            }

            //Phân quyền cho từng bộ phận đăng ký thêm tài khoản
            if (Program.mGroup == "PGV")
            {
                cmbBoPhan.Enabled = true;
                rd1.Checked = true;
                if(cmbBoPhan.SelectedIndex == 0 )
                {
                    rd1.Enabled = rd2.Enabled = false;
                    rd3.Enabled = true;
                    rd3.Checked = true;
                }
                else if(cmbBoPhan.SelectedIndex == 1 || cmbBoPhan.SelectedIndex == 2 )
                {
                    rd1.Enabled = rd2.Enabled = true;
                    rd3.Enabled = false;
                    rd1.Checked = true;
                }
            }
            else
            {
                cmbBoPhan.Enabled = false;
                grNhom.Enabled = false;
                if (Program.mGroup == "KHOA")
                    rd2.Checked = true;
                else rd3.Checked = true;
            }

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
                        this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.gIANGVIENTableAdapter.Fill(this.DS.GIANGVIEN);
                        //this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        //this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                        Program.mBoPhan = cmbBoPhan.SelectedIndex;

                    }
                }
                if (Program.mGroup == "PGV")
                {
                    cmbBoPhan.Enabled = true;
                    rd1.Checked = true;
                    if (cmbBoPhan.SelectedIndex == 0)
                    {
                        rd1.Enabled = rd2.Enabled = false;
                        rd3.Enabled = true;
                        rd3.Checked = true;
                    }
                    else if (cmbBoPhan.SelectedIndex == 1 || cmbBoPhan.SelectedIndex == 2)
                    {
                        rd1.Enabled = rd2.Enabled = true;
                        rd3.Enabled = false;
                        rd1.Checked = true;
                    }
                }
            }
        }

        public void dk()
        {
            String nhom;
            if (txtNamDN.Text.Trim() == "" )
            {
                MessageBox.Show("Tên đăng nhập không được trống", "Báo lỗi đăng ký", MessageBoxButtons.OK);
                txtNamDN.Focus();
                return;
            }
            if (txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được trống", "Báo lỗi đăng ký", MessageBoxButtons.OK);
                txtPass.Focus();
                return;
            }
            if (rd1.Checked == true) nhom = "PGV"; else if (rd2.Checked == true) nhom = "KHOA"; else nhom = "PKETOAN";
            String strLenh = "EXEC SP_TaoTaiKhoan '" + txtNamDN.Text.Trim() + "','" + txtPass.Text.Trim() + "','" + txtGV.Text.Trim() + "','" + nhom + "'" ;

           /* try
            {
                SqlDataReader sqlRead = Program.ExecSqlDataReader(strLenh);
                if (sqlRead != null)
                {
                    sqlRead.Read();
                    if (sqlRead.GetString(0) == "0")
                        MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            String strLenh1 =
                "DECLARE @return_value int "+
                "EXEC    @return_value = [dbo].[sp_TaoTaiKhoan] "+
                "@LGNAME = N'"+txtNamDN.Text.Trim()+"', "+
		        "@PASS = N'"+txtPass.Text.Trim()+"', "+
		        "@USERNAME = N'"+txtGV.Text.Trim() +"', "+
		        "@ROLE = N'"+nhom+"' " +
                "SELECT  'Return Value' = @return_value";
            Program.myReader = Program.ExecSqlDataReader(strLenh1);
            if (Program.myReader != null && Program.myReader.HasRows)
            {
                try
                {
                    while (Program.myReader.Read())
                    {
                        int ret = Program.myReader.GetInt32(0);
                        if(ret == 0)
                        {
                            MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            if (Program.myReader != null)
            Program.myReader.Close();

        }

        private void BtnDangKy_Click(object sender, EventArgs e)
        {
            dk();
        }
    }
}