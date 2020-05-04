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
    public partial class frmrpDanhSachHocSinh : DevExpress.XtraEditors.XtraForm
    {
        public frmrpDanhSachHocSinh()
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
            if (cboNamHoc.Text != "")
            {
                cboLop.Properties.DataSource = LOP_BUS.LayLopTheoNamHoc(cboNamHoc.EditValue.ToString());
                cboLop.Properties.DisplayMember = "TENLOP";
                cboLop.Properties.ValueMember = "MALOP";
                cboLop.EditValue = null;
            }
            else
                cboLop.Properties.DataSource = null;
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            load_cboLop();
        }

        private void frmrpDanhSachHocSinh_Load(object sender, EventArgs e)
        {
            load_cboNamHoc();
        }

        private void cboLop_EditValueChanged(object sender, EventArgs e)
        {
            if (cboLop.Text != "")
                bindingSourceDiemTongKet.DataSource = HOCTAP_BUS.LayDiemHocSinhTheoLop(cboLop.EditValue.ToString());
            else
                bindingSourceDiemTongKet.DataSource = null;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string tenNamHoc = cboNamHoc.Text;
            string tenLop = cboLop.Text;
            string maLop = cboLop.EditValue.ToString();

            rpDanhSachHocSinh rp = new rpDanhSachHocSinh(tenNamHoc, tenLop, maLop);
            //documentViewer1.DocumentSource = rp;
            rp.CreateDocument();
            using (ReportPrintTool printTool = new ReportPrintTool(rp))
            {
                printTool.ShowPreviewDialog();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cboNamHoc.EditValue = null;
            bindingSourceDiemTongKet.DataSource = null;
        }
    }
}