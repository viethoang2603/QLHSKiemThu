using NMCNPM_QLHS.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.BUS
{
    class KHOILOP_BUS
    {
        // Lấy tất cả các khối
        public static List<KHOILOP> LayTatCaKhoi()
        {
            return KHOILOP_DAL.LayTatCaKhoi();
        }

        // Lấy khối theo năm học
        public static List<KHOILOP> LayKhoiTheoNamHoc(string maNamHoc)
        {
            return KHOILOP_DAL.LayKhoiTheoNamHoc(maNamHoc);
        }

        // Lấy khối 10 & 11 theo năm học
        public static List<KHOILOP> LayKhoi1011(string maNamHoc)
        {
            return KHOILOP_DAL.LayKhoi1011(maNamHoc);
        }

        // Lấy khối lớp tiếp theo
        public static List<KHOILOP> LayKhoiLopTiepTheo(string tenKhoiLopCu, string maNamHoc)
        {
            int khoiMoi = int.Parse(tenKhoiLopCu) + 1;
            string tenKhoiLopMoi = khoiMoi.ToString();
            return KHOILOP_DAL.LayKhoiTheoMaKhoiMaNam(tenKhoiLopMoi, maNamHoc);
        }

        // Lấy Cùng khối lớp năm sau
        public static List<KHOILOP> LayCungKhoiLopNamSau(string tenKhoiLopCu, string maNamHoc)
        {
            return KHOILOP_DAL.LayKhoiTheoMaKhoiMaNam(tenKhoiLopCu, maNamHoc);
        }

        // Kiểm tra số lượng lớp
        public static bool kiemTraSoLuongLop(string makhoi)
        {
            int soLopToiDa = int.Parse(THAMSO_BUS.LayThamSo("SOLUONGLOP").ToString());
            if (KHOILOP_DAL.LaySoLop(makhoi) == soLopToiDa)
                return false;
            return true;
        }

    }
}
