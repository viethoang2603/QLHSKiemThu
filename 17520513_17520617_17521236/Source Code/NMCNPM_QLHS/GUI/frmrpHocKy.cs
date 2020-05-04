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
    public partial class frmrpHocKy : DevExpress.XtraEditors.XtraForm
    {
        public frmrpHocKy()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string tenNamHoc = cboNamHoc.Text;
            string maNamHoc = cboNamHoc.EditValue.ToString();
            string tenHocKy = cboHocKy.Text;
            string maHocKy = cboHocKy.EditValue.ToString();

            rpHocKy rp = new rpHocKy(maNamHoc, tenNamHoc, maHocKy, tenHocKy);
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

        private void comBoBox_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.Text != "" && cboHocKy.Text != "")
                bindingSourceBaoCaoHK.DataSource = BAOCAO_BUS.layBaoCaoTongKetHK(cboHocKy.EditValue.ToString(), cboNamHoc.EditValue.ToString());
            else
                bindingSourceBaoCaoHK.DataSource = null;
        }

        private void frmrpHocKy_Load(object sender, EventArgs e)
        {
            load_cboNamHoc();
            load_cboHocKy();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cboHocKy.EditValue = null;
            cboHocKy.EditValue = null;
            bindingSourceBaoCaoHK.DataSource = null;
        }
    }
}