using DevExpress.XtraGrid.Views.Grid;
using NMCNPM_QLHS.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMCNPM_QLHS.BUS
{
    class HOCSINH_BUS
    {
        // Thêm học sinh
        public static void Insert(string maHS, string hoTen, string gioiTinh, DateTime ngaySinh, string diaChi, string email, Binary image_binary)
        {
            HOCSINH_DAL.Insert(maHS, hoTen, gioiTinh, ngaySinh, diaChi, email, image_binary);
        }

        // Sửa học sinh
        public static void Update(string maHS, string hoTen, string gioiTinh, DateTime ngaySinh, string diaChi, string email, Binary image_binary)
        {
            HOCSINH_DAL.Update(maHS, hoTen, gioiTinh, ngaySinh, diaChi, email, image_binary);
        }

        // Xóa học sinh
        public static void Delete(string MaHS)
        {
            HOCSINH_DAL.Delete(MaHS);
        }

        // Tạo MaHS
        public static string autoMaHS()
        {
            return HOCSINH_DAL.autoMaHS();
        }

        // Lấy danh sách tất cả học sinh
        public static List<HOCSINH> LayTatCaHocSinh()
        {
            return HOCSINH_DAL.LayTatCaHocSinh();
        }

        // Lấy danh sách học sinh theo MaLop
        public static List<HOCSINH> LayHocSinhTheoLop(string maLop, string maHocKy)
        {
            return HOCSINH_DAL.LayHocSinhTheoLop(maLop, maHocKy);
        }

        // Lấy danh sách Mã HS, họ tên học sinh đã được phân lớp
        public static List<HOCSINH> LayDSHocSinhDaPhanLop()
        {
            return HOCSINH_DAL.LayDSHocSinhDaPhanLop();
        }

        // Lấy danh sách học sinh chưa phân lớp
        public static List<HOCSINH> LayHocSinhChuaPhanLop()
        {
            return HOCSINH_DAL.LayHocSinhChuaPhanLop();
        }

        // Lấy danh sách học sinh được lên lớp
        public static List<HOCSINH> LayDSHocSinhDuocLenLop(string maLop, string maNam)
        {
            List<HOCSINH> lst = new List<HOCSINH>();

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = HOCSINH_DAL.LayHocSinhTheoLop(maLop, "HK02");
                foreach (var x in ds)
                {
                    if (HOCTAP_BUS.KiemTraDieuKienLenLop(x.MAHS.ToString(), maNam) == true)
                    {
                        HOCSINH hs = new HOCSINH();
                        hs.MAHS = x.MAHS;
                        hs.HOTEN = x.HOTEN;
                        lst.Add(hs);
                    }
                }
            }
            return lst;
        }

        // Lấy danh sách học sinh không được lên lớp
        public static List<HOCSINH> LayDSHocSinhKhongDuocLenLop(string maLop, string maNam)
        {
            List<HOCSINH> lst = new List<HOCSINH>();

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = HOCSINH_DAL.LayHocSinhTheoLop(maLop, "HK02");
                foreach (var x in ds)
                {
                    if (HOCTAP_BUS.KiemTraDieuKienLenLop(x.MAHS.ToString(), maNam) == false)
                    {
                        HOCSINH hs = new HOCSINH();
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
            return HOCSINH_DAL.LayAnhHS(mahs);
        }

        // Tìm kiếm thông tin học sinh theo tên
        public static List<HOCSINH> timTTHSTheoTen(string ten)
        {
            return HOCSINH_DAL.timTTHSTheoTen(ten);
        }

        // Tìm kiếm thông tin học sinh theo mã học sinh
        public static List<HOCSINH> timTTHSTheoMaHS(string maHS)
        {
            return HOCSINH_DAL.timTTHSTheoMaHS(maHS);
        }

        public static bool KiemTraTuoi(DateTime ngaySinh)
        {
            // Tính tuổi học sinh
            int tuoi = TinhTuoi(ngaySinh);

            // Kiểm tra tuổi hợp lệ
            double tuoiToiDa = THAMSO_BUS.LayThamSo("TUOITOIDA");
            double tuoiToiThieu = THAMSO_BUS.LayThamSo("TUOITOITHIEU");
            if (tuoi < tuoiToiThieu || tuoi > tuoiToiDa)
                return false;
            return true;
        }

        public static int TinhTuoi(DateTime ngaySinh)
        {
            int tuoi;
            if ((DateTime.Today.Month > ngaySinh.Month) || (DateTime.Today.Month == ngaySinh.Month && DateTime.Today.Day > ngaySinh.Day))
                tuoi = DateTime.Today.Year - ngaySinh.Year;
            else
                tuoi = DateTime.Today.Year - ngaySinh.Year - 1;
            return tuoi;
        }

    }
}