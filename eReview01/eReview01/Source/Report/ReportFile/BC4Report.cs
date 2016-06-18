using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using eReview01.Source.Util;
using eReview01.CommonUI;

namespace eReview01.Source.Report.ReportFile
{
    public partial class BC4Report : DevExpress.XtraReports.UI.XtraReport
    {
        private Logger logger = LogManager.GetLogger(typeof(BC4Report));
        private Entities.DatasetReview dicSource;
        private Hashtable tcType = new Hashtable() { 
            {3,Properties.Resources.TcType_AllCountry},
            {4,Properties.Resources.TcType_FreeOne},
            {5,Properties.Resources.TcType_FreeMany}
        };
        public BC4Report()
        {
            InitializeComponent();
            dicSource = new Entities.DatasetReview();
            var oBL = new BL.BLBase(dicSource.lane_info.TableName, string.Empty, dicSource);
            oBL.GetAllData();
            oBL.TableMasterName = dicSource.tc_type.TableName;
            oBL.GetAllData();
        }
        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                var dr = (DatasetReport.BC4Row)((DataRowView)GetCurrentRow()).Row;
                string descriptionFormat = "{0:HH:mm:ss dd/MM/yyyy}\r\n{1}";
                lblDescription2.Text = string.Format(descriptionFormat, dr["TRANS_BEGIN"], tcType[dr["TRANS_TC_TYPE"]]);
                xrPictureBox2.ImageUrl = dr["TRANS_MIX_IMG_LINK"].ToString();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void lblLaneInfo_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                var drLaneInfo = dicSource.lane_info.FindByLANE_INFO_ID(GetCurrentColumnValue(datasetReport1.BC4.LANE_INFO_IDColumn.ColumnName).ConvertToInt());
                if (drLaneInfo != null)
                {
                    lblLaneInfo.Text = string.Format(lblLaneInfo.Tag.ToString(),
                        drLaneInfo["LANE_INFO_NUMBER"], Parameters["FromDate"].Value, Parameters["ToDate"].Value);
                }
                else
                {
                    lblLaneInfo.Visible = false;
                }
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
                var dsSource = (DatasetReport)this.DataSource;
                var filterString = "{0}={1}";
                var expessionString = string.Format("COUNT({0})", dsSource.BC4.TRANS_TC_TYPEColumn.ColumnName);
                int allCountryQuantity = dsSource.BC4.Compute(expessionString, string.Format(filterString,
                    dsSource.BC4.TRANS_TC_TYPEColumn.ColumnName, (int)CommonUI.Enumeration.TcType.AllCountry)).ConvertToInt();
                int freeOneQuantity = dsSource.BC4.Compute(expessionString, string.Format(filterString,
                    dsSource.BC4.TRANS_TC_TYPEColumn.ColumnName, (int)CommonUI.Enumeration.TcType.FreeOne)).ConvertToInt();
                int freeManyQuantity = dsSource.BC4.Compute(expessionString, string.Format(filterString,
                    dsSource.BC4.TRANS_TC_TYPEColumn.ColumnName, (int)CommonUI.Enumeration.TcType.FreeMany)).ConvertToInt();
                lblTotalAllCountry.Text = string.Format(lblTotalAllCountry.Tag.ToString(), allCountryQuantity);
                lblTotalFreeOne.Text = string.Format(lblTotalFreeOne.Tag.ToString(), freeOneQuantity);
                lblTotalFreeMany.Text = string.Format(lblTotalFreeMany.Tag.ToString(), freeManyQuantity);
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }
    }
}
