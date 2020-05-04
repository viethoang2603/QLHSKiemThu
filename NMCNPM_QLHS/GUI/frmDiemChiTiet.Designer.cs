namespace NMCNPM_QLHS.GUI
{
    partial class frmDiemChiTiet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiemChiTiet));
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager();
            this.groupControlDiemCT = new DevExpress.XtraEditors.GroupControl();
            this.gridControlHocSinh = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceDiemChiTiet = new System.Windows.Forms.BindingSource();
            this.dgvDiem = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridColumnMonHoc = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumnDiemMieng = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumnDiem15Phut = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumnDiem1Tiet = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumnDiemThi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumnDiemTB = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cboNamHoc = new DevExpress.XtraEditors.LookUpEdit();
            this.cboHocSinh = new DevExpress.XtraEditors.LookUpEdit();
            this.cboHocKy = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDiemCT)).BeginInit();
            this.groupControlDiemCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDiemChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboNamHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboHocSinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl"});
            // 
            // groupControlDiemCT
            // 
            this.groupControlDiemCT.Controls.Add(this.gridControlHocSinh);
            this.groupControlDiemCT.Controls.Add(this.layoutControl1);
            this.groupControlDiemCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlDiemCT.Location = new System.Drawing.Point(0, 0);
            this.groupControlDiemCT.Name = "groupControlDiemCT";
            this.groupControlDiemCT.Size = new System.Drawing.Size(886, 511);
            this.groupControlDiemCT.TabIndex = 2;
            this.groupControlDiemCT.Text = "Thông tin điểm chi tiết";
            // 
            // gridControlHocSinh
            // 
            this.gridControlHocSinh.DataSource = this.bindingSourceDiemChiTiet;
            this.gridControlHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlHocSinh.Location = new System.Drawing.Point(2, 131);
            this.gridControlHocSinh.MainView = this.dgvDiem;
            this.gridControlHocSinh.Name = "gridControlHocSinh";
            this.gridControlHocSinh.Size = new System.Drawing.Size(882, 378);
            this.gridControlHocSinh.TabIndex = 4;
            this.gridControlHocSinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvDiem,
            this.gridView1});
            // 
            // bindingSourceDiemChiTiet
            // 
            this.bindingSourceDiemChiTiet.DataSource = typeof(NMCNPM_QLHS.DAL.sp_LayDiemChiTietHocSinhResult);
            // 
            // dgvDiem
            // 
            this.dgvDiem.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.dgvDiem.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.gridColumnMonHoc,
            this.gridColumnDiemMieng,
            this.gridColumnDiem15Phut,
            this.gridColumnDiem1Tiet,
            this.gridColumnDiemThi,
            this.gridColumnDiemTB});
            this.dgvDiem.GridControl = this.gridControlHocSinh;
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.OptionsBehavior.Editable = false;
            this.dgvDiem.OptionsView.ShowGroupPanel = false;
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBand1.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridBand1.AppearanceHeader.Options.UseFont = true;
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.Caption = "Bảng điểm chi tiết";
            this.gridBand1.Columns.Add(this.gridColumnMonHoc);
            this.gridBand1.Columns.Add(this.gridColumnDiemMieng);
            this.gridBand1.Columns.Add(this.gridColumnDiem15Phut);
            this.gridBand1.Columns.Add(this.gridColumnDiem1Tiet);
            this.gridBand1.Columns.Add(this.gridColumnDiemThi);
            this.gridBand1.Columns.Add(this.gridColumnDiemTB);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.RowCount = 2;
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 866;
            // 
            // gridColumnMonHoc
            // 
            this.gridColumnMonHoc.Caption = "Môn học";
            this.gridColumnMonHoc.FieldName = "TENMONHOC";
            this.gridColumnMonHoc.Name = "gridColumnMonHoc";
            this.gridColumnMonHoc.Visible = true;
            this.gridColumnMonHoc.Width = 155;
            // 
            // gridColumnDiemMieng
            // 
            this.gridColumnDiemMieng.Caption = "Điểm miệng";
            this.gridColumnDiemMieng.FieldName = "DIEMMIENG";
            this.gridColumnDiemMieng.Name = "gridColumnDiemMieng";
            this.gridColumnDiemMieng.Visible = true;
            this.gridColumnDiemMieng.Width = 135;
            // 
            // gridColumnDiem15Phut
            // 
            this.gridColumnDiem15Phut.Caption = "Điểm 15 phút";
            this.gridColumnDiem15Phut.FieldName = "DIEM15P";
            this.gridColumnDiem15Phut.Name = "gridColumnDiem15Phut";
            this.gridColumnDiem15Phut.Visible = true;
            this.gridColumnDiem15Phut.Width = 144;
            // 
            // gridColumnDiem1Tiet
            // 
            this.gridColumnDiem1Tiet.Caption = "Điểm 1 tiết";
            this.gridColumnDiem1Tiet.FieldName = "DIEM1TIET";
            this.gridColumnDiem1Tiet.Name = "gridColumnDiem1Tiet";
            this.gridColumnDiem1Tiet.Visible = true;
            this.gridColumnDiem1Tiet.Width = 137;
            // 
            // gridColumnDiemThi
            // 
            this.gridColumnDiemThi.Caption = "Điểm thi";
            this.gridColumnDiemThi.FieldName = "DIEMTHI";
            this.gridColumnDiemThi.Name = "gridColumnDiemThi";
            this.gridColumnDiemThi.Visible = true;
            this.gridColumnDiemThi.Width = 160;
            // 
            // gridColumnDiemTB
            // 
            this.gridColumnDiemTB.Caption = "Điểm trung bình";
            this.gridColumnDiemTB.FieldName = "DIEMTBHK";
            this.gridColumnDiemTB.Name = "gridColumnDiemTB";
            this.gridColumnDiemTB.Visible = true;
            this.gridColumnDiemTB.Width = 135;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlHocSinh;
            this.gridView1.Name = "gridView1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cboNamHoc);
            this.layoutControl1.Controls.Add(this.cboHocSinh);
            this.layoutControl1.Controls.Add(this.cboHocKy);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(2, 20);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(882, 111);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.Location = new System.Drawing.Point(486, 42);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNamHoc.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENNAMHOC", "")});
            this.cboNamHoc.Properties.NullText = "";
            this.cboNamHoc.Size = new System.Drawing.Size(372, 20);
            this.cboNamHoc.StyleController = this.layoutControl1;
            this.cboNamHoc.TabIndex = 2;
            this.cboNamHoc.EditValueChanged += new System.EventHandler(this.cboNamHoc_EditValueChanged);
            // 
            // cboHocSinh
            // 
            this.cboHocSinh.Location = new System.Drawing.Point(72, 42);
            this.cboHocSinh.Name = "cboHocSinh";
            this.cboHocSinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboHocSinh.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MAHS", "Mã học sinh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HOTEN", "Họ tên")});
            this.cboHocSinh.Properties.NullText = "";
            this.cboHocSinh.Size = new System.Drawing.Size(362, 20);
            this.cboHocSinh.StyleController = this.layoutControl1;
            this.cboHocSinh.TabIndex = 1;
            this.cboHocSinh.EditValueChanged += new System.EventHandler(this.cboHocSinh_EditValueChanged);
            // 
            // cboHocKy
            // 
            this.cboHocKy.Location = new System.Drawing.Point(486, 66);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboHocKy.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENHOCKY", "")});
            this.cboHocKy.Properties.NullText = "";
            this.cboHocKy.Size = new System.Drawing.Size(372, 20);
            this.cboHocKy.StyleController = this.layoutControl1;
            this.cboHocKy.TabIndex = 3;
            this.cboHocKy.EditValueChanged += new System.EventHandler(this.cboHocKy_EditValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(882, 111);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.layoutControlItem3,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(862, 91);
            this.layoutControlGroup1.Text = "Thông tin:";
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.cboHocSinh;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(414, 49);
            this.layoutControlItem7.Text = "Học sinh";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(45, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cboHocKy;
            this.layoutControlItem3.CustomizationFormText = "Học kỳ:";
            this.layoutControlItem3.Location = new System.Drawing.Point(414, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(424, 25);
            this.layoutControlItem3.Text = "Học kỳ:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(45, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cboNamHoc;
            this.layoutControlItem1.Location = new System.Drawing.Point(414, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(424, 24);
            this.layoutControlItem1.Text = "Năm học:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(45, 13);
            // 
            // frmDiemChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 511);
            this.Controls.Add(this.groupControlDiemCT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDiemChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điểm chi tiết";
            this.Load += new System.EventHandler(this.frmNhapDiemChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDiemCT)).EndInit();
            this.groupControlDiemCT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDiemChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboNamHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboHocSinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraEditors.GroupControl groupControlDiemCT;
        private DevExpress.XtraGrid.GridControl gridControlHocSinh;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView dgvDiem;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumnMonHoc;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumnDiemMieng;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumnDiem15Phut;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumnDiem1Tiet;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumnDiemThi;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumnDiemTB;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.BindingSource bindingSourceDiemChiTiet;
        private DevExpress.XtraEditors.LookUpEdit cboHocSinh;
        private DevExpress.XtraEditors.LookUpEdit cboNamHoc;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.LookUpEdit cboHocKy;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}