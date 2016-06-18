using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace eReview01.CDControl
{
    [System.ComponentModel.ToolboxItem(true)]
    public class CDComboTree : DevExpress.XtraTreeList.TreeList
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
            if (this.DataSource != null)
            {
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
                }
            }
            else
            {
                ds = new DataSet();
                sDataMember = TableNameEnum.ToString();
                ds.Tables.Add(sDataMember);
                this.DataSource = ds.Tables[sDataMember];
            }
            ds.Tables[sDataMember].Clear();
            if (!string.IsNullOrEmpty(sDataMember))
            {
                BL.BLBase oBL = new BL.BLBase(sDataMember, string.Empty, ds);
                oBL.GetAllDataByTableName(ds.Tables[sDataMember], this.WhereCause, this.OrderBy);
            }



            //if (string.IsNullOrEmpty(ParentField)) ParentField = "ParentID";
            //DevComponents.AdvTree.Node node;
            //foreach (DataRow row in ds.Tables[sDataMember].Select(ParentField + " IS NULL"))
            //{
            //    // add các row node cha
            //    if (string.IsNullOrEmpty(row[ParentField].ToString()))
            //    {

            //        node = new DevComponents.AdvTree.Node();
            //        node.Name = row[this.ValueMember].ToString();
            //        node.Text = row[this.DisplayMembers].ToString();
            //        this.Nodes.Add(node);
            //        LoadAllChild(Convert.ToInt32(node.Name), node, ds.Tables[sDataMember]);
            //    }
            //}
        }

        //protected void LoadAllChild(int TopID, DevComponents.AdvTree.Node root, DataTable dt)
        //{
        //    DevComponents.AdvTree.Node node;
        //    foreach (DataRow r in dt.Select(ParentField + " = " + TopID.ToString()))
        //    {
        //        node = new DevComponents.AdvTree.Node();
        //        node.Text = r[this.DisplayMembers].ToString();
        //        node.Name = r[this.ValueMember].ToString();
        //        root.Nodes.Add(node);
        //        LoadAllChild(Convert.ToInt32(node.Name  ), node,dt);
        //    }
        //}
    }
}