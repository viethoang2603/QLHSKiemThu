using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using NMCNPM_QLHS.BUS;

namespace NMCNPM_QLHS.GUI
{
    public partial class rpDanhSachHocSinh : DevExpress.XtraReports.UI.XtraReport
    {
        public rpDanhSachHocSinh()
        {
            InitializeComponent();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in Parameters)
                p.Visible = false;
        }

        public rpDanhSachHocSinh(string tenNamHoc, string tenLop, string maLop)
        {
            InitializeComponent();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in Parameters)
                p.Visible = false;
            pNamHoc.Value = tenNamHoc;
            pLop.Value = tenLop;
            pNgayLap.Value = DateTime.Today;
            bindingSourceDiemTongKet.DataSource = HOCTAP_BUS.LayDiemHocSinhTheoLop(maLop);
        }

    }
}
