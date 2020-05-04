using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.DAL
{
    class NAMHOC_DAL
    {
        // Thêm năm học
        public static void Insert()
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                db.sp_ThemNamHoc();
            }
        }

        // Xóa năm học
        public static void Delete(string maNamHoc)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                db.sp_XoaNamHoc(maNamHoc);
            }
        }

        // Lấy tất cả các năm học
        public static List<NAMHOC> LayTatCaNamHoc()
        {
            List<NAMHOC> lst = new List<NAMHOC>();

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = db.NAMHOCs.ToList();
                foreach (var x in ds)
                {
                    NAMHOC namHoc = new NAMHOC();
                    {
                        namHoc.MANAMHOC = x.MANAMHOC;
                        namHoc.TENNAMHOC = x.TENNAMHOC;
                        lst.Add(namHoc);
                    }
                }
            }
            return lst;
        }

        // Lấy năm học theo Mã HS
        public static List<NAMHOC> LayNamHocTheoMaHS(string maHS)
        {
            List<NAMHOC> lst = new List<NAMHOC>();

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = db.sp_LayNamHocTheoMaHS(maHS);
                foreach (var x in ds)
                {
                    NAMHOC namHoc = new NAMHOC();
                    {
                        namHoc.MANAMHOC = x.MANAMHOC;
                        namHoc.TENNAMHOC = x.TENNAMHOC;
                        lst.Add(namHoc);
                    }
                }
            }
            return lst;
        }

        // Lấy năm học trước
        public static NAMHOC LayNamHocTruoc(string maNamHocHienTai)
        {
            NAMHOC namHoc = new NAMHOC();
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                NAMHOC namHocHienTai = db.NAMHOCs.Where(a => a.MANAMHOC == maNamHocHienTai).FirstOrDefault();
                int nam = namHocHienTai.NAM1.Value;
                namHoc = db.NAMHOCs.Where(a => a.NAM1 == nam - 1).FirstOrDefault();
                if (namHoc == null)
                    return null;
            }
            return namHoc;
        }

        // Lấy năm học hiện tại
        public static NAMHOC LayNamHocHienTai()
        {
            NAMHOC namHoc = new NAMHOC();
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = db.sp_LayNamHocHienTai();
                foreach (var x in ds)
                {
                        namHoc.MANAMHOC = x.MANAMHOC;
                        namHoc.TENNAMHOC = x.TENNAMHOC;
                }
            }
            return namHoc;
        }

        // Lấy mã năm học theo tên năm học
        public static NAMHOC LayNamHocTheoTen(string tenNH)
        {
            NAMHOC namHoc = new NAMHOC();
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                namHoc = db.NAMHOCs.Where(a => a.TENNAMHOC == tenNH).FirstOrDefault();
            }
            return namHoc;
        }
    }
}
