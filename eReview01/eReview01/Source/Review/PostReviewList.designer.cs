namespace eReview01.Source.Review
{
    partial class PostReviewList
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostReviewList));
            this.dsReview = new eReview01.Entities.DatasetReview();
            this.bsReview = new System.Windows.Forms.BindingSource();
            this.gcReview = new eReview01.CDControl.CDGrid();
            this.gvReview = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIndex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANS_TC_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rileTCType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsTC_TYPE = new System.Windows.Forms.BindingSource();
            this.colTRANS_BARCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANS_BEGIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLANE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANS_VEH_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rileVEH_TYPE = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsVEH_TYPE = new System.Windows.Forms.BindingSource();
            this.colTRANS_FEE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANS_VEH_NUMBER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSERNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rigleUser = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.bsUSER_INFO = new System.Windows.Forms.BindingSource();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rileShiftType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsShiftType = new System.Windows.Forms.BindingSource();
            this.colTRANS_END = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rileErrorType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsErrorType = new System.Windows.Forms.BindingSource();
            this.mDevXGroupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbl_Note = new DevExpress.XtraEditors.LabelControl();
            this.checkEditSuspect = new DevExpress.XtraEditors.CheckEdit();
            this.errorTcType = new eReview01.CDControl.CDLookUpEnum();
            this.mDevXLabel2 = new eReview01.CDControl.CDLabel();
            this.glueUser = new eReview01.CDControl.CDGridLookUpEdit();
            this.bsUserTicket = new System.Windows.Forms.BindingSource();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUSER_INFO_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_INFO_FULL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateRangeSimple1 = new eReview01.Source.DateRangeSimple();
            this.mDevXLabel5 = new eReview01.CDControl.CDLabel();
            this.lueTcType = new eReview01.CDControl.CDLookUpEnum();
            this.lueTicketType = new eReview01.CDControl.CDLookUpEnum();
            this.bsTICKET_TYPE = new System.Windows.Forms.BindingSource();
            this.lueVehType = new eReview01.CDControl.CDLookUpEnum();
            this.lueLane = new eReview01.CDControl.CDLookUpEnum();
            this.bsLaneInfo = new System.Windows.Forms.BindingSource();
            this.mDevXLabel7 = new eReview01.CDControl.CDLabel();
            this.mDevXLabel1 = new eReview01.CDControl.CDLabel();
            this.btnExport = new eReview01.CDControl.CDButton();
            this.mDevXLabel6 = new eReview01.CDControl.CDLabel();
            this.btnSearch = new eReview01.CDControl.CDButton();
            this.mDevXLabel4 = new eReview01.CDControl.CDLabel();
            this.mDevXLabel3 = new eReview01.CDControl.CDLabel();
            this.txtVehNumber = new eReview01.CDControl.CDTextEdit();
            this.colUSER_INFO_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsLANE_TYPE = new System.Windows.Forms.BindingSource();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lblVehNumber = new eReview01.CDControl.CDLabel();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lblPassCount = new eReview01.CDControl.CDLabel();
            this.lblTransFee = new eReview01.CDControl.CDLabel();
            this.lblVehType = new eReview01.CDControl.CDLabel();
            this.lblTicketType = new eReview01.CDControl.CDLabel();
            this.lblTransBegin = new eReview01.CDControl.CDLabel();
            this.btnUpdateVehNumber = new eReview01.CDControl.CDButton();
            this.lblUser = new eReview01.CDControl.CDLabel();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtUpdateVehNumber = new eReview01.CDControl.CDTextEdit();
            this.labelControl27 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblVehicleHistory = new eReview01.CDControl.CDLabel();
            this.lblVehRegAddress = new eReview01.CDControl.CDLabel();
            this.lblVehRegWeight = new eReview01.CDControl.CDLabel();
            this.lblVehRegType = new eReview01.CDControl.CDLabel();
            this.lblVehRegSeat = new eReview01.CDControl.CDLabel();
            this.lblVehRegDate = new eReview01.CDControl.CDLabel();
            this.lblVehRegOwn = new eReview01.CDControl.CDLabel();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.label111 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.pePhoto = new DevExpress.XtraEditors.PictureEdit();
            this.peZoomPhoto = new DevExpress.XtraEditors.PictureEdit();
            this.pePlayVideo = new DevExpress.XtraEditors.PictureEdit();
            this.timer1 = new System.Windows.Forms.Timer();
            this.bsTicketBill = new System.Windows.Forms.BindingSource();
            this.mc_Image = new System.Windows.Forms.ContextMenuStrip();
            this.lưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.inToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inMànHìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dsReview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcReview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rileTCType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTC_TYPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rileVEH_TYPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVEH_TYPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rigleUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUSER_INFO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rileShiftType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsShiftType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rileErrorType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsErrorType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDevXGroupControl1)).BeginInit();
            this.mDevXGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditSuspect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTcType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glueUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUserTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTcType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTicketType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTICKET_TYPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueVehType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLane.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLaneInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVehNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLANE_TYPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateVehNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pePhoto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peZoomPhoto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pePlayVideo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTicketBill)).BeginInit();
            this.mc_Image.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsReview
            // 
            this.dsReview.DataSetName = "DataSetReview";
            this.dsReview.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsReview
            // 
            this.bsReview.DataMember = "tc_transaction";
            this.bsReview.DataSource = this.dsReview;
            this.bsReview.Sort = "TRANS_BEGIN DESC";
            // 
            // gcReview
            // 
            this.gcReview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcReview.AutoGetData = false;
            this.gcReview.BindingType = eReview01.CommonUI.Enumeration.EnumBindingType.None;
            this.gcReview.DataSource = this.bsReview;
            this.gcReview.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gcReview.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcReview.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gcReview.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcReview.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gcReview.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcReview.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gcReview.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcReview.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gcReview.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcReview.EmbeddedNavigator.TextStringFormat = "Dòng {0} of {1}";
            gridLevelNode1.RelationName = "Level1";
            gridLevelNode2.RelationName = "Level2";
            this.gcReview.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.gcReview.Location = new System.Drawing.Point(8, 128);
            this.gcReview.MainView = this.gvReview;
            this.gcReview.Name = "gcReview";
            this.gcReview.OrderBy = null;
            this.gcReview.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rileVEH_TYPE,
            this.rileTCType,
            this.rigleUser,
            this.rileShiftType,
            this.rileErrorType});
            this.gcReview.Size = new System.Drawing.Size(1108, 408);
            this.gcReview.TabIndex = 3;
            this.gcReview.TableNameEnum = eReview01.CommonUI.Enumeration.EnumTableName.None;
            this.gcReview.UseEmbeddedNavigator = true;
            this.gcReview.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvReview});
            this.gcReview.WhereCause = null;
            this.gcReview.Click += new System.EventHandler(this.gcReview_Click);
            // 
            // gvReview
            // 
            this.gvReview.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIndex,
            this.colTRANS_TC_TYPE,
            this.colTRANS_BARCODE,
            this.colTRANS_BEGIN,
            this.colLANE,
            this.colTRANS_VEH_TYPE,
            this.colTRANS_FEE,
            this.colTRANS_VEH_NUMBER,
            this.colUSERNAME,
            this.gridColumn10,
            this.colTRANS_END,
            this.gridColumn8,
            this.gridColumn9});
            this.gvReview.GridControl = this.gcReview;
            this.gvReview.GroupPanelText = "Kéo cột vào tiêu đề để nhóm";
            this.gvReview.Name = "gvReview";
            this.gvReview.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvReview.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvReview.OptionsBehavior.Editable = false;
            this.gvReview.OptionsCustomization.AllowFilter = false;
            this.gvReview.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gvReview.OptionsFilter.AllowMRUFilterList = false;
            this.gvReview.OptionsFilter.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.TextAndVisual;
            this.gvReview.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvReview.OptionsSelection.MultiSelect = true;
            this.gvReview.OptionsView.RowAutoHeight = true;
            this.gvReview.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvReview.OptionsView.ShowFooter = true;
            this.gvReview.ViewCaption = "Danh sách giao dịch";
            this.gvReview.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvReview_FocusedRowChanged);
            this.gvReview.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvReview_CustomColumnDisplayText);
            // 
            // colIndex
            // 
            this.colIndex.AppearanceCell.Options.UseTextOptions = true;
            this.colIndex.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIndex.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colIndex.AppearanceHeader.Options.UseTextOptions = true;
            this.colIndex.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIndex.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colIndex.Caption = "STT";
            this.colIndex.FieldName = "RowIndex";
            this.colIndex.Name = "colIndex";
            this.colIndex.Visible = true;
            this.colIndex.VisibleIndex = 0;
            this.colIndex.Width = 30;
            // 
            // colTRANS_TC_TYPE
            // 
            this.colTRANS_TC_TYPE.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRANS_TC_TYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRANS_TC_TYPE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANS_TC_TYPE.Caption = "Kiểu thu phí";
            this.colTRANS_TC_TYPE.ColumnEdit = this.rileTCType;
            this.colTRANS_TC_TYPE.FieldName = "TRANS_TC_TYPE";
            this.colTRANS_TC_TYPE.Name = "colTRANS_TC_TYPE";
            this.colTRANS_TC_TYPE.Visible = true;
            this.colTRANS_TC_TYPE.VisibleIndex = 7;
            // 
            // rileTCType
            // 
            this.rileTCType.AutoHeight = false;
            this.rileTCType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rileTCType.DataSource = this.bsTC_TYPE;
            this.rileTCType.DisplayMember = "TC_TYPE_NAME";
            this.rileTCType.Name = "rileTCType";
            this.rileTCType.ValueMember = "TC_TYPE_ID";
            // 
            // bsTC_TYPE
            // 
            this.bsTC_TYPE.DataMember = "tc_type";
            this.bsTC_TYPE.DataSource = this.dsReview;
            // 
            // colTRANS_BARCODE
            // 
            this.colTRANS_BARCODE.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRANS_BARCODE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRANS_BARCODE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANS_BARCODE.Caption = "Seri vé";
            this.colTRANS_BARCODE.FieldName = "TRANS_BARCODE";
            this.colTRANS_BARCODE.Name = "colTRANS_BARCODE";
            this.colTRANS_BARCODE.Visible = true;
            this.colTRANS_BARCODE.VisibleIndex = 1;
            this.colTRANS_BARCODE.Width = 83;
            // 
            // colTRANS_BEGIN
            // 
            this.colTRANS_BEGIN.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRANS_BEGIN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRANS_BEGIN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANS_BEGIN.Caption = "Giờ xe vào";
            this.colTRANS_BEGIN.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colTRANS_BEGIN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTRANS_BEGIN.FieldName = "TRANS_BEGIN";
            this.colTRANS_BEGIN.Name = "colTRANS_BEGIN";
            this.colTRANS_BEGIN.Visible = true;
            this.colTRANS_BEGIN.VisibleIndex = 2;
            this.colTRANS_BEGIN.Width = 107;
            // 
            // colLANE
            // 
            this.colLANE.AppearanceHeader.Options.UseTextOptions = true;
            this.colLANE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLANE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colLANE.Caption = "Làn";
            this.colLANE.FieldName = "LANE_INFO_ID";
            this.colLANE.Name = "colLANE";
            this.colLANE.Visible = true;
            this.colLANE.VisibleIndex = 5;
            this.colLANE.Width = 41;
            // 
            // colTRANS_VEH_TYPE
            // 
            this.colTRANS_VEH_TYPE.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRANS_VEH_TYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRANS_VEH_TYPE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANS_VEH_TYPE.Caption = "Loại xe";
            this.colTRANS_VEH_TYPE.ColumnEdit = this.rileVEH_TYPE;
            this.colTRANS_VEH_TYPE.FieldName = "TRANS_VEH_TYPE";
            this.colTRANS_VEH_TYPE.Name = "colTRANS_VEH_TYPE";
            this.colTRANS_VEH_TYPE.Visible = true;
            this.colTRANS_VEH_TYPE.VisibleIndex = 4;
            this.colTRANS_VEH_TYPE.Width = 70;
            // 
            // rileVEH_TYPE
            // 
            this.rileVEH_TYPE.AutoHeight = false;
            this.rileVEH_TYPE.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rileVEH_TYPE.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VEH_TYPE_NAME", "Loại xe"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VEH_TYPE_DESC", "Chú thích")});
            this.rileVEH_TYPE.DataSource = this.bsVEH_TYPE;
            this.rileVEH_TYPE.DisplayMember = "VEH_TYPE_NAME";
            this.rileVEH_TYPE.Name = "rileVEH_TYPE";
            this.rileVEH_TYPE.NullText = "";
            this.rileVEH_TYPE.ValueMember = "VEH_TYPE_ID";
            // 
            // bsVEH_TYPE
            // 
            this.bsVEH_TYPE.DataMember = "vehicle_type";
            this.bsVEH_TYPE.DataSource = this.dsReview;
            // 
            // colTRANS_FEE
            // 
            this.colTRANS_FEE.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRANS_FEE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRANS_FEE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANS_FEE.Caption = "Giá vé";
            this.colTRANS_FEE.DisplayFormat.FormatString = "###,###";
            this.colTRANS_FEE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTRANS_FEE.FieldName = "TRANS_FEE";
            this.colTRANS_FEE.Name = "colTRANS_FEE";
            this.colTRANS_FEE.Visible = true;
            this.colTRANS_FEE.VisibleIndex = 8;
            this.colTRANS_FEE.Width = 62;
            // 
            // colTRANS_VEH_NUMBER
            // 
            this.colTRANS_VEH_NUMBER.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRANS_VEH_NUMBER.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRANS_VEH_NUMBER.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANS_VEH_NUMBER.Caption = "Biển số";
            this.colTRANS_VEH_NUMBER.FieldName = "TRANS_VEH_NUMBER";
            this.colTRANS_VEH_NUMBER.Name = "colTRANS_VEH_NUMBER";
            this.colTRANS_VEH_NUMBER.Visible = true;
            this.colTRANS_VEH_NUMBER.VisibleIndex = 6;
            this.colTRANS_VEH_NUMBER.Width = 64;
            // 
            // colUSERNAME
            // 
            this.colUSERNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colUSERNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUSERNAME.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUSERNAME.Caption = "Thu phí viên";
            this.colUSERNAME.ColumnEdit = this.rigleUser;
            this.colUSERNAME.FieldName = "USER_INFO_ID";
            this.colUSERNAME.Name = "colUSERNAME";
            this.colUSERNAME.Visible = true;
            this.colUSERNAME.VisibleIndex = 9;
            this.colUSERNAME.Width = 100;
            // 
            // rigleUser
            // 
            this.rigleUser.AutoHeight = false;
            this.rigleUser.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rigleUser.DataSource = this.bsUSER_INFO;
            this.rigleUser.DisplayMember = "USER_INFO_FULL";
            this.rigleUser.Name = "rigleUser";
            this.rigleUser.NullText = "";
            this.rigleUser.ValueMember = "USER_INFO_ID";
            this.rigleUser.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // bsUSER_INFO
            // 
            this.bsUSER_INFO.DataMember = "user_info";
            this.bsUSER_INFO.DataSource = this.dsReview;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn10
            // 
            this.gridColumn10.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn10.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn10.Caption = "Ca";
            this.gridColumn10.ColumnEdit = this.rileShiftType;
            this.gridColumn10.FieldName = "SHIFT_TYPE_ID";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 10;
            this.gridColumn10.Width = 42;
            // 
            // rileShiftType
            // 
            this.rileShiftType.AutoHeight = false;
            this.rileShiftType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rileShiftType.DataSource = this.bsShiftType;
            this.rileShiftType.DisplayMember = "SHI_TYPE_NAME";
            this.rileShiftType.Name = "rileShiftType";
            this.rileShiftType.NullText = "";
            this.rileShiftType.ValueMember = "SHI_TYPE_ID";
            // 
            // bsShiftType
            // 
            this.bsShiftType.DataMember = "shift_type";
            this.bsShiftType.DataSource = this.dsReview;
            // 
            // colTRANS_END
            // 
            this.colTRANS_END.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRANS_END.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRANS_END.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTRANS_END.Caption = "Giờ xe ra";
            this.colTRANS_END.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colTRANS_END.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTRANS_END.FieldName = "TRANS_END";
            this.colTRANS_END.Name = "colTRANS_END";
            this.colTRANS_END.Visible = true;
            this.colTRANS_END.VisibleIndex = 3;
            this.colTRANS_END.Width = 102;
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn8.Caption = "Giám sát viên";
            this.gridColumn8.ColumnEdit = this.rigleUser;
            this.gridColumn8.FieldName = "MNR_USER_ID";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 11;
            this.gridColumn8.Width = 91;
            // 
            // gridColumn9
            // 
            this.gridColumn9.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn9.Caption = "Phân loại lỗi";
            this.gridColumn9.ColumnEdit = this.rileErrorType;
            this.gridColumn9.FieldName = "ERR_TYPE_ID";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 12;
            this.gridColumn9.Width = 107;
            // 
            // rileErrorType
            // 
            this.rileErrorType.AutoHeight = false;
            this.rileErrorType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rileErrorType.DataSource = this.bsErrorType;
            this.rileErrorType.DisplayMember = "ERR_TYPE_NAME";
            this.rileErrorType.Name = "rileErrorType";
            this.rileErrorType.NullText = "";
            this.rileErrorType.ValueMember = "ERR_TYPE_ID";
            // 
            // bsErrorType
            // 
            this.bsErrorType.DataMember = "error_type";
            this.bsErrorType.DataSource = this.dsReview;
            // 
            // mDevXGroupControl1
            // 
            this.mDevXGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mDevXGroupControl1.Controls.Add(this.lbl_Note);
            this.mDevXGroupControl1.Controls.Add(this.checkEditSuspect);
            this.mDevXGroupControl1.Controls.Add(this.errorTcType);
            this.mDevXGroupControl1.Controls.Add(this.mDevXLabel2);
            this.mDevXGroupControl1.Controls.Add(this.glueUser);
            this.mDevXGroupControl1.Controls.Add(this.dateRangeSimple1);
            this.mDevXGroupControl1.Controls.Add(this.mDevXLabel5);
            this.mDevXGroupControl1.Controls.Add(this.lueTcType);
            this.mDevXGroupControl1.Controls.Add(this.lueTicketType);
            this.mDevXGroupControl1.Controls.Add(this.lueVehType);
            this.mDevXGroupControl1.Controls.Add(this.lueLane);
            this.mDevXGroupControl1.Controls.Add(this.mDevXLabel7);
            this.mDevXGroupControl1.Controls.Add(this.mDevXLabel1);
            this.mDevXGroupControl1.Controls.Add(this.btnExport);
            this.mDevXGroupControl1.Controls.Add(this.mDevXLabel6);
            this.mDevXGroupControl1.Controls.Add(this.btnSearch);
            this.mDevXGroupControl1.Controls.Add(this.mDevXLabel4);
            this.mDevXGroupControl1.Controls.Add(this.mDevXLabel3);
            this.mDevXGroupControl1.Controls.Add(this.txtVehNumber);
            this.mDevXGroupControl1.Location = new System.Drawing.Point(8, 32);
            this.mDevXGroupControl1.Name = "mDevXGroupControl1";
            this.mDevXGroupControl1.ShowCaption = false;
            this.mDevXGroupControl1.Size = new System.Drawing.Size(1108, 88);
            this.mDevXGroupControl1.TabIndex = 2;
            this.mDevXGroupControl1.Text = "Lọc thông tin hậu kiểm";
            // 
            // lbl_Note
            // 
            this.lbl_Note.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Note.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Note.Location = new System.Drawing.Point(480, 61);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(74, 13);
            this.lbl_Note.TabIndex = 16;
            this.lbl_Note.Text = "Vé tháng quý";
            this.lbl_Note.Visible = false;
            // 
            // checkEditSuspect
            // 
            this.checkEditSuspect.Location = new System.Drawing.Point(286, 58);
            this.checkEditSuspect.Name = "checkEditSuspect";
            this.checkEditSuspect.Properties.Caption = "&Nghi ngờ";
            this.checkEditSuspect.Size = new System.Drawing.Size(75, 19);
            this.checkEditSuspect.TabIndex = 14;
            // 
            // errorTcType
            // 
            this.errorTcType.AutoGetData = false;
            this.errorTcType.EnumString = eReview01.CommonUI.Enumeration.EnumType.None;
            this.errorTcType.HasSelectAllItem = true;
            this.errorTcType.Location = new System.Drawing.Point(856, 32);
            this.errorTcType.Name = "errorTcType";
            this.errorTcType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.errorTcType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", "Delete", null, true)});
            this.errorTcType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ERR_TYPE_NAME", "Loại lỗi", 5, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.errorTcType.Properties.DataSource = this.bsErrorType;
            this.errorTcType.Properties.DisplayMember = "ERR_TYPE_NAME";
            this.errorTcType.Properties.NullText = "<<Tất cả>>";
            this.errorTcType.Properties.ShowFooter = false;
            this.errorTcType.Properties.ShowHeader = false;
            this.errorTcType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.errorTcType.Properties.ValueMember = "ERR_TYPE_ID";
            this.errorTcType.Size = new System.Drawing.Size(184, 20);
            this.errorTcType.TabIndex = 2;
            // 
            // mDevXLabel2
            // 
            this.mDevXLabel2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.mDevXLabel2.Location = new System.Drawing.Point(792, 31);
            this.mDevXLabel2.Name = "mDevXLabel2";
            this.mDevXLabel2.Size = new System.Drawing.Size(64, 21);
            this.mDevXLabel2.TabIndex = 13;
            this.mDevXLabel2.Text = "Kiểu &Lỗi";
            // 
            // glueUser
            // 
            this.glueUser.AutoGetData = false;
            this.glueUser.BindingType = eReview01.CommonUI.Enumeration.EnumBindingType.None;
            this.glueUser.HasSelectAllItem = false;
            this.glueUser.Location = new System.Drawing.Point(544, 32);
            this.glueUser.Name = "glueUser";
            this.glueUser.OrderBy = null;
            this.glueUser.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.glueUser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.glueUser.Properties.DataSource = this.bsUserTicket;
            this.glueUser.Properties.DisplayMember = "USER_INFO_FULL";
            this.glueUser.Properties.NullText = "<<Tất cả>>";
            this.glueUser.Properties.ShowFooter = false;
            this.glueUser.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.glueUser.Properties.ValueMember = "USER_INFO_ID";
            this.glueUser.Properties.View = this.gridView2;
            this.glueUser.Size = new System.Drawing.Size(232, 20);
            this.glueUser.TabIndex = 10;
            this.glueUser.TableNameEnum = eReview01.CommonUI.Enumeration.EnumTableName.None;
            this.glueUser.WhereCause = null;
            // 
            // bsUserTicket
            // 
            this.bsUserTicket.DataMember = "user_info";
            this.bsUserTicket.DataSource = this.dsReview;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUSER_INFO_ID1,
            this.colUSER_INFO_FULL});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colUSER_INFO_ID1
            // 
            this.colUSER_INFO_ID1.Caption = "Mã nhân viên";
            this.colUSER_INFO_ID1.FieldName = "USER_INFO_ID";
            this.colUSER_INFO_ID1.Name = "colUSER_INFO_ID1";
            this.colUSER_INFO_ID1.Visible = true;
            this.colUSER_INFO_ID1.VisibleIndex = 0;
            // 
            // colUSER_INFO_FULL
            // 
            this.colUSER_INFO_FULL.Caption = "Họ và tên";
            this.colUSER_INFO_FULL.FieldName = "USER_INFO_FULL";
            this.colUSER_INFO_FULL.Name = "colUSER_INFO_FULL";
            this.colUSER_INFO_FULL.Visible = true;
            this.colUSER_INFO_FULL.VisibleIndex = 1;
            // 
            // dateRangeSimple1
            // 
            this.dateRangeSimple1.DateFormat = "dd/MM/yyyy";
            this.dateRangeSimple1.FromDate = new System.DateTime(((long)(0)));
            this.dateRangeSimple1.Location = new System.Drawing.Point(8, 8);
            this.dateRangeSimple1.Name = "dateRangeSimple1";
            this.dateRangeSimple1.Size = new System.Drawing.Size(458, 24);
            this.dateRangeSimple1.TabIndex = 0;
            this.dateRangeSimple1.TimeFormat = "HH:mm:ss";
            this.dateRangeSimple1.ToDate = new System.DateTime(((long)(0)));
            // 
            // mDevXLabel5
            // 
            this.mDevXLabel5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.mDevXLabel5.Location = new System.Drawing.Point(480, 32);
            this.mDevXLabel5.Name = "mDevXLabel5";
            this.mDevXLabel5.Size = new System.Drawing.Size(64, 21);
            this.mDevXLabel5.TabIndex = 9;
            this.mDevXLabel5.Text = "&Thu phí viên";
            // 
            // lueTcType
            // 
            this.lueTcType.AutoGetData = false;
            this.lueTcType.EnumString = eReview01.CommonUI.Enumeration.EnumType.None;
            this.lueTcType.HasSelectAllItem = true;
            this.lueTcType.Location = new System.Drawing.Point(856, 8);
            this.lueTcType.Name = "lueTcType";
            this.lueTcType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lueTcType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "", "Delete", null, true)});
            this.lueTcType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TC_TYPE_NAME", "Loại thu phí")});
            this.lueTcType.Properties.DataSource = this.bsTC_TYPE;
            this.lueTcType.Properties.DisplayMember = "TC_TYPE_NAME";
            this.lueTcType.Properties.NullText = "<<Tất cả>>";
            this.lueTcType.Properties.ShowFooter = false;
            this.lueTcType.Properties.ShowHeader = false;
            this.lueTcType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueTcType.Properties.ValueMember = "TC_TYPE_ID";
            this.lueTcType.Size = new System.Drawing.Size(184, 20);
            this.lueTcType.TabIndex = 2;
            // 
            // lueTicketType
            // 
            this.lueTicketType.AutoGetData = false;
            this.lueTicketType.EnumString = eReview01.CommonUI.Enumeration.EnumType.None;
            this.lueTicketType.HasSelectAllItem = true;
            this.lueTicketType.Location = new System.Drawing.Point(288, 32);
            this.lueTicketType.Name = "lueTicketType";
            this.lueTicketType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lueTicketType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", "Delete", null, true)});
            this.lueTicketType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TICK_TYPE_NAME", "Loại vé")});
            this.lueTicketType.Properties.DataSource = this.bsTICKET_TYPE;
            this.lueTicketType.Properties.DisplayMember = "TICK_TYPE_NAME";
            this.lueTicketType.Properties.NullText = "<<Tất cả>>";
            this.lueTicketType.Properties.ShowFooter = false;
            this.lueTicketType.Properties.ShowHeader = false;
            this.lueTicketType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueTicketType.Properties.ValueMember = "TICK_TYPE_ID";
            this.lueTicketType.Size = new System.Drawing.Size(176, 20);
            this.lueTicketType.TabIndex = 2;
            // 
            // bsTICKET_TYPE
            // 
            this.bsTICKET_TYPE.DataMember = "ticket_type";
            this.bsTICKET_TYPE.DataSource = this.dsReview;
            // 
            // lueVehType
            // 
            this.lueVehType.AutoGetData = false;
            this.lueVehType.EnumString = eReview01.CommonUI.Enumeration.EnumType.None;
            this.lueVehType.HasSelectAllItem = true;
            this.lueVehType.Location = new System.Drawing.Point(56, 32);
            this.lueVehType.Name = "lueVehType";
            this.lueVehType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lueVehType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", "Delete", null, true)});
            this.lueVehType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VEH_TYPE_NAME", "Loại xe")});
            this.lueVehType.Properties.DataSource = this.bsVEH_TYPE;
            this.lueVehType.Properties.DisplayMember = "VEH_TYPE_NAME";
            this.lueVehType.Properties.NullText = "<<Tất cả>>";
            this.lueVehType.Properties.ShowFooter = false;
            this.lueVehType.Properties.ShowHeader = false;
            this.lueVehType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueVehType.Properties.ValueMember = "VEH_TYPE_ID";
            this.lueVehType.Size = new System.Drawing.Size(160, 20);
            this.lueVehType.TabIndex = 2;
            // 
            // lueLane
            // 
            this.lueLane.AutoGetData = false;
            this.lueLane.EnumString = eReview01.CommonUI.Enumeration.EnumType.None;
            this.lueLane.HasSelectAllItem = true;
            this.lueLane.Location = new System.Drawing.Point(544, 8);
            this.lueLane.Name = "lueLane";
            this.lueLane.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lueLane.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", "Delete", null, true)});
            this.lueLane.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LANE_INFO_NUMBER", "Làn")});
            this.lueLane.Properties.DataSource = this.bsLaneInfo;
            this.lueLane.Properties.DisplayMember = "LANE_INFO_NUMBER";
            this.lueLane.Properties.NullText = "<<Tất cả>>";
            this.lueLane.Properties.ShowFooter = false;
            this.lueLane.Properties.ShowHeader = false;
            this.lueLane.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueLane.Properties.ValueMember = "LANE_INFO_ID";
            this.lueLane.Size = new System.Drawing.Size(104, 20);
            this.lueLane.TabIndex = 2;
            // 
            // bsLaneInfo
            // 
            this.bsLaneInfo.DataMember = "lane_info";
            this.bsLaneInfo.DataSource = this.dsReview;
            // 
            // mDevXLabel7
            // 
            this.mDevXLabel7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.mDevXLabel7.Location = new System.Drawing.Point(8, 32);
            this.mDevXLabel7.Name = "mDevXLabel7";
            this.mDevXLabel7.Size = new System.Drawing.Size(40, 21);
            this.mDevXLabel7.TabIndex = 5;
            this.mDevXLabel7.Text = "Loại &xe";
            // 
            // mDevXLabel1
            // 
            this.mDevXLabel1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.mDevXLabel1.Location = new System.Drawing.Point(792, 8);
            this.mDevXLabel1.Name = "mDevXLabel1";
            this.mDevXLabel1.Size = new System.Drawing.Size(64, 21);
            this.mDevXLabel1.TabIndex = 7;
            this.mDevXLabel1.Text = "Kiểu thu &phí";
            // 
            // btnExport
            // 
            this.btnExport.BindingType = eReview01.CommonUI.Enumeration.EnumBindingType.None;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.Location = new System.Drawing.Point(136, 56);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(80, 23);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "&Xuất file";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // mDevXLabel6
            // 
            this.mDevXLabel6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.mDevXLabel6.Location = new System.Drawing.Point(232, 32);
            this.mDevXLabel6.Name = "mDevXLabel6";
            this.mDevXLabel6.Size = new System.Drawing.Size(56, 21);
            this.mDevXLabel6.TabIndex = 7;
            this.mDevXLabel6.Text = "Loại &vé";
            // 
            // btnSearch
            // 
            this.btnSearch.BindingType = eReview01.CommonUI.Enumeration.EnumBindingType.None;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(56, 56);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "&Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // mDevXLabel4
            // 
            this.mDevXLabel4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.mDevXLabel4.Location = new System.Drawing.Point(480, 8);
            this.mDevXLabel4.Name = "mDevXLabel4";
            this.mDevXLabel4.Size = new System.Drawing.Size(40, 21);
            this.mDevXLabel4.TabIndex = 1;
            this.mDevXLabel4.Text = "&Làn xe";
            // 
            // mDevXLabel3
            // 
            this.mDevXLabel3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.mDevXLabel3.Location = new System.Drawing.Point(656, 8);
            this.mDevXLabel3.Name = "mDevXLabel3";
            this.mDevXLabel3.Size = new System.Drawing.Size(40, 21);
            this.mDevXLabel3.TabIndex = 3;
            this.mDevXLabel3.Text = "&Biển số";
            // 
            // txtVehNumber
            // 
            this.txtVehNumber.EditValue = "";
            this.txtVehNumber.Location = new System.Drawing.Point(696, 8);
            this.txtVehNumber.Name = "txtVehNumber";
            this.txtVehNumber.Properties.MaxLength = 15;
            this.txtVehNumber.Size = new System.Drawing.Size(80, 20);
            this.txtVehNumber.TabIndex = 4;
            // 
            // colUSER_INFO_ID
            // 
            this.colUSER_INFO_ID.Caption = "Mã nhân viên";
            this.colUSER_INFO_ID.FieldName = "USER_INFO_ID";
            this.colUSER_INFO_ID.Name = "colUSER_INFO_ID";
            this.colUSER_INFO_ID.Visible = true;
            this.colUSER_INFO_ID.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên nhân viên";
            this.gridColumn2.FieldName = "USER_INFO_FULL";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Loại xe";
            this.gridColumn11.FieldName = "VEH_TYPE_NAME";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 0;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Chú thích";
            this.gridColumn13.FieldName = "VEH_TYPE_DESC";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 1;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tên vé";
            this.gridColumn5.FieldName = "TICK_TYPE_NAME";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Giá vé";
            this.gridColumn6.DisplayFormat.FormatString = "###,###";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn6.FieldName = "TICK_TYPE_FEE";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Chú thích";
            this.gridColumn7.FieldName = "TC_TICKET_TYPE_DESCRIPTION";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            // 
            // bsLANE_TYPE
            // 
            this.bsLANE_TYPE.DataMember = "lane_type";
            this.bsLANE_TYPE.DataSource = this.dsReview;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên vé";
            this.gridColumn1.FieldName = "TICK_TYPE_NAME";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Giá vé";
            this.gridColumn3.FieldName = "TICK_TYPE_FEE";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Chú thích";
            this.gridColumn4.FieldName = "TC_TICKET_TYPE_DESCRIPTION";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.lblVehNumber);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.lblPassCount);
            this.groupControl2.Controls.Add(this.lblTransFee);
            this.groupControl2.Controls.Add(this.lblVehType);
            this.groupControl2.Controls.Add(this.lblTicketType);
            this.groupControl2.Controls.Add(this.lblTransBegin);
            this.groupControl2.Controls.Add(this.btnUpdateVehNumber);
            this.groupControl2.Controls.Add(this.lblUser);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.txtUpdateVehNumber);
            this.groupControl2.Controls.Add(this.labelControl27);
            this.groupControl2.Controls.Add(this.labelControl25);
            this.groupControl2.Controls.Add(this.labelControl23);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl21);
            this.groupControl2.Location = new System.Drawing.Point(696, 544);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(420, 176);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Thông tin soát vé";
            // 
            // lblVehNumber
            // 
            this.lblVehNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehNumber.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblVehNumber.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblVehNumber.Location = new System.Drawing.Point(320, 96);
            this.lblVehNumber.Name = "lblVehNumber";
            this.lblVehNumber.Size = new System.Drawing.Size(88, 21);
            this.lblVehNumber.TabIndex = 13;
            this.lblVehNumber.TextChanged += new System.EventHandler(this.lblVehNumber_TextChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.Location = new System.Drawing.Point(240, 96);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(80, 21);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Biển số xe";
            // 
            // lblPassCount
            // 
            this.lblPassCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassCount.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPassCount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblPassCount.Location = new System.Drawing.Point(320, 48);
            this.lblPassCount.Name = "lblPassCount";
            this.lblPassCount.Size = new System.Drawing.Size(88, 21);
            this.lblPassCount.TabIndex = 11;
            this.lblPassCount.ToolTip = "Số lần qua trong ngày";
            this.lblPassCount.ToolTipTitle = "Số lần qua trong ngày";
            this.lblPassCount.Visible = false;
            // 
            // lblTransFee
            // 
            this.lblTransFee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTransFee.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTransFee.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTransFee.Location = new System.Drawing.Point(320, 72);
            this.lblTransFee.Name = "lblTransFee";
            this.lblTransFee.Size = new System.Drawing.Size(88, 21);
            this.lblTransFee.TabIndex = 9;
            // 
            // lblVehType
            // 
            this.lblVehType.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblVehType.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblVehType.Location = new System.Drawing.Point(88, 96);
            this.lblVehType.Name = "lblVehType";
            this.lblVehType.Size = new System.Drawing.Size(144, 21);
            this.lblVehType.TabIndex = 7;
            // 
            // lblTicketType
            // 
            this.lblTicketType.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTicketType.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTicketType.Location = new System.Drawing.Point(88, 72);
            this.lblTicketType.Name = "lblTicketType";
            this.lblTicketType.Size = new System.Drawing.Size(144, 21);
            this.lblTicketType.TabIndex = 5;
            // 
            // lblTransBegin
            // 
            this.lblTransBegin.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTransBegin.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTransBegin.Location = new System.Drawing.Point(88, 48);
            this.lblTransBegin.Name = "lblTransBegin";
            this.lblTransBegin.Size = new System.Drawing.Size(144, 21);
            this.lblTransBegin.TabIndex = 3;
            this.lblTransBegin.Tag = "TRANS_BEGIN";
            // 
            // btnUpdateVehNumber
            // 
            this.btnUpdateVehNumber.BindingType = eReview01.CommonUI.Enumeration.EnumBindingType.None;
            this.btnUpdateVehNumber.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateVehNumber.Image")));
            this.btnUpdateVehNumber.Location = new System.Drawing.Point(192, 120);
            this.btnUpdateVehNumber.Name = "btnUpdateVehNumber";
            this.btnUpdateVehNumber.Size = new System.Drawing.Size(72, 21);
            this.btnUpdateVehNumber.TabIndex = 0;
            this.btnUpdateVehNumber.Text = "Cập nhật";
            this.btnUpdateVehNumber.Click += new System.EventHandler(this.btnUpdateVehNumber_Click);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblUser.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblUser.Location = new System.Drawing.Point(88, 24);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(320, 21);
            this.lblUser.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(240, 48);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(72, 21);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Số lần qua";
            this.labelControl5.ToolTip = "Số lần qua trong ngày";
            this.labelControl5.ToolTipTitle = "Số lần qua trong ngày";
            this.labelControl5.Visible = false;
            // 
            // txtUpdateVehNumber
            // 
            this.txtUpdateVehNumber.Location = new System.Drawing.Point(88, 120);
            this.txtUpdateVehNumber.Name = "txtUpdateVehNumber";
            this.txtUpdateVehNumber.Properties.MaxLength = 15;
            this.txtUpdateVehNumber.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateVehNumber.TabIndex = 0;
            this.txtUpdateVehNumber.Tag = "";
            this.txtUpdateVehNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpdateVehNumber_KeyPress);
            // 
            // labelControl27
            // 
            this.labelControl27.Appearance.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.labelControl27.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl27.Location = new System.Drawing.Point(240, 72);
            this.labelControl27.Name = "labelControl27";
            this.labelControl27.Size = new System.Drawing.Size(72, 21);
            this.labelControl27.TabIndex = 8;
            this.labelControl27.Text = "Mức phí";
            // 
            // labelControl25
            // 
            this.labelControl25.Appearance.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.labelControl25.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl25.Location = new System.Drawing.Point(8, 96);
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Size = new System.Drawing.Size(72, 21);
            this.labelControl25.TabIndex = 6;
            this.labelControl25.Text = "Loại xe";
            // 
            // labelControl23
            // 
            this.labelControl23.Appearance.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.labelControl23.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl23.Location = new System.Drawing.Point(8, 72);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(72, 21);
            this.labelControl23.TabIndex = 4;
            this.labelControl23.Text = "Loại vé";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(8, 120);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 21);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Sửa biển số";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(8, 48);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 21);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Ngày giờ";
            // 
            // labelControl21
            // 
            this.labelControl21.Appearance.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.labelControl21.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl21.Location = new System.Drawing.Point(8, 24);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(72, 21);
            this.labelControl21.TabIndex = 0;
            this.labelControl21.Text = "Thu phí viên";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Controls.Add(this.lblVehicleHistory);
            this.groupControl1.Controls.Add(this.lblVehRegAddress);
            this.groupControl1.Controls.Add(this.lblVehRegWeight);
            this.groupControl1.Controls.Add(this.lblVehRegType);
            this.groupControl1.Controls.Add(this.lblVehRegSeat);
            this.groupControl1.Controls.Add(this.lblVehRegDate);
            this.groupControl1.Controls.Add(this.lblVehRegOwn);
            this.groupControl1.Controls.Add(this.labelControl19);
            this.groupControl1.Controls.Add(this.labelControl17);
            this.groupControl1.Controls.Add(this.labelControl15);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.label111);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Location = new System.Drawing.Point(272, 544);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(416, 177);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Thông tin xe chuẩn";
            // 
            // lblVehicleHistory
            // 
            this.lblVehicleHistory.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblVehicleHistory.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblVehicleHistory.Location = new System.Drawing.Point(8, 144);
            this.lblVehicleHistory.Name = "lblVehicleHistory";
            this.lblVehicleHistory.Size = new System.Drawing.Size(400, 21);
            this.lblVehicleHistory.TabIndex = 10;
            // 
            // lblVehRegAddress
            // 
            this.lblVehRegAddress.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblVehRegAddress.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lblVehRegAddress.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblVehRegAddress.Location = new System.Drawing.Point(56, 100);
            this.lblVehRegAddress.Name = "lblVehRegAddress";
            this.lblVehRegAddress.Size = new System.Drawing.Size(352, 40);
            this.lblVehRegAddress.TabIndex = 7;
            // 
            // lblVehRegWeight
            // 
            this.lblVehRegWeight.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblVehRegWeight.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblVehRegWeight.Location = new System.Drawing.Point(296, 48);
            this.lblVehRegWeight.Name = "lblVehRegWeight";
            this.lblVehRegWeight.Size = new System.Drawing.Size(112, 21);
            this.lblVehRegWeight.TabIndex = 16;
            // 
            // lblVehRegType
            // 
            this.lblVehRegType.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblVehRegType.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblVehRegType.Location = new System.Drawing.Point(56, 24);
            this.lblVehRegType.Name = "lblVehRegType";
            this.lblVehRegType.Size = new System.Drawing.Size(152, 21);
            this.lblVehRegType.TabIndex = 14;
            // 
            // lblVehRegSeat
            // 
            this.lblVehRegSeat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblVehRegSeat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblVehRegSeat.Location = new System.Drawing.Point(56, 48);
            this.lblVehRegSeat.Name = "lblVehRegSeat";
            this.lblVehRegSeat.Size = new System.Drawing.Size(152, 21);
            this.lblVehRegSeat.TabIndex = 5;
            // 
            // lblVehRegDate
            // 
            this.lblVehRegDate.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblVehRegDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblVehRegDate.Location = new System.Drawing.Point(296, 24);
            this.lblVehRegDate.Name = "lblVehRegDate";
            this.lblVehRegDate.Size = new System.Drawing.Size(112, 21);
            this.lblVehRegDate.TabIndex = 3;
            // 
            // lblVehRegOwn
            // 
            this.lblVehRegOwn.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblVehRegOwn.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblVehRegOwn.Location = new System.Drawing.Point(56, 72);
            this.lblVehRegOwn.Name = "lblVehRegOwn";
            this.lblVehRegOwn.Size = new System.Drawing.Size(352, 21);
            this.lblVehRegOwn.TabIndex = 12;
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.labelControl19.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl19.Location = new System.Drawing.Point(216, 48);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(64, 21);
            this.labelControl19.TabIndex = 15;
            this.labelControl19.Text = "Tải trọng";
            this.labelControl19.ToolTip = "Loại phương tiện";
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.labelControl17.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl17.Location = new System.Drawing.Point(8, 48);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(48, 21);
            this.labelControl17.TabIndex = 4;
            this.labelControl17.Text = "Số chỗ";
            this.labelControl17.ToolTip = "Loại phương tiện";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.labelControl15.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl15.Location = new System.Drawing.Point(8, 24);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(48, 21);
            this.labelControl15.TabIndex = 13;
            this.labelControl15.Text = "Loại xe";
            this.labelControl15.ToolTip = "Loại phương tiện";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.labelControl13.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl13.Location = new System.Drawing.Point(8, 96);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(48, 21);
            this.labelControl13.TabIndex = 6;
            this.labelControl13.Text = "Địa chỉ";
            // 
            // label111
            // 
            this.label111.Appearance.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.label111.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.label111.Location = new System.Drawing.Point(8, 72);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(48, 21);
            this.label111.TabIndex = 11;
            this.label111.Text = "Chủ xe";
            this.label111.ToolTip = "Chủ phương tiện";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.Location = new System.Drawing.Point(216, 24);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(80, 21);
            this.labelControl9.TabIndex = 2;
            this.labelControl9.Text = "Ngày đăng ký";
            // 
            // pePhoto
            // 
            this.pePhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pePhoto.Location = new System.Drawing.Point(8, 544);
            this.pePhoto.Name = "pePhoto";
            this.pePhoto.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.pePhoto.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.pePhoto.Properties.ContextMenuStrip = this.mc_Image;
            this.pePhoto.Properties.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pePhoto.Properties.ErrorImage")));
            this.pePhoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pePhoto.Size = new System.Drawing.Size(256, 177);
            this.pePhoto.TabIndex = 4;
            // 
            // peZoomPhoto
            // 
            this.peZoomPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.peZoomPhoto.EditValue = ((object)(resources.GetObject("peZoomPhoto.EditValue")));
            this.peZoomPhoto.Location = new System.Drawing.Point(184, 552);
            this.peZoomPhoto.Name = "peZoomPhoto";
            this.peZoomPhoto.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.peZoomPhoto.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.peZoomPhoto.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peZoomPhoto.Properties.Appearance.Options.UseBackColor = true;
            this.peZoomPhoto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peZoomPhoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.peZoomPhoto.Size = new System.Drawing.Size(32, 25);
            this.peZoomPhoto.TabIndex = 6;
            this.peZoomPhoto.ToolTip = "Xem chi tiết";
            this.peZoomPhoto.Click += new System.EventHandler(this.peZoomPhoto_Click);
            // 
            // pePlayVideo
            // 
            this.pePlayVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pePlayVideo.EditValue = global::eReview01.Properties.Resources.video;
            this.pePlayVideo.Location = new System.Drawing.Point(224, 552);
            this.pePlayVideo.Name = "pePlayVideo";
            this.pePlayVideo.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.pePlayVideo.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.pePlayVideo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pePlayVideo.Properties.Appearance.Options.UseBackColor = true;
            this.pePlayVideo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pePlayVideo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pePlayVideo.Size = new System.Drawing.Size(32, 25);
            this.pePlayVideo.TabIndex = 7;
            this.pePlayVideo.ToolTip = "Xem video";
            this.pePlayVideo.Click += new System.EventHandler(this.pePlayVideo_Click);
            // 
            // bsTicketBill
            // 
            this.bsTicketBill.DataMember = "ticket_bill";
            this.bsTicketBill.DataSource = this.dsReview;
            // 
            // mc_Image
            // 
            this.mc_Image.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lưuToolStripMenuItem,
            this.toolStripSeparator1,
            this.inToolStripMenuItem,
            this.inMànHìnhToolStripMenuItem});
            this.mc_Image.Name = "mc_Image";
            this.mc_Image.Size = new System.Drawing.Size(153, 98);
            // 
            // lưuToolStripMenuItem
            // 
            this.lưuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lưuToolStripMenuItem.Image")));
            this.lưuToolStripMenuItem.Name = "lưuToolStripMenuItem";
            this.lưuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lưuToolStripMenuItem.Text = "Lưu";
            this.lưuToolStripMenuItem.Click += new System.EventHandler(this.lưuToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // inToolStripMenuItem
            // 
            this.inToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inToolStripMenuItem.Image")));
            this.inToolStripMenuItem.Name = "inToolStripMenuItem";
            this.inToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.inToolStripMenuItem.Text = "In ảnh";
            this.inToolStripMenuItem.Click += new System.EventHandler(this.inToolStripMenuItem_Click);
            // 
            // inMànHìnhToolStripMenuItem
            // 
            this.inMànHìnhToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inMànHìnhToolStripMenuItem.Image")));
            this.inMànHìnhToolStripMenuItem.Name = "inMànHìnhToolStripMenuItem";
            this.inMànHìnhToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.inMànHìnhToolStripMenuItem.Text = "In màn hình";
            this.inMànHìnhToolStripMenuItem.Click += new System.EventHandler(this.inMànHìnhToolStripMenuItem_Click);
            // 
            // PostReviewList
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1124, 733);
            this.Controls.Add(this.pePlayVideo);
            this.Controls.Add(this.peZoomPhoto);
            this.Controls.Add(this.pePhoto);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.mDevXGroupControl1);
            this.Controls.Add(this.gcReview);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "PostReviewList";
            this.ShowIcon = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hậu kiểm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PostReviewList_Load);
            this.Shown += new System.EventHandler(this.PostReviewList_Shown);
            this.Controls.SetChildIndex(this.gcReview, 0);
            this.Controls.SetChildIndex(this.mDevXGroupControl1, 0);
            this.Controls.SetChildIndex(this.groupControl2, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.pePhoto, 0);
            this.Controls.SetChildIndex(this.peZoomPhoto, 0);
            this.Controls.SetChildIndex(this.pePlayVideo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dsReview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcReview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rileTCType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTC_TYPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rileVEH_TYPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVEH_TYPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rigleUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUSER_INFO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rileShiftType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsShiftType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rileErrorType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsErrorType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDevXGroupControl1)).EndInit();
            this.mDevXGroupControl1.ResumeLayout(false);
            this.mDevXGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditSuspect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTcType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glueUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUserTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTcType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTicketType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTICKET_TYPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueVehType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLane.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLaneInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVehNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLANE_TYPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdateVehNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pePhoto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peZoomPhoto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pePlayVideo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTicketBill)).EndInit();
            this.mc_Image.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Entities.DatasetReview dsReview;
        private System.Windows.Forms.BindingSource bsReview;
        private eReview01.CDControl.CDGrid gcReview;
        private DevExpress.XtraGrid.Views.Grid.GridView gvReview;
        private DevExpress.XtraGrid.Columns.GridColumn colTRANS_BEGIN;
        private DevExpress.XtraGrid.Columns.GridColumn colTRANS_END;
        private DevExpress.XtraGrid.Columns.GridColumn colTRANS_VEH_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colTRANS_VEH_NUMBER;
        private DevExpress.XtraGrid.Columns.GridColumn colTRANS_BARCODE;
        private DevExpress.XtraGrid.Columns.GridColumn colTRANS_TC_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colTRANS_FEE;
        private DevExpress.XtraEditors.GroupControl mDevXGroupControl1;
        private eReview01.CDControl.CDTextEdit txtVehNumber;
        private eReview01.CDControl.CDLabel mDevXLabel4;
        private eReview01.CDControl.CDLabel mDevXLabel3;
        private eReview01.CDControl.CDButton btnSearch;
        private eReview01.CDControl.CDLabel mDevXLabel6;
        private DevExpress.XtraGrid.Columns.GridColumn colIndex;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rileVEH_TYPE;
        private System.Windows.Forms.BindingSource bsVEH_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colLANE;
        private DevExpress.XtraGrid.Columns.GridColumn colUSERNAME;
        private System.Windows.Forms.BindingSource bsTC_TYPE;
        private System.Windows.Forms.BindingSource bsLANE_TYPE;
        private System.Windows.Forms.BindingSource bsTICKET_TYPE;
        private System.Windows.Forms.BindingSource bsUSER_INFO;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rileTCType;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rigleUser;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl27;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl label111;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.PictureEdit pePhoto;
        private eReview01.CDControl.CDButton btnUpdateVehNumber;
        private eReview01.CDControl.CDTextEdit txtUpdateVehNumber;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PictureEdit peZoomPhoto;
        private DevExpress.XtraEditors.PictureEdit pePlayVideo;
        private eReview01.CDControl.CDLabel lblVehicleHistory;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rileShiftType;
        private System.Windows.Forms.BindingSource bsShiftType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        public eReview01.CDControl.CDLabel lblUser;
        public eReview01.CDControl.CDLabel lblTransFee;
        public eReview01.CDControl.CDLabel lblVehType;
        public eReview01.CDControl.CDLabel lblTicketType;
        public eReview01.CDControl.CDLabel lblTransBegin;
        public eReview01.CDControl.CDLabel lblPassCount;
        public eReview01.CDControl.CDLabel lblVehRegWeight;
        public eReview01.CDControl.CDLabel lblVehRegType;
        public eReview01.CDControl.CDLabel lblVehRegSeat;
        public eReview01.CDControl.CDLabel lblVehRegDate;
        public eReview01.CDControl.CDLabel lblVehRegOwn;
        public eReview01.CDControl.CDLabel lblVehRegAddress;
        private eReview01.CDControl.CDButton btnExport;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private eReview01.CDControl.CDLabel mDevXLabel7;
        private System.Windows.Forms.BindingSource bsLaneInfo;
        private eReview01.CDControl.CDLookUpEnum lueLane;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_INFO_ID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private eReview01.CDControl.CDLabel mDevXLabel5;
        private System.Windows.Forms.BindingSource bsErrorType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rileErrorType;
        private System.Windows.Forms.Timer timer1;
        public eReview01.CDControl.CDLabel lblVehNumber;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private eReview01.CDControl.CDGridLookUpEdit glueUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_INFO_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_INFO_FULL;
        private System.Windows.Forms.BindingSource bsUserTicket;
        private eReview01.CDControl.CDLabel mDevXLabel1;
        public DateRangeSimple dateRangeSimple1;
        private eReview01.CDControl.CDLookUpEnum lueVehType;
        private eReview01.CDControl.CDLookUpEnum lueTicketType;
        private eReview01.CDControl.CDLookUpEnum lueTcType;
        private eReview01.CDControl.CDLookUpEnum errorTcType;
        private eReview01.CDControl.CDLabel mDevXLabel2;
        private DevExpress.XtraEditors.CheckEdit checkEditSuspect;
        private System.Windows.Forms.BindingSource bsTicketBill;
        private DevExpress.XtraEditors.LabelControl lbl_Note;
        private System.Windows.Forms.ContextMenuStrip mc_Image;
        private System.Windows.Forms.ToolStripMenuItem lưuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem inToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inMànHìnhToolStripMenuItem;
    }
}
