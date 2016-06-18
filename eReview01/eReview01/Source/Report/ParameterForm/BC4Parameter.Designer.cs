namespace eReview01.Source.Report.ParameterForm
{
    partial class BC4Parameter
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
            this.glueLaneInfo = new eReview01.CDControl.CDGridLookUpEdit();
            this.mDevXGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dsReview = new eReview01.Entities.DatasetReview();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.glueLaneInfo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDevXGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReview)).BeginInit();
            this.SuspendLayout();
            // 
            // dateRange1
            // 
            this.dateRange1.DateFormat = "dd/MM/yyyy";
            this.dateRange1.FromDate = new System.DateTime(2014, 8, 1, 0, 0, 0, 0);
            this.dateRange1.ReportPeriod = eReview01.CommonUI.Enumeration.EnumReportPeriod.Today;
            this.dateRange1.TimeFormat = "HH:mm:ss";
            this.dateRange1.ToDate = new System.DateTime(2014, 8, 31, 23, 59, 59, 0);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(45, 170);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(133, 170);
            // 
            // mDevXLabel1
            // 
            this.mDevXLabel1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.mDevXLabel1.Location = new System.Drawing.Point(8, 144);
            this.mDevXLabel1.Name = "mDevXLabel1";
            this.mDevXLabel1.Size = new System.Drawing.Size(24, 21);
            this.mDevXLabel1.TabIndex = 3;
            this.mDevXLabel1.Text = "&Làn";
            // 
            // glueLaneInfo
            // 
            this.glueLaneInfo.AutoGetData = false;
            this.glueLaneInfo.BindingType = eReview01.CommonUI.Enumeration.EnumBindingType.None;
            this.glueLaneInfo.HasSelectAllItem = false;
            this.glueLaneInfo.Location = new System.Drawing.Point(32, 144);
            this.glueLaneInfo.Name = "glueLaneInfo";
            this.glueLaneInfo.OrderBy = null;
            this.glueLaneInfo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.glueLaneInfo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.glueLaneInfo.Properties.DisplayMember = "LANE_ID";
            this.glueLaneInfo.Properties.NullText = "<<Tất cả>>";
            this.glueLaneInfo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.glueLaneInfo.Properties.ValueMember = "LANE_ID";
            this.glueLaneInfo.Properties.View = this.mDevXGridLookUpEdit1View;
            this.glueLaneInfo.Size = new System.Drawing.Size(176, 20);
            this.glueLaneInfo.TabIndex = 4;
            this.glueLaneInfo.TableNameEnum = eReview01.CommonUI.Enumeration.EnumTableName.None;
            this.glueLaneInfo.WhereCause = null;
            // 
            // mDevXGridLookUpEdit1View
            // 
            this.mDevXGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn1,
            this.gridColumn3});
            this.mDevXGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.mDevXGridLookUpEdit1View.Name = "mDevXGridLookUpEdit1View";
            this.mDevXGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.mDevXGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Làn";
            this.gridColumn2.FieldName = "LANE_ID";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // dsReview
            // 
            this.dsReview.DataSetName = "DataSetReview";
            this.dsReview.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Chiều đi";
            this.gridColumn1.FieldName = "FROM";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Chiều đến";
            this.gridColumn3.FieldName = "TO";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // BC4Parameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(215, 202);
            this.Controls.Add(this.glueLaneInfo);
            this.Controls.Add(this.mDevXLabel1);
            this.Name = "BC4Parameter";
            this.Load += new System.EventHandler(this.BC4Parameter_Load);
            this.Controls.SetChildIndex(this.dateRange1, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.mDevXLabel1, 0);
            this.Controls.SetChildIndex(this.glueLaneInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.glueLaneInfo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDevXGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CDControl.CDLabel mDevXLabel1;
        private CDControl.CDGridLookUpEdit glueLaneInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView mDevXGridLookUpEdit1View;
        private Entities.DatasetReview dsReview;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}
