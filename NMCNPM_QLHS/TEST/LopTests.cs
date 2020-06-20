using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NMCNPM_QLHS.DAL;
using NUnit.Framework;

namespace NMCNPM_QLHS.TEST
{
    [TestFixture]
    class LopTests
    {
        List<QUATRINHHOC> qths = null;
        List<BANGDIEMMON> bdms = null;
        List<CT_DIEMMON> ct_diemMons = null;
        List<BAOCAOTONGKETHK> baoCaoTKHKys = null;
        List<CT_BCTKMON> ct_BaoCaoTKMons = null;
        LOP deletedLop = null;
        string deletedLopCode = "LOP02";
        System.Data.Linq.Table<LOP> lops = null;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                deletedLop = db.LOPs.SingleOrDefault(lop => lop.MALOP == deletedLopCode);
                qths = db.QUATRINHHOCs.Where(x => x.MALOP == deletedLopCode).ToList();
                bdms = new List<BANGDIEMMON>();
                ct_diemMons = new List<CT_DIEMMON>();
                foreach (var qth in qths)
                {
                    List<BANGDIEMMON> newBDMs = db.BANGDIEMMONs.Where(bdm => bdm.MAQTHOC == qth.MAQTHOC).ToList();
                    foreach (var bdm in newBDMs)
                    {
                        List<CT_DIEMMON> newCTDMs = db.CT_DIEMMONs.Where(ctdiemMon => ctdiemMon.MABANGDIEMMON == bdm.MABANGDIEMMON).ToList();
                        ct_diemMons.AddRange(newCTDMs);
                    }
                    bdms.AddRange(newBDMs);
                }
                baoCaoTKHKys = db.BAOCAOTONGKETHKs.Where(bc => bc.MALOP == deletedLopCode).ToList();
                ct_BaoCaoTKMons = db.CT_BCTKMONs.Where(bc => bc.MALOP == deletedLopCode).ToList();
            }
        }

        [Test]
        [TestCase("LOP19", "12/4", "KHOI03")]
        public void Lop_ThemLop_ThanhCong(string maLop, string tenLop, string maKhoi)
        {
            LOP_DAL.Insert(maLop, tenLop, maKhoi);
        }

        [Test]
        [TestCase("LOP02")]
        public void Lop_XoaLop_ThanhCong(string maLop)
        {
            deletedLopCode = maLop;
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                LOP_DAL.Delete(maLop);
                bool bctkHKExist = db.BAOCAOTONGKETHKs.Any(bc => bc.MALOP == maLop);
                bool bctkMonExist = db.CT_BCTKMONs.Any(bc => bc.MALOP == maLop);
                bool qthsExist = db.QUATRINHHOCs.Any(bc => bc.MALOP == maLop);

                Assert.IsFalse(bctkHKExist);
                Assert.IsFalse(bctkMonExist);
                Assert.IsFalse(qthsExist);
            }
            Assert.IsTrue(true);
        }

        [Test]
        [TestCase("LOP01", "HK01", 4)]
        [TestCase("LOP01", "HK02", 1)]
        [TestCase("LOP02", "HK02", 3)]
        public void Lop_LaySiSo_ThanhCong(string maLop, string maHocKy, int result)
        {
            Assert.AreEqual(result, LOP_DAL.LaySiSoLop(maLop, maHocKy));
        }

        [OneTimeTearDown]
        //TODO: OPTIMIZE
        public void OneTimeTearDown()
        {
            LOP_DAL.Delete("LOP19");
            if (qths != null)
            {
                using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
                {
                    db.LOPs.InsertOnSubmit(deletedLop.Clone());

                    for (int i = 0; i < qths.Count; ++i)
                    {
                        var exists = db.QUATRINHHOCs.SingleOrDefault(qth => qth.MAQTHOC == qths[i].MAQTHOC);
                        if (exists != null)
                            exists.OverwritedBy(qths[i]);
                        else
                            db.QUATRINHHOCs.InsertOnSubmit(qths[i].Clone());
                    }

                    db.SubmitChanges();

                    for (int i = 0; i < bdms.Count; ++i)
                    {
                        var exists = db.BANGDIEMMONs.SingleOrDefault(record => record.MABANGDIEMMON == bdms[i].MABANGDIEMMON);
                        if (exists != null)
                            exists.OverwritedBy(bdms[i]);
                        else
                            db.BANGDIEMMONs.InsertOnSubmit(bdms[i].Clone());
                    }

                    db.SubmitChanges();

                    for (int i = 0; i < ct_diemMons.Count; ++i)
                    {
                        var exists = db.CT_DIEMMONs.SingleOrDefault(record => (record.MABANGDIEMMON == ct_diemMons[i].MABANGDIEMMON && record.MALHKT == ct_diemMons[i].MALHKT));

                        if (exists != null)
                            exists.OverwritedBy(ct_diemMons[i]);
                        else
                            db.CT_DIEMMONs.InsertOnSubmit(ct_diemMons[i].Clone());
                    }

                    db.SubmitChanges();

                    for (int i = 0; i < ct_BaoCaoTKMons.Count; ++i)
                    {
                        var exists = db.CT_BCTKMONs.SingleOrDefault(record => (record.MABCTKMON == ct_BaoCaoTKMons[i].MABCTKMON && record.MALOP == ct_BaoCaoTKMons[i].MALOP));

                        if (exists != null)
                            exists.OverwritedBy(ct_BaoCaoTKMons[i]);
                        else
                            db.CT_BCTKMONs.InsertOnSubmit(ct_BaoCaoTKMons[i].Clone());
                    }

                    db.SubmitChanges();

                    for (int i = 0; i < baoCaoTKHKys.Count; ++i)
                    {
                        var exists = db.BAOCAOTONGKETHKs.SingleOrDefault(record => (record.MAHK == baoCaoTKHKys[i].MAHK && record.MALOP == baoCaoTKHKys[i].MALOP));

                        if (exists != null)
                            exists.OverwritedBy(baoCaoTKHKys[i]);
                        else
                            db.BAOCAOTONGKETHKs.InsertOnSubmit(baoCaoTKHKys[i].Clone());
                    }

                    db.SubmitChanges();
                    //array name, db.TEN, Primary key
                }
            }
        }
    }
}
