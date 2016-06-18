using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eReview01.DL;

namespace eReview01.BL
{
    public class BLMonthVehicle:BLBase
    {
        private DLMonthVehicle oDL = new DLMonthVehicle();
        public BLMonthVehicle()
        {
            DataAccessObject = oDL;
            TableMasterName = "ticket_bill";
            oDL.TableName = TableMasterName;
        }

        public void getInfoMonthVehicle(string VehNum)
        {
            DataSource.Tables[TableMasterName].Clear(); // lỗi ở đây
            oDL.GetMonthVehicleInfoByNumber(DataSource.Tables[TableMasterName], VehNum);
        }
        public void getInfoMonthVehicleByPlateNumberOrBarcode(string SearchText)
        {
            DataSource.Tables[TableMasterName].Clear(); // lỗi ở đây
            oDL.GetMonthVehicleInfoByNumberOrBarcode(DataSource.Tables[TableMasterName], SearchText);
        }
    }
}
