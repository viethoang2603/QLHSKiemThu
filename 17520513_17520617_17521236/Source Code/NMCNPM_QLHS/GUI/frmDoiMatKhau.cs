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
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
            PhanQuyen();
        }
        public void PhanQuyen()
        {

        }

        private void frmDoiMatKhau_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["frmManHinhChinh"].Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["frmManHinhChinh"].Enabled = true;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.Text != txtNhapLai.Text)
            {
                XtraMessageBox.Show("Nhập lại không trùng");
                txtMatKhauMoi.Text = null;
                txtNhapLai.Text = null;
            }
            else if (NGUOIDUNG_BUS.LayMatKhau(CurrentUser.Code) != txtMatKhau.Text)
            {
                XtraMessageBox.Show("Mật khẩu cũ sai");
                txtMatKhau.Text = null;
                txtMatKhauMoi.Text = null;
                txtNhapLai.Text = null;
            }
            else if (txtMatKhau.Text == txtMatKhauMoi.Text)
            {
                XtraMessageBox.Show("Mật khẩu mới trùng mật khẩu cũ");
                txtMatKhau.Text = null;
                txtMatKhauMoi.Text = null;
                txtNhapLai.Text = null;
            }
            else if (!NGUOIDUNG_BUS.DoiMatKhau(CurrentUser.Code, txtMatKhau.Text, txtMatKhauMoi.Text))
            {
                XtraMessageBox.Show("Đổi mật khẩu không thành công");
                Application.OpenForms["frmDoiMatKhau"].Close();
                Application.OpenForms["frmManHinhChinh"].Enabled = true;
            }
            else
            {
                XtraMessageBox.Show("Đổi mật khẩu thành công");
                Application.OpenForms["frmDoiMatKhau"].Close();
                Application.OpenForms["frmManHinhChinh"].Enabled = true;
            }
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnDongY_Click(btnDongY, e);
            }
        }
    }
}