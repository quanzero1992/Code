using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Globalization;
using System.Data;
using eReview01.Source.Util;
using eReview01.CommonUI;

namespace eReview01.Source.Report.ReportFile
{
    public partial class BC5Report : DevExpress.XtraReports.UI.XtraReport
    {
        private Logger logger = LogManager.GetLogger(typeof(BC5Report));
        public BC5Report()
        {
            InitializeComponent();
        }




        private void xrLabel45_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrLabel45.Text = Parameters[CommonUI.Enumeration.DBOptionKey.TollCollectionChief.ToString()].Value.ToString();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void lblSayDate_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblSayDate.Text = CommonUI.Utils.SayDate(Parameters["MFromDate"].Value.ConvertToDateTime(), Parameters["MToDate"].Value.ConvertToDateTime());
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void lblTotalAmount_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                var amount = ((DatasetReport)this.DataSource).BC5.Compute("SUM(TurnAmount) + SUM(MonthAmount) + SUM(QuarterAmount)", string.Empty).ConvertToDouble();
                if (amount != 0)
                {
                    lblTotalAmount.Text = string.Format(lblTotalAmount.Tag.ToString(), amount);
                }
                else
                {
                    lblTotalAmount.Text = string.Format(lblTotalAmount.Tag.ToString(), "............");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void lblTotalAmountText_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblTotalAmountText.Text = string.Format(lblTotalAmountText.Tag.ToString(), CommonUI.Utils.SayMoney(((DatasetReport)this.DataSource).BC5.
                    Compute("SUM(TurnAmount) + SUM(MonthAmount) + SUM(QuarterAmount)", string.Empty).ConvertToDouble()));
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void lblTotalVertical_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                var drv = (DataRowView)GetCurrentRow();
                lblTotalVertical.Text = string.Format("{0:#,#}", drv["TurnAmount"].ConvertToDouble()
                    + drv["MonthAmount"].ConvertToDouble() + drv["QuarterAmount"].ConvertToDouble());
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void lblTotalAll_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblTotalAll.Text = string.Format("{0:#,#}", ((DatasetReport)this.DataSource).BC5.
                    Compute("SUM(TurnAmount) + SUM(MonthAmount) + SUM(QuarterAmount)", string.Empty).ConvertToDouble());
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void lblAccountingChief_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblAccountingChief.Text = Parameters[CommonUI.Enumeration.DBOptionKey.AccountingChief.ToString()].Value.ToString();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void PageHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
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

        private void ReportFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblName.Text = BL.BLBase.GetTCOption(TCOption.StationChief.ToString());
            }
            catch (Exception ex)
            {
                logger.Error(ex);
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

    }
}
