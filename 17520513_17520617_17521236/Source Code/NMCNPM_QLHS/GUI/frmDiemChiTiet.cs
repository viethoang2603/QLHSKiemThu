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
    public partial class frmDiemChiTiet : DevExpress.XtraEditors.XtraForm
    {

        #region -Constructor-

        public frmDiemChiTiet()
        {
            InitializeComponent();
        }
        public frmDiemChiTiet(string maHS, string maHocKy, string maNamHoc)
        {
            InitializeComponent();
            dgvDiem.OptionsBehavior.ReadOnly = true;
            cboHocSinh.ReadOnly = true;
            cboNamHoc.ReadOnly = true;
            cboHocKy.ReadOnly = true;
            cboHocSinh.EditValue = maHS;
            cboHocKy.EditValue = maHocKy;
            cboNamHoc.EditValue = maNamHoc;
        }

        #endregion -Constructor-

        #region -Events-

        #region -Form-

        private void frmNhapDiemChiTiet_Load(object sender, EventArgs e)
        {
            load_cboHocSinh();
            load_cboHocKy();
            load_BangDiem();
        }

        #endregion -Form-

        #region -comBoBox_EditValueChanged-

        private void cboHocSinh_EditValueChanged(object sender, EventArgs e)
        {
            load_cboNamHoc();
            load_BangDiem();
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            load_BangDiem();
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            load_BangDiem();
        }

        #endregion -comBoBox_ValueChanged-

        #endregion -Events-

        #region -Methods-

        #region -Load-

        private void load_BangDiem()
        {
            if (cboHocSinh.Text != "" && cboHocKy.Text != "" && cboNamHoc.Text != "")
            {
                string maHS = cboHocSinh.EditValue.ToString();
                string maHocKy = cboHocKy.EditValue.ToString();
                string maNamHoc = cboNamHoc.EditValue.ToString();
                bindingSourceDiemChiTiet.DataSource = HOCTAP_BUS.LayDiemChiTietHocSinh(maHS, maHocKy, maNamHoc);
            }
        }

        private void load_cboHocSinh()
        {
            cboHocSinh.Properties.DataSource = HOCSINH_BUS.LayDSHocSinhDaPhanLop();
            cboHocSinh.Properties.DisplayMember = "HOTEN";
            cboHocSinh.Properties.ValueMember = "MAHS";
        }

        private void load_cboHocKy()
        {
            cboHocKy.Properties.DataSource = HOCKY_BUS.LayTatCaHocKy();
            cboHocKy.Properties.DisplayMember = "TENHOCKY";
            cboHocKy.Properties.ValueMember = "MAHK";
        }

        private void load_cboNamHoc()
        {
            string maHS = "";
            if (cboHocSinh.EditValue != null)
                maHS = cboHocSinh.EditValue.ToString();
            cboNamHoc.Properties.DataSource = NAMHOC_BUS.LayNamHocTheoMaHS(maHS);
            cboNamHoc.Properties.DisplayMember = "TENNAMHOC";
            cboNamHoc.Properties.ValueMember = "MANAMHOC";
        }

        #endregion -Load-

        #endregion -Methods-

    }
}