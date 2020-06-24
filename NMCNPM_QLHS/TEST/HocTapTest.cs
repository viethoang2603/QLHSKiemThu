using NMCNPM_QLHS.DAL;
using NUnit.Framework;
using System;

namespace NMCNPM_QLHS.TEST
{
    [TestFixture]
    public class HocTapTest
    {
        [Test]
        [TestCase("LOP02", 1, new string[] { "HS003", "Nguyễn Phi Hùng", "8", "8.7", "8.47" })]
        public void LayDiemHocSinhTheoLop_TonTaiLop_SuccessReturnBangDiem(string maLop, int rowId, string[] rows)
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
        [TestCase("LOP20")]
        public void LayDiemHocSinhTheoLop_KhongTonTaiLop_SuccessReturnNull(string maLop)
        {
            var bangDiems = HOCTAP_DAL.LayDiemHocSinhTheoLop(maLop);

            Assert.AreEqual(null, bangDiems);
        }

        [Test]
        [TestCase("HS028", "HK01", "NH02", 0, new string[] { "Công Nghệ", "9", "9", "10", "9", "9.3" })]
        [TestCase("HS028", "HK01", "NH02", 5, new string[] { "Ngoại ngữ", "7", "7", "7", "7", "7" })]
        [TestCase("HS031", "HK01", "NH02", 1, new string[] { "Địa Lý", "6", "8", "7", "8", "7.6" })]
        [TestCase("HS031", "HK01", "NH02", 8, new string[] { "Tin Học", "6", "7", "7", "5", "6" })]
        public void LayDiemChiTietHocSinh_TonTaiHS_HK_NH_Success(string maHS, string maHocKy, string maNamHoc, int rowId, string[] rows)
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
        [TestCase("HS987", "HK01", "NH02", 0, new string[] { "Công Nghệ", "9", "9", "10", "9", "9.3" })]
        public void LayDiemChiTietHocSinh_KhongTonTaiHocSinh_SuccessReturnNull(string maHS, string maHocKy, string maNamHoc, int rowId, string[] rows)
        {
        }

        [Test]
        [TestCase("LOP02", "MH01", "HK01", 1, new string[] { "HS004", "Huỳnh Quốc Trung", "9", "8", "10", "10" })]
        public void LayDiemMonHocTheoLop_Success(string maLop, string maMonHoc, string maHocKy, int rowId, string[] rows)
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
        public void SuaDiem_DuLieuHopLe_Success(int idMonHoc, string maHS, string maMon, string mahocky, string maLop, string maNamHoc, float[] diems)
        {
            HOCTAP_DAL.SuaDiem(maHS, maMon, mahocky, maLop, diems[0], diems[1], diems[2], diems[3]);
            var bangDiems = HOCTAP_DAL.LayDiemChiTietHocSinh(maHS, mahocky, maNamHoc);
            for (int i = 1; i < bangDiems.Columns.Count - 1; i++)
            {
                var value = bangDiems.Rows[idMonHoc][i];
                if (value is float)
                    value = Math.Round(Convert.ToDecimal(value), 2);
                Assert.AreEqual(diems[i - 1].ToString(), value.ToString());
            }
        }

        [TestCase(4, "HS236", "MH01", "HK01", "LOP11", "NH02", new float[] { 9, 10, 9, 10 })]
        [TestCase(4, "HS031", "MH01", "HK03", "LOP11", "NH02", new float[] { 9, 10, 9, 10 })]
        public void SuaDiem_KhongTonTaiDuLieu_Failed(int idMonHoc, string maHS, string maMon, string mahocky, string maLop, string maNamHoc, float[] diems)
        {
            HOCTAP_DAL.SuaDiem(maHS, maMon, mahocky, maLop, diems[0], diems[1], diems[2], diems[3]);
            var bangDiems = HOCTAP_DAL.LayDiemChiTietHocSinh(maHS, mahocky, maNamHoc);
            int count = 0;

            if (bangDiems != null)
            {
                for (int i = 1; i < bangDiems.Columns.Count - 1; i++)
                {
                    var value = bangDiems.Rows[idMonHoc][i];
                    if (value is float)
                        value = Math.Round(Convert.ToDecimal(value), 2);
                    if (diems[i - 1].ToString() != value.ToString())
                        count++;
                }
                Assert.AreNotEqual(0, count);
            }
            else
                Assert.AreEqual(1, 1);
        }

        [Test]
        [TestCase(9, "HS004", "MH01", "HK01", "LOP02", "NH01", new float[] { 9, 10, 9, 11 })]
        public void SuaDiem_DiemToiDa_Failed(int idMonHoc, string maHS, string maMon, string mahocky, string maLop, string maNamHoc, float[] diems)
        {
            HOCTAP_DAL.SuaDiem(maHS, maMon, mahocky, maLop, diems[0], diems[1], diems[2], diems[3]);
            var bangDiems = HOCTAP_DAL.LayDiemChiTietHocSinh(maHS, mahocky, maNamHoc);
            int count = 0;

            for (int i = 1; i < bangDiems.Columns.Count - 1; i++)
            {
                var value = bangDiems.Rows[idMonHoc][i];
                if (value is float)
                    value = Math.Round(Convert.ToDecimal(value), 2);
                if (diems[i - 1].ToString() != value.ToString())
                    count++;
            }
            Assert.AreNotEqual(0, count);
        }

        [Test]
        [TestCase(9, "HS004", "MH01", "HK01", "LOP02", "NH01", new float[] { -1, 10, 9, 10 })]
        public void SuaDiem_DiemToiThieu_Failed(int idMonHoc, string maHS, string maMon, string mahocky, string maLop, string maNamHoc, float[] diems)
        {
            HOCTAP_DAL.SuaDiem(maHS, maMon, mahocky, maLop, diems[0], diems[1], diems[2], diems[3]);
            var bangDiems = HOCTAP_DAL.LayDiemChiTietHocSinh(maHS, mahocky, maNamHoc);
            int count = 0;


            for (int i = 1; i < bangDiems.Columns.Count - 1; i++)
            {
                var value = bangDiems.Rows[idMonHoc][i+1];
                if (value is float)
                    value = Math.Round(Convert.ToDecimal(value), 2);
                if (diems[i - 1].ToString() != value.ToString())
                    count++;
            }
            Assert.AreNotEqual(0, count);
        }

        [Test]
        [TestCase("HS003", "HK01", "NH01", 8)]
        public void LayDiemTongKetHocKy_TonTaiDuLieu_SuccessReturnDoublue(string maHS, string maHK, string maNamHoc, double diemTKHK)
        {
            double result = HOCTAP_DAL.LayDiemTongKetHocKy(maHS, maHK, maNamHoc);
            result = Math.Round(result, 2);
            Assert.AreEqual(diemTKHK, result);
        }

        [Test]
        [TestCase("HS312", "HK01", "NH01")]
        [TestCase("HS003", "HK03", "NH01")]
        [TestCase("HS003", "HK01", "NH03")]
        public void LayDiemTongKetHocKy_KhongTonTaiDuLieu_FailedReturnNeg(string maHS, string maHK, string maNamHoc)
        {
            double result = HOCTAP_DAL.LayDiemTongKetHocKy(maHS, maHK, maNamHoc);
            result = Math.Round(result, 2);
            Assert.AreEqual(-1, result);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            HOCTAP_DAL.SuaDiem("HS004", "MH01", "HK01", "LOP02", 9, 8, 10, 10);
        }
    }

}