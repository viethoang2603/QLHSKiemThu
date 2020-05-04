using NMCNPM_QLHS.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMCNPM_QLHS.BUS
{
    class HOCTAP_BUS
    {
        // Lấy điểm học sinh theo lớp
        public static DataTable LayDiemHocSinhTheoLop(string maLop)
        {
            return HOCTAP_DAL.LayDiemHocSinhTheoLop(maLop);
        }

        // Lấy điểm chi tiết học sinh
        public static DataTable LayDiemChiTietHocSinh(string maHS, string maHocKy, string maNamHoc)
        {
            return HOCTAP_DAL.LayDiemChiTietHocSinh(maHS, maHocKy, maNamHoc);
        }

        // Lấy điểm môn học theo lớp
        public static DataTable LayDiemMonHocTheoLop(string maLop, string maMonHoc, string maHocKy, string maNamHoc)
        {
            return HOCTAP_DAL.LayDiemMonHocTheoLop(maLop, maMonHoc, maHocKy, maNamHoc);
        }

        // Sửa điểm
        public static void SuaDiem(string maHS, string maMon, string mahocky, string maLop, float diemMieng, float diem15P, float diem1Tiet, float diemThi)
        {
            HOCTAP_DAL.SuaDiem(maHS, maMon, mahocky, maLop, diemMieng, diem15P, diem1Tiet, diemThi);
        }

        // Kiểm tra điều kiện lên lớp
        public static bool KiemTraDieuKienLenLop(string maHS, string maNamHoc)
        {
            var lst = MONHOC_BUS.LayTatCaMonHoc();
            int heSoHK1 = HOCKY_BUS.layHeSo("HK01");
            int heSoHK2 = HOCKY_BUS.layHeSo("HK02");
            //foreach (var mh in lst)
            //{
            //    double diemHK1 = HOCTAP_DAL.LayDiemTongKetMonHoc(maHS, mh.MAMONHOC.ToString(), "HK01", maNamHoc);
            //    double diemHK2 = HOCTAP_DAL.LayDiemTongKetMonHoc(maHS, mh.MAMONHOC.ToString(), "HK02", maNamHoc);
            //    double diemCaNam = (diemHK1 * heSoHK1 + diemHK2 * heSoHK2) / (heSoHK1 + heSoHK2);
            //    if (diemCaNam < 3.5)
            //        return false;
            //}

            double diemTongKetHK1 = HOCTAP_DAL.LayDiemTongKetHocKy(maHS, "HK01", maNamHoc);
            double diemTongKetHK2 = HOCTAP_DAL.LayDiemTongKetHocKy(maHS, "HK02", maNamHoc);
            double diemTongKetCaNam = (diemTongKetHK1 * heSoHK1 + diemTongKetHK2 * heSoHK2) / (heSoHK1 + heSoHK2);
            if (diemTongKetCaNam < 5)
                return false;

            return true;
        }

        // Kiểm tra điểm hợp lệ
        public static bool KiemTraDiem(double diem)
        {
            double diemToiDa = THAMSO_BUS.LayThamSo("DIEMTOIDA");
            double diemToiThieu = THAMSO_BUS.LayThamSo("DIEMTOITHIEU");
            if (diem <= diemToiDa && diem >= diemToiThieu)
                return true;
            return false;
        }
    }
}
