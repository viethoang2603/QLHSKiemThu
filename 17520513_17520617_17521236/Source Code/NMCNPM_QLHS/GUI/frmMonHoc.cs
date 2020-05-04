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
    public partial class frmMonHoc : DevExpress.XtraEditors.XtraForm
    {
                
        #region -Fields-

        static bool state = false;
        List<string> lst = new List<string>();

        #endregion -Fields-

        #region -Constructor-

        public frmMonHoc()
        {
            InitializeComponent();
            Permissions();
        }

        #endregion -Constructor-

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
            bindingNavigatorAddNewItem.Enabled = true;
            bindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
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
            bindingNavigatorSaveItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in ((ColumnView)gridControlMonHoc.Views[0]).Columns)
            {
                col.OptionsColumn.AllowEdit = false;
            }
        }

        public void IsGiaoVu()
        {
            // Enable, Disable các button
        }

        #endregion -Phân quyền-

        #region -Form-

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            bindingSourceMonHoc.DataSource = MONHOC_BUS.LayTatCaMonHoc();
        }

        private void frmMonHoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (state == true)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu thay đổi không?", "SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    this.bindingNavigatorSaveItem_Click(bindingNavigatorSaveItem, e);
            }
        }

        #endregion -Form-

        #region -bindingNavigatorItem_Click-

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            dgvMonHoc.FocusInvalidRow();
            string maMonHoc = MONHOC_BUS.autoID(dgvMonHoc);
            dgvMonHoc.AddNewRow();
            int rowHandle = dgvMonHoc.GetRowHandle(dgvMonHoc.DataRowCount);
            if (dgvMonHoc.IsNewItemRow(rowHandle))
            {
                dgvMonHoc.SetRowCellValue(rowHandle, col_maMonHoc, maMonHoc);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn xóa môn này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string maMonHoc = dgvMonHoc.GetFocusedRowCellDisplayText(col_maMonHoc);
                dgvMonHoc.DeleteSelectedRows();
                lst.Add(maMonHoc);
            }
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string maMonHoc, tenMonHoc;
            bindingNavigatorMonHoc.BindingSource.MoveFirst();
            // Thêm, sửa môn học
            for (int i = 0; i < dgvMonHoc.RowCount; i++)
            {
                maMonHoc = dgvMonHoc.GetFocusedRowCellDisplayText(col_maMonHoc);
                tenMonHoc = dgvMonHoc.GetFocusedRowCellDisplayText(col_tenMonHoc);
                if (MONHOC_BUS.LayTatCaMonHoc().Any(a => a.MAMONHOC == maMonHoc) == true)
                    MONHOC_BUS.update(maMonHoc, tenMonHoc);
                else
                    MONHOC_BUS.insert(maMonHoc, tenMonHoc);
                bindingNavigatorMonHoc.BindingSource.MoveNext();
            }
            // Xóa môn học
            if (lst != null)
            {
                for (int i = 0; i < lst.Count; i++)
                    MONHOC_BUS.delete(lst[i]);
            }
            XtraMessageBox.Show("Lưu thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            state = false;
        }

        #endregion -bindingNavigatorItem_Click-

        #region -popupMenu-

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindingNavigatorAddNewItem_Click(sender, e);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindingNavigatorDeleteItem_Click(sender, e);
        }

        #endregion -popupMenu-

        private void dgvMonHoc_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            state = true;
        }

        private void gridControlMonHoc_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popupMenu1.ShowPopup(Control.MousePosition);
        }
    }
}