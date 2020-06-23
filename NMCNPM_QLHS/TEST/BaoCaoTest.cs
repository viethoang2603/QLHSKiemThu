using DevExpress.XtraVerticalGrid;
using NMCNPM_QLHS.DAL;
using NUnit.Framework;
using System;

namespace NMCNPM_QLHS.TEST
{
    [TestFixture]
    public class BaoCaoTest
    {
        [Test]
        [TestCase("HK01", "NH01", 0, new string[] { "10/1", "", "", "" })]
        [TestCase("HK01", "NH01", 1, new string [] { "10/2", "3", "2", "66.67%" })]
        [TestCase("HK01", "NH01", 2, new string[] { "10/3", "1", "1", "100%" })]
        [TestCase("HK02", "NH01", 0, new string[] { "10/1", "4", "0", "0%" })]
        [TestCase("HK02", "NH01", 1, new string[] { "10/2", "3", "2", "66.67%" })]
        [TestCase("HK02", "NH01", 2, new string[] { "10/3", "", "", "" })]
        public void LayBaoCaoTongKetHK_ThanhCong(string maHocKy, string maNamHoc, int rowId, string[] rows)
        {
            var baoCaoTongKetHKs = BAOCAO_DAL.layBaoCaoTongKetHK(maHocKy, maNamHoc);
            for (int i = 0; i < rows.Length; ++i)
            {
                var value = baoCaoTongKetHKs.Rows[rowId][i];
                if (value is double)
                    value = Math.Round(Convert.ToDecimal(value), 1);
                Assert.AreEqual(rows[i], value.ToString());
            }
        }

        [Test]
        [TestCase("MH01", "HK01", "NH01", 0, new string[] { "10/2", "3", "2", "66.67%" })]
        [TestCase("MH01","HK02", "NH01", 0, new string[] { "10/2", "3", "1", "33.33%" })]
        public void LayBaoCaoTongKetMon_ThanhCong(string maMonHoc, string maHocKy, string maNamHoc, int rowId, string[] rows)
        {
            var baoCaoTongKetMons = BAOCAO_DAL.layBaoCaoTongKetMon(maMonHoc, maHocKy, maNamHoc);
            for (int i = 0; i < rows.Length; ++i)
            {
                var value = baoCaoTongKetMons.Rows[rowId][i];
                if (value is double)
                    value = Math.Round(Convert.ToDecimal(value), 1);
                Assert.AreEqual(rows[i], value.ToString());
            }
        }
    }

}