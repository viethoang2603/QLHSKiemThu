using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid.Views.Grid;
using NMCNPM_QLHS.DAL;

namespace NMCNPM_QLHS.BUS
{
    class NGUOIDUNG_BUS
    {
        public static bool KiemTraTenDangNhap(string tendangnhap)
        {
            return NGUOIDUNG_DAL.KiemTraTonTai(tendangnhap);
        }
        public static bool DangNhap(string tendangnhap, string matkhau)
        {
            return NGUOIDUNG_DAL.DangNhap(tendangnhap, matkhau);
        }
        public static bool DangKy(string tendangnhap, string tennguoidung, string matkhau, string loaingdung) {
            return false;
        }
        public static string LayTenNguoiDung(string tendangnhap) {
            return NGUOIDUNG_DAL.LayTenNguoiDung(tendangnhap);
        }
        public static List<NGUOIDUNG> LayTatCaNguoiDung() {
            return NGUOIDUNG_DAL.LayTatCaNguoiDung();
        }
        public static string LayTenDangNhap(string code)
        {
            return NGUOIDUNG_DAL.LayTenDangNhap(code);
        }
        public static string LayTenQuyen(string code)
        {
            return NGUOIDUNG_DAL.LayTenQuyen(code);
        }
        public static string LayMaQuyen(string code) {
            return NGUOIDUNG_DAL.LayMaQuyen(code);
        }
        public static bool DoiMatKhau(string code, string matkhaucu, string matkhaumoi) {
            if (NGUOIDUNG_DAL.LayMatKhau(code) != matkhaucu)
                return false;
            else  
                return NGUOIDUNG_DAL.DoiMatKhau(code, matkhaumoi);
        }
        public static string LayMatKhau(string code) {
            return NGUOIDUNG_DAL.LayMatKhau(code);
        }

        public static void ResetMK(string maND)
        {
            NGUOIDUNG_DAL.ResetMK(maND);
        }

        // Thêm người dùng
        public static void insert(string maND, string tenNguoiDung, string maLND, string tenDangNhap)
        {
            NGUOIDUNG_DAL.insert(maND, tenNguoiDung, maLND, tenDangNhap);
        }

        // Sửa người dùng
        public static void update(string maND, string tenNguoiDung, string maLND)
        {
            NGUOIDUNG_DAL.update(maND, tenNguoiDung, maLND);
        }

        // Xóa người dùng
        public static void delete(string maND)
        {
            NGUOIDUNG_DAL.delete(maND);
        }

        // auto_idNguoiDung
        public static string autoID(GridView dgv)
        {
            string maxID = "";
            int max = int.Parse(dgv.GetRowCellDisplayText(0, dgv.Columns[0]).Substring(2));
            for (int i = 1; i < dgv.RowCount; i++)
                if (int.Parse(dgv.GetRowCellDisplayText(i, dgv.Columns[0]).Substring(2)) > max)
                    max = int.Parse(dgv.GetRowCellDisplayText(i, dgv.Columns[0]).Substring(2));
            max = max + 1;
            if (max < 9)
                maxID = "ND000" + max.ToString();
            else if(max<99)
                maxID = "ND00" + max.ToString();
            else if (max < 99)
                maxID = "ND0" + max.ToString();
            else
                maxID = "ND" + max.ToString();
            return maxID;
        }
        public static bool ThemNguoiDung(string taikhoan, string ten, string loaiquyen)
        {
            return NGUOIDUNG_DAL.ThemNguoiDung(taikhoan, ten, loaiquyen);
        }
        public static bool XoaNguoiDung(string code)
        {
            return NGUOIDUNG_DAL.XoaNguoiDung(code);
        }
    }
}
