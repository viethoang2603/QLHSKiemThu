using NMCNPM_QLHS.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.BUS
{
    class THAMSO_BUS
    {
        // Lấy tham số
        public static double LayThamSo(string tenThamSo)
        {
            THAMSO ts = THAMSO_DAL.LayThamSo(tenThamSo);
            if (ts != null)
                return ts.GIATRI.Value;
            else
                return 0;
        }

        // Lưu quy định
        public static void LuuQuyDinh(double tuoiToiThieu, double tuoiToiDa, double siSoToiDa,
                                    double diemToiThieu, double diemToiDa, double diemDatMon, double diemDatHK)
        {
            THAMSO_DAL.LuuQuyDinh(tuoiToiThieu, tuoiToiDa, siSoToiDa, diemToiThieu, diemToiDa, diemDatMon, diemDatHK);
        }

        // Kiểm tra sự hợp lệ của các giá trị tham số

        public static bool KiemTraTuoi(double tuoiToiThieu, double TuoiToiDa)
        {
            if (tuoiToiThieu >= TuoiToiDa)
                return false;
            else
                return true;
        }

        public static int KiemTraDiem(double diemToiThieu, double diemToiDa, double diemDatMon, double diemDatHK)
        {
            if (diemToiThieu >= diemToiDa)
                return 2;
            else if (diemDatMon > diemToiDa || diemDatMon < diemToiThieu
                    || diemDatHK > diemToiDa || diemDatHK < diemToiThieu)
                return 3;
            else
                return 1;
        }

        // Kiểm tra giá trị tham số hợp lệ với dữ liệu ko

        //#region -Tuổi-

        //public static bool KiemTraDuLieuTuoi(double tuoiToiThieu, double tuoiToiDa)
        //{
        //    List<HOCSINH> lst = HOCSINH_BUS.LayTatCaHocSinh();
        //    int tuoi;
        //    foreach (var hs in lst)
        //    {
        //        tuoi = HOCSINH_BUS.TinhTuoi(hs.NGAYSINH.Value);
        //        if (tuoi < tuoiToiThieu || tuoi > tuoiToiDa)
        //            return false;
        //    }
        //    return true;
        //}

        //#endregion -Tuổi-

        //#region -Sĩ số-

        //public static bool KiemTraDuLieuSiSo(double siSoToiDa)
        //{
        //    List<LOP> lst = LOP_BUS.LayTatCaLop();
        //    foreach (var lop in lst)
        //    {
        //        if (lop.SISO.Value > siSoToiDa)
        //            return false;
        //    }
        //    return true;
        //}

        //#endregion -Sĩ số-

        //#region -Điểm-

        //public static bool KiemTraDuLieuDiem(double diemToiDa, double diemToiThieu)
        //{
        //    using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
        //    {
        //        var lst = db.CT_DIEMMONs.ToList();
        //        double diem;
        //        foreach (var diemChiTiet in lst)
        //        {
        //            diem = diemChiTiet.DIEM.Value;
        //            if (diem > diemToiDa || diem < diemToiThieu)
        //                return false;
        //        }
        //        return true;
        //    }
        //}

        //#endregion -Điểm-

    }
}
