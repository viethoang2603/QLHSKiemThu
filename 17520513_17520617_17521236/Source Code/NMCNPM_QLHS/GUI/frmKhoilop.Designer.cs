namespace NMCNPM_QLHS.GUI
{
    partial class frmKhoilop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoilop));
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.BIXoa = new DevExpress.XtraBars.BarButtonItem();
            this.BIThemMoi = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.BILuuDanhSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnXemLop = new DevExpress.XtraBars.BarButtonItem();
            this.bindingSourceKhoiLop = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlKhoiLop = new DevExpress.XtraGrid.GridControl();
            this.dgvKhoiLop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_maKhoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_TenKhoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_tenKhoi_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_SoLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_soLop_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_namHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_namHoc_edit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.col_maKhoi_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bindingNavigatorKhoiLop = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceKhoiLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKhoiLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoiLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_tenKhoi_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_soLop_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_namHoc_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_maKhoi_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorKhoiLop)).BeginInit();
            this.bindingNavigatorKhoiLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraOpenFileDialog1
            // 
            this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
            // 
            // BIXoa
            // 
            this.BIXoa.Caption = "Xóa dòng chọn";
            this.BIXoa.Id = 1;
            this.BIXoa.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.delete;
            this.BIXoa.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.BIXoa.Name = "BIXoa";
            // 
            // BIThemMoi
            // 
            this.BIThemMoi.Caption = "Thêm mới";
            this.BIThemMoi.Id = 0;
            this.BIThemMoi.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.add;
            this.BIThemMoi.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Insert);
            this.BIThemMoi.Name = "BIThemMoi";
            this.BIThemMoi.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 441);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.BIThemMoi,
            this.BIXoa,
            this.BILuuDanhSach,
            this.btnXemLop});
            this.barManager1.MaxItemId = 4;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(758, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 441);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(758, 0);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(758, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 441);
            // 
            // BILuuDanhSach
            // 
            this.BILuuDanhSach.Caption = "Lưu danh sách";
            this.BILuuDanhSach.Id = 2;
            this.BILuuDanhSach.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.save;
            this.BILuuDanhSach.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.BILuuDanhSach.Name = "BILuuDanhSach";
            // 
            // btnXemLop
            // 
            this.btnXemLop.Caption = "Xem lớp";
            this.btnXemLop.Id = 3;
            this.btnXemLop.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.icons8_Search_16px;
            this.btnXemLop.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
            this.btnXemLop.Name = "btnXemLop";
            this.btnXemLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXemLop_ItemClick);
            // 
            // bindingSourceKhoiLop
            // 
            this.bindingSourceKhoiLop.DataSource = typeof(NMCNPM_QLHS.DAL.KHOILOP);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlKhoiLop);
            this.groupControl1.Controls.Add(this.bindingNavigatorKhoiLop);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(758, 441);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Danh sách khối lớp";
            // 
            // gridControlKhoiLop
            // 
            this.gridControlKhoiLop.DataSource = this.bindingSourceKhoiLop;
            this.gridControlKhoiLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlKhoiLop.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlKhoiLop.Location = new System.Drawing.Point(2, 56);
            this.gridControlKhoiLop.MainView = this.dgvKhoiLop;
            this.gridControlKhoiLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlKhoiLop.Name = "gridControlKhoiLop";
            this.gridControlKhoiLop.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.col_maKhoi_edit,
            this.col_tenKhoi_edit,
            this.col_soLop_edit,
            this.col_namHoc_edit});
            this.gridControlKhoiLop.Size = new System.Drawing.Size(754, 383);
            this.gridControlKhoiLop.TabIndex = 4;
            this.gridControlKhoiLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvKhoiLop,
            this.gridView1});
            this.gridControlKhoiLop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridControlKhoiLop_MouseUp);
            // 
            // dgvKhoiLop
            // 
            this.dgvKhoiLop.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_maKhoi,
            this.col_TenKhoi,
            this.col_SoLop,
            this.col_namHoc});
            this.dgvKhoiLop.DetailHeight = 431;
            this.dgvKhoiLop.GridControl = this.gridControlKhoiLop;
            this.dgvKhoiLop.Name = "dgvKhoiLop";
            this.dgvKhoiLop.OptionsBehavior.Editable = false;
            this.dgvKhoiLop.OptionsView.ShowGroupPanel = false;
            this.dgvKhoiLop.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.col_namHoc, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.col_maKhoi, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // col_maKhoi
            // 
            this.col_maKhoi.Caption = "Mã khối";
            this.col_maKhoi.FieldName = "MAKHOI";
            this.col_maKhoi.MinWidth = 23;
            this.col_maKhoi.Name = "col_maKhoi";
            this.col_maKhoi.Visible = true;
            this.col_maKhoi.VisibleIndex = 1;
            this.col_maKhoi.Width = 187;
            // 
            // col_TenKhoi
            // 
            this.col_TenKhoi.Caption = "Khối lớp";
            this.col_TenKhoi.ColumnEdit = this.col_tenKhoi_edit;
            this.col_TenKhoi.FieldName = "TENKHOI";
            this.col_TenKhoi.MinWidth = 23;
            this.col_TenKhoi.Name = "col_TenKhoi";
            this.col_TenKhoi.Visible = true;
            this.col_TenKhoi.VisibleIndex = 2;
            this.col_TenKhoi.Width = 201;
            // 
            // col_tenKhoi_edit
            // 
            this.col_tenKhoi_edit.AutoHeight = false;
            this.col_tenKhoi_edit.Name = "col_tenKhoi_edit";
            // 
            // col_SoLop
            // 
            this.col_SoLop.AppearanceCell.Options.UseTextOptions = true;
            this.col_SoLop.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.col_SoLop.Caption = "Số lớp";
            this.col_SoLop.ColumnEdit = this.col_soLop_edit;
            this.col_SoLop.FieldName = "SOLOP";
            this.col_SoLop.MinWidth = 23;
            this.col_SoLop.Name = "col_SoLop";
            this.col_SoLop.Visible = true;
            this.col_SoLop.VisibleIndex = 3;
            this.col_SoLop.Width = 1022;
            // 
            // col_soLop_edit
            // 
            this.col_soLop_edit.AutoHeight = false;
            this.col_soLop_edit.Name = "col_soLop_edit";
            // 
            // col_namHoc
            // 
            this.col_namHoc.Caption = "Năm học";
            this.col_namHoc.ColumnEdit = this.col_namHoc_edit;
            this.col_namHoc.FieldName = "MANAM";
            this.col_namHoc.MinWidth = 24;
            this.col_namHoc.Name = "col_namHoc";
            this.col_namHoc.Visible = true;
            this.col_namHoc.VisibleIndex = 0;
            this.col_namHoc.Width = 167;
            // 
            // col_namHoc_edit
            // 
            this.col_namHoc_edit.AutoHeight = false;
            this.col_namHoc_edit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.col_namHoc_edit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENNAMHOC", "")});
            this.col_namHoc_edit.DisplayMember = "TENNAMHOC";
            this.col_namHoc_edit.Name = "col_namHoc_edit";
            this.col_namHoc_edit.NullText = "";
            this.col_namHoc_edit.ValueMember = "MANAMHOC";
            // 
            // col_maKhoi_edit
            // 
            this.col_maKhoi_edit.AutoHeight = false;
            this.col_maKhoi_edit.Name = "col_maKhoi_edit";
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gridControlKhoiLop;
            this.gridView1.Name = "gridView1";
            // 
            // bindingNavigatorKhoiLop
            // 
            this.bindingNavigatorKhoiLop.AddNewItem = null;
            this.bindingNavigatorKhoiLop.BindingSource = this.bindingSourceKhoiLop;
            this.bindingNavigatorKhoiLop.CountItem = this.toolStripLabel1;
            this.bindingNavigatorKhoiLop.DeleteItem = null;
            this.bindingNavigatorKhoiLop.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigatorKhoiLop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3});
            this.bindingNavigatorKhoiLop.Location = new System.Drawing.Point(2, 20);
            this.bindingNavigatorKhoiLop.MoveFirstItem = this.toolStripButton1;
            this.bindingNavigatorKhoiLop.MoveLastItem = this.toolStripButton4;
            this.bindingNavigatorKhoiLop.MoveNextItem = this.toolStripButton3;
            this.bindingNavigatorKhoiLop.MovePreviousItem = this.toolStripButton2;
            this.bindingNavigatorKhoiLop.Name = "bindingNavigatorKhoiLop";
            this.bindingNavigatorKhoiLop.PositionItem = this.toolStripTextBox1;
            this.bindingNavigatorKhoiLop.Size = new System.Drawing.Size(754, 31);
            this.bindingNavigatorKhoiLop.TabIndex = 2;
            this.bindingNavigatorKhoiLop.Text = "bindingNavigator2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(45, 28);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton1.Text = "Move first";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton2.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(58, 27);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton3.Text = "Move next";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton4.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXemLop)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // frmKhoilop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 441);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKhoilop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khối lớp";
            this.Load += new System.EventHandler(this.frmKhoilop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceKhoiLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKhoiLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoiLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_tenKhoi_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_soLop_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_namHoc_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_maKhoi_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorKhoiLop)).EndInit();
            this.bindingNavigatorKhoiLop.ResumeLayout(false);
            this.bindingNavigatorKhoiLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
        private DevExpress.XtraBars.BarButtonItem BIXoa;
        private DevExpress.XtraBars.BarButtonItem BIThemMoi;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraBars.BarButtonItem BILuuDanhSach;
        private DevExpress.XtraGrid.GridControl gridControlKhoiLop;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvKhoiLop;
        private DevExpress.XtraGrid.Columns.GridColumn col_maKhoi;
        private DevExpress.XtraGrid.Columns.GridColumn col_TenKhoi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col_SoLop;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_maKhoi_edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_tenKhoi_edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_soLop_edit;
        private System.Windows.Forms.BindingSource bindingSourceKhoiLop;
        private DevExpress.XtraGrid.Columns.GridColumn col_namHoc;
        private System.Windows.Forms.BindingNavigator bindingNavigatorKhoiLop;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit col_namHoc_edit;
        private DevExpress.XtraBars.BarButtonItem btnXemLop;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
    }
}