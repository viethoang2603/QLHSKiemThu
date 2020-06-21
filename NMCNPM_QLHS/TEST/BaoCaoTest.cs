using NMCNPM_QLHS.DAL;
using NUnit.Framework;
using System;

namespace NMCNPM_QLHS.TEST
{
    [TestFixture]
    public class BaoCaoTest
    {
        [Test]
        //[TestCase("HK01", "NH01", new string[,] {{ "2017-2018", "Học kỳ 1", "10/3", "8" }})]
        //[TestCase("HK02", "NH01", new string[] { "2017-2018", "Học kỳ 1", "10/3", "8" })]
        //[TestCase("HK01", "NH02", new string[] { "2017-2018", "Học kỳ 1", "10/3", "8" })]
        public void LayBaoCaoTongKetHK_ThanhCong(string maHocKy, string maNamHoc, string[][] records)
        {
            string[,] Kteam = new string[,] {{ "2017-2018", "Học kỳ 1", "10/3", "8" }};
            var table = BAOCAO_DAL.layBaoCaoTongKetHK(maHocKy, maNamHoc);

        }

        [Test]
        public void layBaoCaoTongKetMon()
        {

        }
    }

}