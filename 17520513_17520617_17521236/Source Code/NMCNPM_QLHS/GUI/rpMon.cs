using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using NMCNPM_QLHS.BUS;

namespace NMCNPM_QLHS.GUI
{
    public partial class rpMon : DevExpress.XtraReports.UI.XtraReport
    {
        public rpMon()
        {
            InitializeComponent();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in Parameters)
                p.Visible = false;
        }

        public rpMon(string maNamHoc, string tenNamHoc, string maHocKy, string tenHocKy, string maMonHoc, string tenMonHoc)
        {
            InitializeComponent();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in Parameters)
                p.Visible = false;
            pNamHoc.Value = tenNamHoc;
            pHocKy.Value = tenHocKy;
            pMon.Value = tenMonHoc;
            pNgayLap.Value = DateTime.Today;
            bindingSourceBCTKM.DataSource = BAOCAO_BUS.layBaoCaoTongKetMon(maMonHoc, maHocKy, maNamHoc);
        }

    }
}
