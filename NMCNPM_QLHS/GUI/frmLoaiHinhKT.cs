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
    public partial class frmLoaiHinhKT : DevExpress.XtraEditors.XtraForm
    {
        static bool state = false; // đã thay đổi dữ liệu chưa
        public frmLoaiHinhKT()
        {
            InitializeComponent();
            Permissions();
        }

        #region -Form-

        private void frmLoaiHinhKT_Load(object sender, EventArgs e)
        {
            bindingSourceLHKT.DataSource = LOAIHINHKIEMTRA_BUS.LayTatCaLHKT();
        }

        private void frmLoaiHinhKT_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (state == true)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu thay đổi không?", "SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    bindingNavigatorSaveItem.PerformClick();
            }
        }

        #endregion -Form-

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
            bindingNavigatorCancelItem.Enabled = true;
            bindingNavigatorSaveItem.Enabled = true;
        }

        public void IsBGH()
        {
            // Enable, Disable các button
            IsGiaoVien();
        }

        public void IsGiaoVien()
        {
            // Enable, Disable các button
            bindingNavigatorCancelItem.Enabled = false;
            bindingNavigatorSaveItem.Enabled = false;

            foreach (DevExpress.XtraGrid.Columns.GridColumn col in ((ColumnView)gridControlLoaiKT.Views[0]).Columns)
            {
                col.OptionsColumn.AllowEdit = false;
            }
        }

        public void IsGiaoVu()
        {
            // Enable, Disable các button
        }

        #endregion -Phân quyền-

        #region  -bingdingNagigatorItem_Click-

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string maLHKT;
            int heSo;
            bindingNavigatorHocKy.BindingSource.MoveFirst();
            for (int i = 0; i < dgvLHKT.RowCount; i++)
            {
                maLHKT = dgvLHKT.GetFocusedRowCellDisplayText(col_maLHKT);
                heSo = int.Parse(dgvLHKT.GetFocusedRowCellDisplayText(col_heSo));
                LOAIHINHKIEMTRA_BUS.update(maLHKT, heSo);
                bindingNavigatorHocKy.BindingSource.MoveNext();
            }
            state = false;
        }

        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            bindingSourceLHKT.DataSource = LOAIHINHKIEMTRA_BUS.LayTatCaLHKT();
            state = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindingNavigatorSaveItem_Click(sender, e);
        }

        #endregion -bingdingNagigatorItem_Click-

        private void dgvHocKy_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            state = true;
        }

        private void gridControlLoaiKT_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popupMenu1.ShowPopup(Control.MousePosition);
        }
    }
}