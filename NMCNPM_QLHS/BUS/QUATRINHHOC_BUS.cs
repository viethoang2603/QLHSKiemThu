using NMCNPM_QLHS.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMCNPM_QLHS.BUS
{
    class QUATRINHHOC_BUS
    {
        // Tìm quá trình học của học sinh
        public static DataTable LayQuaTrinhHocCuaHocSinh(string maHS)
        {
            return QUATRINHHOC_DAL.LayQuaTrinhHocCuaHocSinh(maHS);
        }

        // Lưu phân lớp
        public static void LuuPhanLopHS(ListView hocSinh, string maLop, string maHocKy)
        {

            foreach (ListViewItem item in hocSinh.Items)
            {
                QUATRINHHOC_DAL.LuuPhanLopHS(item.SubItems[0].Text.ToString(), maLop, maHocKy);
            }

        }

        // Kiểm tra sĩ số
        public static bool KiemTraSiSo(string maLop, string maHK, int soHS1, int soHS2)
        {
            int siSoHienTai = LOP_DAL.LaySiSoLop(maLop, maHK);
            double siSoToiDa = THAMSO_BUS.LayThamSo("SISOTOIDA");
            if (soHS1 + soHS2 > siSoToiDa)
                return false;
            return true;
        }

        // Kiểm tra tồn tại qth học sinh trong lớp, học kỳ
        public static bool KiemTraTonTai(string maHS, string maLop, string maHocKy)
        {
            return QUATRINHHOC_DAL.KiemTraTonTai(maHS, maLop, maHocKy);
        }
    }
}
