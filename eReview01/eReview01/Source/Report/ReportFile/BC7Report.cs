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
    public partial class BC7Report : DevExpress.XtraReports.UI.XtraReport
    {
        private Logger logger = LogManager.GetLogger(typeof(BC7Report));
        public BC7Report()
        {
            InitializeComponent();
        }

        private void lblCountCar_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                var count = GetCurrentColumnValue("TotalAllVehicle").ConvertToInt();
                if (count > 0)
                {
                    lblCountCar.Text = string.Format(lblCountCar.Tag.ToString(), count);
                }
                else
                {
                    lblCountCar.Text = string.Format(lblCountCar.Tag.ToString(), "........");
                }

            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void lblDateTime_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblDateTime.Text = CommonUI.Utils.SayDate(Parameters["MFromDate"].Value.ConvertToDateTime(), Parameters["MToDate"].Value.ConvertToDateTime());
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void PageHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (CommonDictionary.DataSource != null && CommonDictionary.DataSource.cf_station.Count > 0)
            {
                lblUnitName.Text = CommonDictionary.DataSource.cf_station[0].COMPANY_NAME;
                lblStationName.Text = CommonDictionary.DataSource.cf_station[0].STATION_NAME;
                CalculateTextSize();
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

        private void xrTableCell58_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrTableCell58.Text = "Loại xe theo thông tư số " + CommonDictionary.DataSource.tc_option.FirstOrDefault(x => x.OptionID == "TollCirculars").OptionValue.ToString();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

    }
}
