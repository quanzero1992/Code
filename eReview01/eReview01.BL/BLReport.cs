using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using eReview01.DL;

namespace eReview01.BL
{
    public class BLReport : BLBase
    {
        private DLReport reportDAL = new DLReport();
        public BLReport(string reportTableName, DataSet dataSource)
        {
            DataAccessObject = reportDAL;
            DataAccessObject.TableName = reportTableName;
            base.DataSource = dataSource;
            TableMasterName = reportTableName;
        }
        /// <summary>
        /// Biên bản bàn giao ca của thu phí viên
        /// </summary>
        /// <param name="shiftInfoID"></param>
        public void GetChangeShiftForUserInfo(long shiftInfoID)
        {
            ((DLReport)DataAccessObject).GetChangeShiftForUserInfo(DataSource.Tables[TableMasterName], shiftInfoID);
        }

        /// <summary>
        /// Biên bản bàn giao ca của thu phí viên
        /// </summary>
        /// <param name="shiftInfoID"></param>
        public void GetChangeShiftSummary(long shiftID)
        {
            ((DLReport)DataAccessObject).GetChangeShiftSummary(DataSource.Tables[TableMasterName], shiftID);
        }

        /// <summary>
        /// Báo cáo đếm xe hàng năm
        /// </summary>
        /// <param name="shiftInfoID"></param>
        public void GetVehicleCountInYear(int year)
        {
            ((DLReport)DataAccessObject).GetVehicleCountInYear(DataSource.Tables[TableMasterName], year);
        }

        /// <summary>
        /// Báo cáo số thu hàng năm
        /// </summary>
        /// <param name="shiftInfoID"></param>
        public void GetBC8(int year)
        {
            ((DLReport)DataAccessObject).GetBC8(DataSource.Tables[TableMasterName], year);
        }

        /// <summary>
        /// Báo cáo BC4
        /// </summary>
        /// <param name="year"></param>
        public void GetBC4(DateTime fromDate, DateTime toDate, int laneInfoID)
        {
            ((DLReport)DataAccessObject).GetBC4(DataSource.Tables[TableMasterName], fromDate, toDate, laneInfoID);
        }
        /// <summary>
        /// Báo cáo BC10
        /// </summary>
        /// <param name="year"></param>
        public void GetBC10(DateTime fromDate, DateTime toDate, string userInfoID)
        {
            ((DLReport)DataAccessObject).GetBC10(DataSource.Tables[TableMasterName], fromDate, toDate, userInfoID);
        }
        /// <summary>
        /// Báo cáo BC7
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        public void GetBC7(DateTime fromDate, DateTime toDate)
        {
            ((DLReport)DataAccessObject).GetBC7(DataSource.Tables[TableMasterName], fromDate, toDate);
        }

        /// <summary>
        /// Báo cáo BC5
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        public void GetBC5(DateTime fromDate, DateTime toDate)
        {
            ((DLReport)DataAccessObject).GetBC5(DataSource.Tables[TableMasterName], fromDate, toDate);
        }

        /// <summary>
        /// Báo cáo BC6
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        public void GetBC6(DateTime fromDate, DateTime toDate)
        {
            ((DLReport)DataAccessObject).GetBC6(DataSource.Tables[TableMasterName], fromDate, toDate);
        }
        public void GetBC2(long shiftInfoID)
        {
            ((DLReport)DataAccessObject).GetBC2(DataSource.Tables[TableMasterName], shiftInfoID);
        }
        /// <summary>
        /// Báo cáo lưu lượng xe
        /// cuongtm 29-2-2016
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        public void GetVehicleCount(DateTime fromDate, DateTime toDate)
        {
            ((DLReport)DataAccessObject).GetVehicleCount(DataSource.Tables[TableMasterName], fromDate, toDate);
        }
        /// <summary>
        /// Báo cáo năm biểu 2c
        /// Quanvt 03/03/2016
        /// </summary>
        /// <param name="year"></param>
        public void GetBC2c(int year)
        {
            ((DLReport)DataAccessObject).GetBC2c(DataSource.Tables[TableMasterName], year);
        }
    }
}
