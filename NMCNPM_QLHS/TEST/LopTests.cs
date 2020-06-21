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

        bool needRecovery = false;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                needRecovery = false;
                //RecoveryClass.CachedAll(db, true, true, true, true, true, true);
                deletedLop = db.LOPs.SingleOrDefault(lop => lop.MALOP == deletedLopCode);
                var hocSinhs = db.QUATRINHHOCs.Where(x => x.MALOP == deletedLopCode).Select(qth => qth.HOCSINH).Distinct().ToList();

                qths = new List<QUATRINHHOC>();
                for (int i = 0; i < hocSinhs.Count; ++i)
                {
                    var y = db.QUATRINHHOCs.Where(qth => qth.MAHS == hocSinhs[i].MAHS);
                    qths.AddRange(y);
                }
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
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext()) {
                LOP_DAL.Insert(maLop, tenLop, maKhoi);
                Assert.IsTrue(db.LOPs.Any(lop => lop.MALOP == maLop));
            }
        }

        string deletedLopCode = "LOP02";
        [Test]
        [TestCase("LOP02")]
        public void Lop_XoaLop_ThanhCong(string maLop)
        {
            needRecovery = true;
            deletedLopCode = maLop;
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                int deletedQthsNumber = db.QUATRINHHOCs.Count(qth => qth.MALOP == maLop);
                int deletedBctkHocKy = db.BAOCAOTONGKETHKs.Count(bc => bc.MALOP == maLop);
                int deletedct_tkMon = db.CT_BCTKMONs.Count(bc => bc.MALOP == maLop);

                int allQths = db.QUATRINHHOCs.Count();
                int allBcTkHocKys = db.BAOCAOTONGKETHKs.Count();
                int allCtBcTkMons = db.CT_BCTKMONs.Count();

                LOP_DAL.Delete(maLop);

                Assert.AreEqual(db.BAOCAOTONGKETHKs.Count(), allBcTkHocKys - deletedBctkHocKy);
                Assert.AreEqual(db.CT_BCTKMONs.Count(), allCtBcTkMons - deletedct_tkMon);
                Assert.AreEqual(db.QUATRINHHOCs.Count(), allQths - deletedQthsNumber);
            }
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
            if (needRecovery)
            {
                RecoveryClass.DisableAllTrigger();
                try
                {

                    using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
                    {
                        //RecoveryClass.RecoverWithCached(db);
                        db.LOPs.InsertOnSubmit(deletedLop.Clone());
                        db.SubmitChanges();

                        for (int i = 0; i < qths.Count; ++i)
                            qths[i].InsertOrUpdate(db);

                        db.SubmitChanges();

                        for (int i = 0; i < bdms.Count; ++i)
                            bdms[i].InsertOrUpdate(db);

                        db.SubmitChanges();

                        for (int i = 0; i < ct_diemMons.Count; ++i)
                            ct_diemMons[i].InsertOrUpdate(db);

                        db.SubmitChanges();

                        for (int i = 0; i < ct_BaoCaoTKMons.Count; ++i)
                            ct_BaoCaoTKMons[i].InsertOrUpdate(db);

                        db.SubmitChanges();

                        for (int i = 0; i < baoCaoTKHKys.Count; ++i)
                            baoCaoTKHKys[i].InsertOrUpdate(db);

                        db.SubmitChanges();
                        //array name, db.TEN, Primary key
                    }
                }
                catch (Exception e) { }
                finally
                {
                    RecoveryClass.EnableAllTrigger();
                }
            }
        }
    }
}
