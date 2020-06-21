using NMCNPM_QLHS.DAL;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.TEST
{
    [TestFixture]
    class LoaiHinhKiemTraTest
    {
        [Test]
        [TestCase(0, "LHKT01", "Điểm Miệng", "1")]
        [TestCase(1, "LHKT02", "Điểm 15p", "1")]
        [TestCase(2, "LHKT03", "Điểm 1 tiết", "2")]
        [TestCase(3, "LHKT04", "Điểm cuối kỳ", "3")]
        public void LHKT_LayTatCa_ThanhCong(int id, string MaLHKT, string TenLHKT, int heSo)
        {
            List<LOAIHINHKIEMTRA> loaiHinhKiemTras;
            loaiHinhKiemTras = LOAIHINHKIEMTRA_DAL.LayTatCaLHKT();
            Assert.AreEqual(loaiHinhKiemTras[id].MALHKT, MaLHKT);
            Assert.AreEqual(loaiHinhKiemTras[id].TENLHKT, TenLHKT);
            Assert.AreEqual(loaiHinhKiemTras[id].HESO, heSo);
        }

        [Test]
        [TestCase("LHKT01", "1")]
        [TestCase("LHKT02", "1")]
        [TestCase("LHKT03", "2")]
        [TestCase("LHKT04", "3")]
        public void LHKT_LayHeSo_ThanhCong(string maLHKT, int heSo)
        {
            Assert.AreEqual(LOAIHINHKIEMTRA_DAL.layHeSo(maLHKT), heSo);
        }

        [Test]
        [TestCase("LHKT01", 2)]
        [TestCase("LHKT01", 3)]
        [TestCase("LHKT02", 4)]
        public void LHKT_SuaHeSo_ThanhCong(string maLHKT, int heSo)
        {
            LOAIHINHKIEMTRA_DAL.Update(maLHKT, heSo);
            Assert.AreEqual(heSo, LOAIHINHKIEMTRA_DAL.layHeSo(maLHKT));
        }

        [Test]
        [TestCase("LHKT01", 0)]
        [TestCase("LHKT01", -1)]
        [TestCase("LHKT01", 0.5)]
        public void LHKT_SuaHeSo_KhongThanhCong(string maLHKT, int heSo)
        {
            LOAIHINHKIEMTRA_DAL.Update(maLHKT, heSo);
            Assert.AreNotEqual(heSo, LOAIHINHKIEMTRA_DAL.layHeSo(maLHKT));
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            LOAIHINHKIEMTRA_DAL.Update("LHKT01", 1);
            LOAIHINHKIEMTRA_DAL.Update("LHKT02", 1);
            LOAIHINHKIEMTRA_DAL.Update("LHKT03", 2);
            LOAIHINHKIEMTRA_DAL.Update("LHKT04", 3);
        }
    }
}
