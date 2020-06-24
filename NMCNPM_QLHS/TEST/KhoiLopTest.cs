using DevExpress.Office.Utils;
using NMCNPM_QLHS.DAL;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace NMCNPM_QLHS.TEST
{
    [TestFixture]
    public class KhoiLopTest
    {
        [Test]
        [TestCase(0, "KHOI01","NH01","10",4)]
        [TestCase(1, "KHOI02", "NH01", "11", 3)]
        [TestCase(2, "KHOI03", "NH01", "12", 3)]
        [TestCase(3, "KHOI04", "NH02", "10", 3)]
        [TestCase(4, "KHOI05", "NH02", "11", 2)]
        [TestCase(5, "KHOI06", "NH02", "12", 2)]
        public void LayTatCaKhoi_Success(int id, string maKhoi, string maNam, string tenKhoi, int soLop)
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
        public void LayKhoiTheoNamHoc_TonTaiNamHoc_Success(int id, string maNamHoc, string maKhoi, string tenKhoi, int soLop)
        {
            List<KHOILOP> khoiLops = KHOILOP_DAL.LayKhoiTheoNamHoc(maNamHoc);
            Assert.AreEqual(maKhoi, khoiLops[id].MAKHOI);
            Assert.AreEqual(maNamHoc, khoiLops[id].MANAM);
            Assert.AreEqual(tenKhoi, khoiLops[id].TENKHOI);
            Assert.AreEqual(soLop, khoiLops[id].SOLOP);
        }

        [Test]
        [TestCase(0, "NH03")]
        public void LayKhoiTheoNamHoc_KhongTonTaiNamHoc_FailedReturnNull(int id, string maNamHoc)
        {
            List<KHOILOP> khoiLops = KHOILOP_DAL.LayKhoiTheoNamHoc(maNamHoc);
            Assert.AreEqual(null, khoiLops);
        }

        [Test]
        [TestCase(0, "NH01", "KHOI01", "10")]
        [TestCase(1, "NH01", "KHOI02", "11")]
        [TestCase(0, "NH02", "KHOI04", "10")]
        [TestCase(1, "NH02", "KHOI05", "11")]
        public void LayKhoi1011_TonTaiNamHoc_Success(int id, string maNamHoc, string maKhoi, string tenKhoi)
        {
            List<KHOILOP> khoiLops = KHOILOP_DAL.LayKhoi1011(maNamHoc);
            Assert.AreEqual(maKhoi, khoiLops[id].MAKHOI);
            Assert.AreEqual(tenKhoi, khoiLops[id].TENKHOI);
        }

        [Test]
        [TestCase("NH03")]
        public void LayKhoi1011_KhongTonTaiNamHoc_FailedReturnNull(string maNamHoc)
        {
            List<KHOILOP> khoiLops = KHOILOP_DAL.LayKhoi1011(maNamHoc);
            Assert.AreEqual(null, khoiLops);
        }

        [Test]
        [TestCase("KHOI01", "NH01", "10", 4)]
        [TestCase("KHOI02", "NH01", "11", 3)]
        [TestCase("KHOI06", "NH02", "12", 2)]
        public void LayKhoiTheoTenKhoiMaNam_TonTaiKhoiNamHoc_Success(string maKhoi, string maNamHoc, string tenKhoi, int soLop)
        {
            Assert.AreEqual(maKhoi, KHOILOP_DAL.LayKhoiTheoTenKhoiMaNam(tenKhoi, maNamHoc)[0].MAKHOI);
            Assert.AreEqual(maNamHoc, KHOILOP_DAL.LayKhoiTheoTenKhoiMaNam(tenKhoi, maNamHoc)[0].MANAM);
            Assert.AreEqual(tenKhoi, KHOILOP_DAL.LayKhoiTheoTenKhoiMaNam(tenKhoi, maNamHoc)[0].TENKHOI);
            Assert.AreEqual(soLop, KHOILOP_DAL.LayKhoiTheoTenKhoiMaNam(tenKhoi, maNamHoc)[0].SOLOP);
        }

        [Test]
        [TestCase("NH03", "12")]
        public void LayKhoiTheoTenKhoiMaNam_KhongTonTaiNamHoc_FailedReturnNull(string maNamHoc, string tenKhoi)
        {
            List<KHOILOP> khoiLops = KHOILOP_DAL.LayKhoiTheoTenKhoiMaNam(tenKhoi, maNamHoc);
            Assert.AreEqual(null, khoiLops);
        }

        [Test]
        [TestCase("NH02", "13")]
        public void LayKhoiTheoTenKhoiMaNam_KhongTonTaiKhoi_FailedReturnNull(string maNamHoc, string tenKhoi)
        {
            List<KHOILOP> khoiLops = KHOILOP_DAL.LayKhoiTheoTenKhoiMaNam(tenKhoi, maNamHoc);
            Assert.AreEqual(null, khoiLops);
        }

        [Test]
        [TestCase("KHOI01", 4)]
        [TestCase("KHOI03", 3)]
        [TestCase("KHOI04", 3)]
        public void LaySoLop_TonTaiKhoi_SuccessReturnInt(string maKhoi, int soLop)
        {
            Assert.AreEqual(soLop, KHOILOP_DAL.LaySoLop(maKhoi));
        }

        [Test]
        [TestCase("KHOI10", 0)]
        public void LaySoLop_KhongTonTaiKhoi_FailedReturn0(string maKhoi, int soLop)
        {
            Assert.AreEqual(soLop, KHOILOP_DAL.LaySoLop(maKhoi));
        }
    }

}