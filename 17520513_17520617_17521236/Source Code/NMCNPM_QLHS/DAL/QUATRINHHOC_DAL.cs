using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.DAL
{
    class QUATRINHHOC_DAL
    {
        // Tìm quá trình học của học sinh
        public static DataTable LayQuaTrinhHocCuaHocSinh(string maHS)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TENNAMHOC", typeof(string));
            dt.Columns.Add("TENHOCKY", typeof(string));
            dt.Columns.Add("TENLOP", typeof(string));
            dt.Columns.Add("DIEMTBHK", typeof(double));

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var lst = db.sp_LayQTHCuaHocSinh(maHS);
                foreach (var i in lst)
                {
                    DataRow r = dt.NewRow();
                    if (i.TENNAMHOC != null)
                        r["TENNAMHOC"] = i.TENNAMHOC;
                    if (i.TENHOCKY != null)
                        r["TENHOCKY"] = i.TENHOCKY;
                    if (i.TENLOP != null)
                        r["TENLOP"] = i.TENLOP;
                    if (i.DIEMTBHK != null)
                        r["DIEMTBHK"] = i.DIEMTBHK;
                    dt.Rows.Add(r);
                }
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        // Lưu phân lớp
        public static void LuuPhanLopHS(string maHS, string maLop, string maHocKy)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                if (maHocKy == "HK02")
                    db.sp_ThemQTH1HocKy(maHS, maLop, maHocKy);
                else
                    db.sp_ThemQTH(maHS, maLop);
            }
        }

        // Kiểm tra tồn tại qth học sinh trong lớp, học kỳ
        public static bool KiemTraTonTai(string maHS, string maLop, string maHocKy)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                return db.QUATRINHHOCs.Any(a => a.MAHS == maHS && a.MALOP == maLop && a.MAHK == maHocKy);
            }
        }

    }
}
