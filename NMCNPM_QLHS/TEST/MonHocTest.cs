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
        public void LayTatCaMonHoc(int id, string maMH, string tenMH)
        {
            List<MONHOC> monHocs = MONHOC_DAL.LayTatCaMonHoc();
            Assert.AreEqual(maMH, monHocs[id].MAMONHOC);
            Assert.AreEqual(tenMH, monHocs[id].TENMONHOC);
        }

        [Test]
        public void insert(string maMH, string tenMH)
        {

        }

        [Test]
        [TestCase(0,"MH01","Toán cao cấp")]
        [TestCase(1,"MH02", "updated tenMH")]
        public void update(int id, string maMH, string tenMH)
        {
            MONHOC_DAL.update(maMH, tenMH);
            Assert.AreEqual(tenMH, MONHOC_DAL.LayTatCaMonHoc()[id].TENMONHOC);
        }

        [Test]
        public void delete(string maMH)
        {
               
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            MONHOC_DAL.update("MH01", "Toán");
            MONHOC_DAL.update("MH02", "Vật Lý");
        }
    }

}