using NMCNPM_QLHS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.BUS
{
    class LOAIHINHKIEMTRA_BUS
    {
        // Lấy tất cả các LHKT
        public static List<LOAIHINHKIEMTRA> LayTatCaLHKT()
        {
            return LOAIHINHKIEMTRA_DAL.LayTatCaLHKT();
        }

        // Lấy hệ số
        public static int layHeSo(string maHK)
        {
            return LOAIHINHKIEMTRA_DAL.layHeSo(maHK);
        }

        // Sửa hệ số LHKT
        public static void update(string maLHKT, int heSo)
        {
            LOAIHINHKIEMTRA_DAL.Update(maLHKT, heSo);
        }
    }
}
