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
        public void LayTatCaHocKy_ThanhCong(int id, string MaHK, string TenHK, int heSo)
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
        public void LayHeSo_ThanhCong(string MaHK, int heSo)
        {
            Assert.AreEqual(heSo, HOCKY_DAL.layHeSo(MaHK));
        }

        [TestCase("HK01", 3)]
        [TestCase("HK03", 1)]
        [Test]
        public void LayHeSo_ThatBai(string MaHK, int heSo)
        {
            Assert.AreNotEqual(heSo, HOCKY_DAL.layHeSo(MaHK));
        }

        [Test]
        [TestCase("HK01", 2)]
        [TestCase("HK02", 0)]
        public void SuaHeSo_ThanhCong(string MaHK, int heSo)
        {
            HOCKY_DAL.Update(MaHK, heSo);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            HOCKY_DAL.Update("HK01", 1);
            HOCKY_DAL.Update("HK02", 2);
        }
    }

}