using NMCNPM_QLHS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.BUS
{
    class LOAINGUOIDUNG_BUS
    {
        // Lấy tất cả các loại người dùng
        public static List<LOAINGUOIDUNG> LayTatCaLoaiNguoiDung()
        {
            return LOAINGUOIDUNG_DAL.LayTatCaLoaiNguoiDung();
        }
    }
}
