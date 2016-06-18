using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using eReview01.BL;
using eReview01.CommonUI;
using eReview01.Source;

namespace eReview01.Source.Framework
{
    public partial class FormMasterBase: eReview01.Source.Framework.frmBase
    {
        #region Declaration
        private BLBase oBLBase;
        private BindingSource oMasterBindingSource;
        private BindingSource oDetailBindingSource;
        private eReview01.CDControl.CDGrid grdMasterList;
        private eReview01.CDControl.CDGrid grdDetailList;
        private DataSet dsSource;

        #endregion

        #region Contructor
        public FormMasterBase()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties
        public DataSet DatasetBusiness
        {
            get
            { return dsSource; }
            set { dsSource = value; }
        }
        public string MasterTableName { get; set; }
        public string DetailTableName { get; set; }

        public eReview01.CDControl.CDGrid GridMasterList
        {
            get { return grdMasterList; }
            set
            {
                grdMasterList = value;
                if (grdMasterList != null)
                {
                    grdMasterList.MouseDoubleClick += grdMasterList_MouseDoubleClick;
                    grdMasterList.ContextMenuStrip = cmsBase;
                }
            }
        }

       

        public eReview01.CDControl.CDGrid GridDetailList
        {
            get { return grdDetailList; }
            set { grdDetailList = value; }
        }

        /// <summary>
        /// Object BL use to insert/update/delete
        /// </summary>
        public BLBase BusinessObject
        {
            get { return oBLBase; }
            set { oBLBase = value; }
        }

        /// <summary>
        /// Define datasource binding on form: Master row
        /// </summary>
        public BindingSource MasterBindingSource
        {
            get { return oMasterBindingSource; }
            set
            {
                oMasterBindingSource = value;
                if (oMasterBindingSource != null)
                {
                    oMasterBindingSource.PositionChanged += oMasterBindingSource_PositionChanged;
                    MasterTableName = oMasterBindingSource.DataMember;
                }
            }

        }

        /// <summary>
        /// Define datasource binding on form: Detail row
        /// </summary>
        public BindingSource DetailBindingSource
        {
            get { return oDetailBindingSource; }
            set
            {
                oDetailBindingSource = value;
                if (oDetailBindingSource != null)
                {
                    DetailTableName = oDetailBindingSource.DataMember;
                }
            }
        }

        /// <summary>
        /// Define business for this sreen
        /// </summary>
        public virtual Enumeration.EnumRefType RefType { get; set; }

        
        #endregion

        #region Method/Function
        #region Private

        /// <summary>
        /// Định nghĩa lại các đối tượng khai báo trên form desire gồm grid, dataset, bindingsource,
        /// 
        /// </summary>

        /// <summary>
        /// Rebinding for dataobject
        /// </summary>
        protected virtual void BindingData()
        {
            if (oMasterBindingSource != null)
            {
                oMasterBindingSource.DataSource = DatasetBusiness;
                oMasterBindingSource.DataMember = MasterTableName;
                if(grdMasterList !=null) grdMasterList.DataSource = oMasterBindingSource;
            }
            if (oDetailBindingSource != null)
            {
                oDetailBindingSource.DataSource = DatasetBusiness;
                oDetailBindingSource.DataMember = DetailTableName;
              if (grdDetailList != null)  grdDetailList.DataSource = oDetailBindingSource;
            }
            // Binding control trên form
            foreach (Control oControl in this.Controls)
            {
                BindingDataToControl(oControl);   
            }
        }

        private void BindingDataToControl(Control oControl)
        {
            if (oControl.Tag == null || string.IsNullOrEmpty(oControl.Tag.ToString()))
            {
                foreach (Control item in oControl.Controls)
                {
                    BindingDataToControl(item);
                }
            }
            else
            {
                if (oControl.GetType() == typeof(DevExpress.XtraEditors.TextEdit) || oControl.GetType() == typeof(DevExpress.XtraEditors.MemoEdit))
                    oControl.DataBindings.Add("Text", oMasterBindingSource, oControl.Tag.ToString());
                else if (oControl.GetType() == typeof(DevExpress.XtraEditors.CheckEdit))
                    oControl.DataBindings.Add("Checked", oMasterBindingSource, oControl.Tag.ToString());
                else if (oControl.GetType() == typeof(DevExpress.XtraEditors.LookUpEdit) || oControl.GetType() == typeof(DevExpress.XtraEditors.GridLookUpEdit)
                    || oControl.GetType() == typeof(eReview01.CDControl.CDGridLookUpEdit) || oControl.GetType() == typeof(eReview01.CDControl.CDLookUpEnum))
                    oControl.DataBindings.Add("EditValue", oMasterBindingSource, oControl.Tag.ToString());
                else if (oControl.GetType() == typeof(eReview01.CDControl.CDComboTree))
                    oControl.DataBindings.Add("SelectedValue", oMasterBindingSource, oControl.Tag.ToString());
                
            }
        }
        #endregion

        

        #region public/Virtual
        /// <summary>
        /// Lấy dữ liệu danh mục
        /// </summary>
        protected virtual void GetDictionaryData()
        { }

        protected virtual void grdMasterList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                ToolClick(mnuEdit.Name);
            }
            catch (Exception ex)
            {
                CommonFunction.LogException(ex);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        protected virtual void AddVoucher()
        {
            ShowFormDetail(Enumeration.EnumEditMode.AddNew);
        }

        protected virtual void EditVoucher()
        {
            //if (this.RefType == Enumeration.EnumRefType.NoneVoucher)
            //    ShowFormDetail(Enumeration.EnumEditMode.Edit);
            //else
                ShowFormDetail(Enumeration.EnumEditMode.None);
        }


        protected virtual bool DeleteVoucher()
        {
            
            bool bResult = (CommonFunction.ShowYesNoMessage(eReview01.Properties.Resources.Confirm_WannaDeleteRecord) == DialogResult.Yes);
            if (bResult)
            {
                
                oMasterBindingSource.EndEdit();
                if (oDetailBindingSource != null) oDetailBindingSource.EndEdit();
                if (oBLBase == null)
                {
                    oBLBase = new BLBase(MasterTableName, DetailTableName, DatasetBusiness);
                }
                
                oBLBase.MasterRow = ((DataRowView)oMasterBindingSource.Current).Row;
               bResult = oBLBase.Delete();
               if (bResult)
               {
                   BusinessObject.MasterRow = GetCurrentRow();
                   if (grdDetailList != null && !string.IsNullOrEmpty(DetailTableName))
                   {
                       DatasetBusiness.Tables[DetailTableName].Clear();
                   }
                   BusinessObject.GetDetailByMasterID();
                   
               }
            }
            return bResult;
        }
        protected virtual FormDetailBase GetFormDetail()
        {
            return null;
        }

        protected virtual void ShowFormDetail(eReview01.CommonUI.Enumeration.EnumEditMode EditMode = Enumeration.EnumEditMode.None)
        {
            FormDetailBase frm = GetFormDetail();
            if (frm != null)
            {
                frm.MasterBindingSource = this.MasterBindingSource;
                frm.DetailBindingSource = this.DetailBindingSource;
                frm.MasterTableName = this.MasterTableName;
                frm.DetailTableName = this.DetailTableName;
                frm.BusinessObject = oBLBase;
                frm.DatasetBusiness = DatasetBusiness;
                frm.RefType = this.RefType;
                frm.EditMode = EditMode;
                frm.Owner = this;
                if (this.RefType == Enumeration.EnumRefType.NoneVoucher)
                {
                    frm.WindowState = FormWindowState.Normal;
                    frm.StartPosition = FormStartPosition.CenterParent;
                }
                else
                { frm.WindowState = FormWindowState.Maximized; }
                frm.Owner = this;
                if (EditMode == Enumeration.EnumEditMode.AddNew) frm.AddNewRow();
                frm.ShowDialog();
                SynchronizeCallBack();
                frm.Dispose();

            }
        }

        protected virtual void SynchronizeCallBack()
        {
            oMasterBindingSource_PositionChanged(oMasterBindingSource, new EventArgs());
        }

        public virtual void GetAllData()
        {
            if (grdMasterList != null)
                grdMasterList.LoadData();
            if (grdMasterList == null ||  grdMasterList.Views[0].RowCount == 0)
                if (oBLBase != null)
                    oBLBase.GetAllData();
        }


        /// <summary>
        /// Định nghĩa lại các biến cần thiết cho form
        /// </summary>
        protected virtual void RefineDataObject() { }

        protected virtual bool EditRow()
        {
            bool bResult = false;
            if (MasterBindingSource.Position >= 0)
            {
                EditVoucher();
            }
            return bResult;
        }

        /// <summary>
        /// Lấy current row hiện tại
        /// </summary>
        /// <returns></returns>
        protected DataRow GetCurrentRow()
        {
            if (oMasterBindingSource != null && oMasterBindingSource.Current != null)
            {
                return ((DataRowView)oMasterBindingSource.Current).Row;
            }
            else
                return null;
        }
        #endregion

        #region Private
        protected virtual void ToolClick(string sKey)
        {
            switch (sKey)
            {
                case "mnuNew":
                case "cteNew":
                    AddVoucher();
                    break;
                case "mnuEdit":
                case "cteEdit":
                    EditVoucher();
                    break;
                case "mnuDelete":
                case "cteDelete":
                    DeleteVoucher();
                    break;
                case "mnuRefesh":
                case "cteRefresh":
                    GetAllData();
                    break;
                default:
                    break;
            }
        }
        #endregion

        #endregion

        #region Events
        private void oMasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (this.DesignMode) return;
            try
            {
                if (oMasterBindingSource.Current != null && grdDetailList != null)
                {
                    if (oBLBase == null) oBLBase = new BLBase(MasterTableName, DetailTableName, DatasetBusiness);
                    oBLBase.MasterRow = ((DataRowView)oMasterBindingSource.Current).Row;
                    oBLBase.GetDetailByMasterID();
                }
                bool bEnable = (oMasterBindingSource.Current != null);
                mnuDelete.Enabled = bEnable;
                mnuEdit.Enabled = bEnable;
                cteDelete.Enabled = bEnable;
                cteEdit.Enabled = bEnable;   
            }
            catch (Exception ex)
            {
                CommonFunction.LogException(ex);
            }
        }

        private void MasterFormBase_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.DesignMode) return;
                RefineDataObject();               
                GetDictionaryData();
                BindingData();
             
            }
            catch (Exception ex)
            {
                CommonFunction.LogException(ex);
            }
        }

        private void FormMasterBase_Shown(object sender, EventArgs e)
        {
            try
            {
                if (this.DesignMode) return;
               // Khởi tao businessObject khi form desire không gán
                if (oBLBase == null) oBLBase = new BLBase(MasterTableName, DetailTableName, DatasetBusiness);
                if (grdMasterList == null || !grdMasterList.AutoGetData) GetAllData();
                oMasterBindingSource_PositionChanged(oMasterBindingSource, new EventArgs());
                
            }
            catch (Exception ex)
            {
                CommonFunction.LogException(ex);
            }
        }


        private void cmsBase_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (this.DesignMode) return;
                ToolClick(e.ClickedItem.Name);
            }
            catch (Exception ex)
            {
                CommonFunction.LogException(ex);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }


        /// <summary>
        /// Bấm nút
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuContext_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (this.DesignMode) return;
                ToolClick(e.ClickedItem.Name);
            }
            catch (Exception ex)
            {
                CommonFunction.LogException(ex);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        protected virtual void MasterBindingSourcePositionChange()
        {
            if (oMasterBindingSource.Current != null && grdDetailList != null)
            {
                if (oBLBase == null) oBLBase = new BLBase(MasterTableName, DetailTableName, DatasetBusiness);
                oBLBase.MasterRow = ((DataRowView)oMasterBindingSource.Current).Row;
                oBLBase.GetDetailByMasterID();
            }
            bool bEnable = (oMasterBindingSource.Current != null);
            mnuDelete.Enabled = bEnable;
            mnuEdit.Enabled = bEnable;
            //cteDelete.Enabled = bEnable;
            cteEdit.Enabled = bEnable;
        }

        protected virtual void RefreshData()
        {
            GetAllData();
        }
        #endregion

    }
}
