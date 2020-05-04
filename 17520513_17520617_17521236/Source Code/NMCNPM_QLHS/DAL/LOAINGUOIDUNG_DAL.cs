using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.DAL
{
    class LOAINGUOIDUNG_DAL
    {
        // Lấy tất cả các loại người dùng
        public static List<LOAINGUOIDUNG> LayTatCaLoaiNguoiDung()
        {
            List<LOAINGUOIDUNG> lst = new List<LOAINGUOIDUNG>();

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = db.LOAINGUOIDUNGs.ToList();
                foreach (var x in ds)
                {
                    LOAINGUOIDUNG lnd = new LOAINGUOIDUNG();

                    lnd.MALND = x.MALND;
                    lnd.TENLOAIND = x.TENLOAIND;
                    lst.Add(lnd);
                }
            }
            return lst;
        }
    }
}
