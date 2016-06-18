using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Globalization;
using System.Data;
using eReview01.Source.Util;
using eReview01.CommonUI;
using System.Linq;

namespace eReview01.Source.Report.ReportFile
{
    public partial class VehicleCountReport : DevExpress.XtraReports.UI.XtraReport
    {
        private Logger logger = LogManager.GetLogger(typeof(BC7Report));
        public VehicleCountReport()
        {
            InitializeComponent();
        }

        private void lblCountCar_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

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
                var ds = ((DatasetReport)this.DataSource).CountVehicleYear;
                var monthFrom = 0;
                var monthTo = 0;
                if (ds.Count > 0)
                {
                    monthFrom = ds.AsEnumerable().Min(x => x.TcType);
                    monthTo = ds.AsEnumerable().Max(x => x.TcType);
                }
                if (monthFrom > 0)
                {
                    lblDateTime.Text = string.Format("Từ tháng {0} đến tháng {1}/Năm {2}", monthFrom, monthTo, Parameters["FromDate"].Value.ConvertToDateTime().Year);
                }
                else
                {
                    lblDateTime.Text = string.Format("Năm {1}", Parameters["FromDate"].Value.ConvertToDateTime().Year);
                }
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
                //lblUnitName.Text = CommonDictionary.DataSource.cf_station[0].COMPANY_NAME;
                //lblStationName.Text = CommonDictionary.DataSource.cf_station[0].STATION_NAME;
            }
        }

        private void lblStationChief_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblStationChief.Text = BL.BLBase.GetTCOption(TCOption.StationChief.ToString());
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
                var projectName = BL.BLBase.GetTCOption(TCOption.TCProjectName.ToString());
                if (!string.IsNullOrEmpty(projectName))
                {
                    lblProjectName.Text = string.Format(lblProjectName.Tag.ToString(), projectName);
                }
                var botName = BL.BLBase.GetTCOption(TCOption.BOTName.ToString());
                if (!string.IsNullOrEmpty(botName))
                {
                    lblBOT.Text = string.Format(lblBOT.Tag.ToString(), botName);
                }
                var tcPlace = BL.BLBase.GetTCOption(TCOption.PlaceOfTollGate.ToString());
                if (!string.IsNullOrEmpty(tcPlace))
                {
                    lblPlace.Text = string.Format(lblPlace.Tag.ToString(), tcPlace);
                }
                var strKm = BL.BLBase.GetTCOption(TCOption.TollGateName.ToString());
                if (!string.IsNullOrEmpty(strKm))
                {
                    lblKm.Text = string.Format(lblKm.Tag.ToString(), strKm);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }
    }
}
