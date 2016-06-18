namespace eReview01.Source.Report.ParameterForm
{
    partial class CountVehicleInYearParameter
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
            this.seYear = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.seYear.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dateRange1
            // 
            this.dateRange1.Location = new System.Drawing.Point(16, 248);
            this.dateRange1.ReportPeriod = eReview01.CommonUI.Enumeration.EnumReportPeriod.Today;
            this.dateRange1.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(21, 40);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(109, 40);
            // 
            // mDevXLabel1
            // 
            this.mDevXLabel1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.mDevXLabel1.Location = new System.Drawing.Point(23, 11);
            this.mDevXLabel1.Name = "mDevXLabel1";
            this.mDevXLabel1.Size = new System.Drawing.Size(32, 21);
            this.mDevXLabel1.TabIndex = 3;
            this.mDevXLabel1.Text = "&Năm";
            // 
            // seYear
            // 
            this.seYear.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seYear.Location = new System.Drawing.Point(55, 12);
            this.seYear.Name = "seYear";
            this.seYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seYear.Properties.DisplayFormat.FormatString = "####";
            this.seYear.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seYear.Properties.EditFormat.FormatString = "####";
            this.seYear.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seYear.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.seYear.Properties.Mask.EditMask = "####";
            this.seYear.Size = new System.Drawing.Size(72, 20);
            this.seYear.TabIndex = 4;
            // 
            // CountVehicleInYearParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(207, 71);
            this.Controls.Add(this.seYear);
            this.Controls.Add(this.mDevXLabel1);
            this.Name = "CountVehicleInYearParameter";
            this.Load += new System.EventHandler(this.CountVehicleInYearParameter_Load);
            this.Controls.SetChildIndex(this.dateRange1, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.mDevXLabel1, 0);
            this.Controls.SetChildIndex(this.seYear, 0);
            ((System.ComponentModel.ISupportInitialize)(this.seYear.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CDControl.CDLabel mDevXLabel1;
        private DevExpress.XtraEditors.SpinEdit seYear;
    }
}
