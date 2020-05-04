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
    public partial class frmThemNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        Action<string, string, string, string> actionHandle;
        public frmThemNguoiDung()
        {
            InitializeComponent();
        }

        public frmThemNguoiDung(string maND, Action<string, string, string, string> action)
        {
            InitializeComponent();
            actionHandle = action;
            txtMaNguoiDung.Text = maND;
        }

        private void frmThemNguoiDung_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["frmNguoiDung"].Enabled = true;
        }

        private void load_cboLoaiND()
        {
            cboLoaiNguoiDung.Properties.DataSource = LOAINGUOIDUNG_BUS.LayTatCaLoaiNguoiDung();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!Utility.isTen(txtTenNguoiDung.Text))
            {
                XtraMessageBox.Show("Tên người dùng không đúng định dạng");
                return;
            }
            if (!Utility.isPassword(txtTenTaiKhoan.Text))
            {
                XtraMessageBox.Show("Tên đăng nhập không hợp lệ");
                return;
            }
            if(NGUOIDUNG_BUS.KiemTraTenDangNhap(txtTenTaiKhoan.Text))
            {
                XtraMessageBox.Show("Tên đăng nhập đã tồn tại.");
                return;
            }
            actionHandle(txtMaNguoiDung.Text, txtTenNguoiDung.Text, cboLoaiNguoiDung.EditValue.ToString(), txtTenTaiKhoan.Text);
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemNguoiDung_Load(object sender, EventArgs e)
        {
            load_cboLoaiND();
            cboLoaiNguoiDung.EditValue = "LND001";
        }

        private void txtTenTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            if (!Utility.isPassword(txtTenTaiKhoan.Text))
            {
                errTenTK.SetError(txtTenTaiKhoan, "Tên đăng nhập phải chứa ít nhất 8 kí tự và không được chứa kí tự đặc biệt");
            }
            else
            {
                errTenTK.Dispose();
                if (NGUOIDUNG_BUS.KiemTraTenDangNhap(txtTenTaiKhoan.Text))
                {
                    errTenTK.SetError(txtTenTaiKhoan, "Tên đăng nhập đã tồn tại");
                }
                else
                    errTenTK.Dispose();
            }
        }

        private void txtTenNguoiDung_EditValueChanged(object sender, EventArgs e)
        {
            if (!Utility.isTen(txtTenNguoiDung.Text))
            {
                errTenTK.SetError(txtTenNguoiDung, "Tên người dùng không đúng định dạng");
            }
            else
            {
                errTenTK.Dispose();
            }
            }
    }
}