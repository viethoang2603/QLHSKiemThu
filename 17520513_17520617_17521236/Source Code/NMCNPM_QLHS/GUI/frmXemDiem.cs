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
using DevExpress.XtraGrid.Views.Base;

namespace NMCNPM_QLHS.GUI
{
    public partial class frmXemDiem : DevExpress.XtraEditors.XtraForm
    {
        public frmXemDiem()
        {
            InitializeComponent();
            Permissions();
        }

        #region -Phân quyền-

        public void Permissions()
        {
            switch (NGUOIDUNG_BUS.LayMaQuyen(CurrentUser.Code))
            {
                case "LND002":      // Giao diện đăng nhập với quyền BGH
                    IsBGH();
                    break;
                case "LND003":      // Giao diện đăng nhập với quyền GiaoVu
                    IsGiaoVu();
                    break;
                case "LND004":      // Giao diện đăng nhập với quyền GiaoVien
                    IsGiaoVien();
                    break;
                default:
                    Default();
                    break;
            }
        }

        public void Default()
        {
            // True
            // Enable các button
            // False 
            // Disable các button
            dockPanelChucNang.Visible = true;
        }

        public void IsBGH()
        {
            // Enable, Disable các button
        }

        public void IsGiaoVien()
        {
            // Enable, Disable các button
        }

        public void IsGiaoVu()
        {
            // Enable, Disable các button
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in ((ColumnView)gridDiemControl.Views[0]).Columns) {
                col.OptionsColumn.AllowEdit = false;
            }
        }

        #endregion -Phân quyền-

        private void comBoBox_EditValueChanged(object sender, EventArgs e)
        {
            load_BangDiem();
        }

        #region -Methods-

        #region -Load-

        private void load_cboNamHoc()
        {
            cboNamHoc.Properties.DataSource = NAMHOC_BUS.LayTatCaNamHoc();
            cboNamHoc.Properties.DisplayMember = "TENNAMHOC";
            cboNamHoc.Properties.ValueMember = "MANAMHOC";
        }
        private void load_cboHocKy()
        {
            cboHocKy.Properties.DataSource = HOCKY_BUS.LayTatCaHocKy();
            cboHocKy.Properties.DisplayMember = "TENHOCKY";
            cboHocKy.Properties.ValueMember = "MAHK";
        }
        private void load_cboLop()
        {
            if (cboNamHoc.Text != "")
            {
                cboLop.Properties.DataSource = LOP_BUS.LayLopTheoNamHoc(cboNamHoc.EditValue.ToString());
                cboLop.Properties.DisplayMember = "TENLOP";
                cboLop.Properties.ValueMember = "MALOP";
                cboLop.EditValue = null;
            }
            else
                cboLop.Properties.DataSource = null;
        }
        private void load_cboMonHoc()
        {
            cboMonHoc.Properties.DataSource = MONHOC_BUS.LayTatCaMonHoc();
            cboMonHoc.Properties.DisplayMember = "TENMONHOC";
            cboMonHoc.Properties.ValueMember = "MAMONHOC";
        }

        private void load_BangDiem()
        {
            if (cboLop.Text != "" && cboMonHoc.Text != "" && cboHocKy.Text != "" && cboNamHoc.Text != "")
            {
                string maLop = cboLop.EditValue.ToString();
                string maMonHoc = cboMonHoc.EditValue.ToString();
                string maHocKy = cboHocKy.EditValue.ToString();
                string maNamHoc = cboNamHoc.EditValue.ToString();
                bindingSourceDiem.DataSource = HOCTAP_BUS.LayDiemMonHocTheoLop(maLop, maMonHoc, maHocKy, maNamHoc);
                bindingNavigatorXemDiemItem.Enabled = true;
            }
            else
                bindingSourceDiem.DataSource = null;
        }



        #endregion -Load-

        #endregion -Methods-

        private void bindingNavigatorXemDiemItem_Click(object sender, EventArgs e)
        {
            string maHS = dgvDiem.GetFocusedRowCellDisplayText(col_maHS);
            string hoTen = dgvDiem.GetFocusedRowCellDisplayText(col_hoTen);
            string maHocKy = cboHocKy.EditValue.ToString();
            string maNamHoc = cboNamHoc.EditValue.ToString();
            frmDiemChiTiet frm = new frmDiemChiTiet(maHS, maHocKy, maNamHoc);
            frm.Show();
        }

        private void frmXemDiem_Load(object sender, EventArgs e)
        {
            bindingNavigatorXemDiemItem.Enabled = false;
            load_cboMonHoc();
            load_cboHocKy();
            load_cboNamHoc();
            load_cboLop();
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            load_cboLop();
            load_BangDiem();
        }

        private void btnXemDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindingNavigatorXemDiemItem_Click(sender, e);
        }

        private void gridDiemControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popupMenu1.ShowPopup(Control.MousePosition);
        }
    }
}