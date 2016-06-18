using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace eReview01.Source.Util
{
    public class Utils
    {
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
                CommonFunction.LogException(ex);
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
                    //if (sender.GetType() == typeof(MDevX.MDevXGridLookUpEdit))
                    //{
                    //    ((MDevX.MDevXGridLookUpEdit)sender).ClosePopup();
                    //}
                    //else if (sender.GetType() == typeof(MDevX.MDevXGridLookUpEdit))
                    //{
                    //    ((MDevX.MDevXLookUpEdit)sender).ClosePopup();
                    //}

                    sender.GetType().GetProperty("EditValue").SetValue(sender, null, null);
                }
            }
            catch (Exception ex)
            {
                CommonFunction.LogException(ex);
            }
        }

        public static void SetDefaultValueDataRow(DataRow dr)
        {
            foreach (DataColumn col in dr.Table.Columns)
            {
                if (col.AllowDBNull) continue;
                if (col.DataType == typeof(string))
                {
                    dr[col.ColumnName] = string.Empty;
                }
                else if (IsNumericType(col.DataType))
                {
                    dr[col.ColumnName] = -1;
                }
                else if (col.DataType == typeof(bool))
                {
                    dr[col.ColumnName] = false;
                }
                else if (col.DataType == typeof(Guid))
                {
                    dr[col.ColumnName] = Guid.NewGuid();
                }
                else if (col.DataType == typeof(DateTime))
                {
                    dr[col.ColumnName] = DateTime.Today.AddYears(-100);
                }
            }
        }
        private static HashSet<Type> NumericTypes = new HashSet<Type>
    {
        typeof(int),
        typeof(uint),
        typeof(double),
        typeof(decimal),
       typeof(float),
       typeof(long),
       typeof(float)
    };

        internal static bool IsNumericType(Type type)
        {
            return NumericTypes.Contains(type) ||
                   NumericTypes.Contains(Nullable.GetUnderlyingType(type));
        }
    }
}