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
    public partial class frmNhapDiemChung : DevExpress.XtraEditors.XtraForm
    {

        #region -Fields-

        bool state = false; // Đã thay đổi dữ liệu hay chưa

        #endregion -Fields-

        #region -Constructor-

        public frmNhapDiemChung()
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
            dockPanelChucNang.Visible = true;
            bindingNavigatorSaveItem.Enabled = true;
            btnLuu.Enabled = true;
        }

        public void IsBGH()
        {
            // Enable, Disable các button
            IsGiaoVu();
        }

        public void IsGiaoVien()
        {
            // Enable, Disable các button
        }

        public void IsGiaoVu()
        {
            // Enable, Disable các button
            bindingNavigatorSaveItem.Enabled = false;
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in ((ColumnView)gridDiemControl.Views[0]).Columns)
            {
                col.OptionsColumn.AllowEdit = false;
            }
            btnLuu.Enabled = true;
        }

        #endregion -Phân quyền-

        #region -Events-

        #region -Form-

        private void frmNhapDiemChung_Load(object sender, EventArgs e)
        {
            bindingNavigatorXemDiemItem.Enabled = false;
            load_cboMonHoc();
            load_cboHocKy();
            load_cboLop();
            load_colDiemMieng();
            load_colDiem15P();
            load_colDiem1Tiet();
            load_colDiemThi();
        }

        private void frmNhapDiemChung_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (state == true)
            {
                if (MessageBox.Show("Bạn có muốn lưu thay đổi không?", "SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    this.bindingNavigatorSaveItem_Click(sender, e);
            }
        }
        
        private void btnThemLop_Click(object sender, EventArgs e)
        {
            var frm = new frmLop();
            if (Application.OpenForms[frm.Name] == null)
            {
                frm.Show();
            }
            else
            {
                Application.OpenForms[frm.Name].Focus();
            }
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            var frm = new frmMonHoc();
            if (Application.OpenForms[frm.Name] == null)
            {
                frm.Show();
            }
            else
            {
                Application.OpenForms[frm.Name].Focus();
            }
        }

        #endregion -Form-

        #region -bindingNavigatorItems_Click-

        #region -Xem điểm-

        private void bindingNavigatorXemDiemItem_Click(object sender, EventArgs e)
        {
            string maHS = dgvDiem.GetFocusedRowCellDisplayText(col_maHS);
            string hoTen = dgvDiem.GetFocusedRowCellDisplayText(col_hoTen);
            string maHocKy = cboHocKy.EditValue.ToString();
            string maNamHoc = NAMHOC_BUS.LayNamHocHienTai().MANAMHOC;
            frmDiemChiTiet frm = new frmDiemChiTiet(maHS, maHocKy, maNamHoc);
            frm.Show();
        }

        #endregion -Xem điểm-

        #region -Lưu điểm-

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                string maHS, maMonHoc, maHocKy, maLop;
                float diemMieng, diem15P, diem1Tiet, diemThi;
                maMonHoc = cboMonHoc.EditValue.ToString();
                maHocKy = cboHocKy.EditValue.ToString();
                maLop = cboLop.EditValue.ToString();
                bindingNavigatorDiem.BindingSource.MoveFirst();
                for (int i = 0; i < dgvDiem.RowCount; i++)
                {
                    //maHS, maMon, mahocky, maNamHoc, diemMieng, diem15P, diem1Tiet, diemThi
                    maHS = dgvDiem.GetFocusedRowCellDisplayText(col_maHS);
                    if (dgvDiem.GetFocusedRowCellDisplayText(col_diemMieng) != "")
                        diemMieng = float.Parse(dgvDiem.GetFocusedRowCellDisplayText(col_diemMieng));
                    else
                        diemMieng = -1;
                    if (dgvDiem.GetFocusedRowCellDisplayText(col_diem15Phut) != "")
                        diem15P = float.Parse(dgvDiem.GetFocusedRowCellDisplayText(col_diem15Phut));
                    else
                        diem15P = -1;
                    if (dgvDiem.GetFocusedRowCellDisplayText(col_diem1Tiet) != "")
                        diem1Tiet = float.Parse(dgvDiem.GetFocusedRowCellDisplayText(col_diem1Tiet));
                    else
                        diem1Tiet = -1;
                    if (dgvDiem.GetFocusedRowCellDisplayText(col_diemThi) != "")
                        diemThi = float.Parse(dgvDiem.GetFocusedRowCellDisplayText(col_diemThi));
                    else
                        diemThi = -1;
                    HOCTAP_BUS.SuaDiem(maHS, maMonHoc, maHocKy, maLop, diemMieng, diem15P, diem1Tiet, diemThi);
                    bindingNavigatorDiem.BindingSource.MoveNext();
                }
                state = false;
                XtraMessageBox.Show("Lưu thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch {
                MessageBox.Show("Nhập liệu không đúng định dạng", "Thông báo");
            }
            //string maLop = cboLop.SelectedValue.ToString();
            //bindingSourceDiem.DataSource = HOCTAP_BUS.LayDiemMonHocTheoLop(maLop, maMonHoc, maHocKy, maNamHoc);
        }

        #endregion -Lưu điểm-

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindingNavigatorSaveItem_Click(sender, e);
        }

        private void btnXem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindingNavigatorXemDiemItem_Click(sender, e);
        }
        #endregion -bindingNavigatorItems_Click-

        #region -comBoBox_EditValueChanged-

        private void comBoBox_EditValueChanged(object sender, EventArgs e)
        {
            load_BangDiem();
        }

        #endregion -comBoBox_ValueChanged-

        #endregion -Events-

        #region -Methods-

        #region -Load-
        
        private void load_cboHocKy()
        {
            cboHocKy.Properties.DataSource = HOCKY_BUS.LayTatCaHocKy();
            cboHocKy.Properties.DisplayMember = "TENHOCKY";
            cboHocKy.Properties.ValueMember = "MAHK";
        }

        private void load_cboLop()
        {
            cboLop.Properties.DataSource = LOP_BUS.LayLopTheoNamHoc(NAMHOC_BUS.LayNamHocHienTai().MANAMHOC);
            cboLop.Properties.DisplayMember = "TENLOP";
            cboLop.Properties.ValueMember = "MALOP";
            cboLop.EditValue = null;
        }

        private void load_cboMonHoc()
        {
            cboMonHoc.Properties.DataSource = MONHOC_BUS.LayTatCaMonHoc();
            cboMonHoc.Properties.DisplayMember = "TENMONHOC";
            cboMonHoc.Properties.ValueMember = "MAMONHOC";
        }

        private void load_BangDiem()
        {
            if (cboLop.Text != "" && cboMonHoc.Text != "" && cboHocKy.Text != "")
            {
                string maLop = cboLop.EditValue.ToString();
                string maMonHoc = cboMonHoc.EditValue.ToString();
                string maHocKy = cboHocKy.EditValue.ToString();
                string maNamHoc = NAMHOC_BUS.LayNamHocHienTai().MANAMHOC;
                bindingSourceDiem.DataSource = HOCTAP_BUS.LayDiemMonHocTheoLop(maLop, maMonHoc, maHocKy, maNamHoc);
                bindingNavigatorXemDiemItem.Enabled = true;
            }
            else
                bindingSourceDiem.DataSource = null;
        }



        #endregion -Load-

        #endregion -Methods-

        private void gridDiemControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popupMenu1.ShowPopup(Control.MousePosition);
        }

        private void dgvDiem_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            state = true;
        }

        void load_colDiemMieng()
        {
            col_diemMieng1edit.MinValue = int.Parse(THAMSO_BUS.LayThamSo("DIEMTOITHIEU").ToString());
            col_diemMieng1edit.MaxValue = int.Parse(THAMSO_BUS.LayThamSo("DIEMTOIDA").ToString());
        }
        void load_colDiem15P()
        {
            col_diem15Phut1_edit.MinValue = int.Parse(THAMSO_BUS.LayThamSo("DIEMTOITHIEU").ToString());
            col_diem15Phut1_edit.MaxValue = int.Parse(THAMSO_BUS.LayThamSo("DIEMTOIDA").ToString());
        }
        void load_colDiem1Tiet()
        {
            col_diem1Tiet1_edit.MinValue = int.Parse(THAMSO_BUS.LayThamSo("DIEMTOITHIEU").ToString());
            col_diem1Tiet1_edit.MaxValue = int.Parse(THAMSO_BUS.LayThamSo("DIEMTOIDA").ToString());
        }
        void load_colDiemThi()
        {
            col_diemThi1_edit.MinValue = int.Parse(THAMSO_BUS.LayThamSo("DIEMTOITHIEU").ToString());
            col_diemThi1_edit.MaxValue = int.Parse(THAMSO_BUS.LayThamSo("DIEMTOIDA").ToString());
        }
    }
}