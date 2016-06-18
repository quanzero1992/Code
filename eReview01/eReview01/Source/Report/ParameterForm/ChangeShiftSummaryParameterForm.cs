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
    public partial class ChangeShiftSummaryParameterForm : eReview01.Source.Report.ParameterForm.ParameterForm
    {
        #region Declaration 
        private Logger logger = LogManager.GetLogger(typeof(ChangeShiftSummaryParameterForm));
        #endregion

        #region Contructor
        public ChangeShiftSummaryParameterForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties
        #endregion

        #region Method
        private void SetShiftFilter()
        {
            chkCheckedAllUser.Checked = false;
            var oBL = new BL.BLShift();
            oBL.DataSource = dsReview;
            dsReview.shift.Clear();
            oBL.SearchShiftByTime(dateRange1.FromDate, dateRange1.ToDate);
            bsShift.Filter = string.Format("SHI_TYPE_ID = {0}",
                glueShiftType.EditValue != null && !glueShiftType.EditValue.Equals(-1) ? glueShiftType.EditValue : "SHI_TYPE_ID");
        }

        /// <summary>
        /// Nạp dữ liệu cho các control trên form tham số
        /// </summary>
        private void LoadData()
        {
            dsReview.shift.Columns.Add("Selected", typeof(bool));
            SetShiftFilter();
        }

        protected override XtraReport GetReportDataSource()
        {
            var ds = new  DatasetReport();
            BL.BLReport oBL;
            XtraReport rpt = null;
            if (ReportName == CommonUI.Enumeration.EnumReportName.BC3)
            {
                rpt = new ReportFile.ChangeShiftReportSummary();
            }
           
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                var dr = (Entities.DatasetReview.shiftRow)((DataRowView)gridView1.GetRow(i)).Row;
                if (dr != null && !dr["Selected"].Equals(DBNull.Value) && (bool)dr["Selected"])
                {
                    if (ReportName == CommonUI.Enumeration.EnumReportName.BC3)
                    {
                        oBL = new BL.BLReport(ds.ChangeShiftUserInfo.TableName, ds);
                        oBL.GetChangeShiftSummary(dr.SHIFT_ID);    
                    }
                }
            }
            rpt.DataSource = ds;
            return rpt;
        }
        #endregion

        #region Events
        /// <summary>
        /// Load Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeShiftParameterForm_Load(object sender, EventArgs e)
        {
            
        }

        private void chkCheckedAllUser_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkCheckedAllUser.Focused && chkCheckedAllUser.CheckState == CheckState.Indeterminate)
                {
                    chkCheckedAllUser.CheckStateChanged -= chkCheckedAllUser_CheckStateChanged;
                    chkCheckedAllUser.Checked = false;
                    chkCheckedAllUser.CheckStateChanged += chkCheckedAllUser_CheckStateChanged;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        /// <summary>
        /// Chọn/bỏ chọn tất cả nhân viên thu phí
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkCheckedAllUser_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                gridView1.ClearSelection();
                gridView1.RefreshData();
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    var dr = (DataRowView)gridView1.GetRow(i);
                    dr["Selected"] = chkCheckedAllUser.Checked;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void dateRange1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                SetShiftFilter();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void ChangeShiftSummaryParameterForm_Shown(object sender, EventArgs e)
        {
            try
            {
                LoadData();
                repositoryItemCheckEdit1.CheckedChanged += repositoryItemCheckEdit1_CheckedChanged;
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        void repositoryItemCheckEdit1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                chkCheckedAllUser.CheckedChanged -= chkCheckedAllUser_CheckedChanged;
                var iSelected = dsReview.shift.Select("Selected = 1").Length;
                if (((DevExpress.XtraEditors.CheckEdit)sender).CheckState == CheckState.Checked)
                {
                    iSelected++;
                }
                else
                {
                    iSelected--;
                }
                if (iSelected == 0)
                {
                    chkCheckedAllUser.Checked = false;
                }
                else if (iSelected == bsShift.Count)
                {
                    chkCheckedAllUser.Checked = true;
                }
                else
                {
                    chkCheckedAllUser.CheckState = CheckState.Indeterminate;

                }
                chkCheckedAllUser.CheckedChanged += chkCheckedAllUser_CheckedChanged;
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

       
        #endregion

       
    }
}
