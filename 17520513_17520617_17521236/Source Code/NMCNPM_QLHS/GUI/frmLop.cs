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
    public partial class frmLop : DevExpress.XtraEditors.XtraForm
    {

        #region -Constructor-

        public frmLop(string maKhoi)
        {
            InitializeComponent();
            bindingSourceLop.DataSource = LOP_BUS.LayLopTheoKhoi(maKhoi);
            navPanelChucNang.Enabled = false;
            bindingNavigatorAddNewItem.Visible = false;
            bindingNavigatorAddNewItem.Visible = false;
            bindingNavigatorEditItem.Visible = false;
            bindingNavigatorDeleteItem.Visible = false;
            bindingNavigatorSearchItem.Visible = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnThemNam.Enabled = false;
            cboNamHoc.Enabled = true;
            dockPanelChucNang.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            navPanelChucNang.Hide();
        }

        public frmLop()
        {
            InitializeComponent();
            Permissions();
            load_cboNamHoc();
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
            navNhapLieu.PageVisible = true;
            navPanelChucNang.SelectedPage = navNhapLieu;
            bindingNavigatorAddNewItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;
            bindingNavigatorEditItem.Enabled = true;
            btnSua.Enabled = true;
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
            //navNhapLieu.PageVisible = false;
            //bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorAddNewItem.Visible = false;
            bindingNavigatorDeleteItem.Enabled = false;
            bindingNavigatorEditItem.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            navPanelChucNang.SelectedPage = navTimKiem;
        }

        public void IsGiaoVu()
        {
            // Enable, Disable các button
        }


        #endregion -Phân quyền-

        #region -Methods-

        #region -Load-

        #region -Load_comBoBox

        private void load_cboNamHoc()
        {
            cboNamHoc.Properties.DataSource = NAMHOC_BUS.LayTatCaNamHoc();
            cboNamHoc.Properties.DisplayMember = "TENNAMHOC";
            cboNamHoc.Properties.ValueMember = "MANAMHOC";
            //cboNamHoc.EditValue = NAMHOC_BUS.LayNamHocHienTai().MANAMHOC;
        }

        private void load_cboKhoiLop()
        {
            if (cboNamHoc.Text != "")
            {
                string maNamHoc = cboNamHoc.EditValue.ToString();
                cboKhoiLop.Properties.DataSource = KHOILOP_BUS.LayKhoiTheoNamHoc(maNamHoc);
                cboKhoiLop.Properties.DisplayMember = "TENKHOI";
                cboKhoiLop.Properties.ValueMember = "MAKHOI";
            }
        }

        #endregion -Load_comBoBox

        #region -Load_DSLop-

        private void load_DSLop()
        {
            string maKhoi;
            if (cboKhoiLop.Text != "" && cboNamHoc.Text != "")
            {
                maKhoi = cboKhoiLop.EditValue.ToString();
                bindingSourceLop.DataSource = LOP_BUS.LayLopTheoKhoi(maKhoi);
                bindingSourceLop.MoveNext();
            }
            else if(cboKhoiLop.Text =="" && cboNamHoc.Text !="")
            {
                bindingSourceLop.DataSource = LOP_BUS.LayLopTheoNamHoc(cboNamHoc.EditValue.ToString());
            }
        }

        #endregion -Load_DSLop-

        #endregion -Load-

        #endregion -Methods-

        #region -Events-

        #region -Form-

        private void frmLop_Load(object sender, EventArgs e)
        {
            btnHoanTat.Visible = false;
            btnHuyBo.Visible = false;
            txtTenLop.ReadOnly = true;
        }

        #endregion -Form-

        #region -BindingNavigatorItem_Click-

        private void bindingNavigatorAdd_Click(object sender, EventArgs e)
        {
            dockPanelChucNang.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            navPanelChucNang.SelectedPage = navNhapLieu;
            navPanelChucNang.State = DevExpress.XtraBars.Navigation.NavigationPaneState.Default;
            navTimKiem.PageVisible = false;

            gridControlLop.Enabled = false;
            cboNamHoc.EditValue = NAMHOC_BUS.LayNamHocHienTai().MANAMHOC;
            bindingNavigatorAddNewItem.Enabled = false;
            btnHoanTat.Visible = true;
            btnHuyBo.Visible = true;
            btnHoanTat.Text = "Lưu";
            txtMaLop.Text = LOP_BUS.autoMaLop();
            txtTenLop.Text = "";
            cboKhoiLop.EditValue = null;
            cboNamHoc.ReadOnly = true;
            txtTenLop.ReadOnly = false;
            cboKhoiLop.ReadOnly = false;
            txtTenLop.Focus();
        }

        private void bindingNavigatorDelete_Click(object sender, EventArgs e)
        {
            if (cboKhoiLop.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa lớp này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string maLop = txtMaLop.Text;
                    LOP_BUS.Delete(maLop);
                    load_DSLop();
                }
            }
            else
            {
                XtraMessageBox.Show("Chưa chọn lớp cần xóa", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void bindingNavigatorEdit_Click(object sender, EventArgs e)
        {
            if (cboKhoiLop.Text != "")
            {
                // Chuyển sang panel nhập liệu
                dockPanelChucNang.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
                navPanelChucNang.SelectedPage = navNhapLieu;
                navTimKiem.PageVisible = false;

                btnHoanTat.Text = "Hoàn tất";
                btnHoanTat.Visible = true;
                cboKhoiLop.ReadOnly = true;
                btnHuyBo.Visible = true;
                cboNamHoc.ReadOnly = true;
                txtTenLop.ReadOnly = false;
                txtTenLop.Focus();
            }
            else
            {
                XtraMessageBox.Show("Chưa chọn lớp cần sửa", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bindingNavigatorSearch_Click(object sender, EventArgs e)
        {
            dockPanelChucNang.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            navPanelChucNang.SelectedPage = navTimKiem;
            navPanelChucNang.State = DevExpress.XtraBars.Navigation.NavigationPaneState.Default;
        }

        #endregion -BindingNavigatorItem_Click-

        #region -Nhập liệu-

        private void dgvDSLop_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = true;
            btnHoanTat.Visible = false;
            btnHuyBo.Visible = false;
            cboNamHoc.ReadOnly = false;
            txtTenLop.ReadOnly = true;
            //cboKhoiLop.ReadOnly = true;
            if (bindingSourceLop.DataSource != null)
            {
                DataRow dr = dgvDSLop.GetFocusedDataRow();
                txtMaLop.Text = dr.ItemArray[0].ToString();
                txtTenLop.Text = dr.ItemArray[1].ToString();
                cboKhoiLop.EditValue = dr.ItemArray[4].ToString();
            }
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            if (cboKhoiLop.Text != "" && txtTenLop.Text != "")
            {
                string maLop = txtMaLop.Text;
                string tenLop = txtTenLop.Text;
                string maKhoi = cboKhoiLop.EditValue.ToString();
                try
                {
                    if (btnHoanTat.Text == "Lưu")
                    {
                        LOP_BUS.Insert(maLop, tenLop, maKhoi);
                        load_DSLop();
                        bindingNavigatorLop.BindingSource.MoveLast();
                    }
                    else
                    {
                        LOP_BUS.Update(maLop, tenLop, maKhoi);
                        load_DSLop();
                    }
                    btnHoanTat.Visible = false;
                    btnHuyBo.Visible = false;
                    txtTenLop.ReadOnly = true;
                    gridControlLop.Enabled = true;
                    cboKhoiLop.ReadOnly = false;
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
                bindingNavigatorAddNewItem.Enabled = true;
                navTimKiem.PageVisible = true;
            }
            else
            {
                if (cboKhoiLop.Text == "")
                    XtraMessageBox.Show("Chưa chọn khối lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    XtraMessageBox.Show("Chưa nhập tên lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            gridControlLop.Enabled = true;
            btnHoanTat.Visible = false;
            btnHuyBo.Visible = false;
            cboNamHoc.ReadOnly = false;
            cboKhoiLop.ReadOnly = false;
            txtTenLop.ReadOnly = true;
            navTimKiem.PageVisible = true;
            bindingNavigatorAddNewItem.Enabled = true;
            if (btnHoanTat.Text == "Lưu")
            {
                bindingNavigatorLop.BindingSource.MoveFirst();
                txtTenLop.Text = dgvDSLop.GetRowCellDisplayText(0, col_TenLop);
            }
        }

        #endregion -Nhập liệu-

        #region -Tìm kiếm-

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (rbtnMaLop.Checked == true)
                bindingSourceLop.DataSource = LOP_BUS.timLopTheoMaLop(txtTimKiem.Text);
            else
                bindingSourceLop.DataSource = LOP_BUS.timLopTheoTen(txtTimKiem.Text);
        }


        #endregion -Tìm kiếm-

        #region -popupMenu-

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindingNavigatorAdd_Click(sender, e);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindingNavigatorDelete_Click(sender, e);
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindingNavigatorEdit_Click(sender, e);
        }

        #endregion -popupMenu-

        #region -Button_click-

        private void btnThemNam_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmNamHoc"] == null)
            {
                frmNamHoc f = new frmNamHoc
                {
                    MdiParent = Application.OpenForms["frmManHinhChinh"]
                };
                f.Show();
            }
            else
            {
                Application.OpenForms["frmNamHoc"].Focus();
            }
        }

        #endregion -Button_click-

        #region -comBoBox_EditValueChanged-

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            load_cboKhoiLop();
            cboKhoiLop.EditValue = null;
            load_DSLop();
        }

        private void cboKhoiLop_EditValueChanged(object sender, EventArgs e)
        {
            if (!btnHoanTat.Visible)
                load_DSLop();
        }

        #endregion -comBoBox_EditValueChanged-

        #endregion -Events-

        private void gridControlLop_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popupMenu1.ShowPopup(Control.MousePosition);
        }

        private void btnXemDSHS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaLop.Text != "")
            {
                string maLop = txtMaLop.Text;
                string maNamHoc = NAMHOC_BUS.LayMaNamHocTheoTen(dgvDSLop.GetFocusedRowCellDisplayText(col_Nam));
                frmrpDanhSachLop f = new frmrpDanhSachLop(maLop, maNamHoc);
                f.Show();
            }
        }
    }
}