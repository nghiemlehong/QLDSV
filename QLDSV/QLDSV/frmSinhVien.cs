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
    public partial class frmSinhVien : DevExpress.XtraEditors.XtraForm
    {
        int viTri = 0;
        String maKhoa = "";
        Boolean checkAdd = false;
        Boolean kiemTraThayDoi = false;
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.DIEM' table. You can move, or remove it, as needed.
            this.dIEMTableAdapter.Fill(this.dS.DIEM);


            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            dS.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'qLDSVDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
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
          
          
            gbSinhVien.Enabled = false;

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
                if (cmbBoPhan.SelectedIndex == Program.mBoPhan)
                {
                    return;
                }
                else if (cmbBoPhan.SelectedValue != null && cmbBoPhan.SelectedValue.ToString() == "System.Data.DataRowView") return;
                {
                    Program.servername = cmbBoPhan.SelectedValue.ToString();
                    if (cmbBoPhan.SelectedIndex != Program.mBoPhan)
                    {
                        if (kiemTraThayDoi == true)
                            if (MessageBox.Show("Bạn có muốn lưu lại vào cơ sở dữ liệu không?", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
                            {
                                try
                                {
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
                            }
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
                        Program.mBoPhan = cmbBoPhan.SelectedIndex;

                    }
                    kiemTraThayDoi = false;
                }
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbSinhVien.Enabled = true;
            viTri = bdsLop.Position;
            bdsSinhVien.AddNew();
            txtMaLop.Text = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();
            chkPhai.Checked = true;
            chkNghiHoc.Checked = false;
            //  dateNgaySinh.Checked = true;
            txtMaLop.Enabled = false;
           // chkPhai.Enabled = false;
            chkNghiHoc.Enabled = false;
            gcSinhVien.Enabled = gcLop.Enabled = false;
            cmbBoPhan.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLuuSQL.Enabled= btnPhucHoi.Enabled = btnChuyenLop.Enabled = false;
            //grctrlLop.Enabled = grctrlSV.Enabled = false;
            //checkGhi = false;
            checkAdd = true;
            kiemTraThayDoi = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (txtMaSinhVien.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được trống!", "", MessageBoxButtons.OK);
                txtMaSinhVien.Focus();
                return;
            }
            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ không được trống!", "", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được trống!", "", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }
            int dem = 0;
            for (int i = 0; i < bdsToanSV.Count; i++)
            {

                if (txtMaSinhVien.Text.Trim() == ((DataRowView)bdsToanSV[i])["MASV"].ToString().Trim())
                {
                  
                    dem++;
                }
            }

            if(checkAdd == true)// Thêm sinh viên mới
            {
                if (dem == 1)
                {
                    MessageBox.Show("Mã sinh viên bị trùng!");
                    txtMaSinhVien.Focus();
                    return;
                }
            }
            else // Sửa sinh viên
            {
                if (dem == 2)
                {
                    MessageBox.Show("Mã sinh viên bị trùng!");
                    txtMaSinhVien.Focus();
                    return;
                }
            }
           
            String strLenh =
               " DECLARE @ret int"+
               " EXEC dbo.sp_KiemTraSinhVien"+
               " @masv = '"+txtMaSinhVien.Text+"'," +
               " @ret = @ret OUTPUT" +
               " SELECT @ret";

            Program.myReader = Program.ExecSqlDataReader(strLenh);

            if (Program.myReader != null && Program.myReader.HasRows)
            {
                while (Program.myReader.Read())
                {
                    int ret = Program.myReader.GetInt32(0);
                    /* if (ret == 1)
                     {
                         Program.myReader.Close();
                         MessageBox.Show("Mã sinh viên đã trùng", "Đóng");
                         return;
                     }*/
                     if (ret == 2)// Kiểm tra trùng mã sinh viên ở khoa khác
                    {
                        Program.myReader.Close();
                        MessageBox.Show("Mã lớp đã trung ở khoa khác", "Đóng");
                        return;
                    }
                }

            }
            Program.myReader.Close();
            bdsSinhVien.EndEdit();
            gbSinhVien.Enabled = false;
            gcSinhVien.Enabled = gcLop.Enabled = true;
            if (Program.mGroup == "PGV")
            {
                cmbBoPhan.Enabled = true;
                //bar2.Visible = false;
            }
            else cmbBoPhan.Enabled = false;
           btnLuuSQL.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = btnChuyenLop.Enabled = true;


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (checkAdd == true)
            {
                bdsSinhVien.RemoveCurrent();
                bdsSinhVien.CancelEdit();
                checkAdd = false;
            }
            else
            {
                bdsSinhVien.CancelEdit();
            }
            gbSinhVien.Enabled = false;
            gcSinhVien.Enabled = gcLop.Enabled = true;
            if (Program.mGroup == "PGV")
            {
                cmbBoPhan.Enabled = true;
                //bar2.Visible = false;
            }
            else cmbBoPhan.Enabled = false;
           btnLuuSQL.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = btnChuyenLop.Enabled = true;

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            String masv = "";
            if (chkNghiHoc.Checked)
            {
                MessageBox.Show("Sinh viên này đã nghỉ học!", "", MessageBoxButtons.OK);
                return;
            }
            if(bdsSinhVien.Count==0)
            {
                MessageBox.Show("Lớp không có sinh viên để xóa!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thực sự muốn xóa Sinh viên này??", "Đánh dấu nghỉ học?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    masv = (((DataRowView)bdsSinhVien[bdsSinhVien.Position])["MASV"].ToString());
                    chkNghiHoc.Checked = true;
                    bdsSinhVien.EndEdit();
                

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên.\nBạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                    bdsSinhVien.Position = bdsSinhVien.Find("MASV", masv);
                    return;
                }
            }
            kiemTraThayDoi = true;


        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbSinhVien.Enabled = true;
            viTri = bdsLop.Position;
            chkPhai.Checked = true;
            chkNghiHoc.Checked = false;
            //  dateNgaySinh.Checked = true;
            txtMaLop.Enabled = false;
            // chkPhai.Enabled = false;
            chkNghiHoc.Enabled = false;
            gcSinhVien.Enabled = gcLop.Enabled = false;
            cmbBoPhan.Enabled = false;
            btnLuuSQL.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = btnChuyenLop.Enabled = false;
            //grctrlLop.Enabled = grctrlSV.Enabled = false;
            //checkGhi = false;
            kiemTraThayDoi = true;
           
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {              
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                MessageBox.Show("Lưu dữ liệu thành công!", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi sinh viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
