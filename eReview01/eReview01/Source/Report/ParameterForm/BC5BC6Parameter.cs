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
    public partial class BC5BC6Parameter : eReview01.Source.Report.ParameterForm.ParameterForm
    {
        public BC5BC6Parameter()
        {
            InitializeComponent();
        }

        protected override DevExpress.XtraReports.UI.XtraReport GetReportDataSource()
        {
            BL.BLReport oBL = null;
            var ds = new DatasetReport();
            DevExpress.XtraReports.UI.XtraReport rpt = null;
            //if (ReportName==Enumeration.EnumReportName.BC5)
            //{
            //    rpt = new ReportFile.BC5Report();
            //    oBL = new BL.BLReport(ds.BC5.TableName, ds);
            //    oBL.GetBC5(dateRange1.FromDate, dateRange1.ToDate);
            //    rpt.DataSource = ds;
            //    rpt.DataMember = ds.BC5.TableName;
            //}
            //else 
            if (ReportName == Enumeration.EnumReportName.BC6)
            {
                rpt = new ReportFile.BC6Report();
                oBL = new BL.BLReport(ds.BC6.TableName, ds);
                oBL.GetBC6(dateRange1.FromDate, dateRange1.ToDate);
                rpt.DataSource = ds;
                rpt.DataMember = ds.BC6.TableName;
            }
            //else if (ReportName == Enumeration.EnumReportName.BC7)
            //{
            //    rpt = new ReportFile.BC7Report();
            //    oBL = new BL.BLReport(ds.CountVehicleYear.TableName, ds);
            //    oBL.GetBC7(dateRange1.FromDate, dateRange1.ToDate);
            //    rpt.DataSource = ds;
            //    rpt.DataMember = ds.CountVehicleYear.TableName;
            //}
            else
            {
                rpt = new DevExpress.XtraReports.UI.XtraReport();
            }
            return rpt;
        }

        // Quân edit 09-10
        private void BC5BC6Parameter_Load(object sender, EventArgs e)
        {
            if (ReportName == Enumeration.EnumReportName.BC5)
                defaultTime = CommonUI.Enumeration.EnumReportPeriod.ThisMonth;
            else if (ReportName == Enumeration.EnumReportName.BC7)
                defaultTime = CommonUI.Enumeration.EnumReportPeriod.ThisMonth;
        }
         //end edit

    }
}
