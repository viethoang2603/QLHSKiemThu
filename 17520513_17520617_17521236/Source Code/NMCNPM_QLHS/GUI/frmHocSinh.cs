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
using System.Globalization;
using OfficeOpenXml;
using System.IO;
using System.Drawing.Imaging;
using System.Data.Linq;
using DevExpress.XtraEditors.DXErrorProvider;
using System.Threading;

namespace NMCNPM_QLHS.GUI
{
    public partial class frmHocSinh : DevExpress.XtraEditors.XtraForm
    {

        #region -Constructor-

        public frmHocSinh()
        {
            InitializeComponent();
            //DataService.OpenConnection();
            Permissions();
        }

        #endregion -Constructor-enableall

        #region -Phân quyền-

        public void Permissions()
        {
            switch (NGUOIDUNG_BUS.LayMaQuyen(CurrentUser.Code))
            {
                case "LND002":      // Giao diện đăng nhập với quyền BGH
                    IsBGH();
                    break;
                case "LND004":      // Giao diện đăng nhập với quyền GiaoVien
                    IsGiaoVien();
                    break;
                case "LND003":      // Giao diện đăng nhập với quyền GiaoVu
                    IsGiaoVu();
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
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        public void IsBGH()
        {
            // Enable, Disable các button
            IsGiaoVien();
        }

        public void IsGiaoVien()
        {
            // Enable, Disable các button
            navNhapLieu.PageVisible = false;
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            bindingNavigatorEditItem.Enabled = false;
            bindingNavigatorSearchItem.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            
            navPanelChucNang.SelectedPage = navTimKiem;
        }

        public void IsGiaoVu()
        {
            // Enable, Disable các button
        }



        #endregion -Phân quyền-


        #region -Events-

        #region -Form-

        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            btnHoanTat.Visible = false;
            btnHuyBo.Visible = false;
            load_dgvHocSinh();
        }

        private void frmHocSinh_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void gridControlHocSinh_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popupMenu1.ShowPopup(Control.MousePosition);
        }

        #endregion -Form-

        #region -BindingNavigatorItems_Events-

        // Thêm học sinh
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            // Chuyển sang panel nhập liệu
            dockPanelChucNang.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            navPanelChucNang.SelectedPage = navNhapLieu;
            navPanelChucNang.State = DevExpress.XtraBars.Navigation.NavigationPaneState.Default;
            bindingNavigatorAddNewItem.Enabled = false;
            btnHoanTat.Visible = true;
            btnHuyBo.Visible = true;
            btnHoanTat.Text = "Lưu";
            clear();
            enableAllTextBox();
            txtMaHS.Text = HOCSINH_BUS.autoMaHS();
            txtHoTen.Focus();
        }

        // Xóa học sinh
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn xóa học sinh này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string maHS = txtMaHS.Text;
                HOCSINH_BUS.Delete(maHS);
                load_dgvHocSinh();
            }
        }

        // Sửa học sinh
        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            // Chuyển sang panel nhập liệu
            dockPanelChucNang.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            navPanelChucNang.SelectedPage = navNhapLieu;
            navPanelChucNang.State = DevExpress.XtraBars.Navigation.NavigationPaneState.Default;
            btnHoanTat.Text = "Hoàn tất";
            btnHuyBo.Visible = true;
            btnHoanTat.Visible = true;
            enableAllTextBox();
            txtHoTen.Focus();
        }
        
        // Tìm kiếm học sinh
        private void bindingNavigatorSearchItem_Click(object sender, EventArgs e)
        {
            dockPanelChucNang.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            navPanelChucNang.SelectedPage = navTimKiem;
            navPanelChucNang.State = DevExpress.XtraBars.Navigation.NavigationPaneState.Default;
            txtTTTimKiem.Focus();
        }

        #endregion -BindingNavigatorItems_Events-

        #region -Nhập liệu Events-

        private void dgvHocSinh_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (navPanelChucNang.SelectedPage == navNhapLieu)
            {
                bindingNavigatorAddNewItem.Enabled = true;
                btnHoanTat.Visible = false;
                disableAllTextBox();
                txtMaHS.Text = dgvHocSinh.GetFocusedRowCellDisplayText(col_maHS);
                txtHoTen.Text = dgvHocSinh.GetFocusedRowCellDisplayText(col_hoTen);
                dtpNgaySinh.EditValue = dgvHocSinh.GetFocusedRowCellValue(col_ngaySinh);
                cboGioiTinh.Text = dgvHocSinh.GetFocusedRowCellDisplayText(col_gioiTinh);
                txtDiaChi.Text = dgvHocSinh.GetFocusedRowCellDisplayText(col_diaChi);
                txtEmail.Text = dgvHocSinh.GetFocusedRowCellDisplayText(col_email);
                picHocSinh.Image = HOCSINH_BUS.LayAnhHS(txtMaHS.Text);
            }
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            XtraOpenFileDialog open = new XtraOpenFileDialog();

            PictureBox pic = this.picHocSinh as PictureBox;
            if (pic != null)
            {
                open.Filter = "Image Files|*.jpg;*.jpeg;*.bmp;*.png";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    pic.Image = Image.FromFile(open.FileName);
                }
            }
        }
        
        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            if (!Utility.isEmail(txtEmail.Text))
            {
                XtraMessageBox.Show("email không hợp lệ");
            }
            else if (!Utility.isTen(txtHoTen.Text))
            {
                XtraMessageBox.Show("Họ tên không hợp lệ");
            }
            else
            {
                String.Format("{0:d}", dtpNgaySinh.EditValue);
                string maHS = txtMaHS.Text;
                string hoTen = txtHoTen.Text;
                string gioiTinh = cboGioiTinh.Text;
                //System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern();
                CultureInfo culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
                culture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
                culture.DateTimeFormat.LongDatePattern = "dd MMMM, yyyy";
                Thread.CurrentThread.CurrentCulture = culture;
                DateTime ngaySinh = DateTime.ParseExact(dtpNgaySinh.Text.ToString(), "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("en-GB"));
                string email = txtEmail.Text;
                if (!Utility.isEmail(email))
                {
                    return;
                }
                string diaChi = txtDiaChi.Text;
                //Convert image to byte[] array
                byte[] image_byte;
                Binary image_binary;
                if (picHocSinh.Image != null)
                {
                    image_byte = imageToByteArray(picHocSinh.Image);
                    image_binary = new Binary(image_byte);
                }
                else
                    image_binary = null;

                if (HOCSINH_BUS.KiemTraTuoi(ngaySinh) == true)
                {
                    try
                    {
                        if (btnHoanTat.Text == "Lưu")
                        {
                            HOCSINH_BUS.Insert(maHS, hoTen, gioiTinh, ngaySinh, diaChi, email, image_binary);
                            load_dgvHocSinh();
                            bindingNavigatorHocSinh.BindingSource.MoveLast();
                        }
                        else
                        {
                            HOCSINH_BUS.Update(maHS, hoTen, gioiTinh, ngaySinh, diaChi, email, image_binary);
                            load_dgvHocSinh();
                        }
                        btnHoanTat.Visible = false;
                        btnHuyBo.Visible = false;
                        disableAllTextBox();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    bindingNavigatorAddNewItem.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Tuổi không hợp lệ", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtpNgaySinh.Focus();
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            txtMaHS.Text = "";
            btnHoanTat.Visible = false;
            btnHuyBo.Visible = false;
            bindingNavigatorAddNewItem.Enabled = true;
            disableAllTextBox();
            if (btnHoanTat.Text == "Lưu")
                bindingNavigatorHocSinh.BindingSource.MoveFirst();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindingNavigatorAddNewItem_Click(sender, e);
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindingNavigatorDeleteItem_Click(sender, e);
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindingNavigatorEditItem_Click(sender, e);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "";
                // lấy file excel
                OpenFileDialog dialog = new OpenFileDialog();

                // Lọc ra các file excel
                dialog.Filter = "Excel Files|*.xlsx;*.xlsm;*.xls";

                // Chọn nơi lấy file thành công sẽ lưu đường dẫn lại dùng
                if (dialog.ShowDialog() == DialogResult.OK)
                    filePath = dialog.FileName;
                else
                    return;
                filePath = dialog.FileName;
                // mở file excel
                var package = new ExcelPackage(new FileInfo(filePath));

                // lấy ra sheet đầu tiên để thao tác
                ExcelWorksheet workSheet = package.Workbook.Worksheets[1];

                // duyệt tuần tự từ dòng thứ 2 đến dòng cuối cùng của file.
                for (int i = workSheet.Dimension.Start.Row + 1; i <= workSheet.Dimension.End.Row; i++)
                {
                    try
                    {
                        int j = 1;
                        string maHS = HOCSINH_BUS.autoMaHS();
                        string hoTen = workSheet.Cells[i, j++].Value.ToString();
                        string gioiTinh = workSheet.Cells[i, j++].Value.ToString();
                        var ngaySinh1 = workSheet.Cells[i, j++].Value;
                        DateTime ngaySinh = new DateTime();
                        if (ngaySinh1 != null)
                        {
                            ngaySinh = (DateTime)ngaySinh1;
                        }
                        string diaChi = workSheet.Cells[i, j++].Value.ToString();
                        string email = workSheet.Cells[i, j++].Value.ToString();
                        if (HOCSINH_BUS.KiemTraTuoi(ngaySinh) == true)
                            HOCSINH_BUS.Insert(maHS, hoTen, gioiTinh, ngaySinh, email, diaChi, null);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                XtraMessageBox.Show("Import dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_dgvHocSinh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!");
            }

        }

        #endregion -Nhập liệu Events-

        #region -Tìm kiếm Events-

        private void txtTTTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(rbtnTen.Checked == true)
                bindingSourceHocSinh.DataSource = HOCSINH_BUS.timTTHSTheoTen(txtTTTimKiem.Text);
            else
                bindingSourceHocSinh.DataSource = HOCSINH_BUS.timTTHSTheoMaHS(txtTTTimKiem.Text);
        }

        #endregion -Tìm kiếm Events-

        #endregion -Events-

        #region -Methods-

        #region -Load-

        public void load_dgvHocSinh()
        {
            bindingSourceHocSinh.DataSource = HOCSINH_BUS.LayTatCaHocSinh();
            if (bindingSourceHocSinh.DataSource == null)
            {
                bindingNavigatorEditItem.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;
            }
        }

        #endregion -Load-

        public void clear()
        {
            txtMaHS.Text = "";
            txtHoTen.Text = "";
            dtpNgaySinh.EditValue = null;
            cboGioiTinh.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            picHocSinh.Image = null;
        }

        public void enableAllTextBox()
        {
            txtHoTen.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            dtpNgaySinh.ReadOnly = false;
            cboGioiTinh.Enabled = true;
            btnChonHinh.Enabled = true;
        }

        public void disableAllTextBox()
        {
            txtHoTen.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            dtpNgaySinh.ReadOnly = true;
            cboGioiTinh.Enabled = false;
            btnChonHinh.Enabled = false;
        }

        private byte[] imageToByteArray(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Gif);
                return ms.ToArray();
            }
        }



        #endregion -Methods-

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!Utility.isEmail(txtEmail.Text))
            {
                errEmail.SetError(txtEmail, "Email không hợp lệ");
            }
            else
            {
                errEmail.Dispose();
            }
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            if (!Utility.isTen(txtHoTen.Text))
            {
                errHoTen.SetError(txtHoTen, "Tên không hợp lệ");
            }
            else
            {
                errHoTen.Dispose();
            }
        }
    }
}