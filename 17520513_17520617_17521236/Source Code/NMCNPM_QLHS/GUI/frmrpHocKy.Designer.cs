namespace NMCNPM_QLHS.GUI
{
    partial class frmrpHocKy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmrpHocKy));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cboHocKy = new DevExpress.XtraEditors.LookUpEdit();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.cboNamHoc = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControlBaoCaoHK = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceBaoCaoHK = new System.Windows.Forms.BindingSource();
            this.dgvBaoCaoHK = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_Lop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_SiSo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_SLDat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_TyLe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_maHS_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_hoTen_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_gioiTinh_edit = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.col_ngaySinh_edit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.col_diaChi_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_email_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNamHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBaoCaoHK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaoCaoHK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoHK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_maHS_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_hoTen_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_gioiTinh_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_ngaySinh_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_ngaySinh_edit.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_diaChi_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_email_edit)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cboHocKy);
            this.layoutControl1.Controls.Add(this.btnLamMoi);
            this.layoutControl1.Controls.Add(this.btnIn);
            this.layoutControl1.Controls.Add(this.cboNamHoc);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(794, 49);
            this.layoutControl1.TabIndex = 11;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cboHocKy
            // 
            this.cboHocKy.Location = new System.Drawing.Point(404, 12);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboHocKy.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENHOCKY", "")});
            this.cboHocKy.Properties.NullText = "";
            this.cboHocKy.Size = new System.Drawing.Size(213, 20);
            this.cboHocKy.StyleController = this.layoutControl1;
            this.cboHocKy.TabIndex = 2;
            this.cboHocKy.EditValueChanged += new System.EventHandler(this.comBoBox_EditValueChanged);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.icons8_Refresh_16px;
            this.btnLamMoi.Location = new System.Drawing.Point(714, 12);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(68, 22);
            this.btnLamMoi.StyleController = this.layoutControl1;
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnIn
            // 
            this.btnIn.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.icons8_Export_16px;
            this.btnIn.Location = new System.Drawing.Point(621, 12);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(89, 22);
            this.btnIn.StyleController = this.layoutControl1;
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "Tạo báo cáo";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.Location = new System.Drawing.Point(60, 12);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNamHoc.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENNAMHOC", "")});
            this.cboNamHoc.Properties.NullText = "";
            this.cboNamHoc.Size = new System.Drawing.Size(292, 20);
            this.cboNamHoc.StyleController = this.layoutControl1;
            this.cboNamHoc.TabIndex = 1;
            this.cboNamHoc.EditValueChanged += new System.EventHandler(this.comBoBox_EditValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(794, 49);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnLamMoi;
            this.layoutControlItem4.Location = new System.Drawing.Point(702, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(72, 29);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnIn;
            this.layoutControlItem3.Location = new System.Drawing.Point(609, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(93, 29);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cboNamHoc;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(344, 29);
            this.layoutControlItem1.Text = "Năm học:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(45, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cboHocKy;
            this.layoutControlItem5.Location = new System.Drawing.Point(344, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(265, 29);
            this.layoutControlItem5.Text = "Học kỳ:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(45, 13);
            // 
            // gridControlBaoCaoHK
            // 
            this.gridControlBaoCaoHK.DataSource = this.bindingSourceBaoCaoHK;
            this.gridControlBaoCaoHK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlBaoCaoHK.Location = new System.Drawing.Point(0, 49);
            this.gridControlBaoCaoHK.MainView = this.dgvBaoCaoHK;
            this.gridControlBaoCaoHK.Name = "gridControlBaoCaoHK";
            this.gridControlBaoCaoHK.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.col_maHS_edit,
            this.col_hoTen_edit,
            this.col_gioiTinh_edit,
            this.col_ngaySinh_edit,
            this.col_diaChi_edit,
            this.col_email_edit});
            this.gridControlBaoCaoHK.Size = new System.Drawing.Size(794, 294);
            this.gridControlBaoCaoHK.TabIndex = 12;
            this.gridControlBaoCaoHK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvBaoCaoHK});
            // 
            // bindingSourceBaoCaoHK
            // 
            this.bindingSourceBaoCaoHK.DataSource = typeof(NMCNPM_QLHS.DAL.sp_LayBaoCaoTongKetHocKyResult);
            // 
            // dgvBaoCaoHK
            // 
            this.dgvBaoCaoHK.Appearance.GroupPanel.BackColor = System.Drawing.Color.Transparent;
            this.dgvBaoCaoHK.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.Transparent;
            this.dgvBaoCaoHK.Appearance.GroupPanel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.dgvBaoCaoHK.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.dgvBaoCaoHK.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgvBaoCaoHK.Appearance.GroupPanel.Options.UseFont = true;
            this.dgvBaoCaoHK.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgvBaoCaoHK.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.dgvBaoCaoHK.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvBaoCaoHK.Appearance.Row.Options.UseTextOptions = true;
            this.dgvBaoCaoHK.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.dgvBaoCaoHK.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_Lop,
            this.col_SiSo,
            this.col_SLDat,
            this.col_TyLe});
            this.dgvBaoCaoHK.GridControl = this.gridControlBaoCaoHK;
            this.dgvBaoCaoHK.GroupPanelText = "BÁO CÁO TỔNG KẾT HỌC KỲ";
            this.dgvBaoCaoHK.Name = "dgvBaoCaoHK";
            this.dgvBaoCaoHK.OptionsBehavior.Editable = false;
            // 
            // col_Lop
            // 
            this.col_Lop.Caption = "Lớp";
            this.col_Lop.FieldName = "TENLOP";
            this.col_Lop.MinWidth = 21;
            this.col_Lop.Name = "col_Lop";
            this.col_Lop.Visible = true;
            this.col_Lop.VisibleIndex = 0;
            this.col_Lop.Width = 134;
            // 
            // col_SiSo
            // 
            this.col_SiSo.Caption = "Sĩ số";
            this.col_SiSo.FieldName = "SISO";
            this.col_SiSo.MinWidth = 21;
            this.col_SiSo.Name = "col_SiSo";
            this.col_SiSo.Visible = true;
            this.col_SiSo.VisibleIndex = 1;
            this.col_SiSo.Width = 176;
            // 
            // col_SLDat
            // 
            this.col_SLDat.Caption = "Số lượng đạt";
            this.col_SLDat.FieldName = "SOLUONGDAT";
            this.col_SLDat.MinWidth = 21;
            this.col_SLDat.Name = "col_SLDat";
            this.col_SLDat.Visible = true;
            this.col_SLDat.VisibleIndex = 2;
            this.col_SLDat.Width = 176;
            // 
            // col_TyLe
            // 
            this.col_TyLe.Caption = "Tỷ lệ";
            this.col_TyLe.FieldName = "TYLE";
            this.col_TyLe.MinWidth = 21;
            this.col_TyLe.Name = "col_TyLe";
            this.col_TyLe.Visible = true;
            this.col_TyLe.VisibleIndex = 3;
            this.col_TyLe.Width = 176;
            // 
            // col_maHS_edit
            // 
            this.col_maHS_edit.AutoHeight = false;
            this.col_maHS_edit.Name = "col_maHS_edit";
            // 
            // col_hoTen_edit
            // 
            this.col_hoTen_edit.AutoHeight = false;
            this.col_hoTen_edit.Name = "col_hoTen_edit";
            // 
            // col_gioiTinh_edit
            // 
            this.col_gioiTinh_edit.AutoHeight = false;
            this.col_gioiTinh_edit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.col_gioiTinh_edit.Name = "col_gioiTinh_edit";
            // 
            // col_ngaySinh_edit
            // 
            this.col_ngaySinh_edit.AutoHeight = false;
            this.col_ngaySinh_edit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.col_ngaySinh_edit.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.col_ngaySinh_edit.Name = "col_ngaySinh_edit";
            // 
            // col_diaChi_edit
            // 
            this.col_diaChi_edit.AutoHeight = false;
            this.col_diaChi_edit.Name = "col_diaChi_edit";
            // 
            // col_email_edit
            // 
            this.col_email_edit.AutoHeight = false;
            this.col_email_edit.Name = "col_email_edit";
            // 
            // frmrpHocKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 343);
            this.Controls.Add(this.gridControlBaoCaoHK);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmrpHocKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo học kỳ";
            this.Load += new System.EventHandler(this.frmrpHocKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNamHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBaoCaoHK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaoCaoHK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoHK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_maHS_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_hoTen_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_gioiTinh_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_ngaySinh_edit.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_ngaySinh_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_diaChi_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_email_edit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LookUpEdit cboHocKy;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.LookUpEdit cboNamHoc;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.GridControl gridControlBaoCaoHK;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvBaoCaoHK;
        private DevExpress.XtraGrid.Columns.GridColumn col_Lop;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_maHS_edit;
        private DevExpress.XtraGrid.Columns.GridColumn col_SiSo;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_hoTen_edit;
        private DevExpress.XtraGrid.Columns.GridColumn col_SLDat;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit col_ngaySinh_edit;
        private DevExpress.XtraGrid.Columns.GridColumn col_TyLe;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_diaChi_edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox col_gioiTinh_edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_email_edit;
        private System.Windows.Forms.BindingSource bindingSourceBaoCaoHK;
    }
}