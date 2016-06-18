using eReview01.Source;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace eReview01.CDControl
{
    [System.ComponentModel.ToolboxItem(true)]
   public class CDGrid : DevExpress.XtraGrid.GridControl
    {
        #region Properties
       public CommonUI.Enumeration.EnumBindingType BindingType { get; set; }
        public CommonUI.Enumeration.EnumTableName TableNameEnum { get; set; }
        public bool AutoGetData { get; set; }
        public string WhereCause { get; set; }
        public string OrderBy { get; set; }
        #endregion

        public void LoadData()
        {
            string sDataMember = string.Empty;
            DataSet ds;
            if (this.DataSource.GetType() == typeof(DataTable))
            {
                ds = ((DataTable)this.DataSource).DataSet;
                sDataMember = ((DataTable)this.DataSource).TableName;
            }
            else if (this.DataSource.GetType() == typeof(System.Windows.Forms.BindingSource))
            {
                ds = (DataSet)((System.Windows.Forms.BindingSource)this.DataSource).DataSource;
                sDataMember = ((System.Windows.Forms.BindingSource)this.DataSource).DataMember;
            }
            else
            {
                ds = new DataSet();
                sDataMember = TableNameEnum.ToString();
                ds.Tables.Add(sDataMember);
                this.DataSource = ds.Tables[sDataMember];
            }
            ds.Tables[sDataMember].Clear();
            // Cho nay can sua lai khi gan datasource la binding source hay cai kkhacz
            if (!string.IsNullOrEmpty(sDataMember))
            {
                BL.BLBase oBL = new BL.BLBase(sDataMember, string.Empty, ds);
                oBL.GetAllDataByTableName(ds.Tables[sDataMember], this.WhereCause, this.OrderBy);
            }
        }

        protected override void OnCreateControl()
        {
            try
            {
                base.OnCreateControl();
            if (this.DesignMode || !AutoGetData) return;
            LoadData();
            }
            catch (Exception ex)
            {
                CommonFunction.LogException(ex);
            }   
        }
    }
}
