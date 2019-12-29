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
    public partial class frmDSHocPhi : DevExpress.XtraEditors.XtraForm
    {
        public frmDSHocPhi()
        {
            InitializeComponent();
        }

        private void frmDSHocPhi_Load(object sender, EventArgs e)
        {
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
        }
    }
}