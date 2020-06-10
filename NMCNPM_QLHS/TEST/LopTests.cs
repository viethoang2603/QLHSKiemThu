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
        [Test]
        [TestCase("LOP11", "12/4", "KHOI03")]
        public void Lop_ThemLop_ThanhCong(string maLop, string tenLop, string maKhoi) {
            LOP_DAL.Insert(maLop, tenLop, maKhoi);
        }

        [Test]
        [TestCase("LOP10")]
        public void Lop_XoaLop_ThanhCong(string maLop) {
            //TODO
            //XOA BAOCAOTONGKETHK WHERE MALOP
            //XOA CT_BCTKMON WHERE MALOP
            //LOP_DAL.Delete(maLop);
        }
       
        [Test]
        [TestCase("LOP01", "HK01", 4)]
        [TestCase("LOP01", "HK02", 1)]
        [TestCase("LOP02", "HK02", 2)]
        public void Lop_LaySiSo_ThanhCong(string maLop, string maHocKy, int result)
        {
            Assert.AreEqual(result, LOP_DAL.LaySiSoLop(maLop, maHocKy));
        }

        [OneTimeTearDown]
        public void OneTimeTearDown() {
            LOP_DAL.Delete("LOP11");
        }
    }
}
