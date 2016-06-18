using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eReview01.DL
{
    public class SearchCarLocal
    {
        public int? VehType { get; set; }
        public string PlateNumber { get; set; }
        public string UserInput { get; set; }
        public DateTime? DateSign { get; set; }
        public string FullNameInPut { get; set; }
        public string OwnerCarName { get; set; }
        public string CMT { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }
        public string BillID { get; set; }
        public string PhoneNumber { get; set; }
        // them thong tin cua hieu luc va loai ve
        public DateTime? TICK_SOLD_BEGIN_DATE { get; set; }
        public DateTime? TICK_SOLD_END_DATE { get; set; }
        public int? TICK_SOLD_TYPE { get; set; }
    }
}
