using NMCNPM_QLHS.DAL;
using NUnit.Framework;
using System;

namespace NMCNPM_QLHS.TEST
{
    [TestFixture]
    public class HocTap
    {
        [Test]
        [TestCase("LOP02", 1, new string[] { "HS003", "Nguyễn Phi Hùng", "8", "8.7", "8.47" })]
        [TestCase("LOP02", 2, new string[] { "HS004", "Huỳnh Quốc Trung", "8", "7", "7.33" })]
        public void LayDiemHocSinhTheoLop(string maLop, int rowId, string[] rows)
        {
            var bangDiems = HOCTAP_DAL.LayDiemHocSinhTheoLop(maLop);

            for (int i = 1; i < rows.Length + 1; i++)
            {
                var value = bangDiems.Rows[rowId][i];
                if (value is float)
                    value = Math.Round(Convert.ToDecimal(value), 2);
                Assert.AreEqual(rows[i - 1], value.ToString());
            }
        }

        [Test]
        [TestCase("HS028", "HK01", "NH02", 0, new string[] { "Công Nghệ", "9", "9", "10", "9", "9.3" })]
        [TestCase("HS028", "HK01", "NH02", 5, new string[] { "Ngoại ngữ", "7", "7", "7", "7", "7" })]
        [TestCase("HS028", "HK01", "NH02", 10, new string[] { "Vật Lý", "8", "8", "8", "8", "8" })]
        [TestCase("HS031", "HK01", "NH02", 1, new string[] { "Địa Lý", "7", "8", "7", "8", "7.6" })]
        [TestCase("HS031", "HK01", "NH02", 6, new string[] { "Ngữ Văn", "8", "9", "8", "9", "8.6" })]
        [TestCase("HS031", "HK01", "NH02", 8, new string[] { "Tin Học", "6", "7", "7", "5", "6" })]
        public void LayDiemChiTietHocSinh(string maHS, string maHocKy, string maNamHoc, int rowId, string[] rows)
        {
            var bangDiems = HOCTAP_DAL.LayDiemChiTietHocSinh(maHS, maHocKy, maNamHoc);

            for (int i = 0; i < rows.Length; i++)
            {
                var value = bangDiems.Rows[rowId][i];
                if (value is float)
                    value = Math.Round(Convert.ToDecimal(value), 2);
                Assert.AreEqual(rows[i], value.ToString());
            }
        }

        [Test]
        [TestCase("LOP02", "MH01", "HK01", 1, new string[] { "HS004", "Huỳnh Quốc Trung", "9", "8", "10", "10" })]
        [TestCase("LOP02", "MH01", "HK01", 2, new string[] { "HS007", "bnbmnbnmbmnbmnb", "7", "8", "9", "8" })]
        [TestCase("LOP11", "MH01", "HK01", 0, new string[] { "HS028", "  mnvbn", "6", "5", "4", "10" })]
        public void LayDiemMonHocTheoLop(string maLop, string maMonHoc, string maHocKy, int rowId, string[] rows)
        {
            var bangDiems = HOCTAP_DAL.LayDiemMonHocTheoLop(maLop, maMonHoc, maHocKy, "");

            for (int i = 0; i < rows.Length; i++)
            {
                var value = bangDiems.Rows[rowId][i];
                if (value is float)
                    value = Math.Round(Convert.ToDecimal(value), 2);
                Assert.AreEqual(rows[i], value.ToString());
            }
        }

        [Test]
        [TestCase(9, "HS004", "MH01", "HK01", "LOP02", "NH01", new float[] { 8, 7, 8, 6 })]
        [TestCase(9, "HS003", "MH01", "HK02", "LOP02", "NH01", new float[] { 9, 9, 9, 9 })]
        [TestCase(6, "HS028", "MH06", "HK01", "LOP11", "NH02", new float[] { 7, 7, 7, 7 })]
        [TestCase(4, "HS031", "MH07", "HK01", "LOP11", "NH02", new float[] { 9, 10, 9, 10 })]
        public void SuaDiem(int idMonHoc, string maHS, string maMon, string mahocky, string maLop, string maNamHoc, float[] diems)
        {
            HOCTAP_DAL.SuaDiem(maHS, maMon, mahocky, maLop, diems[0], diems[1], diems[2], diems[3]);
            var bangDiems = HOCTAP_DAL.LayDiemChiTietHocSinh(maHS, mahocky, maNamHoc);
            for (int i = 1; i < bangDiems.Columns.Count - 1; i++)
            {
                var value = bangDiems.Rows[idMonHoc][i];
                if (value is float)
                    value = Math.Round(Convert.ToDecimal(value), 2);
                Assert.AreEqual(diems[i-1].ToString(), value.ToString());
            }
        }

        [Test]
        [TestCase("HS003", "HK01", "NH01", 8)]
        [TestCase("HS003", "HK02", "NH01", 8.7)]
        [TestCase("HS003", "HK01", "NH02", 7)]
        public void LayDiemTongKetHocKy(string maHS, string maHK, string maNamHoc, double diemTKHK)
        {
            double result = HOCTAP_DAL.LayDiemTongKetHocKy(maHS, maHK, maNamHoc);
            result = Math.Round(result, 2);
            Assert.AreEqual(diemTKHK, result);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            HOCTAP_DAL.SuaDiem("HS004", "MH01", "HK01", "LOP02", 9, 8, 10, 10);
            HOCTAP_DAL.SuaDiem("HS003", "MH01", "HK02", "LOP02", 9, 10, 9, 8);
            HOCTAP_DAL.SuaDiem("HS028", "MH06", "HK01", "LOP11", 7, 7, 7, 7);
            HOCTAP_DAL.SuaDiem("HS031", "MH07", "HK01", "LOP11", 9, 10, 9, 10);
        }
    }

}