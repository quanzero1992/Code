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
    public partial class ChangeShiftReportSummary : DevExpress.XtraReports.UI.XtraReport
    {
        private Logger logger = LogManager.GetLogger(typeof(ChangeShiftReportSummary));
        public ChangeShiftReportSummary()
        {
            InitializeComponent();
        }

        private void lblTotalAmountText_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblTotalAmountText.Text = string.Format(lblTotalAmountText.Tag.ToString(), CommonUI.Utils.SayMoney(lblTotalAmount.Summary.GetResult().ConvertToDouble()));
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void lblIdentifyErrorCount_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           try
            {
                var count = GetCurrentColumnValue(datasetReport1.ChangeShiftUserInfo.IdentifyErrorQuantityColumn.ColumnName).ConvertToInt();
                if (count > 0)
                {
                    lblIdentifyErrorCount.Text = "Số lỗi phân loại các thu phí viên mắc phải: " + count + " lỗi";
                }
                else
                {
                    lblIdentifyErrorCount.Text = "Số lỗi phân loại các thu phí viên mắc phải: 0 lỗi";
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                //lblUnitName.Text = string.Format(Properties.Resources.ReportUnitFormatString,
                //                    Parameters[CommonUI.Enumeration.DBOptionKey.UnitName.ToString()].Value);
                //lblStationName.Text = string.Format(Properties.Resources.ReportStationFormatString,
                //    Parameters[CommonUI.Enumeration.DBOptionKey.StationName.ToString()].Value);
                if (CommonDictionary.DataSource != null && CommonDictionary.DataSource.cf_station.Count > 0)
                {
                    lblUnitName.Text = CommonDictionary.DataSource.cf_station[0].COMPANY_NAME;
                    lblStationName.Text = CommonDictionary.DataSource.cf_station[0].STATION_NAME;
                    CalculateTextSize();
                }
                var drv = (DataRowView)GetCurrentRow();
                if (drv != null)
                {
                    var beginDate = drv[datasetReport1.ChangeShiftUserInfo.ShiftBeginColumn.ColumnName].ConvertToDateTime();
                    var endDate = drv[datasetReport1.ChangeShiftUserInfo.ShiftEndColumn.ColumnName].ConvertToDateTime();
                    lblBeginDate.Text = string.Format(lblBeginDate.Tag.ToString(),
                     beginDate.Hour, beginDate.Minute, beginDate.Day, beginDate.Month, beginDate.Year);
                    lblEndDate.Text = string.Format(lblEndDate.Tag.ToString(),
                    endDate.Hour, endDate.Minute, endDate.Day, endDate.Month, endDate.Year);
                    lblTotalCarPass.Text = string.Format(lblTotalCarPass.Tag.ToString(), drv[datasetReport1.ChangeShiftUserInfo.TotalQuantityColumn.ColumnName].ConvertToInt());
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void GroupFooter1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
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
