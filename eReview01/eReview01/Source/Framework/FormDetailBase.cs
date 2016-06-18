using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using eReview01.BL;
using eReview01.CommonUI;
using System.Data.SqlClient;

namespace eReview01.Source.Framework
{
    public partial class FormDetailBase : eReview01.Source.Framework.frmBase
    {
        #region Declaration
        private Logger logger = LogManager.GetLogger(typeof(FormDetailBase));
        private string _masterFieldName = "RefID";
        private string _detailFieldName = "RefDetailID";
        protected const string cst_REFTYPE_FIELD = "RefType";
        private BL.BLBase oBLBase;
        private BindingSource oMasterBindingSource;
        private BindingSource oDetailBindingSource;
        private DataSet oDatasetBusiness;
        private Enumeration.EnumRefType eRefType;
        private CDControl.CDGrid grdDetailList;
        private Enumeration.EnumEditMode eEditMode;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDetail;
        private string _masterTableName;
        private string _detailTableName;
        private string _codeField = string.Empty;
        #endregion

        #region Contructor
        public FormDetailBase()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties
        public string CodeField
        {
            get; set;
            //get { return _codeField; }
            //set
            //{
            //    if (DesignMode) return;
            //    _codeField = value;
            //    if (DesignMode) return;
            //    if (BusinessObject != null)
            //    {
            //        BusinessObject.CodeField = value;
            //    }
            //}
        }
        public string MasterFieldName { get { return _masterFieldName; } set { _masterFieldName = value; } }
        public string DetailFieldName { get { return _detailFieldName; } set { _detailFieldName = value; } }
        public string MasterTableName
        {
            get { return _masterTableName; }
            set
            {
                _masterTableName = value;
                if (oDatasetBusiness != null)
                {
                    _masterFieldName = DatasetBusiness.Tables[value].PrimaryKey[0].ColumnName;
                }
            }
        }
        public string DetailTableName
        {
            get { return _detailTableName; }
            set
            {
                _detailTableName = value;
                if (oDatasetBusiness != null)
                {
                    _detailFieldName = DatasetBusiness.Tables[value].PrimaryKey[0].ColumnName;
                }
            }
        }

        public DataSet DatasetBusiness
        {
            get { return oDatasetBusiness; }
            set { oDatasetBusiness = value;
            oDatasetBusiness = value;
            if (!string.IsNullOrEmpty(_masterTableName) && oDatasetBusiness.Tables[_masterTableName].PrimaryKey.Length > 0)
            {
                _masterFieldName = oDatasetBusiness.Tables[_masterTableName].PrimaryKey[0].ColumnName;
            }
            if (!string.IsNullOrEmpty(_detailTableName) && oDatasetBusiness.Tables[_detailTableName].PrimaryKey.Length > 0)
            {
                _detailFieldName = oDatasetBusiness.Tables[_detailTableName].PrimaryKey[0].ColumnName;
            }
            }

        }

        /// <summary>
        /// Object BL use to insert/update/delete
        /// </summary>
        public BL.BLBase BusinessObject
        {
            get
            {

                if (!DesignMode && oBLBase == null)
                {
                    oBLBase = new BLBase();
                }
                return oBLBase; }
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
                // Đã có trên master
                //if (oMasterBindingSource != null)
                //    oMasterBindingSource.PositionChanged += oMasterBindingSource_PositionChanged;
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
            }
        }

        
        /// <summary>
        /// Define business for this sreen
        /// </summary>
        public Enumeration.EnumRefType RefType
        {
            get { return eRefType; }
            set
            {
                eRefType = value;
            }
        }

        public Enumeration.EnumEditMode EditMode
        {
            get { return eEditMode; }
            set
            {
                eEditMode = value;
                RefreshToolbar();
            }
        }


        public CDControl.CDGrid GridDetailList
        {
            get { return grdDetailList; }
            set
            {
                grdDetailList = value;
                if (grdDetailList != null)
                {
                    gvDetail = (DevExpress.XtraGrid.Views.Grid.GridView)grdDetailList.Views[0];
                    if (gvDetail != null) gvDetail.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.ViewDetail_InitNewRow);
                    SetStatusGrid();
                }
            }
        }
        #endregion

        #region Method/Function
        #region Private
        private void SetStatusGrid()
        {
            if (grdDetailList != null)
            {
                bool bIsView = (eEditMode == Enumeration.EnumEditMode.None);
                DevExpress.XtraGrid.Views.Grid.GridView mainView = (DevExpress.XtraGrid.Views.Grid.GridView)grdDetailList.MainView;
                if (bIsView)
                {
                    mainView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
                    mainView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
                    mainView.OptionsSelection.EnableAppearanceFocusedCell = false;
                    mainView.OptionsBehavior.Editable = false;
                }
                else
                {
                    mainView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
                    mainView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
                    mainView.OptionsSelection.EnableAppearanceFocusedCell = true;
                    mainView.OptionsBehavior.Editable = true;
                }
            }

        }

        // Đã làm trò này ở master nên không cần phải làm trên desire nữa
        //private void oMasterBindingSource_PositionChanged(object sender, EventArgs e)
        //{
        //    if (oMasterBindingSource.Current != null && grdDetailList != null)
        //    {
        //        oBLBase.GetDetailByMasterID();
        //    }
        //    bool bEnable = (oMasterBindingSource.Current != null);
        //    mnuDelete.Enabled = bEnable;
        //    mnuEdit.Enabled = bEnable;
        //}
        #endregion

        #region Protect/Public
        /// <summary>
        /// Xóa dòng trên grid detail
        /// </summary>
        protected virtual void DeleteDetailRow()
        {
            if (gvDetail != null)
            {
                var i = gvDetail.FocusedRowHandle;
                if (i >= 0)
                {
                    gvDetail.DeleteRow(i);
                }
            }
        }

        /// <summary>
        /// Thêm dòng mới trên grid detail
        /// </summary>
        protected virtual void InsertNewDetailRow()
        {
            gvDetail.AddNewRow();
        }

        protected virtual void LoadDefaultCode()
        {
            // Load default code
            //if (eEditMode == Enumeration.EnumEditMode.AddNew && !string.IsNullOrEmpty(_codeField))
            //{
            //    var currentRow = GetCurrentRow();
            //    if (currentRow != null && string.IsNullOrEmpty(currentRow[_codeField].ToString()))
            //    {
            //        currentRow[_codeField] = oBLBase.GetAutoVoucherCode(_masterTableName);
            //    }
            //}
        }

        /// <summary>
        /// trạng thái button tùy theo các trạng thái edit form
        /// </summary>
        protected virtual void RefreshToolbar()
        {
            bool bIsView = (eEditMode == Enumeration.EnumEditMode.None);
            mnuDelete.Enabled = bIsView && MasterBindingSource != null && MasterBindingSource.Position >= 0;
            mnuCancel.Enabled = !bIsView;
            mnuEdit.Enabled = (bIsView && MasterBindingSource != null && MasterBindingSource.Position >= 0);
            mnuForward.Enabled = (bIsView && MasterBindingSource != null && MasterBindingSource.Position < MasterBindingSource.Count - 1);
            mnuNew.Enabled = bIsView;
            mnuPrevious.Enabled = (bIsView && MasterBindingSource.Position > 0);
            mnuRefesh.Enabled = bIsView;
            mnuSave.Enabled = !bIsView;
            SetEnableDisbleControl(this, !bIsView);
            mnuPrint.Enabled = bIsView && MasterBindingSource != null && MasterBindingSource.Position >= 0;
            cmsBase.Enabled = !bIsView;
            biMonthBarcode.Enabled = bIsView && MasterBindingSource != null && MasterBindingSource.Position >= 0;
            SetStatusGrid();
            // Load default code
            if (eEditMode == Enumeration.EnumEditMode.AddNew && !string.IsNullOrEmpty(_codeField))
            {
                LoadDefaultCode();
            }
        }

        private void SetEnableDisbleControl(Control oControl, bool isEdit)
        {
           if (oControl.Tag !=null && !string.IsNullOrEmpty(oControl.Tag.ToString())) oControl.Enabled = isEdit;
            foreach (Control oChild in oControl.Controls)
            {
                SetEnableDisbleControl(oChild, isEdit);
            }
            
        }
        protected virtual void MoveNext()
        {
            MasterBindingSource.MoveNext();
            RefreshToolbar();
        }
        protected virtual void MovePrevious()
        {
            MasterBindingSource.MovePrevious();
            RefreshToolbar();
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

        /// <summary>
        /// Thêm dòng mới
        /// </summary>
        public virtual void AddNewRow()
        {
            DataRow dr = DatasetBusiness.Tables[MasterTableName].NewRow();
            foreach (DataColumn col in DatasetBusiness.Tables[MasterTableName].Columns)
            {
                if (!col.AllowDBNull)
                {
                    if (col.DataType == typeof(System.Int32))
                    {
                        if (!col.AutoIncrement) dr[col.ColumnName] = 0;
                    }
                    else if (col.DataType == typeof(System.String))
                    {
                        dr[col.ColumnName] = string.Empty;
                    }
                    else if (col.DataType == typeof(Guid))
                    {
                        dr[col.ColumnName] = new Guid();
                    }
                    else if (col.DataType == typeof(double) || col.DataType == typeof(Decimal))
                    {
                        dr[col.ColumnName] = 0;
                    }
                    else if (col.DataType == typeof(Boolean))
                    {
                        dr[col.ColumnName] = false;
                    }
                    else if (col.DataType == typeof(DateTime))
                    {
                        dr[col.ColumnName] = DateTime.Now;
                    }
                }
            }
            DatasetBusiness.Tables[MasterTableName].Rows.InsertAt(dr, 0);
            MasterBindingSource.MoveFirst();
            if (oBLBase != null) oBLBase.MasterRow = dr;
            EditMode = Enumeration.EnumEditMode.AddNew;
        }

        /// <summary>
        /// Thêm dòng detail mới
        /// </summary>
        public virtual void AddNewRowDetail()
        {
            DataRow dr = ((DataRowView)DetailBindingSource.Current).Row;
            DataRow drOld = null;
            if (oDetailBindingSource.Count > 1)
            {
                for (int i = DatasetBusiness.Tables[DetailTableName].Rows.Count - 1; i >= 0; i--)
                {
                    if (DatasetBusiness.Tables[DetailTableName].Rows[i].RowState != DataRowState.Deleted)
                    {
                        drOld = DatasetBusiness.Tables[DetailTableName].Rows[i];
                        break;
                    }
                }
            }
            foreach (DataColumn col in DatasetBusiness.Tables[DetailTableName].Columns)
            {
                if (oDetailBindingSource.Count == 1)
                {
                    //Nếu là dòng đầu tiên thì gán mặc định một số thứ
                    if (col.ColumnName.Equals(_masterFieldName))
                    {
                        dr[col.ColumnName] = ((DataRowView)oMasterBindingSource.Current).Row[_masterFieldName];
                    }
                    else if (!col.AllowDBNull)
                    {
                        if (col.DataType == typeof(System.Int32))
                        {
                            if (!col.AutoIncrement) dr[col.ColumnName] = 0;
                        }
                        else if (col.DataType == typeof(System.String))
                        {
                            dr[col.ColumnName] = string.Empty;
                        }
                        else if (col.DataType == typeof(Guid))
                        {
                            dr[col.ColumnName] = new Guid();
                        }
                        else if (col.DataType == typeof(double) || col.DataType == typeof(Decimal))
                        {
                            dr[col.ColumnName] = 0D;
                        }
                        else if (col.DataType == typeof(Boolean))
                        {
                            dr[col.ColumnName] = false;
                        }
                        else if (col.DataType == typeof(DateTime))
                        {
                            dr[col.ColumnName] = DateTime.Now;
                        }
                    }
                }
                else if (drOld !=null)
                {
                    // Còn là dòng thứ 2 trở đi thì sẽ lấy giá trị đã nhập từ dòng trước để gán sang
                    //if (!col.ColumnName.Equals(_detailFieldName)) dr[col] = drOld[col];
                    if (col.ColumnName.Equals(_masterFieldName))
                    {
                        dr[col.ColumnName] = ((DataRowView)oMasterBindingSource.Current).Row[_masterFieldName];
                    }
                }
            }
        }

        /// <summary>
        /// Validate một số thứ trước khi save
        /// </summary>
        /// <returns></returns>
        public virtual bool ValidateBeforeSave()
        {
            bool bValid = dxValidationProvider1.Validate();
            
            DataRow dr = GetCurrentRow();
            if (dr==null) bValid = false;
            if (bValid)
            {
                try
                {
                    oMasterBindingSource.EndEdit();
                }
                catch (SqlException ex)
                {
                    int i = ex.ErrorCode;
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("is constrained to be unique"))
                    {
                        string sField = ex.Message.Split('\'')[1].Trim();
                        CommonFunction.ShowWarningMessage(string.Format(Properties.Resources.Warning_DupplicateCode,
                            oDatasetBusiness.Tables[MasterTableName].Columns[sField].Caption));
                        oMasterBindingSource.ResumeBinding();
                        Control oControl = FindControlByTag(this, sField);
                        if (oControl != null)
                        {
                            // Fake binding lại bindingsource
                            // CỦ CHUỐI CẢ NẢI
                            oControl.Text = string.Empty;
                            oControl.Text = ex.Message.Split('\'')[3].Trim();
                        }
                        bValid = false;
                    }
                }
                if (grdDetailList != null && oDetailBindingSource.Count == 0)
                {
                    bValid = false;
                    CommonFunction.ShowWarningMessage(Properties.Resources.Warning_MustEnterDetail);
                }
            }

            return bValid; 
        }

        private Control FindControlByTag(Control oControl, string tag)
        {
            Control oResult = null;
            if (oControl.Tag !=null && oControl.Tag.ToString().Equals(tag))
            {
                oResult = oControl;
            }
            else
            {
                foreach (Control item in oControl.Controls)
                {
                    oResult = FindControlByTag(item, tag);
                    if (oResult != null) return oResult;
                }
            }
            return oResult;
        }

        public virtual bool ValidateBeforeDelete()
        { return true; }

        public virtual bool DeleteVoucher()
        {
            bool bResult = (CommonFunction.ShowYesNoMessage(Properties.Resources.Confirm_WannaDeleteRecord) == DialogResult.Yes && ValidateBeforeDelete());

            if (!bResult) return false;
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
                if (!string.IsNullOrEmpty(DetailTableName))
                    DatasetBusiness.Tables[DetailTableName].Clear();
                BusinessObject.MasterRow = GetCurrentRow();
                BusinessObject.GetDetailByMasterID();
            }
            if (oMasterBindingSource.Count == 0)
            {
                this.Close();
            }
            return bResult;
        }

        public virtual void PrepareSaveData()
        { }

        protected void FocusOnForm(Control ctrl)
        {
            if (ctrl.GetType().BaseType != typeof(FormDetailBase) && ctrl.CanFocus)
            {
                ctrl.Focus();
                return;
            }
            else
            {
                foreach (Control oControl in ctrl.Controls)
                {
                    if (oControl.GetType() != typeof(CDControl.CDGrid))
                    {
                        FocusOnForm(oControl);
                    }
                }
            }
        }
        public virtual bool SaveData()
        {
            FocusOnForm(this);
            try
            {
                oMasterBindingSource.EndEdit(); 
                if (oDetailBindingSource != null) oDetailBindingSource.EndEdit();
            }
            catch (Exception ex)
            {
                oMasterBindingSource.ResetCurrentItem();
                if (ex.Message.ToLower().Contains("is constrained to be unique"))
                {
                    var i = ex.Message.IndexOf("Value '");
                    var j = ex.Message.LastIndexOf("'");
                    if (i >= 0 && (j - 2) >= i)
                    {
                        throw new Exception(string.Format(Properties.Resources.Warning_DupplicateCode,
                            ex.Message.Substring(i + 8, j - i - 8)));
                    }
                    else
                    { throw ex; }
                }
                else
                {
                    throw ex;
                }
            }
            
            //oDetailBindingSource.EndEdit();
            PrepareSaveData();
            bool bResult = ValidateBeforeSave();
            if (bResult)
            {
                if (oDetailBindingSource != null) oDetailBindingSource.EndEdit();
                if (oBLBase == null)
                {
                    oBLBase = new BLBase(MasterTableName, DetailTableName, DatasetBusiness);
                }
                oBLBase.MasterRow = ((DataRowView)oMasterBindingSource.Current).Row;
                if (oDatasetBusiness.Tables[MasterTableName].Columns.Contains(cst_REFTYPE_FIELD))
                {
                    oBLBase.MasterRow[cst_REFTYPE_FIELD] = RefType;
                }
                if (EditMode == Enumeration.EnumEditMode.AddNew)
                {
                   bResult = oBLBase.Insert();
                }
                else if (EditMode == Enumeration.EnumEditMode.Edit)
                {
                    bResult = oBLBase.Update();
                }
                if (bResult)
                {
                    DatasetBusiness.AcceptChanges();
                    EditMode = Enumeration.EnumEditMode.None;
                }
                else
                {
                    CommonFunction.ShowExceptionMessage(Properties.Resources.Exception_SaveFail);
                    //DatasetBusiness.RejectChanges();
                }
            }
            return bResult;
        }

        protected virtual void CloseForm()
        {
            this.Close();
        }

        protected virtual void CancelEdit()
        {
            DatasetBusiness.RejectChanges();
            BusinessObject.MasterRow = GetCurrentRow();
            BusinessObject.GetDetailByMasterID();
            EditMode = Enumeration.EnumEditMode.None;
            if (MasterBindingSource.Count == 0)
            {
                CloseForm();
            }
        }
        protected virtual void PrintVoucher()
        { 
        
        }
        protected virtual bool ToolClick(string sKey)
        {
            bool bIsDoWork = true;
            switch (sKey)
            {
                case "mnuForward":
                    MoveNext();
                    break;
                case "mnuPrevious":
                    MovePrevious();
                    break;
                case "mnuNew":
                case "cteNew":
                    AddNewRow();
                    break;
                case "mnuEdit":
                case "cteEdit":
                    EditMode = Enumeration.EnumEditMode.Edit;
                    break;
                case "mnuDelete":
                case "cteDelete":
                    DeleteVoucher();
                    break;
                case "mnuRefesh":
                case "cteRefresh":
                    break;
                case "mnuSave":
                    SaveData();
                    break;
                case "mnuCancel":
                    CancelEdit();
                    break;
                case "mnuPrint":
                    PrintVoucher();
                    break;
                case "mnuExit":
                    CloseForm();
                    break;
                default:
                    bIsDoWork = false;
                    break;
            }
            return bIsDoWork;
        }

        /// <summary>
        /// Rebinding for dataobject
        /// </summary>
        protected virtual void BindingData()
        {
            if (MasterBindingSource == null) return;
            // gán datasource cho detail
            if(grdDetailList != null) grdDetailList.DataSource = oDetailBindingSource;
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
                  || oControl.GetType() == typeof(DevExpress.XtraEditors.DateEdit)
                    || oControl.GetType() == typeof(CDControl.CDGridLookUpEdit) || oControl.GetType() == typeof(CDControl.CDLookUpEnum) || oControl.GetType() == typeof(CDControl.CDLookUpEditData) || oControl.GetType() == typeof(DevExpress.XtraEditors.ButtonEdit))
                    oControl.DataBindings.Add("EditValue", oMasterBindingSource, oControl.Tag.ToString());
                else if (oControl.GetType() == typeof(ComboBox) || oControl.GetType() == typeof(CDControl.CDComboTree))
                    oControl.DataBindings.Add("SelectedValue", oMasterBindingSource, oControl.Tag.ToString());

            }
        }

        /// <summary>
        /// Định nghĩa lại các object trên form detail gồm binding source, grid
        /// </summary>
        protected virtual void RefineDataObject()
        { }
        #endregion

        protected virtual void InitCombo()
        { }
        #endregion

        #region Events

        private void FormDetailBase_Load(object sender, EventArgs e)
        {
            try
            {
                if (DesignMode) return;
                bar1.OptionsBar.AllowQuickCustomization = false;
                RefineDataObject();
                InitCombo();
                BindingData();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }
        /// <summary>
        /// Hỏi lưu chứng từ trước khi cất
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormDetailBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.DesignMode) return;
                if (EditMode != Enumeration.EnumEditMode.None)
                {
                    if (oDetailBindingSource != null && oDetailBindingSource.Count == 0)
                    {
                        DatasetBusiness.RejectChanges();
                        return;
                    }
                    else
                    {
                        DialogResult choose = CommonFunction.ShowYesNoCancelMessage(Properties.Resources.Confirm_WannaSaveRecord);
                        if (choose == DialogResult.Yes)
                        {
                            if (!SaveData())
                            {
                                e.Cancel = true;
                            }
                        }
                        // Nếu nhấn cancel thì ko làm gì cả
                        else if (choose == DialogResult.No)
                        {
                            DatasetBusiness.RejectChanges();
                        }
                        else if (choose == System.Windows.Forms.DialogResult.Cancel)
                        {
                            e.Cancel = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        
        private void FormDetailBase_Shown(object sender, EventArgs e)
        {
            try
            {
                if (this.DesignMode) return;
                if (grdDetailList!=null)                
                grdDetailList.ContextMenuStrip = cmsBase;
                LoadDefaultCode();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        /// <summary>
        /// Thêm dòng mới cho detail
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewDetail_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                if (this.DesignMode) return;
                AddNewRowDetail();                
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }
        /// <summary>
        /// Xóa dòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cteDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.DesignMode) return;
                DeleteDetailRow();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void bmBase_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (this.DesignMode) return;
                ToolClick(e.Item.Name);
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void cteNewRow_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.DesignMode) return;
                InsertNewDetailRow();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        #endregion
    }
}
