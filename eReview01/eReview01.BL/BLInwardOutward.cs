using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace eReview01.BL
{
    public class BLInwardOutward : BLBase
    {
        /// <summary>
        /// Hàm tạo cho trường hợp làm các thao tác không cần master detail đơn giản.
        /// </summary>
        public BLInwardOutward()
        {

        }
        public BLInwardOutward(string m_MasterTableName, string m_DetailTableName, DataSet m_Datasource)
            : base(m_MasterTableName, m_DetailTableName, m_Datasource)
        {

        }

        public override bool ValidateDataBeforeSave(CommonUI.Enumeration.EnumEditMode e = CommonUI.Enumeration.EnumEditMode.None)
        {
            bool bValid = base.ValidateDataBeforeSave(e);
            // Valid Số lượng tồn để cảnh báo khi save

            return bValid;
        }

        /// <summary>
        /// Check số hàng tồn
        /// </summary>
        /// <param name="InventoryItemID"></param>
        /// <param name="StockID"></param>
        /// <param name="Quantity"></param>
        /// <param name="FromDate"></param>
        /// <param name="ToDate"></param>
        /// <returns></returns>
        public int CheckInventoryItemInStock(int InventoryItemID, int StockID, int Quantity, DateTime FromDate, DateTime ToDate)
        {
            return new DL.DLInwardOutward().CheckInventoryItemInStock(InventoryItemID, StockID, Quantity, FromDate, ToDate);
        }
    }
}

