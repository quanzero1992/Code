using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using eReview01.Entities;

namespace eReview01.Source.Report.ParameterForm
{
    public partial class BC4Parameter : eReview01.Source.Report.ParameterForm.ParameterForm
    {
        public BC4Parameter()
        {
            InitializeComponent();
        }

        protected override DevExpress.XtraReports.UI.XtraReport GetReportDataSource()
        {
            var rpt = new ReportFile.BC4Report();
            var ds = new DatasetReport();
            var oBL = new BL.BLReport(ds.BC4.TableName, ds);
            oBL.GetBC4(dateRange1.FromDate, dateRange1.ToDate, glueLaneInfo.EditValue != null ? Convert.ToInt32(glueLaneInfo.EditValue) : -1);
            rpt.DataSource = ds;
            rpt.DataMember = ds.BC4.TableName;
            return rpt;
        }

        public static eReview01.Entities.DatasetReview DataSource = new Entities.DatasetReview();
        private void BC4Parameter_Load(object sender, EventArgs e)
        {
            using (var oBL = new BL.BLBase(DataSource.cf_lane.TableName, string.Empty, DataSource))
            {
                DataSource.Clear();
                oBL.TableMasterName = DataSource.cf_lane.TableName;
                oBL.GetAllData();
            }
            glueLaneInfo.Properties.DataSource = DataSource.cf_lane;
        }

       
    }
}
