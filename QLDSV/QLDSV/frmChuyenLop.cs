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
    public partial class frmChuyenLop : DevExpress.XtraEditors.XtraForm
    {
        String maSVChuyenLop = "";
        public frmChuyenLop(String maSV)
        {
            this.maSVChuyenLop = maSV;
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSVDataSet);

        }

        private void frmChuyenLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.qLDSVDataSet.SINHVIEN);
            // TODO: This line of code loads data into the 'qLDSVDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLDSVDataSet.LOP);
            Console.WriteLine(maSVChuyenLop);
            


        }

        private void btnChuyenLop_Click(object sender, EventArgs e)
        {
         

            SqlCommand command;
            SqlDataReader dataReader;
            String strLenh = "";
            string MASV = "";
            string MALOP = "";
            SqlDataAdapter adapter = new SqlDataAdapter();
            using (SqlConnection connection = new SqlConnection(Program.connstr))
            {
                connection.Open();
                // Đưa dữ liệu vào sinh viên tạm - sau đó sửa lại mã sinh viên và mã lớp
                strLenh = string.Format("SELECT MASV,HO,TEN,MALOP,PHAI,NGAYSINH,NOISINH,DIACHI,GHICHU,NGHIHOC FROM dbo.SINHVIEN WHERE MASV = '" +maSVChuyenLop + "'");
                command = new SqlCommand(strLenh, connection);
                dataReader = command.ExecuteReader();
                SinhVien sinhvien = new SinhVien();
                while (dataReader.Read())
                {
                    sinhvien.setMASV(dataReader.GetValue(0).ToString());
                    sinhvien.setHO(dataReader.GetValue(1).ToString());
                    sinhvien.setTEN(dataReader.GetValue(2).ToString());
                    sinhvien.setMALOP(dataReader.GetValue(3).ToString());
                    sinhvien.setPHAI(dataReader.GetValue(4).ToString());
                    sinhvien.setNGAYSINH(dataReader.GetValue(5).ToString());
                    sinhvien.setNOISINH(dataReader.GetValue(6).ToString());
                    sinhvien.setDIACHI(dataReader.GetValue(7).ToString());
                    sinhvien.setGHICHU(dataReader.GetValue(8).ToString());
                    sinhvien.setNGHIHOC(dataReader.GetValue(9).ToString());
                    
                } 
               // MessageBox.Show(sinhvien.ToStringSinhVien());
                  // TODO : Must Close dataReader
                dataReader.Close();

                strLenh = string.Format("SELECT MALOP FROM dbo.LOP WHERE MALOP = '" + txtMaLopChuyen.Text.Trim() +"'");// MALOP chuyen den khac khoa
               
                command = new SqlCommand(strLenh, connection);
                command.CommandType = CommandType.Text;
                try
                {
                    MALOP = (String)command.ExecuteScalar();
                }
                catch { }
             
                
                if (MALOP != null) // TODO : Chuyển Lớp Cùng Khoa
                {
                    //MessageBox.Show("LỚP TỒN TẠI Ở SITE HIỆN TẠI");
                    // TODO : Cập nhập mã lớp cho sinh viên ở chính site hiện tại
                    strLenh = "Update SINHVIEN SET MALOP='" + txtMaLopChuyen.Text.Trim() + "' WHERE MASV='" + sinhvien.getMASV() + "'";
                    command = new SqlCommand(strLenh, connection);
                    adapter.UpdateCommand = new SqlCommand(strLenh, connection);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    MessageBox.Show("Chuyển Sinh Viên Cùng Khoa Thành Công", "Info", MessageBoxButtons.OK);
                    return;
                }
                else // Lên site chủ tìm mã lớp 
                {
                   
                    if (txtMaSVMoi.Text.Trim() == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mã sinh viên mới ! ");
                        return;
                    }
                    for (int i = 0; i < bdsSinhVien.Count; i++)
                    {

                        if (txtMaSVMoi.Text.Trim() == ((DataRowView)bdsSinhVien[i])["MASV"].ToString().Trim())
                        {
                            MessageBox.Show("Mã sinh viên đã tồn tại !");
                            return;

                        }
                    }
                    strLenh = "SELECT MALOP FROM LINK0.QLDSV.dbo.LOP WHERE MALOP = '" + txtMaLopChuyen.Text.Trim() + "'";// giả sử D16CQVT1 là mã lớp chuyển tới
                    command = new SqlCommand(strLenh, connection);
                    command.CommandType = CommandType.Text;
                    try
                    {
                        MALOP = (String)command.ExecuteScalar();
                    }
                    catch { }

                    if (MALOP == null) // INFO : Mã lớp không tồn tại trong Cơ Sở Dữ Liệu
                    {
                        MessageBox.Show("Mã Lớp Này Không Tồn Tại Trong Cơ Sở Dữ Liệu", "INFO", MessageBoxButtons.OK);
                       
                        return;
                    }
                    if (MALOP != null) // TODO : MALOP tồn tại - Cập nhập Mã Sinh Viên mới và thay đổi mã lớp cho sinh viên sắp chuyển lớp
                    {

                        // TODO : Cấp mã mới
                        //string major = this.txtMaLopChuyenDen.Text.ToString().Substring(6, 2);
                        //string nienkhoa = MALOP.Substring(1, 2);
                        //string numcode = "001";

                      

                        // TODO : Cập nhập trạng thái học của sinh viên đó tại khoa ban đầu thành nghỉ học
                        strLenh = "Update SINHVIEN SET NGHIHOC=1 WHERE MASV='" + maSVChuyenLop + "'";
                        command = new SqlCommand(strLenh, connection);
                        adapter.UpdateCommand = new SqlCommand(strLenh, connection);
                        adapter.UpdateCommand.ExecuteNonQuery();

                        // TODO : Đưa thông tin sinh viên qua khoa mới và tạo (Sử dụng LINK0 để về site chủ làm việc)
                        strLenh = "INSERT INTO LINK0.QLDSV.dbo.SINHVIEN (MASV,HO,TEN,MALOP,PHAI,NGAYSINH,NOISINH,DIACHI,GHICHU,NGHIHOC) \n"
                            + "VALUES  ('" + txtMaSVMoi.Text.Trim() + "',N'" + sinhvien.getHO() + "',N'" + sinhvien.getTEN() + "','" + txtMaLopChuyen.Text.Trim() + "','" + sinhvien.getPHAI() + "','" + sinhvien.getNGAYSINH() + "',N'" + sinhvien.getNOISINH() + "',N'" + sinhvien.getDIACHI() + "',NULL, 0)";

                        command = new SqlCommand(strLenh, connection);
                        adapter.InsertCommand = new SqlCommand(strLenh, connection);
                        adapter.InsertCommand.ExecuteNonQuery();

                        MessageBox.Show("Chuyển Sinh Viên Qua Khoa Khác Thành Công", "INFO", MessageBoxButtons.OK);

                        command.Dispose();
                        connection.Close();

                    }
                }
                dataReader.Close();
                command.Dispose();
                connection.Close();


            }//end using





        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        class SinhVien
        {
            private string MASV;
            private string HO;
            private string TEN;
            private string MALOP;
            private string PHAI;
            private string NGAYSINH;
            private string NOISINH;
            private string DIACHI;
            private string GHICHU;
            private string NGHIHOC;

            public SinhVien()
            {

            }

            public void setMASV(string MASV)
            {
                this.MASV = MASV;
            }
            public void setHO(string HO)
            {
                this.HO = HO;
            }
            public void setTEN(string TEN)
            {
                this.TEN = TEN;
            }
            public void setMALOP(string MALOP)
            {
                this.MALOP = MALOP;
            }
            public void setPHAI(string PHAI)
            {
                this.PHAI = PHAI;
            }
            public void setNGAYSINH(string NGAYSINH)
            {
                this.NGAYSINH = NGAYSINH;
            }
            public void setNOISINH(string NOISINH)
            {
                this.NOISINH = NOISINH;
            }
            public void setDIACHI(string DIACHI)
            {
                this.DIACHI = DIACHI;
            }
            public void setGHICHU(string GHICHU)
            {
                this.GHICHU = GHICHU;
            }
            public void setNGHIHOC(string NGHIHOC)
            {
                this.NGHIHOC = NGHIHOC;
            }

            public string getMASV()
            {
                return MASV;
            }
            public string getHO()
            {
                return HO;
            }
            public string getTEN()
            {
                return TEN;
            }
            public string getMALOP()
            {
                return MALOP;
            }
            public string getPHAI()
            {
                return PHAI;
            }
            public string getNGAYSINH()
            {
                return NGAYSINH;
            }
            public string getNOISINH()
            {
                return NOISINH;
            }
            public string getDIACHI()
            {
                return DIACHI;
            }
            public string getGHICHU()
            {
                return GHICHU;
            }
            public string getNGHIHOC()
            {
                return NGHIHOC;
            }


            public string ToStringSinhVien()
            {
                return MASV + "-" + HO + "-" + TEN + "-" + MALOP + "-" + PHAI + "-" + NGAYSINH + "-" + NOISINH + "-" + DIACHI + "-" + GHICHU + "-" + NGHIHOC;
            }

        }

    }
}
