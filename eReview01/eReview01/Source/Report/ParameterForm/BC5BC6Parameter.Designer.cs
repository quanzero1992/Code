namespace eReview01.Source.Report.ParameterForm
{
    partial class BC5BC6Parameter
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
            this.SuspendLayout();
            // 
            // dateRange1
            // 
            this.dateRange1.DateFormat = "dd/MM/yyyy";
            this.dateRange1.FromDate = new System.DateTime(2015, 10, 9, 0, 0, 0, 0);
            this.dateRange1.TimeFormat = "HH:mm:ss";
            this.dateRange1.ToDate = new System.DateTime(2015, 10, 9, 19, 39, 1, 0);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(47, 143);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(135, 143);
            // 
            // BC5BC6Parameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(217, 175);
            this.Name = "BC5BC6Parameter";
            this.Load += new System.EventHandler(this.BC5BC6Parameter_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
