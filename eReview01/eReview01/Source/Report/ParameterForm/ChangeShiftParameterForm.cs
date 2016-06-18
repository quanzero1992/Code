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
    public partial class ChangeShiftParameterForm : eReview01.Source.Report.ParameterForm.ParameterForm
    {
        #region Declaration 
        private Logger logger = LogManager.GetLogger(typeof(ChangeShiftParameterForm));
        #endregion

        #region Contructor
        public ChangeShiftParameterForm()
        {
            InitializeComponent();
            
        }
        #endregion

        #region Properties
        #endregion

        #region Method

        /// <summary>
        /// Nạp dữ liệu cho các control trên form tham số
        /// </summary>
        private void LoadData()
        {
            var oBL = new BL.BLBase();
            oBL.DataSource = dsReview;
            oBL.TableMasterName = dsReview.shift_type.TableName;
            oBL.GetAllData();
            oBL.TableMasterName = dsReview.user_info.TableName;
            oBL.GetAllData();
        }

        private void LoadShiftInfo()
        {
            dsReview.shift_info.Clear();
            chkCheckedAllUser.Checked = false;
            var oBL = new BL.BLShift();
            oBL.DataSource = dsReview;
            oBL.TableMasterName = dsReview.shift_info.TableName;
            oBL.SearchShiftInfoByTimeAndType(dateRange1.FromDate, dateRange1.ToDate, glueShiftType.EditValue.ConvertToInt());
        }
        protected override XtraReport GetReportDataSource()
        {
            var ds = new  DatasetReport();
            BL.BLReport oBL;
            XtraReport rpt = null;
            if (ReportName == Enumeration.EnumReportName.BC1)
            {
                rpt = new Report.ReportFile.ChangeShiftReport();
            }
            else if (ReportName == Enumeration.EnumReportName.BC2)
            {
                rpt = new Report.ReportFile.BC2Report();
            }
            oBL = new BL.BLReport(string.Empty, ds);
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                var dr = (Entities.DatasetReview.shift_infoRow)((DataRowView)gridView1.GetRow(i)).Row;
                if (dr != null && !dr["Selected"].Equals(DBNull.Value) && (bool)dr["Selected"])
                {
                    if (ReportName == Enumeration.EnumReportName.BC1)
                    {
                        oBL.TableMasterName = ds.ChangeShiftUserInfo.TableName;
                        oBL.GetChangeShiftForUserInfo(dr.SHI_INF_ID);  
                    }
                    else if (ReportName == Enumeration.EnumReportName.BC2)
                    {
                        oBL.TableMasterName = ds.BC2.TableName;
                        oBL.GetBC2(dr.SHI_INF_ID);  
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
            try
            {
                if (!dsReview.shift_info.Columns.Contains("Selected")) dsReview.shift_info.Columns.Add("Selected", typeof(bool));
                LoadData();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
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
                LoadShiftInfo();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void glueShiftType_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                LoadShiftInfo();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void ChangeShiftParameterForm_Shown(object sender, EventArgs e)
        {
            try
            {
                LoadShiftInfo();
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
                var iSelected = dsReview.shift_info.Select("Selected = 1").Length;
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
                else if (iSelected == bsShiftInfo.Count)
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

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
