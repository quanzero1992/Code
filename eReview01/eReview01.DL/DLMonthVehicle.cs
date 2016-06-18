using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace eReview01.DL
{
    public class DLMonthVehicle:DLBase
    {

        /// <summary>
        /// Tra cứu thông tin vé tháng quý của xe theo biển số
        /// </summary>
        /// <param name="tableSource"></param>
        /// <param name="VehNum"></param>
        public void GetMonthVehicleInfoByNumber(DataTable tableSource, string VehNum)
        {
            ExecuteTypeParameterReader("proc_MonthVehicle_info_GetByNumber", tableSource, VehNum);
        }
        /// <summary>
        /// Tra cứu thông tin vé tháng quý của xe theo biển số
        /// </summary>
        /// <param name="tableSource"></param>
        /// <param name="VehNum"></param>
        public void GetMonthVehicleInfoByNumberOrBarcode(DataTable tableSource, string SearchText)
        {
            ExecuteTypeParameterReader("proc_MonthVehicle_info_GetByNumberOrBarcode", tableSource, SearchText);
        }
    }
}
