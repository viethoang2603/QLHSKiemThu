using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NMCNPM_QLHS.DAL;
using NUnit.Framework;

                                        //DONE
namespace NMCNPM_QLHS.TEST
{
    [TestFixture]
    public class LoaiNguoiDungTests
    {
        List<LOAINGUOIDUNG> loaiNguoiDungs;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            loaiNguoiDungs = LOAINGUOIDUNG_DAL.LayTatCaLoaiNguoiDung();
        }

        [Test]
        [TestCase(0, "LND001", "ADMIN")]
        [TestCase(1, "LND002", "Ban Giám Hiệu")]
        [TestCase(2, "LND003", "Giáo Vụ")]
        [TestCase(3, "LND004", "Giáo Viên")]
        public void LND_LayTatca_ThanhCong(int id, string code, string name)
        {
            Assert.AreEqual(loaiNguoiDungs[id].MALND, code);
            Assert.AreEqual(loaiNguoiDungs[id].TENLOAIND, name);
        }
    }
}
