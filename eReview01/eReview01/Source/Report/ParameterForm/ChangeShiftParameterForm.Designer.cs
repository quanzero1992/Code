namespace eReview01.Source.Report.ParameterForm
{
    partial class ChangeShiftParameterForm
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
            this.mDevXGroupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcUserInfo = new eReview01.CDControl.CDGrid();
            this.bsShiftInfo = new System.Windows.Forms.BindingSource();
            this.dsReview = new eReview01.Entities.DatasetReview();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colSHI_INF_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHI_INF_BEGIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHI_INF_END = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHI_INF_USER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rileUserInfo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsUserInfo = new System.Windows.Forms.BindingSource();
            this.colSHI_INF_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rileShiftType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsShiftType = new System.Windows.Forms.BindingSource();
            this.colSHI_LANE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHI_INF_STATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHI_INF_TICK_NUM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHI_INF_TICK_SOLD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkCheckedAllUser = new DevExpress.XtraEditors.CheckEdit();
            this.mDevXGroupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.glueShiftType = new eReview01.CDControl.CDGridLookUpEdit();
            this.mDevXGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new eReview01.CDControl.CDLabel();
            ((System.ComponentModel.ISupportInitialize)(this.mDevXGroupControl1)).BeginInit();
            this.mDevXGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUserInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsShiftInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rileUserInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUserInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rileShiftType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsShiftType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCheckedAllUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDevXGroupControl2)).BeginInit();
            this.mDevXGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glueShiftType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDevXGridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // dateRange1
            // 
            this.dateRange1.DateFormat = "dd/MM/yyyy";
            this.dateRange1.FromDate = new System.DateTime(2014, 8, 1, 0, 0, 0, 0);
            this.dateRange1.ReportPeriod = eReview01.CommonUI.Enumeration.EnumReportPeriod.Today;
            this.dateRange1.TimeFormat = "HH:mm:ss";
            this.dateRange1.ToDate = new System.DateTime(2014, 8, 31, 23, 59, 59, 0);
            this.dateRange1.EditValueChanged += new System.EventHandler(this.dateRange1_EditValueChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(344, 352);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(432, 352);
            // 
            // mDevXGroupControl1
            // 
            this.mDevXGroupControl1.Controls.Add(this.gcUserInfo);
            this.mDevXGroupControl1.Location = new System.Drawing.Point(8, 144);
            this.mDevXGroupControl1.Name = "mDevXGroupControl1";
            this.mDevXGroupControl1.Size = new System.Drawing.Size(496, 200);
            this.mDevXGroupControl1.TabIndex = 3;
            this.mDevXGroupControl1.Text = "Danh sách ca";
            // 
            // gcUserInfo
            // 
            this.gcUserInfo.AutoGetData = false;
            this.gcUserInfo.BindingType = eReview01.CommonUI.Enumeration.EnumBindingType.None;
            this.gcUserInfo.DataSource = this.bsShiftInfo;
            this.gcUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcUserInfo.Location = new System.Drawing.Point(2, 21);
            this.gcUserInfo.MainView = this.gridView1;
            this.gcUserInfo.Name = "gcUserInfo";
            this.gcUserInfo.OrderBy = null;
            this.gcUserInfo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.rileShiftType,
            this.rileUserInfo});
            this.gcUserInfo.Size = new System.Drawing.Size(492, 177);
            this.gcUserInfo.TabIndex = 0;
            this.gcUserInfo.TableNameEnum = eReview01.CommonUI.Enumeration.EnumTableName.None;
            this.gcUserInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcUserInfo.WhereCause = null;
            // 
            // bsShiftInfo
            // 
            this.bsShiftInfo.DataMember = "shift_info";
            this.bsShiftInfo.DataSource = this.dsReview;
            this.bsShiftInfo.Filter = "";
            // 
            // dsReview
            // 
            this.dsReview.DataSetName = "DataSetReview";
            this.dsReview.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSelected,
            this.colSHI_INF_ID,
            this.colSHI_INF_BEGIN,
            this.colSHI_INF_END,
            this.colSHI_INF_USER,
            this.colSHI_INF_TYPE,
            this.colSHI_LANE_ID,
            this.colSHI_INF_STATE,
            this.colSHI_INF_TICK_NUM,
            this.colSHI_INF_TICK_SOLD});
            this.gridView1.GridControl = this.gcUserInfo;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colSelected
            // 
            this.colSelected.Caption = " ";
            this.colSelected.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colSelected.FieldName = "Selected";
            this.colSelected.Name = "colSelected";
            this.colSelected.OptionsFilter.AllowAutoFilter = false;
            this.colSelected.OptionsFilter.AllowFilter = false;
            this.colSelected.Visible = true;
            this.colSelected.VisibleIndex = 0;
            this.colSelected.Width = 47;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // colSHI_INF_ID
            // 
            this.colSHI_INF_ID.FieldName = "SHI_INF_ID";
            this.colSHI_INF_ID.Name = "colSHI_INF_ID";
            this.colSHI_INF_ID.OptionsColumn.AllowEdit = false;
            this.colSHI_INF_ID.OptionsColumn.AllowFocus = false;
            this.colSHI_INF_ID.OptionsColumn.ReadOnly = true;
            // 
            // colSHI_INF_BEGIN
            // 
            this.colSHI_INF_BEGIN.Caption = "Bắt đầu lúc";
            this.colSHI_INF_BEGIN.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colSHI_INF_BEGIN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSHI_INF_BEGIN.FieldName = "SHI_INF_BEGIN";
            this.colSHI_INF_BEGIN.Name = "colSHI_INF_BEGIN";
            this.colSHI_INF_BEGIN.OptionsColumn.AllowEdit = false;
            this.colSHI_INF_BEGIN.OptionsColumn.AllowFocus = false;
            this.colSHI_INF_BEGIN.OptionsColumn.ReadOnly = true;
            this.colSHI_INF_BEGIN.Visible = true;
            this.colSHI_INF_BEGIN.VisibleIndex = 1;
            this.colSHI_INF_BEGIN.Width = 131;
            // 
            // colSHI_INF_END
            // 
            this.colSHI_INF_END.Caption = "Kết thúc lúc";
            this.colSHI_INF_END.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colSHI_INF_END.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSHI_INF_END.FieldName = "SHI_INF_END";
            this.colSHI_INF_END.Name = "colSHI_INF_END";
            this.colSHI_INF_END.OptionsColumn.AllowEdit = false;
            this.colSHI_INF_END.OptionsColumn.AllowFocus = false;
            this.colSHI_INF_END.OptionsColumn.ReadOnly = true;
            this.colSHI_INF_END.Visible = true;
            this.colSHI_INF_END.VisibleIndex = 2;
            this.colSHI_INF_END.Width = 127;
            // 
            // colSHI_INF_USER
            // 
            this.colSHI_INF_USER.Caption = "Thu phí viên";
            this.colSHI_INF_USER.ColumnEdit = this.rileUserInfo;
            this.colSHI_INF_USER.FieldName = "SHI_INF_USER";
            this.colSHI_INF_USER.Name = "colSHI_INF_USER";
            this.colSHI_INF_USER.OptionsColumn.AllowEdit = false;
            this.colSHI_INF_USER.OptionsColumn.AllowFocus = false;
            this.colSHI_INF_USER.OptionsColumn.ReadOnly = true;
            this.colSHI_INF_USER.Visible = true;
            this.colSHI_INF_USER.VisibleIndex = 3;
            this.colSHI_INF_USER.Width = 124;
            // 
            // rileUserInfo
            // 
            this.rileUserInfo.AutoHeight = false;
            this.rileUserInfo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rileUserInfo.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("USER_INFO_ID", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("USER_INFO_FULL", "Họ tên")});
            this.rileUserInfo.DataSource = this.bsUserInfo;
            this.rileUserInfo.DisplayMember = "USER_INFO_FULL";
            this.rileUserInfo.Name = "rileUserInfo";
            this.rileUserInfo.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.rileUserInfo.ValueMember = "USER_INFO_ID";
            // 
            // bsUserInfo
            // 
            this.bsUserInfo.DataMember = "user_info";
            this.bsUserInfo.DataSource = this.dsReview;
            // 
            // colSHI_INF_TYPE
            // 
            this.colSHI_INF_TYPE.Caption = "Ca";
            this.colSHI_INF_TYPE.ColumnEdit = this.rileShiftType;
            this.colSHI_INF_TYPE.FieldName = "SHI_TYPE_ID";
            this.colSHI_INF_TYPE.Name = "colSHI_INF_TYPE";
            this.colSHI_INF_TYPE.OptionsColumn.AllowEdit = false;
            this.colSHI_INF_TYPE.OptionsColumn.AllowFocus = false;
            this.colSHI_INF_TYPE.OptionsColumn.ReadOnly = true;
            this.colSHI_INF_TYPE.Visible = true;
            this.colSHI_INF_TYPE.VisibleIndex = 4;
            this.colSHI_INF_TYPE.Width = 73;
            // 
            // rileShiftType
            // 
            this.rileShiftType.AutoHeight = false;
            this.rileShiftType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rileShiftType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SHI_TYPE_NAME", "Ca")});
            this.rileShiftType.DataSource = this.bsShiftType;
            this.rileShiftType.DisplayMember = "SHI_TYPE_NAME";
            this.rileShiftType.Name = "rileShiftType";
            this.rileShiftType.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.rileShiftType.ValueMember = "SHI_TYPE_ID";
            // 
            // bsShiftType
            // 
            this.bsShiftType.DataMember = "shift_type";
            this.bsShiftType.DataSource = this.dsReview;
            // 
            // colSHI_LANE_ID
            // 
            this.colSHI_LANE_ID.FieldName = "SHI_LANE_ID";
            this.colSHI_LANE_ID.Name = "colSHI_LANE_ID";
            this.colSHI_LANE_ID.OptionsColumn.AllowEdit = false;
            this.colSHI_LANE_ID.OptionsColumn.AllowFocus = false;
            this.colSHI_LANE_ID.OptionsColumn.ReadOnly = true;
            // 
            // colSHI_INF_STATE
            // 
            this.colSHI_INF_STATE.FieldName = "SHI_INF_STATE";
            this.colSHI_INF_STATE.Name = "colSHI_INF_STATE";
            this.colSHI_INF_STATE.OptionsColumn.AllowEdit = false;
            this.colSHI_INF_STATE.OptionsColumn.AllowFocus = false;
            this.colSHI_INF_STATE.OptionsColumn.ReadOnly = true;
            // 
            // colSHI_INF_TICK_NUM
            // 
            this.colSHI_INF_TICK_NUM.FieldName = "SHI_INF_TICK_NUM";
            this.colSHI_INF_TICK_NUM.Name = "colSHI_INF_TICK_NUM";
            this.colSHI_INF_TICK_NUM.OptionsColumn.AllowEdit = false;
            this.colSHI_INF_TICK_NUM.OptionsColumn.AllowFocus = false;
            this.colSHI_INF_TICK_NUM.OptionsColumn.ReadOnly = true;
            // 
            // colSHI_INF_TICK_SOLD
            // 
            this.colSHI_INF_TICK_SOLD.FieldName = "SHI_INF_TICK_SOLD";
            this.colSHI_INF_TICK_SOLD.Name = "colSHI_INF_TICK_SOLD";
            this.colSHI_INF_TICK_SOLD.OptionsColumn.AllowEdit = false;
            this.colSHI_INF_TICK_SOLD.OptionsColumn.AllowFocus = false;
            this.colSHI_INF_TICK_SOLD.OptionsColumn.ReadOnly = true;
            // 
            // chkCheckedAllUser
            // 
            this.chkCheckedAllUser.Location = new System.Drawing.Point(8, 352);
            this.chkCheckedAllUser.Name = "chkCheckedAllUser";
            this.chkCheckedAllUser.Properties.AllowGrayed = true;
            this.chkCheckedAllUser.Properties.Caption = "Chọn tất cả";
            this.chkCheckedAllUser.Size = new System.Drawing.Size(96, 19);
            this.chkCheckedAllUser.TabIndex = 6;
            this.chkCheckedAllUser.CheckedChanged += new System.EventHandler(this.chkCheckedAllUser_CheckedChanged);
            this.chkCheckedAllUser.CheckStateChanged += new System.EventHandler(this.chkCheckedAllUser_CheckStateChanged);
            // 
            // mDevXGroupControl2
            // 
            this.mDevXGroupControl2.Controls.Add(this.glueShiftType);
            this.mDevXGroupControl2.Controls.Add(this.label1);
            this.mDevXGroupControl2.Location = new System.Drawing.Point(216, 8);
            this.mDevXGroupControl2.Name = "mDevXGroupControl2";
            this.mDevXGroupControl2.Size = new System.Drawing.Size(288, 128);
            this.mDevXGroupControl2.TabIndex = 7;
            this.mDevXGroupControl2.Text = "Chọn ca";
            // 
            // glueShiftType
            // 
            this.glueShiftType.AutoGetData = false;
            this.glueShiftType.BindingType = eReview01.CommonUI.Enumeration.EnumBindingType.None;
            this.glueShiftType.HasSelectAllItem = false;
            this.glueShiftType.Location = new System.Drawing.Point(32, 24);
            this.glueShiftType.Name = "glueShiftType";
            this.glueShiftType.OrderBy = null;
            this.glueShiftType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.glueShiftType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.glueShiftType.Properties.DataSource = this.bsShiftType;
            this.glueShiftType.Properties.DisplayMember = "SHI_TYPE_NAME";
            this.glueShiftType.Properties.NullText = "<<Tất cả>>";
            this.glueShiftType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.glueShiftType.Properties.ValueMember = "SHI_TYPE_ID";
            this.glueShiftType.Properties.View = this.mDevXGridLookUpEdit1View;
            this.glueShiftType.Size = new System.Drawing.Size(248, 20);
            this.glueShiftType.TabIndex = 7;
            this.glueShiftType.TableNameEnum = eReview01.CommonUI.Enumeration.EnumTableName.None;
            this.glueShiftType.WhereCause = null;
            this.glueShiftType.EditValueChanged += new System.EventHandler(this.glueShiftType_EditValueChanged);
            // 
            // mDevXGridLookUpEdit1View
            // 
            this.mDevXGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3});
            this.mDevXGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.mDevXGridLookUpEdit1View.Name = "mDevXGridLookUpEdit1View";
            this.mDevXGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.mDevXGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Ca";
            this.gridColumn2.FieldName = "SHI_TYPE_NAME";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Chú thích";
            this.gridColumn3.FieldName = "SHI_TYPE_DESC";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "&Ca";
            // 
            // ChangeShiftParameterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(513, 383);
            this.Controls.Add(this.mDevXGroupControl2);
            this.Controls.Add(this.chkCheckedAllUser);
            this.Controls.Add(this.mDevXGroupControl1);
            this.Name = "ChangeShiftParameterForm";
            this.Load += new System.EventHandler(this.ChangeShiftParameterForm_Load);
            this.Shown += new System.EventHandler(this.ChangeShiftParameterForm_Shown);
            this.Controls.SetChildIndex(this.dateRange1, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.mDevXGroupControl1, 0);
            this.Controls.SetChildIndex(this.chkCheckedAllUser, 0);
            this.Controls.SetChildIndex(this.mDevXGroupControl2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.mDevXGroupControl1)).EndInit();
            this.mDevXGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcUserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsShiftInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rileUserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rileShiftType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsShiftType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCheckedAllUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDevXGroupControl2)).EndInit();
            this.mDevXGroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.glueShiftType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDevXGridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl mDevXGroupControl1;
        private CDControl.CDGrid gcUserInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Entities.DatasetReview dsReview;
        private System.Windows.Forms.BindingSource bsShiftType;
        private System.Windows.Forms.BindingSource bsShiftInfo;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.CheckEdit chkCheckedAllUser;
        private DevExpress.XtraEditors.GroupControl mDevXGroupControl2;
        private CDControl.CDGridLookUpEdit glueShiftType;
        private DevExpress.XtraGrid.Views.Grid.GridView mDevXGridLookUpEdit1View;
        private CDControl.CDLabel label1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.BindingSource bsUserInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colSHI_INF_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colSHI_INF_BEGIN;
        private DevExpress.XtraGrid.Columns.GridColumn colSHI_INF_END;
        private DevExpress.XtraGrid.Columns.GridColumn colSHI_INF_USER;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rileUserInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colSHI_INF_TYPE;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rileShiftType;
        private DevExpress.XtraGrid.Columns.GridColumn colSHI_LANE_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colSHI_INF_STATE;
        private DevExpress.XtraGrid.Columns.GridColumn colSHI_INF_TICK_NUM;
        private DevExpress.XtraGrid.Columns.GridColumn colSHI_INF_TICK_SOLD;
        private DevExpress.XtraGrid.Columns.GridColumn colSelected;

    }
}
