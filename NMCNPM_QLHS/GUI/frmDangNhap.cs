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
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtTaiKhoan.Text =="")
            {
                XtraMessageBox.Show("Chưa nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaiKhoan.Focus();
            }
            if (txtMatKhau.Text == "")
            {
                XtraMessageBox.Show("Chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
            }
            if (NGUOIDUNG_BUS.DangNhap(txtTaiKhoan.Text, txtMatKhau.Text))
            {
                string tenDangNhap = txtTaiKhoan.Text;
                frmManHinhChinh frm = new frmManHinhChinh(tenDangNhap);
                this.Hide();
                frm.Show();

            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                txtMatKhau.Text = null;
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnDangNhap_Click(this.btnDangNhap, e);
            }
        }
    }
}