using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eReview01.DL
{
    public class DLInwardOutward : DLBase
    {
        public int CheckInventoryItemInStock(int InventoryItemID, int StockID, int Quantity, DateTime FromDate , DateTime ToDate )
        {
            object dFromDate;
            object dToDate;
            if (FromDate.Year > 2000)
                dFromDate = FromDate;
            else
                dFromDate = DBNull.Value;
            if (ToDate.Year > 2000)
                dToDate = ToDate;
            else
                dToDate = DBNull.Value;
            return (int)ExecuteTypeParameterScalar("CheckOutStockInventoryItem", InventoryItemID, StockID, Quantity, dFromDate, dToDate);
        }
    }
}
