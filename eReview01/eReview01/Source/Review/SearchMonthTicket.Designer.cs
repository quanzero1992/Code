namespace eReview01.Source.Review
{
    partial class SearchMonthTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchMonthTicket));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new eReview01.CDControl.CDButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dsReview = new eReview01.Entities.DatasetReview();
            this.cdGrid1 = new eReview01.CDControl.CDGrid();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBILL_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCus_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBILL_PRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTICK_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBEGIN_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEND_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVEH_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBILL_USERSELL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsUser = new System.Windows.Forms.BindingSource(this.components);
            this.colTICK_TYPE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsTicketType = new System.Windows.Forms.BindingSource(this.components);
            this.txtSearchText = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTicketType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchText.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biển số hoặc số vé";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearch
            // 
            this.btnSearch.BindingType = eReview01.CommonUI.Enumeration.EnumBindingType.None;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(304, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblStatus.ForeColor = System.Drawing.Color.Blue;
            this.lblStatus.Location = new System.Drawing.Point(8, 40);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(696, 24);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Tag = "Trạng thái: {0}";
            this.lblStatus.Text = "Trạng thái:";
            // 
            // dsReview
            // 
            this.dsReview.DataSetName = "DatasetReview";
            this.dsReview.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cdGrid1
            // 
            this.cdGrid1.AutoGetData = false;
            this.cdGrid1.BindingType = eReview01.CommonUI.Enumeration.EnumBindingType.None;
            this.cdGrid1.DataMember = "ticket_bill";
            this.cdGrid1.DataSource = this.dsReview;
            this.cdGrid1.Location = new System.Drawing.Point(8, 72);
            this.cdGrid1.MainView = this.gridView1;
            this.cdGrid1.Name = "cdGrid1";
            this.cdGrid1.OrderBy = null;
            this.cdGrid1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2});
            this.cdGrid1.Size = new System.Drawing.Size(809, 360);
            this.cdGrid1.TabIndex = 3;
            this.cdGrid1.TableNameEnum = eReview01.CommonUI.Enumeration.EnumTableName.None;
            this.cdGrid1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.cdGrid1.WhereCause = null;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBILL_DATE,
            this.colCus_Name,
            this.colBILL_PRICE,
            this.colTICK_CODE,
            this.colBEGIN_DATE,
            this.colEND_DATE,
            this.colVEH_CODE,
            this.colBILL_USERSELL,
            this.colTICK_TYPE_ID});
            this.gridView1.GridControl = this.cdGrid1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colBILL_DATE
            // 
            this.colBILL_DATE.Caption = "Ngày bán";
            this.colBILL_DATE.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colBILL_DATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colBILL_DATE.FieldName = "BILL_DATE";
            this.colBILL_DATE.Name = "colBILL_DATE";
            this.colBILL_DATE.OptionsColumn.AllowEdit = false;
            this.colBILL_DATE.OptionsColumn.AllowFocus = false;
            this.colBILL_DATE.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colBILL_DATE.Visible = true;
            this.colBILL_DATE.VisibleIndex = 4;
            this.colBILL_DATE.Width = 79;
            // 
            // colCus_Name
            // 
            this.colCus_Name.Caption = "Loại xe";
            this.colCus_Name.FieldName = "VEH_TYPE_ID";
            this.colCus_Name.Name = "colCus_Name";
            this.colCus_Name.OptionsColumn.AllowEdit = false;
            this.colCus_Name.OptionsColumn.AllowFocus = false;
            this.colCus_Name.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colCus_Name.Visible = true;
            this.colCus_Name.VisibleIndex = 3;
            this.colCus_Name.Width = 51;
            // 
            // colBILL_PRICE
            // 
            this.colBILL_PRICE.Caption = "Giá vé";
            this.colBILL_PRICE.DisplayFormat.FormatString = "#,#";
            this.colBILL_PRICE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBILL_PRICE.FieldName = "BILL_PRICE";
            this.colBILL_PRICE.Name = "colBILL_PRICE";
            this.colBILL_PRICE.OptionsColumn.AllowEdit = false;
            this.colBILL_PRICE.OptionsColumn.AllowFocus = false;
            this.colBILL_PRICE.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colBILL_PRICE.Visible = true;
            this.colBILL_PRICE.VisibleIndex = 5;
            this.colBILL_PRICE.Width = 78;
            // 
            // colTICK_CODE
            // 
            this.colTICK_CODE.Caption = "Mã vé";
            this.colTICK_CODE.FieldName = "TICK_CODE";
            this.colTICK_CODE.Name = "colTICK_CODE";
            this.colTICK_CODE.OptionsColumn.AllowEdit = false;
            this.colTICK_CODE.OptionsColumn.AllowFocus = false;
            this.colTICK_CODE.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colTICK_CODE.Visible = true;
            this.colTICK_CODE.VisibleIndex = 0;
            this.colTICK_CODE.Width = 116;
            // 
            // colBEGIN_DATE
            // 
            this.colBEGIN_DATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colBEGIN_DATE.AppearanceCell.Options.UseFont = true;
            this.colBEGIN_DATE.Caption = "Ngày bắt đầu";
            this.colBEGIN_DATE.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colBEGIN_DATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colBEGIN_DATE.FieldName = "BEGIN_DATE";
            this.colBEGIN_DATE.Name = "colBEGIN_DATE";
            this.colBEGIN_DATE.OptionsColumn.AllowEdit = false;
            this.colBEGIN_DATE.OptionsColumn.AllowFocus = false;
            this.colBEGIN_DATE.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colBEGIN_DATE.Visible = true;
            this.colBEGIN_DATE.VisibleIndex = 6;
            this.colBEGIN_DATE.Width = 82;
            // 
            // colEND_DATE
            // 
            this.colEND_DATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colEND_DATE.AppearanceCell.Options.UseFont = true;
            this.colEND_DATE.Caption = "Ngày hết hiệu lực";
            this.colEND_DATE.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colEND_DATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colEND_DATE.FieldName = "END_DATE";
            this.colEND_DATE.Name = "colEND_DATE";
            this.colEND_DATE.OptionsColumn.AllowEdit = false;
            this.colEND_DATE.OptionsColumn.AllowFocus = false;
            this.colEND_DATE.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colEND_DATE.Visible = true;
            this.colEND_DATE.VisibleIndex = 7;
            this.colEND_DATE.Width = 92;
            // 
            // colVEH_CODE
            // 
            this.colVEH_CODE.Caption = "Biển số";
            this.colVEH_CODE.FieldName = "VEH_CODE";
            this.colVEH_CODE.Name = "colVEH_CODE";
            this.colVEH_CODE.OptionsColumn.AllowEdit = false;
            this.colVEH_CODE.OptionsColumn.AllowFocus = false;
            this.colVEH_CODE.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colVEH_CODE.Visible = true;
            this.colVEH_CODE.VisibleIndex = 1;
            this.colVEH_CODE.Width = 82;
            // 
            // colBILL_USERSELL
            // 
            this.colBILL_USERSELL.Caption = "Người bán";
            this.colBILL_USERSELL.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colBILL_USERSELL.FieldName = "BILL_USERSELL";
            this.colBILL_USERSELL.Name = "colBILL_USERSELL";
            this.colBILL_USERSELL.OptionsColumn.AllowEdit = false;
            this.colBILL_USERSELL.OptionsColumn.AllowFocus = false;
            this.colBILL_USERSELL.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colBILL_USERSELL.Visible = true;
            this.colBILL_USERSELL.VisibleIndex = 8;
            this.colBILL_USERSELL.Width = 136;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("USER_INFO_FULL", "Người bán")});
            this.repositoryItemLookUpEdit1.DataSource = this.bsUser;
            this.repositoryItemLookUpEdit1.DisplayMember = "USER_INFO_FULL";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ValueMember = "USER_INFO_ID";
            // 
            // bsUser
            // 
            this.bsUser.DataMember = "user_info";
            this.bsUser.DataSource = this.dsReview;
            // 
            // colTICK_TYPE_ID
            // 
            this.colTICK_TYPE_ID.Caption = "Loại vé";
            this.colTICK_TYPE_ID.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colTICK_TYPE_ID.FieldName = "TICK_IMP_TYPE";
            this.colTICK_TYPE_ID.Name = "colTICK_TYPE_ID";
            this.colTICK_TYPE_ID.OptionsColumn.AllowEdit = false;
            this.colTICK_TYPE_ID.OptionsColumn.AllowFocus = false;
            this.colTICK_TYPE_ID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colTICK_TYPE_ID.Visible = true;
            this.colTICK_TYPE_ID.VisibleIndex = 2;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TICK_TYPE_NAME", "Loại vé")});
            this.repositoryItemLookUpEdit2.DataSource = this.bsTicketType;
            this.repositoryItemLookUpEdit2.DisplayMember = "Name";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.NullText = "";
            this.repositoryItemLookUpEdit2.ValueMember = "Id";
            // 
            // txtSearchText
            // 
            this.txtSearchText.Location = new System.Drawing.Point(110, 9);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearchText.Properties.MaxLength = 12;
            this.txtSearchText.Size = new System.Drawing.Size(187, 20);
            this.txtSearchText.TabIndex = 0;
            // 
            // SearchMonthTicket
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(823, 433);
            this.Controls.Add(this.txtSearchText);
            this.Controls.Add(this.cdGrid1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchMonthTicket";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tra cứu thông tin vé tháng - quý";
            this.Load += new System.EventHandler(this.SearchMonthTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsReview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTicketType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchText.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CDControl.CDButton btnSearch;
        private System.Windows.Forms.Label lblStatus;
        private Entities.DatasetReview dsReview;
        private CDControl.CDGrid cdGrid1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colBILL_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colCus_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colBILL_PRICE;
        private DevExpress.XtraGrid.Columns.GridColumn colTICK_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colBEGIN_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colEND_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colVEH_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colBILL_USERSELL;
        private DevExpress.XtraGrid.Columns.GridColumn colTICK_TYPE_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource bsUser;
        private System.Windows.Forms.BindingSource bsTicketType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraEditors.TextEdit txtSearchText;
    }
}
