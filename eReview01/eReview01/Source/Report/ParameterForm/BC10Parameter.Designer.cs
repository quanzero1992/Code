namespace eReview01.Source.Report.ParameterForm
{
    partial class BC10Parameter
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
            this.mDevXLabel1 = new eReview01.CDControl.CDLabel();
            this.bsUserInfo = new System.Windows.Forms.BindingSource();
            this.dsReview = new eReview01.Entities.DatasetReview();
            this.mDevXGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_INFO_FULL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.glueUser = new eReview01.CDControl.CDGridLookUpEdit();
            this.bsUserInfoEx = new System.Windows.Forms.BindingSource();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUSER_INFO_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsUserInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDevXGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glueUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUserInfoEx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dateRange1
            // 
            this.dateRange1.DateFormat = "dd/MM/yyyy";
            this.dateRange1.FromDate = new System.DateTime(2014, 8, 1, 0, 0, 0, 0);
            this.dateRange1.TimeFormat = "HH:mm:ss";
            this.dateRange1.ToDate = new System.DateTime(2014, 8, 31, 23, 59, 59, 0);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(231, 146);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(319, 146);
            // 
            // mDevXLabel1
            // 
            this.mDevXLabel1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.mDevXLabel1.Location = new System.Drawing.Point(214, 8);
            this.mDevXLabel1.Name = "mDevXLabel1";
            this.mDevXLabel1.Size = new System.Drawing.Size(77, 21);
            this.mDevXLabel1.TabIndex = 3;
            this.mDevXLabel1.Text = "&Tên nhân viên";
            // 
            // bsUserInfo
            // 
            this.bsUserInfo.DataMember = "user_info";
            this.bsUserInfo.DataSource = this.dsReview;
            // 
            // dsReview
            // 
            this.dsReview.DataSetName = "DataSetReview";
            this.dsReview.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mDevXGridLookUpEdit1View
            // 
            this.mDevXGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.colUSER_INFO_FULL,
            this.gridColumn1});
            this.mDevXGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.mDevXGridLookUpEdit1View.Name = "mDevXGridLookUpEdit1View";
            this.mDevXGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.mDevXGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Name = "gridColumn2";
            // 
            // colUSER_INFO_FULL
            // 
            this.colUSER_INFO_FULL.Caption = "Họ và tên";
            this.colUSER_INFO_FULL.FieldName = "USER_INFO_FULL";
            this.colUSER_INFO_FULL.Name = "colUSER_INFO_FULL";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // glueUser
            // 
            this.glueUser.AutoGetData = true;
            this.glueUser.BindingType = eReview01.CommonUI.Enumeration.EnumBindingType.None;
            this.glueUser.HasSelectAllItem = false;
            this.glueUser.Location = new System.Drawing.Point(214, 35);
            this.glueUser.Name = "glueUser";
            this.glueUser.OrderBy = null;
            this.glueUser.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.glueUser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.glueUser.Properties.DataSource = this.bsUserInfoEx;
            this.glueUser.Properties.DisplayMember = "USER_INFO_FULL";
            this.glueUser.Properties.NullText = "";
            this.glueUser.Properties.NullValuePrompt = "Hãy chọn nhân viên cho tra cứu thông tin";
            this.glueUser.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.glueUser.Properties.ValueMember = "USER_INFO_ID";
            this.glueUser.Properties.View = this.gridView2;
            this.glueUser.Size = new System.Drawing.Size(175, 20);
            this.glueUser.TabIndex = 12;
            this.glueUser.TableNameEnum = eReview01.CommonUI.Enumeration.EnumTableName.None;
            this.glueUser.WhereCause = null;
            // 
            // bsUserInfoEx
            // 
            this.bsUserInfoEx.DataMember = "user_info";
            this.bsUserInfoEx.DataSource = this.dsReview;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUSER_INFO_ID1,
            this.colUSER_INFO_FULL,
            this.gridColumn4});
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
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Họ và tên";
            this.gridColumn4.FieldName = "USER_INFO_FULL";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Name = "gridColumn3";
            // 
            // BC10Parameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(401, 178);
            this.Controls.Add(this.glueUser);
            this.Controls.Add(this.mDevXLabel1);
            this.Name = "BC10Parameter";
            this.Controls.SetChildIndex(this.mDevXLabel1, 0);
            this.Controls.SetChildIndex(this.dateRange1, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.glueUser, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bsUserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDevXGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glueUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUserInfoEx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CDControl.CDLabel mDevXLabel1;
        private DevExpress.XtraGrid.Views.Grid.GridView mDevXGridLookUpEdit1View;
        private Entities.DatasetReview dsReview;
        private System.Windows.Forms.BindingSource bsUserInfo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_INFO_FULL;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private CDControl.CDGridLookUpEdit glueUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_INFO_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.BindingSource bsUserInfoEx;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}
