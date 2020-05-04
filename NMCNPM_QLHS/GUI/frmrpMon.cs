using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NMCNPM_QLHS.BUS;
using DevExpress.XtraReports.UI;

namespace NMCNPM_QLHS.GUI
{
    public partial class frmrpMon : DevExpress.XtraEditors.XtraForm
    {
        public frmrpMon()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string tenNamHoc = cboNamHoc.Text;
            string maNamHoc = cboNamHoc.EditValue.ToString();
            string tenHocKy = cboHocKy.Text;
            string maHocKy = cboHocKy.EditValue.ToString();
            string tenMonHoc = cboMonHoc.Text;
            string maMonHoc = cboMonHoc.EditValue.ToString();

            rpMon rp = new rpMon(maNamHoc, tenNamHoc, maHocKy, tenHocKy, maMonHoc, tenMonHoc);
            //documentViewer1.DocumentSource = rp;
            rp.CreateDocument();
            using (ReportPrintTool printTool = new ReportPrintTool(rp))
            {
                printTool.ShowPreviewDialog();
            }
        }


        private void load_cboHocKy()
        {
            cboHocKy.Properties.DataSource = HOCKY_BUS.LayTatCaHocKy();
            cboHocKy.Properties.DisplayMember = "TENHOCKY";
            cboHocKy.Properties.ValueMember = "MAHK";
        }

        private void load_cboNamHoc()
        {
            cboNamHoc.Properties.DataSource = NAMHOC_BUS.LayTatCaNamHoc();
            cboNamHoc.Properties.DisplayMember = "TENNAMHOC";
            cboNamHoc.Properties.ValueMember = "MANAMHOC";
        }

        private void load_cboMonHoc()
        {
            cboMonHoc.Properties.DataSource = MONHOC_BUS.LayTatCaMonHoc();
            cboMonHoc.Properties.DisplayMember = "TENMONHOC";
            cboMonHoc.Properties.ValueMember = "MAMONHOC";
        }

        private void comBoBox_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.Text != "" && cboHocKy.Text != "" && cboMonHoc.Text != "")
                bindingSourceBCTKM.DataSource = BAOCAO_BUS.layBaoCaoTongKetMon(cboMonHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboNamHoc.EditValue.ToString());
            else
                bindingSourceBCTKM.DataSource = null;
        }

        private void frmrpMon_Load(object sender, EventArgs e)
        {
            load_cboNamHoc();
            load_cboHocKy();
            load_cboMonHoc();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cboMonHoc.EditValue = null;
            cboHocKy.EditValue = null;
            cboNamHoc.EditValue = null;
            bindingSourceBCTKM.DataSource = null;
        }
    }
}