using eReview01.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eReview01.BL
{
    public class BLStandardVehicleInfo : BLBase
    {
        private DLStandardVehicleInfo svehDAL = new DLStandardVehicleInfo();
        public BLStandardVehicleInfo()
        {
            DataAccessObject = svehDAL;
            TableMasterName = "standard_vehicle_infor";
            svehDAL.TableName = TableMasterName;
        }

        public void GetStandardVehicleInfoByNumber(string vehNumber)
        {
            DataSource.Tables[TableMasterName].Clear();
            svehDAL.GetStandardVehicleInfoByNumber(DataSource.Tables[TableMasterName], vehNumber);
        }
    }
}
