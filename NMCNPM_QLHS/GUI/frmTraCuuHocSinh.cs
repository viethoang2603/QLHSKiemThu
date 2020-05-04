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
using NMCNPM_QLHS.BUS;

namespace NMCNPM_QLHS.GUI
{
    public partial class frmTraCuuHocSinh : DevExpress.XtraEditors.XtraForm
    {
        #region -Constructor-

        public frmTraCuuHocSinh()
        {
            InitializeComponent();
        }

        #endregion

        #region -Events-

        private void frmTraCuuHocSinh_Load(object sender, EventArgs e)
        {
            load_cboHocSinh();
        }

        private void cboSearchHocSinh_EditValueChanged(object sender, EventArgs e)
        {
            load_QuaTrinhHoc();
        }

        #endregion

        #region -Methods-

        private void load_cboHocSinh()
        {
            cboSearchHocSinh.Properties.DataSource = HOCSINH_BUS.LayTatCaHocSinh();
            cboSearchHocSinh.Properties.DisplayMember = "HOTEN";
            cboSearchHocSinh.Properties.ValueMember = "MAHS";
        }

        private void load_QuaTrinhHoc()
        {
            if (cboSearchHocSinh.Text != "")
            {
                string maHS = cboSearchHocSinh.EditValue.ToString();
                bindingSourceQuaTrinhHoc.DataSource = QUATRINHHOC_BUS.LayQuaTrinhHocCuaHocSinh(maHS);
            }
        }

        #endregion -Methods-

    }
}