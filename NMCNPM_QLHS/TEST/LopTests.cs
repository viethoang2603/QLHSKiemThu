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
        SQL_QLHSDataContext db;

        void BackupForDeleted(string maLop)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                needRecovery = true;
                //RecoveryClass.CachedAll(db, true, true, true, true, true, true);
                deletedLop = db.LOPs.SingleOrDefault(lop => lop.MALOP == maLop);
                var hocSinhs = db.QUATRINHHOCs.Where(x => x.MALOP == maLop).Select(qth => qth.HOCSINH).Distinct().ToList();

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
                baoCaoTKHKys = db.BAOCAOTONGKETHKs.Where(bc => bc.MALOP == maLop).ToList();
                ct_BaoCaoTKMons = db.CT_BCTKMONs.Where(bc => bc.MALOP == maLop).ToList();
            }
        }

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            db = new SQL_QLHSDataContext();
        }

        [Test]
        [TestCase("LOP19", "12/4", "KHOI03")]
        public void ThemLop_KhongTrung_ThanhCong(string maLop, string tenLop, string maKhoi)
        {
            LOP_DAL.Insert(maLop, tenLop, maKhoi);
            Assert.IsTrue(db.LOPs.Any(lop => lop.MALOP == maLop));
        }

        [Test]
        [TestCase("LOP01", "12/4", "KHOI03")]
        public void ThemLop_Trung_DbException(string maLop, string tenLop, string maKhoi)
        {
            Assert.Throws<System.Data.SqlClient.SqlException>(() => LOP_DAL.Insert(maLop, tenLop, maKhoi));
        }

        [Test]
        [TestCase("LOP20", "12/4", "KHOI100")]
        public void ThemLop_KhongTonTaiMaKhoi_DbException(string maLop, string tenLop, string maKhoi)
        {
            Assert.Throws<System.Data.SqlClient.SqlException>(() => LOP_DAL.Insert(maLop, tenLop, maKhoi));
        }

        [Test]
        [TestCase("LOP01", "13/4", "KHOI06")]
        public void CapNhat_MaKhoiTonTai_Success(string maLop, string tenLop, string maKhoi)
        {
            LOP_DAL.Update(maLop, tenLop, maKhoi);
            LOP lop = db.LOPs.SingleOrDefault(l => l.MALOP == maLop);

            Assert.NotNull(lop);
            Assert.AreEqual(tenLop, lop.TENLOP);
            Assert.AreEqual(maKhoi, lop.MAKHOI);
        }

        [Test]
        [TestCase("LOP01", "13/4", "KHOI07")]
        public void CapNhat_MaKhoiKoTonTai_DbException(string maLop, string tenLop, string maKhoi)
        {
            //SQLException không tồn tại ForegnKey 
            Assert.Throws<System.Data.SqlClient.SqlException>(() => LOP_DAL.Update(maLop, tenLop, maKhoi));
        }

        [Test]
        [TestCase("LOP91", "13/4", "KHOI07")]
        public void CapNhat_MaLopKoTonTai_NullException(string maLop, string tenLop, string maKhoi)
        {
            //NullException - Không tồn tại lớp
            Assert.Throws<NullReferenceException>(() => LOP_DAL.Update(maLop, tenLop, maKhoi));
        }

        [Test]
        [TestCase("LOP01")]
        [TestCase("LOP02")] //Vì xóa mã học sinh của quá trình học nên xóa luôn lớp khác -> test fail 
        [TestCase("LOP03")]
        [TestCase("LOP04")]
        public void Xoa_TonTai_ThanhCong(string maLop)
        {
            BackupForDeleted(maLop);

            int deletedQthsNumber = db.QUATRINHHOCs.Count(qth => qth.MALOP == maLop);
            int deletedBctkHocKy = db.BAOCAOTONGKETHKs.Count(bc => bc.MALOP == maLop);
            int deletedct_tkMon = db.CT_BCTKMONs.Count(bc => bc.MALOP == maLop);

            int allQths = db.QUATRINHHOCs.Count();
            int allBcTkHocKys = db.BAOCAOTONGKETHKs.Count();
            int allCtBcTkMons = db.CT_BCTKMONs.Count();

            LOP_DAL.Delete(maLop);

            Assert.AreEqual(allBcTkHocKys - deletedBctkHocKy, db.BAOCAOTONGKETHKs.Count());
            Assert.AreEqual(allCtBcTkMons - deletedct_tkMon, db.CT_BCTKMONs.Count());
            Assert.AreEqual(allQths - deletedQthsNumber, db.QUATRINHHOCs.Count());
        }

        [Test]
        [TestCase("LOP91")]
        [TestCase("LOP92")]
        [TestCase("LOP93")]
        public void Xoa_KhongTonTai_SLRecordsXoaBang0(string maLop)
        {
            int allQths = db.QUATRINHHOCs.Count();
            int allBcTkHocKys = db.BAOCAOTONGKETHKs.Count();
            int allCtBcTkMons = db.CT_BCTKMONs.Count();

            LOP_DAL.Delete(maLop);

            Assert.AreEqual(allBcTkHocKys, db.BAOCAOTONGKETHKs.Count());
            Assert.AreEqual(allCtBcTkMons, db.CT_BCTKMONs.Count());
            Assert.AreEqual(allQths, db.QUATRINHHOCs.Count());
        }

        [Test]
        [TestCase("LOP01", "HK01", 4)]
        [TestCase("LOP01", "HK02", 1)]
        public void LaySiSo_TonTai_ThanhCong(string maLop, string maHocKy, int result)
        {
            Assert.AreEqual(result, LOP_DAL.LaySiSoLop(maLop, maHocKy));
        }

        [Test]
        [TestCase("LOP91", "HK01", 0)] //Không tồn tại lớp
        [TestCase("LOP01", "HK91", 0)] //Không tồn tại khối
        public void LaySiSo_KoTonTai_LuonTraVe0(string maLop, string maHocKy, int result)
        {
            Assert.AreEqual(result, LOP_DAL.LaySiSoLop(maLop, maHocKy));
        }

        [TearDown]
        //TODO: OPTIMIZE
        public void TearDown()
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
                catch (Exception e)
                {
                    e = e;
                }
                finally
                {
                    RecoveryClass.EnableAllTrigger();
                    needRecovery = false;
                }
            }

            LOP_DAL.Update("LOP01", "10/1", "KHOI01");
        }
    }
}
