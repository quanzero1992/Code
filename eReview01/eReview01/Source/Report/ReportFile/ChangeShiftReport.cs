﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Globalization;
using System.Data;
using eReview01.Source.Util;
using eReview01.CommonUI;
using System.Linq;

namespace eReview01.Source.Report.ReportFile
{
    public partial class ChangeShiftReport : DevExpress.XtraReports.UI.XtraReport
    {
        private Logger logger = LogManager.GetLogger(typeof(ChangeShiftReport));
        public ChangeShiftReport()
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
               var count =  GetCurrentColumnValue(datasetReport1.ChangeShiftUserInfo.IdentifyErrorQuantityColumn.ColumnName).ConvertToInt();
               if (count > 0)
               {
                   lblIdentifyErrorCount.Text = "Tổng số lỗi mắc phải: " + count.ToString() + " lỗi";
               }
               else
               {
                   lblIdentifyErrorCount.Text = "Tổng số lỗi mắc phải: 0 lỗi";
               }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void lblLaneInfo_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                var drv = (DatasetReport.ChangeShiftUserInfoRow)((DataRowView)GetCurrentRow()).Row;
                if (drv != null)
                {
                    lblLaneInfo.Text = string.Format(lblLaneInfo.Tag.ToString(),
                        drv["LaneInfoNumber"].ToString(), drv["LaneFrom"].ToString(), drv["LaneTo"].ToString());
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
                }
                CalculateTextSize();

                var drv = (DataRowView)GetCurrentRow();
                if (drv != null)
                {
                    var beginDate = drv[datasetReport1.ChangeShiftUserInfo.ShiftInfoBeginColumn.ColumnName].ConvertToDateTime();
                    var endDate = drv[datasetReport1.ChangeShiftUserInfo.ShiftInfoEndColumn.ColumnName].ConvertToDateTime();
                   lblBeginDate.Text = string.Format(lblBeginDate.Tag.ToString(),
                    beginDate.Hour, beginDate.Minute, beginDate.Day, beginDate.Month, beginDate.Year);
                   lblEndDate.Text = string.Format(lblEndDate.Tag.ToString(),
                   endDate.Hour, endDate.Minute, endDate.Day, endDate.Month, endDate.Year);
                    var iQuantity =  drv[datasetReport1.ChangeShiftUserInfo.TotalQuantityColumn.ColumnName].ConvertToInt();
                    lblTotalCarPass.Text = string.Format(lblTotalCarPass.Tag.ToString(),iQuantity > 0 ? iQuantity : 0);
                }
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

        private void xrTableCell1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrTableCell1.Text = "Loại xe theo thông tư " + CommonDictionary.DataSource.tc_option.FirstOrDefault(x => x.OptionID == "TollCirculars").OptionValue.ToString();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void xrLabel25_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                var drv = (DataRowView)GetCurrentRow();
                if (drv != null)
                {
                    var vehType = drv[datasetReport1.ChangeShiftUserInfo.VehTypeIDColumn.ColumnName].ConvertToInt();
                    xrLabel25.Text = CommonDictionary.DataSource.ticket_type.FirstOrDefault(x => x.TICK_TYPE_ID == vehType).TICK_TYPE_FEE.ToString("0,0");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

    }
}
