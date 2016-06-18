using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using eReview01.Source;
using eReview01.Source.Util;

namespace eReview01.CDControl
{
    [System.ComponentModel.ToolboxItem(true)]
    public class CDGridLookUpEdit : DevExpress.XtraEditors.GridLookUpEdit
    {
        #region Properties
        public eReview01.CommonUI.Enumeration.EnumBindingType BindingType { get; set; }
        public eReview01.CommonUI.Enumeration.EnumTableName TableNameEnum { get; set; }
        public bool AutoGetData { get; set; }
        public string WhereCause { get; set; }
        public string OrderBy { get; set; }
        public bool HasSelectAllItem { get; set; }
        #endregion

        public void LoadData()
        {
            if (this.DesignMode) return;
            string sDataMember = string.Empty;
            DataSet ds;
            if (this.Properties.DataSource.GetType() == typeof(DataTable))
            {
                ds = ((DataTable)this.Properties.DataSource).DataSet;
                sDataMember = ((DataTable)this.Properties.DataSource).TableName;
            }
            else if (this.Properties.DataSource.GetType() == typeof(System.Windows.Forms.BindingSource))
            {
                ds = (DataSet)((System.Windows.Forms.BindingSource)this.Properties.DataSource).DataSource;
                sDataMember = ((System.Windows.Forms.BindingSource)this.Properties.DataSource).DataMember;
            }
            else
            {
                ds = new DataSet();
                sDataMember = TableNameEnum.ToString();
                ds.Tables.Add(sDataMember);
                this.Properties.DataSource = ds.Tables[sDataMember];
            }
            ds.Tables[sDataMember].Clear();
            if (!string.IsNullOrEmpty(sDataMember))
            {
                BL.BLBase oBL = new BL.BLBase(sDataMember, string.Empty, ds);
                //oBL.GetAllDataByTableName(ds.Tables[sDataMember], this.WhereCause, this.OrderBy);
                oBL.GetAllData();
            }
            if (HasSelectAllItem && ds != null && ds.Tables[sDataMember] != null)
            {
                var drAll = ds.Tables[sDataMember].NewRow();
                Utils.SetDefaultValueDataRow(drAll);
                if (drAll.Table.Columns[this.Properties.DisplayMember].DataType == typeof(string))
                {
                    drAll[this.Properties.DisplayMember] = eReview01.Properties.Resources.SelectedAllText;
                }
                ds.Tables[sDataMember].Rows.Add(drAll);
                this.EditValue = drAll[this.Properties.ValueMember];
            }
        }


        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            if (this.DesignMode) return;
            try
            {
                this.Properties.PopupFormSize = this.CalcBestSize();
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
