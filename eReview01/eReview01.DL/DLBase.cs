using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.IO;
using System.Xml;
using System.Data;
namespace eReview01.DL
{
    public class DLBase : IDisposable
    {
        #region "Declare"
        bool disposed = false;
        private string sConnectionString = string.Empty;
        private const string strGetDetailByMasterID = "SELECT * from {0} WHERE {1} = {2}";

        private string strTablename;
        #endregion

        #region "Property"

        public string TableName
        {
            get { return strTablename; }
            //strProcInsert = "procInsert_" + strTablename
            set { strTablename = value; }
        }

        public MySqlConnection DataConnection
        {
            get
            {
                var cnn = new MySqlConnection(sConnectionString);
                cnn.Open();
                return cnn;
            }
        }


        public System.Data.Common.DbTransaction DaTaTransaction
        {
            get
            {
                if (DataConnection == null)
                {
                    return null;
                }
                return DataConnection.BeginTransaction();
            }
        }

        public string ProcGetAll
        {
            get { return "proc_" + strTablename + "_GetAll"; }
        }

        public string ProcInsert
        {
            get { return "proc_" + strTablename + "_Insert"; }
        }

        public string ProcUpdateByPK
        {
            get { return "proc_" + strTablename + "_UpdateByPK"; }
        }

        public string ProcDeleteByPK
        {
            get { return "proc_" + strTablename + "_DeleteByPK"; }
        }


        #endregion

        #region "sub/funtion"
        public static string GetTCOption(string key)
        {
            using (var cnn = new MySqlConnection(ConnectionSession.ConnectionString))
            {
                var cmd = new MySqlCommand(string.Format("select optionvalue from tc_option where optionID  = '{0}'", key), cnn);
                cnn.Open();
                cmd.CommandType = CommandType.Text;
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return result.ToString();
                }
                else
                {
                    return string.Empty;
                }
            }
        }
        // search car_local
        public static List<SearchCarLocal> ListCarLocal()
        {
            List<SearchCarLocal> ListLocalCar = new List<SearchCarLocal>();
            SearchCarLocal Car_local = null;
            using (var cnn = new MySqlConnection(ConnectionSession.ConnectionString))
            {
                try
                {
                    cnn.Open();
                    var cmd = new MySqlCommand(@"select * FROM (select b.* , a.TICK_SOLD_BEGIN_DATE, a.TICK_SOLD_END_DATE , a.TICK_SOLD_TYPE from ticket_sold a RIGHT OUTER JOIN local_car b
                            on a.TICK_SOLD_CAR_NUM = b.PlateNumber
                            ORDER BY date(a.TICK_SOLD_BEGIN_DATE) desc
                            ) as r GROUP BY r.PlateNumber", cnn);
                    var Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        Car_local = new SearchCarLocal();
                        var VehType = string.IsNullOrWhiteSpace(Reader["VehType"].ToString()) ? (int?)null : Int32.Parse(Reader["VehType"].ToString());
                        Car_local.VehType = VehType;
                        var DateSign = string.IsNullOrWhiteSpace(Reader["DateSign"].ToString()) ? (DateTime?)null : DateTime.Parse(Reader["DateSign"].ToString());
                        Car_local.DateSign = DateSign;
                        Car_local.OwnerCarName = Reader["OwnerCarName"].ToString();
                        Car_local.CMT = Reader["CMT"].ToString();
                        Car_local.PlateNumber = Reader["PlateNumber"].ToString();
                        Car_local.UserInput = Reader["UserInput"].ToString();
                        Car_local.Address = Reader["Address"].ToString();
                        Car_local.FullNameInPut = Reader["UserInput"].ToString();
                        Car_local.BillID = Reader["BillID"].ToString();
                        Car_local.Note = Reader["Note"].ToString();
                        Car_local.PhoneNumber = Reader["PhoneNumber"].ToString();
                        var TICK_SOLD_BEGIN_DATE = string.IsNullOrWhiteSpace(Reader["TICK_SOLD_BEGIN_DATE"].ToString()) ? (DateTime?)null : DateTime.Parse(Reader["TICK_SOLD_BEGIN_DATE"].ToString());
                        Car_local.TICK_SOLD_BEGIN_DATE = TICK_SOLD_BEGIN_DATE;
                        var TICK_SOLD_END_DATE = string.IsNullOrWhiteSpace(Reader["TICK_SOLD_END_DATE"].ToString()) ? (DateTime?)null : DateTime.Parse(Reader["TICK_SOLD_END_DATE"].ToString());
                        Car_local.TICK_SOLD_END_DATE = TICK_SOLD_END_DATE;
                        var TICK_SOLD_TYPE = string.IsNullOrWhiteSpace(Reader["TICK_SOLD_TYPE"].ToString()) ? (int?)null : Int32.Parse(Reader["TICK_SOLD_TYPE"].ToString());
                        Car_local.TICK_SOLD_TYPE = TICK_SOLD_TYPE;
                        ListLocalCar.Add(Car_local);
                    }
                    return ListLocalCar;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        public DLBase()
        {
            if (string.IsNullOrEmpty(ConnectionSession.ConnectionString))
            {
                string sDirectory = System.IO.Directory.GetCurrentDirectory();
                string sPath = Path.Combine(sDirectory, "ConnectionString");
                if (File.Exists(sPath))
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.LoadXml(CommonUI.Utils.DecryptString(File.ReadAllText(sPath)));
                    string serverName = xmlDoc.GetElementsByTagName("ServerName")[0].InnerText.Trim();
                    string port = xmlDoc.GetElementsByTagName("Port")[0].InnerText.Trim();
                    string databaseName = xmlDoc.GetElementsByTagName("DatabaseName")[0].InnerText.Trim();
                    string serverUserName = xmlDoc.GetElementsByTagName("ServerUserName")[0].InnerText.Trim();
                    string serverPassword = xmlDoc.GetElementsByTagName("ServerPassword")[0].InnerText.Trim();
                    sConnectionString = CommonUI.Utils.CreateConnectionString(serverName,
                        port, databaseName, false, serverUserName, serverPassword);
                }
                else
                {
                    sConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings[0].ConnectionString;
                }
                ConnectionSession.ConnectionString = sConnectionString;
                //sConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CD_Connection"].ConnectionString;
            }
            else
            {
                sConnectionString = ConnectionSession.ConnectionString;
                //sConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CD_Connection"].ConnectionString;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="StoreName"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool ExecuteTypeParameterNonQuery(string StoreName, params object[] paras)
        {
            try
            {
                using (MySqlConnection cnn = DataConnection)
                {
                    MySqlCommand cmd = new MySqlCommand(StoreName, cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlCommandBuilder.DeriveParameters(cmd);
                    int i = 0;
                    foreach (MySqlParameter Para in cmd.Parameters)
                    {
                        if (Para.Direction != ParameterDirection.ReturnValue)
                        {
                            if (paras[i] == null) paras[i] = DBNull.Value;
                            Para.Value = paras[i];
                            i = i + 1;
                        }
                    }

                    return (cmd.ExecuteNonQuery() > 0);
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="StoreName"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool ExecuteTypeParameterNonQuery(MySqlTransaction ts, string StoreName, params object[] paras)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(StoreName, ts.Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlCommandBuilder.DeriveParameters(cmd);
                int i = 0;
                foreach (MySqlParameter Para in cmd.Parameters)
                {
                    if (Para.Direction != ParameterDirection.ReturnValue)
                    {
                        if (paras[i] == null) paras[i] = DBNull.Value;
                        Para.Value = paras[i];
                        i = i + 1;
                    }
                }

                return (cmd.ExecuteNonQuery() > 0);
            }
            catch
            {
                return false;
            }
        }

        public object ExecuteTypeParameterScalar(string StoreName, params object[] paras)
        {
            using (var cnn = DataConnection)
            {
                var cmd = new MySqlCommand(StoreName, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlCommandBuilder.DeriveParameters(cmd);
                Int32 i = 0;
                foreach (MySqlParameter Para in cmd.Parameters)
                {
                    if (Para.Direction != ParameterDirection.ReturnValue)
                    {
                        if (paras[i] == null) paras[i] = DBNull.Value;
                        Para.Value = paras[i];
                        i = i + 1;
                    }

                }
                return cmd.ExecuteScalar();
            }
        }

        public void ExecuteTypeParameterReader(string StoreName, DataTable dtTable, params object[] paras)
        {
            using (var cnn = DataConnection)
            {
                var cmd = new MySqlCommand(StoreName, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlCommandBuilder.DeriveParameters(cmd);
                int i = 0;
                foreach (MySqlParameter Para in cmd.Parameters)
                {
                    if (Para.Direction != ParameterDirection.ReturnValue)
                    {
                        if (paras[i] == null) paras[i] = DBNull.Value;
                        Para.Value = paras[i];
                        i = i + 1;
                    }
                }
                Console.WriteLine(dtTable.TableName);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dtTable);
            }

        }
        public void ExecuteTypeParameterReaderCommandText(string StoreName, DataTable dtTable)
        {
            using (var cnn = DataConnection)
            {
                var cmd = new MySqlCommand(StoreName, cnn);
                cmd.CommandType = CommandType.Text;

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dtTable);
                }
            }

        }

        public void ExecuteTypeParameterReader(string StoreName, DataTable dtTable, MySqlTransaction ts, params object[] paras)
        {

            var cmd = new MySqlCommand(StoreName, ts.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Transaction = ts;
            MySqlCommandBuilder.DeriveParameters(cmd);
            int i = 0;
            foreach (MySqlParameter Para in cmd.Parameters)
            {
                if (Para.Direction != ParameterDirection.ReturnValue)
                {
                    if (paras[i] == null) paras[i] = DBNull.Value;
                    Para.Value = paras[i];
                    i = i + 1;
                }
            }
            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                da.Fill(dtTable);
            }
        }

        public object ExecuteTypeParameterScalar(string strStoreName, DataRow row)
        {
            using (var cnn = DataConnection)
            {
                var cmd = new MySqlCommand(strStoreName, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlCommandBuilder.DeriveParameters(cmd);
                foreach (MySqlParameter pr in cmd.Parameters)
                {
                    if (pr.Direction != ParameterDirection.ReturnValue)
                    {
                        if (row.Table.Columns.Contains(pr.ParameterName.Replace("@p", "")))
                        {
                            pr.Value = row[pr.ParameterName.Replace("@p", "")];
                        }
                    }
                }
                return cmd.ExecuteScalar();
            }
        }

        public bool ExecuteNonQueryParaTyped(string strStoreName, DataRow row)
        {
            using (var cnn = DataConnection)
            {
                var cmd = new MySqlCommand(strStoreName, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlCommandBuilder.DeriveParameters(cmd);
                foreach (MySqlParameter pr in cmd.Parameters)
                {
                    if (pr.Direction != ParameterDirection.ReturnValue)
                    {
                        if (row.Table.Columns.Contains(pr.ParameterName.Replace("@p", "")))
                        {
                            pr.Value = row[pr.ParameterName.Replace("@p", "")];
                        }
                    }
                }
                return Convert.ToInt32(cmd.ExecuteNonQuery()) > 0;
            }
        }

        public bool ExecuteNonQueryParaTyped(string strStoreName, DataRow row, MySqlTransaction ts)
        {
            var cmd = new MySqlCommand(strStoreName, ts.Connection);
            cmd.Transaction = ts;
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlCommandBuilder.DeriveParameters(cmd);
            foreach (MySqlParameter pr in cmd.Parameters)
            {
                if (pr.Direction != ParameterDirection.ReturnValue)
                {
                    if (row.Table.Columns.Contains(pr.ParameterName.Replace("@p", "")))
                    {
                        pr.Value = row[pr.ParameterName.Replace("@p", "")];
                    }
                }
            }
            return cmd.ExecuteNonQuery() > 0;
        }

        public object ExecuteTypeParameterScalar(string storeName, DataRow row, MySqlTransaction ts)
        {
            var cmd = new MySqlCommand(storeName, ts.Connection);
            cmd.Transaction = ts;
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlCommandBuilder.DeriveParameters(cmd);
            foreach (MySqlParameter pr in cmd.Parameters)
            {
                if (pr.Direction != ParameterDirection.ReturnValue)
                {
                    if (row.Table.Columns.Contains(pr.ParameterName.Replace("@p", "")))
                    {
                        pr.Value = row[pr.ParameterName.Replace("@p", "")];
                    }
                }
            }
            return cmd.ExecuteScalar();
        }
        public bool UpdateData(DataSet ds, string TableName)
        {
            using (MySqlConnection cnn = DataConnection)
            {
                MySqlCommand cmd = new MySqlCommand("Select * From " + TableName, cnn);
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    System.Data.Common.DbCommandBuilder cb = MySqlClientFactory.Instance.CreateCommandBuilder();
                    cb.DataAdapter = da;
                    cb.ConflictOption = ConflictOption.OverwriteChanges;
                    cb.QuotePrefix = "`";
                    cb.QuoteSuffix = "`";
                    return da.Update(ds, TableName) > 0;
                }
            }
        }

        public bool UpdateData(DataSet ds, string TableName, MySqlTransaction ts)
        {
            //   Dim da As DbDataAdapter = db.DbProviderFactory.CreateDataAdapter()
            var cmd = new MySqlCommand("Select * From " + TableName, ts.Connection);
            cmd.Transaction = ts;
            using (var da = new MySqlDataAdapter(cmd))
            {
                System.Data.Common.DbCommandBuilder cb = MySqlClientFactory.Instance.CreateCommandBuilder();
                cb.DataAdapter = da;
                cb.ConflictOption = ConflictOption.OverwriteChanges;
                cb.QuotePrefix = "`";
                cb.QuoteSuffix = "`";

                return da.Update(ds, TableName) > 0;
            }
        }

        public int Insert(DataRow row)
        {
            return Convert.ToInt32(ExecuteTypeParameterScalar(ProcInsert, row));
        }

        public int Insert(DataRow row, MySqlTransaction ts)
        {
            return Convert.ToInt32(ExecuteTypeParameterScalar(ProcInsert, row, ts));
        }

        public bool update(DataRow row, MySqlTransaction ts)
        {
            return Convert.ToInt32(ExecuteTypeParameterScalar(ProcUpdateByPK, row, ts)) > 0;
        }

        public bool update(DataRow row)
        {
            return ExecuteNonQueryParaTyped(ProcUpdateByPK, row);
        }


        public void GetDetailByID(DataSet ds, int MasterID, string tableName, string MasterColumn)
        {
            ExecuteTypeParameterReaderCommandText(string.Format(strGetDetailByMasterID, tableName, MasterColumn, MasterID), ds.Tables[tableName]);
        }

        public void GetAllData(DataSet ds, string TableName)
        {
            ExecuteTypeParameterReader(ProcGetAll, ds.Tables[TableName]);
        }

        public bool Delete(int MasterID)
        {
            return ExecuteTypeParameterNonQuery(ProcDeleteByPK, MasterID);
        }
        public bool Delete(int MasterID, MySqlTransaction ts)
        {
            return ExecuteTypeParameterNonQuery(ts, ProcDeleteByPK, MasterID);
        }


        public void GetAllDataByTableName(DataTable tableSource, string whereCause = "", string orderBy = "")
        {
            ExecuteTypeParameterReader("proc_GetAllDataByTableName", tableSource, tableSource.TableName, whereCause, orderBy);
        }

        /// <summary>
        /// Kiểm tra code trùng hay không
        /// trả về true là đã tồn tại mã như thế
        /// trả về false là không tồn tại mã đó
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="FieldName"></param>
        /// <returns></returns>
        public bool CheckUniqueExists(string tableName, string FieldName, string FieldValue, object ID = null)
        {
            return (int)ExecuteTypeParameterScalar("proc_CheckUniqueExists", tableName, FieldName, FieldValue, ID) > 0;
        }
        public bool CheckExit(string procName, int FieldValue)
        {
            return Convert.ToInt32(ExecuteTypeParameterScalar(procName, FieldValue)) > 0;
        }
        #endregion

        #region Phiếu nhập
        public DataTable ExecuteDataTable(string StoreName, params object[] paras)
        {
            DataTable tbl = new DataTable();
            using (MySql.Data.MySqlClient.MySqlConnection cnn = DataConnection)
            {
                //  cnn.Open();
                MySqlCommand cmd = new MySqlCommand(StoreName, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlCommandBuilder.DeriveParameters(cmd);
                int i = 0;
                foreach (MySqlParameter Para in cmd.Parameters)
                {
                    if (Para.Direction != ParameterDirection.ReturnValue)
                    {
                        Para.Value = paras[i];
                        i = i + 1;
                    }
                }
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(tbl);
                }

            }
            return tbl;
        }
        /// <summary>
        /// Tìm kiếm phiếu nhập
        /// </summary>
        /// <param name="tableSource"></param>
        /// <param name="code"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <param name="username"></param>
        public void getsearchTicketImport(DataTable tableSource, string code, int month, int year, string username)
        {
            ExecuteTypeParameterReader("proc_ticket_import_Search", tableSource, code, month, year, username);
        }

        #endregion
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern. 
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here. 
                //
            }

            // Free any unmanaged objects here. 
            //
            disposed = true;
        }
    }
}
