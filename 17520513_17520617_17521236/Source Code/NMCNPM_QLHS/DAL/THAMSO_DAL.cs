using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.DAL
{
    class THAMSO_DAL
    {
        // Lấy tham số
        public static THAMSO LayThamSo(string tenThamSo)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                return db.THAMSOs.Where(a => a.TENTHAMSO == tenThamSo).FirstOrDefault();
            }
        }

        // Lưu quy định
        public static void LuuQuyDinh(double tuoiToiThieu, double tuoiToiDa, double siSoToiDa,
                                    double diemToiThieu, double diemToiDa, double diemDatMon, double diemDatHK)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                db.sp_LuuQuyDinh(tuoiToiThieu, tuoiToiDa, siSoToiDa, diemToiThieu, diemToiDa, diemDatMon, diemDatHK);
            }
        }
        
    }
}
