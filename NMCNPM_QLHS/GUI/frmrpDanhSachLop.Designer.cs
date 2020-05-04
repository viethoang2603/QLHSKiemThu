namespace NMCNPM_QLHS.GUI
{
    partial class frmrpDanhSachLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmrpDanhSachLop));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.cboNamHoc = new DevExpress.XtraEditors.LookUpEdit();
            this.cboHocKy = new DevExpress.XtraEditors.LookUpEdit();
            this.cboLop = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControlHocSinh = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceDSHS = new System.Windows.Forms.BindingSource();
            this.dgvHocSinh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_maHS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_maHS_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_hoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_hoTen_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_gioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_gioiTinh_edit = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.col_ngaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ngaySinh_edit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.col_diaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_diaChi_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_email_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboNamHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDSHS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
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
            this.layoutControl1.Controls.Add(this.btnLamMoi);
            this.layoutControl1.Controls.Add(this.btnIn);
            this.layoutControl1.Controls.Add(this.cboNamHoc);
            this.layoutControl1.Controls.Add(this.cboHocKy);
            this.layoutControl1.Controls.Add(this.cboLop);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(818, 49);
            this.layoutControl1.TabIndex = 11;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.icons8_Refresh_16px;
            this.btnLamMoi.Location = new System.Drawing.Point(738, 12);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(68, 22);
            this.btnLamMoi.StyleController = this.layoutControl1;
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnIn
            // 
            this.btnIn.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.icons8_Export_16px;
            this.btnIn.Location = new System.Drawing.Point(646, 12);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(88, 22);
            this.btnIn.StyleController = this.layoutControl1;
            this.btnIn.TabIndex = 4;
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
            this.cboNamHoc.Size = new System.Drawing.Size(162, 20);
            this.cboNamHoc.StyleController = this.layoutControl1;
            this.cboNamHoc.TabIndex = 1;
            this.cboNamHoc.EditValueChanged += new System.EventHandler(this.cboNamHoc_EditValueChanged);
            // 
            // cboHocKy
            // 
            this.cboHocKy.Location = new System.Drawing.Point(491, 12);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboHocKy.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENHOCKY", "")});
            this.cboHocKy.Properties.NullText = "";
            this.cboHocKy.Size = new System.Drawing.Size(151, 20);
            this.cboHocKy.StyleController = this.layoutControl1;
            this.cboHocKy.TabIndex = 3;
            this.cboHocKy.EditValueChanged += new System.EventHandler(this.comBoBox_EditValueChanged);
            // 
            // cboLop
            // 
            this.cboLop.Location = new System.Drawing.Point(274, 12);
            this.cboLop.Name = "cboLop";
            this.cboLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLop.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENLOP", "")});
            this.cboLop.Properties.NullText = "";
            this.cboLop.Size = new System.Drawing.Size(165, 20);
            this.cboLop.StyleController = this.layoutControl1;
            this.cboLop.TabIndex = 2;
            this.cboLop.EditValueChanged += new System.EventHandler(this.comBoBox_EditValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.layoutControlItem5,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(818, 49);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnLamMoi;
            this.layoutControlItem4.Location = new System.Drawing.Point(726, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(72, 29);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnIn;
            this.layoutControlItem3.Location = new System.Drawing.Point(634, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(92, 29);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cboNamHoc;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(214, 29);
            this.layoutControlItem1.Text = "Năm học:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(45, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cboHocKy;
            this.layoutControlItem5.CustomizationFormText = "Học kỳ:";
            this.layoutControlItem5.Location = new System.Drawing.Point(431, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(203, 29);
            this.layoutControlItem5.Text = "Học kỳ:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(45, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cboLop;
            this.layoutControlItem2.CustomizationFormText = "Lớp:";
            this.layoutControlItem2.Location = new System.Drawing.Point(214, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(217, 29);
            this.layoutControlItem2.Text = "Lớp:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(45, 13);
            // 
            // gridControlHocSinh
            // 
            this.gridControlHocSinh.DataSource = this.bindingSourceDSHS;
            this.gridControlHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlHocSinh.Location = new System.Drawing.Point(0, 49);
            this.gridControlHocSinh.MainView = this.dgvHocSinh;
            this.gridControlHocSinh.Name = "gridControlHocSinh";
            this.gridControlHocSinh.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.col_maHS_edit,
            this.col_hoTen_edit,
            this.col_gioiTinh_edit,
            this.col_ngaySinh_edit,
            this.col_diaChi_edit,
            this.col_email_edit});
            this.gridControlHocSinh.Size = new System.Drawing.Size(818, 365);
            this.gridControlHocSinh.TabIndex = 12;
            this.gridControlHocSinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvHocSinh});
            // 
            // dgvHocSinh
            // 
            this.dgvHocSinh.Appearance.GroupPanel.BackColor = System.Drawing.Color.Transparent;
            this.dgvHocSinh.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.Transparent;
            this.dgvHocSinh.Appearance.GroupPanel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.dgvHocSinh.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.dgvHocSinh.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgvHocSinh.Appearance.GroupPanel.Options.UseFont = true;
            this.dgvHocSinh.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgvHocSinh.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.dgvHocSinh.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvHocSinh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_maHS,
            this.col_hoTen,
            this.col_gioiTinh,
            this.col_ngaySinh,
            this.col_diaChi,
            this.col_email});
            this.dgvHocSinh.GridControl = this.gridControlHocSinh;
            this.dgvHocSinh.GroupPanelText = "DANH SÁCH HỌC SINH";
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.OptionsBehavior.Editable = false;
            this.dgvHocSinh.OptionsView.ShowFooter = true;
            // 
            // col_maHS
            // 
            this.col_maHS.Caption = "Mã Học Sinh";
            this.col_maHS.ColumnEdit = this.col_maHS_edit;
            this.col_maHS.FieldName = "MAHS";
            this.col_maHS.MinWidth = 21;
            this.col_maHS.Name = "col_maHS";
            this.col_maHS.Visible = true;
            this.col_maHS.VisibleIndex = 0;
            this.col_maHS.Width = 81;
            // 
            // col_maHS_edit
            // 
            this.col_maHS_edit.AutoHeight = false;
            this.col_maHS_edit.Name = "col_maHS_edit";
            // 
            // col_hoTen
            // 
            this.col_hoTen.Caption = "Họ Tên";
            this.col_hoTen.ColumnEdit = this.col_hoTen_edit;
            this.col_hoTen.FieldName = "HOTEN";
            this.col_hoTen.MinWidth = 21;
            this.col_hoTen.Name = "col_hoTen";
            this.col_hoTen.Visible = true;
            this.col_hoTen.VisibleIndex = 1;
            this.col_hoTen.Width = 81;
            // 
            // col_hoTen_edit
            // 
            this.col_hoTen_edit.AutoHeight = false;
            this.col_hoTen_edit.Name = "col_hoTen_edit";
            // 
            // col_gioiTinh
            // 
            this.col_gioiTinh.Caption = "Giới Tính";
            this.col_gioiTinh.ColumnEdit = this.col_gioiTinh_edit;
            this.col_gioiTinh.FieldName = "GIOITINH";
            this.col_gioiTinh.MinWidth = 21;
            this.col_gioiTinh.Name = "col_gioiTinh";
            this.col_gioiTinh.Visible = true;
            this.col_gioiTinh.VisibleIndex = 2;
            this.col_gioiTinh.Width = 81;
            // 
            // col_gioiTinh_edit
            // 
            this.col_gioiTinh_edit.AutoHeight = false;
            this.col_gioiTinh_edit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.col_gioiTinh_edit.Name = "col_gioiTinh_edit";
            // 
            // col_ngaySinh
            // 
            this.col_ngaySinh.Caption = "Ngày Sinh";
            this.col_ngaySinh.ColumnEdit = this.col_ngaySinh_edit;
            this.col_ngaySinh.FieldName = "NGAYSINH";
            this.col_ngaySinh.MinWidth = 21;
            this.col_ngaySinh.Name = "col_ngaySinh";
            this.col_ngaySinh.Visible = true;
            this.col_ngaySinh.VisibleIndex = 3;
            this.col_ngaySinh.Width = 81;
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
            // col_diaChi
            // 
            this.col_diaChi.Caption = "Địa Chỉ";
            this.col_diaChi.ColumnEdit = this.col_diaChi_edit;
            this.col_diaChi.FieldName = "DIACHI";
            this.col_diaChi.MinWidth = 21;
            this.col_diaChi.Name = "col_diaChi";
            this.col_diaChi.Visible = true;
            this.col_diaChi.VisibleIndex = 4;
            this.col_diaChi.Width = 81;
            // 
            // col_diaChi_edit
            // 
            this.col_diaChi_edit.AutoHeight = false;
            this.col_diaChi_edit.Name = "col_diaChi_edit";
            // 
            // col_email
            // 
            this.col_email.Caption = "Email";
            this.col_email.ColumnEdit = this.col_email_edit;
            this.col_email.FieldName = "EMAIL";
            this.col_email.MinWidth = 21;
            this.col_email.Name = "col_email";
            this.col_email.Visible = true;
            this.col_email.VisibleIndex = 5;
            this.col_email.Width = 81;
            // 
            // col_email_edit
            // 
            this.col_email_edit.AutoHeight = false;
            this.col_email_edit.Name = "col_email_edit";
            // 
            // frmrpDanhSachLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 414);
            this.Controls.Add(this.gridControlHocSinh);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmrpDanhSachLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách lớp";
            this.Load += new System.EventHandler(this.frmrpDanhSachLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboNamHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDSHS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.LookUpEdit cboNamHoc;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl gridControlHocSinh;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvHocSinh;
        private DevExpress.XtraGrid.Columns.GridColumn col_maHS;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_maHS_edit;
        private DevExpress.XtraGrid.Columns.GridColumn col_hoTen;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_hoTen_edit;
        private DevExpress.XtraGrid.Columns.GridColumn col_gioiTinh;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox col_gioiTinh_edit;
        private DevExpress.XtraGrid.Columns.GridColumn col_ngaySinh;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit col_ngaySinh_edit;
        private DevExpress.XtraGrid.Columns.GridColumn col_diaChi;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_diaChi_edit;
        private DevExpress.XtraGrid.Columns.GridColumn col_email;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_email_edit;
        private System.Windows.Forms.BindingSource bindingSourceDSHS;
        private DevExpress.XtraEditors.LookUpEdit cboHocKy;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.LookUpEdit cboLop;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}