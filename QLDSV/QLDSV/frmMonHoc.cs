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

namespace QLDSV
{
    public partial class frmMonHoc : DevExpress.XtraEditors.XtraForm
    {
        int viTri = 0;
        Boolean checkAdd = false;
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void MONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FrmMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.DIEM' table. You can move, or remove it, as needed.
        
            DS.EnforceConstraints = false;
            this.dIEMTableAdapter.Fill(this.DS.DIEM);
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.DS.MONHOC);
            gbMonHoc.Enabled = false;

        }



        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsMonHoc.Position;
            bdsMonHoc.AddNew();
            checkAdd = true;
            btnXoa.Enabled = btnThem.Enabled = btnSua.Enabled =btnLuuSQL.Enabled= btnPhucHoi.Enabled = false;
            gcMonHoc.Enabled = false;
            gbMonHoc.Enabled = true;
            txtMaMonHoc.Focus();
        }
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsMonHoc.Position;
            btnXoa.Enabled = btnThem.Enabled = btnSua.Enabled = btnLuuSQL.Enabled = btnPhucHoi.Enabled = false;
            gcMonHoc.Enabled = false;
            gbMonHoc.Enabled = true;
            txtMaMonHoc.Focus();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            viTri = bdsMonHoc.Position;
            if (txtMaMonHoc.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtMaMonHoc.Focus();
                return;
            }
            if (txtTenMonHoc.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtTenMonHoc.Focus();
                return;
            }

            int dem1 = 0, dem2 = 0;
            for (int i = 0; i < bdsMonHoc.Count; i++)
            {
                if (txtMaMonHoc.Text.Trim() == ((DataRowView)bdsMonHoc[i])["MAMH"].ToString().Trim())
                {
                    dem1++;

                }
                if (txtTenMonHoc.Text.Trim() == ((DataRowView)bdsMonHoc[i])["TENMH"].ToString().Trim())
                    dem2++;
            }
            if (dem1 == 2)
            {
                MessageBox.Show("Mã môn học bị trùng!", "", MessageBoxButtons.OK);
                txtMaMonHoc.Focus();
                return;
            }
            if (dem2 == 2)
            {
                MessageBox.Show("Tên môn học bị trùng!", "", MessageBoxButtons.OK);
                txtTenMonHoc.Focus();
                return;
            }
            bdsMonHoc.EndEdit();
            btnXoa.Enabled = btnThem.Enabled = btnSua.Enabled = btnLuuSQL.Enabled = btnPhucHoi.Enabled = true;
            gcMonHoc.Enabled = true;
            gbMonHoc.Enabled = false;
        }
     
        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (checkAdd == true)
            {
                bdsMonHoc.RemoveCurrent();
                bdsMonHoc.CancelEdit();
                checkAdd = false;
            }
            else
            {
                bdsMonHoc.CancelEdit();
            }
            gcMonHoc.Enabled = true;
            gbMonHoc.Enabled = false;
            btnXoa.Enabled = btnThem.Enabled = btnSua.Enabled = btnLuuSQL.Enabled = btnPhucHoi.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String mamh = "";
          
            if (bdsDiem.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học này vì môn này sinh viên đã có điểm.", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thực sự muốn xóa MÔN HỌC này??", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
                try
                {
                    mamh = (((DataRowView)bdsMonHoc[bdsMonHoc.Position])["MAMH"].ToString());
                    bdsMonHoc.RemoveCurrent();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa Lớp.\nBạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.mONHOCTableAdapter.Fill(this.DS.MONHOC);
                    bdsMonHoc.Position = bdsMonHoc.Find("MAMH", mamh);
                    return;
                }
            if (bdsMonHoc.Count == 0)
            {
                btnXoa.Enabled = false;
            }
        }

        private void btnLuuSQL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn lưu vào cơ sở dữ liệu ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    this.bdsMonHoc.EndEdit();
                    this.bdsMonHoc.ResetCurrentItem();
                    try
                    {
                        this.mONHOCTableAdapter.Update(this.DS.MONHOC);
                        MessageBox.Show("Đã lưu dữ liệu vào cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMonHoc.CancelEdit();
            bdsMonHoc.Position = viTri;
            this.mONHOCTableAdapter.Fill(this.DS.MONHOC);
         
        }
    }
}