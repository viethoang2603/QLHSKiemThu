using NMCNPM_QLHS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.TEST
{
    public static class RecoveryClass
    {
        public static LOP Clone(this LOP other)
        {
            return new LOP()
            {
                MALOP = other.MALOP,
                MAKHOI = other.MAKHOI,
                TENLOP = other.TENLOP,
                SISO = other.SISO,
            };
        }

        public static QUATRINHHOC Clone(this QUATRINHHOC other)
        {
            return new QUATRINHHOC()
            {
                MAQTHOC = other.MAQTHOC,
                MALOP = other.MALOP,
                MAHS = other.MAHS,
                MAHK = other.MAHK,
                DIEMTBHK = other.DIEMTBHK,
            };
        }

        public static BANGDIEMMON Clone(this BANGDIEMMON other)
        {
            return new BANGDIEMMON()
            {
                MABANGDIEMMON = other.MABANGDIEMMON,
                MAQTHOC = other.MAQTHOC,
                MAMONHOC = other.MAMONHOC,
                DIEMTB = other.DIEMTB,
            };
        }

        public static CT_DIEMMON Clone(this CT_DIEMMON other)
        {
            return new CT_DIEMMON()
            {
                MABANGDIEMMON = other.MABANGDIEMMON,
                MALHKT = other.MALHKT,
                DIEM = other.DIEM,
            };
        }

        public static BAOCAOTONGKETMON Clone(this BAOCAOTONGKETMON other)
        {
            return new BAOCAOTONGKETMON()
            {
                MABCTKMON = other.MABCTKMON,
                MAMONHOC = other.MAMONHOC,
                MAHOCKY = other.MAHOCKY,
            };
        }

        public static BAOCAOTONGKETHK Clone(this BAOCAOTONGKETHK other)
        {
            return new BAOCAOTONGKETHK()
            {
                MAHK = other.MAHK,
                MALOP = other.MALOP,
                SISO = other.SISO,
                SOLUONGDAT = other.SOLUONGDAT,
                TYLE = other.TYLE
            };
        }

        public static CT_BCTKMON Clone(this CT_BCTKMON other)
        {
            return new CT_BCTKMON()
            {
                MABCTKMON = other.MABCTKMON,
                MALOP = other.MALOP,
                SISO = other.SISO,
                SOLUONGDAT = other.SOLUONGDAT,
                TYLE = other.TYLE,
            };
        }

        public static void OverwritedBy(this LOP me, LOP other)
        {
            me.MALOP = other.MALOP;
            me.MAKHOI = other.MAKHOI;
            me.TENLOP = other.TENLOP;
            me.SISO = other.SISO;
        }

        public static void OverwritedBy(this QUATRINHHOC me, QUATRINHHOC other)
        {
            me.MAQTHOC = other.MAQTHOC;
            me.MALOP = other.MALOP;
            me.MAHS = other.MAHS;
            me.MAHK = other.MAHK;
            me.DIEMTBHK = other.DIEMTBHK;
        }

        public static void OverwritedBy(this BANGDIEMMON me, BANGDIEMMON other)
        {
            me.MABANGDIEMMON = other.MABANGDIEMMON;
            me.MAQTHOC = other.MAQTHOC;
            me.MAMONHOC = other.MAMONHOC;
            me.DIEMTB = other.DIEMTB;
        }

        public static void OverwritedBy(this CT_DIEMMON me, CT_DIEMMON other)
        {
            me.MABANGDIEMMON = other.MABANGDIEMMON;
            me.MALHKT = other.MALHKT;
            me.DIEM = other.DIEM;
        }

        public static void OverwritedBy(this BAOCAOTONGKETMON me, BAOCAOTONGKETMON other)
        {
            me.MABCTKMON = other.MABCTKMON;
            me.MAMONHOC = other.MAMONHOC;
            me.MAHOCKY = other.MAHOCKY;
        }

        public static void OverwritedBy(this BAOCAOTONGKETHK me, BAOCAOTONGKETHK other)
        {
            me.MAHK = other.MAHK;
            me.MALOP = other.MALOP;
            me.SISO = other.SISO;
            me.SOLUONGDAT = other.SOLUONGDAT;
            me.TYLE = other.TYLE;
        }

        public static void OverwritedBy(this CT_BCTKMON me, CT_BCTKMON other)
        {
            me.MABCTKMON = other.MABCTKMON;
            me.MALOP = other.MALOP;
            me.SISO = other.SISO;
            me.SOLUONGDAT = other.SOLUONGDAT;
            me.TYLE = other.TYLE;
        }
    }
}
