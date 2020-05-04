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
    public partial class frmKhoilop : DevExpress.XtraEditors.XtraForm
    {

        #region -Constructor-

        public frmKhoilop()
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

        }

        public void IsBGH()
        {
            // Enable, Disable các button
            IsGiaoVien();
        }

        public void IsGiaoVien()
        {
            // Enable, Disable các button
            
        }

        public void IsGiaoVu()
        {
            // Enable, Disable các button
        }



        #endregion -Phân quyền-

        private void frmKhoilop_Load(object sender, EventArgs e)
        {
            bindingSourceKhoiLop.DataSource = KHOILOP_BUS.LayTatCaKhoi();
            load_colNamHoc();
        }

        private void load_colNamHoc()
        {
            col_namHoc_edit.DataSource = NAMHOC_BUS.LayTatCaNamHoc();
        }

        private void btnXemLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maKhoi = dgvKhoiLop.GetFocusedRowCellDisplayText(col_maKhoi);

            frmLop f = new frmLop(maKhoi);
                f.Show();
        }

        private void gridControlKhoiLop_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popupMenu1.ShowPopup(Control.MousePosition);
        }
    }
}