using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Globalization;
using System.Data;
using eReview01.Source.Util;
using eReview01.CommonUI;
using System.Drawing;
using System.Linq;

namespace eReview01.Source.Report.ReportFile
{
    public partial class CountCarInYearReport : DevExpress.XtraReports.UI.XtraReport
    {
        public CountCarInYearReport()
        {
            InitializeComponent();
        }

        private Logger logger = LogManager.GetLogger(typeof(CountCarInYearReport));
        
        /// <summary>
        /// Hiển thị title với số năm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblReportTitle_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           
        }

        private Hashtable tcType = new Hashtable() { 
            {3,Properties.Resources.TcType_AllCountry},
            {4,Properties.Resources.TcType_FreeOne},
            {5,Properties.Resources.TcType_FreeMany},
            {99,Properties.Resources.TcType_InvalidPass}
        };

        private void lblVehType_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                var iTcType = GetCurrentColumnValue("TcType").ConvertToInt();
                var iVehType = GetCurrentColumnValue("VehTypeID").ConvertToInt();
                if (iTcType == 1)
                {
                    lblVehType.Text = iVehType.ToString();
                }
                else
                {
                    lblVehType.Text = tcType[iTcType].ToString();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void lblCountCar_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblCountCar.Text = string.Format(lblCountCar.Tag.ToString(), GetCurrentColumnValue("TotalAllVehicle"));
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
                //lblStationName.Text = string.Format(lblStationName.Tag.ToString(), Parameters["StationName"].Value);
                //lblUnitName.Text = string.Format(lblUnitName.Tag.ToString(), Parameters["UnitName"].Value);
                if (CommonDictionary.DataSource != null && CommonDictionary.DataSource.cf_station.Count > 0)
                {
                    lblUnitName.Text = CommonDictionary.DataSource.cf_station[0].COMPANY_NAME;
                    lblStationName.Text = CommonDictionary.DataSource.cf_station[0].STATION_NAME;
                    CalculateTextSize();
                }
                lblReportTitle.Text = string.Format(lblReportTitle.Tag.ToString(), Parameters["Year"].Value.ToString());
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void lbl_StationCaptain_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lbl_StationCaptain.Text = BL.BLBase.GetTCOption(TCOption.StationChief.ToString());
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
