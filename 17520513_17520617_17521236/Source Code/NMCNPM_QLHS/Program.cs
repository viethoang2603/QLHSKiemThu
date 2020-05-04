using NMCNPM_QLHS.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMCNPM_QLHS.GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmSplash());
           // Application.Run(new frmManHinhChinh());
            //Application.Run(new frmNguoiDung());
           Application.Run(new frmDangNhap());
            //Application.Run(new frmNhapDiemChung());
            //Application.Run(new frmNhapDiemChiTiet());
            //Application.Run(new frmPhanLop());
            //Application.Run(new frmQuyDinh());
            //Application.Run(new frmTraCuuHocSinh());
            //Application.Run(new frmLenLop());
            //Application.Run(new frmLop());
            //Application.Run(new frmrpDanhSachLop());
            //Application.Run(new frmrpHocKy());
            //Application.Run(new frmHocKy());
            //Application.Run(new frmHocSinh());
            //Application.Run(new frmDoiMatKhau());
        }
    }
}
