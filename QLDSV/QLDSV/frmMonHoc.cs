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
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void MONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mONHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FrmMonHoc_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.DS.MONHOC);

        }



        private void WindowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            String option = null;

            option = e.Button.Properties.Caption;

            switch (option)
            {
                case "New":
                    this.mONHOCBindingSource.AddNew();
                    break;

                case "SQL Save":
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn lưu vào cơ sở dữ liệu ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            this.mONHOCBindingSource.EndEdit();
                            this.mONHOCBindingSource.ResetCurrentItem();
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
                    break;
                case "Delete":
                    DialogResult result1 = MessageBox.Show("Bạn chắc chắn muốn xóa môn " + tENMHTextEdit.Text + " ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    switch (result1)
                    {
                        case DialogResult.Yes:
                            this.mONHOCBindingSource.RemoveCurrent();
                            this.mONHOCBindingSource.MoveFirst();
                            break;
                        case DialogResult.No:
                            break;
                    }
                    break;
            }
        }
    }
}