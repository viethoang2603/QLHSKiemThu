﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NMCNPM_QLHS.DAL;
using NUnit.Framework;
                                                //DONE
namespace NMCNPM_QLHS.TEST
{
    [TestFixture]
    class ThamSoTests
    {
        [Test]
        [TestCase("DIEMDAT", 5)]
        [TestCase("DIEMDATMON", 5)]
        [TestCase("DIEMTOIDA", 10)]
        [TestCase("DIEMTOITHIEU", 0)]
        [TestCase("SISOTOIDA", 5)]
        [TestCase("SOLUONGLOP", 3)]
        [TestCase("SOLUONGMONHOC", 15)]
        [TestCase("TUOITOIDA", 20)]
        [TestCase("TUOITOITHIEU", 15)]
        public void Lay_DungThamSo_SuccessTraVeInt(string tenThamSo, int result)
        {
            Assert.AreEqual(THAMSO_DAL.LayThamSo(tenThamSo).GIATRI, result);
        }

        [Test]
        [TestCase("TUOITUOI", 15)]
        [TestCase("SISO", 15)]
        public void Lay_SaiTenThamSo_FailedNull(string tenThamSo, int result)
        {
            var thamSo = THAMSO_DAL.LayThamSo(tenThamSo);
            Assert.Null(thamSo);
        }

        [Test]
        [TestCase(10, 50, 10, 15, 100, 60, 60)]
        [TestCase(5, 20, 20, 1, 60, 100, 50)]
        public void LuuQuyDinh_DungThuTu_Success(
            double tuoiToiThieu,
            double tuoiToiDa,
            double siSoToiDa,
            double diemToiThieu,
            double diemToiDa,
            double diemDatMon,
            double diemDatHK)
        {
            THAMSO_DAL.LuuQuyDinh(tuoiToiThieu, tuoiToiDa, siSoToiDa, diemToiThieu, diemToiDa, diemDatMon, diemDatHK);
            Assert.AreEqual(THAMSO_DAL.LayThamSo("DIEMDAT").GIATRI, diemDatHK);
            Assert.AreEqual(THAMSO_DAL.LayThamSo("DIEMDATMON").GIATRI, diemDatMon);
            Assert.AreEqual(THAMSO_DAL.LayThamSo("DIEMTOIDA").GIATRI, diemToiDa);
            Assert.AreEqual(THAMSO_DAL.LayThamSo("DIEMTOITHIEU").GIATRI, diemToiThieu);
            Assert.AreEqual(THAMSO_DAL.LayThamSo("SISOTOIDA").GIATRI, siSoToiDa);
            Assert.AreEqual(THAMSO_DAL.LayThamSo("TUOITOIDA").GIATRI, tuoiToiDa);
            Assert.AreEqual(THAMSO_DAL.LayThamSo("TUOITOITHIEU").GIATRI, tuoiToiThieu);
        }

        [TearDown]
        public void TearDown()
        {
            THAMSO_DAL.LuuQuyDinh(15, 20, 5, 0, 10, 5, 5);
        }
    }
}
