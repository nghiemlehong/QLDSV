using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLVTPT_D16ISMT
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            string chuoiketnoi = "Data Source=THU-PC\\SERVER1;Initial Catalog=QLVT_DATHANG;Integrated Security=True";
            Program.conn.ConnectionString = chuoiketnoi ;
            Program.conn.Open ();
            DataTable dt = new DataTable() ;
            dt=Program.ExecSqlDataTable ("SELECT * FROM V_DSPM");
            Program.bds_dspm.DataSource  =dt; 
            cmbCN.DataSource = dt;
            cmbCN.DisplayMember ="TENPM";
            cmbCN.ValueMember ="TENSERVER";
            cmbCN.SelectedIndex = -1;

        }

        private void cmbCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbCN.SelectedValue.ToString();
                
            }
            catch (Exception) { };
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "" || txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Login name và mật mã không được trống", "", MessageBoxButtons.OK);
                return;
            }
            Program.mlogin = txtLogin.Text; Program.password = txtPass.Text;
            if (Program.KetNoi() == 0) return;

            Program.mChinhanh = cmbCN.SelectedIndex;
           
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            string strLenh = "EXEC SP_THONGTINDANGNHAP '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();


            Program.username = Program.myReader.GetString(0);     // Lay user name
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();
            MessageBox.Show("Nhan vien - Nhom : "+Program.mHoten + " - " + Program.mGroup , "", MessageBoxButtons.OK);
      
        }
    }
}
