using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eReview01.CommonUI
{
    public class Enumeration
    {
        public enum TcType
        {
            Turn = 1,
            Month = 2,
            AllCountry = 3,
            FreeOne = 4,
            FreeMany = 5,
            ETC = 10,
            InvalidPass = 99
        }
        public enum AccountingAction
        {
            nhập = 0,
            xuất = 1,
            bán = 2,
            hủy = 3,
            thu_hồi = 4,
            bán_bổ_sung = 5,
            tháng_quý = 6,
            xe_địa_phương = 7,
            hệ_thống = 99,
        }
        public enum ErrorType
        {
            /// <summary>
            /// Không có lỗi
            /// </summary>
            None = 0,
            /// <summary>
            /// 1 - nhân viên dùng sai thẻ.
            /// </summary>
            Error1 = 1,
            /// <summary>
            /// 2 - nhân viên không quẹt vé.
            /// </summary>
            Error2 = 2,
            /// <summary>
            /// 3 - hệ thống không trả về biển số xe qua.
            /// </summary>
            Error3 = 3,
            /// <summary>
            /// 4 - hệ thống trả về biển số xe không đúng.
            /// </summary>
            Error4 = 4,
            /// <summary>
            /// 5 - hệ thống không trả về hình ảnh.
            /// </summary>
            Error5 = 5,
            /// <summary>
            /// 6 - những lỗi khác.
            /// </summary>
            Error6 = 6,
            /// <summary>
            /// Là lỗi mà hệ thống tự tích thông qua việc so sánh sự khác nhau giữa 2 lần soát vé
            /// </summary>
            Error9 = 9,
            /// <summary>
            /// Giao dịch chưa xử lý lỗi cụ thể.
            /// </summary>
            Error99 = 99
        }

        /// <summary>
        /// Key db option
        /// </summary>
        public enum DBOptionKey
        {
            UnitName,
            StationName,
            TollCollectionChief,
            MonitorChief,
            AccountingChief,
            AccountingStaff
        }
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
            /// Kế toán vé
            /// </summary>
            AccountingRole = 5,
            /// <summary>
            /// Thu phi vien
            /// </summary>
            TicketStaff = 4
        }

        /// <summary>
        /// Hành động trên form
        /// </summary>
        public enum FormAction
        {
            xem = 0,
            thêm = 1,
            sửa = 2,
            xóa = 3,
            tích_lỗi = 4,
            đăng_nhập = 100,
            đăng_xuất = 101,
            thoát_chương_trình = 102
        }

        public enum eReview_Monitor
        {
            giám_sát = 0,
            hậu_kiểm = 1,
            hệ_thống = 99
        }

        public enum EnumReportPeriod
        {
            /// <summary>
            /// Hôm nay
            /// </summary>
            Today = -99,
            /// <summary>
            /// Hôm qua
            /// </summary>
            Yesterday = -1,
            /// <summary>
            /// Tuan nay
            /// </summary>
            ThisWeek = -2,
            /// <summary>
            /// Tuần trước
            /// </summary>
            LastWeek = -3,
            /// <summary>
            /// Tháng trước
            /// </summary>
            LastMonth = -4,
            /// <summary>
            /// Tháng này
            /// </summary>
            ThisMonth = 0,
            /// <summary>
            /// Tháng 1
            /// </summary>
            January = 1,
            /// <summary>
            /// Tháng 2
            /// </summary>
            February = 2,
            /// <summary>
            /// Tháng 3
            /// </summary>
            March = 3,
            /// <summary>
            /// Tháng 4
            /// </summary>
            April = 4,
            /// <summary>
            /// Tháng 5
            /// </summary>
            May = 5,
            /// <summary>
            /// Tháng 6
            /// </summary>
            June = 6,
            /// <summary>
            /// Tháng 7
            /// </summary>
            July = 7,
            /// <summary>
            /// Tháng 8
            /// </summary>
            August = 8,
            /// <summary>
            /// Tháng 9
            /// </summary>
            September = 9,
            /// <summary>
            /// Tháng 10
            /// </summary>
            October = 10,
            /// <summary>
            /// Tháng 11
            /// </summary>
            November = 11,
            /// <summary>
            /// Tháng 12
            /// </summary>
            December = 12,
            /// <summary>
            /// Quý 1
            /// </summary>
            QuarterOne = 101,
            /// <summary>
            /// Quý 2
            /// </summary>
            QuarterTwo = 102,
            /// <summary>
            /// Quý 3
            /// </summary>
            QuarterThree = 103,
            /// <summary>
            /// Quý 4
            /// </summary>
            QuarterFour = 104,
            /// <summary>
            /// Cả năm
            /// </summary>
            AllYear = 999,
            /// <summary>
            /// Tùy chọn
            /// </summary>
            Option = 9999
        }

        public enum AuthenSQLServerMode
        {
            /// <summary>
            /// Chế độ đăng nhập bằng quyền user của window
            /// </summary>
            WindowAuthen = 0,
            /// <summary>
            /// Chế độ đăng nhập bằng username và password
            /// </summary>
            UserRequire = 1
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
            EnumEditMode,
            EnumReportPeriod
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

        public enum EnumReportName
        {
            None,
            /// <summary>
            /// Biên bản giao ca của thu phí viên
            /// </summary>
            BC1,
            /// <summary>
            /// Báo cáo đếm xe trong ca
            /// </summary>
            BC2,
            /// <summary>
            /// Biên bản giao ca toàn trạm
            /// </summary>
            BC3,
            /// <summary>
            /// Ảnh chụp các trường hợp thông xe miễn phí và xe có vé toàn quốc
            /// </summary>
            BC4,
            /// <summary>
            /// Báo cáo tổng hợp số thu hàng tháng
            /// </summary>
            BC5,
            /// <summary>
            /// Bản ghi bán vé tháng/quý hàng tháng
            /// </summary>
            BC6,
            /// <summary>
            /// Báo cáo đếm xe hàng tháng
            /// </summary>
            BC7,
            /// <summary>
            /// Báo cáo tổng hợp số thu năm
            /// </summary>
            BC8,
            /// <summary>
            /// Báo cáo đếm xe hàng năm
            /// </summary>
            BC9,
            /// <summary>
            /// Báo cáo doanh số theo ngày
            /// </summary>
            DaySummaryAmount,
            /// <summary>
            /// Bảng kê bán vé của tổ trong ca
            /// </summary>
            VoucherSoldTicketInShift,
            /// <summary>
            /// Bảng kê bán vé tháng quý theo ngày
            /// </summary>
            VoucherSoldTicketInMonthAndQuarter,
            /// <summary>
            /// Phieu nop tien ve luot
            /// </summary>
            PaymentInShiftInfoTicketTurn,
            /// <summary>
            /// Bảng kê tồn vé lượt
            /// </summary>
            ClosingTicketTurn,
            /// <summary>
            /// Bảng kê tồn vé tháng/quý
            /// </summary>
            ClosingTicketMonth,
            /// <summary>
            /// Báo cáo bán vé lượt
            /// </summary>
            SoldTurn,
            /// <summary>
            /// Báo cáo bán vé và nộp tiền vé lượt
            /// </summary>
            SoldAndPaymentInshiftInfo,
            /// <summary>
            /// Báo cáo doanh thu theo từng nhân viên 1 ca
            /// </summary>
            SummaryAmountInShift,
            /// <summary>
            /// Báo cáo xem vé tồn trong kho tại thời điểm hiện tại
            /// </summary>
            ClosingTicket,
            /// <summary>
            /// Báo cáo lỗi nhân viên hàng tháng
            /// </summary>
            BC10,
            /// <summary>
            /// Báo cáo lưu lượng xe
            /// </summary>
            VehicleCount,
                 /// <summary>
            /// Báo cáo năm 2c
            /// </summary>
            BC2c,
            /// <summary>
            /// Báo cáo năm 2b
            /// </summary>
            BC2b
        }


    }
}
