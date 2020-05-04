using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using NMCNPM_QLHS.BUS;

namespace NMCNPM_QLHS.GUI
{
    public partial class rpHocKy : DevExpress.XtraReports.UI.XtraReport
    {
        public rpHocKy()
        {
            InitializeComponent();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in Parameters)
                p.Visible = false;
        }

        public rpHocKy(string maNamHoc, string tenNamHoc, string maHocKy, string tenHocKy)
        {
            InitializeComponent();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in Parameters)
                p.Visible = false;
            pNamHoc.Value = tenNamHoc;
            pHocKy.Value = tenHocKy;
            pNgayLap.Value = DateTime.Today;
            bindingSourceBCTKHK.DataSource = BAOCAO_BUS.layBaoCaoTongKetHK(maHocKy, maNamHoc);
        }

    }
}
