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
    public partial class frmHocPhi : DevExpress.XtraEditors.XtraForm
    {

        Boolean checkAdd = false, checkAdd1 = false;
        public frmHocPhi()
        {
            InitializeComponent();
        }

        private void SINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sINHVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS1);

        }

        private void FrmHocPhi_Load(object sender, EventArgs e)
        {
            DS1.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'DS1.HOCPHI' table. You can move, or remove it, as needed.
            this.hOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.hOCPHITableAdapter.Fill(this.DS1.HOCPHI);


            // TODO: This line of code loads data into the 'dS1.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.DS1.SINHVIEN);

            IDictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "1");
            dict.Add(2, "2");
            dict.Add(3, "3");
            cmbHocKy.DataSource = new BindingSource(dict, null);
            cmbHocKy.DisplayMember = "Value";
            cmbHocKy.ValueMember = "Key";



            int year = DateTime.Now.Year;

            IDictionary<int, string> dict1 = new Dictionary<int, string>();
            for (int i = 4; i >= 0; i--)
            {
                dict1.Add(i, year - i + " - " + (year - i + 1));
            }

            cmbNienKhoa.DataSource = new BindingSource(dict1, null);
            cmbNienKhoa.DisplayMember = "Value";
            cmbNienKhoa.ValueMember = "Key";


            panelSearch.Dock = DockStyle.Top;

        }

        private void BtnSearch_Click(object sender, EventArgs e)
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
                            String kt = hOCPHIBindingSource.Count.ToString();
                            if (kt == "0")
                            {
                                hOCPHIBindingSource.AddNew();
                                checkAdd = true;
                                btnThem.Enabled = false;
                            }
                            gvNhap.Visible = true;
                            panelSearch.Visible = false;
                            lbHoTen.Text = "Họ và tên : " + gvData.GetRowCellValue(foundIndex, "HO").ToString().Trim() + " " + gvData.GetRowCellValue(foundIndex, "TEN").ToString();
                            lbMaLop.Text = "Mã lớp : " + gvData.GetRowCellValue(foundIndex, "MALOP").ToString();
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

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            if (checkAdd)
            {
                hOCPHIBindingSource.RemoveCurrent();
                checkAdd = false;              
            }
            else
            {
                hOCPHIBindingSource.CancelEdit();
                checkAdd = false;               
            }
            gvNhap.Visible = false;
            panelSearch.Visible = true;
            txtSearch.Focus();
            btnSave.Enabled = false;
            btnThem.Enabled = true;
            panelHocPhi.Enabled = true;

        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                sINHVIENBindingSource.Filter = "MASV LIKE '%" + txtSearch.Text + "%'";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn lưu vào cơ sở dữ liệu ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    this.hOCPHIBindingSource.EndEdit();
                    this.hOCPHIBindingSource.ResetCurrentItem();
                    try
                    {
                        this.hOCPHITableAdapter.Update(this.DS1.HOCPHI);
                        MessageBox.Show("Đã lưu dữ liệu vào cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gvNhap.Visible = false;
                        panelSearch.Visible = true;
                        txtSearch.Focus();
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

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            if (cmbNienKhoa.SelectedValue == null)
            {
                MessageBox.Show("Chưa chọn niên khóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbNienKhoa.Focus();
                return;
            }
            if (cmbHocKy.SelectedValue == null)
            {
                MessageBox.Show("Chưa chọn học kì", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbHocKy.Focus();
                return;
            }
            if (txtHocPhi.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập học phí", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHocPhi.Focus();
                return;
            }
            if (txtTienDaDong.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập số tiền đã đóng ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTienDaDong.Focus();
                return;
            }
            if( int.Parse(txtTienDaDong.Text) > int.Parse(txtHocPhi.Text))
            {
                MessageBox.Show("Tiền đã đóng phải nhỏ hơn học phí ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTienDaDong.Focus();
                return;
            }
            try
            {
                int hp = int.Parse(txtHocPhi.Text);
                if (hp < 0)
                {
                    MessageBox.Show("HỌC PHÍ không được âm!", "", MessageBoxButtons.OK);
                    txtHocPhi.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                txtHocPhi.Focus();
            }
            try
            {
                int hp = int.Parse(txtTienDaDong.Text);
                if (hp < 0)
                {
                    MessageBox.Show("Tiền không được âm!", "", MessageBoxButtons.OK);
                    txtTienDaDong.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                txtTienDaDong.Focus();
            }
            hOCPHIBindingSource.EndEdit();
            MessageBox.Show("Đã cập nhật dữ liệu học phí", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnSave.Enabled = true;
            btnThem.Enabled = true;
            panelHocPhi.Enabled = true;
            btnHuy.Visible = false;
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            if (checkAdd1)
            {
                hOCPHIBindingSource.RemoveCurrent();
                checkAdd1 = false;
                panelHocPhi.Enabled = true;
                btnThem.Enabled = true;
                btnHuy.Visible = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            hOCPHIBindingSource.AddNew();
            btnThem.Enabled = false;
            panelHocPhi.Enabled = false;
            checkAdd1 = true;
            btnHuy.Visible = true;
            cmbHocKy.SelectedValue = cmbNienKhoa.SelectedValue = "";
        }
    }
}