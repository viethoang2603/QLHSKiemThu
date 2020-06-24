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
        [TestCase(0, "LHKT01", "Điểm Miệng", 1)]
        [TestCase(1, "LHKT02", "Điểm 15p", 1)]
        [TestCase(2, "LHKT03", "Điểm 1 tiết", 2)]
        [TestCase(3, "LHKT04", "Điểm cuối kỳ", 3)]
        public void LayTatCaLHKT_Success(int id, string MaLHKT, string TenLHKT, int heSo)
        {
            List<LOAIHINHKIEMTRA> loaiHinhKiemTras;
            loaiHinhKiemTras = LOAIHINHKIEMTRA_DAL.LayTatCaLHKT();
            Assert.AreEqual(MaLHKT, loaiHinhKiemTras[id].MALHKT);
            Assert.AreEqual(TenLHKT, loaiHinhKiemTras[id].TENLHKT);
            Assert.AreEqual(heSo, loaiHinhKiemTras[id].HESO);
        }

        [Test]
        [TestCase("LHKT01", 1)]
        public void LayHeSo_TonTaiLHKT_SuccessReturnInt(string maLHKT, int heSo)
        {
            Assert.AreEqual(heSo, LOAIHINHKIEMTRA_DAL.layHeSo(maLHKT));
        }

        [Test]
        [TestCase("LHKT05")]
        public void LayHeSo_KhongTonTaiLHKT_NullException(string maLHKT)
        {
            Assert.Throws<System.NullReferenceException>(() => LOAIHINHKIEMTRA_DAL.layHeSo(maLHKT));
        }

        [Test]
        [TestCase("LHKT01", 2)]
        public void SuaHeSo_TonTaiLHKT_Success(string maLHKT, int heSo)
        {
            LOAIHINHKIEMTRA_DAL.Update(maLHKT, heSo);
            Assert.AreEqual(heSo, LOAIHINHKIEMTRA_DAL.layHeSo(maLHKT));
        }

        [Test]
        [TestCase("LHKT05", 4)]
        public void SuaHeSo_KhongTonTaiLHKT_NullException(string maLHKT, int heSo)
        {
            Assert.Throws<System.NullReferenceException>(() => LOAIHINHKIEMTRA_DAL.Update(maLHKT, heSo));

        }

        [Test]
        [TestCase("LHKT01", 0)]
        [TestCase("LHKT01", -1)]
        public void SuaHeSo_HeSoKhongHopLe_Failed(string maLHKT, int heSo)
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
