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
    public partial class BC6Report : DevExpress.XtraReports.UI.XtraReport
    {
        private Logger logger = LogManager.GetLogger(typeof(BC6Report));
        private Hashtable TickType = new Hashtable()
        {
            { 1,"Vé tháng"},
            { 2,"Vé quý"}
        };
        public BC6Report()
        {
            InitializeComponent();
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

        private int _index = 1;
        private void lblIndex_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblIndex.Text = _index.ToString();
                _index++;
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
                lblSayDate.Text = CommonUI.Utils.SayDate(Parameters["FromDate"].Value.ConvertToDateTime(), Parameters["ToDate"].Value.ConvertToDateTime());
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void lblTicketType_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                var drv = (DataRowView)GetCurrentRow();
                var ticketType = drv[datasetReport2.BC6.TICK_SOLD_TYPEColumn.ColumnName].ConvertToInt();
                if (ticketType == 1 || ticketType == 2)
                    lblTicketType.Text = TickType[drv[datasetReport2.BC6.TICK_SOLD_TYPEColumn.ColumnName].ConvertToInt()].ToString();
                else
                    lblTicketType.Text = string.Empty;
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
                //lblStationName.Text = string.Format(Properties.Resources.ReportUnitFormatString, Parameters[CommonUI.Enumeration.DBOptionKey.StationName.ToString()].Value);
                //lblUnitName.Text = string.Format(Properties.Resources.ReportUnitFormatString, Parameters[CommonUI.Enumeration.DBOptionKey.UnitName.ToString()].Value);
                if (CommonDictionary.DataSource != null && CommonDictionary.DataSource.cf_station.Count > 0)
                {
                    lblUnitName.Text = CommonDictionary.DataSource.cf_station[0].COMPANY_NAME;
                    lblStationName.Text = CommonDictionary.DataSource.cf_station[0].STATION_NAME;
                    CalculateTextSize();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        // Quan edit 19-10
        private void GroupFooter1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblTotal.Text =string.Format("Tổng tiền (bằng chữ): {0}", CommonUI.Utils.SayMoney(((DatasetReport)this.DataSource).BC6.Compute("SUM(TICK_SOLD_FEE)", string.Empty).ConvertToDouble()));
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

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
