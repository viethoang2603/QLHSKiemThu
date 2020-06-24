using DevExpress.Office.Utils;
using NMCNPM_QLHS.DAL;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace NMCNPM_QLHS.TEST
{
    [TestFixture]
    public class KhoiLop
    {
        [Test]
        [TestCase(0, "KHOI01","NH01","10",4)]
        [TestCase(1, "KHOI02", "NH01", "11", 3)]
        [TestCase(2, "KHOI03", "NH01", "12", 3)]
        [TestCase(3, "KHOI04", "NH02", "10", 3)]
        [TestCase(4, "KHOI05", "NH02", "11", 2)]
        [TestCase(5, "KHOI06", "NH02", "12", 2)]
        public void LayTatCaKhoi_ThanhCong(int id, string maKhoi, string maNam, string tenKhoi, int soLop)
        {
            List<KHOILOP> khoiLops = KHOILOP_DAL.LayTatCaKhoi();
            Assert.AreEqual(maKhoi, khoiLops[id].MAKHOI);
            Assert.AreEqual(maNam, khoiLops[id].MANAM);
            Assert.AreEqual(tenKhoi, khoiLops[id].TENKHOI);
            Assert.AreEqual(soLop, khoiLops[id].SOLOP);
        }

        [Test]
        [TestCase(0, "NH01", "KHOI01", "10", 4)]
        [TestCase(1, "NH01", "KHOI02", "11", 3)]
        [TestCase(2, "NH01", "KHOI03", "12", 3)]
        [TestCase(0, "NH02", "KHOI04", "10", 3)]
        [TestCase(1, "NH02", "KHOI05", "11", 2)]
        [TestCase(2, "NH02", "KHOI06", "12", 2)]
        public void LayKhoiTheoNamHoc_ThanhCong(int id, string maNamHoc, string maKhoi, string tenKhoi, int soLop)
        {
            List<KHOILOP> khoiLops = KHOILOP_DAL.LayKhoiTheoNamHoc(maNamHoc);
            Assert.AreEqual(maKhoi, khoiLops[id].MAKHOI);
            Assert.AreEqual(maNamHoc, khoiLops[id].MANAM);
            Assert.AreEqual(tenKhoi, khoiLops[id].TENKHOI);
            Assert.AreEqual(soLop, khoiLops[id].SOLOP);
        }

        [Test]
        [TestCase(0, "NH01", "KHOI01", "10")]
        [TestCase(1, "NH01", "KHOI02", "11")]
        [TestCase(0, "NH02", "KHOI04", "10")]
        [TestCase(1, "NH02", "KHOI05", "11")]
        public void LayKhoi1011_ThanhCong(int id, string maNamHoc, string maKhoi, string tenKhoi)
        {
            List<KHOILOP> khoiLops = KHOILOP_DAL.LayKhoi1011(maNamHoc);
            Assert.AreEqual(maKhoi, khoiLops[id].MAKHOI);
            Assert.AreEqual(tenKhoi, khoiLops[id].TENKHOI);
        }

        [Test]
        [TestCase("KHOI01", "NH01", "10", 4)]
        [TestCase("KHOI02", "NH01", "11", 3)]
        [TestCase("KHOI06", "NH02", "12", 2)]
        public void LayKhoiTheoMaKhoiMaNam_ThanhCong(string maKhoi, string maNamHoc, string tenKhoi, int soLop)
        {
            Assert.AreEqual(maKhoi, KHOILOP_DAL.LayKhoiTheoMaKhoiMaNam(tenKhoi, maNamHoc)[0].MAKHOI);
            Assert.AreEqual(maNamHoc, KHOILOP_DAL.LayKhoiTheoMaKhoiMaNam(tenKhoi, maNamHoc)[0].MANAM);
            Assert.AreEqual(tenKhoi, KHOILOP_DAL.LayKhoiTheoMaKhoiMaNam(tenKhoi, maNamHoc)[0].TENKHOI);
            Assert.AreEqual(soLop, KHOILOP_DAL.LayKhoiTheoMaKhoiMaNam(tenKhoi, maNamHoc)[0].SOLOP);
        }

        [Test]
        [TestCase("KHOI01", 4)]
        [TestCase("KHOI03", 3)]
        [TestCase("KHOI04", 3)]
        public void LaySoLop(string maKhoi, int soLop)
        {
            Assert.AreEqual(soLop, KHOILOP_DAL.LaySoLop(maKhoi));
        }
    }

}