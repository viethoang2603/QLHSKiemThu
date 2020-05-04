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
    public partial class frmThongTinNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        public frmThongTinNguoiDung()
        {
            InitializeComponent();
        }

        private void frmThongTinNguoiDung_FormClosed(object sender, FormClosedEventArgs e)
        {
                Application.OpenForms["frmManHinhChinh"].Enabled=true;
        }

        private void frmThongTinNguoiDung_Load(object sender, EventArgs e)
        {
            lbChucVu.Text = NGUOIDUNG_BUS.LayTenQuyen(CurrentUser.Code);
            lbTenNgDung.Text = NGUOIDUNG_BUS.LayTenNguoiDung(CurrentUser.Code);
            lbTenTaiKhoan.Text = NGUOIDUNG_BUS.LayTenDangNhap(CurrentUser.Code);
        }
    }
}