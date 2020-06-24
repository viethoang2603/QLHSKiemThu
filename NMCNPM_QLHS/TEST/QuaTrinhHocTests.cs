using System;
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
    class QuaTrinhHocTests
    {
        bool createQTH = false;

        [Test]
        [TestCase("HS001", "LOP07", "HK01", true)]
        public void KiemTraTonTai_TonTai_True(string maHocSinh, string maLop, string maHocKy, bool result)
        {
            Assert.AreEqual(QUATRINHHOC_DAL.KiemTraTonTai(maHocSinh, maLop, maHocKy), result);
        }

        [Test]
        [TestCase("HS001", "LOP08", "HK01", false)]
        public void KiemTraTonTai_KhongTonTai_False(string maHocSinh, string maLop, string maHocKy, bool result)
        {
            Assert.AreEqual(QUATRINHHOC_DAL.KiemTraTonTai(maHocSinh, maLop, maHocKy), result);
        }

        [Test]
        [TestCase("HS003", 0, new string[] { "2017-2018", "Học kỳ 1", "10/3", "8" })]
        [TestCase("HS003", 1, new string[] { "2017-2018", "Học kỳ 2", "10/2", "8.7" })]
        [TestCase("HS003", 2, new string[] { "2018-2019", "Học kỳ 1", "11/2", "7" })]
        public void LayQuaTrinhHS_HSTonTai_Success(string maHocSinh, int rowId, string[] row)
        {
            var table = QUATRINHHOC_DAL.LayQuaTrinhHocCuaHocSinh(maHocSinh);
            for (int i = 0; i < row.Length; ++i)
            {
                var str = table.Rows[rowId][i];
                if (str is double)
                    str = Math.Round(Convert.ToDecimal(str), 1);
                Assert.AreEqual(str.ToString(), row[i]);
            }
        }

        [Test]
        [TestCase("HS091", 0, new string[] { "2017-2018", "Học kỳ 1", "10/3", "8" })]
        public void LayQuaTrinhHS_KoTonTai_Null(string maHocSinh, int rowId, string[] row)
        {
            var table = QUATRINHHOC_DAL.LayQuaTrinhHocCuaHocSinh(maHocSinh);
            Assert.Null(table);
        }

        [Test]
        [TestCase("HS001", "LOP01", "HK02", 11, 4)]
        public void LuuQTH_HK02_Success(string maHocSinh, string maLop, string maHocKy, int slMonHoc, int slLoaiHinhKTra)
        {
            //Luu qua trinh hoc -> 
            //luu QHT cua N mon hoc -> BANGDIEMMON (MaBDM, MaQTH)
            //luu N * M loai hinh kiem tra vao CT_DIEMMON (MaLHKT, MaDDM)
            createQTH = true;
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                int slBDM = db.BANGDIEMMONs.Count();
                int slCTDM = db.CT_DIEMMONs.Count();

                QUATRINHHOC_DAL.LuuPhanLopHS(maHocSinh, maLop, maHocKy);

                Assert.AreEqual(db.BANGDIEMMONs.Count(), slBDM + slMonHoc);
                Assert.AreEqual(db.CT_DIEMMONs.Count(), slMonHoc * slLoaiHinhKTra + slCTDM);
            }
        }


        [Test]
        [TestCase("HS091", "LOP01", "HK02", 11, 4)]
        public void LuuQTH_HSKoTonTai_KhongLuu(string maHocSinh, string maLop, string maHocKy, int slMonHoc, int slLoaiHinhKTra)
        {
            //Luu qua trinh hoc -> 
            //luu QHT cua N mon hoc -> BANGDIEMMON (MaBDM, MaQTH)
            //luu N * M loai hinh kiem tra vao CT_DIEMMON (MaLHKT, MaDDM)
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                int slBDM = db.BANGDIEMMONs.Count();
                int slCTDM = db.CT_DIEMMONs.Count();
                int slQTH = db.QUATRINHHOCs.Count();

                QUATRINHHOC_DAL.LuuPhanLopHS(maHocSinh, maLop, maHocKy);

                Assert.AreEqual(db.BANGDIEMMONs.Count(), slBDM);
                Assert.AreEqual(db.CT_DIEMMONs.Count(), slCTDM);
                Assert.AreEqual(db.QUATRINHHOCs.Count(), slQTH);
            }
        }

        [Test]
        [TestCase("HS001", "LOP91", "HK02", 11, 4)]
        public void LuuQTH_LopKoTonTai_KhongLuu(string maHocSinh, string maLop, string maHocKy, int slMonHoc, int slLoaiHinhKTra)
        {
            //Luu qua trinh hoc -> 
            //luu QHT cua N mon hoc -> BANGDIEMMON (MaBDM, MaQTH)
            //luu N * M loai hinh kiem tra vao CT_DIEMMON (MaLHKT, MaDDM)
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                int slBDM = db.BANGDIEMMONs.Count();
                int slCTDM = db.CT_DIEMMONs.Count();
                int slQTH = db.QUATRINHHOCs.Count();

                QUATRINHHOC_DAL.LuuPhanLopHS(maHocSinh, maLop, maHocKy);

                Assert.AreEqual(db.BANGDIEMMONs.Count(), slBDM);
                Assert.AreEqual(db.CT_DIEMMONs.Count(), slCTDM);
                Assert.AreEqual(db.QUATRINHHOCs.Count(), slQTH);
            }
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            if (createQTH)
                using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
                {
                    var listBDMs = db.BANGDIEMMONs.Where(bdm => bdm.MAQTHOC == "QTH051").ToList();
                    for (int i = 0; i < listBDMs.Count; ++i)
                    {
                        foreach (var item in db.CT_DIEMMONs.Where(ctdm => ctdm.MABANGDIEMMON == listBDMs[i].MABANGDIEMMON))
                        {
                            db.CT_DIEMMONs.DeleteOnSubmit(item);
                        }
                        db.BANGDIEMMONs.DeleteOnSubmit(listBDMs[i]);
                    }
                    db.QUATRINHHOCs.DeleteOnSubmit(db.QUATRINHHOCs.Where(qth => qth.MAQTHOC == "QTH051").FirstOrDefault());
                    db.SubmitChanges();
                    createQTH = false;
                }
        }
    }
}
