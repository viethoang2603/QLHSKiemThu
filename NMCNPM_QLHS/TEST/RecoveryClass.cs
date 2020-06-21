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
        public static List<LOP> cachedLOPs;
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

        public static void CachedAll(
            SQL_QLHSDataContext db,
            bool lop = false,
            bool qth = false,
            bool bdm = false,
            bool ct_dm = false,
            bool bctkHKy = false,
            bool ct_BCTKMon = false
            )
        {
            cachedLOPs = lop ? db.LOPs.ToList() : null;
            cachedQTHs = qth ? db.QUATRINHHOCs.ToList() : null;
            cachedBDMs = bdm ? db.BANGDIEMMONs.ToList() : null;
            cachedCT_DMs = ct_dm ? db.CT_DIEMMONs.ToList() : null;
            cachedBCTKHKys = bctkHKy ? db.BAOCAOTONGKETHKs.ToList() : null;
            cachedCT_BCTKMONs = ct_BCTKMon ? db.CT_BCTKMONs.ToList() : null;
        }

        public static void RecoverWithCached(SQL_QLHSDataContext db) {
            if (cachedLOPs != null) {
                for (int i = 0; i < cachedLOPs.Count; ++i)
                    cachedLOPs[i].InsertOrUpdate(db);
            }
            if (cachedQTHs != null)
            {
                for (int i = 0; i < cachedQTHs.Count; ++i)
                    cachedQTHs[i].InsertOrUpdate(db);
            }
            if (cachedBDMs != null)
            {
                for (int i = 0; i < cachedBDMs.Count; ++i)
                    cachedBDMs[i].InsertOrUpdate(db);
            }
            if (cachedCT_DMs != null)
            {
                for (int i = 0; i < cachedCT_DMs.Count; ++i)
                    cachedCT_DMs[i].InsertOrUpdate(db);
            }
            if (cachedBCTKHKys != null)
            {
                for (int i = 0; i < cachedBCTKHKys.Count; ++i)
                    cachedBCTKHKys[i].InsertOrUpdate(db);
            }
            if (cachedCT_BCTKMONs != null)
            {
                for (int i = 0; i < cachedCT_BCTKMONs.Count; ++i)
                    cachedCT_BCTKMONs[i].InsertOrUpdate(db);
            }
            db.SubmitChanges();
        }

        public static void OverwritedBy(this LOP me, LOP other)
        {
            me.MALOP = other.MALOP;
            me.MAKHOI = other.MAKHOI;
            me.TENLOP = other.TENLOP;
            me.SISO = other.SISO;
        }

        public static void InsertOrUpdate(this LOP lop, SQL_QLHSDataContext db)
        {
            var exists = db.LOPs.SingleOrDefault(record => (record.MALOP == lop.MALOP));

            if (exists != null)
                exists.OverwritedBy(lop);
            else
                db.LOPs.InsertOnSubmit(lop.Clone());
        }

        public static List<QUATRINHHOC> cachedQTHs;
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

        public static void OverwritedBy(this QUATRINHHOC me, QUATRINHHOC other)
        {
            me.MAQTHOC = other.MAQTHOC;
            me.MALOP = other.MALOP;
            me.MAHS = other.MAHS;
            me.MAHK = other.MAHK;
            me.DIEMTBHK = other.DIEMTBHK;
        }

        public static void InsertOrUpdate(this QUATRINHHOC qth, SQL_QLHSDataContext db)
        {
            var exists = db.QUATRINHHOCs.SingleOrDefault(record => (record.MAQTHOC == qth.MAQTHOC));

            if (exists != null)
                exists.OverwritedBy(qth);
            else
                db.QUATRINHHOCs.InsertOnSubmit(qth.Clone());
        }

        public static List<BANGDIEMMON> cachedBDMs;
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

        public static void OverwritedBy(this BANGDIEMMON me, BANGDIEMMON other)
        {
            me.MABANGDIEMMON = other.MABANGDIEMMON;
            me.MAQTHOC = other.MAQTHOC;
            me.MAMONHOC = other.MAMONHOC;
            me.DIEMTB = other.DIEMTB;
        }

        public static void InsertOrUpdate(this BANGDIEMMON bdm, SQL_QLHSDataContext db)
        {
            var exists = db.BANGDIEMMONs.SingleOrDefault(record => (record.MABANGDIEMMON == bdm.MABANGDIEMMON));

            if (exists != null)
                exists.OverwritedBy(bdm);
            else
                db.BANGDIEMMONs.InsertOnSubmit(bdm.Clone());
        }

        public static List<CT_DIEMMON> cachedCT_DMs;
        public static CT_DIEMMON Clone(this CT_DIEMMON other)
        {
            return new CT_DIEMMON()
            {
                MABANGDIEMMON = other.MABANGDIEMMON,
                MALHKT = other.MALHKT,
                DIEM = other.DIEM,
            };
        }

        public static void OverwritedBy(this CT_DIEMMON me, CT_DIEMMON other)
        {
            me.MABANGDIEMMON = other.MABANGDIEMMON;
            me.MALHKT = other.MALHKT;
            me.DIEM = other.DIEM;
        }

        public static void InsertOrUpdate(this CT_DIEMMON ct_diemMon, SQL_QLHSDataContext db)
        {
            var exists = db.CT_DIEMMONs.SingleOrDefault(record => (record.MABANGDIEMMON == ct_diemMon.MABANGDIEMMON && record.MALHKT == ct_diemMon.MALHKT));

            if (exists != null)
                exists.OverwritedBy(ct_diemMon);
            else
                db.CT_DIEMMONs.InsertOnSubmit(ct_diemMon.Clone());
        }

        //public static BAOCAOTONGKETMON Clone(this BAOCAOTONGKETMON other)
        //{
        //    return new BAOCAOTONGKETMON()
        //    {
        //        MABCTKMON = other.MABCTKMON,
        //        MAMONHOC = other.MAMONHOC,
        //        MAHOCKY = other.MAHOCKY,
        //    };
        //}

        //public static void OverwritedBy(this BAOCAOTONGKETMON me, BAOCAOTONGKETMON other)
        //{
        //    me.MABCTKMON = other.MABCTKMON;
        //    me.MAMONHOC = other.MAMONHOC;
        //    me.MAHOCKY = other.MAHOCKY;
        //}

        //public static void InsertOrUpdate(this BAOCAOTONGKETMON bctkMon, SQL_QLHSDataContext db)
        //{
        //    var exists = db.BAOCAOTONGKETMONs.SingleOrDefault(record => (record.MABCTKMON == bctkMon.MABCTKMON));

        //    if (exists != null)
        //        exists.OverwritedBy(bctkMon);
        //    else
        //        db.BAOCAOTONGKETMONs.InsertOnSubmit(bctkMon.Clone());
        //}

        public static List<BAOCAOTONGKETHK> cachedBCTKHKys;
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

        public static void OverwritedBy(this BAOCAOTONGKETHK me, BAOCAOTONGKETHK other)
        {
            me.MAHK = other.MAHK;
            me.MALOP = other.MALOP;
            me.SISO = other.SISO;
            me.SOLUONGDAT = other.SOLUONGDAT;
            me.TYLE = other.TYLE;
        }

        public static void InsertOrUpdate(this BAOCAOTONGKETHK bctkHKy, SQL_QLHSDataContext db)
        {
            var exists = db.BAOCAOTONGKETHKs.SingleOrDefault(record => (record.MAHK == bctkHKy.MAHK && record.MALOP == bctkHKy.MALOP));

            if (exists != null)
                exists.OverwritedBy(bctkHKy);
            else
                db.BAOCAOTONGKETHKs.InsertOnSubmit(bctkHKy.Clone());
        }

        public static List<CT_BCTKMON> cachedCT_BCTKMONs;
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

        public static void OverwritedBy(this CT_BCTKMON me, CT_BCTKMON other)
        {
            me.MABCTKMON = other.MABCTKMON;
            me.MALOP = other.MALOP;
            me.SISO = other.SISO;
            me.SOLUONGDAT = other.SOLUONGDAT;
            me.TYLE = other.TYLE;
        }

        public static void InsertOrUpdate(this CT_BCTKMON ct_bctkMon, SQL_QLHSDataContext db)
        {
            var exists = db.CT_BCTKMONs.SingleOrDefault(record => (record.MABCTKMON == ct_bctkMon.MABCTKMON && record.MALOP == ct_bctkMon.MALOP));

            if (exists != null)
                exists.OverwritedBy(ct_bctkMon);
            else
                db.CT_BCTKMONs.InsertOnSubmit(ct_bctkMon.Clone());
        }


        public static void DisableAllTrigger()
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                db.ExecuteCommand("DISABLE TRIGGER ALL ON [dbo].[QUATRINHHOC]");
                db.ExecuteCommand("DISABLE TRIGGER ALL ON [dbo].[MONHOC]");
                db.ExecuteCommand("DISABLE TRIGGER ALL ON [dbo].[LOP]");
                db.ExecuteCommand("DISABLE TRIGGER ALL ON [dbo].[CT_DIEMMON]");
                db.ExecuteCommand("DISABLE TRIGGER ALL ON [dbo].[BANGDIEMMON]");
            }
        }

        public static void EnableAllTrigger()
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                db.ExecuteCommand("ENABLE TRIGGER ALL ON [dbo].[QUATRINHHOC]");
                db.ExecuteCommand("ENABLE TRIGGER ALL ON [dbo].[MONHOC]");
                db.ExecuteCommand("ENABLE TRIGGER ALL ON [dbo].[LOP]");
                db.ExecuteCommand("ENABLE TRIGGER ALL ON [dbo].[CT_DIEMMON]");
                db.ExecuteCommand("ENABLE TRIGGER ALL ON [dbo].[BANGDIEMMON]");
            }
        }

        public static void InsertOrUpdateList(List<dynamic> list, SQL_QLHSDataContext db)
        {
            for (int i = 0; i < list.Count; ++i)
                list[i].InsertOrUpdate(db);
        }
    }
}
