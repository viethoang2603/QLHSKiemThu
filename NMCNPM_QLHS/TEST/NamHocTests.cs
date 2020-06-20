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
        public void ThemNamHoc_Them_ThanhCong()
        {
            int preCount = NAMHOC_DAL.LayTatCaNamHoc().Count;
            NAMHOC_DAL.Insert();
            int nextCount = NAMHOC_DAL.LayTatCaNamHoc().Count;
            Assert.AreEqual(preCount + 1, nextCount);
        }

        [Test]
        [TestCase("NH01", "HS001")]
        public void LayNamHoc_TheoMaHocSinh_ThanhCong(string maNamHocDauTien, string maHocSinh)
        {
            var x = NAMHOC_DAL.LayNamHocTheoMaHS(maHocSinh);
            Assert.AreNotEqual(x, null);
            Assert.AreNotEqual(x[0], null);
            Assert.AreEqual(x[0].MANAMHOC, maNamHocDauTien);
        }

        [Test]
        [TestCase("NH01", "2017-2018")]
        public void LayNamHoc_TheoTen_ThanhCong(string maNamHoc, string ten)
        {
            var x = NAMHOC_DAL.LayNamHocTheoTen(ten);
            Assert.AreNotEqual(x, null);
            Assert.AreEqual(x.MANAMHOC, maNamHoc);
        }

        [Test]
        public void LayNamHoc_NamHocHienTai_ThanhCong()
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
