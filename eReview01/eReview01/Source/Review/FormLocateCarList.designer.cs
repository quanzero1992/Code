namespace eReview01.Source.Review
{
    partial class FormLocateCarList
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtVehNum = new DevExpress.XtraEditors.ButtonEdit();
            this.txtCode = new DevExpress.XtraEditors.ButtonEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.lueVehType = new DevExpress.XtraEditors.LookUpEdit();
            this.bsVehType = new System.Windows.Forms.BindingSource(this.components);
            this.dsAccounting = new Entities.DatasetReview();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdBill = new eReview01.CDControl.CDGrid();
            this.bsLocalCar = new System.Windows.Forms.BindingSource(this.components);
            this.grdBillView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBillID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBILL_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBILL_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCus_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCus_Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBILL_PRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVEH_TYPE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVEH_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserSell = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoVehType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repoUser = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVehNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueVehType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAccounting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLocalCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBillView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoVehType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtVehNum);
            this.panelControl2.Controls.Add(this.txtCode);
            this.panelControl2.Controls.Add(this.label4);
            this.panelControl2.Controls.Add(this.lueVehType);
            this.panelControl2.Controls.Add(this.btnSearch);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 24);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(934, 33);
            this.panelControl2.TabIndex = 7;
            // 
            // txtVehNum
            // 
            this.txtVehNum.Location = new System.Drawing.Point(283, 6);
            this.txtVehNum.Name = "txtVehNum";
            this.txtVehNum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.txtVehNum.Size = new System.Drawing.Size(105, 20);
            this.txtVehNum.TabIndex = 13;
            this.txtVehNum.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtVehNum_ButtonPressed);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(81, 6);
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.txtCode.Properties.MaxLength = 15;
            this.txtCode.Size = new System.Drawing.Size(107, 20);
            this.txtCode.TabIndex = 12;
            this.txtCode.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtCode_ButtonPressed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Loại xe";
            // 
            // lueVehType
            // 
            this.lueVehType.Location = new System.Drawing.Point(475, 6);
            this.lueVehType.Name = "lueVehType";
            this.lueVehType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lueVehType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.lueVehType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VEH_TYPE_NAME", "Tên loại xe"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VEH_TYPE_DESC", "Mô tả")});
            this.lueVehType.Properties.DataSource = this.bsVehType;
            this.lueVehType.Properties.DisplayMember = "VEH_TYPE_NAME";
            this.lueVehType.Properties.NullText = "Tất cả";
            this.lueVehType.Properties.ShowFooter = false;
            this.lueVehType.Properties.ShowHeader = false;
            this.lueVehType.Properties.ValueMember = "VEH_TYPE_ID";
            this.lueVehType.Size = new System.Drawing.Size(129, 20);
            this.lueVehType.TabIndex = 10;
            this.lueVehType.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.lueVehType_ButtonPressed);
            // 
            // bsVehType
            // 
            this.bsVehType.DataMember = "vehicle_type";
            this.bsVehType.DataSource = this.dsAccounting;
            this.bsVehType.Filter = "VEH_TYPE_ID > 0";
            // 
            // dsAccounting
            // 
            this.dsAccounting.DataSetName = "DatasetAccounting";
            this.dsAccounting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(654, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Biển số xe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã biên bản";
            // 
            // grdBill
            // 
            this.grdBill.AutoGetData = false;
            this.grdBill.BindingType = eReview01.CommonUI.Enumeration.EnumBindingType.None;
            this.grdBill.ContextMenuStrip = this.cmsBase;
            this.grdBill.DataSource = this.bsLocalCar;
            this.grdBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBill.Location = new System.Drawing.Point(0, 57);
            this.grdBill.MainView = this.grdBillView;
            this.grdBill.Name = "grdBill";
            this.grdBill.OrderBy = null;
            this.grdBill.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoVehType,
            this.repoUser});
            this.grdBill.Size = new System.Drawing.Size(934, 296);
            this.grdBill.TabIndex = 8;
            this.grdBill.TableNameEnum = eReview01.CommonUI.Enumeration.EnumTableName.None;
            this.grdBill.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdBillView});
            this.grdBill.WhereCause = null;
            // 
            // bsLocalCar
            // 
            this.bsLocalCar.DataMember = "local_car";
            this.bsLocalCar.DataSource = this.dsAccounting;
            // 
            // grdBillView
            // 
            this.grdBillView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBillID,
            this.colBILL_CODE,
            this.colBILL_DATE,
            this.colCus_Name,
            this.colCus_Address,
            this.colBILL_PRICE,
            this.colVEH_TYPE_ID,
            this.colVEH_CODE,
            this.colUserSell});
            this.grdBillView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.grdBillView.GridControl = this.grdBill;
            this.grdBillView.Name = "grdBillView";
            this.grdBillView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdBillView.OptionsView.ShowGroupPanel = false;
            // 
            // colBillID
            // 
            this.colBillID.Caption = "Mã biên bản";
            this.colBillID.FieldName = "BillID";
            this.colBillID.Name = "colBillID";
            this.colBillID.OptionsColumn.AllowEdit = false;
            this.colBillID.OptionsColumn.AllowFocus = false;
            this.colBillID.OptionsFilter.AllowAutoFilter = false;
            this.colBillID.OptionsFilter.AllowFilter = false;
            this.colBillID.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.colBillID.Visible = true;
            this.colBillID.VisibleIndex = 0;
            // 
            // colBILL_CODE
            // 
            this.colBILL_CODE.Caption = "ID";
            this.colBILL_CODE.FieldName = "ID";
            this.colBILL_CODE.Name = "colBILL_CODE";
            this.colBILL_CODE.OptionsColumn.AllowEdit = false;
            this.colBILL_CODE.OptionsColumn.AllowFocus = false;
            this.colBILL_CODE.OptionsFilter.AllowAutoFilter = false;
            this.colBILL_CODE.OptionsFilter.AllowFilter = false;
            this.colBILL_CODE.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.colBILL_CODE.Width = 102;
            // 
            // colBILL_DATE
            // 
            this.colBILL_DATE.Caption = "Ngày nhập";
            this.colBILL_DATE.FieldName = "DateSign";
            this.colBILL_DATE.Name = "colBILL_DATE";
            this.colBILL_DATE.OptionsColumn.AllowEdit = false;
            this.colBILL_DATE.OptionsColumn.AllowFocus = false;
            this.colBILL_DATE.OptionsFilter.AllowAutoFilter = false;
            this.colBILL_DATE.OptionsFilter.AllowFilter = false;
            this.colBILL_DATE.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.colBILL_DATE.Visible = true;
            this.colBILL_DATE.VisibleIndex = 1;
            this.colBILL_DATE.Width = 104;
            // 
            // colCus_Name
            // 
            this.colCus_Name.Caption = "Chủ phương tiện";
            this.colCus_Name.FieldName = "OwnerCarName";
            this.colCus_Name.Name = "colCus_Name";
            this.colCus_Name.OptionsColumn.AllowEdit = false;
            this.colCus_Name.OptionsColumn.AllowFocus = false;
            this.colCus_Name.OptionsFilter.AllowAutoFilter = false;
            this.colCus_Name.OptionsFilter.AllowFilter = false;
            this.colCus_Name.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.colCus_Name.Visible = true;
            this.colCus_Name.VisibleIndex = 4;
            this.colCus_Name.Width = 133;
            // 
            // colCus_Address
            // 
            this.colCus_Address.Caption = "Địa chỉ";
            this.colCus_Address.FieldName = "Address";
            this.colCus_Address.Name = "colCus_Address";
            this.colCus_Address.OptionsColumn.AllowEdit = false;
            this.colCus_Address.OptionsColumn.AllowFocus = false;
            this.colCus_Address.OptionsFilter.AllowAutoFilter = false;
            this.colCus_Address.OptionsFilter.AllowFilter = false;
            this.colCus_Address.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.colCus_Address.Visible = true;
            this.colCus_Address.VisibleIndex = 5;
            this.colCus_Address.Width = 244;
            // 
            // colBILL_PRICE
            // 
            this.colBILL_PRICE.Caption = "Thành tiền";
            this.colBILL_PRICE.Name = "colBILL_PRICE";
            this.colBILL_PRICE.OptionsColumn.AllowEdit = false;
            this.colBILL_PRICE.OptionsColumn.AllowFocus = false;
            this.colBILL_PRICE.OptionsFilter.AllowAutoFilter = false;
            this.colBILL_PRICE.OptionsFilter.AllowFilter = false;
            this.colBILL_PRICE.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.colBILL_PRICE.Width = 107;
            // 
            // colVEH_TYPE_ID
            // 
            this.colVEH_TYPE_ID.Caption = "Loại xe";
            this.colVEH_TYPE_ID.FieldName = "VehType";
            this.colVEH_TYPE_ID.Name = "colVEH_TYPE_ID";
            this.colVEH_TYPE_ID.OptionsColumn.AllowEdit = false;
            this.colVEH_TYPE_ID.OptionsColumn.AllowFocus = false;
            this.colVEH_TYPE_ID.OptionsFilter.AllowAutoFilter = false;
            this.colVEH_TYPE_ID.OptionsFilter.AllowFilter = false;
            this.colVEH_TYPE_ID.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.colVEH_TYPE_ID.Visible = true;
            this.colVEH_TYPE_ID.VisibleIndex = 3;
            this.colVEH_TYPE_ID.Width = 68;
            // 
            // colVEH_CODE
            // 
            this.colVEH_CODE.Caption = "Biển số xe";
            this.colVEH_CODE.FieldName = "PlateNumber";
            this.colVEH_CODE.Name = "colVEH_CODE";
            this.colVEH_CODE.OptionsColumn.AllowEdit = false;
            this.colVEH_CODE.OptionsColumn.AllowFocus = false;
            this.colVEH_CODE.OptionsFilter.AllowAutoFilter = false;
            this.colVEH_CODE.OptionsFilter.AllowFilter = false;
            this.colVEH_CODE.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.colVEH_CODE.Visible = true;
            this.colVEH_CODE.VisibleIndex = 2;
            this.colVEH_CODE.Width = 111;
            // 
            // colUserSell
            // 
            this.colUserSell.Caption = "Người Nhập";
            this.colUserSell.FieldName = "UserInput";
            this.colUserSell.Name = "colUserSell";
            this.colUserSell.OptionsColumn.AllowEdit = false;
            this.colUserSell.OptionsColumn.AllowFocus = false;
            this.colUserSell.Visible = true;
            this.colUserSell.VisibleIndex = 6;
            this.colUserSell.Width = 154;
            // 
            // repoVehType
            // 
            this.repoVehType.AutoHeight = false;
            this.repoVehType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoVehType.DisplayMember = "VEH_TYPE_NAME";
            this.repoVehType.Name = "repoVehType";
            this.repoVehType.NullText = "";
            this.repoVehType.ValueMember = "VEH_TYPE_ID";
            // 
            // repoUser
            // 
            this.repoUser.AutoHeight = false;
            this.repoUser.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoUser.DisplayMember = "USER_INFO_FULL";
            this.repoUser.Name = "repoUser";
            this.repoUser.NullText = "";
            this.repoUser.ValueMember = "USER_INFO_ID";
            // 
            // FormLocateCarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 353);
            this.Controls.Add(this.grdBill);
            this.Controls.Add(this.panelControl2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormLocateCarList";
            this.Tag = "FormLocateCarList";
            this.Text = "Danh sách xe địa phương";
            this.Activated += new System.EventHandler(this.FormLocateCarList_Activated);
            this.Controls.SetChildIndex(this.panelControl2, 0);
            this.Controls.SetChildIndex(this.grdBill, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVehNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueVehType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAccounting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLocalCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBillView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoVehType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.ButtonEdit txtVehNum;
        private DevExpress.XtraEditors.ButtonEdit txtCode;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.LookUpEdit lueVehType;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CDControl.CDGrid grdBill;
        private DevExpress.XtraGrid.Views.Grid.GridView grdBillView;
        private DevExpress.XtraGrid.Columns.GridColumn colBILL_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colBILL_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colCus_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colCus_Address;
        private DevExpress.XtraGrid.Columns.GridColumn colBILL_PRICE;
        private DevExpress.XtraGrid.Columns.GridColumn colVEH_TYPE_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoVehType;
        private DevExpress.XtraGrid.Columns.GridColumn colVEH_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colUserSell;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoUser;
        private Entities.DatasetReview dsAccounting;
        private System.Windows.Forms.BindingSource bsLocalCar;
        private DevExpress.XtraGrid.Columns.GridColumn colBillID;
        private System.Windows.Forms.BindingSource bsVehType;
    }
}