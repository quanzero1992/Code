using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eReview01
{
    /// <summary>
    /// enum tương ứng với các record trong bảng TCOption.
    /// </summary>
    public enum TCOption
    {
        /// <summary>
        /// Trạm trưởng
        /// </summary>
        StationChief,
        /// <summary>
        /// Tên dự án thu phí
        /// </summary>
        TCProjectName,
        /// <summary>
        /// Tên nhà đầu tư, doanh nghiệp dự án
        /// </summary>
        BOTName,
        /// <summary>
        /// Địa điểm dự án thu phí
        /// </summary>
        PlaceOfTollGate,
        /// <summary>
        /// Tên trạm thu phí
        /// </summary>
        TollGateName
    }
}
