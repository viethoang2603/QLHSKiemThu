using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.DAL
{
    class NGUOIDUNG_DAL
    {


        public static bool KiemTraTonTai(string tendangnhap)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                if (db.NGUOIDUNGs.Any(u => u.TENDANGNHAP == tendangnhap))
                    return true;
                return false;
            }
        }
        public static bool DangNhap(string tendangnhap, string matkhau)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {

                if (db.NGUOIDUNGs.Any(u => u.TENDANGNHAP == tendangnhap && u.MATKHAU == matkhau))
                {
                    NGUOIDUNG user = db.NGUOIDUNGs.FirstOrDefault(u => u.TENDANGNHAP == tendangnhap && u.MATKHAU == matkhau);
                    CurrentUser.Code = user.MAND;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static string LayTenNguoiDung(string code) {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                if (db.NGUOIDUNGs.Any(u => u.MAND == code))
                {
                    return db.NGUOIDUNGs.First(u => u.MAND == code).TENNGUOIDUNG;
                }
                return "unknown";
            }
        }
        public static List<NGUOIDUNG> LayTatCaNguoiDung()
        {
            List<NGUOIDUNG> lst = new List<NGUOIDUNG>();

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = db.NGUOIDUNGs.ToList();
                foreach (var x in ds)
                {
                    NGUOIDUNG ngd = new NGUOIDUNG();
                    {
                        ngd.MAND = x.MAND;
                        ngd.TENNGUOIDUNG = x.TENNGUOIDUNG;
                        ngd.TENDANGNHAP = x.TENDANGNHAP;
                        ngd.MALND = x.MALND;
                        lst.Add(ngd);
                    }
                }
            }
            return lst;
        }
        public static string LayTenDangNhap(string code) {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                if (db.NGUOIDUNGs.Any(u => u.MAND == code))
                {
                    return db.NGUOIDUNGs.First(u => u.MAND == code).TENDANGNHAP;
                }
                return "unknown";
            }
        }
        public static string LayTenQuyen(string code)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                if (db.NGUOIDUNGs.Any(u => u.MAND == code))
                {
                    return db.NGUOIDUNGs.First(u => u.MAND == code).LOAINGUOIDUNG.TENLOAIND;
                }
                return "unknown";
            }
        }
        public static string LayMaQuyen(string code)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                if (db.NGUOIDUNGs.Any(u => u.MAND == code))
                {
                    return db.NGUOIDUNGs.First(u => u.MAND == code).MALND;
                }
                return "unknown";
            }
        }
        public static string LayMatKhau(string code)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                if (db.NGUOIDUNGs.Any(u => u.MAND == code))
                {
                    return db.NGUOIDUNGs.First(u => u.MAND == code).MATKHAU;
                }
                return "unknown";
            }
        }

        public static void ResetMK(string maND)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                NGUOIDUNG nd = db.NGUOIDUNGs.Where(a => a.MAND == maND).FirstOrDefault();
                if (nd == null)
                    return;
                nd.MATKHAU = "12345678";
                db.SubmitChanges();
            }
        }

        // Thêm người dùng
        public static void insert(string maND, string tenNguoiDung, string maLND, string tenDangNhap)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                NGUOIDUNG nd = new NGUOIDUNG();
                nd.MAND = maND;
                nd.TENNGUOIDUNG = tenNguoiDung;
                nd.MALND = maLND;
                nd.TENDANGNHAP = tenDangNhap;
                nd.MATKHAU = "12345678";

                db.NGUOIDUNGs.InsertOnSubmit(nd);
                db.SubmitChanges();
            }
        }

        // Sửa người dùng
        public static void update(string maND, string tenNguoiDung, string maLND)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                NGUOIDUNG nd = db.NGUOIDUNGs.Where(a => a.MAND == maND).FirstOrDefault();
                if (nd == null)
                    return;
                nd.TENNGUOIDUNG = tenNguoiDung;
                nd.MALND = maLND;
                db.SubmitChanges();
            }
        }

        // Xóa người dùng
        public static void delete(string maND)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                NGUOIDUNG nd = db.NGUOIDUNGs.Where(a => a.MAND == maND).FirstOrDefault();
                if (nd == null)
                    return;
                db.NGUOIDUNGs.DeleteOnSubmit(nd);
                db.SubmitChanges();
            }
        }

        public static bool DoiMatKhau(string code, string matkhaumoi)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                NGUOIDUNG ngd = db.NGUOIDUNGs.Where(a => a.MAND == code).FirstOrDefault();
                if (ngd == null)
                    return false;
                ngd.MATKHAU = matkhaumoi;
                db.SubmitChanges();
                return true;
            }
        }

        public static bool ThemNguoiDung(string taikhoan, string ten, string loaiquyen) {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                string matkhau = "12345678";
                if (KiemTraTonTai(taikhoan))
                    return false;
                if (!db.LOAINGUOIDUNGs.Any(kind => kind.MALND == loaiquyen))
                    return false;
                else
                    db.sp_ThemNguoiDung(taikhoan, ten, matkhau, loaiquyen);
                return true;
            }
        }

        public static bool XoaNguoiDung(string code) {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext()) {
                try
                {
                    db.NGUOIDUNGs.DeleteOnSubmit(db.NGUOIDUNGs.Where(user => user.MAND == code).FirstOrDefault());
                }
                catch {
                    return false;
                }
                return true;
            }
        }
    }
}
