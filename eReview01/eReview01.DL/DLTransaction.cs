using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace eReview01.DL
{
    public class DLTransaction : DLBase
    {
        /// <summary>
        /// Tìm kiếm giao dịch
        /// </summary>
        /// <param name="tableSource"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="laneInfoID"></param>
        /// <param name="userInfoID"></param>
        /// <param name="ticketType"></param>
        /// <param name="vehNumber"></param>
        public void GetTransactionSearch(DataTable tableSource, DateTime fromDate, DateTime toDate, int tcType, int laneInfoID, string userInfoID, int ticketType, int vehType, string vehNumber, int errorType, int selectSuspect)
        {
            ExecuteTypeParameterReader("proc_tc_transaction_Search", tableSource, fromDate, toDate, tcType, laneInfoID, userInfoID, ticketType, vehType, vehNumber, errorType, selectSuspect);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableSource"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="vehNumber"></param>
        public void GetTransactionByCarNumberAndTime(DataTable tableSource, DateTime fromDate, DateTime toDate, string vehNumber, string transID)
        {
          ExecuteTypeParameterReader("proc_tc_transaction_GetByCarNumberAndTime", tableSource, fromDate, toDate, vehNumber, transID);
        }
    }
}