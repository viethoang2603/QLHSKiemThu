using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using NMCNPM_QLHS.BUS;

namespace NMCNPM_QLHS.GUI
{
    public partial class rpDanhSachLop : DevExpress.XtraReports.UI.XtraReport
    {
        public rpDanhSachLop()
        {
            InitializeComponent();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in Parameters)
                p.Visible = false;
        }

        public rpDanhSachLop(string tenNamHoc, string tenLop, string maLop,string tenHK, string maHK)
        {
            InitializeComponent();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in Parameters)
                p.Visible = false;
            pNamHoc.Value = tenNamHoc;
            pLop.Value = tenLop;
            pHocKy.Value = tenHK;
            pNgayLap.Value = DateTime.Today;
            bindingSourceDSHS.DataSource = HOCSINH_BUS.LayHocSinhTheoLop(maLop, maHK);
        }

    }
}
