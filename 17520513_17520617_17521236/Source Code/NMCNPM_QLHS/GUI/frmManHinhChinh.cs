using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using System.Threading;
using NMCNPM_QLHS.BUS;

namespace NMCNPM_QLHS.GUI
{
    public partial class frmManHinhChinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        #region -Fields-
        //NguoiDungCtrl m_NguoiDungCtrl = new NguoiDungCtrl();
        //frmDoiMatKhau m_FrmDoiMatKhau = null;
        //frmDangNhap m_FrmLogin = null;
        //frmNguoiDung m_FrmNguoiDung = null;
        //frmConnection m_Connection = null;
        string username;
        #endregion -Fields-

        #region -frmMain-

        #region -Constructor-
        public frmManHinhChinh()
        {
            //Load frmSplash
            //Thread t = new Thread(new ThreadStart(Start));
            //t.Start();
            //Thread.Sleep(3000);
            InitializeComponent();
            Permissions();
            //t.Abort();
        }

        public frmManHinhChinh(string tenDangNhap)
        {
            //Load frmSplash

            //Thread t = new Thread(new ThreadStart(Start));
            //t.Start();
            //Thread.Sleep(3000);
            InitializeComponent();
            Permissions();
            //t.Abort();
            username = tenDangNhap;
        }
        public void Start()
        {
            //try
            //{
            //    frmSplash frm = new frmSplash();
            //    Application.Run(frm);
            //}
            //catch (ThreadAbortException ex)
            //{
            //    Thread.ResetAbort();
            //}
        }
        #endregion -Constructor-

        #region -Load-

        private void frmManHinhChinh_Load(object sender, EventArgs e)
        {
            staticNamHoc.Caption = "Năm học: " + NAMHOC_BUS.LayNamHocHienTai().TENNAMHOC.ToString();
            staticNguoiDung.Caption = "Người dùng: " + NGUOIDUNG_BUS.LayTenNguoiDung(CurrentUser.Code);
            subNguoiDung.Caption = NGUOIDUNG_BUS.LayTenNguoiDung(CurrentUser.Code) + " đã đăng nhập";
            Utility.updateAction += UpdateNe;
        }

        #endregion -Load-

        #region -Kết nối lại CSDL-
        public void ReConnection()
        {
            //MessageBoxEx.Show("Lỗi kết nối đến cơ sở dữ liệu! Xin vui lòng thiết lập lại kết nối...", "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);

            //if (m_Connection == null || m_Connection.IsDisposed)
            //    m_Connection = new frmConnection();

            //if (m_Connection.ShowDialog() == DialogResult.OK)
            //{
            //    MessageBoxEx.Show("Đã thiết lập kết nối cho lần chạy đầu tiên.\nHãy khởi động lại chương trình để thực thi kết nối!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.Close();
            //}
            //else
            //    return;
        }
        #endregion -Kết nối lại CSDL-

        #region -Lưu trạng thái trước khi rời khỏi Ch.trình

        private void frmManHinhChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            Utility.updateAction -= UpdateNe;
        }
        #endregion -Lưu trạng thái trước khi rời khỏi Ch.trình

        #endregion -frmMain-

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
            btnPhanLop.Visibility = BarItemVisibility.Always;
            btnLenLop.Visibility = BarItemVisibility.Always;
            btnNhapDiem.Visibility = BarItemVisibility.Always;
            ribbonPageQuyDinh.Visible = true;
            ribbonPageGroup11.Visible = true;
        }

        public void IsBGH()
        {
            // Enable, Disable các button
            btnPhanLop.Visibility = BarItemVisibility.Never;
            btnLenLop.Visibility = BarItemVisibility.Never;
            ribbonPageThongKe.Visible = false;
            btnNhapDiem.Visibility = BarItemVisibility.Never;
        }

        public void IsGiaoVien()
        {
            // Enable, Disable các button
            btnPhanLop.Visibility = BarItemVisibility.Never;
            btnLenLop.Visibility = BarItemVisibility.Never;
            ribbonPageQuyDinh.Visible = false;
            ribbonPageGroup11.Visible = false;
        }

        public void IsGiaoVu()
        {
            // Enable, Disable các button
            btnNhapDiem.Visibility = BarItemVisibility.Never;
            btnNguoiDung.Visibility = BarItemVisibility.Never;
            ribbonPageGroup11.Visible = false;
        }


        #endregion -Phân quyền-

        #region -Tài Khoản-

        #region -Đăng nhập-
        public void DangNhap()
        {
            //Cont:
            //if (m_FrmLogin == null || m_FrmLogin.IsDisposed)
            //    m_FrmLogin = new frmDangNhap();

            //if (m_FrmLogin.ShowDialog() == DialogResult.OK)
            //{
            //    if (m_FrmLogin.txtUsername.Text == "")
            //    {
            //        m_FrmLogin.lblPassError.Text = "";
            //        m_FrmLogin.lblUserError.Text = "Bạn chưa nhập tên!";
            //        goto Cont;
            //    }

            //    if (m_FrmLogin.txtPassword.Text == "")
            //    {
            //        m_FrmLogin.lblUserError.Text = "";
            //        m_FrmLogin.lblPassError.Text = "Bạn chưa nhập mật khẩu!";
            //        goto Cont;
            //    }

            //    int ketQua = m_NguoiDungCtrl.DangNhap(m_FrmLogin.txtUsername.Text, m_FrmLogin.txtPassword.Text);

            //    switch (ketQua)
            //    {
            //        case 0:
            //            m_FrmLogin.lblPassError.Text = "";
            //            m_FrmLogin.lblUserError.Text = "Người dùng này không tồn tại!";
            //            goto Cont;
            //        case 1:
            //            m_FrmLogin.lblUserError.Text = "";
            //            m_FrmLogin.lblPassError.Text = "Mật khẩu không hợp lệ!";
            //            goto Cont;
            //        case 2:
            //            lblTenNguoiDung.Text = Utilities.NguoiDung.TenND;
            //            Permissions(Utilities.NguoiDung.LoaiND.MaLoai);
            //            break;
            //    }
            //}
            //else
            //    return;
        }
        #endregion -Đăng nhập-

        #region -Đổi mật khẩu-
        public void DoiMatKhau()
        {
            //Cont:
            //if (m_FrmDoiMatKhau.ShowDialog() == DialogResult.OK)
            //{
            //    if (m_FrmDoiMatKhau.txtOldPassword.Text == "")
            //    {
            //        m_FrmDoiMatKhau.lblOldPassError.Text = "Chưa nhập mật khẩu hiện tại!";
            //        m_FrmDoiMatKhau.lblNewPassError.Text = "";
            //        m_FrmDoiMatKhau.lblReNPassError.Text = "";
            //        goto Cont;
            //    }

            //    if (m_FrmDoiMatKhau.txtNewPassword.Text == "")
            //    {
            //        m_FrmDoiMatKhau.lblOldPassError.Text = "";
            //        m_FrmDoiMatKhau.lblNewPassError.Text = "Chưa nhập mật khẩu mới!";
            //        m_FrmDoiMatKhau.lblReNPassError.Text = "";
            //        goto Cont;
            //    }

            //    if (m_FrmDoiMatKhau.txtReNPassword.Text == "")
            //    {
            //        m_FrmDoiMatKhau.lblOldPassError.Text = "";
            //        m_FrmDoiMatKhau.lblNewPassError.Text = "";
            //        m_FrmDoiMatKhau.lblReNPassError.Text = "Chưa nhập xác nhận mật khẩu!";
            //        goto Cont;
            //    }

            //    String m_Username = m_FrmLogin.txtUsername.Text;
            //    String m_Password = m_FrmLogin.txtPassword.Text;

            //    String m_OldPassword = m_FrmDoiMatKhau.txtOldPassword.Text;
            //    String m_NewPassword = m_FrmDoiMatKhau.txtNewPassword.Text;
            //    String m_ReNPassword = m_FrmDoiMatKhau.txtReNPassword.Text;

            //    if (m_Password != m_OldPassword)
            //    {
            //        m_FrmDoiMatKhau.lblOldPassError.Text = "Nhập sai mật khẩu cũ!";
            //        m_FrmDoiMatKhau.lblNewPassError.Text = "";
            //        m_FrmDoiMatKhau.lblReNPassError.Text = "";
            //        goto Cont;
            //    }
            //    else if (m_NewPassword != m_ReNPassword)
            //    {
            //        m_FrmDoiMatKhau.lblOldPassError.Text = "";
            //        m_FrmDoiMatKhau.lblNewPassError.Text = "";
            //        m_FrmDoiMatKhau.lblReNPassError.Text = "Nhập xác nhận không khớp!";
            //        goto Cont;
            //    }
            //    else
            //    {
            //        m_NguoiDungCtrl.ChangePassword(m_Username, m_NewPassword);
            //        MessageBoxEx.Show("Đổi mật khẩu thành công!", "PASSWORD CHANGED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //else
            //    return;
        }
        #endregion -Đổi mật khẩu-

        #endregion -Tài Khoản-

        #region -Show form-

        #region -Menu Start-

        #endregion

        #region -Menu Quản Lý-

        private void btnLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmLop));
            if (frm != null)
                frm.Activate();
            else
            {
                frmLop f = new frmLop
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void btnKhoiLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmKhoilop));
            if (frm != null)
                frm.Activate();
            else
            {
                frmKhoilop f = new frmKhoilop
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void btnHocKy_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmHocKy));
            if (frm != null)
                frm.Activate();
            else
            {
                frmHocKy f = new frmHocKy
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void btnNamHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmNamHoc));
            if (frm != null)
                frm.Activate();
            else
            {
                frmNamHoc f = new frmNamHoc
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void btnMonHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmMonHoc));
            if (frm != null)
                frm.Activate();
            else
            {
                frmMonHoc f = new frmMonHoc
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void btnDiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmNhapDiemChung));
            if (frm != null)
                frm.Activate();
            else
            {
                frmNhapDiemChung f = new frmNhapDiemChung
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void btnHocSinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmHocSinh));
            if (frm != null)
                frm.Activate();
            else
            {
                frmHocSinh f = new frmHocSinh
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void btnPhanLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmPhanLop));
            if (frm != null)
                frm.Activate();
            else
            {
                frmPhanLop f = new frmPhanLop
                {
                    MdiParent = this
                };
                f.Show();
            }
        }
        private void btnLenLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmLenLop));
            if (frm != null)
                frm.Activate();
            else
            {
                frmLenLop f = new frmLenLop
                {
                    MdiParent = this
                };
                f.Show();
            }
        }
        private void btnXemDiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmXemDiem));
            if (frm != null)
                frm.Activate();
            else
            {
                frmXemDiem f = new frmXemDiem
                {
                    MdiParent = this
                };
                f.Show();
            }
        }
        private void btnNguoiDung_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmNguoiDung));
            if (frm != null)
                frm.Activate();
            else
            {
                frmNguoiDung f = new frmNguoiDung
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void btnLoaiHinhKiemTra_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmLoaiHinhKT));
            if (frm != null)
                frm.Activate();
            else
            {
                frmLoaiHinhKT f = new frmLoaiHinhKT
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        #endregion

        #region -Menu Thống kê-

        private void btnBaoCaoHocKy_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmrpHocKy));
            if (frm != null)
                frm.Activate();
            else
            {
                frmrpHocKy f = new frmrpHocKy
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void btnBaoCaoMon_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmrpMon));
            if (frm != null)
                frm.Activate();
            else
            {
                frmrpMon f = new frmrpMon
                {
                    MdiParent = this
                };
                f.Show();
            }
        }
        private void btnDSHocSinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmrpDanhSachHocSinh));
            if (frm != null)
                frm.Activate();
            else
            {
                frmrpDanhSachHocSinh f = new frmrpDanhSachHocSinh
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void btnDSLopHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmrpDanhSachLop));
            if (frm != null)
                frm.Activate();
            else
            {
                frmrpDanhSachLop f = new frmrpDanhSachLop
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        #endregion

        #region -Menu Tra cứu-

        private void btnTraCuuHS_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmTraCuuHocSinh));
            if (frm != null)
                frm.Activate();
            else
            {
                frmTraCuuHocSinh f = new frmTraCuuHocSinh
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void btnTraCuuDiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmDiemChiTiet));
            if (frm != null)
                frm.Activate();
            else
            {
                frmDiemChiTiet f = new frmDiemChiTiet
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        #endregion

        #region -Menu Qui Định-

        private void btnQuyDinhTuoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            load_menuQuyDinh("QuyDinhTuoi");
        }

        private void btnQuyDinhSiSo_ItemClick(object sender, ItemClickEventArgs e)
        {
            load_menuQuyDinh("QuyDinhSiSo");
        }

        private void btnQuyDinhDiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            load_menuQuyDinh("QuyDinhDiem");
        }

        private void load_menuQuyDinh(string s)
        {
            var frm = new frmQuyDinh(s);
            frm.Show();
            Application.OpenForms["frmManHinhChinh"].Enabled = false;
        }

        #endregion

        #region -Menu Trợ Giúp-

        #endregion

        #region -Kiểm tra form tồn tại hay không-
        private Form KiemTraTonTai(Type fType)
        {
            foreach (Form f in MdiChildren)
            {
                if (f.GetType() == fType) //Neu Form duoc truyen vao da duoc mo
                    return f;
            }
            return null;
        }

        #endregion
        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
            var frm = new frmDangNhap();
            frm.Show();
        }

        private void btnThongTin_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmThongTinNguoiDung();
            frm.Show();
            this.Enabled = false;
        }
        private void btnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmDoiMatKhau();
            frm.Show();
            this.Enabled = false;
        }



        #endregion -Show form-

        private void UpdateNe()
        {
            staticNamHoc.Caption = staticNamHoc.Caption = "Năm học: " + NAMHOC_BUS.LayNamHocHienTai().TENNAMHOC.ToString();
        }

        private void btnThongTinPhanMem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmThongTin();
            frm.Show();
            this.Enabled = false;
        }
    }
}