using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        Boolean kiemTraThemSV = false;
        Boolean kiemTraThayDoi = false;
        int viTriThemSinhVien = 0;
        public static String maSV = "";
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            Program.bds_DSPM.Filter = "TENCN LIKE 'KHOA%'";
            
            // TODO: This line of code loads data into the 'qLDSVDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter1.Fill(this.qLDSVDataSet.LOP);
            // TODO: This line of code loads data into the 'dS.DIEM' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            dS.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            this.dIEMTableAdapter.Fill(this.dS.DIEM);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'qLDSVDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            cmbBoPhan.DataSource = Program.bds_DSPM;
            cmbBoPhan.DisplayMember = "TENCN";
            cmbBoPhan.ValueMember = "TENSERVER";
            cmbBoPhan.SelectedIndex = Program.mBoPhan;

            if (Program.mGroup == "PGV")
            {
                cmbBoPhan.Enabled = true;
                btnLuuSQL.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = btnChuyenLop.Enabled = true;
                
               
                //bar2.Visible = false;
            }
            else
            {
                cmbBoPhan.Enabled = false;
                btnLuuSQL.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = btnChuyenLop.Enabled = false;
                gcSinhVien.Enabled= false;

            }
          


            gbLop.Enabled = false;
            maKhoa = ((DataRowView)bdsLop[bdsLop.Position])["MAKH"].ToString();

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
                        maKhoa = ((DataRowView)bdsLop[bdsLop.Position])["MAKH"].ToString();

                    }
                    kiemTraThayDoi = false;
                }
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Thêm lớp
            gbLop.Enabled = true;
            viTri = bdsLop.Position;
            bdsLop.AddNew();
            txtMaKhoa.Text = maKhoa;
            txtMaKhoa.Enabled = false;
           
         
            // chkPhai.Checked = true;
            // chkNghiHoc.Checked = false;
            //  dateNgaySinh.Checked = true;
            // txtMaLop.Enabled = false;
            // chkPhai.Enabled = false;
            //  chkNghiHoc.Enabled = false;
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
            
         /*   if (txtMaSinhVien.Text.Trim() == "")
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
            }*/
 /*          
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
                    *//* if (ret == 1)
                     {
                         Program.myReader.Close();
                         MessageBox.Show("Mã sinh viên đã trùng", "Đóng");
                         return;
                     }*//*
                     if (ret == 2)// Kiểm tra trùng mã sinh viên ở khoa khác
                    {
                        Program.myReader.Close();
                        MessageBox.Show("Mã lớp đã trung ở khoa khác", "Đóng");
                        return;
                    }
                }

            }*/
            Program.myReader.Close();
            bdsSinhVien.EndEdit();
            gbLop.Enabled = false;
            gcSinhVien.Enabled = gcLop.Enabled = true;
            if (Program.mGroup == "PGV")
            {
                cmbBoPhan.Enabled = true;
                btnLuuSQL.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = btnChuyenLop.Enabled = true;

                //bar2.Visible = false;
            }
            else cmbBoPhan.Enabled = false;


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
            gbLop.Enabled = false;
            gcSinhVien.Enabled = gcLop.Enabled = true;
            if (Program.mGroup == "PGV")
            {
                cmbBoPhan.Enabled = true;
                btnLuuSQL.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = btnChuyenLop.Enabled = true;

                //bar2.Visible = false;
            }
            else cmbBoPhan.Enabled = false;

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            /*   */

            kiemTraThayDoi = true;
            String malop = "";
            viTri = bdsLop.Position;

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
                    /* this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                     this.lOPTableAdapter.Update(this.dS.LOP);*/
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
            if (Program.mGroup == "PGV")
            {
                cmbBoPhan.Enabled = true;

            }
            else cmbBoPhan.Enabled = false;


        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* gbSinhVien.Enabled = true;
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
             kiemTraThayDoi = true;*/
            viTri = bdsLop.Position;
            gbLop.Enabled = true;
            cmbBoPhan.Enabled = false;
            txtMaKhoa.Text = maKhoa;
            txtMaKhoa.Enabled = false;
            gcLop.Enabled = false;
            kiemTraThayDoi = true;
            btnXoa.Enabled = btnThem.Enabled = btnSua.Enabled = btnLuuSQL.Enabled = btnPhucHoi.Enabled = false;

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Update(this.dS.LOP);
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                MessageBox.Show("Lưu dữ liệu thành công!", "", MessageBoxButtons.OK);
                kiemTraThayDoi = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi sinh viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnChuyenLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            kiemTraThayDoi = true;
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
            bdsLop.EndEdit();
            gbLop.Enabled = false;
            gcLop.Enabled = true;
            if (Program.mGroup == "PGV")
            {
                cmbBoPhan.Enabled = true;
                btnXoa.Enabled = btnThem.Enabled = btnSua.Enabled = btnLuuSQL.Enabled = btnPhucHoi.Enabled = true;
            }
            else cmbBoPhan.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLop.CancelEdit();
            bdsLop.Position = viTri;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

        }

        private void tsThem_Click(object sender, EventArgs e)
        {
            viTri = bdsSinhVien.Position;
            bdsSinhVien.AddNew();
            tsThem.Enabled = tsXoa.Enabled = tsChuyenLop.Enabled = false;
            btnXoa.Enabled = btnThem.Enabled = btnSua.Enabled = btnLuuSQL.Enabled = btnPhucHoi.Enabled = false ;
            Console.WriteLine(bdsSinhVien.Position);
            ((DataRowView)bdsSinhVien[bdsSinhVien.Position])["PHAI"] = true;
            ((DataRowView)bdsSinhVien[bdsSinhVien.Position])["NGHIHOC"] = false;
            gcLop.Enabled = false;
            kiemTraThemSV = true;
            viTriThemSinhVien = bdsSinhVien.Position;

          
        }

        private void tsLuu_Click(object sender, EventArgs e)
        {
           
            if(kiemTraThemSV == true)
            {
              
                Console.WriteLine(viTriThemSinhVien);
               
                    if(gvSinhVien.GetRowCellValue(viTriThemSinhVien, "MASV").ToString().Trim() == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mã sinh viên!");
                        gvSinhVien.FocusedRowHandle = viTriThemSinhVien;
                        return;
                    }
                    if (gvSinhVien.GetRowCellValue(viTriThemSinhVien, "HO").ToString().Trim() == "")
                    {
                        MessageBox.Show("Bạn chưa nhập họ sinh viên!");
                        gvSinhVien.FocusedRowHandle = viTriThemSinhVien;
                        return;
                    }
                    if (gvSinhVien.GetRowCellValue(viTriThemSinhVien, "TEN").ToString().Trim() == "")
                    {
                        MessageBox.Show("Bạn chưa nhập tên sinh viên!");
                        gvSinhVien.FocusedRowHandle = viTriThemSinhVien;
                        return;
                    }
               
                Console.WriteLine(gvSinhVien.GetRowCellValue(viTriThemSinhVien, "MASV").ToString().Trim());
                Console.WriteLine(bdsToanSV.Count);
                int dem = 0;
                for (int i = 0; i < bdsToanSV.Count; i++)//Kiểm tra sinh viên trong khoa
                {
                    Console.WriteLine(((DataRowView)bdsToanSV[i])["MASV"].ToString().Trim());
                    if (gvSinhVien.GetRowCellValue(viTriThemSinhVien, "MASV").ToString().Trim() == ((DataRowView)bdsToanSV[i])["MASV"].ToString().Trim())
                    {

                        dem++;
                    }
                }

                if (kiemTraThemSV == true)// Thêm sinh viên mới
                {
                    if (dem == 2)
                    {
                        MessageBox.Show("Mã sinh viên bị trùng!");
                        return;
                    }
                }
                // Kiểm tra sinh viên khác khoa
                  String strLenh =
               " DECLARE @ret int"+
               " EXEC dbo.sp_KiemTraSinhVien"+
               " @masv = '"+ gvSinhVien.GetRowCellValue(viTriThemSinhVien, "MASV").ToString().Trim() + "'," +
               " @ret = @ret OUTPUT" +
               " SELECT @ret";

                  Program.myReader = Program.ExecSqlDataReader(strLenh);

                if (Program.myReader != null && Program.myReader.HasRows)
                {
                    while (Program.myReader.Read())
                    {
                        int ret = Program.myReader.GetInt32(0);
                  
                         if (ret == 2)// Kiểm tra trùng mã sinh viên ở khoa khác
                        {
                            Program.myReader.Close();
                            MessageBox.Show("Mã lớp đã trung ở khoa khác", "Đóng");
                            return;
                        }
                    }

                }
                Program.myReader.Close();
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
            else
            {
                for(int i = 0; i<bdsSinhVien.Count;i++)
                {
                    if (gvSinhVien.GetRowCellValue(i, "MASV").ToString().Trim() == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mã sinh viên!");
                        gvSinhVien.FocusedRowHandle = i;
                        return;
                    }
                    if (gvSinhVien.GetRowCellValue(i, "HO").ToString().Trim() == "")
                    {
                        MessageBox.Show("Bạn chưa nhập họ sinh viên!");
                        gvSinhVien.FocusedRowHandle = i;
                        return;
                    }
                    if (gvSinhVien.GetRowCellValue(i, "TEN").ToString().Trim() == "")
                    {
                        MessageBox.Show("Bạn chưa nhập tên sinh viên!");
                        gvSinhVien.FocusedRowHandle = i;
                        return;
                    }

                    int dem = 0;
                    for (int j = 0; j < bdsToanSV.Count; j++)//Kiểm tra sinh viên trong khoa
                    {
                       
                        if (gvSinhVien.GetRowCellValue(i, "MASV").ToString().Trim() == ((DataRowView)bdsToanSV[j])["MASV"].ToString().Trim())
                        {

                            dem++;
                        }
                    }

                  
                        if (dem == 2)
                        {
                            MessageBox.Show("Mã sinh viên bị trùng!");
                           gvSinhVien.FocusedRowHandle = i;
                            return;
                        }
                    
                    // Kiểm tra sinh viên khác khoa
                    String strLenh =
                 " DECLARE @ret int" +
                 " EXEC dbo.sp_KiemTraSinhVien" +
                 " @masv = '" + gvSinhVien.GetRowCellValue(i, "MASV").ToString().Trim() + "'," +
                 " @ret = @ret OUTPUT" +
                 " SELECT @ret";

                    Program.myReader = Program.ExecSqlDataReader(strLenh);

                    if (Program.myReader != null && Program.myReader.HasRows)
                    {
                        while (Program.myReader.Read())
                        {
                            int ret = Program.myReader.GetInt32(0);

                            if (ret == 2)// Kiểm tra trùng mã sinh viên ở khoa khác
                            {
                                Program.myReader.Close();
                                MessageBox.Show("Mã sinh viên đã trùng ở khoa khác !!", "Đóng");
                                return;
                            }
                        }

                    }
                    Program.myReader.Close();
                }

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
            //Thuộc tính các nút quay về như cũ
            tsThem.Enabled = tsXoa.Enabled = tsChuyenLop.Enabled = true;
            btnXoa.Enabled = btnThem.Enabled = btnSua.Enabled = btnLuuSQL.Enabled = btnPhucHoi.Enabled = true;
            gcLop.Enabled = true;
            kiemTraThemSV = false;
            kiemTraThayDoi = false;
        }

        private void tsChuyenLop_Click(object sender, EventArgs e)
        {
            viTri = bdsSinhVien.Position;
            bdsSinhVien.CancelEdit();
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            bdsSinhVien.Position = viTri;
            maSV = ((DataRowView)bdsSinhVien[viTri])["MASV"].ToString();
            frmChuyenLop frmChuyen = new frmChuyenLop(maSV);
            frmChuyen.Show();
        }

        private void tsPhucHoi_Click(object sender, EventArgs e)
        {
            bdsSinhVien.CancelEdit();
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            tsThem.Enabled = tsXoa.Enabled = tsChuyenLop.Enabled = true;
            btnXoa.Enabled = btnThem.Enabled = btnSua.Enabled = btnLuuSQL.Enabled = btnPhucHoi.Enabled = true;
            bdsSinhVien.Position = viTri;
            gcLop.Enabled = true;
            kiemTraThemSV = false ;
           
        }

        private void tsXoa_Click(object sender, EventArgs e)
        {
            String masv = "";
           
            if (((DataRowView)bdsSinhVien[bdsSinhVien.Position])["MASV"].ToString() == "True")
            {
                MessageBox.Show("Sinh viên này đã nghỉ học!", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsSinhVien.Count == 0)
            {
                MessageBox.Show("Lớp không có sinh viên để xóa!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thực sự muốn xóa Sinh viên này??", "Đánh dấu nghỉ học?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    masv = (((DataRowView)bdsSinhVien[bdsSinhVien.Position])["MASV"].ToString());
                    ((DataRowView)bdsSinhVien[bdsSinhVien.Position])["NGHIHOC"] = true;
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
          
        }
    }
}
