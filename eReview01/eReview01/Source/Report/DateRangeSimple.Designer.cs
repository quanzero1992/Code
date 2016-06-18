namespace eReview01.Source
{
    partial class DateRangeSimple
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
            this.teToTime = new DevExpress.XtraEditors.TimeEdit();
            this.teFromTime = new DevExpress.XtraEditors.TimeEdit();
            this.mDevXLabel2 = new eReview01.CDControl.CDLabel();
            this.deToDate = new DevExpress.XtraEditors.DateEdit();
            this.mDevXLabel1 = new eReview01.CDControl.CDLabel();
            this.deFromDate = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.teToTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFromTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFromDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // teToTime
            // 
            this.teToTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teToTime.EditValue = new System.DateTime(2014, 7, 23, 0, 0, 0, 0);
            this.teToTime.Location = new System.Drawing.Point(368, 0);
            this.teToTime.Name = "teToTime";
            this.teToTime.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.teToTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.teToTime.Properties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.teToTime.Properties.DisplayFormat.FormatString = "HH:mm:ss";
            this.teToTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.teToTime.Properties.EditFormat.FormatString = "HH:mm:ss";
            this.teToTime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.teToTime.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.teToTime.Size = new System.Drawing.Size(88, 20);
            this.teToTime.TabIndex = 5;
            this.teToTime.EditValueChanged += new System.EventHandler(this.deFromDate_EditValueChanged);
            this.teToTime.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.teFromTime_EditValueChanging);
            // 
            // teFromTime
            // 
            this.teFromTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teFromTime.EditValue = new System.DateTime(2014, 7, 23, 0, 0, 0, 0);
            this.teFromTime.Location = new System.Drawing.Point(136, 0);
            this.teFromTime.Name = "teFromTime";
            this.teFromTime.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.teFromTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.teFromTime.Properties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.teFromTime.Properties.DisplayFormat.FormatString = "HH:mm:ss";
            this.teFromTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.teFromTime.Properties.EditFormat.FormatString = "HH:mm:ss";
            this.teFromTime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.teFromTime.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.teFromTime.Size = new System.Drawing.Size(72, 20);
            this.teFromTime.TabIndex = 2;
            this.teFromTime.EditValueChanged += new System.EventHandler(this.deFromDate_EditValueChanged);
            this.teFromTime.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.teFromTime_EditValueChanging);
            // 
            // mDevXLabel2
            // 
            this.mDevXLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mDevXLabel2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.mDevXLabel2.Location = new System.Drawing.Point(224, 0);
            this.mDevXLabel2.Name = "mDevXLabel2";
            this.mDevXLabel2.Size = new System.Drawing.Size(56, 21);
            this.mDevXLabel2.TabIndex = 3;
            this.mDevXLabel2.Text = "Đến ngày";
            // 
            // deToDate
            // 
            this.deToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deToDate.EditValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.deToDate.Location = new System.Drawing.Point(280, 0);
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
            this.deToDate.Properties.MinValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.deToDate.Properties.NullDate = new System.DateTime(2000, 1, 1, 15, 55, 52, 0);
            this.deToDate.Size = new System.Drawing.Size(80, 20);
            this.deToDate.TabIndex = 4;
            this.deToDate.EditValueChanged += new System.EventHandler(this.deFromDate_EditValueChanged);
            this.deToDate.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.deFromDate_EditValueChanging);
            // 
            // mDevXLabel1
            // 
            this.mDevXLabel1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.mDevXLabel1.Location = new System.Drawing.Point(0, 0);
            this.mDevXLabel1.Name = "mDevXLabel1";
            this.mDevXLabel1.Size = new System.Drawing.Size(48, 21);
            this.mDevXLabel1.TabIndex = 0;
            this.mDevXLabel1.Text = "Từ ngày";
            // 
            // deFromDate
            // 
            this.deFromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deFromDate.EditValue = new System.DateTime(2000, 1, 1, 15, 56, 9, 0);
            this.deFromDate.Location = new System.Drawing.Point(48, 0);
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
            this.deFromDate.Properties.MinValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.deFromDate.Properties.NullDate = new System.DateTime(2000, 1, 1, 15, 56, 9, 0);
            this.deFromDate.Size = new System.Drawing.Size(80, 20);
            this.deFromDate.TabIndex = 1;
            this.deFromDate.EditValueChanged += new System.EventHandler(this.deFromDate_EditValueChanged);
            this.deFromDate.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.deFromDate_EditValueChanging);
            // 
            // DateRangeSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.teToTime);
            this.Controls.Add(this.teFromTime);
            this.Controls.Add(this.mDevXLabel2);
            this.Controls.Add(this.deToDate);
            this.Controls.Add(this.mDevXLabel1);
            this.Controls.Add(this.deFromDate);
            this.Name = "DateRangeSimple";
            this.Size = new System.Drawing.Size(458, 24);
            this.Load += new System.EventHandler(this.DateRange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teToTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFromTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFromDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TimeEdit teToTime;
        private DevExpress.XtraEditors.TimeEdit teFromTime;
        private eReview01.CDControl.CDLabel mDevXLabel2;
        private DevExpress.XtraEditors.DateEdit deToDate;
        private eReview01.CDControl.CDLabel mDevXLabel1;
        private DevExpress.XtraEditors.DateEdit deFromDate;

    }
}
