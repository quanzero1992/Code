using eReview01.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eReview01.BL
{
    public class BLVehicleInfo : BLBase
    {
        private DLVehicleInfo vehDAL = new DLVehicleInfo();
        public BLVehicleInfo()
        {
            DataAccessObject = vehDAL;
            TableMasterName = "vehicle_info";
            vehDAL.TableName = TableMasterName;
        }

        /// <summary>
        /// Tìm kiếm ca theo thời gian
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        public void GetVehicleInfoByNumber(string vehNumber)
        {
            DataSource.Tables[TableMasterName].Clear();
            vehDAL.GetVehicleInfoByNumber(DataSource.Tables[TableMasterName], vehNumber);
        }
    }
}
