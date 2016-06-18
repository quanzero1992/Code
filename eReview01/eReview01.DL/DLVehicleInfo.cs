using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace eReview01.DL
{
    public class DLVehicleInfo : DLBase
    {
        /// <summary>
        /// Tìm kiếm ca trong khoảng thời gian
        /// </summary>
        /// <param name="tableSource"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        public void GetVehicleInfoByNumber(DataTable tableSource, string vehicleNumber)
        {
            ExecuteTypeParameterReader("proc_vehicle_info_GetByNumber", tableSource, vehicleNumber);
        }
    }
}
