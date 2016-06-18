using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eMonitor01
{
    class Enumeration
    {
        /// <summary>
        /// Quyền cho hệ thống soát vé
        /// </summary>
        public enum TollCollectionRole
        {
            /// <summary>
            /// Quyền giám sát
            /// </summary>
            MonitorRole = 1,
            /// <summary>
            /// Quyền hậu kiểm
            /// </summary>
            ReviewRole = 2,
            /// <summary>
            /// Quyền admin
            /// </summary>
            Administrator = 6
        }
        /// <summary>
        /// Kiểu dữ liệu trả về khi executeNonQuery
        /// </summary>
        public enum ExecuteNonqueryResultDataType
        {
            None = 0,
            Number = 1,
            Boolean = 2,
            Text = 3
        }

        /// <summary>
        /// Enum quản lý tên các enum khác
        /// </summary>
        public enum EnumType
        {
            None,
            EnumCustomerType,
            EnumRefType,
            EnumBindingType,
            EnumEditMode
        }

        public enum EnumCustomerType
        {
            /// <summary>
            /// Vừa là khách hàng vừa là nhà cung cấp
            /// </summary>
            All = 0,
            /// <summary>
            /// Khách hàng
            /// </summary>
            Customer = 1,
            /// <summary>
            /// Nhà cung cấp
            /// </summary>
            Supplier = 2
        }


        /// <summary>
        /// Chế độ sửa form
        /// </summary>
        public enum EnumEditMode
        {
            /// <summary>
            /// Chỉ xem
            /// </summary>
            None = 0,
            /// <summary>
            /// Thêm mới
            /// </summary>
            AddNew = 1,
            /// <summary>
            /// Sửa
            /// </summary>
            Edit = 2,
            /// <summary>
            /// Xóa, ít dùng, cứ thêm vào cho có
            /// </summary>
            Delete = 3,
            /// <summary>
            /// In
            /// </summary>
            Prinf = 4
        }

        /// <summary>
        /// Loại màn hình nghiệp vụ
        /// </summary>
        public enum EnumRefType
        {
            /// <summary>
            /// Không phải hóa đơn chứng từ, thường dành cho danh mục
            /// </summary>
            NoneVoucher = 0,
            /// <summary>
            /// Phiếu nhập
            /// </summary>
            InwardVoucher = 1,
            /// <summary>
            /// Phiếu xuất
            /// </summary>
            OutwardVoucher = 2,
            /// <summary>
            /// Phiếu thu
            /// </summary>
            ReceiptVoucher = 3,
            /// <summary>
            /// Phiếu chi
            /// </summary>
            ExpenseVoucher = 4
        }

        public enum EnumTableName
        {
            None,
            AccountingObject,
            AccountingObjectCategory,
            Department,
            Employee,
            INInwardOutward,
            INInwardOutwardDetail,
            InventoryItem,
            InventoryItemCategory,
            Stock
        }

        /// <summary>
        /// Cách binding vào control
        /// </summary>
        public enum EnumBindingType
        {
            None,
            Text,
            Value,
            Checked
        }

        /// <summary>
        /// Trả ra type khi truyền vào enum
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static System.Type GetEnumerationType(EnumType e)
        {

            return Type.GetType(e.GetType().DeclaringType.FullName + "+" + e.ToString());
        }
    }
}
