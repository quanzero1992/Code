using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace eReview01.DL
{
    public class DLStandardVehicleInfo : DLBase
    {
        public void GetStandardVehicleInfoByNumber(DataTable tableSource, string vehicleNumber)
        {
            ExecuteTypeParameterReader("proc_standard_vehicle_info_GetByNumber", tableSource, vehicleNumber);
        }
    }
}
