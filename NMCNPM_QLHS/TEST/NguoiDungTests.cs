﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NMCNPM_QLHS.DAL;
using NUnit.Framework;

namespace NMCNPM_QLHS.TEST
{
    [TestFixture]
    class NguoiDungTests
    {

        [SetUp]
        public void Setup()
        {
        }

        #region DangNhap_Test
        [Test]
        [TestCase("admin", "admin")]
        [TestCase("bgh1", "bgh1")]
        [TestCase("gvu1", "gvu1")]
        [Category("Dang_Nhap")]
        public void DangNhap_ChinhXac_HopLe(string tendangnhap, string pass)
        {
            NGUOIDUNG_DAL.DangNhap(tendangnhap, pass);
            Assert.IsTrue(NGUOIDUNG_DAL.DangNhap(tendangnhap, pass));
        }

        [Test]
        [TestCase("admin", "bgh1")]
        [Category("Dang_Nhap")]
        public void DangNhap_SaiMatKhau_KhongHopLe(string tendangnhap, string pass)
        {
            NGUOIDUNG_DAL.DangNhap(tendangnhap, pass);
            Assert.IsFalse(NGUOIDUNG_DAL.DangNhap(tendangnhap, pass));
        }

        [Test]
        [TestCase("admin1", "admin")]
        [Category("Dang_Nhap")]
        public void DangNhap_SaiTaiKhoan_KhongHopLe(string tendangnhap, string pass)
        {
            NGUOIDUNG_DAL.DangNhap(tendangnhap, pass);
            Assert.IsFalse(NGUOIDUNG_DAL.DangNhap(tendangnhap, pass));
        }
        #endregion

        #region Them_Xoa_Test

        [Test]
        [TestCase("NDABCD", "phuongle", "Phuong Le", "LND001")]
        public void ThemNguoiDung_KhongBiTrung_ThanhCong(string maND, string taikhoan, string ten, string loaiquyen)
        {
            NGUOIDUNG_DAL.insert(maND, ten, loaiquyen, taikhoan);
            Assert.IsTrue(NGUOIDUNG_DAL.KiemTraTonTai(taikhoan));
        }

        [Test]
        [TestCase("ND0001", "phuongle", "Phuong Le", "LND001")]
        [TestCase("ND0002", "phuongle", "Phuong Le", "LND001")]
        [TestCase("ND0003", "phuongle", "Phuong Le", "LND001")]
        public void ThemNguoiDung_BiTrung_DbException(string maND, string taikhoan, string ten, string loaiquyen)
        {
            Assert.Throws<System.Data.SqlClient.SqlException>(() => NGUOIDUNG_DAL.insert(maND, ten, loaiquyen, taikhoan));
        }

        [Test]
        [TestCase("NDABCD", "phuongle", "Phuong Le", "LND091")]
        [TestCase("NDABCD", "phuongle", "Phuong Le", "LND092")]
        [TestCase("NDABCD", "phuongle", "Phuong Le", "LND093")]
        public void ThemNguoiDung_KhongTonTaiLND_DbException(string maND, string taikhoan, string ten, string loaiquyen)
        {
            Assert.Throws<System.Data.SqlClient.SqlException>(() => NGUOIDUNG_DAL.insert(maND, ten, loaiquyen, taikhoan));
        }

        [Test]
        [TestCase("ND0007", "bnvnbvnb")]
        public void XoaNguoiDung_TonTai_ThanhCong(string maND, string tenDangNhap)
        {
            NGUOIDUNG_DAL.delete(maND);
            Assert.IsFalse(NGUOIDUNG_DAL.KiemTraTonTai(tenDangNhap));
        }

        [Test]
        [TestCase("ND0091", "test")]
        public void XoaNguoiDung_KoTonTai_KhongLoi(string maND, string tenDangNhap)
        {
            NGUOIDUNG_DAL.delete(maND);
            Assert.IsFalse(NGUOIDUNG_DAL.KiemTraTonTai(tenDangNhap));
        }

        #endregion

        [Test]
        [TestCase("admin")]
        [TestCase("bgh1")]
        [TestCase("gvu1")]
        public void KiemTraTonTai_TonTai_ThanhCong(string tenDangNhap)
        {
            Assert.IsTrue(NGUOIDUNG_DAL.KiemTraTonTai(tenDangNhap));
        }

        [Test]
        [TestCase("adm1in")]
        [TestCase("bgh12")]
        [TestCase("gvu31")]
        public void KiemTraTonTai_KhongTonTai_ThatBai(string tenDangNhap)
        {
            Assert.IsFalse(NGUOIDUNG_DAL.KiemTraTonTai(tenDangNhap));
        }

        [TestCase("ND0001", "Lê Thiên Đế")]
        [TestCase("ND0002", "Nguyễn Hoàng Thượng")]
        [TestCase("ND0003", "Đặng Tể Tướng")]
        public void LayTenNguoiDung_TonTai_ThanhCong(string maNguoiDung, string tenNguoiDung)
        {
            Assert.AreEqual(NGUOIDUNG_DAL.LayTenNguoiDung(maNguoiDung), tenNguoiDung);
        }

        [TestCase("ND9848", "unknown")]
        public void LayTenNguoiDung_KhongTonTai_TraVeUnknown(string maNguoiDung, string tenNguoiDung)
        {
            Assert.AreEqual(NGUOIDUNG_DAL.LayTenNguoiDung(maNguoiDung), tenNguoiDung);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            NGUOIDUNG_DAL.delete("NDABCD");
            if (!NGUOIDUNG_DAL.KiemTraTonTai("bnvnbvnb"))
                NGUOIDUNG_DAL.insert("ND0007", " bmbn", "LND004", "bnvnbvnb");
        }
    }
}
