using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace eReview01.DL
{
    public class DLReport: DLBase
    {
        /// <summary>
        /// BIên bản bàn giao ca toàn trạm
        /// </summary>
        /// <param name="tableSource"></param>
        /// <param name="shiftInfoID"></param>
        public void GetChangeShiftSummary(DataTable tableSource, long shiftID)
        {
            ExecuteTypeParameterReader("proc_Report_ChangeShiftSummary", tableSource, shiftID);
        }

        /// <summary>
        /// BIên bản bàn giao ca của thu phí viên
        /// </summary>
        /// <param name="tableSource"></param>
        /// <param name="shiftInfoID"></param>
        public void GetChangeShiftForUserInfo(DataTable tableSource, long shiftInfoID)
        {
            ExecuteTypeParameterReader("proc_Report_ChangeShiftForUser", tableSource, shiftInfoID);
        }

        /// <summary>
        /// bc-9 báo cáo đếm xe hàng năm
        /// </summary>
        /// <param name="tableSource"></param>
        /// <param name="shiftInfoID"></param>
        /// <param name="year"></param>
        public void GetVehicleCountInYear(DataTable tableSource, int year)
        {
            ExecuteTypeParameterReader("proc_Report_CountVehicle", tableSource, year);
        }

        /// <summary>
        /// bc-8 báo cáo số thu hàng năm
        /// </summary>
        /// <param name="tableSource"></param>
        /// <param name="shiftInfoID"></param>
        /// <param name="year"></param>
        public void GetBC8(DataTable tableSource, int year)
        {
            ExecuteTypeParameterReader("proc_Report_BC8", tableSource, year);
        }

        /// <summary>
        /// Báo cáo bc4
        /// </summary>
        /// <param name="tableSource"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="laneInfoID"></param>
        public void GetBC4(DataTable tableSource, DateTime fromDate, DateTime toDate, int laneInfoID)
        {
            ExecuteTypeParameterReader("proc_Report_BC4", tableSource, fromDate, toDate, laneInfoID);
        }
        /// <summary>
        /// Báo cáo bc10
        /// </summary>
        /// <param name="tableSource"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="laneInfoID"></param>
        public void GetBC10(DataTable tableSource, DateTime fromDate, DateTime toDate, string userInfoID)
        {
            ExecuteTypeParameterReader("proc_Report_BC10", tableSource, fromDate, toDate, userInfoID);
        }
        /// <summary>
        /// Báo cáo BC7
        /// </summary>
        /// <param name="tableSource"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        public void GetBC7(DataTable tableSource, DateTime fromDate, DateTime toDate)
        {
            ExecuteTypeParameterReader("proc_Report_BC7", tableSource, fromDate, toDate);
        }

        /// <summary>
        /// Báo cáo BC5
        /// </summary>
        /// <param name="tableSource"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        public void GetBC5(DataTable tableSource, DateTime fromDate, DateTime toDate)
        {
            ExecuteTypeParameterReader("proc_Report_BC5", tableSource, fromDate, toDate);
        }

        /// <summary>
        /// Báo cáo BC6
        /// </summary>
        /// <param name="tableSource"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        public void GetBC6(DataTable tableSource, DateTime fromDate, DateTime toDate)
        {
            ExecuteTypeParameterReader("proc_Report_BC6", tableSource, fromDate, toDate);
        }

        /// <summary>
        /// Báo cáo BC2
        /// </summary>
        /// <param name="tableSource"></param>
        /// <param name="shiftInfoID"></param>
        public void GetBC2(DataTable tableSource, long shiftInfoID)
        {
            ExecuteTypeParameterReader("proc_Report_BC2", tableSource, shiftInfoID);
        }

        /// <summary>
        /// Báo cáo lưu lượng xe
        /// </summary>
        /// <param name="tableSource"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        public void GetVehicleCount(DataTable tableSource, DateTime fromDate, DateTime toDate)
        {
            ExecuteTypeParameterReader("proc_Report_VehicleCount", tableSource, fromDate, toDate);
        }

        public void GetBC2c(DataTable tableSource, int year)
        {
            ExecuteTypeParameterReader("proc_Report_Bieu2c", tableSource, year);
        }
    }
}
