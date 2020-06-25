using NMCNPM_QLHS.DAL;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace NMCNPM_QLHS.TEST
{
    [TestFixture]
    public class MonHocTest
    {
        [Test]
        [TestCase(0,"MH01","Toán")]
        [TestCase(5, "MH06", "Ngữ Văn")]
        [TestCase(10, "MH11", "Công Nghệ")]
        public void LayTatCaMonHoc_Success(int id, string maMH, string tenMH)
        {
            List<MONHOC> monHocs = MONHOC_DAL.LayTatCaMonHoc();
            Assert.AreEqual(maMH, monHocs[id].MAMONHOC);
            Assert.AreEqual(tenMH, monHocs[id].TENMONHOC);
        }

        [Test]
        [TestCase("MH99", "Toán cao cấp")]
        public void insert_DuLieuHopLe_Success(string maMH, string tenMH)
        {

        }

        [Test]
        [TestCase("MH01", "Toán cao cấp")]
        public void insert_TrungMaMH_Failed(string maMH, string tenMH)
        {

        }

        [Test]
        [TestCase(0,"MH01","Toán cao cấp")]
        public void update_TonTaiMonHoc_Success(int id, string maMH, string tenMH)
        {
            MONHOC_DAL.update(maMH, tenMH);
            Assert.AreEqual(tenMH, MONHOC_DAL.LayTatCaMonHoc()[id].TENMONHOC);
        }

        [Test]
        [TestCase(0, "MH98", "Toán cao cấp")]
        public void update_KhongTonTaiMonHoc_NullException(int id, string maMH, string tenMH)
        {
            Assert.Throws<System.NullReferenceException>(() => MONHOC_DAL.update(maMH, tenMH));

        }

        [Test]
        [TestCase("MH99")]
        public void delete_TonTaiMonHoc_Success(string maMH)
        {
               
        }

        [Test]
        [TestCase("M98")]
        public void delete_KhongTonTaiMonHoc_Failed(string maMH)
        {

        }

        [OneTimeTearDown]
        public void TearDown()
        {
            MONHOC_DAL.update("MH01", "Toán");
            MONHOC_DAL.delete("MH99");
        }
    }

}