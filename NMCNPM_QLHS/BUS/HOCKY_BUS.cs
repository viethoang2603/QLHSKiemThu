using NMCNPM_QLHS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.BUS
{
    class HOCKY_BUS
    {
        // Lấy tất cả các học kỳ
        public static List<HOCKY> LayTatCaHocKy()
        {
            return HOCKY_DAL.LayTatCaHocKy();
        }

        // Lấy hệ số
        public static int layHeSo(string maHK)
        {
            return HOCKY_DAL.layHeSo(maHK);
        }

        // Sửa hệ số học kỳ
        public static void update(string maHK, int heSo)
        {
            HOCKY_DAL.Update(maHK, heSo);
        }
    }
}
