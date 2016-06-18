using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace eReview01.Source.Report.ParameterForm
{
    public partial class BC10Parameter : eReview01.Source.Report.ParameterForm.ParameterForm
    {
        public BC10Parameter()
        {
            InitializeComponent();
        }

        protected override DevExpress.XtraReports.UI.XtraReport GetReportDataSource()
        {
           
            var rpt = new ReportFile.BC10Report();
            var ds = new DatasetReport();
            var oBL = new BL.BLReport(ds.BC10.TableName, ds);
            string userID = glueUser.EditValue != null ? glueUser.EditValue.ToString() : string.Empty;
            //DataRow dr = (glueUser.GetSelectedDataRow() as DataRowView).Row;
           
            oBL.GetBC10(dateRange1.FromDate, dateRange1.ToDate, glueUser.EditValue != null ? glueUser.EditValue.ToString() : string.Empty);
            rpt.DataSource = ds;
            rpt.DataMember = ds.BC10.TableName;
            return rpt;
        }


       
    }
}
