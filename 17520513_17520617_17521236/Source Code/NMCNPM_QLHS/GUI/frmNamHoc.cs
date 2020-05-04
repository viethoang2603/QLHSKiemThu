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
    public partial class frmNamHoc : DevExpress.XtraEditors.XtraForm
    {
        public frmNamHoc()
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
            //bindingNavigatorAdd.Enabled = true;
            //bindingNavigatorEdit.Enabled = true;
            //bindingNavigatorDelete.Enabled = true;
            //bindingNavigatorSave.Enabled = true;
            //dockPanelChucNang.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
        }

        public void IsBGH()
        {
            // Enable, Disable các button
            IsGiaoVien();
        }

        public void IsGiaoVien()
        {
            // Enable, Disable các button
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            //bindingNavigatorEdit.Enabled = false;
            //bindingNavigatorDelete.Enabled = false;
            //bindingNavigatorSave.Enabled = false;
            //dockPanelChucNang.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
        }

        public void IsGiaoVu()
        {
            // Enable, Disable các button
        }


        #endregion -Phân quyền-

        private void frmNamHoc_Load(object sender, EventArgs e)
        {
            load_DSNamHoc();
        }

        private void bindingNavigatorAdd_Click(object sender, EventArgs e)
        {
            NAMHOC_BUS.Insert();
            load_DSNamHoc();
            if (Utility.updateAction != null)
                Utility.updateAction();
        }

        private void btnDeletebindingNavigatorDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn xóa Năm học này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string maNamHoc = dgvNamHoc.GetFocusedRowCellDisplayText(col_maNamHoc);
                NAMHOC_BUS.Delete(maNamHoc);
                load_DSNamHoc();
                if (Utility.updateAction != null)
                    Utility.updateAction();
            }
        }

        private void load_DSNamHoc()
        {

            bindingSourceNamHoc.DataSource = NAMHOC_BUS.LayTatCaNamHoc();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindingNavigatorAdd_Click(sender, e);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnDeletebindingNavigatorDelete_Click(sender, e);
        }

        private void gridControlNamHoc_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popupMenu1.ShowPopup(Control.MousePosition);
        }
    }
}