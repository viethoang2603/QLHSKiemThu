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
    class QUATRINHHOCTEST
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new[] { "HS001", "HS003", "HS004", "HS008" }, new[] { "LOP07", "LOP15", "LOP02", "LOP01" }, new[] { "HK01", "HK01", "HK01", "HK01" }, true)]
        [TestCase(new[] { "ádasd", "bádasdgh1", "gádasdvu1", "gádasdasdvien1" }, new[] { "admin", "bgh1", "gvu1", "gvien1" }, new[] { "admin", "bgh1", "gvu1", "gvien1" }, false)]

        public void KiemTraTonTai(string[] maHS, string[] maLop, string[] maHocKy, bool result)
        {
          for(int i =0; i<4; i++)
                Assert.AreEqual(result, QUATRINHHOC_DAL.KiemTraTonTai(maHS[i], maLop[i], maHocKy[i]));
        }
    }
}
