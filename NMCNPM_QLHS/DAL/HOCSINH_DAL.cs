using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMCNPM_QLHS.DAL
{
    class HOCSINH_DAL
    {
        // Thêm học sinh
        public static void Insert(string maHS, string hoTen, string gioiTinh, DateTime ngaySinh, string diaChi, string email, Binary image_binary)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                HOCSINH hs = new HOCSINH();
                hs.MAHS = maHS;
                hs.HOTEN = hoTen;
                hs.GIOITINH = gioiTinh;
                hs.NGAYSINH = ngaySinh;
                hs.DIACHI = diaChi;
                hs.EMAIL = email;
                hs.ANH = image_binary;
                db.HOCSINHs.InsertOnSubmit(hs);
                db.SubmitChanges();
            }
        }

        // Sửa học sinh
        public static void Update(string maHS, string hoTen, string gioiTinh, DateTime ngaySinh, string diaChi, string email, Binary image_binary)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                HOCSINH hs = db.HOCSINHs.Where(a => a.MAHS == maHS).FirstOrDefault();
                hs.HOTEN = hoTen;
                hs.GIOITINH = gioiTinh;
                hs.NGAYSINH = ngaySinh;
                hs.DIACHI = diaChi;
                hs.EMAIL = email;
                hs.ANH = image_binary;
                db.SubmitChanges();
            }
        }

        // Xóa học sinh
        public static void Delete(string maHS)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                db.sp_XoaHocSinh(maHS);
            }
        }

        // Tạo MaHS
        public static string autoMaHS()
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                return db.AUTO_IDHS();
            }
        }

        // Lấy danh sách tất cả học sinh
        public static List<HOCSINH> LayTatCaHocSinh()
        {
            List<HOCSINH> lst = new List<HOCSINH>();

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = from hs in db.HOCSINHs
                         select new
                         {
                             MAHS = hs.MAHS,
                             HOTEN = hs.HOTEN,
                             GIOITINH = hs.GIOITINH,
                             NGAYSINH = hs.NGAYSINH,
                             DIACHI = hs.DIACHI,
                             EMAIL = hs.EMAIL
                         };
                foreach (var x in ds)
                {
                    HOCSINH hs = new HOCSINH();
                    {
                        hs.MAHS = x.MAHS;
                        hs.HOTEN = x.HOTEN;
                        hs.GIOITINH = x.GIOITINH;
                        hs.NGAYSINH = x.NGAYSINH;
                        hs.DIACHI = x.DIACHI;
                        hs.EMAIL = x.EMAIL;
                        lst.Add(hs);
                    }
                }
            }
            return lst;
        }

        // Lấy danh sách học sinh theo lớp
        public static List<HOCSINH> LayHocSinhTheoLop(string maLop, string maHocKy)
        {
            List<HOCSINH> lst = new List<HOCSINH>();

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = db.sp_LayHocSinhTheoLop(maLop, maHocKy);
                foreach (var x in ds)
                {
                    HOCSINH hs = new HOCSINH();
                    {
                        hs.MAHS = x.MAHS;
                        hs.HOTEN = x.HOTEN;
                        hs.GIOITINH = x.GIOITINH;
                        hs.NGAYSINH = x.NGAYSINH;
                        hs.DIACHI = x.DIACHI;
                        hs.EMAIL = x.EMAIL;
                        lst.Add(hs);
                    }
                }
            }
            return lst;
        }

        // Lấy danh sách học sinh đã được phân lớp
        public static List<HOCSINH> LayDSHocSinhDaPhanLop()
        {
            List<HOCSINH> lst = new List<HOCSINH>();

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = db.sp_LayDSHSDaPhanLop();
                foreach (var x in ds)
                {
                    HOCSINH hs = new HOCSINH();
                    hs.MAHS = x.MAHS;
                    hs.HOTEN = x.HOTEN;
                    lst.Add(hs);
                }
            }
            return lst;
        }

        // Lấy danh sách học sinh chưa phân lớp
        public static List<HOCSINH> LayHocSinhChuaPhanLop()
        {
            List<HOCSINH> lst = new List<HOCSINH>();
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = db.sp_LayDanhSachHocSinhChuaPhanLop();
                foreach (var x in ds)
                {
                    HOCSINH hs = new HOCSINH();
                    {
                        hs.MAHS = x.MAHS;
                        hs.HOTEN = x.HOTEN;
                        lst.Add(hs);
                    }
                }
            }
            return lst;
        }

        // Lấy ảnh hs theo mã hs
        public static Image LayAnhHS(string mahs)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var hs = db.HOCSINHs.Where(a => a.MAHS == mahs).FirstOrDefault();
                if (hs.ANH == null)
                    return null;
                using (MemoryStream ms = new MemoryStream(hs.ANH.ToArray()))
                {
                    Image img = Image.FromStream(ms);
                    return img;
                }
            }
        }

        // Tìm kiếm học sinh theo tên
        public static List<HOCSINH> timTTHSTheoTen(string ten)
        {
            List<HOCSINH> lst = new List<HOCSINH>();
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = db.sp_TimHSTheoTen(ten);
                foreach (var x in ds)
                {
                    HOCSINH hs = new HOCSINH();
                    {
                        hs.MAHS = x.MAHS;
                        hs.HOTEN = x.HOTEN;
                        hs.GIOITINH = x.GIOITINH;
                        hs.NGAYSINH = x.NGAYSINH;
                        hs.DIACHI = x.DIACHI;
                        hs.EMAIL = x.EMAIL;
                        lst.Add(hs);
                    }
                }
            }
            return lst;
        }

        // Tìm kiếm thông tin học sinh theo mã học sinh
        public static List<HOCSINH> timTTHSTheoMaHS(string maHS)
        {
            List<HOCSINH> lst = new List<HOCSINH>();
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = db.sp_TimHSTheoMaHS(maHS);
                foreach (var x in ds)
                {
                    HOCSINH hs = new HOCSINH();
                    {
                        hs.MAHS = x.MAHS;
                        hs.HOTEN = x.HOTEN;
                        hs.GIOITINH = x.GIOITINH;
                        hs.NGAYSINH = x.NGAYSINH;
                        hs.DIACHI = x.DIACHI;
                        hs.EMAIL = x.EMAIL;
                        hs.ANH = null;
                        lst.Add(hs);
                    }
                }
            }
            return lst;
        }

    }
}
