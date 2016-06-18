using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace eReview01.DL
{
    public class DLShift : DLBase
    {
        /// <summary>
        /// Tìm kiếm ca trong khoảng thời gian
        /// </summary>
        /// <param name="tableSource"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        public void SearchShiftByTime(DataTable tableSource, DateTime fromDate, DateTime toDate)
        {
            ExecuteTypeParameterReader("proc_shift_SearchByTime", tableSource, fromDate, toDate);
        }

        /// <summary>
        /// Tìm kiếm ca trong khoảng thời gian
        /// </summary>
        /// <param name="tableSource"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        public void SearchShiftInfoByTimeAndType(DataTable tableSource, DateTime fromDate, DateTime toDate, int ShiftType)
        {
            ExecuteTypeParameterReader("proc_shift_info_SearchByTimeAndType", tableSource, fromDate, toDate, ShiftType);
        }
    }
}
