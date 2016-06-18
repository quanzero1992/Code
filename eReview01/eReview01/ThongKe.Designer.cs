namespace eReview01
{
    partial class ThongKe
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            this.pivotGridControl = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.chartControl = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
                      
            this.SuspendLayout();
            // 
            // pivotGridControl
            // 
            this.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pivotGridControl.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl.Name = "pivotGridControl";
            this.pivotGridControl.Size = new System.Drawing.Size(844, 283);
            this.pivotGridControl.TabIndex = 5;
            // 
            // chartControl
            // 
            this.chartControl.DataSource = this.pivotGridControl;
            xyDiagram1.AxisX.Label.Staggered = true;
            xyDiagram1.AxisX.VisualRange.AutoSideMargins = true;
            //xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            //xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            //xyDiagram1.AxisY.Range.AlwaysShowZeroLevel = true;
            //xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            //xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl.Diagram = xyDiagram1;
            this.chartControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl.Legend.MaxHorizontalPercentage = 30D;
            this.chartControl.Location = new System.Drawing.Point(0, 283);
            this.chartControl.Name = "chartControl";
            this.chartControl.SeriesDataMember = "Series";
            this.chartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl.SeriesTemplate.ArgumentDataMember = "Arguments";
            this.chartControl.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl.SeriesTemplate.Label = sideBySideBarSeriesLabel1;
            this.chartControl.SeriesTemplate.ValueDataMembersSerializable = "Values";
            this.chartControl.Size = new System.Drawing.Size(844, 319);
            this.chartControl.TabIndex = 6;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 602);
            this.Controls.Add(this.chartControl);
            this.Controls.Add(this.pivotGridControl);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl;
        private DevExpress.XtraCharts.ChartControl chartControl;
    }
}