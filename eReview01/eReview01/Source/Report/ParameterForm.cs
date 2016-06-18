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
    public partial class ParameterForm : eReview01.Source.Framework.frmBase
    {

        #region Declaration
        private Enumeration.EnumReportName _reportName;
        private Logger logger = LogManager.GetLogger(typeof(ParameterForm));
        #endregion

        #region Contructor
        public ParameterForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties
        public Enumeration.EnumReportName ReportName
        {
            get { return _reportName; }
            set
            {
                _reportName = value;
                this.Text = Properties.Resources.ResourceManager.GetString("ReportTitle_" + value.ToString());
            }
        }
        public string ReportDataMember { get; set; }
        #endregion

        #region Method
        /// <summary>
        /// Nạp datasource cho báo cáo
        /// phần này sẽ làm dưới form desire
        /// </summary>
        protected virtual XtraReport GetReportDataSource()
        {
            return null;
        }

        /// <summary>
        /// Gọi form in báo cáo
        /// </summary>
        protected virtual void PreviewReport()
        {
            Cursor = Cursors.WaitCursor;
            var frm = new Report.PreviewReportForm();
            var rpt = GetReportDataSource();
            Cursor = Cursors.Default;
            bool validateSource = true;
            if (rpt.DataSource == null)
            {
                validateSource = false;
            }
            if (rpt.DataSource != null)
            {
                if (rpt.DataSource.GetType() == typeof(DatasetReport))
                {
                    if (((DatasetReport)rpt.DataSource).Tables[rpt.DataMember].Rows.Count == 0)
                    {
                        validateSource = false;
                    }
                }
                else if (rpt.DataSource.GetType().DeclaringType == typeof(DataTable))
                {
                    if (((DataTable)rpt.DataSource).Rows.Count == 0)
                    {
                        validateSource = false;
                    }
                }
            }
            if (!validateSource)
            {
                CommonFunction.ShowWarningMessage(Properties.Resources.Report_NotData);
                return;
            }
            AddParameterForReport(rpt);
            frm.Text = rpt.DisplayName;
            rpt.CreateDocument(false);
            frm.ReportDocument.DocumentSource = rpt;
            frm.ShowDialog();
            Cursor = Cursors.Default;
        }

        /// <summary>
        /// Truyền tham số cho báo cáo
        /// </summary>
        /// <param name="rpt"></param>
        protected virtual void AddParameterForReport(XtraReport rpt)
        {
            rpt.Parameters.Add(new DevExpress.XtraReports.Parameters.Parameter() { Type = typeof(DateTime), Value = dateRange1.FromDate, Name = "FromDate", Description = "Từ ngày" });
            rpt.Parameters.Add(new DevExpress.XtraReports.Parameters.Parameter() { Type = typeof(DateTime), Value = dateRange1.ToDate, Name = "ToDate", Description = "Đến ngày" });
            rpt.Parameters.Add(new DevExpress.XtraReports.Parameters.Parameter()
            {
                Type = typeof(string),
                Value = DBOption.TollCollectionChief,
                Name = CommonUI.Enumeration.DBOptionKey.TollCollectionChief.ToString(),
                Description = Properties.Resources.DBOptionKey_TollCollectionChief
            });
            rpt.Parameters.Add(new DevExpress.XtraReports.Parameters.Parameter()
            {
                Type = typeof(string),
                Value = DBOption.StationName,
                Name = CommonUI.Enumeration.DBOptionKey.StationName.ToString(),
                Description = Properties.Resources.DBOptionKey_StationName
            });
            rpt.Parameters.Add(new DevExpress.XtraReports.Parameters.Parameter()
            {
                Type = typeof(string),
                Value = DBOption.UnitName,
                Name = CommonUI.Enumeration.DBOptionKey.UnitName.ToString(),
                Description = Properties.Resources.DBOptionKey_UnitName
            });

            rpt.Parameters.Add(new DevExpress.XtraReports.Parameters.Parameter()
            {
                Type = typeof(string),
                Value = DBOption.AccountingChieft,
                Name = CommonUI.Enumeration.DBOptionKey.AccountingChief.ToString(),
                Description = Properties.Resources.DBOptionKey_AccountingChief
            });

            rpt.Parameters.Add(new DevExpress.XtraReports.Parameters.Parameter()
            {
                Type = typeof(string),
                Value = DBOption.AccountingStaff,
                Name = CommonUI.Enumeration.DBOptionKey.AccountingStaff.ToString(),
                Description = Properties.Resources.DBOptionKey_AccountingStaff
            });
            rpt.Parameters.Add(new DevExpress.XtraReports.Parameters.Parameter()
            {
                Type = typeof(string),
                Value = DBOption.AccountingStaff,
                Name = CommonUI.Enumeration.DBOptionKey.MonitorChief.ToString(),
                Description = Properties.Resources.DBOptionKey_MonitorChief
            });

        }
        #endregion

        #region Events
        /// <summary>
        /// In báo cáo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                PreviewReport();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Thoát form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void ParameterForm_Shown(object sender, EventArgs e)
        {
            try
            {
                // Quan edit | 10-10-2015
                // Lấy ngày tháng từ form danh sách hậu kiểm
                //var frm = (eReview01.Source.Review.PostReviewList)Application.OpenForms["PostReviewList"];
                //if (frm != null)
                //{
                //    dateRange1.FromDate = frm.dateRangeSimple1.FromDate;
                //    dateRange1.ToDate = frm.dateRangeSimple1.ToDate;
                //}
                //else
                    dateRange1.ReportPeriod = defaultTime;
                // end edit
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        // Quân edit 09-10
        /// <summary>
        /// Giá trị mặc định cho kỳ báo cáo
        /// </summary>
        public CommonUI.Enumeration.EnumReportPeriod defaultTime = CommonUI.Enumeration.EnumReportPeriod.Today;
        private void ParameterForm_Load(object sender, EventArgs e)
        {
            try
            {
                //dateRange1.ReportPeriod = CommonUI.Enumeration.EnumReportPeriod.ThisMonth;
                //dateRange1.FromDate = DateTime.Today;
                //dateRange1.ToDate = DateTime.Now;
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        // end edit
        #endregion

        
    }
}
