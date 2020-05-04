using DevExpress.XtraGrid.Views.Grid;
using NMCNPM_QLHS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.BUS
{
    class MONHOC_BUS
    {
        // Lấy tất cả các môn học
        public static List<MONHOC> LayTatCaMonHoc()
        {
            return MONHOC_DAL.LayTatCaMonHoc();
        }

        // Thêm môn học
        public static void insert(string maMH, string tenMH)
        {
            MONHOC_DAL.insert(maMH, tenMH);
        }

        // Sửa môn học
        public static void update(string maMH, string tenMH)
        {
            MONHOC_DAL.update(maMH, tenMH);
        }

        // Xóa môn học
        public static void delete(string maMH)
        {
            MONHOC_DAL.delete(maMH);
        }

        // auto_idMonHoc
        public static string autoID(GridView dgv)
        {
            string maxID = "";
            int max = int.Parse(dgv.GetRowCellDisplayText(0, dgv.Columns[0]).Substring(2));
            for (int i = 1; i < dgv.RowCount; i++)
                if (int.Parse(dgv.GetRowCellDisplayText(i, dgv.Columns[0]).Substring(2)) > max)
                    max = int.Parse(dgv.GetRowCellDisplayText(i, dgv.Columns[0]).Substring(2));
            max = max + 1;
            if (max < 9)
                maxID = "MH0" + max.ToString();
            else
                maxID = "MH" + max.ToString();
            return maxID;
        }

        // Kiểm tra số lượng môn học
        public static bool KiemtraSoLuongMonHoc(GridView dgv)
        {
            int soLuongMHToiDa = int.Parse(THAMSO_BUS.LayThamSo("SOLUONGMONHOC").ToString());
            if (dgv.RowCount == soLuongMHToiDa)
                return false;
            return true;
        }
    }
}
