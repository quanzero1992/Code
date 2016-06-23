using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using eReview01.Source.Util;
using eReview01.CommonUI;
using System.Linq;

namespace eReview01.Source.Report.ReportFile
{
    public partial class BC8Report : DevExpress.XtraReports.UI.XtraReport
    {
        public BC8Report()
        {
            InitializeComponent();
        }
        private Logger logger = LogManager.GetLogger(typeof(BC8Report));

        /// <summary>
        /// Cộng tổng dòng ngang
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblTotalTurn_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                var dr =(DatasetReport.BC8Row) ((DataRowView)GetCurrentRow()).Row;
                lblTotalTurn.Text = string.Format("{0:#,#}", (dr.TurnVehType2Amount + dr.TurnVehType3Amount + dr.TurnVehType4Amount
                    + dr.TurnVehType5Amount + dr.TurnVehType1Amount));
                lblTotalMonth.Text = string.Format("{0:#,#}", (dr.MonthVehType2Amount + dr.MonthVehType3Amount + dr.MonthVehType4Amount
                    + dr.MonthVehType5Amount + dr.MonthVehType1Amount));
                lblTotalQuarter.Text = string.Format("{0:#,#}", (dr.QuarterVehType2Amount + dr.QuarterVehType3Amount + dr.QuarterVehType4Amount
                    + dr.QuarterVehType5Amount + dr.QuarterVehType1Amount ));
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }
        
        private void lblReportTitle_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblReportTitle.Text = string.Format(lblReportTitle.Text, Parameters["Year"].Value);
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void ReportFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
               
                lblSum2.Text = string.Format("{0:#,#}", ((DatasetReport)this.DataSource).BC8.Compute
                    ("SUM(TurnVehType2Amount) + SUM(MonthVehType2Amount) + SUM(QuarterVehType2Amount)", string.Empty).ConvertToDouble());
                lblSum3.Text = string.Format("{0:#,#}", ((DatasetReport)this.DataSource).BC8.Compute
                    ("SUM(TurnVehType3Amount) + SUM(MonthVehType3Amount) + SUM(QuarterVehType3Amount)", string.Empty).ConvertToDouble());
                lblSum4.Text = string.Format("{0:#,#}", ((DatasetReport)this.DataSource).BC8.Compute
                    ("SUM(TurnVehType4Amount) + SUM(MonthVehType4Amount) + SUM(QuarterVehType4Amount)", string.Empty).ConvertToDouble());
                lblSum5.Text = string.Format("{0:#,#}", ((DatasetReport)this.DataSource).BC8.Compute
                    ("SUM(TurnVehType5Amount) + SUM(MonthVehType5Amount) + SUM(QuarterVehType5Amount)", string.Empty).ConvertToDouble());
                lblSum1.Text = string.Format("{0:#,#}", ((DatasetReport)this.DataSource).BC8.Compute
                    ("SUM(TurnVehType1Amount) + SUM(MonthVehType1Amount) + SUM(QuarterVehType1Amount)", string.Empty).ConvertToDouble());

                lblSumAll.Text = string.Format("{0:#,#}", ((DatasetReport)this.DataSource).BC8.Compute
                    (" SUM(TurnVehType2Amount) + SUM(MonthVehType2Amount) + SUM(QuarterVehType2Amount) + "
                    + "SUM(TurnVehType3Amount) + SUM(MonthVehType3Amount) + SUM(QuarterVehType3Amount) + "
                    + "SUM(TurnVehType4Amount) + SUM(MonthVehType4Amount) + SUM(QuarterVehType4Amount) + "
                    + "SUM(TurnVehType5Amount) + SUM(MonthVehType5Amount) + SUM(QuarterVehType5Amount) + "
                    + "SUM(TurnVehType1Amount) + SUM(MonthVehType1Amount) + SUM(QuarterVehType1Amount)"
                    , string.Empty).ConvertToDouble());
                var amount = lblSumAll.Text.ConvertToDouble();
                if (amount != 0)
                {
                    lblTotalAmount.Text = string.Format(lblTotalAmount.Tag.ToString(), amount);
                    lblTotalAmountText.Text = string.Format(lblTotalAmountText.Tag.ToString(), CommonUI.Utils.SayMoney(amount));
                }
                else
                {
                    lblTotalAmount.Text = string.Format(lblTotalAmount.Tag.ToString(), "............");
                    lblTotalAmountText.Text = string.Format(lblTotalAmountText.Tag.ToString(), "............");
                }
                lblName.Text = BL.BLBase.GetTCOption(TCOption.StationChief.ToString());

            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void ReportHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                if (CommonDictionary.DataSource != null && CommonDictionary.DataSource.cf_station.Count > 0)
                {
                    lblUnitName.Text = CommonDictionary.DataSource.cf_station[0].COMPANY_NAME;
                    lblStationName.Text = CommonDictionary.DataSource.cf_station[0].STATION_NAME;
                    CalculateTextSize();
                }
            }
            catch (Exception ex)
            {
                CommonFunction.LogException(ex);
            }
        }

        private void CalculateTextSize()
        {
            int factor;
            Graphics gr = Graphics.FromHwnd(IntPtr.Zero);
            if (this.ReportUnit == ReportUnit.HundredthsOfAnInch)
            {
                gr.PageUnit = GraphicsUnit.Inch;
                factor = 100;
            }
            else
            {
                gr.PageUnit = GraphicsUnit.Millimeter;
                factor = 10;
            }

            //SizeF sizeStationName = ((XtraReport)this).PrintingSystem.Graph.MeasureString(lblStationName.Text);
            //SizeF sizeUnitName = ((XtraReport)this).PrintingSystem.Graph.MeasureString(lblUnitName.Text);

            SizeF sizeStationName = gr.MeasureString(lblStationName.Text, lblStationName.Font);
            SizeF sizeUnitName = gr.MeasureString(lblUnitName.Text, lblUnitName.Font);

            float fMaxWidth = sizeStationName.Width > sizeUnitName.Width ? sizeStationName.Width : sizeUnitName.Width;

            lblStationName.Width = Convert.ToInt32(fMaxWidth * factor);
            lblUnitName.Width = Convert.ToInt32(fMaxWidth * factor);

            lblStationName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            lblUnitName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            var X = lblUnitName.Location.X;
            lblStationName.Location = new Point(X, lblStationName.Location.Y);

        }

        private void xrLabel7_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrLabel7.Text = "Loại xe theo thông tư số " + CommonDictionary.DataSource.tc_option.FirstOrDefault(x => x.OptionID == "TollCirculars").OptionValue.ToString();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

    }
}
