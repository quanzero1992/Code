using eReview01.Source;
using eReview01.Source.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eReview01.CDControl
{
    [System.ComponentModel.ToolboxItem(true)]
   public class CDLookUpEnum : DevExpress.XtraEditors.LookUpEdit
    {
        public bool AutoGetData { get; set; }
        public bool HasSelectAllItem { get; set; }
        public void LoadData()
        {
            System.Type t = eReview01.CommonUI.Enumeration.GetEnumerationType(EnumString);
            if (t == null) return;
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add(CommonFunction.cst_EnumValue, typeof(int));
            dt.Columns.Add(CommonFunction.cst_EnumDisplay);
            foreach (Enum e in Enum.GetValues(t))
            {
                dt.Rows.Add(
                     Convert.ToInt32(e),
                  eReview01.Properties.Resources.ResourceManager.GetString(t.Name
                      + "_" + Enum.GetName(t, e))
                 );
            }
            if (HasSelectAllItem)
            {
                dt.Rows.Add(DBNull.Value, eReview01.Properties.Resources.SelectedAllText);
            }
            dt.DefaultView.Sort = CommonFunction.cst_EnumValue;
            this.Properties.DataSource = dt;
            this.Properties.ValueMember = CommonFunction.cst_EnumValue;
            this.Properties.DisplayMember = CommonFunction.cst_EnumDisplay;
            foreach (DevExpress.XtraEditors.Controls.LookUpColumnInfo col in this.Properties.Columns)
            {
                col.Visible = false;
            }
            this.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo(CommonFunction.cst_EnumDisplay, 150, ""));
            if (HasSelectAllItem)
            {
                this.SelectedText = eReview01.Properties.Resources.SelectedAllText;
            }
        }
        public eReview01.CommonUI.Enumeration.EnumType EnumString { get; set; }
        protected override void OnCreateControl()
        {
            try
            {
                base.OnCreateControl();
                if (this.DesignMode) return;
                this.Properties.PopupFormMinSize = this.CalcBestSize();
                // Tự động gán sự kiện set null khi giá trị nhập là trắng
                this.Leave += new System.EventHandler(Utils.EventLeaveSetEmptyValue);
                this.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Utils.EventClearComboSelect);
                if (AutoGetData) LoadData();
            }
            catch (Exception ex)
            {
                CommonFunction.LogException(ex);
            }

        }
    }
}
