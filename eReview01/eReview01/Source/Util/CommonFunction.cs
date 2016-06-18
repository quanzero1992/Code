using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using log4net;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace eReview01.Source
{
    public class MyLocalizer : DevExpress.XtraEditors.Controls.Localizer
    {
        public override string GetLocalizedString(DevExpress.XtraEditors.Controls.StringId id)
        {
            if (id == DevExpress.XtraEditors.Controls.StringId.XtraMessageBoxAbortButtonText)
            {
                return Properties.Resources.XtraMessage_Abort;
            }

            else if (id == DevExpress.XtraEditors.Controls.StringId.XtraMessageBoxCancelButtonText)
            {
                return Properties.Resources.XtraMessage_Cancel;
            }
            else if (id == DevExpress.XtraEditors.Controls.StringId.XtraMessageBoxIgnoreButtonText)
            {
                return Properties.Resources.XtraMessage_Ignore;
            }
            else if (id == DevExpress.XtraEditors.Controls.StringId.XtraMessageBoxNoButtonText)
            {
                return Properties.Resources.XtraMessage_No;
            }
            else if (id == DevExpress.XtraEditors.Controls.StringId.XtraMessageBoxOkButtonText)
            {
                return Properties.Resources.XtraMessage_Ok;
            }
            else if (id == DevExpress.XtraEditors.Controls.StringId.XtraMessageBoxRetryButtonText)
            {
                return Properties.Resources.XtraMessage__Retry;
            }
            else if (id == DevExpress.XtraEditors.Controls.StringId.XtraMessageBoxYesButtonText)
            {
                return Properties.Resources.XtraMessage_Yes;
            }
            return base.GetLocalizedString(id);
        }
    }

    //public static class DataUtility
    //{
    //    public static DateTime ConvertToDateTime(this object obj)
    //    {
    //        if (obj == null || obj == DBNull.Value || string.IsNullOrEmpty(obj.ToString())) return DateTime.MinValue;
    //        try
    //        {
    //            return Convert.ToDateTime(obj);
    //        }
    //        catch
    //        {
    //            return DateTime.MinValue;
    //        }
    //    }
    //    public static Int32 ConvertToInt(this object obj, int defaultValue = 0)
    //    {
    //        if (obj == DBNull.Value) return defaultValue;
    //        try
    //        {
    //            return Convert.ToInt32(obj);
    //        }
    //        catch
    //        { return defaultValue; }
    //    }

    //    public static decimal ConvertToDecimal(this object obj, int defaultValue = 0)
    //    {
    //        if (obj == DBNull.Value) return defaultValue;
    //        try
    //        {
    //            return Convert.ToDecimal(obj);
    //        }
    //        catch
    //        { return defaultValue; }
    //    }

    //    public static double ConvertToDouble(this object obj, int defaultValue = 0)
    //    {
    //        if (obj == null || obj == DBNull.Value || string.IsNullOrEmpty(obj.ToString())) return defaultValue;
    //        try
    //        {
    //            return Convert.ToDouble(obj);
    //        }
    //        catch
    //        { return defaultValue; }
    //    }
    //}

    public class CommonFunction
    {
        public const string cst_EnumValue = "EnumValue";
        public const string cst_EnumDisplay = "EnumDisplay";

        public static void AddCommonParametersReport(DevExpress.XtraReports.UI.XtraReport report)
        {
            report.Parameters.Add(new DevExpress.XtraReports.Parameters.Parameter() { Type = typeof(string), Value = eReview01.Source.Personal.CustomerName, Name = Properties.Resources.Config_CompanyName, Description = "Đơn vị" });
            report.Parameters.Add(new DevExpress.XtraReports.Parameters.Parameter() { Type = typeof(string), Value = eReview01.Source.Personal.CustomerName, Name = Properties.Resources.Config_Address, Description = "Địa chỉ" });
        }

        /// <summary>
        /// Tao table cua enum
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static System.Data.DataTable CreateEnumTable(CommonUI.Enumeration.EnumType eType)
        {
            System.Type t = CommonUI.Enumeration.GetEnumerationType(eType);
            if (t == null) return null;
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add(cst_EnumValue);
            dt.Columns.Add(cst_EnumDisplay);
            foreach (Enum e in Enum.GetValues(t))
            {
                dt.Rows.Add(
                     Convert.ToInt32(e),
                     eReview01.Properties.Resources.ResourceManager.GetString(t.Name
                      + "_" + Enum.GetName(t, e))
                 );
            }
            return dt;
        }
        public static void LogException(Exception ex)
        {
            // --- Quân edit 08-10
            if (ex is MySql.Data.MySqlClient.MySqlException)
            {
                XtraMessageBox.Show("Vui lòng kiểm tra kết nối cơ sở dữ liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // end edit

            StackTrace stackTrace = new StackTrace();
            ILog logger = LogManager.GetLogger(stackTrace.GetFrame(1).GetMethod().DeclaringType);
            logger.Error(ex);// Right
            logger.Error(ex.Message);// Wrong. Because most time, the ex.Message is useless.
            if (!string.IsNullOrEmpty(ex.Message))
            {
                ShowExceptionMessage(ex.Message);
            }
        }

        public static System.Windows.Forms.DialogResult ShowYesNoCancelMessage(string strMessage)
        {
            return XtraMessageBox.Show(strMessage, System.Windows.Forms.Application.ProductName, System.Windows.Forms.MessageBoxButtons.YesNoCancel, System.Windows.Forms.MessageBoxIcon.Warning);
        }

        public static System.Windows.Forms.DialogResult ShowYesNoMessage(string strMessage)
        {
            return XtraMessageBox.Show(strMessage, System.Windows.Forms.Application.ProductName, System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Warning);
        }

        public static System.Windows.Forms.DialogResult ShowWarningMessage(string strMessage)
        {
            return XtraMessageBox.Show(strMessage, System.Windows.Forms.Application.ProductName, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
        }

        public static System.Windows.Forms.DialogResult ShowExceptionMessage(string strMessage)
        {
            return XtraMessageBox.Show(strMessage, System.Windows.Forms.Application.ProductName, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }

        public static System.Windows.Forms.DialogResult ShowInfomationMessage(string strMessage)
        {
            return DevExpress.XtraEditors.XtraMessageBox.Show(strMessage, System.Windows.Forms.Application.ProductName, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }

        public static void EventLeaveSetEmptyValue(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(sender.GetType().GetProperty("Text").GetValue(sender, null).ToString()))
                {
                    sender.GetType().GetProperty("EditValue").SetValue(sender, null, null);
                }
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
        }

        /// <summary>
        /// Xóa nhanh lựa chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void EventClearComboSelect(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
                {
                    sender.GetType().GetProperty("EditValue").SetValue(sender, null, null);
                }
            }
            catch (Exception ex)
            {
                CommonFunction.LogException(ex);
            }
        }
                     
        public static void LogException(Exception ex, bool showMessage = true)
        {
            StackTrace stackTrace = new StackTrace();
            ILog logger = LogManager.GetLogger(stackTrace.GetFrame(1).GetMethod().DeclaringType);
            logger.Error(ex);// Right
            logger.Error(ex.Message);// Wrong. Because most time, the ex.Message is useless.
            if (showMessage && !string.IsNullOrEmpty(ex.Message))
            {
                ShowExceptionMessage(ex.Message);
            }
                  
        }
            
            
    }
    
}