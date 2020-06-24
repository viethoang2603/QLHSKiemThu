using DevExpress.XtraEditors.Filtering.Templates;
using NMCNPM_QLHS.DAL;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Globalization;

namespace NMCNPM_QLHS.TEST
{
    [TestFixture]
    public class HocSinhTest
    {
        [Test]
        [TestCase("HS111", "testName", "Nam", "22-06-1999", "testAddress", "testEmail@gmail.com")]
        [TestCase("HS112", "testName2", "Nam", "20-06-1999", "testAddress2", "testEmail2@gmail.com")]
        public void Insert_DuLieuHopLe_Success(string maHS, string hoTen, string gioiTinh, string ngaySinh, string diaChi, string email)
        {
            int old_HSQuantity = HOCSINH_DAL.LayTatCaHocSinh().Count;
            DateTime birth = DateTime.ParseExact(ngaySinh, "dd-MM-yyyy", CultureInfo.CreateSpecificCulture("en-GB"));
            HOCSINH_DAL.Insert(maHS, hoTen, gioiTinh, birth, diaChi, email, null);
            int new_HSQuantity = HOCSINH_DAL.LayTatCaHocSinh().Count;
            Assert.AreEqual(old_HSQuantity + 1, new_HSQuantity);
            HOCSINH hs = HOCSINH_DAL.timTTHSTheoMaHS(maHS)[0];
            Assert.AreEqual(hoTen, hs.HOTEN);
            Assert.AreEqual(gioiTinh, hs.GIOITINH);
            Assert.AreEqual(ngaySinh, hs.NGAYSINH.Value.ToString("dd-MM-yyyy"));
            Assert.AreEqual(diaChi, hs.DIACHI);
            Assert.AreEqual(email, hs.EMAIL);
        }

        [Test]
        [TestCase("HS001", "testName2", "Nam", "20-06-1999", "testAddress2", "testEmail2@gmail.com")]
        public void Insert_MaHSDaTonTai_DBException(string maHS, string hoTen, string gioiTinh, string ngaySinh, string diaChi, string email)
        {
            int old_HSQuantity = HOCSINH_DAL.LayTatCaHocSinh().Count;
            DateTime birth = DateTime.ParseExact(ngaySinh, "dd-MM-yyyy", CultureInfo.CreateSpecificCulture("en-GB"));
            Assert.Throws<System.Data.SqlClient.SqlException>(() => HOCSINH_DAL.Insert(maHS, hoTen, gioiTinh, birth, diaChi, email, null));
            int new_HSQuantity = HOCSINH_DAL.LayTatCaHocSinh().Count;
            Assert.AreEqual(old_HSQuantity, new_HSQuantity);
        }

        [Test]
        [TestCase("HS001", "testName2", "Nam", "32-06-1999", "testAddress2", "testEmail2@gmail.com")]
        public void Insert_NgSinhKhongHopLe_FormatException(string maHS, string hoTen, string gioiTinh, string ngaySinh, string diaChi, string email)
        {
            int old_HSQuantity = HOCSINH_DAL.LayTatCaHocSinh().Count;
            Assert.Throws<System.FormatException>(() => HOCSINH_DAL.Insert(maHS, hoTen, gioiTinh, DateTime.ParseExact(ngaySinh, "dd-MM-yyyy", CultureInfo.CreateSpecificCulture("en-GB")), diaChi, email, null));
            int new_HSQuantity = HOCSINH_DAL.LayTatCaHocSinh().Count;
            Assert.AreEqual(old_HSQuantity, new_HSQuantity);
        }

        [Test]
        [TestCase("HS001", "testNameupdate", "Nam", "23-06-1999", "testAddressupdate", "testEmailupdate@gmail.com")]
        [TestCase("HS002", "testName2update", "Nam", "25-06-1999", "testAddress2update", "testEmail2update@gmail.com")]
        public void Update_DuLieuHopLe_Success(string maHS, string hoTen, string gioiTinh, string ngaySinh, string diaChi, string email)
        {
            //int old_HSQuantity = HOCSINH_DAL.LayTatCaHocSinh().Count;
            DateTime birth = DateTime.ParseExact(ngaySinh, "dd-MM-yyyy", CultureInfo.CreateSpecificCulture("en-GB"));
            HOCSINH_DAL.Update(maHS, hoTen, gioiTinh, birth, diaChi, email, null);
            //int new_HSQuantity = HOCSINH_DAL.LayTatCaHocSinh().Count;
            //Assert.AreEqual(old_HSQuantity, new_HSQuantity);
            HOCSINH hs = HOCSINH_DAL.timTTHSTheoMaHS(maHS)[0];
            Assert.AreEqual(hoTen, hs.HOTEN);
            Assert.AreEqual(gioiTinh, hs.GIOITINH);
            Assert.AreEqual(ngaySinh, hs.NGAYSINH.Value.ToString("dd-MM-yyyy"));
            Assert.AreEqual(diaChi, hs.DIACHI);
            Assert.AreEqual(email, hs.EMAIL);
        }

        [Test]
        [TestCase("HS113", "testNameupdate", "Nam", "23-06-1999", "testAddressupdate", "testEmailupdate@gmail.com")]
        public void Update_KhongTonTaiHS_NullException(string maHS, string hoTen, string gioiTinh, string ngaySinh, string diaChi, string email)
        {
            //int old_HSQuantity = HOCSINH_DAL.LayTatCaHocSinh().Count;
            DateTime birth = DateTime.ParseExact(ngaySinh, "dd-MM-yyyy", CultureInfo.CreateSpecificCulture("en-GB"));
            Assert.Throws<System.NullReferenceException>(() => HOCSINH_DAL.Update(maHS, hoTen, gioiTinh, birth, diaChi, email, null));
        }

        [Test]
        [TestCase("HS001", "testNameupdate", "Nam", "32-06-1999", "testAddressupdate", "testEmailupdate@gmail.com")]
        public void Update_NgSinhKhongHopLe_FormatException(string maHS, string hoTen, string gioiTinh, string ngaySinh, string diaChi, string email)
        {
            Assert.Throws<System.FormatException>(() => HOCSINH_DAL.Insert(maHS, hoTen, gioiTinh, DateTime.ParseExact(ngaySinh, "dd-MM-yyyy", CultureInfo.CreateSpecificCulture("en-GB")), diaChi, email, null));
        }

        [Test]
        [TestCase("HS111")]
        [TestCase("HS112")]
        public void Delete(string maHS)
        {
            //int old_HSQuantity = HOCSINH_DAL.LayTatCaHocSinh().Count;
            //HOCSINH_DAL.Delete(maHS);
            //int new_HSQuantity = HOCSINH_DAL.LayTatCaHocSinh().Count;
            //Assert.AreEqual(old_HSQuantity - 1, new_HSQuantity);
        }

        [Test]
        [TestCase(0, "HS001", "Lê Quốc Phương", "Nam", "02-02-1999", "Quảng bình", "17520000@gm.uit.edu.vn")]
        [TestCase(4, "HS005", "abcx", "Nữ", "18-04-1999", "tpHCM", "1752xxxx@gm.uit.edu.vn")]
        [TestCase(10, "HS012", "abcdm", "Nam", "01-01-1999", "Phú Ninh, Quảng Nam", "17520084@gm.agds")]
        [TestCase(20, "HS031", "Lisa", "Nữ", "27-06-1999", "lisa@gmail.com", "Korea@gmail.com")]
        [TestCase(25, "HS037", "bnbnbnbn", "Nam", "30-07-1999", "bnmbmnb", "abc@gmail.com")]
        public void LayTatCaHocSinh_Success(int id, string maHS, string tenHS, string gioiTinh, string ngaySinh, string diaChi, string email)
        {
            List<HOCSINH> hocSinhs = HOCSINH_DAL.LayTatCaHocSinh();
            Assert.AreEqual(maHS, hocSinhs[id].MAHS);
            Assert.AreEqual(tenHS, hocSinhs[id].HOTEN);
            Assert.AreEqual(gioiTinh, hocSinhs[id].GIOITINH);
            Assert.AreEqual(ngaySinh, hocSinhs[id].NGAYSINH.Value.ToString("dd-MM-yyyy"));
            Assert.AreEqual(diaChi, hocSinhs[id].DIACHI);
            Assert.AreEqual(email, hocSinhs[id].EMAIL);
        }

        [Test]
        [TestCase("LOP01", "HK01", 1, "HS012", "abcdm", "Nam", "01-01-1999", "Phú Ninh, Quảng Nam", "17520084@gm.agds")]
        [TestCase("LOP01", "HK01", 2, "HS013", "Senko", "Nữ", "10-10-1999", "bmnbnmbn", "bmnbnmbn@gmail.com")]
        [TestCase("LOP02", "HK01", 0, "HS002", "Nguyễn Lê Việt Hoàng", "Nam", "20-03-1999", "Quế Sơn, Quảng Nam", "17520513@gm.uit.edu.vn")]
        [TestCase("LOP02", "HK01", 1, "HS004", "Huỳnh Quốc Trung", "Nam", "01-01-1999", "Phú Ninh, Quảng Nam", "17520084@gm.uit.edu.vn")]
        [TestCase("LOP11", "HK02", 1, "HS031", "Lisa", "Nữ", "27-06-1999", "lisa@gmail.com", "Korea@gmail.com")]
        public void LayHocSinhTheoLop_TonTaiLop_Success(string maLop, string maHocKy, int id, string maHS, string tenHS, string gioiTinh, string ngaySinh, string diaChi, string email)
        {
            List<HOCSINH> hocSinhs = HOCSINH_DAL.LayHocSinhTheoLop(maLop, maHocKy);
            Assert.AreEqual(maHS, hocSinhs[id].MAHS);
            Assert.AreEqual(tenHS, hocSinhs[id].HOTEN);
            Assert.AreEqual(gioiTinh, hocSinhs[id].GIOITINH);
            Assert.AreEqual(ngaySinh, hocSinhs[id].NGAYSINH.Value.ToString("dd-MM-yyyy"));
            Assert.AreEqual(diaChi, hocSinhs[id].DIACHI);
            Assert.AreEqual(email, hocSinhs[id].EMAIL);
        }

        [Test]
        [TestCase("LOP20", "HK01")]
        public void LayHocSinhTheoLop_KhongTonTaiLop_FailedReturnNull(string maLop, string maHocKy)
        {
            List<HOCSINH> hocSinhs = HOCSINH_DAL.LayHocSinhTheoLop(maLop, maHocKy);
            Assert.AreEqual(null, hocSinhs);
        }

        [Test]
        [TestCase(0, "HS001", "Lê Quốc Phương")]
        [TestCase(9, "HS013", "Senko")]
        [TestCase(18, "HS034", "bcs")]
        public void LayDSHocSinhDaPhanLop_Success(int id, string maHS, string tenHS)
        {
            List<HOCSINH> hocSinhs = HOCSINH_DAL.LayDSHocSinhDaPhanLop();
            Assert.AreEqual(maHS, hocSinhs[id].MAHS);
            Assert.AreEqual(tenHS, hocSinhs[id].HOTEN);
        }

        [Test]
        [TestCase(0, "HS005", "abcx")]
        [TestCase(3, "HS030", "mbmnbmnbnmbnm")]
        [TestCase(6, "HS037", "bnbnbnbn")]
        public void LayHocSinhChuaPhanLop_Success(int id, string maHS, string tenHS)
        {
            List<HOCSINH> hocSinhs = HOCSINH_DAL.LayHocSinhChuaPhanLop();
            Assert.AreEqual(maHS, hocSinhs[id].MAHS);
            Assert.AreEqual(tenHS, hocSinhs[id].HOTEN);
        }

        [Test]
        [TestCase("Lê Quốc Phương", 0, "HS001", "Nam", "02-02-1999", "Quảng bình", "17520000@gm.uit.edu.vn")]
        [TestCase("abc", 0, "HS005", "Nữ", "18-04-1999", "tpHCM", "1752xxxx@gm.uit.edu.vn")]
        [TestCase("abc", 2, "HS012", "Nam", "01-01-1999", "Phú Ninh, Quảng Nam", "17520084@gm.agds")]
        public void timTTHSTheoTen_TonTaiTenHS_SuccessReturnListHS(string ten, int id, string maHS, string gioiTinh, string ngaySinh, string diaChi, string email)
        {
            List<HOCSINH> hocSinhs = HOCSINH_DAL.timTTHSTheoTen(ten);
            Assert.AreEqual(maHS, hocSinhs[id].MAHS);
            Assert.AreEqual(gioiTinh, hocSinhs[id].GIOITINH);
            Assert.AreEqual(ngaySinh, hocSinhs[id].NGAYSINH.Value.ToString("dd-MM-yyyy"));
            Assert.AreEqual(diaChi, hocSinhs[id].DIACHI);
            Assert.AreEqual(email, hocSinhs[id].EMAIL);
        }

        [Test]
        [TestCase("qweqwoiepqwi")]
        public void timTTHSTheoTen_KhongTonTaiTenHS_SuccessReturnNull(string ten)
        {
            List<HOCSINH> hocSinhs = HOCSINH_DAL.timTTHSTheoTen(ten);
            Assert.AreEqual(null, hocSinhs);
        }

        [Test]
        [TestCase("HS00", 0, "Lê Quốc Phương", "Nam", "02-02-1999", "Quảng bình", "17520000@gm.uit.edu.vn")]
        [TestCase("HS00", 4, "abcx", "Nữ", "18-04-1999", "tpHCM", "1752xxxx@gm.uit.edu.vn")]
        [TestCase("HS012", 0, "abcdm", "Nam", "01-01-1999", "Phú Ninh, Quảng Nam", "17520084@gm.agds")]
        public void timTTHSTheoMaHS_TonTaiMaHS_SuccessReturnListHS(string maHS, int id, string tenHS, string gioiTinh, string ngaySinh, string diaChi, string email)
        {
            List<HOCSINH> hocSinhs = HOCSINH_DAL.timTTHSTheoMaHS(maHS);
            Assert.AreEqual(tenHS, hocSinhs[id].HOTEN);
            Assert.AreEqual(gioiTinh, hocSinhs[id].GIOITINH);
            Assert.AreEqual(ngaySinh, hocSinhs[id].NGAYSINH.Value.ToString("dd-MM-yyyy"));
            Assert.AreEqual(diaChi, hocSinhs[id].DIACHI);
            Assert.AreEqual(email, hocSinhs[id].EMAIL);
        }

        [Test]
        [TestCase("HS123")]
        public void timTTHSTheoMaHS_KhongTonTaiMaHS_SuccessReturnNull(string maHS)
        {
            List<HOCSINH> hocSinhs = HOCSINH_DAL.timTTHSTheoMaHS(maHS);
            Assert.AreEqual(null, hocSinhs);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            DateTime birthDay1 = DateTime.ParseExact("02-02-1999", "dd-MM-yyyy", CultureInfo.CreateSpecificCulture("en-GB"));
            DateTime birthDay2 = DateTime.ParseExact("20-03-1999", "dd-MM-yyyy", CultureInfo.CreateSpecificCulture("en-GB"));
            HOCSINH_DAL.Update("HS001", "Lê Quốc Phương", "Nam", birthDay1, "Quảng bình", "17520000@gm.uit.edu.vn", null);
            HOCSINH_DAL.Update("HS002", "Nguyễn Lê Việt Hoàng", "Nam", birthDay2, "Quế Sơn, Quảng Nam", "17520513@gm.uit.edu.vn", null);
            HOCSINH_DAL.Delete("HS111");
            HOCSINH_DAL.Delete("HS112");
        }
    }

}