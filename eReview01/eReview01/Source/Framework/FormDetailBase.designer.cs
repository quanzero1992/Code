namespace eReview01.Source.Framework
{
    partial class FormDetailBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetailBase));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.bmBase = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.mnuPrevious = new DevExpress.XtraBars.BarButtonItem();
            this.mnuForward = new DevExpress.XtraBars.BarButtonItem();
            this.mnuNew = new DevExpress.XtraBars.BarButtonItem();
            this.mnuEdit = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSave = new DevExpress.XtraBars.BarButtonItem();
            this.mnuCancel = new DevExpress.XtraBars.BarButtonItem();
            this.mnuDelete = new DevExpress.XtraBars.BarButtonItem();
            this.mnuRefesh = new DevExpress.XtraBars.BarButtonItem();
            this.mnuPrint = new DevExpress.XtraBars.BarButtonItem();
            this.biMonthBarcode = new DevExpress.XtraBars.BarButtonItem();
            this.mnuExit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.cmsBase = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cteNewRow = new System.Windows.Forms.ToolStripMenuItem();
            this.cteDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmBase)).BeginInit();
            this.cmsBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // bmBase
            // 
            this.bmBase.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.bmBase.DockControls.Add(this.barDockControlTop);
            this.bmBase.DockControls.Add(this.barDockControlBottom);
            this.bmBase.DockControls.Add(this.barDockControlLeft);
            this.bmBase.DockControls.Add(this.barDockControlRight);
            this.bmBase.Form = this;
            this.bmBase.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mnuPrevious,
            this.mnuForward,
            this.mnuNew,
            this.mnuEdit,
            this.mnuSave,
            this.mnuCancel,
            this.mnuDelete,
            this.mnuRefesh,
            this.mnuExit,
            this.mnuPrint,
            this.barCheckItem1,
            this.biMonthBarcode});
            this.bmBase.MaxItemId = 21;
            this.bmBase.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bmBase_ItemClick);
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.mnuPrevious, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.mnuForward, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.mnuNew, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.mnuEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.mnuSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.mnuCancel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.mnuDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.mnuRefesh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.mnuPrint, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.biMonthBarcode, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.mnuExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // mnuPrevious
            // 
            this.mnuPrevious.Caption = "Trước";
            this.mnuPrevious.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuPrevious.Glyph")));
            this.mnuPrevious.Hint = "Bản ghi trước";
            this.mnuPrevious.Id = 0;
            this.mnuPrevious.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7);
            this.mnuPrevious.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("mnuPrevious.LargeGlyph")));
            this.mnuPrevious.Name = "mnuPrevious";
            this.mnuPrevious.ShortcutKeyDisplayString = "F7";
            this.mnuPrevious.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            toolTipTitleItem1.Text = "F7";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.mnuPrevious.SuperTip = superToolTip1;
            // 
            // mnuForward
            // 
            this.mnuForward.Caption = "Sau";
            this.mnuForward.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuForward.Glyph")));
            this.mnuForward.Hint = "Bản ghi sau";
            this.mnuForward.Id = 1;
            this.mnuForward.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F8);
            this.mnuForward.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("mnuForward.LargeGlyph")));
            this.mnuForward.Name = "mnuForward";
            this.mnuForward.ShortcutKeyDisplayString = "F8";
            this.mnuForward.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            // 
            // mnuNew
            // 
            this.mnuNew.Caption = "&Thêm";
            this.mnuNew.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuNew.Glyph")));
            this.mnuNew.Hint = "Thêm mới";
            this.mnuNew.Id = 2;
            this.mnuNew.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.mnuNew.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("mnuNew.LargeGlyph")));
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.ShortcutKeyDisplayString = "Ctrl+N";
            this.mnuNew.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            // 
            // mnuEdit
            // 
            this.mnuEdit.Caption = "&Sửa";
            this.mnuEdit.Glyph = global::eReview01.Properties.Resources.editmode;
            this.mnuEdit.Hint = "Sửa";
            this.mnuEdit.Id = 3;
            this.mnuEdit.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.mnuEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("mnuEdit.LargeGlyph")));
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.ShortcutKeyDisplayString = "Ctrl+E";
            this.mnuEdit.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            // 
            // mnuSave
            // 
            this.mnuSave.Caption = "Lưu";
            this.mnuSave.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuSave.Glyph")));
            this.mnuSave.Hint = "Lưu";
            this.mnuSave.Id = 4;
            this.mnuSave.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.mnuSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("mnuSave.LargeGlyph")));
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.ShortcutKeyDisplayString = "Ctrl+S";
            this.mnuSave.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            // 
            // mnuCancel
            // 
            this.mnuCancel.Caption = "Hoãn";
            this.mnuCancel.Glyph = global::eReview01.Properties.Resources.Cancel16;
            this.mnuCancel.Hint = "Hoãn";
            this.mnuCancel.Id = 5;
            this.mnuCancel.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U));
            this.mnuCancel.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("mnuCancel.LargeGlyph")));
            this.mnuCancel.Name = "mnuCancel";
            this.mnuCancel.ShortcutKeyDisplayString = "Ctrl+U";
            this.mnuCancel.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            // 
            // mnuDelete
            // 
            this.mnuDelete.Caption = "Xóa";
            this.mnuDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuDelete.Glyph")));
            this.mnuDelete.Hint = "Xóa";
            this.mnuDelete.Id = 6;
            this.mnuDelete.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D));
            this.mnuDelete.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("mnuDelete.LargeGlyph")));
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.ShortcutKeyDisplayString = "Ctrl+D";
            this.mnuDelete.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            // 
            // mnuRefesh
            // 
            this.mnuRefesh.Caption = "Tải lại";
            this.mnuRefesh.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuRefesh.Glyph")));
            this.mnuRefesh.Hint = "Tải lại dữ liệu";
            this.mnuRefesh.Id = 7;
            this.mnuRefesh.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.mnuRefesh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("mnuRefesh.LargeGlyph")));
            this.mnuRefesh.Name = "mnuRefesh";
            this.mnuRefesh.ShortcutKeyDisplayString = "F5";
            this.mnuRefesh.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            // 
            // mnuPrint
            // 
            this.mnuPrint.Caption = "&In";
            this.mnuPrint.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuPrint.Glyph")));
            this.mnuPrint.Hint = "In chứng từ";
            this.mnuPrint.Id = 18;
            this.mnuPrint.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.mnuPrint.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("mnuPrint.LargeGlyph")));
            this.mnuPrint.Name = "mnuPrint";
            this.mnuPrint.ShortcutKeyDisplayString = "Ctrl+P";
            this.mnuPrint.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            // 
            // biMonthBarcode
            // 
            this.biMonthBarcode.Caption = "In phôi";
            this.biMonthBarcode.Glyph = ((System.Drawing.Image)(resources.GetObject("biMonthBarcode.Glyph")));
            this.biMonthBarcode.Id = 20;
            this.biMonthBarcode.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("biMonthBarcode.LargeGlyph")));
            this.biMonthBarcode.Name = "biMonthBarcode";
            this.biMonthBarcode.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // mnuExit
            // 
            this.mnuExit.Caption = "Đóng";
            this.mnuExit.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuExit.Glyph")));
            this.mnuExit.Hint = "Đóng";
            this.mnuExit.Id = 8;
            this.mnuExit.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4));
            this.mnuExit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("mnuExit.LargeGlyph")));
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeyDisplayString = "Ctrl+F4";
            this.mnuExit.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(723, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 397);
            this.barDockControlBottom.Size = new System.Drawing.Size(723, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 366);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(723, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 366);
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "barCheckItem1";
            this.barCheckItem1.Id = 19;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // cmsBase
            // 
            this.cmsBase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cteNewRow,
            this.cteDelete});
            this.cmsBase.Name = "contextMenuStrip1";
            this.cmsBase.Size = new System.Drawing.Size(186, 48);
            // 
            // cteNewRow
            // 
            this.cteNewRow.Image = global::eReview01.Properties.Resources.ADD1;
            this.cteNewRow.Name = "cteNewRow";
            this.cteNewRow.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Insert)));
            this.cteNewRow.Size = new System.Drawing.Size(185, 22);
            this.cteNewRow.Text = "Thêm dòng";
            this.cteNewRow.Click += new System.EventHandler(this.cteNewRow_Click);
            // 
            // cteDelete
            // 
            this.cteDelete.Image = global::eReview01.Properties.Resources.Delete16;
            this.cteDelete.Name = "cteDelete";
            this.cteDelete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.cteDelete.Size = new System.Drawing.Size(185, 22);
            this.cteDelete.Text = "Xóa dòng";
            this.cteDelete.Click += new System.EventHandler(this.cteDelete_Click);
            // 
            // FormDetailBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(723, 397);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormDetailBase";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDetailBase_FormClosing);
            this.Load += new System.EventHandler(this.FormDetailBase_Load);
            this.Shown += new System.EventHandler(this.FormDetailBase_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmBase)).EndInit();
            this.cmsBase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        public DevExpress.XtraBars.BarManager bmBase;
        public DevExpress.XtraBars.BarButtonItem mnuForward;
        public DevExpress.XtraBars.BarButtonItem mnuNew;
        public DevExpress.XtraBars.BarButtonItem mnuEdit;
        public DevExpress.XtraBars.BarButtonItem mnuSave;
        public DevExpress.XtraBars.BarButtonItem mnuCancel;
        public DevExpress.XtraBars.BarButtonItem mnuDelete;
        public DevExpress.XtraBars.BarButtonItem mnuRefesh;
        public DevExpress.XtraBars.BarButtonItem mnuExit;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraBars.BarButtonItem mnuPrevious;
        public System.Windows.Forms.ContextMenuStrip cmsBase;
        private System.Windows.Forms.ToolStripMenuItem cteDelete;
        public DevExpress.XtraBars.Bar bar1;
        private System.Windows.Forms.ToolStripMenuItem cteNewRow;
        private DevExpress.XtraBars.BarButtonItem mnuPrint;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        public DevExpress.XtraBars.BarButtonItem biMonthBarcode;

    }
}
