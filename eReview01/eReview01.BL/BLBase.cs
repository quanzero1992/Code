using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using MySql.Data.MySqlClient;
using eReview01.DL;

namespace eReview01.BL
{
    public class BLBase : IDisposable
    {
        #region "Declare"
        private string strTableMasterName;
        private string strTableDetailName;
        private string strMasterPrimarykey;
        private string strDetailPrimarykey;
        private DataSet dsDataSource;
        private DataRow drMasterRow;
        protected DLBase oDLBase = new DLBase();
        protected DLBase DataAccessObject;
        #endregion
        //private Entity.Enums.InvoiceType eInvoiceType = Entity.Enums.InvoiceType.None;
        #region "Property"

        //public Entity.Enums.InvoiceType InvoiceType
        //{
        //    get { return eInvoiceType; }
        //    set { eInvoiceType = value; }
        //}

        public DataRow MasterRow
        {
            get { return drMasterRow; }
            set { drMasterRow = value; }
        }

        public DataTable TableDetail
        {
            get { return dsDataSource.Tables[TableDetailName]; }
            set
            {
                dsDataSource.Tables[strTableDetailName].Clear();
                dsDataSource.Tables[strTableDetailName].Merge(value);
            }
        }

        public string TableMasterName
        {
            get { return strTableMasterName; }
            set
            {
                strTableMasterName = value;
                oDLBase.TableName = TableMasterName;
            }
        }


        public string TableDetailName
        {
            get { return strTableDetailName; }
            set { strTableDetailName = value; }
        }

        public DataSet DataSource
        {
            get { return dsDataSource; }
            set
            {
                dsDataSource = value;
                oDLBase.TableName = TableMasterName;
                if (!string.IsNullOrEmpty(strTableMasterName) && dsDataSource.Tables[strTableMasterName].PrimaryKey.Length > 0) strMasterPrimarykey = dsDataSource.Tables[strTableMasterName].PrimaryKey[0].ColumnName;
                if (!string.IsNullOrEmpty(strTableDetailName) && dsDataSource.Tables[strTableDetailName].PrimaryKey.Length > 0) strDetailPrimarykey = dsDataSource.Tables[strTableDetailName].PrimaryKey[0].ColumnName;
                //SetBusinessObject()
            }
        }
        #endregion
        #region "Contructor"
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (dsDataSource != null)
                {
                    dsDataSource.Dispose();
                    dsDataSource = null;
                }
                if (oDLBase != null)
                {
                    oDLBase.Dispose();
                    oDLBase = null;
                }
            }
        }
        /// <summary>
        /// Hàm tạo cho trường hợp làm các thao tác không cần master detail đơn giản.
        /// </summary>
        public BLBase()
        {
            dsDataSource = new DataSet();
            DataAccessObject = new DLBase();
        }

        public BLBase(string m_MasterTableName, string m_DetailTableName, DataSet m_Datasource)
        {
            Dispose(false);
            //oDLBase = new DL.DLBase();
            this.TableMasterName = m_MasterTableName;
            this.TableDetailName = m_DetailTableName;
            this.DataSource = m_Datasource;
        }
        #endregion
        #region "Method/Sub"

        /// <summary>
        /// Làm một số việc trước khi update
        /// </summary>
        /// <returns></returns>
        protected virtual bool PrepareUpdate(MySqlTransaction ts)
        {
            return true;
        }

        /// <summary>
        /// Làm một số việc trước khi insert
        /// </summary>
        /// <returns></returns>
        protected virtual bool PrepareInsert(MySqlTransaction ts)
        {
            return true;
        }

        protected virtual bool PrepareDelete(MySqlTransaction ts)
        {
            return true;
        }

        /// <summary>
        /// Goi thuc thi them mot so cong viec sau khi insert thanh cong
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        protected virtual bool CompleteInsert(MySqlTransaction ts)
        {
            return true;
        }

        /// <summary>
        /// Thuc thi mot so cong viec khi update thanh cong
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        protected virtual bool CompleteUpdate(MySqlTransaction ts)
        {
            return true;
        }

        protected virtual bool CompleteDelete(MySqlTransaction ts)
        {
            return true;
        }
        public static void SaveConnectionString(string connectionString)
        {
            ConnectionSession.ConnectionString = connectionString;
        }

        //public static List<SearchCarLocal> SearchCarLocal(string plateNumber)
        //{
        //    return DL.DLBase.li(plateNumber);
        //}
        public static List<SearchCarLocal> ListCarLocal()
        {
            return DL.DLBase.ListCarLocal();
        }

        public DataTable getDateMinImportTicket()
        {
            //oDLBase = new DLBase();
            return oDLBase.ExecuteDataTable("proc_getMin_Date_Ticket_Import");

        }
        /// <summary>
        /// Lấy danh sách user theo RoleID
        /// </summary>
        /// <param name="RoleId"></param>
        /// <returns></returns>
        public DataTable GetUsersByRole(int RoleId)
        {
            oDLBase = new DLBase();
            return oDLBase.ExecuteDataTable("proc_user_info_GetByRole", RoleId);
        }
        /// <summary>
        /// Tìm kiếm phiếu nhập
        /// </summary>
        /// <param name="code"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <param name="username"></param>
        public void searchTicketImport(string code, int month, int year, string username)
        {
            //oDLBase = new DLBase();
            oDLBase.TableName = "ticket_import";

            oDLBase.getsearchTicketImport(dsDataSource.Tables["ticket_import"], code, month, year, username);

        }
        public virtual bool checkDeleteImport(int ImportId)
        {
            oDLBase = new DLBase();
            return oDLBase.CheckExit("proc_CheckStauts_Ticket_Info_Delete_Ticket_Import", ImportId);
        }
        public bool UpdateData(DataTable dt)
        {
            return oDLBase.UpdateData(dt.DataSet, dt.TableName);
        }

        public void GetDetailByMasterID()
        {
            if (drMasterRow != null)
            {
                dsDataSource.Tables[strTableDetailName].Clear();
                oDLBase.GetDetailByID(dsDataSource, Convert.ToInt32(drMasterRow[strMasterPrimarykey].ToString()), TableDetailName, strMasterPrimarykey);
            }
        }

        /// <summary>
        /// Hàm check trùng mã
        /// Simple thì chỉ check với các mã là string
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        public virtual bool CheckUniqueExists(DataRow dr)
        {
            bool bResult = false;
            DL.DLBase oDL = new DL.DLBase();
            foreach (DataColumn col in dr.Table.Columns)
            {
                if (col.Unique && col.DataType == typeof(String))
                {
                    if (oDL.CheckUniqueExists(col.Table.TableName, col.ColumnName, dr[col.ColumnName].ToString(), dr[dr.Table.PrimaryKey[0].ColumnName]))
                    {
                        bResult = true;
                        break;
                    }
                }
            }
            return bResult;
        }

        /// <summary>
        /// Hàm check trùng mã
        /// Simple thì chỉ check với các mã là string
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        public virtual string CheckUniqueExistsReturnString(DataRow dr)
        {
            string strMessage = string.Empty;
            //DL.DLBase oDL = new DL.DLBase();
            //foreach (DataColumn col in dr.Table.Columns)
            //{
            //    if (col.Unique && col.DataType == typeof(String))
            //    {
            //        if (oDL.CheckUniqueExists(col.Table.TableName, col.ColumnName, dr[col.ColumnName].ToString(), dr[dr.Table.PrimaryKey[0].ColumnName]))
            //        {
            //            strMessage = string.Format(Properties.Resources.Warning_DupplicateCode, col.Caption);
            //            break;
            //        }
            //    }
            //}
            return strMessage;
        }
        /// <summary>
        /// ((Inser)t)MasterDetail
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public virtual bool Insert()
        {
            bool blnResult = false;
            using (var cnn = oDLBase.DataConnection)
            {
                if (cnn.State == ConnectionState.Closed) cnn.Open();
                MySqlTransaction ts = cnn.BeginTransaction();
                try
                {
                    int iMasterID;
                    string strMessageDupplicate = CheckUniqueExistsReturnString(MasterRow);
                    if (string.IsNullOrEmpty(strMessageDupplicate))
                    {
                        blnResult = PrepareInsert(ts);
                        if (int.TryParse(oDLBase.Insert(drMasterRow, ts).ToString(), out iMasterID) && iMasterID > 0)
                        {
                            bool orinalReadonly = drMasterRow.Table.Columns[strMasterPrimarykey].ReadOnly;
                            drMasterRow.Table.Columns[strMasterPrimarykey].ReadOnly = false;
                            drMasterRow[strMasterPrimarykey] = iMasterID;
                            drMasterRow.Table.Columns[strMasterPrimarykey].ReadOnly = orinalReadonly;
                            // Nếu có bảng Detail thì cập nhật bảng detail
                            if (TableDetail != null && TableDetail.Rows.Count > 0)
                            {
                                // cập nhật lại identity tự tăng
                                foreach (DataRow drDetail in TableDetail.Rows)
                                {
                                    drDetail[strMasterPrimarykey] = iMasterID;
                                }
                                oDLBase.UpdateData(TableDetail.DataSet, strTableDetailName, ts);
                                blnResult = true;
                            }
                            //else blnResult = true;
                            if (blnResult)
                            {
                                blnResult = CompleteInsert(ts);
                            }
                        }
                    }
                    else
                    {
                        throw new Exception(strMessageDupplicate);
                    }
                    if (!blnResult)
                    {
                        ts.Rollback();
                    }
                    else ts.Commit();
                }
                catch (Exception ex)
                {
                    ts.Rollback();
                    throw ex;
                }
                finally
                {
                    ts.Dispose();
                    cnn.Close();
                }

            }
            return blnResult;
        }

        public virtual bool ValidateDataBeforeSave(CommonUI.Enumeration.EnumEditMode e = CommonUI.Enumeration.EnumEditMode.None)
        {
            return true;
        }

        /// <summary>
        /// UpdateMasterDetail
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public virtual bool Update()
        {
            bool blnResult = false;
            MySqlTransaction ts = null;
            using (var cnn = oDLBase.DataConnection)
            {
                try
                {
                    if (cnn.State == ConnectionState.Closed) cnn.Open();
                    ts = cnn.BeginTransaction();
                    string strMessage = CheckUniqueExistsReturnString(MasterRow);
                    if (string.IsNullOrEmpty(strMessage))
                    {
                        blnResult = PrepareUpdate(ts);
                        if (oDLBase.update(drMasterRow, ts))
                        {
                            // nếu có detail thì cập nhật vào bảng detail
                            if (TableDetail != null && TableDetail.Rows.Count > 0)
                            {
                                oDLBase.UpdateData(TableDetail.DataSet, strTableDetailName, ts);
                                blnResult = true;
                            }
                            else
                                blnResult = true;
                        }
                        if (blnResult)
                        {
                            blnResult = CompleteUpdate(ts);
                        }
                        if (!blnResult) ts.Rollback();
                        else ts.Commit();
                    }
                    else
                    {
                        throw new Exception(strMessage);
                    }
                }
                catch (Exception ex)
                {
                    if (ts != null) ts.Rollback();
                    throw ex;

                }
                finally
                {
                    if (ts != null) ts.Dispose();
                    cnn.Close();
                }

            }
            return blnResult;
        }

        /// <summary>
        /// Load toàn bộ dữ liệu trong bảng
        /// </summary>
        public void GetAllData()
        {
            dsDataSource.Tables[TableMasterName].Rows.Clear();
            oDLBase.GetAllData(dsDataSource, TableMasterName);
        }

        /// <summary>
        /// Xóa dòng dữ liệu hiện tại
        /// </summary>
        /// <returns></returns>
        public bool Delete()
        {

            //if (oDLBase.Delete(Convert.ToInt32(MasterRow[strMasterPrimarykey].ToString())))
            //{
            //    DataSource.Tables[strTableMasterName].Rows.Remove(MasterRow);
            //    DataSource.AcceptChanges();
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            using (var cnn = oDLBase.DataConnection)
            {
                MySqlTransaction ts = null;
                bool blnResult = false;
                try
                {
                    if (cnn.State == ConnectionState.Closed) cnn.Open();
                    ts = cnn.BeginTransaction();
                    blnResult = PrepareDelete(ts);
                    if (blnResult && oDLBase.Delete(Convert.ToInt32(MasterRow[strMasterPrimarykey].ToString()), ts))
                    {
                        blnResult = CompleteDelete(ts);
                    }
                    else
                    {
                        blnResult = false;
                    }
                    if (blnResult)
                    {
                        ts.Commit();
                        DataSource.Tables[strTableMasterName].Rows.Remove(MasterRow);
                        DataSource.AcceptChanges();
                    }
                    else
                    {
                        ts.Rollback();
                    }
                }
                catch (Exception ex)
                {
                    ts.Rollback();
                    throw ex;
                }
                finally
                {
                    if (ts != null) ts.Dispose();
                    cnn.Close();
                }
                return blnResult;
            }
        }

        /// <summary>
        /// Load động dữ liệu theo table name
        /// </summary>
        /// <param name="tableSource"></param>
        /// <param name="whereCause"></param>
        /// <param name="orderBy"></param>
        public void GetAllDataByTableName(DataTable tableSource, string whereCause = "", string orderBy = "")
        {
            if (oDLBase == null) oDLBase = new DL.DLBase();
            oDLBase.GetAllDataByTableName(tableSource, whereCause, orderBy);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual DataTable getConfigByReport()
        {
            oDLBase = new DLBase();
            return oDLBase.ExecuteDataTable("proc_cf_station_by_Report");
        }

        public void getImportDetailForPrint(DataTable tableSource, int id)
        {
            oDLBase = new DLBase();
            oDLBase.ExecuteTypeParameterReader("proc_Import_Ticket_Prinf", tableSource, id);

        }

        public static string GetTCOption(string key)
        {
            return DLBase.GetTCOption(key);
        }
        #endregion
    }
}


