using NMCNPM_QLHS.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.BUS
{
    class LOP_BUS
    {
        // Thêm lớp
        public static void Insert(string maLop, string tenLop, string maKhoi)
        {
            LOP_DAL.Insert(maLop, tenLop, maKhoi);
        }

        // Sửa học sinh
        public static void Update(string maLop, string tenLop, string maKhoi)
        {
            LOP_DAL.Update(maLop, tenLop, maKhoi);
        }

        // Xóa lớp
        public static void Delete(string maLop)
        {
            LOP_DAL.Delete(maLop);
        }

        // Lấy tất cả các lớp
        public static List<LOP> LayTatCaLop()
        {
            return LOP_DAL.LayTatCaLop();
        }

        // Lấy ds lớp theo năm học
        public static DataTable LayLopTheoNamHoc(string maNamHoc)
        {
            return LOP_DAL.LayLopTheoNamHoc(maNamHoc);
        }

        // Lấy ds lớp theo Khối
        public static DataTable LayLopTheoKhoi(string maKhoi)
        {
            return LOP_DAL.LayLopTheoKhoi(maKhoi);
        }

        // Lấy mã lớp auto
        public static string autoMaLop()
        {
            return LOP_DAL.autoMaLop();
        }

        // Tìm kiếm lớp theo tên lớp
        public static DataTable timLopTheoTen(string ten)
        {
            return LOP_DAL.timLopTheoTen(ten);
        }

        // Tìm kiếm lớp theo mã lớp
        public static DataTable timLopTheoMaLop(string maLop)
        {
            return LOP_DAL.timLopTheoMaLop(maLop);
        }
    }
}
