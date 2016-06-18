using eReview01.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eReview01.BL
{
    public class BLShift : BLBase
    {
        private string tableName = "shift";
        private DLShift shiftDAL = new DLShift();
        public BLShift()
        {
            DataAccessObject = shiftDAL;
            TableMasterName = tableName;
            shiftDAL.TableName = TableMasterName;
        }

        /// <summary>
        /// Tìm kiếm ca theo thời gian
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        public void SearchShiftByTime(DateTime fromDate, DateTime toDate)
        {
            shiftDAL.SearchShiftByTime(DataSource.Tables[TableMasterName], fromDate, toDate);
        }

        /// <summary>
        /// Tìm kiếm chi tiết ca theo thời gian
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        public void SearchShiftInfoByTimeAndType(DateTime fromDate, DateTime toDate, int ShiftType)
        {
            shiftDAL.SearchShiftInfoByTimeAndType(DataSource.Tables[TableMasterName], fromDate, toDate, ShiftType);
        }
    }
}
