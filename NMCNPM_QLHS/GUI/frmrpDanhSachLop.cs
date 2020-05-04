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
    public partial class frmrpDanhSachLop : DevExpress.XtraEditors.XtraForm
    {
        public frmrpDanhSachLop(string maLop, string maNamHoc)
        {
            InitializeComponent();
            load_cboNamHoc();
            cboNamHoc.EditValue = maNamHoc;
            cboLop.EditValue = maLop;
            cboHocKy.EditValue = "HK01";
            bindingSourceDSHS.DataSource = HOCSINH_BUS.LayHocSinhTheoLop(maLop, "HK01");
            cboNamHoc.ReadOnly = true;
            cboLop.ReadOnly = true;
            btnLamMoi.Enabled = false;
        }

        public frmrpDanhSachLop()
        {
            InitializeComponent();
        }

        private void load_cboNamHoc()
        {
            cboNamHoc.Properties.DataSource = NAMHOC_BUS.LayTatCaNamHoc();
            cboNamHoc.Properties.DisplayMember = "TENNAMHOC";
            cboNamHoc.Properties.ValueMember = "MANAMHOC";
        }

        private void load_cboLop()
        {
            if (cboNamHoc.EditValue != null)
            {
                cboLop.Properties.DataSource = LOP_BUS.LayLopTheoNamHoc(cboNamHoc.EditValue.ToString());
                cboLop.Properties.DisplayMember = "TENLOP";
                cboLop.Properties.ValueMember = "MALOP";
                cboLop.EditValue = null;
            }
            else
                cboLop.Properties.DataSource = null;
        }

        private void load_cboHocKy()
        {
            cboHocKy.Properties.DataSource = HOCKY_BUS.LayTatCaHocKy();
            cboHocKy.Properties.DisplayMember = "TENHOCKY";
            cboHocKy.Properties.ValueMember = "MAHK";
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            load_cboLop();
        }

        private void frmrpDanhSachLop_Load(object sender, EventArgs e)
        {
            load_cboNamHoc();
            load_cboHocKy();
        }

        private void comBoBox_EditValueChanged(object sender, EventArgs e)
        {
            if (cboLop.Text != "" && cboHocKy.Text != "")
                bindingSourceDSHS.DataSource = HOCSINH_BUS.LayHocSinhTheoLop(cboLop.EditValue.ToString(), cboHocKy.EditValue.ToString());
            else
                bindingSourceDSHS.DataSource = null;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string tenNamHoc = cboNamHoc.Text;
            string tenLop = cboLop.Text;
            string maLop = cboLop.EditValue.ToString();
            string tenHK = cboHocKy.Text;
            string maHK = cboHocKy.EditValue.ToString();

            rpDanhSachLop rp = new rpDanhSachLop(tenNamHoc, tenLop, maLop, tenHK, maHK);
            //documentViewer1.DocumentSource = rp;
            rp.CreateDocument();
            using (ReportPrintTool printTool = new ReportPrintTool(rp))
            {
                printTool.ShowPreviewDialog();
            }
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboLop.Text != "" && cboHocKy.Text != "")
                bindingSourceDSHS.DataSource = HOCSINH_BUS.LayHocSinhTheoLop(cboLop.EditValue.ToString(), cboHocKy.EditValue.ToString());
            else
                bindingSourceDSHS.DataSource = null;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cboNamHoc.EditValue = null;
            cboHocKy.EditValue = null;
            bindingSourceDSHS.DataSource = null;
        }
    }
}