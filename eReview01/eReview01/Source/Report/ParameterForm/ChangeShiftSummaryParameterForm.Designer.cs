namespace eReview01.Source.Report.ParameterForm
{
    partial class ChangeShiftSummaryParameterForm
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
            this.bsShift = new System.Windows.Forms.BindingSource();
            this.dsReview = new eReview01.Entities.DatasetReview();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSHIFT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHIFT_BEGIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHIFT_END = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHI_TYPE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rileShiftType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsShiftType = new System.Windows.Forms.BindingSource();
            this.colUSER_INFO_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.rileUserInfo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsUserInfo = new System.Windows.Forms.BindingSource();
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
            ((System.ComponentModel.ISupportInitialize)(this.bsShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rileShiftType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsShiftType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rileUserInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUserInfo)).BeginInit();
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
            this.mDevXGroupControl1.Text = "Thông tin chi tiết ca";
            // 
            // gcUserInfo
            // 
            this.gcUserInfo.AutoGetData = false;
            this.gcUserInfo.BindingType = eReview01.CommonUI.Enumeration.EnumBindingType.None;
            this.gcUserInfo.DataSource = this.bsShift;
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
            // bsShift
            // 
            this.bsShift.DataMember = "shift";
            this.bsShift.DataSource = this.dsReview;
            // 
            // dsReview
            // 
            this.dsReview.DataSetName = "DataSetReview";
            this.dsReview.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSHIFT_ID,
            this.colSHIFT_BEGIN,
            this.colSHIFT_END,
            this.colSHI_TYPE_ID,
            this.colUSER_INFO_ID,
            this.colCreateDate,
            this.colModifyDate,
            this.colSelected});
            this.gridView1.GridControl = this.gcUserInfo;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colSHIFT_ID
            // 
            this.colSHIFT_ID.FieldName = "SHIFT_ID";
            this.colSHIFT_ID.Name = "colSHIFT_ID";
            this.colSHIFT_ID.OptionsColumn.AllowEdit = false;
            this.colSHIFT_ID.OptionsColumn.AllowFocus = false;
            this.colSHIFT_ID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colSHIFT_BEGIN
            // 
            this.colSHIFT_BEGIN.Caption = "Đầu ca";
            this.colSHIFT_BEGIN.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colSHIFT_BEGIN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSHIFT_BEGIN.FieldName = "SHIFT_BEGIN";
            this.colSHIFT_BEGIN.Name = "colSHIFT_BEGIN";
            this.colSHIFT_BEGIN.OptionsColumn.AllowEdit = false;
            this.colSHIFT_BEGIN.OptionsColumn.AllowFocus = false;
            this.colSHIFT_BEGIN.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colSHIFT_BEGIN.Visible = true;
            this.colSHIFT_BEGIN.VisibleIndex = 2;
            this.colSHIFT_BEGIN.Width = 148;
            // 
            // colSHIFT_END
            // 
            this.colSHIFT_END.Caption = "Cuối ca";
            this.colSHIFT_END.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colSHIFT_END.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSHIFT_END.FieldName = "SHIFT_END";
            this.colSHIFT_END.Name = "colSHIFT_END";
            this.colSHIFT_END.OptionsColumn.AllowEdit = false;
            this.colSHIFT_END.OptionsColumn.AllowFocus = false;
            this.colSHIFT_END.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colSHIFT_END.Visible = true;
            this.colSHIFT_END.VisibleIndex = 3;
            this.colSHIFT_END.Width = 153;
            // 
            // colSHI_TYPE_ID
            // 
            this.colSHI_TYPE_ID.Caption = "Ca";
            this.colSHI_TYPE_ID.ColumnEdit = this.rileShiftType;
            this.colSHI_TYPE_ID.FieldName = "SHI_TYPE_ID";
            this.colSHI_TYPE_ID.Name = "colSHI_TYPE_ID";
            this.colSHI_TYPE_ID.OptionsColumn.AllowEdit = false;
            this.colSHI_TYPE_ID.OptionsColumn.AllowFocus = false;
            this.colSHI_TYPE_ID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colSHI_TYPE_ID.Visible = true;
            this.colSHI_TYPE_ID.VisibleIndex = 1;
            this.colSHI_TYPE_ID.Width = 148;
            // 
            // rileShiftType
            // 
            this.rileShiftType.AutoHeight = false;
            this.rileShiftType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rileShiftType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SHI_TYPE_NAME", "Ca"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SHI_TYPE_DESC", "Chú thích")});
            this.rileShiftType.DataSource = this.bsShiftType;
            this.rileShiftType.DisplayMember = "SHI_TYPE_NAME";
            this.rileShiftType.Name = "rileShiftType";
            this.rileShiftType.ValueMember = "SHI_TYPE_ID";
            // 
            // bsShiftType
            // 
            this.bsShiftType.DataMember = "shift_type";
            this.bsShiftType.DataSource = this.dsReview;
            // 
            // colUSER_INFO_ID
            // 
            this.colUSER_INFO_ID.FieldName = "USER_INFO_ID";
            this.colUSER_INFO_ID.Name = "colUSER_INFO_ID";
            this.colUSER_INFO_ID.OptionsColumn.AllowEdit = false;
            this.colUSER_INFO_ID.OptionsColumn.AllowFocus = false;
            this.colUSER_INFO_ID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colCreateDate
            // 
            this.colCreateDate.FieldName = "CreateDate";
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.OptionsColumn.AllowEdit = false;
            this.colCreateDate.OptionsColumn.AllowFocus = false;
            this.colCreateDate.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colModifyDate
            // 
            this.colModifyDate.FieldName = "ModifyDate";
            this.colModifyDate.Name = "colModifyDate";
            this.colModifyDate.OptionsColumn.AllowEdit = false;
            this.colModifyDate.OptionsColumn.AllowFocus = false;
            this.colModifyDate.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colSelected
            // 
            this.colSelected.Caption = " ";
            this.colSelected.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colSelected.FieldName = "Selected";
            this.colSelected.Name = "colSelected";
            this.colSelected.OptionsFilter.AllowAutoFilter = false;
            this.colSelected.OptionsFilter.AllowFilter = false;
            this.colSelected.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.colSelected.Visible = true;
            this.colSelected.VisibleIndex = 0;
            this.colSelected.Width = 25;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // rileUserInfo
            // 
            this.rileUserInfo.AutoHeight = false;
            this.rileUserInfo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rileUserInfo.DataSource = this.bsUserInfo;
            this.rileUserInfo.DisplayMember = "USER_INFO_FULL";
            this.rileUserInfo.Name = "rileUserInfo";
            this.rileUserInfo.ValueMember = "USER_INFO_ID";
            // 
            // bsUserInfo
            // 
            this.bsUserInfo.DataMember = "user_info";
            this.bsUserInfo.DataSource = this.dsReview;
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
            this.mDevXGroupControl2.Text = "Thông tin ca";
            // 
            // glueShiftType
            // 
            this.glueShiftType.AutoGetData = true;
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
            this.glueShiftType.EditValueChanged += new System.EventHandler(this.dateRange1_EditValueChanged);
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
            // ChangeShiftSummaryParameterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(513, 383);
            this.Controls.Add(this.mDevXGroupControl2);
            this.Controls.Add(this.chkCheckedAllUser);
            this.Controls.Add(this.mDevXGroupControl1);
            this.Name = "ChangeShiftSummaryParameterForm";
            this.Load += new System.EventHandler(this.ChangeShiftParameterForm_Load);
            this.Shown += new System.EventHandler(this.ChangeShiftSummaryParameterForm_Shown);
            this.Controls.SetChildIndex(this.dateRange1, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.mDevXGroupControl1, 0);
            this.Controls.SetChildIndex(this.chkCheckedAllUser, 0);
            this.Controls.SetChildIndex(this.mDevXGroupControl2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.mDevXGroupControl1)).EndInit();
            this.mDevXGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcUserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rileShiftType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsShiftType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rileUserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUserInfo)).EndInit();
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
        private System.Windows.Forms.BindingSource bsShift;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.CheckEdit chkCheckedAllUser;
        private DevExpress.XtraEditors.GroupControl mDevXGroupControl2;
        private CDControl.CDGridLookUpEdit glueShiftType;
        private DevExpress.XtraGrid.Views.Grid.GridView mDevXGridLookUpEdit1View;
        private CDControl.CDLabel label1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.BindingSource bsUserInfo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rileUserInfo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rileShiftType;
        private DevExpress.XtraGrid.Columns.GridColumn colSHIFT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colSHIFT_BEGIN;
        private DevExpress.XtraGrid.Columns.GridColumn colSHIFT_END;
        private DevExpress.XtraGrid.Columns.GridColumn colSHI_TYPE_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_INFO_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSelected;

    }
}
