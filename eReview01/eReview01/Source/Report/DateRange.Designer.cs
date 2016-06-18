namespace eReview01.Source
{
    partial class DateRange
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mDevXGroupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.teToTime = new DevExpress.XtraEditors.TimeEdit();
            this.teFromTime = new DevExpress.XtraEditors.TimeEdit();
            this.mDevXLabel2 = new CDControl.CDLabel();
            this.deToDate = new DevExpress.XtraEditors.DateEdit();
            this.lueOption = new CDControl.CDLookUpEnum();
            this.mDevXLabel1 = new CDControl.CDLabel();
            this.deFromDate = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.mDevXGroupControl1)).BeginInit();
            this.mDevXGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teToTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFromTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueOption.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFromDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mDevXGroupControl1
            // 
            this.mDevXGroupControl1.Controls.Add(this.teToTime);
            this.mDevXGroupControl1.Controls.Add(this.teFromTime);
            this.mDevXGroupControl1.Controls.Add(this.mDevXLabel2);
            this.mDevXGroupControl1.Controls.Add(this.deToDate);
            this.mDevXGroupControl1.Controls.Add(this.lueOption);
            this.mDevXGroupControl1.Controls.Add(this.mDevXLabel1);
            this.mDevXGroupControl1.Controls.Add(this.deFromDate);
            this.mDevXGroupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mDevXGroupControl1.Location = new System.Drawing.Point(0, 0);
            this.mDevXGroupControl1.Name = "mDevXGroupControl1";
            this.mDevXGroupControl1.Size = new System.Drawing.Size(201, 125);
            this.mDevXGroupControl1.TabIndex = 0;
            this.mDevXGroupControl1.Text = "Kỳ báo cáo";
            // 
            // teToTime
            // 
            this.teToTime.EditValue = new System.DateTime(2014, 7, 23, 0, 0, 0, 0);
            this.teToTime.Location = new System.Drawing.Point(104, 96);
            this.teToTime.Name = "teToTime";
            this.teToTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.teToTime.Properties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.teToTime.Properties.DisplayFormat.FormatString = "HH:mm:ss";
            this.teToTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.teToTime.Properties.EditFormat.FormatString = "HH:mm:ss";
            this.teToTime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.teToTime.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.teToTime.Size = new System.Drawing.Size(88, 20);
            this.teToTime.TabIndex = 6;
            this.teToTime.EditValueChanged += new System.EventHandler(this.deFromDate_EditValueChanged);
            this.teToTime.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.teFromTime_EditValueChanging);
            // 
            // teFromTime
            // 
            this.teFromTime.EditValue = new System.DateTime(2014, 7, 23, 0, 0, 0, 0);
            this.teFromTime.Location = new System.Drawing.Point(8, 96);
            this.teFromTime.Name = "teFromTime";
            this.teFromTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.teFromTime.Properties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.teFromTime.Properties.DisplayFormat.FormatString = "HH:mm:ss";
            this.teFromTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.teFromTime.Properties.EditFormat.FormatString = "HH:mm:ss";
            this.teFromTime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.teFromTime.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.teFromTime.Size = new System.Drawing.Size(88, 20);
            this.teFromTime.TabIndex = 5;
            this.teFromTime.EditValueChanged += new System.EventHandler(this.deFromDate_EditValueChanged);
            this.teFromTime.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.teFromTime_EditValueChanging);
            // 
            // mDevXLabel2
            // 
            this.mDevXLabel2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.mDevXLabel2.Location = new System.Drawing.Point(104, 48);
            this.mDevXLabel2.Name = "mDevXLabel2";
            this.mDevXLabel2.Size = new System.Drawing.Size(56, 21);
            this.mDevXLabel2.TabIndex = 2;
            this.mDevXLabel2.Text = "Đến ngày";
            // 
            // deToDate
            // 
            this.deToDate.EditValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.deToDate.Location = new System.Drawing.Point(104, 72);
            this.deToDate.Name = "deToDate";
            this.deToDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.deToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deToDate.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.deToDate.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.deToDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.deToDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deToDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.deToDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deToDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.deToDate.Properties.MinValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.deToDate.Properties.NullDate = new System.DateTime(2000, 1, 1, 15, 57, 54, 0);
            this.deToDate.Size = new System.Drawing.Size(88, 20);
            this.deToDate.TabIndex = 4;
            this.deToDate.EditValueChanged += new System.EventHandler(this.deFromDate_EditValueChanged);
            this.deToDate.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.deFromDate_EditValueChanging);
            // 
            // lueOption
            // 
            this.lueOption.AutoGetData = true;
            this.lueOption.EnumString = eReview01.CommonUI.Enumeration.EnumType.EnumReportPeriod;
            this.lueOption.HasSelectAllItem = false;
            this.lueOption.Location = new System.Drawing.Point(8, 24);
            this.lueOption.Name = "lueOption";
            this.lueOption.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueOption.Properties.NullText = "";
            this.lueOption.Size = new System.Drawing.Size(184, 20);
            this.lueOption.TabIndex = 0;
            this.lueOption.EditValueChanged += new System.EventHandler(this.lueOptionValue_EditValueChanged);
            // 
            // mDevXLabel1
            // 
            this.mDevXLabel1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.mDevXLabel1.Location = new System.Drawing.Point(8, 48);
            this.mDevXLabel1.Name = "mDevXLabel1";
            this.mDevXLabel1.Size = new System.Drawing.Size(48, 21);
            this.mDevXLabel1.TabIndex = 1;
            this.mDevXLabel1.Text = "Từ ngày";
            // 
            // deFromDate
            // 
            this.deFromDate.EditValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.deFromDate.Location = new System.Drawing.Point(8, 72);
            this.deFromDate.Name = "deFromDate";
            this.deFromDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.deFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFromDate.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.deFromDate.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.deFromDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.deFromDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deFromDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.deFromDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deFromDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.deFromDate.Properties.MinValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.deFromDate.Properties.NullDate = new System.DateTime(2000, 1, 1, 15, 57, 54, 0);
            this.deFromDate.Size = new System.Drawing.Size(88, 20);
            this.deFromDate.TabIndex = 3;
            this.deFromDate.EditValueChanged += new System.EventHandler(this.deFromDate_EditValueChanged);
            this.deFromDate.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.deFromDate_EditValueChanging);
            // 
            // DateRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mDevXGroupControl1);
            this.Name = "DateRange";
            this.Size = new System.Drawing.Size(201, 125);
            this.Load += new System.EventHandler(this.DateRange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mDevXGroupControl1)).EndInit();
            this.mDevXGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teToTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFromTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueOption.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFromDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl mDevXGroupControl1;
        private CDControl.CDLabel mDevXLabel2;
        private DevExpress.XtraEditors.DateEdit deToDate;
        private CDControl.CDLookUpEnum lueOption;
        private CDControl.CDLabel mDevXLabel1;
        private DevExpress.XtraEditors.DateEdit deFromDate;
        private DevExpress.XtraEditors.TimeEdit teToTime;
        private DevExpress.XtraEditors.TimeEdit teFromTime;
    }
}
