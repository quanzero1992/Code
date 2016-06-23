using System;
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
    public partial class BC2Report : XtraReport
    {
        private Logger logger = LogManager.GetLogger(typeof(BC2Report));
        private Hashtable tcType = new Hashtable() { 
            {1,Properties.Resources.TcType_Turn},
            {2,Properties.Resources.TcType_Month},
            {3,Properties.Resources.TcType_AllCountry},
            {4,Properties.Resources.TcType_FreeOne},
            {5,Properties.Resources.TcType_FreeMany},
            {10,Properties.Resources.TcType_ETC},
            {99,Properties.Resources.TcType_InvalidPass}
        };

        private Hashtable tickType = new Hashtable() { 
        {0, "Vé lượt"},{1, "Vé tháng"}, {2, "Vé quý"}
        };
        public BC2Report()
        {
            InitializeComponent();
        }
        private int _index = 1;
        private void lblIndex_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblIndex.Text = _index.ToString();
            _index++;
        }

        private void lblTcType_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                var iTickType = GetCurrentColumnValue(datasetReport2.BC2.TransTicketTypeColumn.ColumnName).ConvertToInt();
                var iTcType = GetCurrentColumnValue(datasetReport2.BC2.TcTypeColumn.ColumnName).ConvertToInt();
                if (iTcType == 2)
                {
                    lblTcType.Text = tickType[iTickType].ToString();
                }
                else
                {
                    lblTcType.Text = tcType[iTcType].ToString();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void GroupHeader2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                var drv = (DataRowView)GetCurrentRow();
                if (drv != null)
                {
                    var dFromDate = drv[datasetReport2.BC2.ShiftInfoBeginColumn.ColumnName].ConvertToDateTime();
                    var dEndDate = drv[datasetReport2.BC2.ShiftInfoEndColumn.ColumnName].ConvertToDateTime();
                    if (dFromDate.Year > 2000)
                    {
                        lblBeginDate.Text = string.Format(lblBeginDate.Tag.ToString(), dFromDate.Hour, dFromDate.Minute, dFromDate.Day, dFromDate.Month, dFromDate.Year);
                    }
                    if (dEndDate.Year > 2000)
                    {
                        lblEndDate.Text = string.Format(lblEndDate.Tag.ToString(), dEndDate.Hour, dEndDate.Minute, dEndDate.Day, dEndDate.Month, dEndDate.Year);
                    }
                    lblLaneInfo.Text = string.Format(lblLaneInfo.Tag.ToString(), drv[datasetReport2.BC2.LaneInfoNumberColumn.ColumnName],
                            drv[datasetReport2.BC2.LaneInfoFromColumn.ColumnName], drv[datasetReport2.BC2.LaneInfoToColumn.ColumnName]);
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
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void lblError_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                var iError = GetCurrentColumnValue(datasetReport2.BC2.ErrorTypeColumn.ColumnName).ConvertToInt();
                if (iError == (int)CommonUI.Enumeration.ErrorType.None || iError == (int)CommonUI.Enumeration.ErrorType.Error99)
                {
                    lblError.Text = string.Empty;
                }
                else
                {
                    lblError.Text = iError.ToString();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }

        }

        private void BottomMargin_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
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

        private void xrTableCell58_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrTableCell58.Text = "Loại xe theo thông tư " + CommonDictionary.DataSource.tc_option.FirstOrDefault(x => x.OptionID == "TollCirculars").OptionValue.ToString();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }


    }
}
