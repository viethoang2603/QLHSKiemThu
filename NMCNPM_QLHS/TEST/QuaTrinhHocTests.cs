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
        [Test]
        [TestCase("HS001", "LOP07", "HK01", true)]
        [TestCase("HS001", "LOP08", "HK01", false)]
        public void QuaTrinhHoc_KiemTraTonTai(string maHocSinh, string maLop, string maHocKy, bool result)
        {
            Assert.AreEqual(QUATRINHHOC_DAL.KiemTraTonTai(maHocSinh, maLop, maHocKy), result);
        }

        [Test]
        [TestCase("HS003", 0, new string[] { "2017-2018", "Học kỳ 1", "10/3", "8" })]
        [TestCase("HS003", 1, new string[] { "2017-2018", "Học kỳ 2", "10/2", "8.7" })]
        [TestCase("HS003", 2, new string[] { "2018-2019", "Học kỳ 1", "11/2", "7" })]
        public void QuaTrinhHoc_LayQuaTrinhHocSinh(string maHocSinh, int rowId, string[] row)
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
        [TestCase("HS001", "LOP01", "HK02", 11, 4)]
        public void QuaTrinhHoc_LuuQuaTrinhHoc_HK02(string maHocSinh, string maLop, string maHocKy, int slMonHoc, int slLoaiHinhKTra)
        {
            //Luu qua trinh hoc -> 
            //luu QHT cua N mon hoc -> BANGDIEMMON (MaBDM, MaQTH)
            //luu N * M loai hinh kiem tra vao CT_DIEMMON (MaLHKT, MaDDM)
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                int slBDM = db.BANGDIEMMONs.Count();
                int slCTDM = db.CT_DIEMMONs.Count();

                QUATRINHHOC_DAL.LuuPhanLopHS(maHocSinh, maLop, maHocKy);

                Assert.AreEqual(db.BANGDIEMMONs.Count(), slBDM + slMonHoc);
                Assert.AreEqual(db.CT_DIEMMONs.Count(), slMonHoc * slLoaiHinhKTra + slCTDM);
            }
            Assert.IsTrue(true);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
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
            }
        }
    }
}
