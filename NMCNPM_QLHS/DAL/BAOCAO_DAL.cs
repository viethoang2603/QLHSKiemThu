using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.DAL
{
    class BAOCAO_DAL
    {
        // Lấy báo cáo tổng kết học kỳ
        public static DataTable layBaoCaoTongKetHK(string maHocKy, string maNamHoc)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TENLOP", typeof(string));
            dt.Columns.Add("SISO", typeof(int));
            dt.Columns.Add("SOLUONGDAT", typeof(int));
            dt.Columns.Add("TYLE", typeof(string));

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var lst = db.sp_LayBaoCaoTongKetHocKy(maHocKy, maNamHoc);
                foreach (var i in lst)
                {
                    DataRow r = dt.NewRow();
                    if (i.TENLOP != null)
                        r["TENLOP"] = i.TENLOP;
                    if (i.SISO != null)
                        r["SISO"] = i.SISO.Value;
                    if (i.SOLUONGDAT != null)
                        r["SOLUONGDAT"] = i.SOLUONGDAT.Value;
                    if (i.TYLE != null)
                        r["TYLE"] = i.TYLE;
                    dt.Rows.Add(r);
                }
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        // Lấy báo cáo tổng kết môn
        public static DataTable layBaoCaoTongKetMon(string maMonHoc, string maHocKy, string maNamHoc)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TENLOP", typeof(string));
            dt.Columns.Add("SISO", typeof(int));
            dt.Columns.Add("SOLUONGDAT", typeof(int));
            dt.Columns.Add("TYLE", typeof(string));

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var lst = db.sp_LayBaoCaoTongKetMon(maMonHoc, maHocKy, maNamHoc);
                foreach (var i in lst)
                {
                    DataRow r = dt.NewRow();
                    if (i.TENLOP != null)
                        r["TENLOP"] = i.TENLOP;
                    if (i.SISO != null)
                        r["SISO"] = i.SISO.Value;
                    if (i.SOLUONGDAT != null)
                        r["SOLUONGDAT"] = i.SOLUONGDAT.Value;
                    if (i.TYLE != null)
                        r["TYLE"] = i.TYLE;
                    dt.Rows.Add(r);
                }
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

    }
}
