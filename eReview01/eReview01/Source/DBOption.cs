using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eReview01.Source
{
    public static class DBOption
    {
        /// <summary>
        /// Lãnh đạo ca
        /// </summary>
        public static string TollCollectionChief { get; set; }
        /// <summary>
        /// Tên đơn vị
        /// </summary>
        public static string UnitName { get; set; }
        /// <summary>
        /// Tên trạm
        /// </summary>
        public static string StationName { get; set; }
        /// <summary>
        /// Kế toán trưởng
        /// </summary>
        public static string AccountingChieft { get; set; }
        /// <summary>
        /// Kế toán viên
        /// </summary>
        public static string AccountingStaff { get; set; }
        /// <summary>
        /// Giám sát trưởng
        /// </summary>
        public static string MonitorChief { get; set; }
        /// <summary>
        /// Server video streaming playback
        /// </summary>
        public static string NVRServerID { get; set; }
        /// <summary>
        /// PORT Server video streaming playback
        /// </summary>
        public static uint? NVRServerPort { get; set; }
    }
}