using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.DAL
{
    class HOCTAP_DAL
    {
        // Lấy điểm học sinh theo lớp
        public static DataTable LayDiemHocSinhTheoLop(string maLop)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MAHS", typeof(string));
            dt.Columns.Add("HOTEN", typeof(string));
            dt.Columns.Add("DIEMTBHK1", typeof(float));
            dt.Columns.Add("DIEMTBHK2", typeof(float));
            dt.Columns.Add("DIEMCANAM", typeof(float));

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var lst = db.sp_LayDiemHocSinhTheoLop(maLop);
                foreach (var i in lst)
                {
                    DataRow r = dt.NewRow();
                    if (i.MAHS != null)
                        r["MAHS"] = i.MAHS;
                    if (i.HOTEN != null)
                        r["HOTEN"] = i.HOTEN;
                    if (i.DIEMTBHK1 != null)
                        r["DIEMTBHK1"] = i.DIEMTBHK1.Value;
                    if (i.DIEMTBHK2 != null)
                        r["DIEMTBHK2"] = i.DIEMTBHK2.Value;
                    if (i.DIEMCANAM != null)
                        r["DIEMCANAM"] = i.DIEMCANAM.Value;
                    dt.Rows.Add(r);
                }
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        // Lấy điểm chi tiết học sinh
        public static DataTable LayDiemChiTietHocSinh(string maHS, string maHocKy, string maNamHoc)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TENMONHOC", typeof(string));
            dt.Columns.Add("DIEMMIENG", typeof(float));
            dt.Columns.Add("DIEM15P", typeof(float));
            dt.Columns.Add("DIEM1TIET", typeof(float));
            dt.Columns.Add("DIEMTHI", typeof(float));
            dt.Columns.Add("DIEMTBHK", typeof(float));

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var lst = db.sp_LayDiemChiTietHocSinh(maHS, maHocKy, maNamHoc);
                foreach (var i in lst)
                {
                    DataRow r = dt.NewRow();
                    if (i.TENMONHOC != null)
                        r["TENMONHOC"] = i.TENMONHOC;
                    if (i.DIEMMIENG != null)
                        r["DIEMMIENG"] = i.DIEMMIENG;
                    if (i.DIEM15P != null)
                        r["DIEM15P"] = i.DIEM15P;
                    if (i.DIEM1TIET != null)
                        r["DIEM1TIET"] = i.DIEM1TIET;
                    if (i.DIEMTHI != null)
                        r["DIEMTHI"] = i.DIEMTHI;
                    if (i.DIEMTBHK != null)
                        r["DIEMTBHK"] = i.DIEMTBHK;
                    dt.Rows.Add(r);
                }
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        // Lấy điểm môn học theo lớp
        public static DataTable LayDiemMonHocTheoLop(string maLop, string maMonHoc, string maHocKy, string maNamHoc)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MAHS", typeof(string));
            dt.Columns.Add("HOTEN", typeof(string));
            dt.Columns.Add("DIEMMIENG", typeof(float));
            dt.Columns.Add("DIEM15P", typeof(float));
            dt.Columns.Add("DIEM1TIET", typeof(float));
            dt.Columns.Add("DIEMTHI", typeof(float));

            SQL_QLHSDataContext db = new SQL_QLHSDataContext();
            var lst = db.sp_LayDiemMonHocTheoLop(maLop, maHocKy, maMonHoc);
            foreach (var i in lst)
            {
                DataRow r = dt.NewRow();
                if (i.MAHS != null)
                    r["MAHS"] = i.MAHS;
                if (i.HOTEN != null)
                    r["HOTEN"] = i.HOTEN;
                if (i.DIEMMIENG != null)
                    r["DIEMMIENG"] = i.DIEMMIENG;
                if (i.DIEM15P != null)
                    r["DIEM15P"] = i.DIEM15P;
                if (i.DIEM1TIET != null)
                    r["DIEM1TIET"] = i.DIEM1TIET;
                if (i.DIEMTHI != null)
                    r["DIEMTHI"] = i.DIEMTHI;
                dt.Rows.Add(r);
            }
            return dt;
        }

        // Sửa điểm
        public static void SuaDiem(string maHS, string maMon, string mahocky, string maLop, float diemMieng, float diem15P, float diem1Tiet, float diemThi)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                db.sp_SuaDiem(maHS, maMon, mahocky, maLop, diemMieng, diem15P, diem1Tiet, diemThi);
            }
        }

        // Lấy điểm tổng kết môn học
        public static double LayDiemTongKetMonHoc(string maHS, string maMonHoc, string maHK, string maNamHoc)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                double? diem = db.func_LayDiemTongKetMonHoc(maHS, maMonHoc, maHK, maNamHoc);
                if (diem.HasValue)
                    return diem.Value;
                else
                    return 0;
            }
        }

        // Lấy điểm tổng kết học kỳ
        public static double LayDiemTongKetHocKy(string maHS, string maHK, string maNamHoc)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                double? diem = db.func_LayDiemTongKetHocKy(maHS, maHK, maNamHoc);
                if (diem.HasValue)
                    return diem.Value;
                else
                    return 0;
            }
        }

    }
}
