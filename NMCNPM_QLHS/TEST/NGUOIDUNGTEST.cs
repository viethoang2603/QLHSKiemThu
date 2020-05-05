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
    class NGUOIDUNGTEST
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new[] { "admin", "bgh1", "gvu1", "gvien1" }, true)]
        [TestCase(new[] { "ádasd", "bádasdgh1", "gádasdvu1", "gádasdasdvien1" }, false)]

        public void KiemTraTonTai(string[] tendangnhap, bool result)
        {
            foreach (string item in tendangnhap)
            Assert.AreEqual(result, NGUOIDUNG_DAL.KiemTraTonTai(item));
        }

        [Test]

        [TestCase(new[] { "admin", "bgh1", "gvu1", "gvien1" }, new[] { "admin", "bgh1", "gvu1", "gvien1" }, true)]
        [TestCase(new[] { "admin", "bgh1", "gvu1", "gvien1" }, new[] { "addfg", "12432", "sdfdsf", "sdf" }, false)]

        public void DangNhap(string[] tendangnhap, string[] pass, bool result)
        {
            for (int i=0; i<4; i++)
                Assert.AreEqual(result, NGUOIDUNG_DAL.DangNhap(tendangnhap[i], pass[i]));
        }
        [Test]
        public void LayTenNguoiDung()
        {
            Assert.AreEqual("Lê Thiên Đế", NGUOIDUNG_DAL.LayTenNguoiDung("ND0001"));
        }

        [Test]
        public void LayTenDangNhap()
        {
            Assert.AreEqual("admin", NGUOIDUNG_DAL.LayTenDangNhap("ND0001"));
        }

    }
}
