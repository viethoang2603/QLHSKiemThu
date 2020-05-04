namespace NMCNPM_QLHS.GUI
{
    partial class frmrpDanhSachHocSinh
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmrpDanhSachHocSinh));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cboLop = new DevExpress.XtraEditors.LookUpEdit();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.cboNamHoc = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControlHocSinh = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceDiemTongKet = new System.Windows.Forms.BindingSource(this.components);
            this.dgvDiemTongKet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_maHS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_diemTBHK1_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_hoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_hoTen_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_DiemTBHK1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_HocKy2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_diemTBHK2_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_CaNam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_diemCaNam_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_maHS_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_gioiTinh_edit = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.col_diemTBH_edit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNamHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDiemTongKet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemTongKet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_diemTBHK1_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_hoTen_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_diemTBHK2_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_diemCaNam_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_maHS_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_gioiTinh_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_diemTBH_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_diemTBH_edit.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cboLop);
            this.layoutControl1.Controls.Add(this.btnLamMoi);
            this.layoutControl1.Controls.Add(this.btnIn);
            this.layoutControl1.Controls.Add(this.cboNamHoc);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1002, 60);
            this.layoutControl1.TabIndex = 10;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cboLop
            // 
            this.cboLop.Location = new System.Drawing.Point(485, 14);
            this.cboLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboLop.Name = "cboLop";
            this.cboLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLop.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENLOP", "")});
            this.cboLop.Properties.NullText = "";
            this.cboLop.Size = new System.Drawing.Size(311, 22);
            this.cboLop.StyleController = this.layoutControl1;
            this.cboLop.TabIndex = 2;
            this.cboLop.EditValueChanged += new System.EventHandler(this.cboLop_EditValueChanged);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.icons8_Refresh_16px;
            this.btnLamMoi.Location = new System.Drawing.Point(908, 14);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(80, 27);
            this.btnLamMoi.StyleController = this.layoutControl1;
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnIn
            // 
            this.btnIn.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.icons8_Export_16px;
            this.btnIn.Location = new System.Drawing.Point(800, 14);
            this.btnIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(104, 27);
            this.btnIn.StyleController = this.layoutControl1;
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "Tạo báo cáo";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.Location = new System.Drawing.Point(77, 14);
            this.cboNamHoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNamHoc.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENNAMHOC", "")});
            this.cboNamHoc.Properties.NullText = "";
            this.cboNamHoc.Size = new System.Drawing.Size(341, 22);
            this.cboNamHoc.StyleController = this.layoutControl1;
            this.cboNamHoc.TabIndex = 1;
            this.cboNamHoc.EditValueChanged += new System.EventHandler(this.cboNamHoc_EditValueChanged);
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
            this.Root.Size = new System.Drawing.Size(1002, 60);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnLamMoi;
            this.layoutControlItem4.Location = new System.Drawing.Point(894, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(84, 36);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnIn;
            this.layoutControlItem3.Location = new System.Drawing.Point(786, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(108, 36);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cboNamHoc;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(408, 36);
            this.layoutControlItem1.Text = "Năm học:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(60, 17);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cboLop;
            this.layoutControlItem5.Location = new System.Drawing.Point(408, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(378, 36);
            this.layoutControlItem5.Text = "Lớp:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(60, 17);
            // 
            // gridControlHocSinh
            // 
            this.gridControlHocSinh.DataSource = this.bindingSourceDiemTongKet;
            this.gridControlHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlHocSinh.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlHocSinh.Location = new System.Drawing.Point(0, 60);
            this.gridControlHocSinh.MainView = this.dgvDiemTongKet;
            this.gridControlHocSinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlHocSinh.Name = "gridControlHocSinh";
            this.gridControlHocSinh.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.col_maHS_edit,
            this.col_hoTen_edit,
            this.col_gioiTinh_edit,
            this.col_diemTBH_edit,
            this.col_diemTBHK2_edit,
            this.col_diemCaNam_edit,
            this.col_diemTBHK1_edit});
            this.gridControlHocSinh.Size = new System.Drawing.Size(1002, 573);
            this.gridControlHocSinh.TabIndex = 11;
            this.gridControlHocSinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvDiemTongKet});
            // 
            // bindingSourceDiemTongKet
            // 
            this.bindingSourceDiemTongKet.DataSource = typeof(NMCNPM_QLHS.DAL.sp_LayDiemHocSinhTheoLopResult);
            // 
            // dgvDiemTongKet
            // 
            this.dgvDiemTongKet.Appearance.GroupPanel.BackColor = System.Drawing.Color.Transparent;
            this.dgvDiemTongKet.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.Transparent;
            this.dgvDiemTongKet.Appearance.GroupPanel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.dgvDiemTongKet.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.dgvDiemTongKet.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgvDiemTongKet.Appearance.GroupPanel.Options.UseFont = true;
            this.dgvDiemTongKet.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgvDiemTongKet.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.dgvDiemTongKet.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvDiemTongKet.Appearance.Row.Options.UseTextOptions = true;
            this.dgvDiemTongKet.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.dgvDiemTongKet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_maHS,
            this.col_hoTen,
            this.col_DiemTBHK1,
            this.col_HocKy2,
            this.col_CaNam});
            this.dgvDiemTongKet.DetailHeight = 431;
            this.dgvDiemTongKet.GridControl = this.gridControlHocSinh;
            this.dgvDiemTongKet.GroupPanelText = "DANH SÁCH HỌC SINH";
            this.dgvDiemTongKet.Name = "dgvDiemTongKet";
            this.dgvDiemTongKet.OptionsBehavior.Editable = false;
            // 
            // col_maHS
            // 
            this.col_maHS.Caption = "Mã Học Sinh";
            this.col_maHS.ColumnEdit = this.col_diemTBHK1_edit;
            this.col_maHS.FieldName = "MAHS";
            this.col_maHS.MinWidth = 24;
            this.col_maHS.Name = "col_maHS";
            this.col_maHS.Visible = true;
            this.col_maHS.VisibleIndex = 0;
            this.col_maHS.Width = 168;
            // 
            // col_diemTBHK1_edit
            // 
            this.col_diemTBHK1_edit.AutoHeight = false;
            this.col_diemTBHK1_edit.Name = "col_diemTBHK1_edit";
            // 
            // col_hoTen
            // 
            this.col_hoTen.Caption = "Họ Tên";
            this.col_hoTen.ColumnEdit = this.col_hoTen_edit;
            this.col_hoTen.FieldName = "HOTEN";
            this.col_hoTen.MinWidth = 24;
            this.col_hoTen.Name = "col_hoTen";
            this.col_hoTen.Visible = true;
            this.col_hoTen.VisibleIndex = 1;
            this.col_hoTen.Width = 329;
            // 
            // col_hoTen_edit
            // 
            this.col_hoTen_edit.AutoHeight = false;
            this.col_hoTen_edit.Name = "col_hoTen_edit";
            // 
            // col_DiemTBHK1
            // 
            this.col_DiemTBHK1.Caption = "Học kỳ 1";
            this.col_DiemTBHK1.ColumnEdit = this.col_diemTBHK1_edit;
            this.col_DiemTBHK1.FieldName = "DIEMTBHK1";
            this.col_DiemTBHK1.MinWidth = 24;
            this.col_DiemTBHK1.Name = "col_DiemTBHK1";
            this.col_DiemTBHK1.Visible = true;
            this.col_DiemTBHK1.VisibleIndex = 2;
            this.col_DiemTBHK1.Width = 168;
            // 
            // col_HocKy2
            // 
            this.col_HocKy2.Caption = "Học kỳ 2";
            this.col_HocKy2.ColumnEdit = this.col_diemTBHK2_edit;
            this.col_HocKy2.FieldName = "DIEMTBHK2";
            this.col_HocKy2.MinWidth = 24;
            this.col_HocKy2.Name = "col_HocKy2";
            this.col_HocKy2.Visible = true;
            this.col_HocKy2.VisibleIndex = 3;
            this.col_HocKy2.Width = 161;
            // 
            // col_diemTBHK2_edit
            // 
            this.col_diemTBHK2_edit.AutoHeight = false;
            this.col_diemTBHK2_edit.Name = "col_diemTBHK2_edit";
            // 
            // col_CaNam
            // 
            this.col_CaNam.Caption = "Cả năm";
            this.col_CaNam.ColumnEdit = this.col_diemCaNam_edit;
            this.col_CaNam.FieldName = "DIEMCANAM";
            this.col_CaNam.MinWidth = 24;
            this.col_CaNam.Name = "col_CaNam";
            this.col_CaNam.Visible = true;
            this.col_CaNam.VisibleIndex = 4;
            this.col_CaNam.Width = 751;
            // 
            // col_diemCaNam_edit
            // 
            this.col_diemCaNam_edit.AutoHeight = false;
            this.col_diemCaNam_edit.Name = "col_diemCaNam_edit";
            // 
            // col_maHS_edit
            // 
            this.col_maHS_edit.AutoHeight = false;
            this.col_maHS_edit.Name = "col_maHS_edit";
            // 
            // col_gioiTinh_edit
            // 
            this.col_gioiTinh_edit.AutoHeight = false;
            this.col_gioiTinh_edit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.col_gioiTinh_edit.Name = "col_gioiTinh_edit";
            // 
            // col_diemTBH_edit
            // 
            this.col_diemTBH_edit.AutoHeight = false;
            this.col_diemTBH_edit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.col_diemTBH_edit.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.col_diemTBH_edit.Name = "col_diemTBH_edit";
            // 
            // frmrpDanhSachHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 633);
            this.Controls.Add(this.gridControlHocSinh);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmrpDanhSachHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách học sinh";
            this.Load += new System.EventHandler(this.frmrpDanhSachHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNamHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDiemTongKet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemTongKet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_diemTBHK1_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_hoTen_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_diemTBHK2_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_diemCaNam_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_maHS_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_gioiTinh_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_diemTBH_edit.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_diemTBH_edit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.LookUpEdit cboNamHoc;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl gridControlHocSinh;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvDiemTongKet;
        private DevExpress.XtraGrid.Columns.GridColumn col_maHS;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_maHS_edit;
        private DevExpress.XtraGrid.Columns.GridColumn col_hoTen;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_hoTen_edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox col_gioiTinh_edit;
        private DevExpress.XtraGrid.Columns.GridColumn col_DiemTBHK1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit col_diemTBH_edit;
        private DevExpress.XtraGrid.Columns.GridColumn col_HocKy2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_diemTBHK2_edit;
        private DevExpress.XtraGrid.Columns.GridColumn col_CaNam;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_diemCaNam_edit;
        private DevExpress.XtraEditors.LookUpEdit cboLop;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.BindingSource bindingSourceDiemTongKet;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_diemTBHK1_edit;
    }
}