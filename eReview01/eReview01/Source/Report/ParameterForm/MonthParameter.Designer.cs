namespace eReview01.Source.Report.ParameterForm
{
    partial class MonthParameter
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
            this.cboYear = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new eReview01.CDControl.CDLabel();
            this.cdLabel1 = new eReview01.CDControl.CDLabel();
            this.cboMonth = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cboYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMonth.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dateRange1
            // 
            this.dateRange1.DateFormat = "dd/MM/yyyy";
            this.dateRange1.FromDate = new System.DateTime(2015, 10, 9, 0, 0, 0, 0);
            this.dateRange1.Location = new System.Drawing.Point(144, 168);
            this.dateRange1.ReportPeriod = eReview01.CommonUI.Enumeration.EnumReportPeriod.Today;
            this.dateRange1.TimeFormat = "HH:mm:ss";
            this.dateRange1.ToDate = new System.DateTime(2015, 10, 9, 19, 39, 1, 0);
            this.dateRange1.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(62, 52);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(150, 52);
            // 
            // cboYear
            // 
            this.cboYear.Location = new System.Drawing.Point(40, 8);
            this.cboYear.Name = "cboYear";
            this.cboYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboYear.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboYear.Size = new System.Drawing.Size(64, 20);
            this.cboYear.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "&Năm";
            // 
            // cdLabel1
            // 
            this.cdLabel1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.cdLabel1.Location = new System.Drawing.Point(120, 8);
            this.cdLabel1.Name = "cdLabel1";
            this.cdLabel1.Size = new System.Drawing.Size(40, 21);
            this.cdLabel1.TabIndex = 7;
            this.cdLabel1.Text = "&Tháng";
            // 
            // cboMonth
            // 
            this.cboMonth.Location = new System.Drawing.Point(160, 8);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMonth.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboMonth.Size = new System.Drawing.Size(64, 20);
            this.cboMonth.TabIndex = 3;
            // 
            // MonthParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(232, 84);
            this.Controls.Add(this.cdLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMonth);
            this.Controls.Add(this.cboYear);
            this.Name = "MonthParameter";
            this.Load += new System.EventHandler(this.MonthParameter_Load);
            this.Controls.SetChildIndex(this.dateRange1, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.cboYear, 0);
            this.Controls.SetChildIndex(this.cboMonth, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cdLabel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cboYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMonth.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cboYear;
        private CDControl.CDLabel label1;
        private CDControl.CDLabel cdLabel1;
        private DevExpress.XtraEditors.ComboBoxEdit cboMonth;
    }
}
