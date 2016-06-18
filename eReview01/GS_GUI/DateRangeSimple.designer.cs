namespace eMonitor01
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
            this.deToDate = new DevExpress.XtraEditors.DateEdit();
            this.deFromDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
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
            this.teToTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.teToTime.EditValue = new System.DateTime(2014, 7, 23, 0, 0, 0, 0);
            this.teToTime.Location = new System.Drawing.Point(209, 45);
            this.teToTime.Margin = new System.Windows.Forms.Padding(4);
            this.teToTime.Name = "teToTime";
            this.teToTime.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.teToTime.Properties.Appearance.Options.UseFont = true;
            this.teToTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.teToTime.Properties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.teToTime.Properties.DisplayFormat.FormatString = "HH:mm:ss";
            this.teToTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.teToTime.Properties.EditFormat.FormatString = "HH:mm:ss";
            this.teToTime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.teToTime.Properties.Mask.EditMask = "HH:mm:ss";
            this.teToTime.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.teToTime.Size = new System.Drawing.Size(105, 22);
            this.teToTime.TabIndex = 16;
            this.teToTime.EditValueChanged += new System.EventHandler(this.deFromDate_EditValueChanged);
            // 
            // teFromTime
            // 
            this.teFromTime.EditValue = new System.DateTime(2014, 7, 23, 0, 0, 0, 0);
            this.teFromTime.Location = new System.Drawing.Point(209, 0);
            this.teFromTime.Margin = new System.Windows.Forms.Padding(4);
            this.teFromTime.Name = "teFromTime";
            this.teFromTime.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.teFromTime.Properties.Appearance.Options.UseFont = true;
            this.teFromTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.teFromTime.Properties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.teFromTime.Properties.DisplayFormat.FormatString = "HH:mm:ss";
            this.teFromTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.teFromTime.Properties.EditFormat.FormatString = "HH:mm:ss";
            this.teFromTime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.teFromTime.Properties.Mask.EditMask = "HH:mm:ss";
            this.teFromTime.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.teFromTime.Size = new System.Drawing.Size(105, 22);
            this.teFromTime.TabIndex = 17;
            this.teFromTime.EditValueChanged += new System.EventHandler(this.deFromDate_EditValueChanged);
            // 
            // deToDate
            // 
            this.deToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deToDate.EditValue = null;
            this.deToDate.Location = new System.Drawing.Point(76, 45);
            this.deToDate.Margin = new System.Windows.Forms.Padding(4);
            this.deToDate.Name = "deToDate";
            this.deToDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.deToDate.Properties.Appearance.Options.UseFont = true;
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
            this.deToDate.Size = new System.Drawing.Size(125, 22);
            this.deToDate.TabIndex = 14;
            this.deToDate.EditValueChanged += new System.EventHandler(this.deFromDate_EditValueChanged);
            // 
            // deFromDate
            // 
            this.deFromDate.EditValue = null;
            this.deFromDate.Location = new System.Drawing.Point(76, 0);
            this.deFromDate.Margin = new System.Windows.Forms.Padding(4);
            this.deFromDate.Name = "deFromDate";
            this.deFromDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.deFromDate.Properties.Appearance.Options.UseFont = true;
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
            this.deFromDate.Size = new System.Drawing.Size(125, 22);
            this.deFromDate.TabIndex = 12;
            this.deFromDate.EditValueChanged += new System.EventHandler(this.deFromDate_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl1.Location = new System.Drawing.Point(0, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 16);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Đến ngày:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl2.Location = new System.Drawing.Point(0, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 16);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Từ ngày:";
            // 
            // DateRangeSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.teToTime);
            this.Controls.Add(this.teFromTime);
            this.Controls.Add(this.deToDate);
            this.Controls.Add(this.deFromDate);
            this.FontDateRange = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DateRangeSimple";
            this.Size = new System.Drawing.Size(335, 75);
            ((System.ComponentModel.ISupportInitialize)(this.teToTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFromTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFromDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TimeEdit teToTime;
        private DevExpress.XtraEditors.TimeEdit teFromTime;
       // private DevExpress.XtraEditors.LabelControl lblToDate;
        private DevExpress.XtraEditors.DateEdit deToDate;
       // private DevExpress.XtraEditors.LabelControl lblFromDate;
        private DevExpress.XtraEditors.DateEdit deFromDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;

    }
}
