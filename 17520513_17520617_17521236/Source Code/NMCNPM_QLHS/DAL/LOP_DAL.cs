using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.DAL
{
    class LOP_DAL
    {
        // Thêm Lớp
        public static void Insert(string maLop, string tenLop, string maKhoi)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                LOP l = new LOP();
                l.MALOP = maLop;
                l.TENLOP = tenLop;
                l.MAKHOI = maKhoi;
                l.SISO = null;

                db.LOPs.InsertOnSubmit(l);
                db.SubmitChanges();
            }
        }

        // Sửa lớp
        public static void Update(string maLop, string tenLop, string maKhoi)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                LOP l = db.LOPs.Where(a => a.MALOP == maLop).FirstOrDefault();
                l.TENLOP = tenLop;
                l.MAKHOI = maKhoi;
                db.SubmitChanges();
            }
        }

        // Xóa lớp
        public static void Delete(string maLop)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                db.sp_XoaLop(maLop);
            }
        }

        // Lấy tất cả các lớp
        public static List<LOP> LayTatCaLop()
        {
            List<LOP> lst = new List<LOP>();

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = from lop in db.LOPs
                         select lop;
                foreach (var x in ds)
                {
                    LOP lop = new LOP();
                    {
                        lop.MALOP = x.MALOP;
                        lop.TENLOP = x.TENLOP;
                        lst.Add(lop);
                    }
                }
            }
            return lst;
        }

        // Lấy ds lớp theo năm học
        public static DataTable LayLopTheoNamHoc(string maNamHoc)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MALOP", typeof(string));
            dt.Columns.Add("TENLOP", typeof(string));
            dt.Columns.Add("SISO", typeof(int));
            dt.Columns.Add("TENKHOI", typeof(string));
            dt.Columns.Add("MAKHOI", typeof(string));
            dt.Columns.Add("TENNAMHOC", typeof(string));

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = db.sp_LayLopTheoNamHoc(maNamHoc);
                foreach (var i in ds)
                {
                    DataRow r = dt.NewRow();
                    if (i.MALOP != null)
                        r["MALOP"] = i.MALOP;
                    if (i.TENLOP != null)
                        r["TENLOP"] = i.TENLOP;
                    if (i.SISO != null)
                        r["SISO"] = i.SISO.Value;
                    if (i.TENKHOI != null)
                        r["TENKHOI"] = i.TENKHOI;
                    if (i.MAKHOI != null)
                        r["MAKHOI"] = i.MAKHOI;
                    if (i.TENNAMHOC != null)
                        r["TENNAMHOC"] = i.TENNAMHOC;
                    dt.Rows.Add(r);
                }
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        // Lấy ds lớp theo Khối
        public static DataTable LayLopTheoKhoi(string maKhoi)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MALOP", typeof(string));
            dt.Columns.Add("TENLOP", typeof(string));
            dt.Columns.Add("SISO", typeof(int));
            dt.Columns.Add("TENKHOI", typeof(string));
            dt.Columns.Add("MAKHOI", typeof(string));
            dt.Columns.Add("TENNAMHOC", typeof(string));

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = from lop in db.LOPs
                         from khoi in db.KHOILOPs
                         from namhoc in db.NAMHOCs
                         where lop.MAKHOI == khoi.MAKHOI && khoi.MANAM == namhoc.MANAMHOC
                         && khoi.MAKHOI == maKhoi
                         select new
                         {
                             MALOP = lop.MALOP,
                             TENLOP = lop.TENLOP,
                             SISO = lop.SISO,
                             TENKHOI = khoi.TENKHOI,
                             MAKHOI = khoi.MAKHOI,
                             TENNAMHOC = namhoc.TENNAMHOC
                         };
                foreach (var i in ds)
                {
                    DataRow r = dt.NewRow();
                    if (i.MALOP != null)
                        r["MALOP"] = i.MALOP;
                    if (i.TENLOP != null)
                        r["TENLOP"] = i.TENLOP;
                    if (i.SISO != null)
                        r["SISO"] = i.SISO.Value;
                    if (i.TENKHOI != null)
                        r["TENKHOI"] = i.TENKHOI;
                    if (i.MAKHOI != null)
                        r["MAKHOI"] = i.MAKHOI;
                    if (i.TENNAMHOC != null)
                        r["TENNAMHOC"] = i.TENNAMHOC;
                    dt.Rows.Add(r);
                }
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        // Lấy sĩ số lớp
        public static int LaySiSoLop(string maLop, string maHocKy)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                int siSo = db.QUATRINHHOCs.Where(a => a.MALOP == maLop && a.MAHK == maHocKy).Count();
                return siSo;
            }
        }

        // Lấy mã lớp auto
        public static string autoMaLop()
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                return db.AUTO_IDLOP();
            }
        }

        // Tìm kiếm lớp theo tên
        public static DataTable timLopTheoTen(string ten)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MALOP", typeof(string));
            dt.Columns.Add("TENLOP", typeof(string));
            dt.Columns.Add("SISO", typeof(int));
            dt.Columns.Add("TENKHOI", typeof(string));
            dt.Columns.Add("MAKHOI", typeof(string));
            dt.Columns.Add("TENNAMHOC", typeof(string));

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = db.sp_TimLopTheoTenLop(ten);
                foreach (var i in ds)
                {
                    DataRow r = dt.NewRow();
                    if (i.MALOP != null)
                        r["MALOP"] = i.MALOP;
                    if (i.TENLOP != null)
                        r["TENLOP"] = i.TENLOP;
                    if (i.SISO != null)
                        r["SISO"] = i.SISO.Value;
                    if (i.TENKHOI != null)
                        r["TENKHOI"] = i.TENKHOI;
                    if (i.MAKHOI != null)
                        r["MAKHOI"] = i.MAKHOI;
                    if (i.TENNAMHOC != null)
                        r["TENNAMHOC"] = i.TENNAMHOC;
                    dt.Rows.Add(r);
                }
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        // Tìm kiếm lớp theo mã lớp
        public static DataTable timLopTheoMaLop(string maLop)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MALOP", typeof(string));
            dt.Columns.Add("TENLOP", typeof(string));
            dt.Columns.Add("SISO", typeof(int));
            dt.Columns.Add("TENKHOI", typeof(string));
            dt.Columns.Add("MAKHOI", typeof(string));
            dt.Columns.Add("TENNAMHOC", typeof(string));

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = db.sp_TimLopTheoMaLop(maLop);
                foreach (var i in ds)
                {
                    DataRow r = dt.NewRow();
                    if (i.MALOP != null)
                        r["MALOP"] = i.MALOP;
                    if (i.TENLOP != null)
                        r["TENLOP"] = i.TENLOP;
                    if (i.SISO != null)
                        r["SISO"] = i.SISO.Value;
                    if (i.TENKHOI != null)
                        r["TENKHOI"] = i.TENKHOI;
                    if (i.MAKHOI != null)
                        r["MAKHOI"] = i.MAKHOI;
                    if (i.TENNAMHOC != null)
                        r["TENNAMHOC"] = i.TENNAMHOC;
                    dt.Rows.Add(r);
                }
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
    }
}
