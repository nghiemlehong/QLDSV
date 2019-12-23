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
    public partial class frmNhapDiem : DevExpress.XtraEditors.XtraForm
    {
        public frmNhapDiem()
        {
            InitializeComponent();
        }
        Boolean nhapDiem = false;
        int ret = -1;
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
                      
                        this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                       
                        this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.lOPTableAdapter.Fill(this.dS.LOP);

                        this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.sINHVIENTableAdapter.FillBy3(this.dS.SINHVIEN);

                        Program.mBoPhan = cmbBoPhan.SelectedIndex;

                    }
                    
                }
            }
        }

        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            dS.EnforceConstraints = false;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.FillBy3(this.dS.SINHVIEN);

            cmbBoPhan.DataSource = Program.bds_DSPM;
            cmbBoPhan.DisplayMember = "TENCN";
            cmbBoPhan.ValueMember = "TENSERVER";
            cmbBoPhan.SelectedIndex = Program.mBoPhan;
            gcNhapDiem.Visible = false;
            gbGhiDiem.Enabled = false;
            if (Program.mGroup == "PGV")
            {
                cmbBoPhan.Enabled = true;
                //bar2.Visible = false;
            }
            else cmbBoPhan.Enabled = false;
            IDictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "1");
            dict.Add(2, "2");
            cmbLanThi.DataSource = new BindingSource(dict, null);
            cmbLanThi.DisplayMember = "Value";
            cmbLanThi.ValueMember = "Key";

        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void tENLOPLabel_Click(object sender, EventArgs e)
        {

        }

        private void tENLOPTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
           if(bdsSinhVien.Count==0)
            {
                MessageBox.Show("Lớp hiện tại chưa có sinh viên !", "", MessageBoxButtons.OK);
                return;
            }
           
            String strLenh1 =
                "DECLARE @RET int " +
                "EXEC  dbo.sp_KiemTraNhapDiem " +
                "@MALOP = N'" + cmbMaLop.SelectedValue + "', " +
                "@MAMH = N'" + cmbMaMonHoc.SelectedValue + "', " +
                "@LAN = " + cmbLanThi.SelectedValue + ", " +
                "@RET = @RET OUTPUT " +
                "SELECT  @RET as N'@RET' ";

            String strLenh =
              "EXEC dbo.sp_GetValueDiem @MALOP = '" + cmbMaLop.SelectedValue + "'," +
              "@MAMH = '" + cmbMaMonHoc.SelectedValue + "'," +
              "@LAN =" + cmbLanThi.SelectedValue;

          

            Program.myReader = Program.ExecSqlDataReader(strLenh1);
            

            if (Program.myReader != null && Program.myReader.HasRows)
            {
                while (Program.myReader.Read())
                {
                     ret = Program.myReader.GetInt32(0);
                }
            }
            Program.myReader.Close();

            if (cmbLanThi.SelectedValue.ToString().Equals("1") == true)
            {
               
                   if (ret == 0)
                    {
                        // Nhập điểm lần 1
                        gcNhapDiem.Visible = true;
                        nhapDiem = true;
                        Program.myTable = Program.ExecSqlDataTable(strLenh);
                        gcNhapDiem.DataSource = Program.myTable;
                    }
                   else if (ret == 3)
                    {
                        //Sửa điểm
                        gcNhapDiem.Visible = true;
                        Program.myTable = Program.ExecSqlDataTable(strLenh);
                        gcNhapDiem.DataSource = Program.myTable;
                    }
                
             

            }
            else if (cmbLanThi.SelectedValue.ToString().Equals("2") == true)
            {
                if (ret == 0)
                {
                    // Nhập điểm lần 2
                    gcNhapDiem.Visible = true;
                    nhapDiem = true;
                    Program.myTable = Program.ExecSqlDataTable(strLenh);
                    gcNhapDiem.DataSource = Program.myTable;
                }
                else if (ret == 2)
                {
                    MessageBox.Show("Chưa nhập điểm lần 1 !", "", MessageBoxButtons.OK);
                    return;

                }
                if (ret == 3)
                {
                    // Sửa điểm
                    gcNhapDiem.Visible = true;
                    Program.myTable = Program.ExecSqlDataTable(strLenh);
                    gcNhapDiem.DataSource = Program.myTable;
                }
            }
            cmbBoPhan.Enabled = false;
            gbNhapDiem.Enabled = false;
            gbGhiDiem.Enabled = true;

        }




        private void btnHuy_Click(object sender, EventArgs e)
        {
            gbNhapDiem.Enabled = true;
            gbGhiDiem.Enabled = false ;
            gcNhapDiem.Visible = false;
            if (Program.mGroup == "PGV")
            {
                cmbBoPhan.Enabled = true;
            }
            else cmbBoPhan.Enabled = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            for(int i =0; i<bdsSinhVien.Count;i++)
            {
            //    float diem = float.Parse(gvNhapDiem.GetRowCellValue(i,"DIEM").ToString().Trim());
                if (gvNhapDiem.GetRowCellValue(i, "DIEM").ToString().Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập điểm cho sinh viên này!\n" + "Mã SV: " + gvNhapDiem.GetRowCellValue(i, "MASV").ToString().Trim());
                    gvNhapDiem.FocusedRowHandle = i;
                    return;
                }
                if (float.Parse(gvNhapDiem.GetRowCellValue(i, "DIEM").ToString().Trim()) > 10)
                {
                    MessageBox.Show("Điểm không được lớn hơn 10!\n" + "Mã SV: " + gvNhapDiem.GetRowCellValue(i, "MASV").ToString().Trim());
                    gvNhapDiem.FocusedRowHandle = i;
                    return;
                }
                if (float.Parse(gvNhapDiem.GetRowCellValue(i, "DIEM").ToString().Trim()) < 0)
                {
                    MessageBox.Show("Điểm phải lớn hơn hoặc bằng 0!\n" + "Mã SV: " + gvNhapDiem.GetRowCellValue(i, "MASV").ToString().Trim());
                    gvNhapDiem.FocusedRowHandle = i;
                    return;
                }
            }
            ////////////////
            string strLenh = "";
            for (int i = 0; i < bdsSinhVien.Count; i++)
            {
                if(nhapDiem == true)
                strLenh = "INSERT INTO dbo.DIEM (MASV,MAMH,LAN,DIEM) VALUES (@MASV,@MAMH,@LAN,@DIEM)";
                else
                {
                    strLenh = "UPDATE dbo.DIEM SET DIEM = @DIEM WHERE MASV = @MASV and MAMH = @MAMH and LAN = @LAN";
                }
                using (SqlConnection sqlConn = new SqlConnection(Program.connstr))
                using (SqlCommand sqlcmd = new SqlCommand(strLenh, sqlConn))
                {
                    sqlcmd.Parameters.AddWithValue("@MASV", gvNhapDiem.GetRowCellValue(i, "MASV").ToString().Trim());
                    sqlcmd.Parameters.AddWithValue("@MAMH", cmbMaMonHoc.SelectedValue.ToString());
                    sqlcmd.Parameters.AddWithValue("@LAN", int.Parse(cmbLanThi.SelectedValue.ToString()));
                    sqlcmd.Parameters.AddWithValue("@DIEM", float.Parse(gvNhapDiem.GetRowCellValue(i, "DIEM").ToString().Trim()));
                    sqlConn.Open();
                    try
                    {
                        sqlcmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi ghi điểm! " + ex.Message, "", MessageBoxButtons.OK);
                        sqlConn.Close();
                        return;
                    }
                    sqlConn.Close();
                }
            }
            MessageBox.Show("Ghi điểm thành công!", "", MessageBoxButtons.OK);

            nhapDiem = false;
            gbNhapDiem.Enabled = true;
            gbGhiDiem.Enabled = false;
            gcNhapDiem.Visible = false;
            if (Program.mGroup == "PGV")
            {
                cmbBoPhan.Enabled = true;
            }
            else cmbBoPhan.Enabled = false;
        }
    }
}
