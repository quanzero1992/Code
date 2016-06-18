using eReview01.CommonUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace eReview01.Source.Report.ParameterForm
{
    public partial class MonthParameter : eReview01.Source.Report.ParameterForm.ParameterForm
    {
        public MonthParameter()
        {
            InitializeComponent();
        }

        protected override DevExpress.XtraReports.UI.XtraReport GetReportDataSource()
        {
            BL.BLReport oBL = null;
            var ds = new DatasetReport();
            DevExpress.XtraReports.UI.XtraReport rpt = null;
            var fromDate = new DateTime(cboYear.SelectedItem.ConvertToInt(), cboMonth.SelectedItem.ConvertToInt(), 1);
            var toDate = fromDate.AddMonths(1).AddMilliseconds(-1);
            if (ReportName == Enumeration.EnumReportName.BC7)
            {
                rpt = new ReportFile.BC7Report();
                oBL = new BL.BLReport(ds.CountVehicleYear.TableName, ds);
                oBL.GetBC7(fromDate, toDate);
                rpt.DataSource = ds;
                rpt.DataMember = ds.CountVehicleYear.TableName;
            }
            else if (ReportName == Enumeration.EnumReportName.BC5)
            {
                rpt = new ReportFile.BC5Report();
                oBL = new BL.BLReport(ds.BC5.TableName, ds);
                oBL.GetBC5(fromDate, toDate);
                rpt.DataSource = ds;
                rpt.DataMember = ds.BC5.TableName;
            }
            else
            {
                rpt = new DevExpress.XtraReports.UI.XtraReport();
            }
            rpt.Parameters.Add(new DevExpress.XtraReports.Parameters.Parameter()
            {
                Name = "MFromDate",
                Value = fromDate
            });
            rpt.Parameters.Add(new DevExpress.XtraReports.Parameters.Parameter()
            {
                Name = "MToDate",
                Value = toDate
            });
            return rpt;
        }

        // Quân edit 09-10
        private void MonthParameter_Load(object sender, EventArgs e)
        {
            try
            {
                var year = DateTime.Now.Year;
                for (int i = year; i > 2000; i--)
                {
                    cboYear.Properties.Items.Add(i);
                }
                cboYear.SelectedItem = year;
                for (int i = 1; i < 13; i++)
                {
                    cboMonth.Properties.Items.Add(i);
                }
                cboMonth.SelectedItem = DateTime.Now.Month;
            }
            catch (Exception ex)
            {
                CommonFunction.LogException(ex);
            }
        }
         //end edit

    }
}
