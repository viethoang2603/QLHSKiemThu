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
    class NamHocTests
    {
        [Test]
        public void Them_NamHocMoi_ThanhCong()
        {
            int preCount = NAMHOC_DAL.LayTatCaNamHoc().Count;
            NAMHOC_DAL.Insert();
            int nextCount = NAMHOC_DAL.LayTatCaNamHoc().Count;
            Assert.AreEqual(preCount + 1, nextCount);
        }

        [Test]
        [TestCase("NH01", "HS001")]
        [TestCase("NH01", "HS002")]
        [TestCase("NH01", "HS003")]
        public void LayTheoMaHS_TonTaiHocSinh_ThanhCong(string maNamHocDauTien, string maHocSinh)
        {
            var x = NAMHOC_DAL.LayNamHocTheoMaHS(maHocSinh);
            Assert.AreNotEqual(x, null);
            Assert.AreNotEqual(x[0], null);
            Assert.AreEqual(x[0].MANAMHOC, maNamHocDauTien);
        }

        [Test]
        [TestCase("NH01", "HS091")]
        public void LayTheoMaHS_KoTonTaiHocSinh_KhongCoNamHoc(string maNamHocDauTien, string maHocSinh)
        {
            var x = NAMHOC_DAL.LayNamHocTheoMaHS(maHocSinh);
            Assert.AreEqual(x.Count(), 0);
        }

        [Test]
        [TestCase("NH01", "HS999")]
        public void LayTheoMaHS_HSKhongTonTai_KhongCoNamHoc(string maNamHocDauTien, string maHocSinh)
        {
            var namHocs = NAMHOC_DAL.LayNamHocTheoMaHS(maHocSinh);
            Assert.AreEqual(namHocs.Count, 0);
        }

        [Test]
        [TestCase("NH01", "2017-2018")]
        public void LayTheoTen_TonTai_ThanhCong(string maNamHoc, string ten)
        {
            var x = NAMHOC_DAL.LayNamHocTheoTen(ten);
            Assert.AreNotEqual(x, null);
            Assert.AreEqual(x.MANAMHOC, maNamHoc);
        }

        [Test]
        [TestCase("NH01", "2029-2030")]
        public void LayTheoTen_TenKhongTonTai_Null(string maNamHoc, string ten)
        {
            var x = NAMHOC_DAL.LayNamHocTheoTen(ten);
            Assert.Null(x);
        }

        [Test]
        public void Lay_NamHocHienTai_ThanhCong()
        {
            var array = NAMHOC_DAL.LayTatCaNamHoc();
            string maNamHoc = array[array.Count - 1].MANAMHOC;

            var x = NAMHOC_DAL.LayNamHocHienTai();

            Assert.AreNotEqual(x, null);
            Assert.AreEqual(x.MANAMHOC, maNamHoc);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            NAMHOC_DAL.Delete("NH03");
            while (NAMHOC_DAL.LayTatCaNamHoc().Count < 2)
                NAMHOC_DAL.Insert();
        }
    }
}
