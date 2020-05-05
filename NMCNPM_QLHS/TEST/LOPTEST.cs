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
    class LOPTEST
    {
        [Test]
        [TestCase(new[] { "LOP01", "LOP02", "LOP03", "LOP04" }, new[] { "HK01", "HK02", "HK01", "HK01" }, new[] { 4, 3, 1, 0})]

        public void LaySiSoLop(string[] maHS, string[] maHocKy, int[] result)
        {
            for (int i = 0; i < 4; i++)
                Assert.AreEqual(result[i], LOP_DAL.LaySiSoLop(maHS[i], maHocKy[i]));
        }
    }
}
