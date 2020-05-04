using NMCNPM_QLHS.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.BUS
{
    class BAOCAO_BUS
    {
        // Lấy báo cáo tổng kết học kỳ
        public static DataTable layBaoCaoTongKetHK(string maHocKy, string maNamHoc)
        {
            return BAOCAO_DAL.layBaoCaoTongKetHK(maHocKy, maNamHoc);
        }

        // Lấy báo cáo tổng kết môn
        public static DataTable layBaoCaoTongKetMon(string maMonHoc, string maHocKy, string maNamHoc)
        {
            return BAOCAO_DAL.layBaoCaoTongKetMon(maMonHoc, maHocKy, maNamHoc);
        }
    }
}
