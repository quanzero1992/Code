using DevExpress.XtraReports.UI;
using eReview01.CommonUI;
using eReview01.Source.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace eReview01.Source.Report.ParameterForm
{
    public partial class CountVehicleInYearParameter : eReview01.Source.Report.ParameterForm.ParameterForm
    {
        private Logger logger = LogManager.GetLogger(typeof(CountVehicleInYearParameter));
        public CountVehicleInYearParameter()
        {
            InitializeComponent();
        }
        #region Method
        protected override XtraReport GetReportDataSource()
        {
            XtraReport rpt = null;
            if (ReportName == CommonUI.Enumeration.EnumReportName.BC9)
            {
                rpt = new ReportFile.CountCarInYearReport();
                DatasetReport source = new DatasetReport();
                var oBL = new BL.BLReport(source.CountVehicleYear.TableName, source);
                oBL.GetVehicleCountInYear(Convert.ToInt32(seYear.Value));
                rpt.DataSource = source;
                rpt.DataMember = source.CountVehicleYear.TableName;
            }
            else if (ReportName == CommonUI.Enumeration.EnumReportName.BC8)
            {
                rpt = new ReportFile.BC8Report();
                DatasetReport source = new DatasetReport();
                var oBL = new BL.BLReport(source.BC8.TableName, source);
                oBL.GetBC8(Convert.ToInt32(seYear.Value));
                rpt.DataSource = source;
                rpt.DataMember = source.BC8.TableName;
            }
            else if (ReportName == Enumeration.EnumReportName.VehicleCount)
            {
                rpt = new ReportFile.VehicleCountReport();
                DatasetReport source = new DatasetReport();
                var oBL = new BL.BLReport(source.CountVehicleYear.TableName, source);
                var fromDate = new DateTime(seYear.Value.ConvertToInt(), 1, 1);
                var toDate = fromDate.AddYears(1).AddMilliseconds(-1);
                oBL.GetVehicleCount(fromDate, toDate);
                dateRange1.FromDate = fromDate;
                dateRange1.ToDate = toDate;
                rpt.DataSource = source;
                rpt.DataMember = source.CountVehicleYear.TableName;
            }
            else if (ReportName == Enumeration.EnumReportName.BC2c)
            {
                rpt = new ReportFile.BC2cReport();
                DatasetReport source = new DatasetReport();
                var oBL = new BL.BLReport(source.BC_2c.TableName, source);
                oBL.GetBC2c(Convert.ToInt32(seYear.Value));
                rpt.DataSource = source;
                rpt.DataMember = source.BC_2c.TableName;
            }
            return rpt;
        }

        protected override void AddParameterForReport(XtraReport rpt)
        {
            base.AddParameterForReport(rpt);
            rpt.Parameters.Add(new DevExpress.XtraReports.Parameters.Parameter()
            {
                 Name="Year", Value = seYear.Value, Description = "Năm"
            });
        }
        #endregion

        #region Events
        private void CountVehicleInYearParameter_Load(object sender, EventArgs e)
        {
            try
            {
                seYear.Value = DateTime.Today.Year;
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }
        #endregion
    }
}
