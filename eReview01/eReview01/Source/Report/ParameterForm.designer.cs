namespace eReview01.Source.Report.ParameterForm
{
    partial class ParameterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParameterForm));
            this.btnCancel = new eReview01.CDControl.CDButton();
            this.btnPrint = new eReview01.CDControl.CDButton();
            this.dateRange1 = new eReview01.Source.DateRange();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BindingType = eReview01.CommonUI.Enumeration.EnumBindingType.None;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(304, 240);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Đóng";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BindingType = eReview01.CommonUI.Enumeration.EnumBindingType.None;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(216, 240);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 23);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Xem trước";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dateRange1
            // 
            this.dateRange1.DateFormat = null;
            this.dateRange1.FromDate = new System.DateTime(2015, 4, 8, 0, 0, 0, 0);
            this.dateRange1.Location = new System.Drawing.Point(8, 8);
            this.dateRange1.Name = "dateRange1";
            this.dateRange1.ReportPeriod = eReview01.CommonUI.Enumeration.EnumReportPeriod.ThisMonth;
            this.dateRange1.Size = new System.Drawing.Size(200, 128);
            this.dateRange1.TabIndex = 0;
            this.dateRange1.TimeFormat = null;
            this.dateRange1.ToDate = new System.DateTime(2015, 4, 8, 0, 0, 0, 0);
            // 
            // ParameterForm
            // 
            this.AcceptButton = this.btnPrint;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(386, 272);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dateRange1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ParameterForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tham số báo cáo";
            this.Load += new System.EventHandler(this.ParameterForm_Load);
            this.Shown += new System.EventHandler(this.ParameterForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        public DateRange dateRange1;
        public CDControl.CDButton btnPrint;
        public CDControl.CDButton btnCancel;

    }
}
