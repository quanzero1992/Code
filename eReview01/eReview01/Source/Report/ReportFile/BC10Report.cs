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
    public partial class BC10Report : DevExpress.XtraReports.UI.XtraReport
    {
        private Logger logger = LogManager.GetLogger(typeof(BC10Report));
        public BC10Report()
        {
            InitializeComponent();
        }
        
        private void lblCountError_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                int count = GetCurrentColumnValue("ERROR_TYPE_TOTAL").ConvertToInt();
                lblCountError.Text = string.Format("Tổng số lỗi của nhân viên: {0:D} lỗi", count);
                //if (count > 0)
                //{
                //    lblCountError.Text = string.Format(lblCountError.Tag.ToString(), count);
                //}
                //else
                //{
                //    lblCountError.Text = string.Format(lblCountError.Tag.ToString(), "........");
                //}
                
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }
        private void lblTenNhanVien_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                var stName = GetCurrentColumnValue("USER_INFO_FULL").ToString();
                if (stName != "")
                {
                    lblNhanvien.Text = lblNhanvien.Tag.ToString() + stName;
                }
                else
                {
                    lblNhanvien.Text = string.Format(lblNhanvien.Tag.ToString(), "........");
                }
                
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }
        private void xrLabel1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblUnitName.Text = CommonDictionary.DataSource.cf_station[0].COMPANY_NAME;

            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void xrLabel3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblStationName.Text = CommonDictionary.DataSource.cf_station[0].STATION_NAME;
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
                lblDateTime.Text = CommonUI.Utils.SayDate(Parameters["FromDate"].Value.ConvertToDateTime(), Parameters["ToDate"].Value.ConvertToDateTime());
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

        private void PageHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblStationName.Text = CommonDictionary.DataSource.cf_station[0].STATION_NAME;
                lblUnitName.Text = CommonDictionary.DataSource.cf_station[0].COMPANY_NAME;
                CalculateTextSize();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

       
    }
}
