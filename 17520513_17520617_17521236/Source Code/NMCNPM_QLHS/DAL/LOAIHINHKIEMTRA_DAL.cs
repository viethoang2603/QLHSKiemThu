using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.DAL
{
    class LOAIHINHKIEMTRA_DAL
    {
        // Lấy tất cả các loại hình kiểm tra
        public static List<LOAIHINHKIEMTRA> LayTatCaLHKT()
        {
            List<LOAIHINHKIEMTRA> lst = new List<LOAIHINHKIEMTRA>();

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = db.LOAIHINHKIEMTRAs.ToList();
                foreach (var x in ds)
                {
                    LOAIHINHKIEMTRA lhkt = new LOAIHINHKIEMTRA();
                    {
                        lhkt.MALHKT = x.MALHKT;
                        lhkt.TENLHKT = x.TENLHKT;
                        lhkt.HESO = x.HESO;
                        lst.Add(lhkt);
                    }
                }
            }
            return lst;
        }

        // Lấy hệ số
        public static int layHeSo(string maLHKT)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                LOAIHINHKIEMTRA lhkt = db.LOAIHINHKIEMTRAs.Where(a => a.MALHKT == maLHKT).FirstOrDefault();
                return lhkt.HESO.Value;
            }
        }

        // Sửa hệ số LHKT
        public static void Update(string maLHKT, int heSo)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                LOAIHINHKIEMTRA lhkt = db.LOAIHINHKIEMTRAs.Where(a => a.MALHKT == maLHKT).FirstOrDefault();
                lhkt.HESO = heSo;
                db.SubmitChanges();
            }
        }
    }
}
