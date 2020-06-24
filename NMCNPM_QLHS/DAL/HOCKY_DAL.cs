using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.DAL
{
    class HOCKY_DAL
    {
        // Lấy tất cả các học kỳ
        public static List<HOCKY> LayTatCaHocKy()
        {
            List<HOCKY> lst = new List<HOCKY>();

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = db.HOCKies.ToList();
                foreach (var x in ds)
                {
                    HOCKY hocKy = new HOCKY();
                    {
                        hocKy.MAHK = x.MAHK;
                        hocKy.TENHOCKY = x.TENHOCKY;
                        hocKy.HESO = x.HESO;
                        lst.Add(hocKy);
                    }
                }
            }
            return lst;
        }

        // Lấy hệ số
        public static int layHeSo(string maHK)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                HOCKY hk = db.HOCKies.Where(a => a.MAHK == maHK).FirstOrDefault();
                return hk.HESO.Value;
            }
        }

        // Sửa hệ số học kỳ
        public static void Update(string maHK, int heSo)
        {
            if(heSo < 1)
                return;
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                HOCKY hk = db.HOCKies.Where(a => a.MAHK == maHK).FirstOrDefault();
                hk.HESO = heSo;
                db.SubmitChanges();
            }
        }
    }
}
