using NMCNPM_QLHS.DAL;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace NMCNPM_QLHS.TEST
{
    [TestFixture]
    public class HocKyTest
    {
        [Test]
        [TestCase(0, "HK01", "Học kỳ 1", 1)]
        [TestCase(1, "HK02", "Học kỳ 2", 2)]
        public void LayTatCaHocKy_Success(int id, string MaHK, string TenHK, int heSo)
        {
            List<HOCKY> hocKys;
            hocKys = HOCKY_DAL.LayTatCaHocKy();
            Assert.AreEqual(MaHK, hocKys[id].MAHK);
            Assert.AreEqual(TenHK, hocKys[id].TENHOCKY);
            Assert.AreEqual(heSo, hocKys[id].HESO);
        }

        [Test]
        [TestCase("HK01", 1)]
        [TestCase("HK02", 2)]
        public void LayHeSo_TonTaiHK_SuccessReturnInt(string MaHK, int heSo)
        {
            Assert.AreEqual(heSo, HOCKY_DAL.layHeSo(MaHK));
        }

        [Test]
        [TestCase("HK03")]
        public void LayHeSo_KhongTonTaiHK_NullException(string MaHK)
        {
            Assert.Throws<System.NullReferenceException>(() => HOCKY_DAL.layHeSo(MaHK));
        }

        [Test]
        [TestCase("HK01", 2)]
        [TestCase("HK02", 1)]
        public void SuaHeSo_TonTaiHK_Success(string MaHK, int heSo)
        {
            HOCKY_DAL.Update(MaHK, heSo);
            Assert.AreEqual(heSo, HOCKY_DAL.layHeSo(MaHK));
        }

        [Test]
        [TestCase("HK03")]
        public void SuaHeSo_KhongTonTaiHK_NullException(string MaHK)
        {
            Assert.Throws<System.NullReferenceException>(() => HOCKY_DAL.layHeSo(MaHK));
        }

        [Test]
        [TestCase("HK02", 0)]
        public void SuaHeSo_HeSoKhongHopLe_Failed(string MaHK, int heSo)
        {
            HOCKY_DAL.Update(MaHK, heSo);
            Assert.AreNotEqual(heSo, HOCKY_DAL.layHeSo(MaHK));
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            HOCKY_DAL.Update("HK01", 1);
            HOCKY_DAL.Update("HK02", 2);
        }
    }

}