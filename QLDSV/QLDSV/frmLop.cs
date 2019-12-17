using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class frmLop : Form
    {
        int viTri = 0;
        String maKhoa = "";
        Boolean checkAdd = false;

        public frmLop()
        {
            InitializeComponent();
        }

        private void cmbBoPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoPhan.SelectedIndex == 0)
            {
                MessageBox.Show("Login không đủ quyền truy cập!", "", MessageBoxButtons.OK);
                cmbBoPhan.SelectedIndex = Program.mBoPhan;
                return;
            }
            if (Program.FrmDangNhap.Visible == false)
            {
                if(cmbBoPhan.SelectedIndex == Program.mBoPhan)
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
                        this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                        
                         maKhoa = ((DataRowView)bdsLop[bdsLop.Position])["MAKH"].ToString();
                            
                       
                        Program.mBoPhan = cmbBoPhan.SelectedIndex;
                    
                    }
                }
            }
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            // this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            dS.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            
    
            cmbBoPhan.DataSource = Program.bds_DSPM;
            cmbBoPhan.DisplayMember = "TENCN";
            cmbBoPhan.ValueMember = "TENSERVER";
            cmbBoPhan.SelectedIndex = Program.mBoPhan;

            if (Program.mGroup == "PGV")
            {
                cmbBoPhan.Enabled = true;
               
            }
            else cmbBoPhan.Enabled = false;
            gbLop.Enabled = false;
            maKhoa = ((DataRowView)bdsLop[bdsLop.Position])["MAKH"].ToString();

        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void lOPGridControl_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
   
            viTri = bdsLop.Position;
            gbLop.Enabled = true;
            cmbBoPhan.Enabled = false;
            bdsLop.AddNew();
            txtMaKhoa.Text = maKhoa;
            txtMaKhoa.Enabled = false;
            gcLop.Enabled = false;
            checkAdd = true;
            btnXoa.Enabled = btnThem.Enabled = btnSua.Enabled = false;
        }

        // Kiểm tra tồn tại lớp

        private void btnSave_Click(object sender, EventArgs e)
        {
            viTri = bdsLop.Position;
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return;
            }
            if (txtTenLop.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtTenLop.Focus();
                return;
            }
            int dem1 = 0, dem2 = 0;
            for (int i = 0; i < bdsLop.Count; i++)
            {
                if (txtMaLop.Text.Trim() == ((DataRowView)bdsLop[i])["MALOP"].ToString().Trim())
                {
                    dem1++;
                    Console.WriteLine(((DataRowView)bdsLop[i])["MALOP"].ToString().Trim());
                }
                if (txtTenLop.Text.Trim() == ((DataRowView)bdsLop[i])["TENLOP"].ToString().Trim())
                    dem2++;
            }
            if (dem1 == 2)
            {
                MessageBox.Show("Mã lớp bị trùng!", "", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return;
            }
            if (dem2 == 2)
            {
                MessageBox.Show("Tên lớp bị trùng!", "", MessageBoxButtons.OK);
                txtTenLop.Focus();
                return;
            }

            String strLenh =
           " declare @ret int;" +
           " EXEC dbo.sp_KiemTraLop @malop = '" + txtMaLop.Text + "'," +
           " @tenlop = N'" + txtTenLop.Text + "', " +
           " @ret = @ret OUTPUT" +
           " SELECT  @ret";
            Program.myReader = Program.ExecSqlDataReader(strLenh);

            if (Program.myReader != null && Program.myReader.HasRows)
            {
                while (Program.myReader.Read())
                {
                    int ret = Program.myReader.GetInt32(0);
                   /* if (ret == 1)
                    {
                        Program.myReader.Close();
                        MessageBox.Show("Mã hoặc tên lớp đã tồn tại ở khoa khác", "Đóng");
                        return;
                    }*/
                    if (ret == 2)
                    {
                        Program.myReader.Close();
                        MessageBox.Show("Mã hoặc tên lớp đã tồn tại ở khoa khác", "Đóng");
                        return;
                    }
                }

            }
            Program.myReader.Close();

            try
            {
                bdsLop.EndEdit();
                //bdsLop.ResetCurrentItem();
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Update(this.dS.LOP);
                MessageBox.Show("Lưu dữ liệu thành công!", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi lớp.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gbLop.Enabled = false;
            gcLop.Enabled = true;
            cmbBoPhan.Enabled = true;
            btnXoa.Enabled = btnThem.Enabled = btnSua.Enabled = true;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (checkAdd == true)
            {
                bdsLop.RemoveCurrent();
                bdsLop.CancelEdit();
                checkAdd = false;
            }
            else
            {
                bdsLop.CancelEdit();
            }
            cmbBoPhan.Enabled = true;
            gcLop.Enabled = true;
            gbLop.Enabled = false;
            btnXoa.Enabled = btnThem.Enabled = btnSua.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String malop = "";
            Console.WriteLine(bdsLop.Count);
            if (bdsSinhVien.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp này vì Lớp đã có sinh viên.", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thực sự muốn xóa Lớp này??", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    malop = (((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString());
                    bdsLop.RemoveCurrent();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.dS.LOP);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa Lớp.\nBạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.lOPTableAdapter.Fill(this.dS.LOP);
                    bdsLop.Position = bdsLop.Find("MALOP", malop);
                    return;

                }
            }
            if (bdsLop.Count == 0) btnXoa.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsLop.Position;
            gbLop.Enabled = true;
            cmbBoPhan.Enabled = false;
            txtMaKhoa.Text = maKhoa;
            txtMaKhoa.Enabled = false;
            gcLop.Enabled = false;
        
            btnXoa.Enabled = btnThem.Enabled = btnSua.Enabled = false;
        }
    }
}
