using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eReview01.DL;
using System.Data;

namespace eReview01.BL
{
    public class BLTransaction : BLBase
    {
        private string tableName = "tc_transaction";
        private DLTransaction transactionDAL = new DLTransaction();
        public BLTransaction()
        {
            DataAccessObject = transactionDAL;
            TableMasterName = tableName;
            transactionDAL.TableName = TableMasterName;
        }
        public BLTransaction(DataSet datasource)
        {
            DataAccessObject = transactionDAL;
            TableMasterName = tableName;
            DataSource = datasource;
        }
        public void GetTransactionSearch(DateTime fromDate, DateTime toDate, int tcType, int laneInfoID, string userInfoID, int ticketType, int vehType, string vehNumber, int errorType, int selectSuspect)
        {
            transactionDAL.GetTransactionSearch(DataSource.Tables[TableMasterName], fromDate, toDate, tcType, laneInfoID, userInfoID, ticketType, vehType, vehNumber, errorType, selectSuspect);
        }
        /// <summary>
        /// Lấy giao dịch theo số xe và thời gian
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="vehNumber"></param>
        public void GetTransactionByCarNumberAndTime(DateTime fromDate, DateTime toDate, string vehNumber, string transID)
        {
            transactionDAL.GetTransactionByCarNumberAndTime(DataSource.Tables[TableMasterName], fromDate, toDate, vehNumber, transID);
        }
    }
}
